using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using Amazon.Models;

namespace Amazon.Controllers
{
    public class BoekController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Aantal(string auteur)
        {
            int aantal = Boek.Boeken.Where(b => b.auteur == auteur).Count();
            ViewData["auteur"] = auteur;
            ViewData["aantal"] = aantal;
            return View();
        }

        public IActionResult Genre(string id)
        {
            string message;
            try {
                string genre = Boek.Boeken.Where(b => b.isbn == id).Single().genre;
                message = $"Het boek met de isbn: {id} heeft de genre: {genre}."; 
            } 
            catch {
                message = "Er bestaat geen boek met het isbn: " + id;
            }

            ViewData["message"] = message;
            return View();
        }

        public IActionResult ZoekAuteur(string id)
        {
            List<string> model = Boek.Boeken.Where(b => b.auteur.Substring(0,1).Equals(id.ToUpper()))
                                            .Select(b => b.auteur).Distinct().ToList();
            ViewData["letter"] = id;

            return View(model);
        }
    }
}