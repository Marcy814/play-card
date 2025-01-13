
namespace Devoir_1_INF1035;


class PileDePioche : IPileDeCartes
{
    private Stack<Carte> pioche = new Stack<Carte>();

    public void AjouterCarte(Carte carte)
    {
        pioche.Push(carte);
    }

    public Carte RetirerCarte()
    {
        return pioche.Pop();
    }

    public bool EstVide()
    {
        return pioche.Count == 0;
    }

    
}