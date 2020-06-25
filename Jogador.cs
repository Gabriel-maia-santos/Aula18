using System;

namespace Aula18Dojo
{
    public class Jogador
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public DateTime Nascimento {get; set;}

        public float Peso { get; set; }
        public float Altura { get; set; }

        public DateTime Nascionalidade { get; set; }

        public int CalcularIdade(){
            int AnoAtual = Int32.Parse(DateTime.Now.ToString().Split("/"),[2]);
        }


        public void MostrarDados(){
            System.Console.WriteLine($"Nome: {Nome}, Posição {Posicao}, {Nascionalidade}");
        }
    }
}