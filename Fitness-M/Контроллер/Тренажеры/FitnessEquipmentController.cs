using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Тренажеры
    /// </summary>
    public class FitnessEquipmentController : ObjectManager
    {
        /// <summary>
        /// Получить список свободного времени
        /// </summary>
        public IList<DateFromAndDateTo> GetListFreeTime(
            FitnessEquipment fitnessEquipment, 
            DateTime dateVisit, 
            DateFromAndDateTo workPeriod)
        {
            var listFreeTime = new List<DateFromAndDateTo>();

            var listBusyTime = GetListBusyTime(fitnessEquipment, dateVisit);
            if (listBusyTime.Any())
            {
                listBusyTime = listBusyTime.OrderBy(x => x.DateFrom).ToArray();
                DateTime firstFreeDate = DateTime.MinValue;
                DateFromAndDateTo dateFromAndTo;
                foreach (var busyTime in listBusyTime)
                {
                    if (firstFreeDate == DateTime.MinValue)
                    {
                        if (busyTime.DateFrom == workPeriod.DateFrom)
                        {
                            firstFreeDate = busyTime.DateTo;
                        }
                        else
                        {
                            dateFromAndTo = new DateFromAndDateTo(workPeriod.DateFrom, busyTime.DateFrom);
                            listFreeTime.Add(dateFromAndTo);
                            firstFreeDate = busyTime.DateTo;
                        }
                    }
                    else
                    {
                        if (firstFreeDate == busyTime.DateFrom)
                        {
                            firstFreeDate = busyTime.DateTo;
                            continue;
                        }
                        else
                        {
                            dateFromAndTo = new DateFromAndDateTo(firstFreeDate, busyTime.DateFrom);
                            listFreeTime.Add(dateFromAndTo);
                            firstFreeDate = busyTime.DateTo;
                        }
                    }
                }

                if (firstFreeDate < workPeriod.DateTo)
                {
                    dateFromAndTo = new DateFromAndDateTo(firstFreeDate, workPeriod.DateTo);
                    listFreeTime.Add(dateFromAndTo);
                }
            }
            else
                listFreeTime.Add(workPeriod);

            return listFreeTime;
        }

        public IList<DateFromAndDateTo> GetListBusyTime(
            FitnessEquipment fitnessEquipment, 
            DateTime dateVisit)
        {
            var rslt = new List<DateFromAndDateTo>();

            OpenConnection();

             string sql = 
                 @"select 
	                    cue.time_from, cue.time_to 
                    from 
	                    client_use_equipment cue
                    inner join 
	                    visits v 
                    on 
	                    v.id = cue.visit_id
                    where 
	                    fitness_equipment_id = {0} 
                    AND 
	                    is_disabled = 0
                    AND
	                    (date(visit_from) = '{1}' 
                    OR 
	                    date(plan_from) = '{1}')";

             var cmd = new MySql.Data.MySqlClient.MySqlCommand(string.Format(
                 sql, 
                 fitnessEquipment.Id, 
                 dateVisit.ToString("yyyy-MM-dd")));

            cmd.Connection = Connection;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var timeFrom = (TimeSpan)reader[0];
                var dateFrom = new DateTime(dateVisit.Year, dateVisit.Month, dateVisit.Day, timeFrom.Hours, timeFrom.Minutes, timeFrom.Seconds);
                
                var timeTo = (TimeSpan)reader[1];
                var dateTo = new DateTime(dateVisit.Year, dateVisit.Month, dateVisit.Day, timeTo.Hours, timeTo.Minutes, timeTo.Seconds);

                var dateFromAndDateTo = new DateFromAndDateTo(dateFrom, dateTo);

                rslt.Add(dateFromAndDateTo);
            }

            CloseConnection();

            return rslt;
        }

        public static void CheckInterval(Client client, 
            FitnessEquipment fitnessEq, 
            DateTime DateVisit, 
            TimeSpan timeFrom)
        {
            //Если интервал задан
            if (fitnessEq.TimeSpan > 0)
            {
                //За какое количество дней просмотреть посещения
                var periodDayForVisit = (fitnessEq.TimeSpan / 24)+1;
                //Дата записи на тренажер
                var date = DateVisit.Date.Add(timeFrom);
                //Список посещений за предыдущие дни
                var listVisit = client.ListVisit.Where(x=>
                    x.PlanFrom.Date >= DateVisit.Date.AddDays(-periodDayForVisit));

                foreach (var visit in listVisit)
                {
                    var existFitEq = visit.ClientUseFitnessEquipmentSpec.Where(x => 
                        x.FitnessEquipmentRef == fitnessEq);
                    if(existFitEq.Any(x=>
                        (date - visit.PlanFrom.Date.Add(x.TimeFrom)).TotalHours < fitnessEq.TimeSpan))
                    {
                        throw new BussinesException(
                            string.Format("Ошибка записи на тренажер {0}, интервал между посещениями должен состовлять не менее {1} часов",
                            fitnessEq.Title, fitnessEq.TimeSpan));
                    }

                }
            }
        }
    }
}
