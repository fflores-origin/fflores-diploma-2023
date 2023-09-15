namespace PD.Entities
{
    public class Log : BaseEntity
    {
        public int Level { get; set; }
        public string Message { get; set; }
    }
}