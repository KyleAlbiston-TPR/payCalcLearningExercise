using localPayCalc;
using System;
using System.Linq;

namespace PayCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tTPR Pay calculator program v.1");
            bool quitApp = false;
            do
            {
                Console.WriteLine("\nWhat would you like to do today? \n1: Get staff info \n2: Generate pay report \n3: Exit");
                var selectedOption = Console.ReadLine();

                switch (selectedOption)
                {
                    case "1":
                        generateStaffPay();
                        break;
                    case "2":
                        generateReport();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            while (!quitApp);
        }

        public static void generateReport()
        {
            Employee employee = new Employee();
            MockEmployeeRepository mock = new MockEmployeeRepository();
            Console.Clear();
            Console.WriteLine("\t\tTPR Pay calculator program v.1");
            Console.ReadLine();
            
        }

        public static void generateStaffPay()
        {
            Employee employee = new Employee();
            MockEmployeeRepository mock = new MockEmployeeRepository();

            Console.Clear();
            Console.WriteLine("\t\tTPR Pay calculator program v.1");

            Console.WriteLine(Environment.NewLine + "Enter ID: ");
            int inputID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(string.Concat(mock.GetEmployee(inputID)));

            Console.WriteLine("\nWhat would you like to do next? \n1: Calculate Total \n2: Calculate hourly wage \n3: Exit");
            var Response = Console.ReadLine();

            if (Response == "1")
            {
                Console.WriteLine(string.Concat(mock.ClaculateTotal()));
            }
            if (Response == "2")
            { 
                
            }
            if (Response == "3")
            {
                Environment.Exit(0);
            }
        }

    }
}
