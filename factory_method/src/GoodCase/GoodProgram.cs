// Factory Method Design Pattern
// Basado en: Dive Into Design Patterns [Alexander Shvets]
using System;

namespace GoodCase {

    abstract class Creator {
        public abstract IVehiculo FactoryMethod();

        public string SomeOperation() {
            var product = FactoryMethod();
            var result = "Creador: el mismo código sirve para crear " + product.Operation();
            return result;
        }
    }

    class CreatorAvion: Creator {
        public override IVehiculo FactoryMethod() {
            return new Avion();
        }
    }

    class CreatorCarro : Creator {
        public override IVehiculo FactoryMethod() {
            return new Carro();
        }
    }

    public interface IVehiculo {
        string Operation();
    }

    class Avion : IVehiculo {
        public string Operation() {
            return "{Soy un avion}";
        }
    }

    class Carro : IVehiculo {
        public string Operation() {
            return "{Soy un carro}";
        }
    }

    class Program {
        static void Main(string[] args) {
            List<Creator> creators = new List<Creator>();
            creators.Add(new CreatorAvion());
            creators.Add(new CreatorCarro());

            foreach (Creator creator in creators) {
                Console.WriteLine(creator.SomeOperation());
            }
        }
    }
}

