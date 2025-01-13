namespace  Devoir_1_INF1035;
class PileDeDepot : IPileDeCartes
{
    private Stack<Carte> depot = new Stack<Carte>();

    public void AjouterCarte(Carte carte)
    {
        depot.Push(carte);
        //Console.WriteLine($"{carte} a été ajoutée à la pile de dépôt.");
    }

    public Carte RetirerCarte()
    {
        return depot.Pop();
    }

    public bool EstVide()
    {
        return depot.Count == 0;
    }
    public Carte derniereCartePile(){
        return depot.Peek();

    }


}