using System;
using System.Globalization;

namespace ExercicioLista {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registered? ");
            int qtde = int.Parse(Console.ReadLine());

            List<Employee> lista = new List<Employee>();

            for (int i = 0; i < qtde; i++) {
                Console.WriteLine($"Employee #{i+1}:");
                Console.Write("Id: ");
                int numID = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double auxSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Employee(numID, name, auxSalario));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idAux = int.Parse(Console.ReadLine());
            Employee emp = lista.Find(x => x.Id == idAux);
            if (emp != null) {
                Console.Write("Enter ther percentage: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(porcentagem);
            }

            else Console.WriteLine("This id does not exist!");

            Console.WriteLine();
            Console.WriteLine("update list of employees: ");
            foreach(Employee obj in lista) {
                Console.WriteLine(obj);
            }
        }
    }
}
