using ClaseDosCS;
using System;
using System.Numerics;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;

            Vehiculo[] vehiculos = new Vehiculo[2];
            do
            {
                Console.Clear();

                Console.WriteLine("***Menu***");
                Console.WriteLine("1. Registrar vehiculo");
                Console.WriteLine("2. Mostrar vehiculo");
                Console.WriteLine("0. Salir");
                option = int.Parse(Console.ReadLine());



            switch(option)
            {
                case 1:
                    //Console.WriteLine("Registrar");
                    for(int i = 0; i < vehiculos.Length; i++)
                        {
                            Console.WriteLine($"Vehiculo *******# {i + 1}");

                            vehiculos[i] = new Vehiculo();

                            vehiculos[i].createVehicle();
                        }
                    break;

                case 2:
                    //Console.WriteLine("Mostrar");

                        for(int i = 0; i < vehiculos.Length; i++)
                        {
                            Console.WriteLine($"Vehiculo *******# {i + 1}");
                            vehiculos[i].getInfoCoche();
                        }

                        Console.ReadKey();

                    break;

                default:
                    Console.WriteLine("Selecione una opcion valida");
                    break;

            }

            } while (option != 0);


        }
    }
   
}