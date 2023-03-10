namespace MyBoards.Entities
{
    public class WorkItem
    {
        public string State { get; set; }
        public string Area { get; set; }
        public string IterationPath { get; set; }
        public int Priority { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double Efford { get; set; }
        public string  Activity { get; set; }
        public float RemaningWork { get; set; }
        public string Type { get; set; }
    }
}
