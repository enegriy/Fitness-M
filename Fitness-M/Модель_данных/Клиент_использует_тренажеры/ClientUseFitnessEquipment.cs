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
        #region Prop
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
        #endregion

        #region ReferenceProp
        private Visit m_VisitRef;
        /// <summary>
        /// Ссылка на посещение
        /// </summary>
        public Visit VisitRef
        {
            get
            {
                if (m_VisitRef == null)
                {
                    var dataSet = ClientDataSet.Get();
                    m_VisitRef = dataSet.ListVisit.FirstOrDefault(x => x.Id == VisitId);
                }
                return m_VisitRef;
            }
            set
            {
                m_VisitRef = value;
            }
        }

        private FitnessEquipment m_FitnessEquipmentRef;
        /// <summary>
        /// Ссылка на тренажер
        /// </summary>
        public FitnessEquipment FitnessEquipmentRef
        {
            get
            {
                if (m_FitnessEquipmentRef == null)
                {
                    var dataSet = ClientDataSet.Get();
                    m_FitnessEquipmentRef = dataSet.ListFitnessEquipment.FirstOrDefault(x => x.Id == FitnessEquipmentId);
                }
                return m_FitnessEquipmentRef;
            }
            set
            {
                m_FitnessEquipmentRef = value;
            }
        }
        #endregion

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
