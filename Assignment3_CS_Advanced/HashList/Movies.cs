using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_CS_Advanced.HashList
{
    internal class Movies:IEquatable<Movies>
    {
        public Movies(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Price}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name , Price);
        }

        public bool Equals(Movies? other)
        {
          return  this.Id.Equals(other.Id) && this.Name.Equals(other.Name) && this.Price.Equals(other.Price);
                ;
        }
    }
}
