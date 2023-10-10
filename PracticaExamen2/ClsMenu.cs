using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen2
{
    internal class ClsMenu
    {
        // atributo
        static int opcion = 0;  // global

        // metodo
        static public void Desplegar()
        {
            do
            {
                Console.WriteLine("1- Inicializar Vectores");
                Console.WriteLine("2- Incluir Estudiantes");
                Console.WriteLine("3- Consultar Estudiantes");
                Console.WriteLine("4-Salir");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: Clsestudiante.Inicializar(); break;
                    case 2: Clsestudiante.Agregar(); break;
                    case 4: Clsestudiante.Consultar(); break;
                    default:
                        break;
                }
            } while (opcion != 3);
        }
    }
}
