using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace asp_webpage.Pages
{
    public class RespModel : PageModel
    {
        private readonly ILogger<RespModel> _logger;

        public RespModel(ILogger<RespModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
