
# Project AP GSB

Ce projet est une application de gestion de médicament, ou les médicament sont trié, affiché par étape, et validation, et ou l'on peut en ajouter.



## Table des matière


- [Ressource](#Ressource)
- [Mode d'emploie instalation base de données](#tutoBDD)
- [Utilisation](#utilisation)
- [Utilisateur](#Utilisateur)
- [Languages](#language)
- [Auteurs](#auteurs)

## Ressource 

Pour faire fonctionne le projet vous aurez besoin de l'appiclation GSB en c#, de sql serveur, ainsi que d'un OS sous windows.

## Tuto

Lancer votre sql serveur, faite un clique droit sur l'onglet base de données a gauche dans l'explorateur d'objet, et faite nouvelle base de données, ensuite saisissez GSB_gesAMM dans le nom de la base de données. Ensuite séléctioner votre base de données et glissez déposer le document script.sql dans sql serveur et appuyer sur le boutton executer.

il faudra aussi crée une classe connexion.cs et y collez ceci :

public static SqlConnection cnx;
public static String nomServeur = "Data Source=ROXSTRIXG17JC;Initial Catalog=GSB_gesAMM;Integrated Security=True;MultipleActiveResultSets=True";

Veillez a remplacez Data Source=ROXSTRIXG17JC par le nom de votre serveur sql serveur.


## Utilisation

Il vous suffit d'allez dans le dossier du projet et de lancé APPGSB.sln, une fois l'application visual studio lancé, appuyer sur executer.


## Utilisateur

Un utilisateur est déja crée dans la base de données voici ces logs :
nom d'utilisateur : test
mot de passe : test1234.HAHAB?


## Languages

Les Languages utilisée sont :

- C#
- SQL
## Auteurs

Chef de projet : Carlos RODIRGUES DIAS
Équipe : Jonathan LEMERCIER et Julien Cochard