using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClaseDosCS
{
    public class Vehiculo
    {

        private string Marca { get; set; }
        private string Modelo { get; set; }
        private string Color { get; set; }
        private string Llantas { get; set; }
        private string Placa { get; set; }
        private string Motor { get; set; }
        private string Vin { get; set; }

        // CRUD -> create, read, update, delete

        public void createVehicle()
        {
            Vehiculo vehiculo = new Vehiculo();

            Console.Write("Ingrese la marca: ");
            vehiculo.Marca = ReadLine();

            Console.Write("Ingrese el modelo: ");
            vehiculo.Modelo = ReadLine();

            Console.Write("Ingrese la color: ");
            vehiculo.Color = ReadLine();

            Console.Write("Ingrese la llantas: ");
            vehiculo.Llantas = ReadLine();

            Console.Write("Ingrese la placa: ");
            vehiculo.Placa = ReadLine();

            Console.Write("Ingrese el motor: ");
            vehiculo.Motor = ReadLine();

            Console.Write("Ingrese el vin: ");
            vehiculo.Vin = ReadLine();

            WriteLine("");

        }

        public void readVehicle()
        {
            WriteLine(Marca);
            WriteLine(Modelo);
            WriteLine(Color);
            WriteLine(Placa);
            WriteLine(Llantas);
            WriteLine(Vin);
            WriteLine(Motor);

        }

        public string[] getInfoCoche()
        {
            string[] values = { Marca, Modelo, Color, Placa, Llantas, Vin, Motor };

            return values;
        }

    }
}
