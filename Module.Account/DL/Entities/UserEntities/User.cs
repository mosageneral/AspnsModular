namespace Module.Account.DL.Entities.UserEntites
{
    internal class User : BaseDomain
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public Guid? CityId { get; set; }
        public City City { get; set; }
        public string UserType { get; set; }
        public Guid? VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }
}