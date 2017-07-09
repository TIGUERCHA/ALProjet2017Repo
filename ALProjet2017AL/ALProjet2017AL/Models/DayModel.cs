using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ALProjet2017AL.Models
{
    public class DayModel
    {

        // C'est mauvais -> On ne sait pas quelle classe
        // public List<PlageHoraireModel> plagesHoraireDuJour { get; set; }
        public string day { get; set; }
        public string month { get; set; }
        public string year { get; set; }

        public DayModel(string day, string month, string year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public string getDayOfWeek()
        {
            DateTime dateValue = new DateTime(
                Int32.Parse(year),
                Int32.Parse(month),
                Int32.Parse(day)
            );
            return dateValue.ToString("ddd", new CultureInfo("fr-FR"));
        }
    }
}