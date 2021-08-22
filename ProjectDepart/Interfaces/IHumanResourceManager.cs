using ProjectDepart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDepart.Interfaces
{
    interface IHumanResourceManager
    {
        //sistemdeki departamentler siyahisini ifade edir
        public List<Department> Departments { get; set; }

        /*departament yaratmaq ucun lazimli melumatlari parameter olaraq qebul edib,yaradib, 
         * departamenets arrayina elave eden metod*/
        public void AddDepartment(Department department);


        //sistemdeki butun departamentleri geriye qaytaran
        public List<Department> GetDepartments();

        /* departamentin uzerinde deyisiklik - departamentin adi deyisdirile biler ve parameter oaraq deyisdirmek 
         istediyi departamentin adini ve yeni adini gonderir*/
        public List<Department> EditDepartments(string oldName, Department newName);

        /*parametr olaraq employee yaranmasi ucun lazim olan melumatlar ve departament name gonderilir.Method icinde 
        employe yaradilir ve gonderilmis nomreli departamentin employees arrayine elave edilir*/
        public void  AddEmployee(Employee employee);

        //parametr olaraq employee nomresi ve department adi gondeirlir ve gonderilmis nomreli employee-ni silir.
        public void RemoveEmployee(string rangeNo, string departmentName);

        //paramters olaraq iscinin nomersi, fullname,salary ve position daxil edilir ve uzerinde deyisiklik etmek ucun
        public List<Employee> EditEmployee(string rangeNo, string FullName,double Salary, string Position);




    }
}
