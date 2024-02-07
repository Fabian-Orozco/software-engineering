// Problem
// Basado en: Dive Into Design Patterns [Alexander Shvets]
using System;

namespace BadCase {

    class Avion {
        public string Operation() {
            return "{Soy un avion}";
        }
    }

    class Carro {
        public string Operation() {
            return "{Soy un carro}";
        }
    }

    class Program {
        static void Main(string[] args) {
            Avion Avion = new Avion();
            Carro Carro = new Carro();
            Console.WriteLine(Avion.Operation());
            Console.WriteLine(Carro.Operation());
        }
    }
}

