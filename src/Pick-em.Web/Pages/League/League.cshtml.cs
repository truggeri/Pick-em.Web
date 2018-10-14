using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pick_em.Lib.Models;

namespace Pick_em.Web.Pages
{
    public class LeagueViewModel : PageModel
    {
        [BindProperty]
        public LeagueModel LeagueModel { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Console.WriteLine($"Creating league with\n\tName={LeagueModel.Name}");
            System.Console.WriteLine($"\tLocation={LeagueModel.Location}");
            System.Console.WriteLine($"\tSport={LeagueModel.Sport}");

            return RedirectToPage("/League/Index");
        }
    }
}