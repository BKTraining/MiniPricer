
# Etape 2: Le caractère aléatoire

 Enoncé:

En fait, un instrument ne varie jamais exactement de sa volatilité moyenne tous les jours. Comme son nom le dit C’est une moyenne. De plus la valeur de la volatilité est une valeur absolue, donc le prix de l’instrument peut augmenter ou descendre de cette valeur.

Revoir la méthode de calcul du prix en considérant que chaque jour soit le prix augmente de la volatilité moyenne, soit le prix ne bouge pas, soit le prix baisse de la volatilité moyenne. Le choix entre les trois mouvements possibles devant être aléatoire.

A la fin de l’étape:

Comment avez vous fait pour écrire un test sachant que le résultat de la méthode à tester est plus ou moins aléatoire ?

Avez vous utilisé des tests sur les extremums ( nb jours ouvrés x volatilité x -1 >= Prix >= nb jours ouvrés x volatilité x 1) ?

Avez vous utilisé un faux (mock) générateur de nombre aléatoire en vérifiant le nombre de fois où il a été appelé par exemple ?

# Etape 3: Monté-Carlo

Enoncé:

En fait faire un seul tirage aléatoire par jour n’est pas du tout satisfaisant d’un point de vue mathématique. Une meilleure stratégie est de créer un grand nombre de trajectoires de prix et d’en faire la moyenne. Une trajectoire de prix étant ce qu’on a fait à l’étape précédente. A savoir tous les jours on fait un tirage au sort de la variation du prix à appliquer, et ce pour chaque jour à considérer. C’est ce qu’on appelle utiliser la méthode de Monté-Carlo (grand nombre d’aléas en entrée d’un processus connu et moyenne au final).
