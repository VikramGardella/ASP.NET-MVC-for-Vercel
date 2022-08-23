using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace asp_webpage.Pages
{
    public class HandbotModel : PageModel
    {
        private readonly ILogger<HandbotModel> _logger;

        public HandbotModel(ILogger<HandbotModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
