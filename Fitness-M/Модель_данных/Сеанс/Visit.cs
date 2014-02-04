using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Клиент
    /// </summary>
    public sealed class Visit
    {
        /// <summary>
        /// Спецификация абонементов
        /// </summary>
        public IList<ClientUseFitnessEquipment> ClientUseFitnessEquipmentSpec { get; set; }

        /// <summary>
        /// Индтификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Клиент
        /// </summary>
        public int ClientId { get; set; }
        /// <summary>
        /// Бронь с
        /// </summary>
        public DateTime PlanFrom { get; set; }
        /// <summary>
        /// Бронь по
        /// </summary>
        public DateTime PlanTo { get; set; }
        /// <summary>
        /// Посещение с
        /// </summary>
        public DateTime VisitFrom { get; set; }
        /// <summary>
        /// Посещение по
        /// </summary>
        public DateTime VisitTo { get; set; }
        /// <summary>
        /// Анулирован
        /// </summary>
        public bool IsDisabled { get; set; }
    }
}
