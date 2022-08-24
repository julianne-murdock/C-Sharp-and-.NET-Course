﻿using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChallengeSubmission.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            DateTime localDate = DateTime.Now;
            ViewData["TimeStamp"] = localDate;


        }
    }
}