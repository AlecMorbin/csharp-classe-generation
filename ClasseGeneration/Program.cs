//Libreria

/*
-Nome
-Cognome
-eta
-numero di partecipanti attuali nel corso
 dei vostri alunni.
MAX ALUNNI 10
*/

string[] alunniNome = new string[10];
string[] alunniCognome = new string[10];
int[] alunniEta = new int[10];
int numeroPartecipantiAttuale = 0;

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
}

void stampaArrayString(string[] array)
{
    foreach (string item in array)
    {
        Console.WriteLine(item);
    }
}

void stampaArrayInt(int[] array)
{
    foreach (int item in array)
    {
        Console.WriteLine(item);
    }
}

void stampa()
{
    stampaArrayString(alunniCognome);
    stampaArrayString(alunniNome);
    stampaArrayInt(alunniEta);
}


Console.WriteLine("Scrivi nome poi cognome poi eta Alunno");
string nome = Console.ReadLine();
string cognome = Console.ReadLine();
int eta = int.Parse( Console.ReadLine());
aggiungiAlunno(nome, cognome,eta);

//stampa();

stampaArrayString(alunniCognome);