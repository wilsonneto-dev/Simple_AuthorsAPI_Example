using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldAPI
{
    class SocialData
    {
        public string Social { get; set; }
        public string Link { get; set; }
    }
    class AuthorCard
    {
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public List<string> tags { get; set; }
        public List<SocialData> Socials { get; set; }
        public string Photo { get; set; }
        public bool Online { get; set; }
    }

    [ApiController]
    [Route("/api/hello")]
    public class CreatorsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Hello()
        {
            var Renato = new AuthorCard()
            {
                DisplayName = "renatogroffe",
                Description = "Microsoft Most Valuable Professional (MVP), Multi-Plataform Technical Audience Contributor (MTAC), Software Engineer, Technical Writer and Speaker",
                Online = true,
                Photo = "https://avatars.githubusercontent.com/u/8309296?v=4",
                tags = new List<string>() { ".Net", "Azure", "DevOps", "Tudo mais..." }
            };

            var Milton = new AuthorCard()
            {
                DisplayName = "miltoncamara",
                Description = "Microsoft MVP, MCP & MCSA, Community Leader & Speaker, Cloud & DevOps Consultan",
                Online = true,
                Photo = "https://avatars.githubusercontent.com/u/382444?v=4",
                tags = new List<string>() { ".Net", "Azure", "DevOps", "Tudo mais..." }
            };

            return Ok(new List<AuthorCard>() { 
                Renato, Milton
            });
        }
    }
}
