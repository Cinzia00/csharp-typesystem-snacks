//SNACK 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.

Console.WriteLine("Scegli un numero");
int primoNumeroScelto = int.Parse(Console.ReadLine());
Console.WriteLine("Scegli un altro numero");
byte secondoNumeroScelto = byte.Parse(Console.ReadLine());

if (primoNumeroScelto > secondoNumeroScelto)
{
    Console.WriteLine($"Il numero maggiore é: {primoNumeroScelto}");
}else if (secondoNumeroScelto > primoNumeroScelto)
{
    Console.WriteLine($"Il numero maggiore é: {secondoNumeroScelto}");
}else
{
    Console.WriteLine($"I numeri {primoNumeroScelto} e {secondoNumeroScelto} sono uguali");
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







////SNACK 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

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
bool nomeTrovato = false;

for (int i = 0; i < elencoInvitati.Length; i++)
{
    if (elencoInvitati[i] == nomeInvitato)
    {
        nomeTrovato = true;
    }
}

if(nomeTrovato)
{
    Console.WriteLine($"{nomeInvitato} puoi partecipare alla festa");
} else
{
    Console.WriteLine($"{nomeInvitato} non puoi partecipare alla festa");
}




//Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Scrivi un numero");
    int numeroInserito = int.Parse(Console.ReadLine());
    if (numeroInserito % 2 == 1)
    {
        Console.WriteLine("Bene, il numero è dispari");
    }
}






//Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

int[] numeriInteri = { 8, 45, 12, 5, 30, 15, 68, 10, 55, 49 };
int posizioneDispari = 0;
for (int i = 0; i < numeriInteri.Length; i++)
{
    //trovare gli elementi in posizione dispari
    if (i % 2 == 1)
    {
        //sommare gli elementi in posizione dispari
        posizioneDispari += numeriInteri[i];
    }
}
Console.WriteLine(posizioneDispari);





//Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array,
//fino a quando la somma degli elementi è minore di 50.

int somma = 0;

while (somma < 50)
{
    Console.WriteLine("Inserisci un numero");
    int numero = int.Parse(Console.ReadLine());
    somma += numero;
}

Console.WriteLine(somma);






//Snack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.


Console.WriteLine("Scrivi un numero");
int num = int.Parse(Console.ReadLine());

Random rand = new Random();

for (int i = 0; i < num; i++)
{
    int[] numArray = new int[10];

    for (int j = 0;j < 10; j++)
    {
        int numeroRandom = rand.Next(1, 101);
        numArray[j] = numeroRandom;
        Console.WriteLine(numArray[j]);
    }
}



