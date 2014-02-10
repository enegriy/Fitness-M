using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Транспортный класс , тренажер будет забронирован
    /// </summary>
    public sealed class FitnessEquipmentWillBeReserve
    {
        /// <summary>
        /// Бронируемый тренажер
        /// </summary>
        public FitnessEquipment FitnessEquipmentReserve { get; set; }
        /// <summary>
        /// Время с
        /// </summary>
        public TimeSpan TimeFrom { get; set; }
        /// <summary>
        /// Время по
        /// </summary>
        public TimeSpan TimeTo { get; set; }

    }
}
