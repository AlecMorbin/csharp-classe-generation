//Libreria

/*
-Nome
-Cognome
-eta
-numero di partecipanti attuali nel corso
 dei vostri alunni.
MAX ALUNNI 10
*/

//Variabili globali
string[] alunniNome = new string[10];
string[] alunniCognome = new string[10];
int[] alunniEta = new int[10];
int numeroPartecipantiAttuale = 0;

//funzioni
void aggiungiAlunno(string nome,string cognome , int eta)
{
    for (int i = 0; i < alunniCognome.Length; i++)
    {
        //controllo se lo spazio è vuoto  
        if (String.IsNullOrEmpty(alunniCognome[i]))
        {
            //aggiungio se è vuoto
            alunniCognome[i] = cognome; 
            //esco dal ciclo altrimento rischio di aggiungere copie
            break;
        }
    }
    for (int i = 0; i < alunniNome.Length; i++)
    {
        if (String.IsNullOrEmpty(alunniNome[i]))
        {
            alunniNome[i] = nome;
            break;
        }
    }
    for (int i = 0; i < alunniEta.Length; i++)
    {
        if (alunniEta[i]==0)
        {
            alunniEta[i] = eta;
            break;
        }
    }
    numeroPartecipantiAttuale++;
}



void stampaArray(Array array)
{
    //ciclo l'array
    foreach (var item in array)
    {
        //controllo il tipo
        if (item is int)
        {
            //se intero controllo se non è zero
            if ((int)item != 0)
                Console.WriteLine(item);
        } else if (item is string)
        {
            //se stringa controllo è null o vuoto
            if (!String.IsNullOrEmpty((string)item))
            Console.WriteLine(item); 
        }
    }
}


void stampa()
{
    Console.WriteLine("\nCognomi: ");
    stampaArray(alunniCognome);
    Console.WriteLine("\nNomi: ");
    stampaArray(alunniNome);
    Console.WriteLine("\nEtà: ");
    stampaArray(alunniEta);
}

void rimuoviUltimoAlunno()
{
    //resetto a default la posizione ultima cosi da "rimuovere" l'ultimo alunno
    alunniCognome[alunniCognome.Length-1] = "";
    alunniNome[alunniNome.Length - 1] = "";
    alunniEta[alunniEta.Length - 1] = 0;
    Console.WriteLine("Il numero attuale di alunni in classe è: " + numeroPartecipantiAttuale);
}

float calcolaEtaMediaClasse()
{
    float media = 0;
    int somma = 0;
    for (int i = 0; i < alunniEta.Length; i++)
    {
        somma += alunniEta[i];
    }
    media = somma / numeroPartecipantiAttuale;

    return media;
}

int EtaPiuGiovane()
{
    int min = alunniEta[0];
    for (int i = 0; i < alunniEta.Length; i++)
    {
        if (alunniEta[i] < min && alunniEta[i] != 0)
        {
            min = alunniEta[i];
        }
    }
    return min;
}

int EtàPiuVecchio()
{
    int max = 0;
    for (int i = 0; i < alunniEta.Length; i++)
    {
        if(alunniEta[i] != 0 && alunniEta[i] > max)
        {
            max = alunniEta[i];
        }
    }
    return max;
}
//Esecuzione

//testing con piu alunni
aggiungiAlunno("Marco", "Giaretta", 15);
aggiungiAlunno("Alessandro", "Mantovani", 17);
aggiungiAlunno("Lara", "Bianchi", 16);


Console.WriteLine("Scrivi nome poi cognome poi eta di Alunno per aggiungerlo: ");
string nome = Console.ReadLine();
string cognome = Console.ReadLine();
int eta = int.Parse( Console.ReadLine());
aggiungiAlunno(nome, cognome,eta);

stampa();
Console.WriteLine("L'età media della classe è: " + calcolaEtaMediaClasse());

Console.WriteLine("Il più giovane ha " + EtaPiuGiovane() + " anni");
Console.WriteLine("Il più vecchio ha " + EtàPiuVecchio() + " anni");