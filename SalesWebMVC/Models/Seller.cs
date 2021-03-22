﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BithDay { get; set; }
        public double BaseSalary { get; set; }

        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime bithDay, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BithDay = bithDay;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
    
        public double TotalSales(DateTime inital, DateTime final)
        { 
            return Sales.Where(Sale => Sale.Date > inital && Sale.Date<final).Sum(Sale => Sale.Amount);
        }
    }
}