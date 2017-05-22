
Imports System.Net
Imports System.ServiceModel.Web
Imports Backend.Domain
Imports Backend.Infrastructure
Imports Backend.Presentation

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

        WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE")
        WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Headers", "Content-Type")

    End Sub

    Public Function PostProfile(profile As Profile) As Profile Implements IHeckYaBabyService.PostProfile

        _serviceContext.ResponseContentType(ApplicationJson)

        Using unitOfWork As IUnitOfWork = _repository.NewUnitOfWork()

            Dim entity = new ProfileEntity With {
                    .Name = profile.Name,
                    .Address = profile.Address,
                    .PhoneNumber = profile.PhoneNumber,
                    .DateOfBirth = profile.DateOfBirth,
                    .FriendCount = profile.FriendCount
                    }

            _repository.Add(entity)

            unitOfWork.Commit()


            return Map(entity)
        End Using

    End Function


    Public Function GetProfile() As IEnumerable(Of Profile) Implements IHeckYaBabyService.GetProfile

        _serviceContext.ResponseStatusCode(HttpStatusCode.OK)

        Return _repository.
            AllInstances(Of ProfileEntity).
            ToList().
            Select(Function(x) Map(x)).
            ToList()

    End Function

    Public Function UpdateProfile(id As string, profile As Profile) As Profile _
        Implements IHeckYaBabyService.UpdateProfile


        Using unitOfWork As IUnitOfWork = _repository.NewUnitOfWork()
        
            Dim entity = Map(profile)
            
            _repository.Update(entity)

            unitOfWork.Commit()

        End Using

        _serviceContext.ResponseContentType(ApplicationJson)
        _serviceContext.ResponseStatusCode(HttpStatusCode.OK)
        Return profile
    End Function
 
    Public Sub DeleteProfile(id As String) Implements IHeckYaBabyService.DeleteProfile

        Using unitOfWork As IUnitOfWork = _repository.NewUnitOfWork()

            Dim entityId = Integer.Parse(id)

            _repository.Remove (Of ProfileEntity)(Function(x) x.Id = entityId)

            unitOfWork.Commit()

        End Using

        _serviceContext.ResponseContentType(ApplicationJson)
        _serviceContext.ResponseStatusCode(HttpStatusCode.OK)

    End Sub

    Private Shared Function Map(profile As Profile) As ProfileEntity
        return New ProfileEntity With{
            .Id = profile.Id,
            .Address = profile.Address,
            .DateOfBirth = profile.DateOfBirth,
            .Name = profile.Name,
            .PhoneNumber = profile.PhoneNumber,
            .FriendCount = profile.FriendCount
        }
 
    End Function

    Private Shared Function Map(entity As ProfileEntity) As Profile

        return New Profile With{
            .Id = entity.Id,
            .Address = entity.Address,
            .DateOfBirth = entity.DateOfBirth,
            .Name = entity.Name,
            .PhoneNumber = entity.PhoneNumber,
            .FriendCount = entity.FriendCount
        }

    End Function
End Class