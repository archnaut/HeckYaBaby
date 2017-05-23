using System;

namespace Service.Domain
{
    public class ProfileEntity : IAuditable
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }        
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int FriendCount { get; set; }
        public DateTime RowDate { get; set; }
        public string RowStatus { get; set; }
    }
}