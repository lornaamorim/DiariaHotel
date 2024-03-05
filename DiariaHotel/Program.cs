using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariaHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Valor da diária do hotel: ");
            double diaria = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de adultos: ");
            int adultos = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de crianças: ");
            int criancas = int.Parse(Console.ReadLine());

            double resultado = diaria * adultos + (criancas * diaria / 2);
            Console.WriteLine("O valor por dia da família será: " + resultado .ToString("C"));

            Console.WriteLine("Número de dias de hospedagem: ");
            int dias = int.Parse(Console.ReadLine());

            double resultado1 = resultado * dias;
            Console.WriteLine("O valor total da hospedagem é: " + resultado1.ToString("C"));

            Console.Write("Informe o número de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            double valor_parcela = resultado1 / parcelas;
            Console.WriteLine("O valor de cada parcela é: " + valor_parcela.ToString("C"));

            Console.ReadKey();



        }
    }
}
