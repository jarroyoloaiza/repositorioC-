using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acitvidad._2
{
    class Program
    {
        static int horassemana, horas1, horasfinde, horas2, valor, valorhora;  
        static void Main(string[] args)
        {
            
            cantidadhorasemana();
            cantidadhorasfinde();
            Valorhora();
            Mostrar();
        }
            static void cantidadhorasemana()
             
                {
                    
                    
                    try
                    {
                        Console.WriteLine("Ingrese Cantidad de Horas Trabajadas en la semana ");
                        horassemana = Convert.ToInt16(Console.ReadLine());
                        horas1 = horassemana; 
                    }
                    catch (FormatException)
                    {
                         Console.WriteLine("Ingrese solo numeros");
                        cantidadhorasemana();
                    }
                 
                }
            static void cantidadhorasfinde()
                {
                    try
                    {
                        Console.WriteLine("Ingrese Cantidad de Horas Trabajadas en los fines de semana ");
                        horasfinde = Convert.ToInt16(Console.ReadLine());
                        horas2 = horasfinde;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ingrese solo numeros");
                        cantidadhorasfinde();
                    }
            }
            static void Valorhora()
                {
                    try
                    {
                        Console.WriteLine("Ingrese el valor de Hora:");
                        valor = Convert.ToInt16(Console.ReadLine());
                        valorhora = valor; 
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ingrese solo numeros!");
                        Valorhora();
                    }
            }

            static void Mostrar()
            {
                
                Console.Clear();
                System.Console.BackgroundColor = ConsoleColor.Blue;
                System.Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Horas Normales:- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - " + horas1);
                Console.WriteLine("Horas Fines de Semana: - - - - - - - - - - - - - - - - - - - - - - - - - - " + horas2);
                Console.WriteLine("Valor Hora: - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - " + valorhora);
                Console.ReadKey();
            }
        }
    }

