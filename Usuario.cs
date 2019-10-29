using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        public Usuario(string nombre,string apellido,string sexo,string ciudad,string fechaNacimiento,int edad,string departamento,string nacionalidad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Ciudad = ciudad;
            FechaNacimiento = fechaNacimiento;
            Edad = edad;
            Departamento = departamento;
            Nacionalidad = nacionalidad;
        }
        List<Usuario> listaUsuarios = new List<Usuario>();
        public void cargarUsuarios()
        {
            string line;
            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\Usuarios.txt" , Encoding.UTF8); 
            while ((line=sr.ReadLine())!=null)
                {
                string[] datos = line.Split(';');
                if (datos[0].Equals(this.Nombre))
                {
                    Usuario usuarioTemporal = new Usuario(datos[0], datos[1], datos[2], datos[3], datos[4], Int32.Parse(datos[5]), datos[6], datos[7]);
                    listaUsuarios.Add(usuarioTemporal);
                }
                

                }
        }
        public List<Usuario> recibirUsuarios()
        {
            return listaUsuarios; 
        }
    }
}
