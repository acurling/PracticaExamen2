using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen2
{
    internal class Clsestudiante
    {
        // Atributos de un estudiante
        static string[] cedula = new string[10];  // 10108708505
        static string[] nombre = new string[10];  // 60984701523
        static float[] promedio = new float[10];

        // metodos

        public static void Inicializar()
        {
            cedula= Enumerable.Repeat("", 10).ToArray();
            nombre=Enumerable.Repeat("",10).ToArray();
            promedio=Enumerable.Repeat(0f,10).ToArray(); 
            
            foreach(var numero in promedio)
            {
                Console.WriteLine(numero);
            }
        }

        public static void incluirEstudiantes()
        {

        }

       static public void Agregar() { }
       static public void Borrar() { }
      static  public void Consultar() { }
      

    }
}
