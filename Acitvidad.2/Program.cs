using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acitvidad._2
{
    class Program
    {
        static int horassemana, horas1, horasfinde, horas2, valor, valorhora, mes, mes1,
                    año, año1, rut, rut1, anti, anticipo, desc, descuento, bon, bonos, descuentofonasa1;
        static double pagosemana, pagofinde, descuentofonasa;
        static string nom, nombre, ape, apellidos, isapre, ssalud, afp;
        static void Main(string[] args)
        {

            cantidadhorasemana();
            cantidadhorasfinde();
            Valorhora();
            Pagosemana();
            PagoFinde();
            Mes();

            Año();
            Rut();
            Nombre();
            Apellidos();

            Anticipos();
            Descuento();
            Bonos();
            SistemaSalud();
            AFP();
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
        static double Pagosemana()
        {
            pagosemana = (horassemana * valorhora);
            return pagosemana;
        }
        static double PagoFinde()
        {
            pagofinde = horasfinde * (valorhora * 1.5);
            return pagofinde;
        }
        public static double Sueldo()
        {
            double sueldototal;
            sueldototal = pagosemana + pagofinde;
            return sueldototal;
        }
        static void Mes()
        {
            try
            {
                Console.WriteLine("Ingrese Mes: ");
                mes = Convert.ToInt16(Console.ReadLine());
                mes1 = mes;

            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Error MES NO PUEDE SER CERO");
                Mes();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese solo numeros!");
                Mes();
            }
            if (mes1 <= 0 || mes1 > 12)
            {
                Console.WriteLine("MES FUERA DE RANGO!");
                Mes();
            }
        }
        static void Año()
        {
            try
            {
                Console.WriteLine("Ingrese Año: ");
                año = Convert.ToInt16(Console.ReadLine());
                año1 = año;

            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Error AÑO NO PUEDE SER CERO");
                Console.ReadKey();
                Año();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese solo numeros!");
                Año();
            }
        }
        static void Rut()
        {
            try
            {
                Console.WriteLine("Ingrese su Rut: (SIN DIGITO VERIFICADOR)");
                rut = Convert.ToInt32(Console.ReadLine());
                rut1 = rut;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Error RUT NO PUEDE SER CERO");
                Console.ReadKey();
                Año();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese solo numeros!");
                Año();
            }
        }
        static void Nombre()
        {
            try
            {
                Console.WriteLine("Ingrese su Nombre: ");
                nom = Console.ReadLine();
                nombre = nom;

            }
            catch (ArgumentException)
            {
                Nombre();
            }
        }
        static void Apellidos()
        {
            try
            {
                Console.WriteLine("Ingrese sus Apellidos: ");
                ape = Console.ReadLine();
                apellidos = ape;

            }
            catch
            {
                Apellidos();
            }
        }

        static void Anticipos()
        {
            try
            {
                Console.WriteLine("Ingrese Anticipo Otorgado: ");
                anti = Convert.ToInt32(Console.ReadLine());
                anticipo = anti;

            }

            catch (FormatException)
            {
                Console.WriteLine("Ingrese solo numeros!");
                Anticipos();
            }
        }
        static void Descuento()
        {
            try
            {
                Console.WriteLine("Ingrese Descuento: ");
                desc = Convert.ToInt16(Console.ReadLine());
                descuento = desc;

            }

            catch (FormatException)
            {
                Console.WriteLine("Ingrese solo numeros!");
                Descuento();
            }
        }
        static void Bonos()
        {
            try
            {
                Console.WriteLine("Ingrese Bonos Otorgados: ");
                bon = Convert.ToInt16(Console.ReadLine());
                bonos = bon;

            }

            catch (FormatException)
            {
                Console.WriteLine("Ingrese solo numeros!");
                Bonos();
            }
        }
        static void SistemaSalud()
        {
            Console.WriteLine("Seleccione su sistema de salud: \n 1 Fonasa \n 2 Isapre ");
            ssalud = Console.ReadLine();
            if (ssalud == "1")
            {
                ssalud = "Fonasa";
                double descuentofonasa = ((Sueldo() - (descuento) - (anticipo) + bonos) - ((Sueldo() - (descuento) - (anticipo) + bonos) * 7 / 100));
                Console.WriteLine("Sueldo Liquido es: " + descuentofonasa);
                
            }
            else if (ssalud == "2")
            {
                ssalud = "Isapre";
                Console.WriteLine("Seleccione su Isapre: \n 1 Banmedica \n 2 GoldenCross \n 3 Consalud \n 4 CruzBlanca \n 5 MasVida");
                isapre = Console.ReadLine();
                if (isapre == "1")
                {
                    Console.WriteLine("Sueldo liquido es: $" + ((Sueldo() - (descuento) - (anticipo) + bonos) - ((Sueldo() - (descuento) - (anticipo) + bonos) - 30000)));
                    Console.ReadLine();
                }
                else if (isapre == "2")
                {
                    Console.WriteLine("Sueldo liquido es: $" + ((Sueldo() - (descuento) - (anticipo) + bonos) - ((Sueldo() - (descuento) - (anticipo) + bonos) - 45000)));
                    Console.ReadLine();
                }
                else if (isapre == "3")
                {
                    Console.WriteLine("Sueldo liquido es: $" + ((Sueldo() - (descuento) - (anticipo) + bonos) - ((Sueldo() - (descuento) - (anticipo) + bonos) - 46500)));
                    Console.ReadLine();
                }
                else if (isapre == "4")
                {
                    Console.WriteLine("Sueldo liquido es: $" + ((Sueldo() - (descuento) - (anticipo) + bonos) - ((Sueldo() - (descuento) - (anticipo) + bonos) - 35000)));
                    Console.ReadLine();
                }
                else if (isapre == "5")
                {
                    Console.WriteLine("Sueldo liquido es: $" + ((Sueldo() - (descuento) - (anticipo) + bonos) - ((Sueldo() - (descuento) - (anticipo) + bonos) - 49980)));
                    Console.ReadLine();
                }
            }
            else if (ssalud != "1" || ssalud != "2" || ssalud != "3" || ssalud != "4" || ssalud != "5")
            {
                ssalud = "No ingreso numero o no es correcto!";
            }
        }
        static void AFP()
        {
            Console.WriteLine("Seleccione AFP:\n 1 Capital \n 2 Habitat \n 3 Cuprum \n 4 PlanVital \n 5 Provida \n 6 Modelo");
            afp = Console.ReadLine();
            if (afp == "1")
            {
                Console.WriteLine("Sueldo liquido es: $" + ((Sueldo() - (descuento) - (anticipo) + bonos) - ((Sueldo() - (descuento) - (anticipo) + bonos) * (11.44 / 100))));
                Console.ReadLine();
            }
            else if (afp == "2")
            {
                Console.WriteLine("Sueldo liquido es: $" + ((Sueldo() - (descuento) - (anticipo) + bonos) - ((Sueldo() - (descuento) - (anticipo) + bonos) * (11.27 / 100))));
                Console.ReadLine();
            }
            else if (afp == "3")
            {
                Console.WriteLine("Sueldo liquido es: $" + ((Sueldo() - (descuento) - (anticipo) + bonos) - ((Sueldo() - (descuento) - (anticipo) + bonos) * (11.48 / 100))));
                Console.ReadLine();
            }
            else if (afp == "4")
            {
                Console.WriteLine("Sueldo liquido es: $" + ((Sueldo() - (descuento) - (anticipo) + bonos) - ((Sueldo() - (descuento) - (anticipo) + bonos) * (10.47 / 100))));
                Console.ReadLine();
            }
            else if (afp == "5")
            {
                Console.WriteLine("Sueldo liquido es: $" + ((Sueldo() - (descuento) - (anticipo) + bonos) - ((Sueldo() - (descuento) - (anticipo) + bonos) * (11.54 / 100))));
                Console.ReadLine();
            }
            else if (afp == "6")
            {
                Console.WriteLine("Sueldo liquido es: $" + ((Sueldo() - (descuento) - (anticipo) + bonos) - ((Sueldo() - (descuento) - (anticipo) + bonos) * (10.77 / 100))));
                Console.ReadLine();
            }
        }
        static void Mostrar()
        {

            Console.Clear();
            System.Console.BackgroundColor = ConsoleColor.Blue;
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(nombre + "  " + apellidos + "  Rut: " + rut);
            Console.WriteLine("Horas Normales:- - - - - - - - - - - - - - - - - - - - - - - - - - - - - " + horas1);
            Console.WriteLine("Horas Fines de Semana: - - - - - - - - - - - - - - - - - - - - - - - - - " + horas2);
            Console.WriteLine("Valor Hora: - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  " + valorhora);
            Console.WriteLine("Mes : - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  " + mes1);
            Console.WriteLine("Año : - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  " + año1);
            Console.WriteLine("AFP : - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  " + ssalud);
            Console.WriteLine("DES SALUD : - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  " + afp);
            Console.WriteLine("Anticipo : - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - " + anticipo);
            Console.WriteLine("Descuento : - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  " + descuento);
            Console.WriteLine("Bonos : - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  " + bonos);
            Console.WriteLine("Total $ Semana: - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" + pagosemana);
            Console.WriteLine("Total $ Fines de Semana: - - - - - - - - - - - - - - - - - - - - - - - - " + pagofinde);

            Console.WriteLine("Sueldo Liquido : - - - - - - - - - - - - - - - - - - - - - - - - - - - - " + (Sueldo() + bonos - (descuento + anticipo)));

            Console.ReadKey();
        }
    }
}

