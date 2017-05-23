using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Service
{
    [ServiceContract]
    public interface IHeckYaBabyService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Profile", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<Profile> GetProfile();

        [OperationContract]
        [WebInvoke(Method = "OPTIONS", UriTemplate = "*")]
        void Options();

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/Profile/{id}", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Json)]
        Profile UpdateProfile(string id, Profile profile);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Profile", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Json)]
        Profile PostProfile(Profile profile);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/Profile/{id}", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Json)]
        void DeleteProfile(string id);
    }
}
