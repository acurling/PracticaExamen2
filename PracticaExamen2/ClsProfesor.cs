using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen2
{
    internal class ClsProfesor
    {

        // delimitadores de acceso public private protected

        // Atributos

        private string cedula { get; set; }  // cedula
        private string nombre { get; set; }
        private float salario { get; set; }
        public static float precio = 300f;

        // contructor




        public ClsProfesor(string Cedula, string Nombre, float Salario)
        {
            this.cedula = Cedula;
            this.nombre = Nombre;
            this.salario = Salario;
        }
        public ClsProfesor(string cedula)
        {
            this.cedula = cedula;
        }

        public ClsProfesor()
        {
        }

        public void SetCedula(string cedula) // asignar
        {
            this.cedula = cedula;
        }

        public string GetCedula()  // imprimir valor
        {
            return cedula;
        }
        public void Agregar() { }
        public void Borrar() { }
        public void Consultar() { }
        public void imprimir()

        {
            cedula = "30";
            Console.WriteLine(cedula);
        }
    }
}
