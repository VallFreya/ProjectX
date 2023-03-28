using ProjectX.Core.Entities.Base;

namespace ProjectX.Core.Entities
{
    public class MasterTemplateTimes : Entity
    {
        public int TemplateId { get; set; }

        /// <summary>
        /// Время начала в формате 00:00
        /// </summary>
        public List<string> TimesStart { get; set; }
    }
}
