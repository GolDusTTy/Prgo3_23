//Em algum momento o programa da errado e esse programa vai vcorrigir isso
// Menu de Inicialização

string entrada = string.Empty; // tambem pode colocar "" aspas vazias
Console.WriteLine("-------------------");
Console.WriteLine("Tratamento de Erros");
Console.WriteLine("-------------------");

do{
    Console.WriteLine("");
    Console.WriteLine("Selecione uma das opções abaixo");
    Console.WriteLine("1 - Tratamento de Erro");
    Console.WriteLine("2 - Try {} Cath {}");
    Console.WriteLine("3 - Cath com Filtros");
    Console.WriteLine("4 - ");
    Console.WriteLine("5 - ");
    Console.WriteLine("0 - SAIR");

    entrada = Console.ReadLine();
    
    switch(entrada)
    {
        case "1" :
            //int count = int.Parse("abc");
            bool aux = true;// aux = auxiliar
            while(aux)
            {    
                Console.WriteLine("Quantos ovos na cesta");
                string? input = Console.ReadLine(); //? = nulabor da valor nulo pra string
                if( int.TryParse( input, out int count ) ) //TryParce recebe dois parametros um de entrada e saida
                {
                    Console.WriteLine($"Existem {count} ovos na cesto.");
                    aux = false;
                }
                else
                {
                    Console.WriteLine("Não é um número válido.");
                    aux = true;
                }
                
            }

        break;

        case "2" :

            Console.WriteLine("Antes da Validação.");
            Console.WriteLine("Informe sua Idade.");
            string input2 = Console.ReadLine();
            try
            {
                int age = int.Parse(input2);
                //Forçando um erro de indice fora dos limites do vetor
                int[] vetInteiros = {10,11,12,13};
                Console.WriteLine( vetInteiros[vetInteiros.Length - 1] );
            }
            catch(IndexOutOfRangeException ixorgex)
            {
                Console.WriteLine("Queridão, posição inexistente no vetor.");
                
            }
            catch( FormatException fex ) // trata um tipo especifico
            {
                Console.WriteLine("Erro de formato invalido de dados.");
            }
            catch( Exception ex ) //Exeption geralmente declaramos como ex
            {
                Console.WriteLine("Ocorreu um Erro. Dados Invalidos");
                Console.WriteLine($"{ex.GetType()} : {ex.Message}");//{} para ter acesso a variavel ex
            }
            Console.WriteLine("Depois da Validação.");

        break;
        //Ele não mostra o erro
        case "3" :

            Console.WriteLine("Informe um valor");
            string quantia = Console.ReadLine();
            if( string.IsNullOrEmpty(quantia) )
                Console.WriteLine("Quantia invalida.");
            else
            {
                try
                {
                    decimal amountValue = decimal.Parse(quantia);
                    Console.WriteLine($"Valor formatado: {amountValue:C}"); //C = Corrence = moeda reais
                }
                catch(FormatException) when (quantia.Contains("$"))
                {
                    Console.WriteLine("O valor deve ser informado sem $");
                }
                catch(FormatException fex)
                {
                    Console.WriteLine("Informe apenas o digitos.");
                }
            }

        break;

        case "4" :
        case "5" :
        
        break;

        case "0" :
        break;

        default:
            Console.WriteLine("ATENÇÃO: Opção Invalida!");
        break;

    }
//break interronpe o bloco 
}

while( !entrada.Equals("0") && !string.IsNullOrWhiteSpace(entrada) ); //! = negação bolleano

//no While primeiro checamos a condição bollena for verdadeira só depois vai repetir
//no Do while ele vai executar a primeira vez e depois vai checar
