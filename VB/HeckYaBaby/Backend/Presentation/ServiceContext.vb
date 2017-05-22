Imports System.Net
Imports System.ServiceModel.Web

Namespace Presentation

    Public Class ServiceContext
        Implements IServiceContext

        Public Sub ResponseStatusCode(statusCode As HttpStatusCode) Implements IServiceContext.ResponseStatusCode
            WebOperationContext.Current.OutgoingResponse.StatusCode = statusCode
        End Sub

        Public Sub ResponseContentType(type As String) Implements IServiceContext.ResponseContentType
            WebOperationContext.Current.OutgoingResponse.ContentType = type 
        End Sub

        Public ReadOnly Property Page As Integer Implements IServiceContext.Page
            Get
                Return ParameterValue(Of Integer)("page")
            End Get
        End Property

        Public ReadOnly Property PageSize As Integer Implements IServiceContext.PageSize
            Get
                Return ParameterValue(Of Integer)("pageSize")
            End Get
        End Property

        Public ReadOnly Property Skip As Integer Implements IServiceContext.Skip
            Get
                Return ParameterValue(Of Integer)("skip")
            End Get
        End Property

        Private Function ParameterValue(Of T)(name As String) As T

            Dim value = WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters(name)

            If String.IsNullOrEmpty(value) Then
                Return CType(Nothing, T)
            End If

            Return Convert.ChangeType(value, GetType(T))

        End Function
    End Class

End NameSpace