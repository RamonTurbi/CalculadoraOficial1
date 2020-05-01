using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOficial.Clases
{
    /*La clase al igual que los metodos utilizan el limitador de acceso Publico para que puedan ser usados por cualquier otra clase 
     dek proyecto*/
    public class OpreacionesAritmeticas
    {
        //Aqui utilizo el encapsulamiento privatizando esta variable para que solo pueda ser utilizado en esta clase
        private double resultado;
        //aqui las Variables cantidauno y cantidad2 se toman como parametros de entrada del metodo las cuales influiran en el resultado del metodo.
        public double Suma(double cantidaUno, double cantidad2)
        {
            resultado = cantidaUno + cantidad2;
            return resultado;
        }
        public double Resta(double cantidaUno, double cantidad2)
        {
            resultado = cantidaUno - cantidad2;
            return resultado;
        }
        public double Multiplicacion(double cantidaUno, double cantidad2)
        {
            resultado = cantidaUno * cantidad2;
            return resultado;
        }
        public double Division(double cantidaUno, double cantidad2)
        {
            resultado = cantidaUno / cantidad2;
            return resultado;
        }

    }
}
