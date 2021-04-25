using System;

namespace Departments
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Employee emp = new Employee();
            Menu(emp);
            

        }
        static public void Menu(Employee emp)
        {
            for (; ; )
            {
                Console.WriteLine("1. Добавити працівника");
                Console.WriteLine("2. Показати всіх працівників");
                Console.WriteLine("3. Змінити ім'я, прізвище та посаду");
                Console.WriteLine("4. Збільшити розмір заробітної плати");
                Console.WriteLine("0. Вихід");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            emp.Clone();
                            break;
                            
                        }
                    case 2:
                        {
                            emp.Show();
                            break;
                        }
                    case 3:
                        {
                            emp.InputName();
                            break;
                        }
                }
            }

        }
    }
}
