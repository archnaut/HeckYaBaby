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
    End Class

End NameSpace