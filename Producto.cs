using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoAula
{
    class Producto
    {
        public String nombre;
        public double isbn;
        public String tipo;
        public String marca;
        public String proveedor;
        public double precio;

        public Producto() { }
        public Producto(String nombre,double isbn,String tipo,String marca,String proveedor,double precio)
        {
            this.nombre = nombre;
            this.isbn = isbn;
            this.tipo = tipo;
            this.marca = marca;
            this.proveedor = proveedor;
            this.precio = precio;
        }
    }
}
