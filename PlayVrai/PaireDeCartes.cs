namespace Devoir_1_INF1035;

using System;
using System.Collections.Generic;

// Classe gérant un jeu complet de 52 cartes
class PaireDeCartes
{
    private List<Carte> cartes;

    public PaireDeCartes()
    {
        cartes = new List<Carte>();
        foreach (Couleur couleur in Enum.GetValues(typeof(Couleur)))
        {
            foreach (Valeur valeur in Enum.GetValues(typeof(Valeur)))
            {
                cartes.Add(new Carte(couleur, valeur));
            }
        }
    }

    public void AfficherCartes()
        {
            int i =0;
            cartes.Count();
            
            foreach (var carte in cartes)
            {
                Console.WriteLine(carte);
                i++;
            }
            Console.WriteLine(cartes.Count());
    
        }

    // Mélanger les cartes
    public void Melanger()
    {
        Random rand = new Random();
        int n = cartes.Count;
        while (n > 1)
        {
            n--;
            int k = rand.Next(n + 1);
            Carte valeur = cartes[k];
            cartes[k] = cartes[n];
            cartes[n] = valeur;
        }
    }

    // Distribuer un nombre de cartes
    public List<Carte> DistribuerCartes(int nombre)
    {
        List<Carte> main = new List<Carte>();
        for (int i = 0; i < nombre; i++)
        {
            if (cartes.Count == 0) break;
            main.Add(cartes[0]);
            cartes.RemoveAt(0);
        }
        return main;
    }

    public bool EstVide()
    {
        return cartes.Count == 0;
    }
}
