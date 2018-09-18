using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase02
{
    class Program
    {

        static void ejerciocio1 ()
        {
            int a, b;
            a = 10;
            b = 55;
            if(a>b)
            {
                Console.WriteLine("A es maypr a B");
            }
            else
            {
                Console.WriteLine("B es mayor que A");
            }
        }
        static void ejercicio2 ()
        {
            string numero="", mensaje="";
            Console.Write("ingrese un numero: ");
            numero = Console.ReadLine();
            if (numero == "1")
                mensaje = "Ganaste una bandera";
            else if (numero == "2")
                mensaje = "ganaste un banderin";
            else if (numero == "3")
                mensaje = "Suerte la proxima";
            else
                mensaje = "Respuesta incorecta ";

            Console.WriteLine(mensaje);
        }
        static void ejercicio3 ()
        {
            int a=10, b=15, c=15;
            string mensaje = "";
           
            
            if (a > b)
            {
                if (a > c)
                {
                    mensaje = "el mayor es A";
                }
                else
                    mensaje = "el mayor es C";

            }
            else if (b > c)
            {
                mensaje = "El mayor es B";
            }
            else
                mensaje = "el mayor es C";

;            Console.WriteLine(mensaje);
        }
        static void ejercicio4 ()
        {
            string usuario, contraseña,mensaje;
            Console.Write("ingrese usuario: ");
            usuario = Console.ReadLine();
            Console.Write("ingrese contraseña: ");
            contraseña = Console.ReadLine();

            usuario = usuario.ToUpper();
            if (usuario == "PEPE")
            {
                if (contraseña == "ABC")
                {
                    mensaje = "Bienvenido";
                }
                else
                    mensaje = "contraseña incorecta";
            }
            else
                mensaje = "Usuario incorecto";

            Console.WriteLine(mensaje);


        }

        static void ejercicio5()
        {
            string numero, mensaje;
            Console.Write("ingrese un numero: ");
            numero = Console.ReadLine();

            switch (numero)
            {
                case "1":
                    mensaje=("gano una camiseta");

                    break;
                case "2":
                    mensaje=("gano una bandera");


                    break;
                case "3":
                    mensaje=("no gano nada");

                    break;
                default:
                     mensaje = "numero incorecto";
                    break;

            }

            Console.WriteLine(mensaje);

        }

        static void ejercicio6()
        {
            string usuario, contraseña,mensaje;

        Console.Write("ingrese usuario: ");
            usuario = Console.ReadLine();


        Console.Write("ingrese contraseña: ");
            contraseña = Console.ReadLine();

            usuario = usuario.ToUpper();

            switch(usuario)
            {
                case "PEPE":
                    if (contraseña == "ABC")
                        mensaje = "bienvenido pepe";
                    else
                        mensaje = "contraseña incorrecta";
                    break;

                case "PEDRO":
                    if (contraseña == "123")
                        mensaje = "bienvenido pedro";
                    else
                        mensaje = "contraseña incorrecta";
                    break;

                case "MARIA":
                    if (contraseña == "XXX")
                        mensaje = "bienvenido maria";
                    else
                        mensaje = "contraseña incorrecta";
                    break;
                default:
                    mensaje = "usuario incorrecto";
                    break;

            }
            Console.WriteLine(mensaje);

        }



    static void Main(string[] args)
        {
            ejercicio6();
            Console.ReadKey();

        }
    }
}
