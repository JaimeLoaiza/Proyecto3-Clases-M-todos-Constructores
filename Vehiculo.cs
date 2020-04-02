using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClasesMetodosyConstructores
{
    class Vehiculo
    {
        //Propiedades
        public string marca;
        public string placa;
        public int modelo;
        //Constructor
        public Vehiculo(string marca, string placa, int modelo)
        {
            this.marca = marca;
            this.placa = placa;
            this.modelo = modelo;
        }
    }
}
