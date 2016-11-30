# Introduction

## Objectifs

Le premier objectif de ce Kata est identique à tous les Kata: S’améliorer dans la technique du TDD, par l’écriture de tests, l’écriture du code. Puis le refactoring des tests et du code à cause des changements de spécifications (complexification de l’algo, exception à la règle, besoin d’amélioration techniques induit,…).

Le deuxième objectif de ce kata est de vous donner une idée, certes sommaire mais idée tout de même, de comment peut fonctionner un pricer « On Demand » dans la finance de marché.

Enfin, pour certaines étapes on va voir les « limites » des tests unitaires, je vous laisse débattre de s’il faut trouver des moyens de les franchir ou pas. Et si oui de comment le faire.

# Etape 1: Extrapolation du prix simple

Enoncé:

Il faut créer un MiniPricer pouvant donner le prix dans le futur d’un instrument en fonction de:

La date dans le futur du prix.
Le prix actuel  de l’instrument.
La volatilité moyenne journalière en % de l’instrument.
Sachant que la volatilité moyenne journalière représente sa variation prix moyenne d’un jour à l’autre. En d’autres termes,  si l’instrument vaut P à J, à J+1 il vaut P x (1+V/100) en moyenne. Où V est la volatilité journalière moyenne de l’instrument exprimée en %

Note: Pour cette étape on considère que la variation de prix de l’instrument est toujours égale à sa volatilité moyenne.
