namespace ProjectX.PrivateOffice.Pages.Models.TemplateScheduleDay
{
    public class AddTemplatePostModel
    {
        /// <summary>
        /// Id шаблона <see cref="Core.Entities.Enums.MasterTemplateType"/>
        /// </summary>
        public int TemplateTypeId { get; set; }

        /// <summary>
        /// Список времени начала
        /// </summary>
        public List<string> TimesStart { get; set; } = new List<string>();

        /// <summary>
        /// Наименование шаблона в том случае, если он кастомный
        /// </summary>
        public string? TemplateName { get; set; }
    }
}
