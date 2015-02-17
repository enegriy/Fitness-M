using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Сеанс
    /// </summary>
    public sealed class Visit : VisitManager, IBusinessObject
    {
        #region Prop
        private IList<ClientUseFitnessEquipment> m_ClientUseFitnessEquipmentSpec;
        /// <summary>
        /// Спецификация абонементов
        /// </summary>
        public IList<ClientUseFitnessEquipment> ClientUseFitnessEquipmentSpec 
        {
            get 
            {
                if (m_ClientUseFitnessEquipmentSpec == null)
                {
                    m_ClientUseFitnessEquipmentSpec = new List<ClientUseFitnessEquipment>();
                    var dataSet = ClientDataSet.Get();
                    var useFitnessEquipment = dataSet.ListUseFitnessEquipment.Where(x => x.VisitId == this.Id).ToList();
                    ((List<ClientUseFitnessEquipment>)m_ClientUseFitnessEquipmentSpec).AddRange(useFitnessEquipment);
                }

                return m_ClientUseFitnessEquipmentSpec;
            }
            set 
            {
                m_ClientUseFitnessEquipmentSpec = value;
            }
        }

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

        /// <summary>
        /// Пустая запись
        /// </summary>
        public bool IsEmpty
        {
            get { return Id == 0; }
        }
        #endregion

        #region Reference Prop
        private Client m_ClientRef;
        /// <summary>
        /// Ссылка на клиента
        /// </summary>
        public Client ClientRef
        {
            get
            {
                if (m_ClientRef == null)
                {
                    var dataSet = ClientDataSet.Get();
                    m_ClientRef = dataSet.ListClients.FirstOrDefault(x => x.Id == ClientId);
                }
                return m_ClientRef;
            }
            set
            {
                m_ClientRef = value;
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
