using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Тренажер
    /// </summary>
    public class FitnessEquipment: FitnessEquipmentManager, IBusinessObject
    {
        /// <summary>
        /// Спецификация незанятого времени
        /// </summary>
        public IList<DateFromAndDateTo> ListFreeTime { get; set; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Продолжительность
        /// </summary>
        public int RunningTime { get; set; }
        /// <summary>
        /// Количество баллов
        /// </summary>
        public int CountBalls { get; set; }
        /// <summary>
        /// Пустая запись
        /// </summary>
        public bool IsEmpty
        {
            get { return Id == 0; }
        }

        #region Public Methods

        /// <summary>
        /// Поднять всех клиентов
        /// </summary>
        /// <returns></returns>
        public static IList<FitnessEquipment> FindAll()
        {
            var fem = new FitnessEquipmentManager();
            return fem.LoadFitnessEquipment();
        }

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
