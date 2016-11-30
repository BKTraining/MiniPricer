
# Etape 4: Le panier d’instruments

Enoncé:

Pour aller plus vite, on veut pricer tous les instruments d’un même panier en un coup. La méthode que l’on va appliquer est la suivante. On va pricer un instrument dit pivot selon la méthode précédente. Et grâce à la corrélation moyenne des autres instruments par rapport a cet instrument pivot, on calcul la variation de prix de ces instruments. La corrélation représente le lien entre la variation de prix de deux actifs. Elle est généralement exprimée de manière signée, mais en %. A savoir si la corrélation entre deux instruments vaut -1, cela veut dire que quand l’un monte de X%, l’autre baisse de X%

A la fin de l’étape:

Peut-on toujours pricer qu’un seul instrument ? Avez-vous gardé vos premiers tests ? Les avez vous refactorisés ?

Ce changement de spécification a-t-il engendré un changement de l’API de votre MiniPricer ? Est-ce nécessaire/bien ?



# Etape 5: La précision sur demande

Avertissement:

Cette étape n’apporte pas grand chose en termes de TDD ou méthodologie de travail, il s’agit juste de changer l’algo de pricing pour plus de commodité de l’utilisateur. En gros c’est l’étape bonus. Ceux qui ne voudrait pas la faire, allez à la fin directement.

Enoncé:

On doit pouvoir choisir la précision du prix déterminé par le pricer. On doit pouvoir dire au pricer que l’on veut un prix précis à 0.01€ près.

Pour ceux qui sécheraient complément sur l’algo à mettre en oeuvre voici une petite astuce: la précision du prix dépend du nombre de trajectoires calculées. Plus on a de trajectoires plus la précision est grande. Un moyen simple de le faire est de calculer un certains nombres de trajectoires, calculé la moyenne de la distance de chacune des trajectoires par rapport à la moyenne (écart type). De vérifier que l’écart type est en dessous de la précision demandée. Si ce n’est pas le cas recommencer en ajoutant les trajectoires les nouvelles trajectoires aux anciennes et en recalculant le nouvel écart type et ainsi de suite. La différence de prix étant bornée entre les trajectoires, + ou – nb jour ouvrés x Volatilité aux extremums, plus le nombre de trajectoires augmente, plus la précision aussi.
