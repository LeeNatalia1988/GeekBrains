﻿namespace SPAWebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
