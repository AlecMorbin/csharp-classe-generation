﻿//Libreria

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
    Console.Write("Cognome: ");
    stampaArray(alunniCognome);
    Console.Write("Nome: ");
    stampaArray(alunniNome);
    Console.Write("Età: ");
    stampaArray(alunniEta);
}

void rimuoviUltimoAlunno()
{
    //resetto a default la posizione ultima cosi da "rimuovere" l'ultimo alunno
    alunniCognome[alunniCognome.Length-1] = "";
    alunniNome[alunniNome.Length - 1] = "";
    alunniEta[alunniEta.Length - 1] = 0;
}


//Esecuzione
Console.WriteLine("Scrivi nome poi cognome poi eta di Alunno per aggiungerlo: ");
string nome = Console.ReadLine();
string cognome = Console.ReadLine();
int eta = int.Parse( Console.ReadLine());
aggiungiAlunno(nome, cognome,eta);

stampa();

