using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoAula
{
    class Usuario
    {
        private String nombre;
        private String apellido;
        private String sexo;
        private String direccion;
        private String ciudad;
        private String fechaNacimiento;
        private int edad;
        private String departamento;
        private String nacionalidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }

        public Usuario() { }

    }
}
