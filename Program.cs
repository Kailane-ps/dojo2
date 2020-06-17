using System;

namespace _333
{
    class Program
    {
        static void Main(string[] args)
        {

            IngressoVip bilhete = new IngressoVip();
            bilhete.IngressoPreco = 15.0f;
            bilhete.ImprimirValor();
            bilhete.AdicionarValor();

            Console.WriteLine("A diferença de valores é:" + bilhete.valorAdicional);
        }
    }
}
