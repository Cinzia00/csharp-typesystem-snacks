//SNACK 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.

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






//SNACK 2: L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.

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







//SNACK 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.

int sommaNumeriScelti = 0;


for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Scegli un numero");
    int numeriScelti = int.Parse(Console.ReadLine());
    sommaNumeriScelti += numeriScelti;
}
    Console.WriteLine($"la somma dei numeri scelti é: {sommaNumeriScelti}");






//SNACK 4: Calcola la somma e la media dei numeri da 2 a 10.

int[] numeri = {2, 3, 4, 5, 6, 7, 8, 9, 10};
int SommaNumeri = 0;
for (int i = 0; i < numeri.Length; i++)
{
   SommaNumeri += numeri[i];
}
    Console.WriteLine($"La somma dei numeri è: {SommaNumeri}");
int media = SommaNumeri / numeri.Length;
Console.WriteLine($"La media dei numeri è: {media}");







//SNACK 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

Console.WriteLine("Inserisci un numero");
int numeroUtente = int.Parse(Console.ReadLine());

if(numeroUtente % 2 == 0)
{
    Console.WriteLine($"Il numero da te inserito è: {numeroUtente}");
}else
{
    Console.WriteLine($"{numeroUtente + 1} Al tuo numero è stato aggiunto +1");
}




//Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

string[] elencoInvitati = { "Simon", "Olly", "Skyler", "Gina", "Gianni", "Henk", "Anna"};

Console.WriteLine("Inserisci il tuo nome");
string nomeInvitato = Console.ReadLine();
string singoloNomeElenco = "";
string controlloInvitato = "";

for(int i = 0; i < elencoInvitati.Length; i++)
{
    singoloNomeElenco += elencoInvitati[i];
}
if(singoloNomeElenco == controlloInvitato)
{
    Console.WriteLine("Puoi partecipare alla festa");
}else
{
    Console.WriteLine("Non puoi partecipare alla festa");
}
//Da rivedere





//Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

int numeriDispari = new int {};

for(int i = 0; i < 6; i++)
{
    Console.WriteLine("Scrivi un numero");
    int numeroInserito = int.Parse(Console.ReadLine());
    if(numeroInserito % 2 == 1)
    {
        Console.WriteLine("Bene, il numero è dispari");
    }
}



//Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

