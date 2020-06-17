using System;

namespace _333
{

    public class IngressoVip : Ingresso
    {
       public float valorAdicional = 30.0f;

       public void AdicionarValor(){

          
           Console.WriteLine("Valor do ingresso VIP é: R$", IngressoPreco + valorAdicional);
       }

    }
}
