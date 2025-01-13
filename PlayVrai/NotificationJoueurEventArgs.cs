namespace Devoir_1_INF1035;

public class NotificationJoueurEventArgs : EventArgs {
    public Joueur Joueur { get; }

    public NotificationJoueurEventArgs(Joueur joueur) {
        Joueur = joueur;
    }
}