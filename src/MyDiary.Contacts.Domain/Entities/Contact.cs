using System;

namespace MyDiary.Contacts.Domain.Entities
{
    public class Contact 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int CountryCode { get; set; }
        public int MobileNo { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DOB { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PinCode { get; set; }
        public string Country { get; set; }
        public string FaceBookProfileLink { get; set; }
        public string LinkedInProfileLink { get; set; }
    }
}
