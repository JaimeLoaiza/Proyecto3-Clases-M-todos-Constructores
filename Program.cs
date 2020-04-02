using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClasesMetodosyConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo mivehiculo = new Vehiculo("Renault","SMV639",2011);
            Console.WriteLine("La marca del Vehiculo es: " + mivehiculo.marca);
            Console.WriteLine("La placa del Vehiculo es: " + mivehiculo.placa);
            Console.WriteLine("El modelo del Vehiculo es: " + mivehiculo.modelo);
            Console.ReadKey();
        }
    }
}
