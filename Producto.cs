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
        private String isbn;
        private String tipo;
        private String marca;
        private String proveedor;
        private String precio;
        private String fechaIngreso;

        public string Nombre { get => nombre; set => nombre = value; }
        public String Isbn { get => isbn; set => isbn = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public string FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string Precio { get => precio; set => precio = value; }

        public Producto(string line)
        {
           
            string[] datos = line.Split(',');
            Nombre = datos[0];
            Isbn = datos[1];
            Tipo = datos[2];
            Marca = datos[3];
            Proveedor = datos[4];
            Precio = datos[5];
            FechaIngreso = datos[6];
        }
        public Producto(String nombre,String isbn,String tipo,String marca,String proveedor,String precio,String fechaIngreso)
        {
            this.nombre = nombre;
            this.isbn = isbn;
            this.tipo = tipo;
            this.Marca = marca;
            this.Proveedor = proveedor;
            this.precio = precio;
            this.fechaIngreso = fechaIngreso;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6}", Nombre, Isbn, Tipo, Marca, Proveedor, Precio, fechaIngreso);

        }
    }
}
