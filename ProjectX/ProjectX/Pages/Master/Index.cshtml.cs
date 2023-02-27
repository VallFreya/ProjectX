using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectX.Web.Interfaces;
using ProjectX.Web.ViewModels;

namespace ProjectX.Web.Pages.Master
{
    public class IndexModel : PageModel
    {
        private readonly IMasterPageService masterPageService;

        public IndexModel(IMasterPageService masterPageService)
        {
            this.masterPageService = masterPageService;
        }

        public IEnumerable<MasterViewModel> Masters { get; set; } = new List<MasterViewModel>();

        public async Task<IActionResult> OnGetAsync()
        {
            Masters = await masterPageService.GetAllAsync();
            return Page();
        }
    }
}
