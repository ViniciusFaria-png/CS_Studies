﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista {
    internal class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double porcentagem) {
            porcentagem /= 100;
            Salary *= porcentagem+1;
        }

        public override string ToString() {
            return Id 
                + ", " 
                + Name 
                + ", " 
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
