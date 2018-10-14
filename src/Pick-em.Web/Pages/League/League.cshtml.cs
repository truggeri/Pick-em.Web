using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pick_em.Lib.Models;

namespace Pick_em.Web.Pages
{
    public class LeagueViewModel : PageModel
    {
        public string Name { get; set; }

        public LeagueModel Model { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/League/Index");
        }
    }
}