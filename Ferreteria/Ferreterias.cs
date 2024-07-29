using DocumentFormat.OpenXml.Office2013.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria
{
    public class Ferreterias
    {
        private Int32 _id;
        private string _nombreFerreteria;
        private string _direccion;
        private string _telefono;

        public int Id { get => _id; set => _id = value; }
        public string NombreFerreteria { get => _nombreFerreteria; set => _nombreFerreteria = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }

        public Ferreterias() { }

        public Ferreterias(int id, string nombreFerreteria, string direccion, string telefono)
        {
            this.Id = id;
            this.NombreFerreteria = nombreFerreteria;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }
    }
}
