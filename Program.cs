// See https://aka.ms/new-console-template for more information

using System;

namespace Ejercicio_polimorfismo1

{
    public class Personaje
    {
        public string Nombre { get; set; }
        public int Nivel { get; set; }

        public Personaje(string nombre, int nivel)
        {
            Nombre = nombre;
            Nivel = nivel;
        }

        public virtual void Atacar()
        {
            Console.WriteLine($"{Nombre} ataca con su arma.");
        }

        public virtual void Defender()
        {
            Console.WriteLine($"{Nombre} se protege con su escudo.");
        }
    }

    public class Guerrero : Personaje
    {
        public Guerrero(string nombre, int nivel) : base(nombre, nivel)
        {
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} ataca con su espada y causa un gran daño.");
        }

        public void UsarPocion()
        {
            Console.WriteLine($"{Nombre} usa una poción y recupera 50 puntos de vida.");
        }
    }

    public class Mago : Personaje
    {
        public Mago(string nombre, int nivel) : base(nombre, nivel)
        {
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} lanza un hechizo y causa daño.");
        }

        public void LanzarHechizo()
        {
            Console.WriteLine($"{Nombre} lanza un gran hechizo y causa mucho daño.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Guerrero guerrero = new Guerrero("Gorlock", 10);
            guerrero.Atacar();
            guerrero.UsarPocion();

            Mago mago = new Mago("Stardestroya", 12);
            mago.Atacar();
            mago.LanzarHechizo();

            Console.ReadLine();
        }
    }
}

//Vaquea en este ejemplo la clase base Personajes tienen
//las propiedades Nombre (Gorlok y stardestroya) y Nivel (12 y 10) y los metodos de atacar y defender.

//Que no me guste presentar no significa que no haga nada.