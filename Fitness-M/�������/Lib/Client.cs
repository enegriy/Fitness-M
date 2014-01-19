using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Клиент
    /// </summary>
    public sealed class Client: ClientManager, IBusinessObject
    {
        /// <summary>
        /// Индтификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Номер
        /// </summary>
        public long Number { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string SurName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateBirth { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Доп
        /// </summary>
        public string Note { get; set; }
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
        public  static IList<Client> FindAll()
        {
            var cm = new ClientManager();
            return cm.LoadCliets();
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
