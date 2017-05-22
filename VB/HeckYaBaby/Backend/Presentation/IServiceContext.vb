Imports System.Net

Public Interface IServiceContext
    Sub ResponseStatusCode(statusCode As HttpStatusCode)
    Sub ResponseContentType(type As String)
    ReadOnly Property Page As Integer
    ReadOnly Property PageSize As Integer
    ReadOnly Property Skip As Integer
End Interface