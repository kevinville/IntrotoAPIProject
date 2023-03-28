namespace WorkerSalaryAPI.Models
{
    public class Worker
    {
        public int WorkerId { get; set; }
        public string WorkerName { get; set; }
        public int Age { get; set; }
        public string JobTitle { get; set; } 
        public float CurrentPay { get; set; }
        public PublicInfo PublicInfo { get; set; }
    }
}
