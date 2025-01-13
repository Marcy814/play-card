namespace Devoir_1_INF1035;

class TableDeJeu
{
    public PileDePioche Pioche { get; set; }
    public PileDeDepot Depot { get; set; }
    public List<Joueur> Joueurs { get; set; }

    public TableDeJeu()
    {
        Pioche = new PileDePioche();
        Depot = new PileDeDepot();
        Joueurs = new List<Joueur>();
    }

    public void RemplirPiocheSiVide()
{
    if (Pioche.EstVide())
    {
        Console.WriteLine("La pioche est vide. Remplissage à partir de la pile de dépôt.");
        var depot = Depot;

        // Retirer la dernière carte de dépôt
        Carte derniereCarte = depot.RetirerCarte();

        // Mélanger les cartes de la pile de dépôt
        List<Carte> cartesDepot = new List<Carte>();
        while (!depot.EstVide())
        {
            cartesDepot.Add(depot.RetirerCarte());
        }
        // Remettre la dernière carte de dépôt sur la pile de dépôt
        depot.AjouterCarte(derniereCarte);
        // Mélanger les cartes et les remettre dans la pioche
        Random rand = new Random();
        for (int i = cartesDepot.Count - 1; i > 0; i--)
        {
            int j = rand.Next(i + 1);
            Carte temp = cartesDepot[i];
            cartesDepot[i] = cartesDepot[j];
            cartesDepot[j] = temp;
        }
        foreach (var carte in cartesDepot)
        {
            Pioche.AjouterCarte(carte);
        }

        Console.WriteLine("La pile de dépôt a été mélangée et ajoutée à la pioche.");
    }
}


    
}