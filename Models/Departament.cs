using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesForceMVC.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public ICollection<Seller> Seller { get; set; } = new List<Seller>();

        public Departament()
        {
        }

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Seller.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Seller.Sum(Seller => Seller.TotalSales(initial, final));
        }

    }
}
