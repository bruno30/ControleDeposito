using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueDeposito
{
    internal class Program
    {
        static void Main(string[] args)
        {

            deposito depsitoFilial01 = new deposito();
            depsitoFilial01.nome = "venda";
            depsitoFilial01.codigo = 0101;
            depsitoFilial01.qntEstoq = 25;
            depsitoFilial01.qntPC = 5;

            Console.WriteLine("Nome deposito: " + depsitoFilial01.nome);
            Console.WriteLine("Código do deposito: " + depsitoFilial01.codigo);
            Console.WriteLine("Quantidade em estoque: " + depsitoFilial01.qntEstoq);
            Console.WriteLine("Quantidade em pedido de compra: " + depsitoFilial01.qntPC);

            depsitoFilial01.RequisicaoMaterial(30);


            Console.WriteLine("                                                         ");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("                                                         ");


            deposito depsitoFilial16 = new deposito();
            depsitoFilial16.nome = "venda";
            depsitoFilial16.codigo = 0116;
            depsitoFilial16.qntEstoq = 50;
            depsitoFilial16.qntPC = 5;

            Console.WriteLine("Nome deposito: {0}", depsitoFilial16.nome); //uso da interpolação de strings
            Console.WriteLine($"Código do deposito:  {depsitoFilial16.codigo} é referente a filial 01 dep 16"); //outro tipo de interpolação
            Console.WriteLine($"............... 1 + 1 é igual a {1 + 1}");//outro tipo de imterpolação
            Console.WriteLine("Quantidade em estoque: " + depsitoFilial16.qntEstoq);
            Console.WriteLine("Quantidade em pedido de compra: " + depsitoFilial16.qntPC);

            depsitoFilial16.RequisicaoMaterial(60);

            Console.WriteLine("                                              ");
            depsitoFilial16.EntradaMercadoria(10);
            
            Console.WriteLine("                                              ");
            depsitoFilial16.RequisicaoMaterial(80);

            Console.WriteLine("                                              ");
            depsitoFilial16.SaidaMercadoria(5);


            Console.ReadLine();
        }
    }
}
