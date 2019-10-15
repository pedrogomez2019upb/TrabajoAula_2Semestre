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
        public String Precio { get => precio; set => precio = value; }
        public string FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }

        public Producto() { }
        public Producto(String nombre,String isbn,String tipo,String marca,String proveedor,String precio,String fechaIngreso)
        {
            this.nombre = nombre;
            this.isbn = isbn;
            this.tipo = tipo;
            this.Marca = marca;
            this.Proveedor = proveedor;
            this.Precio = precio;
            this.fechaIngreso = fechaIngreso;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6}", Nombre, Isbn, Tipo, Marca, Proveedor, Precio, fechaIngreso);

        }
    }
}
