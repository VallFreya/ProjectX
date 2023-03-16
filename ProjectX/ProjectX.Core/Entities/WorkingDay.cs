using ProjectX.Core.Entities.Base;

namespace ProjectX.Core.Entities
{
    
    public class WorkingDay : Entity
    {
        public int MasterId { get; set; }

        public DateTime WorkDay { get; set; }

        public Master Master { get; set; }
    }
}
