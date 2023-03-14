// See https://aka.ms/new-console-template for more information
Console.WriteLine("Olá, seja bem vindo");
Console.WriteLine("Qual é o seu nome?");
string name = Console.ReadLine();
Console.WriteLine(
    $"Olá {name}  prazer conhecê-lo."
    );

// Declarar sem inicializar / primitivo
string message1;
// Declarar inicialiado / abstrato
String message2 = "Seu Nome Completo";
// Declarar string vazia
string message3 = String.Empty;
string message4 = "";

//Declaração com tipo implícito

var menssage5 = "mensagem aleatória";

message1 = "Rogério Ceni;Pelé;The Rock;Roberto Carlos";
var palavras = message1.Split(';');

foreach(var word in palavras)
{
    // Variavel de escopo local do
    // laço repetição foreach
 int a = 10;
 Console.WriteLine(word);
}