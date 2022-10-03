namespace MargheritaPub.Data
{
    public class Workorder
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public double Cost { get; set; }
        public bool IsDone { get; set; }
    }
}
