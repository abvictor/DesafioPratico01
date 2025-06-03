using DesafioPratico01;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld;

class Program
{

    static void Main()
    {
        Usuario usuario = new Usuario();

        usuario.InformarNome();
        usuario.Saudar();

        usuario.MostrarNomeCompleto();

        Console.WriteLine("Inserir os parametros para os calculos:");
        string valor1 = Console.ReadLine();
        string valor2 = Console.ReadLine();

        double numero1 = ConverterParaDouble(valor1);
        double numero2 = ConverterParaDouble(valor2);


        static double ConverterParaDouble(string valor)
        {
            return Convert.ToDouble(valor);
        }

        Calculos calculadora = new Calculos(numero1, numero2);

        Console.WriteLine("Soma: " + calculadora.Somar());
        Console.WriteLine("Subtrair: " + calculadora.Subtrair());
        Console.WriteLine("Dividir: " + calculadora.Dividir());
        Console.WriteLine("Multiplicar: " + calculadora.Multiplicar());


        static string ContarCaracteres()
        {
            Console.WriteLine("Insira uma frase");
            string frase = Console.ReadLine();

            string[] palavras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int totalLetras = 0;

            for (int i = 0; i < palavras.Length; i++)
            {
                totalLetras += palavras[i].Length;
            }

            return $"Total de letras: {totalLetras}";
        }

        Console.WriteLine(ContarCaracteres());

        static bool VerificarPlaca()
        {

            Console.WriteLine("Insira uma placa");
            string placa = Console.ReadLine();

            bool placaValida = false;
            
            for (int i = 0; i < 2; i++)
            {
                if (!char.IsLetter(placa[i]))
                {
                    Console.WriteLine("A placa deve começar com 3 letras.");
                    break;
                }
            }

            for (int i = 3; i < placa.Length; i++)
            {
                if (!char.IsNumber(placa[i]))
                {
                    Console.WriteLine("Os 4 últimos digitos devem ser números.");
                    return placaValida = false;
                }
            }

            if (placa.Length < 7)
            {
                Console.WriteLine("O tamanho da placa é inválido");
                return placaValida = false;
            }

            Console.WriteLine("Tamanho da placa" + " " + placa.Length);


            return placaValida = true;

        }
        //Console.WriteLine(VerificarPlaca());


        static string SolicitarDatas()
        {
            Console.WriteLine("Digite o tipo de data que você deseja visualizar:");
            Console.WriteLine(" 1 - Formato completo \n 2 - Formato dd/mm/aaaa \n 3 - Formato de 24h \n 4 - Data com o mês por extenso");

            string tipo = Console.ReadLine();

            switch (tipo)
            {
                case "1":
                    DateTime dataDetalhada = DateTime.Now;
                    Console.WriteLine(dataDetalhada);    
                    break;

                case "2":
                    DateTime data = DateTime.Now;
                    DateTime dataAtual = DateTime.Now.Date;
                    Console.WriteLine(dataAtual);
                    break;

                case "3":

                    DateTime horas = DateTime.Now;

                    int hora = DateTime.Now.Hour;
                    int minutos = DateTime.Now.Minute;
                    int segundos = DateTime.Now.Second;

                    Console.WriteLine($"{hora}:{minutos}:{segundos}");
                    break;

                case "4":
                    DateTime dataPorExtenso = DateTime.Now;
                    CultureInfo cultura = new CultureInfo("pt-BR");
                    string dataFormatada = dataPorExtenso.ToString("d 'de' MMMM 'de' yyyy", cultura);

                    Console.WriteLine(dataFormatada);
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            return tipo;
        }

        Console.WriteLine(SolicitarDatas());

    }    


}