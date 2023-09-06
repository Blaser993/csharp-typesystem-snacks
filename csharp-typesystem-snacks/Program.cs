// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Snack 4: Calcola la somma e la media dei numeri da 2 a 10.
//Snack 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
//Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
//Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
//Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
//Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
//Snack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.



//Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.

Console.Write("Inserisci il primo numero: ");
int numero1 = Convert.ToInt32(Console.ReadLine());

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
