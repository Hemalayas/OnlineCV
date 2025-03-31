using Microsoft.AspNetCore.Mvc;
using OnlineCV.Models;

namespace OnlineCV.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var myCV = new CVModel
            {
                FullName = "Hemal Kanjee",
                Title = "Aspiring Software Developer",
                Contact = new ContactInfo
                {
                    Email = "hemalkanjee03@gmail.com.com",
                    Phone = "123-456-7890",
                    Location = "Johannesburg , South Africa",
                    LinkedIn = "https://linkedin.com/in/hemalkanjee",
                    Website = "https://Example.dev"
                },
                Summary = "Motivated software developer with strong foundations in C#, .NET, and web technologies.",
                WorkHistory = new List<WorkExperience>
                {
                    new WorkExperience
                    {
                        Company = "Example",
                        JobTitle = "Junior Developer Intern",
                        StartDate = "Jan 2023",
                        EndDate = "Dec 2023",
                        Responsibilities = "Built internal tools using ASP.NET MVC and SQL. Assisted in debugging and maintaining existing codebases."
                    }
                },
                Education = new List<Education>
                {
                    new Education
                    {
                        Degree = "Diploma in Software Development",
                        Institution = "IIE Varsity College",
                        Year = "2022-2025"
                    }
                },
                Skills = new List<string>
                {
                    "C#", ".NET Core", "ASP.NET MVC", "HTML/CSS", "JavaScript", "SQL", "Git"
                },
                Projects = new List<Project>
                {
                    new Project
                    {
                        Name = "Personal Portfolio Website",
                        Description = "A responsive web portfolio to showcase my work and skills.",
                        GitHubLink = "https://github.com/example/portfolio"
                    }
                }
            };

            return View(myCV);
        }
    }
}
