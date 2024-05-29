namespace NeighbourComplaintRegistrationSystem.Models
{
    public class Complaint
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Category Category { get; set; }
        public string ComplaintDescription { get; set; }
        public string SourceAddress { get; set; }
        public DateTime Date { get; set; }
        public Status Status { get; set; }

    }

    public enum Status
    { pending, active, resolved, canceled }
    public enum Category
    { animals, children, maintenance, parking }
}
