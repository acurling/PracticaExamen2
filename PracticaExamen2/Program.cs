using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen2
{
  
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //  ClsMenu.Desplegar();

            ClsProfesor Carlos = new ClsProfesor("1", "Carlos", 150f);  // instanciando
            ClsProfesor Sofia = new ClsProfesor("2", "Sofia", 300f);
            ClsProfesor Diana = new ClsProfesor("3", "Diana", 500f);
            ClsProfesor Luis = new ClsProfesor("4");
            ClsProfesor Mateo = new ClsProfesor();

            Mateo.SetCedula("5555");
            Console.WriteLine(Mateo.GetCedula()); 
            

           
            Console.Read();
        }
    }
}
