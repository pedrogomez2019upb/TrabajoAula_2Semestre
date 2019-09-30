using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoAula
{
    class Producto
    {
        private String nombre;
        private double isbn;
        private String tipo;
        private String marca;
        private String proveedor;
        private double precio;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Isbn { get => isbn; set => isbn = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public double Precio { get => precio; set => precio = value; }

        public Producto() { }
        public Producto(String nombre,double isbn,String tipo,String marca,String proveedor,double precio)
        {
            this.nombre = nombre;
            this.isbn = isbn;
            this.tipo = tipo;
            this.Marca = marca;
            this.Proveedor = proveedor;
            this.Precio = precio;
        }
    }
}
