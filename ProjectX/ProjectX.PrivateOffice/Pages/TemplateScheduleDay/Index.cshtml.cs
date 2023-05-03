using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectX.Core.Entities;
using ProjectX.Core.Entities.Enums;
using ProjectX.Core.Extentions;
using ProjectX.PrivateOffice.Pages.ViewModels;

namespace ProjectX.PrivateOffice.Pages.TemplateScheduleDay
{

    public class IndexModel : PageModel
    {
        public TemplateScheduleDayViewModel MasterTimes { get; set; }
        public Dictionary<int, string> MasterTemplateTypes { get; set; } = new();
        public void OnGet()
        {
            foreach (MasterTemplateType templateType in Enum.GetValues(typeof(MasterTemplateType)))
            {
                MasterTemplateTypes.Add((int)templateType, templateType.GetDescription());
            }

            // будем брать потом это из бд
            MasterTimes = new TemplateScheduleDayViewModel()
            {
                MasterTemplateTimes = new List<MasterTemplateTimes>()
                {
                    new MasterTemplateTimes()
                    {
                        Id = 1,
                        TemplateId = 1,
                        TimesStart = new List<string>() { "10:00", "12:00", "14:00", "16:00" },
                    },
                    new MasterTemplateTimes()
                    {
                        Id = 2,
                        TemplateId = 2,
                        TimesStart = new List<string>() { "11: 00", "13:00", "15:00", "17:00"}
                    }
                }
            };
        }
    }
}
