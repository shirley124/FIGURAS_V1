using System;
using System.Collections.Generic;
using System.Text;

namespace FIGURAS_V1
{
    class FIGURAS
    {
        public decimal area { get; set;} //get set son de tipo lectura y escritura, sintaxis para declarar un atributo
        decimal lado;
        decimal ancho;
        decimal radio;

        public void areaCuadrado() 
        {
            Console.WriteLine("Escribe el lado: ");
          lado = Convert.ToDecimal(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("El resultado del area es: " + area);

        }


    }
}
