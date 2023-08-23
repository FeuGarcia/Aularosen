using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioImposto;

namespace ExercicioImposto
{
    public class CalcularImposto
    {
        public static double Calcular()   /* Precisa fazer public static pra todos os if e else  */
        {
            double salario;
            double desconto;
            double total;
            salario = double.Parse(Console.ReadLine());
            if (salario <= 1903.99)
            {
                Console.WriteLine("Você não paga imposto de renda");
            }
            else
            {
                if (salario > 1903.98 && salario < 2826.66)
                {
                    desconto = (salario * 7.50) / 100.00;
                    total = desconto - 142.80;
                    Console.WriteLine($"Você deverar pagar R$ {total.ToString("F2")} de imposto de renda");
                }
                else if (salario > 2826.65 && salario < 3751.06)
                {
                    desconto = (salario * 15.00) / 100.00;
                    total = desconto - 354.80;
                    Console.WriteLine($"Você deverar pagar R$ {total.ToString("F2")} de imposto de renda");
                }
                else if (salario > 3751.05 && salario < 4664.69)
                {
                    desconto = (salario * 22.50) / 100.00;
                    total = desconto - 636.13;
                    Console.WriteLine($"Você deverar pagar R$ {total.ToString("F2")} de imposto de renda");
                }
                else if (salario > 4664.67)
                {
                    desconto = (salario * 27.50) / 100.00;
                    total = desconto - 869.36;
                    Console.WriteLine($"Você deverar pagar R$ {total.ToString("F2")} de imposto de renda");
                }
             return;
            }   
        }
        public static double Calcular2()
        {
            salario
        }


    }
}
