// Operadoradores Unários
using Firma.Classes;
int x = 5;
int incrementoPosfixado = x++; //6
incrementoPosfixado++;
x++; x = x+1;
int incrementoPrefixado = ++x;
Console.WriteLine(
    $"Posfixado: {incrementoPosfixado}"
);
Console.WriteLine(
    $"Prefixado: {incrementoPrefixado}"
);

//Como obter o tipo de uma variável

Type tipoDeInteiro = typeof(int);
Type tipoDeX = x.GetType();

//Como obter o nome de uma varáivel

string nomeDaVariavel = nameof(x);
int quantosBytes = sizeof(int);
Console.WriteLine("Nome da var: " + nomeDaVariavel);

//Operadores de atribuição
int p = 6;
p += 3; // equivalente a p = p + 3;
Console.WriteLine($"+={p}");
p -=3; // equivalente a p = p - 3;
Console.WriteLine($"-={p}");
p *=3; // equivalente a p = p * 3;
Console.WriteLine($"*={p}");
p /=3; // equialenrte a p = p / 3;
Console.WriteLine($"/={p}");

// Operadores Lógicos
bool a = true;
bool b = false;
Console.WriteLine($"AND  | a    | b    ");
Console.WriteLine($"a    |{a & a, -5} | {a & b, -5}");
Console.WriteLine($"b    |{b & b, -5} | {b & b, -5}");
Console.WriteLine();
Console.WriteLine($"OR   | a    | b    ");
Console.WriteLine($"a    |{a | a, -5} | {a | b, -5}");
Console.WriteLine($"b    |{b | a, -5} | {b | b, -5}");
Console.WriteLine();
Console.WriteLine($"XOR  | a    | b    ");
Console.WriteLine($"a    |{a ^ a, -5} | {a ^ b, -5}");
Console.WriteLine($"b    |{b ^ a, -5} | {b ^ b, -5}");
Console.WriteLine();

static bool FacaAlgo()
{
    Console.WriteLine("Fazendo alguma coisa");
    return true;
}
Console.WriteLine();
Console.WriteLine($"a & FacaAlgo() = {a & FacaAlgo()}");
Console.WriteLine($"b & FacaAlgo() = {b & FacaAlgo()}");

//------------------------------

Firma[] firma = new firma[]
{
    new Manager{ 
        Name = "Roskov"
        , Born = new(year:1992, month: 1, day: 14)
        , Legs = 2
        , IsManager = true
    },
    new Apprentice{
        Name = "Eu mesmo"
        , Born = new(year: 2003, month:3, day:1)
        , Legs = 2
        , IsApprentice = true
    },
    new Apprentice{
        Name = "The Rock"
        , Born = new(year:2002, month:4, day:29)
        , Legs = 2
        , IsApprentice = true
    },
    new FactoryWorker{
        Name =  "Jack"
        , Born = new(year:2000, month:8, day:4)
        , Legs = 2
        , IsFactoryWorker = true 
    },
    new FactoryWorker{
        Name =  "Fin"
        , Born = new(year:1998, month:11, day:23)
        , Legs = 2
        , IsFactoryWorker = true 
    },
    new Supervisor{
        Name = "Symon"
        , Born = new(year:1995, month:7, day:24)
        , Legs = 2
        , IsSupervisor = true 
    }
};

// Laços de repetição
// 3 tipos de variáveis para controle de repetição 
// 1: Flag - Bandeirinha, booleano que indica se para ou continua
// 2: Counter - Contador, Conta quantas vezes a repetição ocorreu
// 3: Acumulador - Permite acumular valores a cada interação

// Laço for
for(int i = 0; i < firma.Length; i++)
{
    string message;
    message = $"Nome: {firma[i].Name} ";
    message += $"Data Nasc: {firma[i].Born.ToShortDateString()} ";
    Console.WriteLine(message);
}

// LAÇO DE REPETIÇÃO PARA CADA
Console.WriteLine("\n---FOREACH---\n");
foreach( Firma firma in firma )
{
    string message = string.Empty;
    if( firma != null)
    {
        message += $"Nome: {firma.Name}";
    }
    Console.WriteLine(message);
}

//