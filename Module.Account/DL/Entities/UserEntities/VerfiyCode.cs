namespace Module.Account.DL.Entities.UserEntities
{
    internal class VerfiyCode : BaseDomain
    {
        public Guid UserId { get; set; }
        public int VirfeyCode { get; set; }
        public DateTime Date { get; set; }
        public string PhoneNumber { get; set; }
    }
}