using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace github_actions_test.Pages
{

    public class CommitInformation
    {
        public required string Branch { get; set; }
        public required string CommitHash { get; set; }
    }


    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public IndexModel(IConfiguration configuration, ILogger<IndexModel> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public CommitInformation? CommitInfo { get; private set; }

        public void OnGet()
        {
         
          CommitInfo = _configuration.GetSection("CommitInformation").Get<CommitInformation>();
           
            
        }
        private readonly ILogger<IndexModel> _logger;

       
    }
}
