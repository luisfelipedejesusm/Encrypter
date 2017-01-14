using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        private static Program p = 
            new Program();
        static void Main(string[] args)
        {
            p.menu();
            Console.ReadKey();
        }
        private void menu()
        {
            Console.WriteLine("Encriptador");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1) Encriptar");
            Console.WriteLine("2) Desencriptar");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Seleccione una Opcion : ");
            var opcion = Console.ReadLine().ToString();

            switch (opcion.ToString())
            {
                case "1":
                    metodo(1);
                    break;
                case "2":
                    metodo(2);
                    break;
                default:
                    Console.WriteLine("No es una opcion valida");
                    Console.WriteLine("-------------------------------------------");
                    menu();
                    break;
            }
        }
        public void metodo(int opcion)
        {
            var metodo = "";
            Console.WriteLine("Seleccione El Metodo a Utilizar");
            Console.WriteLine("1) Clasico");
            Console.WriteLine("2) Cesar 4 posiciones");
            metodo = Console.ReadLine();
            switch (opcion)
            {
                case 1:
                    switch (metodo)
                    {
                        case "1":
                            Encriptar(1);
                            break;
                        case "2":
                            Encriptar(2);
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (metodo)
                    {
                        case "1":
                            desencriptar(1);
                            break;
                        case "2":
                            desencriptar(2);
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        private void Encriptar(int metodo)
        {
            var resultado = "";
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Escriba ahora el texto a encriptar");
            var texto = Console.ReadLine();
            if (texto != null)
            {
                switch (metodo)
                {
                    case 1:
                        resultado = scriptClasico(texto);
                        break;
                    case 2:
                        resultado = scriptCesar(texto,1);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Texto encriptado correctamente : ");
            Console.WriteLine(resultado);     
            Console.WriteLine("Volver al menu y/n");
            var opcion = Console.ReadLine();
            switch (opcion.ToString())
            {
                case "y":
                    Console.WriteLine("-------------------------------------------");
                    menu();                    
                    break;
                case "n":
                    break;
                default:
                    Console.WriteLine("No es una opcion valida. Redireccionando al Menu");
                    Console.WriteLine("-------------------------------------------");
                    menu();
                    break;
            }

            
        }
        private void desencriptar(int metodo)
        {
            var resultado = "";
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Escriba ahora el texto a Desencriptar");
            var texto = Console.ReadLine();
            if (texto != null)
            {
                switch (metodo)
                {
                    case 1:
                        resultado = scriptClasico(texto);
                        break;
                    case 2:
                        resultado = scriptCesar(texto, 2);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Texto desencriptado correctamente : ");
            Console.WriteLine(resultado);
            Console.WriteLine("Volver al menu y/n");
            var opcion = Console.ReadLine();
            switch (opcion.ToString())
            {
                case "y":
                    Console.WriteLine("-------------------------------------------");
                    menu();
                    break;
                case "n":
                    break;
                default:
                    Console.WriteLine("No es una opcion valida. Redireccionando al Menu");
                    Console.WriteLine("-------------------------------------------");
                    menu();
                    break;
            }
        }
        private string scriptClasico(string texto)
        {
            var resultado = "";
            var posiciones = texto.Length;
            for (int x = 0; x < posiciones; x++)
            {
                resultado = texto[x].ToString() + resultado;
            }
            
            return resultado;
        }
        private string scriptCesar(string texto, int opcion)
        {
            string cadena = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[] ";
            string cadena2 = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[] abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";
            var resultado = "";
            int count=0;
            for (int x = 0; x<texto.Length; x++)
            {
                while (texto[x]!=cadena[count])
                {
                    count++;
                }

                switch (opcion)
                {
                    case 1:
                        resultado = resultado + cadena2[count + 4];
                        break;
                    case 2:
                        resultado = resultado + cadena2[count - 4 ];
                        break;
                }
                count = 0;
            }
            return resultado;
        }
    }


}
