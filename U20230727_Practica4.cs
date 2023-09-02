using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
        Console.WriteLine("\n************** Estructuras de control selectivas en C# **************");
        Console.WriteLine("\n Opciones ");

        Console.WriteLine("1.Determinar si el numero es positivo, negativo o igual a cero. ");
        Console.WriteLine("2. Mostrar fecha y hora actual: ");
        Console.WriteLine("3.Determinar si puede votar y conducir legalmente,");
        Console.WriteLine("4.Determinar si el numero es par o impar");
        Console.WriteLine("\n Elija una opcion"); 
        int opcion = Convert.ToInt32(Console.ReadLine());



        if (opcion == 0){
            Console.WriteLine("\nIngrese un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0 ){
                Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("Su numero es positivo");

            }
            else if (numero < 0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Su numero es negativo");
            }
         else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Su numero es igual a 0");

            }
        }

        else if (opcion == 2) {
            Console.ForegroundColor = ConsoleColor.Red;
            DateTime FechaHora = DateTime.Now;
             Console.WriteLine("\n La fecha y hora actual es:" + FechaHora);
        }
        else
        {
            switch (opcion) {
                    case 3:
                        Console.WriteLine("Ingrese su edad: ");
                        int edad = Convert.ToInt32(Console.ReadLine());

                    if (edad >= 18 ){
                        Console.ForegroundColor = ConsoleColor.Red; 
                        Console.WriteLine("Eres mayor de edad y puedes votar y conducir legalmente. ");

                    }
                    break;


                case 4: 
                    Console.WriteLine("\n Ingrese un numero: ");
                    int Numero = Convert.ToInt32(Console.ReadLine());
                    
                    if (Numero % 2 == 0 )
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                         Console.WriteLine("\n El numero ingresado es par \n");
                    }

                    else {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine ("\n El numero ingresado es impar. \n");

                        }
                            
                             break; 
                    default:
                    Console.WriteLine("Opcion invalda intente de nuevo"); break;
                    
                 
            }
        }  
        Console.ReadKey();
        Console.ResetColor();
       }
          
    }
        
}