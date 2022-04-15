using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfazexplicita
{
     class Program
    {

        public interface IOrganismo
        {
            //Método
            void respirar();
            void mover();
        }

        public interface IAnimal
        {
            void mover();
            void viviparo();
        }

        class Perro : IOrganismo, IAnimal
        {
            //Declarar todos los métodos
            //Public void no se puede usar con funciones explicita
            public void respirar()
            {
                Console.WriteLine("Este organismo respira");
            }

            void IOrganismo.mover()
            {
                Console.WriteLine("Este organismo se mueve");
            }

            void IAnimal.mover()
            {
                Console.WriteLine("Este animal se mueve");
            }
            public void viviparo()
            {
                Console.WriteLine("Este organismo es vivíparo");
            }

        }
        static void Main(string[] args)
        {
            Perro perros = new Perro();
            IOrganismo organismo = perros;
            IAnimal animal = perros;

            perros.respirar();
            perros.viviparo();

            organismo.mover();
            animal.mover();

            Console.ReadKey();



        }
    }
}
