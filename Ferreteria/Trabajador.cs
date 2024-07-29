using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria
{
    internal class Trabajador
    {
        private Int32 _id;
        private string _nombre;
        private string _apellido;
        private string _numero_de_pago;
        private string _area;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Numero_de_pago { get => _numero_de_pago; set => _numero_de_pago = value; }
        public string Area { get => _area; set => _area = value; }

        public Trabajador() { }

        public Trabajador(int id, string nombre, string apellido, string numero_de_pago, string area)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Numero_de_pago = numero_de_pago;
            this.Area = area;
        }
    }
}
