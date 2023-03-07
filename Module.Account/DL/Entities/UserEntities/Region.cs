namespace Module.Account.DL.Entities.UserEntites
{
    internal class Region : BaseDomain
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public Guid CountryId { get; set; }
        public Country Country { get; set; }
    }
}