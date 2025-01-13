PlayCard
Description du projet
PlayCard est une application console développée en C# qui implémente un jeu de cartes de type « Pêche ». Ce projet a été réalisé dans le cadre du cours INF 1035 : Travail de Groupe I, visant à manipuler les concepts orientés objet. Le jeu est basé sur un jeu de 52 cartes et intègre des règles spécifiques pour des cartes spéciales telles que le Valet, l'As, le 10 et le 7.

Fonctionnalités principales
Initialisation :

Création d'un paquet de 52 cartes (valeurs : As, 2-10, Valet, Dame, Roi et couleurs : Trèfle, Carreau, Cœur, Pique).
Distribution aléatoire de cartes (5 à 8 cartes par joueur).
Gameplay :

Gestion automatique des tours des joueurs.
Suivi des actions des joueurs (cartes jouées, pioche, changement de direction, etc.).
Gestion des effets des cartes spéciales :
Valet (J) : Change la couleur de la pile de dépôt.
As : Saute le tour du joueur suivant.
10 : Change la direction du jeu.
7 : Oblige le joueur suivant à piocher 2 cartes (avec possibilité d'annulation si le joueur possède un autre 7).
Fin de partie :

Détection du vainqueur (joueur sans cartes restantes).
Calcul du score final basé sur la valeur des cartes restantes.
Stratégies :

Implémentation d'une stratégie pour minimiser le score des joueurs.
Notification lorsque qu’un joueur a une seule carte.
Architecture du projet
Le projet suit les principes de la programmation orientée objet et est structuré autour des concepts suivants :

Carte : Struct représentant une carte avec une valeur et une couleur.
Couleur et Valeur : Enumérations pour les couleurs (Trèfle, Carreau, Cœur, Pique) et les valeurs (As, 2-10, Valet, Dame, Roi).
Joueur et Personne : Classes représentant les joueurs et leurs informations (nom, prénom, identifiant).
PaireDeCartes : Classe représentant le paquet de cartes.
PileDePioche et PileDeDepot : Classes gérant les piles de cartes pour le jeu.
JeuxDePêche : Classe principale orchestrant le jeu.
TableDeJeu : Gère les interactions entre les joueurs et les piles.
Le projet respecte les principes suivants :

Pattern Observateur : Utilisé pour notifier les joueurs des événements.
Responsabilités distribuées : Chaque classe a un rôle clair et défini.
Éviter les variables statiques : Seules les constantes sont statiques.
Exécution
Pré-requis :

.NET SDK installé.
Visual Studio Code ou tout IDE compatible C#.
Instructions :

Clonez ce dépôt Git :
git clone https://github.com/<VotreNomUtilisateur>/PlayCard.git
Accédez au répertoire du projet :
cd PlayCard
Compilez et exécutez le projet :
dotnet run
