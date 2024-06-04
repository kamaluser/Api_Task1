namespace Api_Task1.Dtos
{
    public class GroupPostDto
    {
        public string No { get; set; }
        public byte Limit { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
