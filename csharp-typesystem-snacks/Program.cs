//SNACK 1

Console.WriteLine("Scegli un numero");
int primoNumeroScelto = int.Parse(Console.ReadLine());
Console.WriteLine("Scegli un altro numero");
byte secondoNumeroScelto = byte.Parse(Console.ReadLine());

if(primoNumeroScelto > secondoNumeroScelto)
{
    Console.WriteLine($"Il numero maggiore é: {primoNumeroScelto}");
}else if (secondoNumeroScelto > primoNumeroScelto)
{
    Console.WriteLine($"Il numero maggiore é: {secondoNumeroScelto}");
}else
{
    Console.WriteLine("I numeri sono uguali");
}



//SNACK 2

Console.WriteLine("Scegli una parola");
string primaParolaScelta = Console.ReadLine();

Console.WriteLine("Scegli un'altra parola");
string secondaParolaScelta = Console.ReadLine();

if (primaParolaScelta.Length > secondaParolaScelta.Length)
{
    Console.WriteLine($"Le parole scelte sono: {secondaParolaScelta} e {primaParolaScelta}");
}else
{
    Console.WriteLine($"Le parole scelte sono: {primaParolaScelta} e {secondaParolaScelta}");
}







