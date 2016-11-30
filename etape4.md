
# Etape 3: Monté-Carlo

Enoncé:

En fait faire un seul tirage aléatoire par jour n’est pas du tout satisfaisant d’un point de vue mathématique. Une meilleure stratégie est de créer un grand nombre de trajectoires de prix et d’en faire la moyenne. Une trajectoire de prix étant ce qu’on a fait à l’étape précédente. A savoir tous les jours on fait un tirage au sort de la variation du prix à appliquer, et ce pour chaque jour à considérer. C’est ce qu’on appelle utiliser la méthode de Monté-Carlo (grand nombre d’aléas en entrée d’un processus connu et moyenne au final).

A la fin de l’étape:

Peut-on choisir le nombre de trajectoires ? Devrait-on d’après l’énoncé ?

Avez vous touché aux tests précédents ? Comment verifier que l’algorithme à bien changé sans casser l’encapsulation ?

Avez vous mis en parallèle  le calcul des trajectoires ? Si oui, doit/peut on le vérifier par un test ?



# Etape 4: Le panier d’instruments

Enoncé:

Pour aller plus vite, on veut pricer tous les instruments d’un même panier en un coup. La méthode que l’on va appliquer est la suivante. On va pricer un instrument dit pivot selon la méthode précédente. Et grâce à la corrélation moyenne des autres instruments par rapport a cet instrument pivot, on calcul la variation de prix de ces instruments. La corrélation représente le lien entre la variation de prix de deux actifs. Elle est généralement exprimée de manière signée, mais en %. A savoir si la corrélation entre deux instruments vaut -1, cela veut dire que quand l’un monte de X%, l’autre baisse de X%
