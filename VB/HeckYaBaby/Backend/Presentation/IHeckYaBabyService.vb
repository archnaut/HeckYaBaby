Imports System.ServiceModel
Imports System.ServiceModel.Web

Namespace Presentation

    <ServiceContract>
    Friend Interface IHeckYaBabyService

        <OperationContract>
        <WebInvoke(Method:="OPTIONS", UriTemplate:="*")>
        Sub Options()

        <OperationContract>
        <WebInvoke(Method := "POST", UriTemplate := "/Profile", RequestFormat := WebMessageFormat.Xml, ResponseFormat := WebMessageFormat.Json)>
        Function PostProfile(profile As Profile) As Profile 

        <OperationContract>
        <WebInvoke(Method := "GET", UriTemplate := "/Profile", ResponseFormat := WebMessageFormat.Json)>
        Function GetProfiles() As ProfilePage

        <OperationContract>
        <WebInvoke(Method := "PUT", UriTemplate := "/Profile/{id}", RequestFormat := WebMessageFormat.Xml, ResponseFormat := WebMessageFormat.Json)>
        Function UpdateProfile(id As string, profile As Profile) As Profile 

        <OperationContract>
        <WebInvoke(Method := "DELETE", UriTemplate := "/Profile/{id}", RequestFormat := WebMessageFormat.Xml, ResponseFormat := WebMessageFormat.Json)>
        Sub DeleteProfile(id As String)

    End Interface

End NameSpace