using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace asp_webpage.Pages
{
    public class SpiderbotModel : PageModel
    {
        private readonly ILogger<SpiderbotModel> _logger;

        public SpiderbotModel(ILogger<SpiderbotModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
