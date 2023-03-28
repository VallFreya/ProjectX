using System.ComponentModel;

namespace ProjectX.Core.Entities.Enums
{
    /// <summary>
    /// Тип шаблона расписания
    /// </summary>
    public enum MasterTemplateType
    {
        /// <summary>
        /// Шаблон на будний день
        /// </summary>
        [Description("Будний день")]
        WeekDay = 1,

        /// <summary>
        /// Шаблон на выходной день
        /// </summary>
        [Description("Выходной день")]
        WeekEnd = 2,

        /// <summary>
        /// Шаблон не подходящий под критерии выходного или буднего дня
        /// </summary>
        [Description("Свой шаблон")]
        Custom = 3
    }
}
