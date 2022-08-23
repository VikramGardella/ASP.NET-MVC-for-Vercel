using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace asp_webpage.Pages
{
    public class BrakeToolModel : PageModel
    {
        private readonly ILogger<BrakeToolModel> _logger;

        public BrakeToolModel(ILogger<BrakeToolModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
