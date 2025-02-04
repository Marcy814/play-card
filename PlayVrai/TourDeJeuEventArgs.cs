using System;

namespace Devoir_1_INF1035;

public class TourDeJeuEventArgs : EventArgs
{
    public Joueur Joueur { get; }
    public Carte CarteJouee { get; }
    public Carte CarteDepot { get; }

    public TourDeJeuEventArgs(Joueur joueur, Carte carteJouee, Carte carteDepot)
    {
        Joueur = joueur;
        CarteJouee = carteJouee;
        CarteDepot = carteDepot;
    }
}
