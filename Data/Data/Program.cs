using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Object skonstantnimi znachenijzmi");
            Data nul = new Data();
            nul.Info();
            Console.WriteLine("Visokosnii?");
            Console.WriteLine(nul.Visokos());
            nul.Update();
            Console.WriteLine("Novije znachenija");
            nul.Info();
            Console.WriteLine("Sozdaem noviu object");
            Console.WriteLine("Vvedyte Den:");
            int day = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite mesac:");
            int moon = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite god:");
            int year = Int32.Parse(Console.ReadLine());
            Data newData = new Data(day, moon, year);
            newData.Info();
            Console.WriteLine("Visokosnii?");
            Console.WriteLine(newData.Visokos());
            newData.Update();
            Console.WriteLine("Novije znachenija");
            newData.Info();
            Console.ReadLine();
        }
    }
    class Data
    {
        public int day;
        public int month;
        public int year;
        public Data()
        {

        }
        public Data(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }
        ~Data()
        {
            Console.WriteLine("Remove this object");
            Console.ReadKey();
        }
        public bool Visokos()
        {
            return year%4==0;
        }
        public void Update()
        {
            day += 5;
            if (day > 30)
            {
                day -= 30;
                month++;
                if(month>12)
                {
                    month -= 12;
                    year++;
                }
            }
        }
        public void Info()
        {
            Console.WriteLine("day: {0}, month: {1}, year: {2}",day,month,year);
        }
    }
}
