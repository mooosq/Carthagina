using System;

namespace Carthagina.Core.Models
{
    public class Date : IEquatable<Date>
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public bool Equals(Date other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Day == other.Day && Month == other.Month && Year == other.Year;
        }

        public bool Equals(DateTime dateTime)
        {
            return Day == dateTime.Day && Month == dateTime.Month && Year == dateTime.Year;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Date) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Day, Month, Year);
        }

        public override string ToString()
            => $"{Day}.{Month}.{Year}";
    }
}