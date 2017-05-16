using System;

namespace Ask.TechnicalTest.FrontEnd.ViewModels
{
    public class RegistrationViewModel
    {
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CountryId { get; set; }
        public DateTime Arrival { get; set; }
    }
}