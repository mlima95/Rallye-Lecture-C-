# PPE - Application C# Rallye Lecture

 Interface réalisé en Windows Form permettant de créer des identifiants et mot de passe des élèves du site Rallye Lecture à partir d'un fichier CSV
 
Le projet est divisé en 3 grandes parties:
* Lecture des informations des élèves.
* Ecriture d'un fichier csv avec les informations de connexion(login, mot de passe) de chaques élèves. 
* Alimentation d'une base de données.



Nous avons tout d'abord créée une base de données afin de traiter les informations : 
![Bdd](https://github.com/mlima95/Rallye-Lecture-Csharp/blob/master/schemaDbRallyeLecture.PNG)

# Tables liées à la gestion des autorisations :
![BddAauth](https://github.com/mlima95/Rallye-Lecture-Csharp/blob/master/schemaDbAauth.PNG)

# Cas Utilisation
![Bdd](https://github.com/mlima95/Rallye-Lecture-Csharp/blob/master/Use_Case_Diagram.png)

# Diagramme de Classes :

* Classes d'accès aux données 
![DcDonnées](https://github.com/mlima95/Rallye-Lecture-Csharp/blob/master/ClasseCnx.PNG)

* Classes métiers

![DcMétier](https://github.com/mlima95/Rallye-Lecture-Csharp/blob/master/ClasseM%C3%A9tier.PNG)

* Classe technique

![DcTechnique](https://github.com/mlima95/Rallye-Lecture-Csharp/blob/master/Class_Diagram_Technical.png)

* Le Windows Form se présente ainsi :

![Wf](https://github.com/mlima95/Rallye-Lecture-Csharp/blob/master/WF%20New%20Classe%20Rallye%20Lecture.PNG)

Le professeur peut ainsi choisir un fichier CSV contenant le prénom et le nom de famille des élèves il pourra ainsi déterminer l'année, le niveau,la classe et si le mot de passe et aléatoire ou construit(première lettre du prénom + nom de famille)

# Fichier Original/Fichier créée:
![Avant](https://github.com/mlima95/Rallye-Lecture-Csharp/blob/master/CaptureAvant.PNG)
![Apres](https://github.com/mlima95/Rallye-Lecture-Csharp/blob/master/CaptureApres.PNG)

## Languages
```

- C#

- Sql

```
## Outils
```
- Visual Studio 2017
- MySql
- Sublime Text (Editor)

```

