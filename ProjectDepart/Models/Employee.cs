using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDepart.Models
{
    class Employee
    {
        private static int _counter = 1000;
        // iscilerin nomresini bildirir.
        public string No { get; set; }
        public Employee()
        {
            _counter++;
            No = DepartmentName.Substring(0, 2).ToUpper() + _counter;
        }
    

        // iscinin ad ve soyadini bildirir.
        public string Fullname { get; set; }
        // iscinin vezifesini bildirir.
        private string _position;
        public string Position 
        { 
            get
            {
                return _position;
            }
            set
            {
                if (NameCheck(value))
                {
                    _position = value;
                }
                else
                {
                    Console.WriteLine("Iscinin vezifesinin adi minimum 2 herfden ibaret olmalidir");
                }
            }
        }
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

        //iscinin maasini bildirir.
        private double _salary;
         public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 250 )
                {
                   _salary = value;
                }
                else
                {
                    Console.WriteLine("Iscinin maasi minimum 250 olmalidir.");
                }
                
            }
        }
        
        // iscinin elave olundugu departamentin adi
        public string DepartmentName { get; set; }
        

        
    }
}
