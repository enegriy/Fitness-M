using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Клиент использует тренажеры
    /// </summary>
    public sealed class ClientUseFitnessEquipment : ClientUseFitnessEquipmentManager, IBusinessObject
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
        /// <summary>
        /// Время с
        /// </summary>
        public TimeSpan TimeFrom { get; set; }
        /// <summary>
        /// Время по
        /// </summary>
        public TimeSpan TimeTo { get; set; }
        /// <summary>
        /// Пустая запись
        /// </summary>
        public bool IsEmpty
        {
            get { return Id == 0; }
        }

        #region Public Methods

        /// <summary>
        /// Сохранить
        /// </summary>
        public void Save()
        {
            Save(this);
        }

        /// <summary>
        /// Обновить
        /// </summary>
        public void Update()
        {
            Update(this);
        }

        /// <summary>
        /// Удалить
        /// </summary>
        public void Delete()
        {
            Delete(this);
        }


        #endregion
    }
}
