using System;
public class deposito
{
    public string nome;
    public int codigo;
    public int qntEstoq;
    public int qntPC;

    public bool RequisicaoMaterial(int req)
    {
        if (req > this.qntEstoq)
        {
            Console.WriteLine("Quantidade solicitada: " +req + " , solicitação NEGADA");
            return false;
        }
        else
        {
            Console.WriteLine("Quantidade solicitada: " + req + " , solicitação APROVADA");
            return true;
        }

    
    }

    public void EntradaMercadoria (int Ent)
    {
        this.qntEstoq += Ent;
        System.Console.WriteLine("Quantidade entrada: " + Ent + " , SALDO TOTAL EM ESTOQUE "+ qntEstoq);

    }

    public void SaidaMercadoria(int Sai)
    {
        this.qntEstoq -= Sai;
        System.Console.WriteLine("Quantidade saida: " + Sai + " , SALDO TOTAL EM ESTOQUE " + qntEstoq);

    }



}