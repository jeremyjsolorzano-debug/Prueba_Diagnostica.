using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Diagnositca_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definimos variables
            char TipoJugo, TamanoVaso, TipoPago;
            double Precio = 0, PagoTotal = 0, Ajuste = 0, Porcentaje = 0;

            //Cuerpo
            Console.WriteLine("[N] - Naranja");
            Console.WriteLine("[F] - Fresa");
            Console.WriteLine("[L] - Lúcuma");
            Console.WriteLine("[P] - Papaya");
            Console.WriteLine("[S] - Surtido");
            Console.WriteLine("[X] - Piña");
            Console.WriteLine("-------------");
            Console.Write("Ingrese la letra correspondiente al tipo de jugo a comprar: ");
            TipoJugo = Convert.ToChar(Console.ReadLine());

            //ECM
            switch (TipoJugo)
            {
                //Caso del Jugo de Naranja
                case 'N':
                case 'n':
                    Console.WriteLine("[L] - Large");
                    Console.WriteLine("[M] - Medium");
                    Console.WriteLine("[S] - Small");
                    Console.WriteLine("-------------");
                    Console.Write("Ingrese la letra correspondiente al tamaño del vaso que desea: ");
                    TamanoVaso = Convert.ToChar(Console.ReadLine());
                    switch (TamanoVaso)
                    {
                        case 'L':
                        case 'l':
                            Precio = 15.50;
                            break;
                        case 'M':
                        case 'm':
                            Precio = 12.00;
                            break;
                        case 'S':
                        case 's':
                            Precio = 10.50;
                            break;
                        default:
                            Precio = 0;
                            break;
                    }
                    break;

                //Caso del Jugo de Fresa
                case 'F':
                case 'f':
                    Console.WriteLine("[L] - Large");
                    Console.WriteLine("[M] - Medium");
                    Console.WriteLine("[S] - Small");
                    Console.WriteLine("-------------");
                    Console.Write("Ingrese la letra correspondiente al tamaño del vaso que desea: ");
                    TamanoVaso = Convert.ToChar(Console.ReadLine());
                    switch (TamanoVaso)
                    {
                        case 'L':
                        case 'l':
                            Precio = 17.00;
                            break;
                        case 'M':
                        case 'm':
                            Precio = 13.70;
                            break;
                        case 'S':
                        case 's':
                            Precio = 11.50;
                            break;
                        default:
                            Precio = 0;
                            break;
                    }
                    break;

                //Caso del Jugo de Lúcuma
                case 'L':
                case 'l':
                    Console.WriteLine("[L] - Large");
                    Console.WriteLine("[M] - Medium");
                    Console.WriteLine("[S] - Small");
                    Console.WriteLine("-------------");
                    Console.Write("Ingrese la letra correspondiente al tamaño del vaso que desea: ");
                    TamanoVaso = Convert.ToChar(Console.ReadLine());
                    switch (TamanoVaso)
                    {
                        case 'L':
                        case 'l':
                            Precio = 14.20;
                            break;
                        case 'M':
                        case 'm':
                            Precio = 11.50;
                            break;
                        case 'S':
                        case 's':
                            Precio = 9.70;
                            break;
                        default:
                            Precio = 0;
                            break;
                    }
                    break;

                //Caso del Jugo de Papaya
                case 'P':
                case 'p':
                    Console.WriteLine("[L] - Large");
                    Console.WriteLine("[M] - Medium");
                    Console.WriteLine("[S] - Small");
                    Console.WriteLine("-------------");
                    Console.Write("Ingrese la letra correspondiente al tamaño del vaso que desea: ");
                    TamanoVaso = Convert.ToChar(Console.ReadLine());
                    switch (TamanoVaso)
                    {
                        case 'L':
                        case 'l':
                            Precio = 10.00;
                            break;
                        case 'M':
                        case 'm':
                            Precio = 8.50;
                            break;
                        case 'S':
                        case 's':
                            Precio = 6.50;
                            break;
                        default:
                            Precio = 0;
                            break;
                    }
                    break;

                //Caso del Jugo de Surtido
                case 'S':
                case 's':
                    Console.WriteLine("[L] - Large");
                    Console.WriteLine("[M] - Medium");
                    Console.WriteLine("[S] - Small");
                    Console.WriteLine("-------------");
                    Console.Write("Ingrese la letra correspondiente al tamaño del vaso que desea: ");
                    TamanoVaso = Convert.ToChar(Console.ReadLine());
                    switch (TamanoVaso)
                    {
                        case 'L':
                        case 'l':
                            Precio = 20.00;
                            break;
                        case 'M':
                        case 'm':
                            Precio = 17.00;
                            break;
                        case 'S':
                        case 's':
                            Precio = 15.00;
                            break;
                        default:
                            Precio = 0;
                            break;
                    }
                    break;

                //Caso del Jugo de Piña
                case 'X':
                case 'x':
                    Console.WriteLine("[L] - Large");
                    Console.WriteLine("[M] - Medium");
                    Console.WriteLine("[S] - Small");
                    Console.WriteLine("-------------");
                    Console.Write("Ingrese la letra correspondiente al tamaño del vaso que desea: ");
                    TamanoVaso = Convert.ToChar(Console.ReadLine());
                    switch (TamanoVaso)
                    {
                        case 'L':
                        case 'l':
                            Precio = 11.50;
                            break;
                        case 'M':
                        case 'm':
                            Precio = 9.40;
                            break;
                        case 'S':
                        case 's':
                            Precio = 7.20;
                            break;
                        default:
                            Precio = 0;
                            break;
                    }
                    break;

                default:
                    Precio = -1;
                    break;
            }

            //ECA
            if (Precio == -1)
            {
                Console.Write("Ingrese una letra válida correspondiente al tipo de jugo.");
            }
            else if (Precio == 0)
            {
                Console.Write("Ingrese una letra válida correspondiente al tamaño del vaso.");
            }
            else
            {
                Console.WriteLine("[E] - Efectivo");
                Console.WriteLine("[T] - Tarjeta");
                Console.WriteLine("--------------");
                Console.Write("Ingrese la letra correspondiente al tipo de pago: ");
                TipoPago = Convert.ToChar(Console.ReadLine());
                if (char.ToUpper(TipoPago) == 'T')
                {
                    Porcentaje = 0.05;
                    Ajuste = Porcentaje * Precio;
                    PagoTotal = Precio + Ajuste;
                    Console.WriteLine("Precio unitario del jugo: S/" + Precio);
                    Console.WriteLine("Monto del incremento: S/" + Ajuste);
                    Console.WriteLine("Total a pagar: S/" + PagoTotal);
                }
                else if (char.ToUpper(TipoPago) == 'E')
                {
                    Porcentaje = 0.10;
                    Ajuste = Porcentaje * Precio;
                    PagoTotal = Precio - Ajuste;
                    Console.WriteLine("Precio unitario del jugo: S/" + Precio);
                    Console.WriteLine("Monto del descuento: S/" + Ajuste);
                    Console.WriteLine("Total a pagar: S/" + PagoTotal);
                }
                else
                {
                    Console.Write("Ingrese una letra válida correspondiente al método de pago.");
                }
            }
        }
    }
}
