using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestForGitHub.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        // Test update Privacy page
        public void OnGet()
        {
            
            _logger.LogInformation("GET request received on Privacy Page at {Time}", DateTime.Now);

        }
    }

}
