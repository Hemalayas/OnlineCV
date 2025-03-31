namespace OnlineCV.Models
{
    public class CVModel
    {
        public string FullName { get; set; }
        public string Title { get; set; }
        public ContactInfo Contact { get; set; }
        public string Summary { get; set; }
        public List<WorkExperience> WorkHistory { get; set; }
        public List<Education> Education { get; set; }
        public List<string> Skills { get; set; }
        public List<Project> Projects { get; set; }
    }

    public class ContactInfo
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string LinkedIn { get; set; }
        public string Website { get; set; }
    }

    public class WorkExperience
    {
        public string Company { get; set; }
        public string JobTitle { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Responsibilities { get; set; }
    }

    public class Education
    {
        public string Degree { get; set; }
        public string Institution { get; set; }
        public string Year { get; set; }
    }

    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string GitHubLink { get; set; }
    }
}
