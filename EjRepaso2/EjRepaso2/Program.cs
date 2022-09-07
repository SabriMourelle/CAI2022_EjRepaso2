using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjRepaso2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Ejercicio II
            //Crear una aplicación que cuente desde el número 1 hasta los últimos tres dígitos del
            //propio número de registro(en caso de ser comenzar con 0, sumarle 100) e identificar
            //los múltiplos de 3 y, también, aquellos que sean números primos.Para ambos casos
            //(múltiplo de 3 y primos), deben mostrar el número en cuestión y " Es divisible por 3",
            //"Es primo" y, en caso de ser ambos “Es primo y divisible por 3”.
            //Por ejemplo, con el primer número mostrará “1 – Es primo”. 

            //registro 866644

            int _registro;
            string _pantalla;
            int _numero;

            _pantalla = "";
            _numero = 0;

            Console.WriteLine("Ingrese últimos 3 numeros del nro de registro");
            _registro = Int32.Parse(Console.ReadLine());
            Console.Clear();

            do
            {
                _numero = _numero + 1;
                if (_numero % 3 == 0)
                {
                    if (EsPrimo(_numero))
                    {
                        _pantalla = _pantalla + _numero + "Es primo y es divisible por 3" + "\n";
                    }
                    else
                    {
                        _pantalla = _pantalla + _numero + "Es divisible por 3" + "\n";
                    }
                }
                else
                {
                    if (EsPrimo(_numero))
                    {
                        _pantalla = _pantalla + _numero + "Es primo" + "\n";
                    }
                    else
                    {
                        _pantalla = _pantalla + _numero + "\n";
                    }

                }
            }
            while (_numero < _registro);

             bool EsPrimo (int numero)
            {
                for (int i=2; i<numero;i++)
                { 
                    if ((numero%i)==0)
                        {
                            return false;
                        }
                     
                }
                return true;
            }

            Console.WriteLine(_pantalla);
            Console.ReadKey();
        

    }
    }
}
