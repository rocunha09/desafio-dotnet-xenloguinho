
//lista de quantidades a serem testadas baseando-se em C 
List<int> casos = new List<int>();

//lista de quantidade minima de cada teste
List<int> resultados = new List<int>();
    
//quantidade de casos de teste
int c = int.Parse(Console.ReadLine());

//recebe uma lista de casos
for (int i = 0; i < c; i++)
{
    //quantidade de esferas necessárias para invocar xenlonguinho
    int n = int.Parse(Console.ReadLine());
    
    //add o caso na lista:
    casos.Add(n);
}

//testa cada caso
for(int i = 0; i < casos.Count; i++)
{
    //quantidade de esferas a serem coletadas
    int count = 0;
    
    //testa cada esfera
    for(int j = 1; j <= casos[i]; j++)
    {
        /*
        *   O método tradicional para encontrar os divisores de um número consiste em fatorar o número, obter a quantidade de vezes
        *que cada fator foi utilizado(estes são expoentes do fator), somar 1 em cada expoente, e então multiplicar todos os resultantes...
        *   Durante o processo acima descobri resultados relevantes ao resolver o problema no papel, logo realizei o processo de "prova real" ou 
        *dos resultados para o valor original.
        *   sempre que o numero de divisores é par o Número não possui raiz quadrada exata, 
        *mas se o número de divisores é ímpar haver á um termo central na lista de divisores, este é a raiz 
        *quadrada exata.
        *   mediante o exposto acima, só preciso contabilizar a raiz quadrada de resultados com casas decimais...
        */
        double qtdDivisores = Math.Sqrt(j);
    
        if(qtdDivisores % 1 != 0)
        {
            count++; 
        }
    }
    
    //add o quantidade de esferas a serem coletadas  na lista de resultados:
    resultados.Add(count);
}

foreach(var resultado in resultados)
{
    Console.WriteLine(resultado);
}

