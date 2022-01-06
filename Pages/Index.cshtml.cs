using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kubeApp.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		protected readonly IConfiguration _configuration;


		public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
		{
			_logger = logger;
			_configuration = configuration;
		}

		public void OnGet()
		{
			ViewData["test"] = Content(_configuration.GetValue<string>("ValuesConfiguration:Message"), "text/plain").Content.ToString();
		}
	}

}