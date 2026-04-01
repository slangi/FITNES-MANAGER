using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnes.core
{
    public class Membership
    {
        public decimal Price { get; set; }
        public int DurationDays { get; }
        public DateTime StartDate { get; set; }
        public const decimal VAT = 0.22m;

        public Membership(decimal price, int durationDays, DateTime startDate)
        {
            Price = price;
            DurationDays = durationDays;
            StartDate = startDate;
        }

        public DateTime GetExpirationDate()
        {
            return StartDate.AddDays(DurationDays);
        }

        public virtual bool IsActive()
        {
            return DateTime.Now <= GetExpirationDate();
        }

        public static bool operator >(Membership a, Membership b)
        {
            return a.Price > b.Price;
        }

        public static bool operator <(Membership a, Membership b)
        {
            return a.Price < b.Price;
        }

        public override string ToString()
        {
            return $"Cena: {Price:F2}, Trajanje: {DurationDays} dni, Velja do: {GetExpirationDate():dd.MM.yyyy}";
        }
    }
}
