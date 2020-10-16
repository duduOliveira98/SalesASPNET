﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesForceMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public DateTime BirthData { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthData, double baseSalary,Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthData = birthData;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial,DateTime final) {

            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Ammount);

        }
    }
}
