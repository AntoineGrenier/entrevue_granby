# Exercices de polymorphisme en C#

Ce document présente trois exercices progressifs pour pratiquer le polymorphisme en C#.

---

## Exercice 1 : Polymorphisme simple avec animaux
**Objectif :** Illustrer le polymorphisme dynamique avec une méthode commune `Vocaliser()`.

### Énoncé
- Créez une classe abstraite `Animal` avec une méthode abstraite `Vocaliser()`.
- Créez deux classes concrètes `Chien` et `Chat` qui héritent de `Animal`.
- Chaque classe doit afficher un message spécifique dans `Vocaliser()`.
- Dans `Main()`, créez une liste d’`Animal` et appelez `Vocaliser()` sur chaque élément.

---

## Exercice 2 : Interface et classe abstraite (véhicules)
**Objectif :** Introduire l’interface et la classe abstraite pour montrer deux niveaux d’abstraction.

### Énoncé
- Créez une interface `IVehicule` avec les méthodes `Demarrer()` et `Arreter()`.
- Créez une classe abstraite `Vehicule` qui implémente `IVehicule` et ajoute une propriété `Couleur`.
- Créez deux classes concrètes `Voiture` et `Velo` qui héritent de `Vehicule`.
- Chaque classe doit définir ses propres comportements pour `Demarrer()` et `Arreter()`.
- Dans `Main()`, créez une liste de `Vehicule` et appelez les méthodes sur chaque élément.

---

## Exercice 3 : Polymorphisme avec instruments de musique
**Objectif :** Illustrer le polymorphisme dynamique avec des actions communes (`Jouer`, `Accorder`) et une propriété `Nom`.

### Énoncé
- Créez une interface `IInstrument` avec les méthodes `Jouer()` et `Accorder()`.
- Créez une classe abstraite `Instrument` qui implémente `IInstrument`, avec :
  - une propriété protégée `string nom`,
  - une méthode `Jouer()` virtuelle avec comportement générique,
  - une méthode `Accorder()` abstraite.
- Créez trois classes concrètes (`Guitare`, `Piano`, `Batterie`) qui héritent de `Instrument`, chacune avec un nom par défaut et ses propres implémentations.
- Dans `Main()`, créez une liste d’`Instrument` et appelez `Jouer()` et `Accorder()` sur chaque élément.

---
