using ProjectX.Core.Entities.Base;

namespace ProjectX.Core.Entities
{
    public class Master : Entity
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }

        public List<WorkingDay> WorkingDays { get; set;}
    }
}
