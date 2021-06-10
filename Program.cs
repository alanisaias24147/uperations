using System;
using System.IO;

namespace operaciones
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //intentar ejecutar el codigo
                Console.WriteLine("ingresa valor de a");
                float a = float.Parse(Console.ReadLine());

                Console.WriteLine("ingresa valor de b");
                float b = float.Parse(Console.ReadLine());

                float result = a / b;
                Console.WriteLine($"{a}/ {b} = {result}");

                using (StreamWriter sw = new StreamWriter("operacion.txt"))
                {
                    sw.WriteLine($"{a} / {b} = {result}");
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("ingresa el valor adecuado");
                //throw;
            }
            finally
            {
                Console.WriteLine("este mensaje siempre se muestra");
            }
        }
    }
}
