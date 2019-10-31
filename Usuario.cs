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
        private String lugarNacimiento;
        private Double edad;
        private String departamento;
        private String nacionalidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        
        public string Departamento { get => departamento; set => departamento = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string LugarNacimiento { get => lugarNacimiento; set => lugarNacimiento = value; }
        public double Edad { get => edad; set => edad = value; }

        public Usuario() { }

        public Usuario(string nombre,string apellido,string sexo,string direccion,string ciudad,string fechaNacimiento,string lugarNacimiento,double edad,string departamento,string nacionalidad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Direccion = direccion;
            Ciudad = ciudad;
            FechaNacimiento = fechaNacimiento;
            LugarNacimiento = lugarNacimiento;
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
                string[] datos = line.Split(',');
                if (datos[0].Equals(this.Nombre))
                {
                    Usuario usuarioTemporal = new Usuario(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], Double.Parse(datos[7]),datos[8],datos[9]);
                    listaUsuarios.Add(usuarioTemporal);
                }
                

                }
            sr.Close();
        }
        public List<Usuario> recibirUsuarios()
        {
            return listaUsuarios; 
        }
        public Usuario(string line)
        {

            string[] datos = line.Split(',');
            Nombre = datos[0];
            Apellido = datos[1];
            Sexo = datos[2];
            Direccion = datos[3];
            FechaNacimiento = datos[4];
            LugarNacimiento = datos[5];
            Edad = Convert.ToDouble(datos[6]);
            Departamento = datos[7];
            Nacionalidad = datos[8];


        }
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}", Nombre, Apellido, Sexo, Direccion, FechaNacimiento, LugarNacimiento, Edad, Departamento, Nacionalidad);
        }

    }
}
