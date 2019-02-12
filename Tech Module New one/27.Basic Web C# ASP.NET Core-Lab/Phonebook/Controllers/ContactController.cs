using Microsoft.AspNetCore.Mvc;
using Phonebook.Data;
using Phonebook.Data.Models;

namespace Phonebook.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Name and number are required!";
            }

            else
            {
                DataAccess.Contacts.Add(contact);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
