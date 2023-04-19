using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace Portfolio.Controllers
{
    public class ProjectController : Controller
    {
        public async Task<IActionResult> Index()
        {
            Mongodb db = new Mongodb();
            List<Project> projects = await db.GetAllProjects();
            return View(projects);
        }

        public async Task<IActionResult> Details(string id)
        {
            Mongodb db = new Mongodb();
            Project project = await db.GetProjectsById(id); 
            return View(project);   

        }

        public async Task<IActionResult> Delete(string id)
        {
            Mongodb db = new Mongodb();
            var project = await db.GetProjectsById(id);
            return View(project);

        }
        [HttpPost]
        public async Task<IActionResult> DeleteProject(string id)
        {
            Mongodb db = new Mongodb();
            await db.DeleteProject(id);
            return Redirect("/Project");    

        }

    }
}