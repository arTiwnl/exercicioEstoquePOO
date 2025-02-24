﻿using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p;
            p = new Produto();
            
            Console.WriteLine("Entre os dados do produto:");
            
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);
            
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);
            
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

        }
    }
}

