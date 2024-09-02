using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion5_Ejercicio1.models
{
   internal class Exercise
   {

      public Exercise() { }

      public bool esMayor(int num1, int num2)
      {
         return num1 > num2;
      }
      public bool esMenor(int num1, int num2)
      {
         return num1 < num2;
      }

      public string EvalueDay(int day)
      {
         switch (day)
         {
            case 1:
               return "Lunes";
               break;
            case 2:
               return "Martes";
               break;
            case 3:
               return "Miércoles";
               break;
            case 4:
               return "Jueves";
               break;
            case 5:
               return "Viernes";
               break;
            case 6:
               return "Sábado";
               break;
            case 7:
               return "Domingo";
               break;
            default:
               return "Número ingresado no pertenece a ningún día";
               break;
         }
      }
   }
}
