namespace Estoque;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;
    
    public double ValorTotalEmEstoque ()
    {
        return Preco * Quantidade;
    }
    
    public void AdicionarProdutos (int quantidade)
    {
        Quantidade = Quantidade + quantidade;
    }
    
    public void RemoverProdutos (int quantidade)
    {
        Quantidade = Quantidade - quantidade;
    }
    
    public override string ToString()
    {
        return Nome + ", R$" + Preco + ", " + Quantidade + " Unidades, Total: R$ " + ValorTotalEmEstoque().ToString("F2");
    }
    

}