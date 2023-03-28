using ProjectX.Core.Entities.Base;

namespace ProjectX.Core.Entities
{
    public class MasterTemplate : Entity
    {
        public int TemplateTypeId { get; set; }

        public string TemplateName { get; set; }

        public int MasterId { get; set; }

        public Master Master { get; set; }

        public List<MasterTemplateTime> MasterTemplateTime { get;}

    }
}
