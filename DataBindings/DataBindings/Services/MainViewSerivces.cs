using DataBindings.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBindings.Services
{
    public  class MainViewSerivces
    {
        

        public List<Employee> List()
        {
            var crops = new List<Employee>
            { 
                new Employee{Name="Kavindu",Description="I am a student"},
                new Employee{Name="Kavindu",Description="I am a Teacher"},
                new Employee{Name="Kavindu",Description="I am a student"},
            };
            return crops;
        }
    }
}
