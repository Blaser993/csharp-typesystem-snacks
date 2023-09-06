// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");


//Snack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.

//Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.

int[] arrayVuoto = new int[1000];

int sommaNumeriVuoto = 0;
int numeroDaSommare = 0;

while (sommaNumeriVuoto <= 50)   
{

    switch (sommaNumeriVuoto += numeroDaSommare)
    {

        case > 50:
            Console.WriteLine($"Il numero che hai inserito è troppo grande");
            Console.Write("Inserisci un numero minore di 51: ");
            numeroDaSommare = Convert.ToInt32(Console.ReadLine());
        break;
        default:
            Console.Write("Inserisci un numero minore di 51: ");
            numeroDaSommare = Convert.ToInt32(Console.ReadLine());
        break;
    }
}

Console.WriteLine();

//Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.

Console.Write("Inserisci il primo numero: ");
int numero1 = Convert.ToInt32(Console.ReadLine());

/*
SOLUZIONE CON DOMANDA AD OLTRANZA
while(int.TryParse(Console.ReadLine(), out numero1)= false)
{
    Console.WriteLine($"Non hai inserito un numero! Riprova!");
}
FINE
*/

Console.Write("Inserisci il secondo numero: ");
int numero2 = Convert.ToInt32(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine($"il numero maggiore è {numero1}");
} 
else if (numero2 > numero1)
{
    Console.WriteLine($"il numero maggiore è {numero2}");
}
else Console.WriteLine($"i due numeri sono uguali!");

Console.WriteLine();

//Snack 2 : L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.

Console.Write("Inserisci una parola: ");
string parola1 = (Console.ReadLine());

Console.Write("Inserisci un'altra parola: ");
string parola2 = (Console.ReadLine());

if (parola1.Length > parola2.Length)
{
    Console.WriteLine($"{parola1}, {parola2}");
} else Console.WriteLine($"{parola2}, {parola1}");

Console.WriteLine();


//Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.

int sommaNumeri = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write("Inserisci un numero: ");

    int numero = Convert.ToInt32(Console.ReadLine());
    sommaNumeri = sommaNumeri + numero;

    if (i == 9)
    {
        Console.WriteLine($"Ecco la somma dei tuoi numeri: {sommaNumeri}");
    }
}

Console.WriteLine();


//Snack 4: Calcola la somma e la media dei numeri da 2 a 10.

int[] numeriDa2a10 = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int sommaNumeriDa2a10 = 0;


for (int i = 0; i < numeriDa2a10.Length; i++)
{
    sommaNumeriDa2a10 += numeriDa2a10[i];
}

float mediaNumeriDa2a10 = sommaNumeriDa2a10 / numeriDa2a10.Length;

Console.WriteLine($"La somma dei numeri da 2 a 10 è {sommaNumeriDa2a10}, la loro media è {mediaNumeriDa2a10}");

Console.WriteLine();


//Snack 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

Console.Write("Inserisci un numero: ");
int numeroPari = Convert.ToInt32(Console.ReadLine());

if (numeroPari % 2 == 0)
{
    Console.WriteLine($"Il numero {numeroPari} che hai scritto è pari");
}
else
{
    int numeroDispari = numeroPari + 1;
    Console.WriteLine($"il numero che hai scritto è dispari, ecco il suo successivo: {numeroDispari}");
}

Console.WriteLine();

//Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.  
//Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

string[] invitati = { "Corrado", "Giovanni", "Marco", "Paolo" };

Console.Write("Inserisci il tuo nome: ");
string tuoNome = (Console.ReadLine());

bool invitato = false;
int incremento = 0;
while (incremento < invitati.Length)
{
    if (tuoNome == invitati[incremento])
    {
        invitato = true;
    }
    incremento++;
}

if (invitato == true)
{
    Console.WriteLine($"Benvenut* {tuoNome}, sei nella lista degli invitati.");
}
else
{
    Console.WriteLine($"Smamma {tuoNome}, non sei stato invitato!");
}

Console.WriteLine();

//Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

int[] sonoNumeriDispari = new int[6];

for (int i = 0; i < 6; i++)
{
    Console.Write("Inserisci un numero: ");
    int numeroDispari = Convert.ToInt32(Console.ReadLine());
    if (numeroDispari % 2 != 0)
    {
        sonoNumeriDispari = new int[] { numeroDispari };
        Console.WriteLine($"il {numeroDispari} è stato aggiunto all'arrey dei numeri dispari ");
    }
}

Console.WriteLine();


//Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

int[] numeriInteri = { 1, 3, 1, 5, 1, 7, 1, 9, 1, 31, 1, 12, 1 };
int sommaNumeriInteri = 0;

for (int i = 0; i < numeriInteri.Length; i++)
{
    int posizione = i + 1;
    if (posizione % 2 != 0)
    {
        sommaNumeriInteri += numeriInteri[i];
    }
}

Console.WriteLine($"La somma dei numeri in posizione dispari è {sommaNumeriInteri}");

Console.WriteLine();