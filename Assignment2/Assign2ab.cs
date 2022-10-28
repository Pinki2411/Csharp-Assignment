using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Assignment2
{
    class Program
    {





        class Employee
        {
            public string ID;
            public string Name;
            public double Salary;
            public double HRA;
            public double TA;
            public double DA;
            public double PF;
            public double TDS;
            public double NetSalary;
            public double GrossSalary;




            public void setDataEmployee(string ID, string Name, double Salary, double HRA, double TA, double DA, double PF, double TDS)
            {
                this.ID = ID;
                this.Name = Name;
                this.Salary = Salary;
                //HRA – 20%, TA – 10%, DA – 50%, PF – 12%
                this.HRA = HRA;
                this.TA = TA;
                this.DA = DA;
                this.PF = PF;
                this.TDS = TDS;




                if (HRA < 0)
                {
                    this.HRA = 20;
                }
                if (TA < 0)
                {
                    this.HRA = 10;
                }
                if (DA < 0)
                {
                    this.HRA = 50;
                }
                if (PF < 0)
                {
                    this.HRA = 12;
                }


                this.GrossSalary = calculateGrossSalary();
                this.NetSalary = calculateNetSalary();


            }






            public double calculateGrossSalary()
            {
                return Salary + Salary * HRA / 100.0 + Salary * TA / 100.0 + Salary * DA / 100.0;
            }
            public double calculateNetSalary()
            {
                return GrossSalary - (GrossSalary * PF / 100.0 + GrossSalary * TDS / 100.0);
            }
        }


        class Library
        {
            private List<Employee> employees = new List<Employee>();


            public void addEmployee(Employee emp)
            {
                this.employees.Add(emp);
            }


            public void displayEmployees()
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    Console.WriteLine("ID: {0}", employees[i].ID);
                    Console.WriteLine("Name: {0}", employees[i].Name);
                    Console.WriteLine("Salary: {0}", employees[i].Salary);
                    Console.WriteLine("HRA: {0}", employees[i].HRA);
                    Console.WriteLine("TA: {0}", employees[i].TA);
                    Console.WriteLine("DA: {0}", employees[i].DA);
                    Console.WriteLine("PF: {0}", employees[i].PF);
                    Console.WriteLine("TDS: {0}", employees[i].TDS);
                    Console.WriteLine("Net Salary: {0}", employees[i].NetSalary);
                    Console.WriteLine("Gross Salary: {0}", employees[i].GrossSalary);
                    Console.WriteLine();


                }
            }
        }




        static void Main(string[] args)
        {
            Library library = new Library();




            int ch = -1;
            do
            {
                Console.WriteLine("1. Register the employees in company");
                Console.WriteLine("2. Display employee");
                Console.WriteLine("3. Exit\n");
                Console.Write("Your choice: ");
                ch = int.Parse(Console.ReadLine());
                if (ch == 1)
                {
                    Console.Write("Enter Employee ID: ");
                    string ID = Console.ReadLine();
                    Console.Write("Enter Employee Name: ");
                    string Name = Console.ReadLine();
                    Console.Write("Enter Employee Salary: ");
                    double Salary = double.Parse(Console.ReadLine());
                    Console.Write("Enter Employee HRA (-1 skip): ");
                    double HRA = double.Parse(Console.ReadLine());
                    Console.Write("Enter Employee TA (-1 skip): ");
                    double TA = double.Parse(Console.ReadLine());
                    Console.Write("Enter Employee DA (-1 skip): ");
                    double DA = double.Parse(Console.ReadLine());
                    Console.Write("Enter Employee PF (-1 skip): ");
                    double PF = double.Parse(Console.ReadLine());
                    Console.Write("Enter Employee TDS: ");
                    double TDS = double.Parse(Console.ReadLine());
                    Employee emp = new Employee();
                    emp.setDataEmployee(ID, Name, Salary, HRA, TA, DA, PF, TDS);
                    library.addEmployee(emp);
                }
                else if (ch == 2)
                {
                    library.displayEmployees();
                }
                else if (ch == 3)
                {


                }
            } while (ch != 3);








            Console.ReadKey();
        }
    }
}

