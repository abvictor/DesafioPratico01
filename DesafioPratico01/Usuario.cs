using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPratico01;
internal class Usuario
{
    
    string nome = "";
    string sobrenome = "";

    public void InformarNome()
    {
        Console.WriteLine("Informe o seu nome e sobrenome.");
        Console.WriteLine("Nome");
        nome += Console.ReadLine();
        Console.WriteLine("Sobrenome");
        sobrenome += Console.ReadLine();

        while (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(sobrenome)) {
            Console.WriteLine("Nome inválido, favor digitar o nome corretamente.");
            Console.WriteLine("Nome");
            nome = Console.ReadLine();
            Console.WriteLine("Sobrenome");
            sobrenome += Console.ReadLine();
        }
    }

    public void Saudar()
    {
       Console.WriteLine($"Olá, {nome}! Seja muito bem - vindo!");
    }

    public void MostrarNomeCompleto()
    {
        Console.WriteLine($"Nome completo: {nome} {sobrenome}");
    }
}
