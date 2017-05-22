Namespace Domain
    Public Class ProfileEntity 
        Implements IAuditable

        Public Property Id As Integer
        Public Property Address As String
        Public Property DateOfBirth As Date
        Public Property FriendCount As Integer
        Public Property Name As String
        Public Property PhoneNumber As String
        Public Property RowDate As Date Implements IAuditable.RowDate
        Public Property RowStatus As String Implements IAuditable.RowStatus

    End Class
End NameSpace