using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_estagio_gupy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Observe o trecho de código abaixo:
            //    int INDICE = 13, SOMA = 0, K = 0;
            //enquanto K<INDICE faça

            //    K = K + 1;
            //    SOMA = SOMA + K;
            //}

            //  imprimir(SOMA);
            //Ao final do processamento, qual será o valor da variável SOMA ?


            //RESPOSTA:  solução abaixo , resposta final é 91

            //int indice = 13, soma =0, k=0;

            //while ( k < indice )
            //{
            //    k += 1;
            //    soma += k;
            //}

            //Console.WriteLine($"Resultado da variável soma: {soma}");






            //2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores
            //    anteriores(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde,
            //    informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o 
            //    número informado pertence ou não a sequência.
            //    IMPORTANTE:
            //    Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente 
            //    definido no código;


            //RESPOSTA:

            //bool resultado = true;

            //Console.Write("Informe um número: ");
            //int numero = int.Parse(Console.ReadLine());

            //List<int> sequenciaFibonacci = new List<int>();

            //sequenciaFibonacci.Add(0);
            //sequenciaFibonacci.Add(1);


            //while (resultado)
            //{

            //    int ultimoElemento = sequenciaFibonacci.Last();
            //    int penultimoElemento = sequenciaFibonacci[sequenciaFibonacci.Count - 2];

            //    int soma = ultimoElemento + penultimoElemento;

            //    sequenciaFibonacci.Add(soma);

            //    if (soma <= numero)
            //        resultado = true;
            //    else
            //        resultado = false;
            //}

            //bool confereNumero = sequenciaFibonacci.Contains(numero);

            //if (confereNumero == true)
            //    Console.WriteLine("O número informado está presente na sequência Fibonacci");
            //else
            //    Console.WriteLine("O número informado não está presente na sequência Fibonacci");


            //Console.WriteLine("Sequência Fibonacci");
            //foreach (var item in sequenciaFibonacci)
            //{
            //    Console.Write("-" + item);
            //}








            //3) Descubra a lógica e complete o próximo elemento:

            //RESPOSTA:

            //a) 1, 3, 5, 7, __9__

            //b) 2, 4, 8, 16, 32, 64, __128__

            //c) 0, 1, 4, 9, 16, 25, 36, __49__

            //d) 4, 16, 36, 64, __100__

            //e) 1, 1, 2, 3, 5, 8, __13__

            //f) 2,10, 12, 16, 17, 18, 19, ____






            //4) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em uma sala diferente.Você não
            //   pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser. 
            //    Seu objetivo é descobrir qual interruptor controla qual lâmpada.

            //    Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla 
            //      cada lâmpada?


            //RESPOSTA:

            //Ligo dois interruptores A e B , vou a sala verificar, se estiver acesa é um dos dois interruptores A ou B , mas caso 
            //    esteja desligada é o interruptor C que não liguei.
            //Volto a sala de interruptores, desligo um interruptor que tinha deixado ligado e aguardo alguns minutos, vou verificar
            //    novamente se a lampada estiver ligado é o interruptor que deixei ligado , ou se a lampada estiver fria é o interruptor;
            //que tinha desligado, dessa forma consigo saber quais interruptores sao de cada sala indo apenas conferir duas vezes.








            //5) Escreva um programa que inverta os caracteres de um string.

            //  IMPORTANTE:

            //a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente 
            //    definida no código;

            //b) Evite usar funções prontas, como, por exemplo, reverse;


            //RESPOSTA:

            //    string nome = "Anderson";

            //    Queue<char> fila = new Queue<char>();


            //    foreach (char i in nome)
            //    {
            //        fila.Enqueue(i);
            //    }

            //    Stack<char> pilha = new Stack<char>();


            //    while (fila.Count > 0)
            //    {
            //        pilha.Push(fila.Dequeue());
            //    }


            //    string nomeInvertido = "";

            //    foreach (char i in nome)
            //    {
            //        nomeInvertido += pilha.Pop();
            //    }

            //    Console.WriteLine(nomeInvertido);


            //    Console.ReadLine();
        }
    }
}
