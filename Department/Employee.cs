using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Departments
{

    public class Employee : ICloneable, IComparable, IEnumerable
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string position { get; set; }
        public int salary { get; set; }
        public int contract = 100001;
        int contract1;
        int salary1;
        int new_salary;
        public Employee()
        {
            this.name = "немає імені";
            this.surname = "немає прізвища";
            this.position = "немає посади";
            this.salary = 0;
            this.contract = contract++;

        }
        public List<Employee> emp1 = new List<Employee>();
        public void InputName()
        {
            Console.WriteLine("\n\nВведіть номер договору працівника");
            contract1 = int.Parse(Console.ReadLine());
            if(emp1.)
            
                foreach ( var contract in emp1)
                {
                  if ((int)this.contract == contract1)
                   {
                    //Console.WriteLine("\n\nВведіть ім'я працівника");
                    //string name = Console.ReadLine();
                    //Console.WriteLine("Введіть прізвище працівника");
                    //string surname = Console.ReadLine();
                    //this.name = name;
                    //this.surname = surname;
                    Console.WriteLine(contract);
                   }
                }
            


        }
        public void InputSalary()
        {
            Console.WriteLine("\n\nВведіть розмір заробітної плати працівника");
            int salary = int.Parse(Console.ReadLine());
        }
        public void AddSalary(ushort add)
        {
            Console.WriteLine("Введіть суму, на яку потрібно збільшити заробітну плату працівника");
            salary1 = int.Parse(Console.ReadLine());
            new_salary = salary + salary1;
            this.salary = new_salary;
        }

        public override string ToString()
        {
            return $"\nІм'я: {name} \nПрізвище: {surname} \nДоговір {this.contract} \nЗаробітна плата: {this.salary}";

        }

        

        public void Show()
        {
            foreach (Employee item in emp1)
            {
                Console.WriteLine(item);
            }
        }
    public object Clone()
        {
            Employee emp = new Employee() { name = this.name, surname = this.surname };
            emp.contract = this.contract + 1;
            contract++;
            emp1.Add(emp);

            return emp;

        }

        public int CompareTo(object obj)
        {

            Employee em = obj as Employee;

            if (em is null)
            {
                throw new NotImplementedException();
            }
            return (int)this.contract.CompareTo(contract1);

        }

        public IEnumerator GetEnumerator()
        {
            return emp1.GetEnumerator();
        }
    }
}
