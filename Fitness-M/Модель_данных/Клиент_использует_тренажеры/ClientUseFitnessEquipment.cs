using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Клиент использует тренажеры
    /// </summary>
    public sealed class ClientUseFitnessEquipment
    {
        /// <summary>
        /// Индтификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Сеанс
        /// </summary>
        public int VisitId { get; set; }
        /// <summary>
        /// Тренажер
        /// </summary>
        public int FitnessEquipmentId { get; set; }
    }
}
