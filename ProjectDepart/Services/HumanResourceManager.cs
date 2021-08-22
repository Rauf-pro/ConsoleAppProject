using ProjectDepart.Interfaces;
using ProjectDepart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDepart.Services
{
    class HumanResourceManager : IHumanResourceManager
    {
        private List<Department> _departments;
        private List<Employee> _employees;

     
        public List<Department> Departments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddDepartment(Department department)  // Adding Department
        {
            _departments.Add(department);
        }

        public void AddEmployee(Employee employee)    // Addin Employee
        {
            _employees.Add(employee);
        }

        public List<Department> EditDepartments(string oldName, Department newName)
        {
            throw new NotImplementedException();
        }

        public List <Employee> EditEmployee(string rangeNo, string FullName, double Salary, string Position)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetDepartments()   
        {
            return _departments;
        }

        public void RemoveEmployee(string rangeNo, string departmentName)
        {
            throw new NotImplementedException();
        }
    }
}
