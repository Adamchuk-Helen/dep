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
            int count = 0;
            Console.WriteLine("\n\nВведіть номер договору працівника");
            contract1 = int.Parse(Console.ReadLine());
            
                foreach ( Employee emp in emp1)
                {
                if (emp.contract == contract1)
                {
                    Console.WriteLine("\n\nВведіть ім'я працівника");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введіть прізвище працівника");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Введіть посаду працівника");
                    string position = Console.ReadLine();
                    emp.name = name;
                    emp.surname = surname;
                    emp.position = position;
                    count++;
                }
                
                }
            if (count == 0) { Console.WriteLine("\nНе знайдено працівника з таким номером договору"); }



        }
        public void InputSalary()
        {
            int count = 0;
            Console.WriteLine("\n\nВведіть номер договору працівника");
            contract1 = int.Parse(Console.ReadLine());

            foreach (Employee emp in emp1)
            {
                if (emp.contract == contract1)
                {
                    Console.WriteLine("Введіть суму заробітної плати працівника");
                    salary1 = int.Parse(Console.ReadLine());   
                        emp.salary = salary1;
                    count++;
                }
                
            }
            if (count == 0) { Console.WriteLine("\nНе знайдено працівника з таким номером договору"); }

        }
        public void AddSalary()
        {
            int count = 0;
            Console.WriteLine("\n\nВведіть номер договору працівника");
            contract1 = int.Parse(Console.ReadLine());

            foreach (Employee emp in emp1)
            {
                if (emp.contract == contract1)
                {
                    Console.WriteLine("Введіть суму, на яку потрібно збільшити заробітну плату працівника");
                    salary1 = int.Parse(Console.ReadLine());
                        new_salary = emp.salary + salary1;
                        emp.salary = new_salary;
                    count++;
                }
                
            }
            if (count == 0) { Console.WriteLine("\nНе знайдено працівника з таким номером договору"); }

        }

        public override string ToString()
        {
            return $"\nІм'я: {name} \nПрізвище: {surname} \nДоговір {this.contract} \nЗаробітна плата: {this.salary} \nПосада: {this.position}";

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
