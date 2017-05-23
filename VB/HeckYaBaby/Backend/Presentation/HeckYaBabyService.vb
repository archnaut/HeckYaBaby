
Imports System.Net
Imports System.ServiceModel.Web
Imports Backend.Domain
Imports Backend.Infrastructure

Namespace Presentation

    Public Class HeckYaBabyService
        Implements IHeckYaBabyService

        Private const ApplicationJson as String = "application/json; charset=utf-8"
        Private ReadOnly _repository As IRepository
        Private ReadOnly _serviceContext As IServiceContext

        Public Sub New()
            Dim context = new DataContext()
            _repository = new Repository(context)
            _serviceContext = new ServiceContext()
        End Sub

        Public Sub Options() Implements IHeckYaBabyService.Options
            Try
                _serviceContext.AddHeader("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE")
                _serviceContext.AddHeader("Access-Control-Allow-Headers", "Content-Type")
            Catch
                Throw New WebFaultException(Of String)("Server encountered and error", HttpStatusCode.InternalServerError)
            End Try
        End Sub

        Public Function PostProfile(profile As Profile) As Profile Implements IHeckYaBabyService.PostProfile

            If profile Is Nothing Then
                Throw New WebFaultException(Of String)("Bad Request", HttpStatusCode.BadRequest)
            End If

            Dim response As Profile

            Try
                Using unitOfWork As IUnitOfWork = _repository.NewUnitOfWork()

                    Dim entity = Map(profile)

                    _repository.Add(entity)
                    unitOfWork.Commit()

                    response = Map(entity)

                End Using
            Catch
                Throw New WebFaultException(Of String)("Error creating profile.", HttpStatusCode.InternalServerError)
            End Try

            _serviceContext.ResponseContentType(ApplicationJson)
            _serviceContext.ResponseStatusCode(HttpStatusCode.Created)

            Return response

        End Function


        Public Function GetProfiles() As ProfilePage Implements IHeckYaBabyService.GetProfiles

            Try
                Dim pageSize = _serviceContext.PageSize
                Dim skip = _serviceContext.Skip

                Dim query = _repository.
                        AllInstances (Of ProfileEntity).
                        OrderBy(Function(x) x.Id).
                        Skip(skip)

                Dim profiles As IEnumerable(Of ProfileEntity)

                If pageSize > 0 Then
                    profiles = query.Take(pageSize).ToList()
                Else
                    profiles = query.ToList()
                End If

                _serviceContext.ResponseStatusCode(HttpStatusCode.OK)

                return New ProfilePage With{
                    .ItemCount = _repository.AllInstances (of ProfileEntity).Count(),
                    .Items = profiles.Select(Function(x) Map(x)).ToList()
                    }
            Catch
                Throw new WebFaultException(Of String)("Failed to get profiles", HttpStatusCode.InternalServerError)
            End Try

        End Function

        Public Function UpdateProfile(id As string, profile As Profile) As Profile _
            Implements IHeckYaBabyService.UpdateProfile

            If( id < 1 Or profile Is Nothing)
                Throw New WebFaultException(Of String)("Bad Request", HttpStatusCode.BadRequest)
            End If

            Try
                Using unitOfWork As IUnitOfWork = _repository.NewUnitOfWork()
            
                    Dim entity = Map(profile)
                
                    _repository.Update(entity)

                    unitOfWork.Commit()

                End Using

                _serviceContext.ResponseContentType(ApplicationJson)
                _serviceContext.ResponseStatusCode(HttpStatusCode.OK)

                Return profile
            Catch
                Throw new WebFaultException(Of String)("Failed to update profile", HttpStatusCode.InternalServerError)
            End Try
        
        End Function
 
        Public Sub DeleteProfile(id As String) Implements IHeckYaBabyService.DeleteProfile

            If(id < 1)
                Throw new WebFaultException(Of String)("Bad Request", HttpStatusCode.BadRequest)
            End If

            Try
                Using unitOfWork As IUnitOfWork = _repository.NewUnitOfWork()

                    Dim entityId = Integer.Parse(id)

                    _repository.Remove (Of ProfileEntity)(Function(x) x.Id = entityId)

                    unitOfWork.Commit()

                End Using

                _serviceContext.ResponseStatusCode(HttpStatusCode.NoContent)
            Catch
                Throw new WebFaultException(Of String)("Failed to delete profile", HttpStatusCode.InternalServerError)
            End Try

        End Sub

        Private Shared Function Map(profile As Profile) As ProfileEntity
            return New ProfileEntity With{
                .Id = profile.Id,
                .Address = profile.Address,
                .DateOfBirth = profile.DateOfBirth,
                .Name = profile.Name,
                .PhoneNumber = profile.PhoneNumber,
                .FriendCount = profile.FriendCount,
                .Active = profile.Active
                }
 
        End Function

        Private Shared Function Map(entity As ProfileEntity) As Profile

            return New Profile With{
                .Id = entity.Id,
                .Address = entity.Address,
                .DateOfBirth = entity.DateOfBirth,
                .Name = entity.Name,
                .PhoneNumber = entity.PhoneNumber,
                .FriendCount = entity.FriendCount,
                .Active = entity.Active
                }

        End Function
    End Class
End NameSpace