using Microsoft.AspNetCore.Mvc;
using MongodbDatabase;

namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        public async Task<IActionResult> Index()

        {
            Mongodb db = new Mongodb();
            ViewBag.ContactSuccess = Request.Query["contact"] == "success";

            var contacts = await db.GetAllContacts();
            return View(contacts);

        }

        public async Task<IActionResult> PostContactAsync(Contact contact)
        {
            var db = new Mongodb();
            await db.SaveContact(contact);
            return Redirect("/Contact?contact=success");
        }
    }
}
