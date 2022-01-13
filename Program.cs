int calcularDivisores(int estrelas)
    {
        //primeiro passo: fatoração e identificação dos expoentes...
        //segundo passo: somar 1 a cada expoente...
        //terceiro passo: multiplicar os resultados e o resultado será o número de dividores do valor de entrada...

        //passo 1:

        int estrelasAux = estrelas;
        
        ///lista de fatores utilizados
        List<int> fatores = new List<int>();
        
        ///lista de quantidade de vezes que os fatores foram utilizados
        List<int> listaQtdFatUtil = new List<int>();
        
        //fator
        int fator = 2;
        
        //adiciona o primeiro fator utilizado
        fatores.Add(fator);

        //quantidade de Vezes que o Fator foi utilizado
        int qtdFatUtil = 0;

        //enquanto o resultado da fatoração não atingir 1 continue fatorando
        while(estrelasAux != 1)
        {
        
        do
        {
            //se o resultado da divisão for zero então realize-a
            if(estrelasAux % fator == 0)
            {
            //fatorando
            estrelasAux = estrelasAux / fator;  
            
            //soma o numero de vezes que o fator foi utilizado...
            qtdFatUtil++;
            }
            
        //continue realizando a divisão enquanto o resultado for igual a zero se não aumente o fator.
        }while(estrelasAux % fator == 0);
        
        //adiciona quantidade de uso do fator na lista
        listaQtdFatUtil.Add(qtdFatUtil);
        
        //reinicia contagem
        qtdFatUtil = 0;

        if(estrelasAux != 1)
        {
            //aumenta o fator para garantir resto 0
            fator++;
            
            //adiciona fator a lista de utilizados
            fatores.Add(fator);
        }
        }
        
        //Console.WriteLine("lista de fatores utilizados: \t\t\t\t" + String.Join(", ", fatores));
        //Console.WriteLine("lista de numero de vezes em que o fator foi utilizado: \t" + String.Join(", ", listaQtdFatUtil));


        //passo 2:

        for(int i = 0; i < listaQtdFatUtil.Count; i++)
        {
            listaQtdFatUtil[i] += 1;
            //Console.WriteLine(listaQtdFatUtil[i]);
        }


        //passo 3:
        int numeroDeDivisoresDoValorDeEntrada = 1;

        foreach(var fatorResult in listaQtdFatUtil)
        {
            numeroDeDivisoresDoValorDeEntrada *= fatorResult;
        }
        
        //Console.WriteLine(numeroDeDivisoresDoValorDeEntrada);

        return numeroDeDivisoresDoValorDeEntrada;
        
    }
/*
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
foreach(var qtdEsferas in casos)
{
    //quantidade de esferas a serem coletadas
    int count = 0;
    
    //testa cada esfera
    for(int i = 0; i < qtdEsferas; i++)
    {
        int qtdDivisores = calcularDivisores(i);
    
        if(qtdDivisores % 2 == 0)
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


*/
 //quantidade de esferas a serem coletadas
    int count = 0;
    
    //testa cada esfera
    for(int i = 1; i <= 24; i++)
    {
        int qtdDivisores = calcularDivisores(i);
    
        if(qtdDivisores % 2 == 0)
        {
            count++; 
        }
    }

    Console.WriteLine(count);