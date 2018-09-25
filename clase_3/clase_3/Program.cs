using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_3
{
    class Program
    {


        static void ejercicio1()
        {
            string respuesta = "";
            do
            {
                Console.Write("Desea seguir?");
                respuesta = Console.ReadLine().ToUpper();

            } while (respuesta != "SI");


        }

        static void ejercicio2()
        {
            int a = 1;
            do
            {
                Console.WriteLine(a);
                a++;

            } while (a <= 10);
        }

        static void ejercicio3()
        {

            int a = 1;
            do
            {
                if (!(a == 4 || a == 7 || a == 9))
                    Console.WriteLine(a);
                

                a++;

            } while (a <= 10);
        }
 
        static void ejercicio4()
        {
            int a = 1;
            do
            {   
                if(a<7||a>12)
                Console.WriteLine(a);

                a++;

            } while (a <= 20);

        }

        static void ejercicio5()
        {
            int a = 1, b = 1,limite = 5;
            while(a<=limite)
            {
                
                while(b<=limite)
                {
                    Console.WriteLine("{0} ---> {1}",a,b);
                    b++;
                }
                Console.WriteLine("----------------------");
                a++;
                b = 1;
            }

        }
        static void ejercicio6()
        {
            int a = 1,b=1;
            while (a <= 5)
            {

                while(b <= a)
                {
                    Console.Write("X");
                    b++;

                }
                Console.WriteLine();
               a++;
                b = 1; 
            }

        }
     
        static void Main(string[] args)
        {
            ejercicio6();
            Console.ReadKey();
        }
   }
    }

