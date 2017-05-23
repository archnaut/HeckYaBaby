using System;
using System.Runtime.Serialization;

namespace Service
{
    [DataContract]
    public class Profile
    {
        [DataMember(Name="DateOfBirth")]
        private string _dateOfBirth;
        
        [DataMember]
        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public int FriendCount { get; set; }

        [DataMember]
        public int  Id{get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            _dateOfBirth = DateOfBirth.ToString("o");
        }
        [OnDeserializing]
        private void OnDeserializing(StreamingContext context)
        {
            _dateOfBirth = DateTime.Parse("12/31/9999").ToString("o");
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            DateOfBirth = DateTime.Parse(_dateOfBirth);
        }
    }
}