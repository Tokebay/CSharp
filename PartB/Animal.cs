using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB
{
    internal class Animal
    {
    }

    public interface IAnimal
    {
        string IMove();
    }

    public class Cat : IAnimal
    {
        public int Leg { get; set; }
        public string IMove()
        {
            return "run";
        }
    }

    public class Fish : IAnimal
    {
        
        public string IMove()
        {
            return "Sweam";
        }
    }
}
