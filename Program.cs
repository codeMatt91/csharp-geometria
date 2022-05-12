/*
 * Consegna: Nel progetto csharp-geometria creare le seguenti classi
Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo. Aggiungere un opportuno costruttore con parametri. Aggiungere due metodi: 
calcolaArea e calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.
Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console, i valori di base e di altezza con cui istanziare un nuovo Rettangolo. 
Dopo averlo istanziato, stampate a video il perimetro e l’area.
Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo) e provate a stampare le loro proprietà ad esempio con un metodo 
StampaRettangolo che vi stampi il vostro rettangolo ad esempio cosi:

—— Rettangolo1 —— base: 20 cm altezza: 10 cm Perimetro: 60 cm Area: 200 cm2
BONUS Aggiungere alla classe Rettangolo un metodo “disegna” che disegna in console il rettangolo con le sue dimensioni, ossia tanti “—” (due trattini) orizzontali quanto è grande 
la sua base e tanti ‘|’ verticali quanto e grande la sua altezza
 */


using System;           
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)  //entry point
        {
            //Chiedo all'utente base ed altezza
            Console.WriteLine("Inserisci la base");
            int baseRettangolo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci l'altezza");
            int altezzaRettangolo = Convert.ToInt32(Console.ReadLine());


            // ISTANZIO UN RETTANGOLO
            Rettangolo ret = new Rettangolo(baseRettangolo, altezzaRettangolo);


            // STAMPO AREA E PERIMETRO
            Console.WriteLine("Area: {0}", ret.calcolaArea());
            Console.WriteLine("Perimetro: {0}", ret.calcolaPerimetro());

            ret.stampaRettangolo();


            Rettangolo r2 = new Rettangolo(10, 20);
            Rettangolo r3 = new Rettangolo(110, 320);
            Rettangolo r4 = new Rettangolo(210, 540);

            r2.stampaRettangolo();
            r3.stampaRettangolo();
            r4.stampaRettangolo();


            // DISEGNO IL RETTANGOLO
            r2.Disegna();
        }
    }

}
