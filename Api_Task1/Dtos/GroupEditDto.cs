namespace Api_Task1.Dtos
{
    public class GroupEditDto
    {
        public string No { get; set; }
        public byte Limit { get; set; }
        public DateTime ModifiedAt { get; set; } = DateTime.Now;
    }
}
