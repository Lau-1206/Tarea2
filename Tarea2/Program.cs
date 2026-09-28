using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Variables
            string ced, nom, tper; // cedula, nombre, tipo de persona.
            string otro = "s";     // respuesta para repetir (s/n).
            int tipo;              // 1, 2 o 3
            double horas, precio, ord, aum, bruto, ccss, neto; // salario ordinario, aumento, salario bruto, deduccion CCSS, salario neto.
            tipo = 0;

            while (otro == "s")
            {
                // Entrada
                Console.Write("Cedula: ");
                ced = Console.ReadLine();
                Console.Write("Nombre: ");
                nom = Console.ReadLine();
                //Nuevo ciclo
                while (tipo < 1 || tipo > 3)
                {
                    Console.Write("Tipo (1-Operario 2-Tecnico 3-Profesional): ");
                    tipo = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Horas laboradas: ");
                horas = Convert.ToDouble(Console.ReadLine());
                Console.Write("Precio por hora: ");
                precio = Convert.ToDouble(Console.ReadLine());

                // Proceso
                ord = horas * precio;

                if (tipo == 1)
                {
                    tper = "Operario";
                    aum = ord * 0.15;
                }
                else if (tipo == 2)
                {
                    tper = "Tecnico";
                    aum = ord * 0.10;
                }
                else
                {
                    tper = "Profesional";
                    aum = ord * 0.05;
                }

                bruto = ord + aum;
                ccss = bruto * 0.0917;
                neto = bruto - ccss;

                // Salida
                Console.WriteLine("Cedula: " + ced);
                Console.WriteLine("Nombre Empleado: " + nom);
                Console.WriteLine("Tipo Empleado: " + tper);
                Console.WriteLine("Salario por Hora: " + precio);
                Console.WriteLine("Cantidad de Horas: " + horas);
                Console.WriteLine("Salario Ordinario: " + ord);
                Console.WriteLine("Aumento: " + aum);
                Console.WriteLine("Salario Bruto: " + bruto);
                Console.WriteLine("Deduccion CCSS: " + ccss.ToString("N2"));
                Console.WriteLine("Salario Neto: " + neto.ToString("N2"));

                Console.Write("Desea otro calculo? (s/n): ");
                otro = Console.ReadLine();
            }
        }
    }
}