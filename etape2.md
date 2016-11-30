
# Etape 1: Extrapolation du prix simple

Enoncé:

Il faut créer un MiniPricer pouvant donner le prix dans le futur d’un instrument en fonction de:

La date dans le futur du prix.
Le prix actuel  de l’instrument.
La volatilité moyenne journalière en % de l’instrument.
Sachant que la volatilité moyenne journalière représente sa variation prix moyenne d’un jour à l’autre. En d’autres termes,  si l’instrument vaut P à J, à J+1 il vaut P x (1+V/100) en moyenne. Où V est la volatilité journalière moyenne de l’instrument exprimée en %

Note: Pour cette étape on considère que la variation de prix de l’instrument est toujours égale à sa volatilité moyenne.


------------
A la fin de létape:


Les marchés sont fermés le samedi, le dimanche, et les jours fériés, donc la variation de prix de l’instrument est nulle, ces jours là. Y avez vous pensé ?

Note: pour simplifier on peut ne considérer que les jours fériés à date fixe 01/01, 01/05, 08/05… et pas ceux comme le lundi de pentecôte, Lundi de Pâques… Toujours pour simplifier, on peut en considérer que les 3 premiers, donnée précédemment.




# Etape 2: Le caractère aléatoire

 Enoncé:

En fait, un instrument ne varie jamais exactement de sa volatilité moyenne tous les jours. Comme son nom le dit C’est une moyenne. De plus la valeur de la volatilité est une valeur absolue, donc le prix de l’instrument peut augmenter ou descendre de cette valeur.

Revoir la méthode de calcul du prix en considérant que chaque jour soit le prix augmente de la volatilité moyenne, soit le prix ne bouge pas, soit le prix baisse de la volatilité moyenne. Le choix entre les trois mouvements possibles devant être aléatoire.
