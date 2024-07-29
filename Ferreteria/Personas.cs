using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria
{
    public class Personas
    {
        private Int32 _id;
        private string _name;
        private string _correo;
        private string _direccion;
        private string _telefono;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }

        public Personas() { }

        public Personas(int id, string name, string correo, string direccion, string telefono)
        {
            this.Id = id;
            this.Name = name;
            this.Correo = correo;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }
    }
}
