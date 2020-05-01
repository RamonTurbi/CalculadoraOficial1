using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
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
            return resultado = cantidaUno + cantidad2; 
        }
        //segun lo que entendi este es un ejemplo de poliformismo
        public string Suma(string expresion1, string expresion2) 
        {
            string resultado;
            return resultado = expresion1 + expresion2;
        }
        public double Resta(double cantidaUno, double cantidad2)
        { 
            return resultado = cantidaUno - cantidad2;
        }
        public double Multiplicacion(double cantidaUno, double cantidad2)
        {
            return resultado = cantidaUno * cantidad2;
        }
        public double Division(double cantidaUno, double cantidad2)
        { 
            return resultado = cantidaUno / cantidad2;
        }

    }
}
