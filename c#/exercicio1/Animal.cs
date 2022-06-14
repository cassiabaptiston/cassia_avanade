using System;

namespace exercicio1
{
    public class Animal
    {
        public string especie;
        public string reino;

        public virtual void Comer()
        {
            Console.WriteLine("Animal comendo");
        }
        public virtual void Respirar()
        {
            Console.WriteLine("Animal Respirando");
        }

    }
}
