//Realizzare un programma in grado di CRIPTARE e DECRIPTARE una stringa inserita nell’utente con la strategia di criptazione nota come “IL CIFRARIO DI CESARE”
//Mi raccomando ci sono diversi modi di integrarlo, scegliete una strategia semplice in base a quello che abbiamo spiegato:
//l’utente inserisce una stringa da criptare / decriptare
//l’utente inserisce una chiave numerica per effettuare la criptazione / decriptazione della stringa inserita
Console.WriteLine("Premi 1 per cifrare o 2 per decifrare");
int Cesare = Convert.ToInt32(Console.ReadLine());

if (Cesare == 1)
{
    Console.WriteLine("Inserisci la frase o parola da cifrare");
    string userString = (Console.ReadLine());
    userString = userString.ToUpper();

    Console.WriteLine("Inserisci la chiave numerica da utilizzare");
    int numericKey = Convert.ToInt32(Console.ReadLine());
    string cifrato = "";

    for (int i = 0; i < userString.Length; i++)
    {
        int letter = (Convert.ToInt32(userString[i]));
        int letterModify = 0;

        if (letter == 32)
            letterModify = letter;
        else if (letter >= 48 && letter <= 57)
        {

            letterModify = letter + numericKey;
            if (letterModify > 57)
            {
                int number = letterModify - 57;
                letterModify = 47 + number;
            }
        }
        else if (letter >= 65 && letter <= 90)
        {
            letterModify = letter + numericKey;
            if (letterModify > 90)
            {
                int letters = letterModify - 90;
                letterModify = 64 + letters;
            }
        }

        char letterConvert = Convert.ToChar(letterModify);
        Console.Write(letterConvert);
    }
} else if(Cesare == 2)
{
    Console.WriteLine("Inserisci la frase o parola da decifrare");
    string userString = (Console.ReadLine());
    userString = userString.ToUpper();

    Console.WriteLine("Inserisci la chiave numerica usata");
    int numericKey = Convert.ToInt32(Console.ReadLine());
    string cifrato = "";

    for (int i = 0; i < userString.Length; i++)
    {
        int letter = (Convert.ToInt32(userString[i]));
        int letterModify = 0;

        if (letter == 32)
            letterModify = letter;
        else if (letter >= 48 && letter <= 57)
        {

            letterModify = letter - numericKey;
            
            if (letterModify < 48)
            {
                int number = letterModify - 48;
                letterModify = 58 + number;
            }
        }
        else if (letter >= 65 && letter <= 90)
        {
            letterModify = letter - numericKey;
            if (letterModify < 65)
            {
                int letters = letterModify - 65;
                letterModify = 91 + letters;
            }
        }

        char letterConvert = Convert.ToChar(letterModify);
        Console.Write(letterConvert);
    }
}
else
{
    Console.WriteLine("Errore. Premi 1 o 2");
}





