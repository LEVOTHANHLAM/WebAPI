namespace Data.Models
{
    public class Banking
    {
        public Guid Id { get; set; }
        public string? Code { get; set; }
        public string? Type { get; set; }
        public string? Cmt { get; set; }
        public DateTime? CreatAt { get; set; }
        public decimal? Amount { get; set; }
        public Guid? idSinhVien { get; set; }
    }
}