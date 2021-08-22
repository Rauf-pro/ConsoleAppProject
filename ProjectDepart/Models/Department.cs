using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDepart.Models
{
    class Department
    {
        // Departamentin adini ifade edir.
        private string Name
        {
            get
            {
                return Name;
            }
            set
            {
                if (NameCheck(value))
                {
                   Name = value;
                }
                else
                {
                    Console.WriteLine("Departamewntin adi  minimum 2 herfden ibaret olmalidir");
                }
            }
        }
        // Departamentin adinda minimum 2 herfden ibaret olmasinin metodu
        private bool NameCheck(string name)
        {
            if (name.Length < 2)
            {
                return false;

            }
            foreach (char item in name)
            {
                if (!Char.IsLetter(item))
                {
                    return false;
                }
            }
            return true;
        }

        //Departmanetde maximum var ola bilicek isci sayini ifade edir

        private int _workerlimit;
        public int WorkerLimit 
        {
            get
            {
                return _workerlimit;
            }
            set
            {
                if (value >= 1 )
                {
                    _workerlimit = value;
                }
            } 
        }

        //Departamentde butun iscelere ayliq cemi verilecek maximum meblegi ifade edir
        private double _salarylimit;
        public double SalaryLimit 
        {
            get
            {
                return _salarylimit;
            }
            set
            {
                if (value >= 250)
                {
                    _salarylimit = value;
                }

            }
        }
        //Departamentdeki iscileri ifade edir.Departamente elave olunmus iscilerin siyahisini ifade edir
        public List<Employee> Employees { get; set; }

        // Departamentdeki iscilerin maas ortalamasini qaytaran method

        public double CalcSalaryAverage()
        {
            double sum = 0;
            double average = 0;

            foreach (var item in Employees)
            {
                sum += item.Salary;

            }
            if (Employees.Count != 0)
            {
                average = sum / Employees.Count;
                return average;
            }
            else
            {
                return 0;
            }
        }
    
    }
}
