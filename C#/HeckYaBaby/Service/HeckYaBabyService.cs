using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Web;
using Service.Domain;
using Service.Infrastructure;

namespace Service
{
    public class HeckYaBabyService : IHeckYaBabyService
    {
        private readonly IRepository _repository;

        public HeckYaBabyService()
        {
            var context = new HeckYaBabyContext();
            _repository = new Repository(context);
        }

        public IEnumerable<Profile> GetProfile()
        {
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";

            return _repository
                .AllInstances<ProfileEntity>()
                .ToList()
                .Select(Map)
                .ToList();
        }

        public void Options()
        {
            WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Origin", "http://localhost:8989");
            WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Methods", "POST, PUT, DELETE");
            WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Header", "content-type");
        }

        public Profile UpdateProfile(string id, Profile profile)
        {
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";

            using (var unitOfWork = _repository.NewUnitOfWork())
            {
                _repository.Update<ProfileEntity>(
                    x => x.Id == profile.Id,
                    x => new ProfileEntity {
                        Name = profile.Name,
                        Address = profile.Address,
                        PhoneNumber = profile.PhoneNumber,
                        DateOfBirth = profile.DateOfBirth,
                        FriendCount = profile.FriendCount,
                    });

                unitOfWork.Commit();
            }

            WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.OK;

            return profile;
        }

        public Profile PostProfile(Profile profile)
        {
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";

            using (var unitOfWork = _repository.NewUnitOfWork())
            {
                var entity = new ProfileEntity {
                    Name = profile.Name,
                    Address = profile.Address,
                    PhoneNumber = profile.PhoneNumber,
                    DateOfBirth = profile.DateOfBirth,
                    FriendCount = profile.FriendCount
                };

                _repository.Add(entity);

                unitOfWork.Commit();


                return Map(entity);
            }
        }

        public void DeleteProfile(string id)
        {
            using (var unitOfWork = _repository.NewUnitOfWork())
            {
                var entityId = int.Parse(id);

                 _repository.Remove<ProfileEntity>(x => x.Id == entityId);

                unitOfWork.Commit();
            }

            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.NoContent;
        }

        private static Profile Map(ProfileEntity entity)
        {
            return new Profile
            {
                Id = entity.Id,
                Address = entity.Address,
                DateOfBirth = entity.DateOfBirth,
                Name = entity.Name,
                PhoneNumber = entity.PhoneNumber,
                FriendCount = entity.FriendCount
            };
        }
    }
}