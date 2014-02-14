using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Fitness_M
{
    /// <summary>
    /// Виды абонементов
    /// </summary>
    public class KindTickets : TicketsManager, IBusinessObject, INotifyPropertyChanged
    {
        #region Prop
        /// <summary>
        /// Индтификатор
        /// </summary>
        private int m_Id;
        /// <summary>
        /// Индтификатор
        /// </summary>
        public int Id
        {
            get { return m_Id; }
            set 
            { 
                m_Id = value;
                OnPropertyChanged("Id");
            }
        }

        /// <summary>
        /// Период действия
        /// </summary>
        private int m_Period;
        /// <summary>
        /// Период действия
        /// </summary>
        public int Period
        {
            get { return m_Period; }
            set { 
                m_Period = value;
                OnPropertyChanged("Period");
            }
        }

        /// <summary>
        /// Количество баллов
        /// </summary>
        private int m_CountBalls;
        /// <summary>
        /// Количество баллов
        /// </summary>
        public int CountBalls
        {
            get { return m_CountBalls; }
            set { 
                m_CountBalls = value;
                OnPropertyChanged("CountBalls");
            }
        }

        /// <summary>
        /// Количество посещений
        /// </summary>
        private int m_CountVisits;
        /// <summary>
        /// Количество посещений
        /// </summary>
        public int CountVisits
        {
            get { return m_CountVisits; }
            set { 
                m_CountVisits = value;
                OnPropertyChanged("CountVisits");
            }
        }

        /// <summary>
        /// Только групповые занятия
        /// </summary>
        private bool m_IsOnlyGroup;
        /// <summary>
        /// Только групповые занятия
        /// </summary>
        public bool IsOnlyGroup
        {
            get { return m_IsOnlyGroup; }
            set { 
                m_IsOnlyGroup = value;
                OnPropertyChanged("IsOnlyGroup");
            }
        }

        /// <summary>
        /// Недействителен
        /// </summary>
        private bool m_IsInactive;
        /// <summary>
        /// Недействителен
        /// </summary>
        public bool IsInactive
        {
            get { return m_IsInactive; }
            set { 
                m_IsInactive = value;
                OnPropertyChanged("IsInactive");
            }
        }

        private decimal m_Price;
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price
        {
            get { return m_Price; }
            set { 
                m_Price = value;
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Пустая запись
        /// </summary>
        public bool IsEmpty
        {
            get { return Id == 0; }
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Сохранить
        /// </summary>
        public void Save()
        {
            SaveKindTickets(this);
        }
        /// <summary>
        /// Обновить
        /// </summary>
        public void Update()
        {
            UpdateKindTickets(this);
        }
        /// <summary>
        /// Удалить
        /// </summary>
        public void Delete()
        {
            DeleteKindTickets(this);
        }

        /// <summary>
        /// Сделать активным
        /// </summary>
        public void DoActive()
        {
            IsInactive = false;
            UpdateIsDisabled(this, IsInactive);
        }

        /// <summary>
        /// Сделать неактивным
        /// </summary>
        public void DoInactive()
        {
            IsInactive = true;
            UpdateIsDisabled(this, IsInactive);
        }

        /// <summary>
        /// Используется этот вид абонемента
        /// </summary>
        /// <returns></returns>
        public bool UseKindTicket()
        {
            return UseKindTicket(this);
        }

        /// <summary>
        /// Сделать снимок
        /// </summary>
        /// <returns></returns>
        public KindTickets SnapShot()
        {
            var snapshot = new KindTickets();
            snapshot.Id = Id;
            snapshot.Period = Period;
            snapshot.CountBalls = CountBalls;
            snapshot.CountVisits = CountVisits;
            snapshot.IsInactive = IsInactive;
            snapshot.IsOnlyGroup = IsOnlyGroup;
            snapshot.Price = Price;
            return snapshot;
        }

        /// <summary>
        /// Востановить по значению снимка
        /// </summary>
        /// <param name="snapShot"></param>
        public void RestoreBySnapShot(KindTickets snapShot)
        {
            Id = snapShot.Id;
            Period = snapShot.Period;
            CountBalls = snapShot.CountBalls;
            CountVisits = snapShot.CountVisits;
            IsInactive = snapShot.IsInactive;
            IsOnlyGroup = snapShot.IsOnlyGroup;
            Price = snapShot.Price;
        }
        #endregion

        #region INotifyChanged
        /// <summary>
        /// Возможность информировать всех, что свойства объекта изменились
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Fire PropertyChanged
        /// </summary>
        /// <param name="propertyName">Property name</param>
        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
