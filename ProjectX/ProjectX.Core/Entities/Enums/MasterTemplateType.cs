namespace ProjectX.Core.Entities.Enums
{
    /// <summary>
    /// Тип шаблона расписания
    /// </summary>
    enum MasterTemplateType
    {
        /// <summary>
        /// Шаблон на будний день
        /// </summary>
        WeekDay = 1,

        /// <summary>
        /// Шаблон на выходной день
        /// </summary>
        WeekEnd = 2,

        /// <summary>
        /// Шаблон не подходящий под критерии выходного или буднего дня
        /// </summary>
        Custom = 3
    }
}
