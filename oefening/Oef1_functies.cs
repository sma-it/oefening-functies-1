using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace First
{
    class Oef1_functies
    {

        /* Functie 1: Maak een functie ZetOmCm() die een afstand in inch omzet in cm. De afstand in inch kan een kommagetal zijn.
         * Rond af op 2 getallen na de komma.
         * Opm.: Omzetting inch -> cm: 1 inch= 2.54 cm
        */

        // Schrijf hier functie 1


        /* Functie 2: Schrijf een functie BerekenOppRh() die de oppervlakte van een rechthoek berekent.
        */

        // Schrijf hier functie 2

        /* Functie 3: Maak een functie BerekenBoete() die aan de hand van het aantal boeken en het aantal dagen dat de uitleentermijn 
         * overschreden werd, berekent hoeveel de boete is.
         * Deze boete wordt als volgt bepaald:
         * de boete bedraagt 0,07 euro per boek per dag. Voor personen die reeds meerdere malen hun boeken te laat binnenbrachten wordt
         * er echter 0.09 euro per boek per dag aangerekend. Voorzie voor de prijs van de boete een functieargument dat je instelt op een default
         * waarde van 0.07.
         * 
        */

        // Schrijf hier functie 3

        /* Functie 4: Een telecom-operator hanteert volgende prijzen:
         * De eerste minuut (= 60 seconden) wordt steeds volledig aangerekend, ook al duurt het gesprek geen volle minuut. 
         * Deze eerste minuut kost meestal 75 eurocent, behalve bij bepaalde abonnementen wordt 90 eurocent aangerekend. Voorzie
         * voor deze prijs een default waarde van 0.75 bij het argument.
         * Na de eerste minuut wordt er met seconden gewerkt. Voor één seconde wordt er 1 eurocent aangerekend.
         * Maak een functie die de prijs van een telefoongesprek bepaalt. 
         */

        // Schrijf hier functie 4

        /* Functie 5: Maak een functie BepaalVolgendPriemgetal(): deze functie bepaalt het eerste priemgetal dat op het functieargument 
         * volgt. Maak hierbij gebruik van de functie IsPriem() die je reeds uitwerkte in een vorige oefeningenreeks en die je 
         * hieronder terugvindt.
         * Geef het eerstvolgende priemgetal als functieresultaat.
         */

        public static bool IsPriem(int a)
        {
            bool priem = true;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    priem = false;
                }
            }
            return priem;
        }

        /* Werk hier de functie BepaalVolgendPriemgetal uit.
         */

        // Schrijf hier functie 5

        /* Functie 6: Werk een functie BerekenBmi() uit die a.h.v. een ingegeven gewicht en lengte de bmi als volgt berekent:
         * bmi=gewicht/lengte²      Hierbij is gewicht in kilogram en lengte in meter.
         * Rond de bmi af op 1 cijfer na de komma.
         * Te gebruiken volgorde van de functieargumenten: gewicht, lengte
         * Tip: gebruik Math.pow() voor het berekenen van het kwadraat.
         */

        // Schrijf hier functie 6

        /* Functie 7: Maak een functie BoodschapBmi() die afhankelijk van de bmi van een persoon een gepaste boodschap als functieresultaat geeft.
         * Hanteer volgende regels:
         * Ondergewicht: <18,5
         * Gezond gewicht: 18,5 tot 24,9
         * Overgewicht: 25 tot 29,9
         * Obesitas: >30
         * Maak bij het uitwerken van deze functie gebruik van de functie BerekenBmi() die je hierboven reeds maakte.
         * Te gebruiken volgorde van de functieargumenten: gewicht, lengte
         */

        // Schrijf hier functie 7

    }
}
