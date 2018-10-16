using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Pick_em.Lib.Models;

namespace Pick_em.Web.Pages
{
    public class LeagueViewModel : PageModel
    {
        private ILogger logger { get; }

        public LeagueViewModel(
            ILogger<LeagueViewModel> givenLogger
        )
        {
            this.logger = givenLogger;
        }

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
            this.logger.LogTrace($"Creating league with\n\tName={LeagueModel.Name}, Sport={LeagueModel.Sport}, Location={LeagueModel.Location}");

            return RedirectToPage("/League/Index");
        }
    }
}