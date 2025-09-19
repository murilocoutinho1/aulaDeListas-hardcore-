using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ListasC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> frutas = new List<string>();
            //Adicionando elementos à lista
            frutas.Add("Banana");
            frutas.Add("Manga");
            frutas.Add("Limão");
            WriteLine("Frutas na lista: ");
            foreach(string fruta in frutas)
            {
                WriteLine(fruta);
            }
            WriteLine("Acessando pelo índice:");
            WriteLine(frutas[0]);

            WriteLine("Removendo um item da lista");
            frutas.Remove("Banana");
            foreach(string fruta in frutas)
            {
                WriteLine(fruta);
            }
            WriteLine("Removendo um item da lista por posição");
            frutas.RemoveAt(0);
            foreach (string fruta in frutas)
            {
                WriteLine(fruta);
            }
            frutas.Add("Banana");
            frutas.Add("Manga");
            WriteLine("Mostrando frutas adicionadas novamente: ");
            foreach (string fruta in frutas)
            {
                WriteLine(fruta);
            }
            WriteLine($"O número de elementos na lista: {frutas.Count}");
            bool temBanana = frutas.Contains("Banana");
            if (temBanana == true)
            {
                WriteLine("Sua lista tem banana");
            }
            else
            {
                WriteLine("Sem banana!");
            }
            WriteLine("Digite um nome de fruta:");
            string frutaDigitada = ReadLine();
            int indiceFruta = frutas.IndexOf(frutaDigitada);
            WriteLine($"O índice do limão é: {frutaDigitada}");
            WriteLine(frutas[indiceFruta]);
            if (indiceFruta < 0)
            {
                WriteLine($"{frutaDigitada} não está na lista!");
            }
            else
            {
                WriteLine($"O índice da {frutaDigitada} é: {indiceFruta}");
                WriteLine(frutas[indiceFruta]);
            }
            List<string> nomes = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                WriteLine("Digite um nome: ");
                string nome = ReadLine();
                nomes.Add(nome);
            }
            foreach (string nomeTotal in nomes)
            {
                WriteLine(nomeTotal);
            }
            ReadKey();
        }
    }
}