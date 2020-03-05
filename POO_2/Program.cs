using System;

namespace POO_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Elija una Opcion");
            Console.WriteLine("1 -> Alquilar Apartamento");
            Console.WriteLine("2 -> Vender Apartamento");
            Console.WriteLine("Nota: Despues de realizar la opcion deseada, debera de presionar 2 veces enter  despues de realizar las prox. opciones");

            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {

                case 1:
                    Alquilar();
                    break;
                case 2: 
                    Vender();
                    break;

            }
            Console.ReadKey();
            Console.Clear();
        }
        static void Alquilar()
        {
            String Dirección;
            Console.WriteLine("Escribir la direccion deseada");
            Dirección = Console.ReadLine();
            Console.ReadKey();

            String Color;
            Console.WriteLine("Escribir el color deseado");
            Color = Console.ReadLine();
            Console.ReadKey();

            String Area;
            Console.WriteLine("Escribir el area deseada");
            Area = Console.ReadLine();
            Console.ReadKey();

            String Construcción;
            Console.WriteLine("Escribir la construccion deseada");
            Construcción = Console.ReadLine();
            Console.ReadKey();

            String Parqueos;
            Console.WriteLine("Escribir la cantidad de parqueos deseados");
            Parqueos = Console.ReadLine();
            Console.ReadKey();

            String Habitaciones;
            Console.WriteLine("Escribir la cantidad de habitaciones deseada");
            Habitaciones = Console.ReadLine();
            Console.ReadKey();

            String Baños;
            Console.WriteLine("Escribir la cantidad de baños deseados");
            Baños = Console.ReadLine();
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine(" Direccion: " + Dirección);
            Console.WriteLine(" Color: " + Color);
            Console.WriteLine(" Area: " + Area);
            Console.WriteLine(" Construccion: " + Construcción);
            Console.WriteLine(" Parqueos: " + Parqueos);
            Console.WriteLine(" Habitaciones: " + Habitaciones);
            Console.WriteLine(" Baños: " + Baños);



            Console.ReadKey();
            Console.WriteLine("Saliendo...");

        }

        static void Vender()
        {
            String Dirección;
            Console.WriteLine("Escribir la direccion deseada");
            Dirección = Console.ReadLine();
            Console.ReadKey();

            String Color;
            Console.WriteLine("Escribir el color deseado");
            Color = Console.ReadLine();
            Console.ReadKey();

            String Area;
            Console.WriteLine("Escribir el area deseada");
            Area = Console.ReadLine();
            Console.ReadKey();

            String Construcción;
            Console.WriteLine("Escribir la construccion deseada");
            Construcción = Console.ReadLine();
            Console.ReadKey();

            String Parqueos;
            Console.WriteLine("Escribir la cantidad de parqueos deseados");
            Parqueos = Console.ReadLine();
            Console.ReadKey();

            String Habitaciones;
            Console.WriteLine("Escribir la cantidad de habitaciones deseada");
            Habitaciones = Console.ReadLine();
            Console.ReadKey();

            String Baños;
            Console.WriteLine("Escribir la cantidad de baños deseados");
            Baños = Console.ReadLine();
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine(" Direccion: " + Dirección);
            Console.WriteLine(" Color: " + Color);
            Console.WriteLine(" Area: " + Area);
            Console.WriteLine(" Construccion: " + Construcción);
            Console.WriteLine(" Parqueos: " + Parqueos);
            Console.WriteLine(" Habitaciones: " + Habitaciones);
            Console.WriteLine(" Baños: " + Baños);



            Console.ReadKey();
            Console.WriteLine("Saliendo...");

        }
    }

}
