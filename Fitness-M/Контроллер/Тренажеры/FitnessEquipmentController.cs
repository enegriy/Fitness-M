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
                            firstFreeDate = busyTime.DateFrom;
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
    }
}
