namespace Devoir_1_INF1035;


// Structure représentant une carte
public struct Carte
{
    public Couleur Couleur { get; }
    public Valeur Valeur { get; }

    public Carte(Couleur couleur, Valeur valeur)
    {
        Couleur = couleur;
        Valeur = valeur;
    }

    public override string ToString()
    {
        return $"{Valeur} de {Couleur}";
    }
}
