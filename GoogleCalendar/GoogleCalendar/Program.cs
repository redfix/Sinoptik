using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleCalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            XGCalendarAccess.CreateNewEvent(DateTime.Now, DateTime.Now, "Проверка Хрюши", true);
        }
    }
}
