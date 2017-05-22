Imports System.Runtime.Serialization

Namespace Presentation
    <DataContract>
    Public Class Profile
        
        <DataMember(Name := "DateOfBirth")>
        Private _dob As String

        <DataMember>
        Public Property Id As Integer

        <DataMember>
        Public Property Address As String

        Public Property DateOfBirth As Date

        <DataMember>
        Public Property Name As String

        <DataMember>
        Public Property PhoneNumber As String

        <DataMember>
        Public Property FriendCount As Integer

        <OnSerializing>
        Private Sub OnSerializing(context As StreamingContext)
            _dob = DateOfBirth.ToString("o")
        End Sub

        <OnDeserializing>
        Private Sub OnDeserializing( context As StreamingContext)
            _dob = Date.Parse("12/31/9999").ToString("o")
        End Sub

        <OnDeserialized>
        Private Sub OnDeserialized(context As StreamingContext)
            DateOfBirth = Date.Parse(_dateOfBirth)
        End Sub

    End Class

End NameSpace