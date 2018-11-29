using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WebServerProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Servidor Web pequeño");
            Server.Start();
            Console.WriteLine("Se termino de cargar");
            Console.ReadLine();
        }


        public delegate int Calculo(int x, int y);

        // Firma de un metodo/funcion
        static void AnonymousSample()
        {
            // Declaracion normal
            // Type nombre;
            Type a1;
            string a2;
            int a3;

            // Declaracion anonima
            var b1 = typeof(object);
            var b2 = "Hola";
            var b3 = 10;
            // no funciona
            // var b4;



            // Delegates examples

            // Function call
            Console.WriteLine(Sumar(2, 3));

            Calculo funcion = Sumar;
            Console.WriteLine(funcion(2, 3));

            DelegateTest x = new DelegateTest();

            x.ClickHandler += Sumar;
            x.ClickHandler += Restar;
            x.ClickHandler += (z, y) => { return 10; };
            
        }

        public static int Sumar(int x, int y)
        {
            return x + y;
        }

        public static int Restar(int x, int y) { return 1; }
    }

    public class DelegateTest
    {
        public event Calculo ClickHandler;
        public delegate int Calculo(int x, int y);
        // Una modificacion

    }
}
