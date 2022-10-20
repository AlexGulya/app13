using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app13
{
    internal class Person
    {
        public string name;
        public int age;
        public const string type = "Person";
        public Company company;

      
        public Person(string name = "Неизвестно ", int age = 10)
        {
            this.name = name;
            this.age = age;
            company =  new Company();
            
        }







        public void Info()
        {
            Console.WriteLine($"type:{type} - name: {name} - age: {age} - company: {company.title}");
        }
    }
}
