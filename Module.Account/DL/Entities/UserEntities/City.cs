namespace Module.Account.DL.Entities.UserEntites
{
    internal class City : BaseDomain
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public Guid RegionId { get; set; }
        public Region Region { get; set; }
    }
}