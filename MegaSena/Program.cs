using System;

int size = 6;
int[] sorteado = new int[size];
int[] sorteadoOrdenado = new int[size];

for (int i = 0; i < size; i++) //repetir até pegar todos os números que devem ser sorteados
{
    sorteado[i] = new Random().Next(1, 61);//pra pegar do 1 ao 60
    {
        Console.Write(sorteado[i]);
    }
    /*while(i < 6) //enquanto for menor que 6 números sorteados
    {
        int aux = random.Next(1, 61);
        if
        { o N sorteado for == N no sorteado[i], então 
            [i] == sorteado[i];
            //sorteia novamente
            i++; //incrementa para o proximo
        }
        else //se diferenta, então adiciona no vetor e próx
            {
                (!repetido) = sorteado[i];
                i++;
            }
   }*/
}
for (int referencia = 0; referencia < size; referencia++) //pega o valor e guarda na variavel
{
    int menor = sorteado[referencia];  //muda a posição e realoca na variável menor
    int guardarMenor = referencia;
    // no índice chamado vai somar +1 pra pegar a próx casa e guardar o valor de "i" que recebeu
    for (int j = referencia + 1; j < 5; j++)
    {
        if (sorteado[j] < menor) //VETOR VARIAVEL está recebendo o valor de j (antes recebeu i) e vendo se o seguinte é menor
        {
            menor = sorteado[j]; //variavel menor recebe o valor que esta no VETOR VARIAVEL que recebeu o valor de j
            guardarMenor = j; //outra variavel recebe o valor do j
        }
    }
    //troca
    sorteadoOrdenado[referencia] = sorteado[referencia];
    sorteado[referencia] = menor;
    sorteado[guardarMenor] = sorteadoOrdenado[referencia];
}
//imprimir
Console.WriteLine("\nNúmeros sorteados: ");
for (int i = 0; i < 5; i++)
{
    Console.Write(sorteado[i] + " ");
}