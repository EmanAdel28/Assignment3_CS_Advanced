using System;
using System.Collections;

namespace Assignment3_CS_Advanced.HashTable
{
    
    
       public class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee(int id, string name, int salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , Salary : {Salary}";
        }


  


    }
}
