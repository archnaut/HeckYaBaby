Imports System.Net

Public Interface IServiceContext
   Sub ResponseStatusCode(statusCode As HttpStatusCode)
   Sub ResponseContentType(type As String)
End Interface