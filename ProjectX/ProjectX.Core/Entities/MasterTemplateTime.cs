using ProjectX.Core.Entities.Base;


namespace ProjectX.Core.Entities
{
    public class MasterTemplateTime: Entity
    {
        public int TemplateId { get; set; }

        /// <summary>
        /// Время начала в формате 00:00
        /// </summary>
        public string TimeStart { get; set; }

        public MasterTemplate MasterTemplate { get; set; }
    }
}
