using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class Date
    {   
        //atributos de la clase Date
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day) //parametros del constructor Date
        {
            _year = year;
            _month = CheckMont(month); // con el método CheckMont validamos que el mes introducido sea válido
            _day = Checkday(year,month, day);
        }

        private int Checkday(int year, int month, int day)
        {
            if (month == 2 && day == 29 && IsLeapYear(year))// Validamos si el año es bisiesto con IsLeapYear que es un metodo que vamos a construir
            {
                return day;
            }

            int[] daysPerMonth = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; // creamos un arreglo con los dias del mes de cada mes
            if (day >= 1 && day <= daysPerMonth[month])
              {
                return day;
            }
            throw new DayException($"Invalid day {day}");
        }

        private bool IsLeapYear(int year) //
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        private int CheckMont(int month) // nétodo CheckMonth
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }
                
            throw new MonthException($"Invalid Month {month}");
        }

        public override string ToString() // necesitamos reescribir el metodo ToString porque date1 heredó de la clase Date este método
        {
            return $"{_year}/{_month:00}/{_day:00}"; // se ponen las variables entre llaves, para el mes y el dia se le pone :00 para que rellene con dos 00
        }

    }
}
