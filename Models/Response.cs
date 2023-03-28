namespace WorkerSalaryAPI.Models
{
    public class Response
    {
        public int statusCode { get; set; }
        public string statusDescription { get; set; }
        public List<Worker?> Worker { get; set; }
    }
}
