# EvaluationGauthierCadet

Je me suis fait avoir avec la parallelisation dans la lecture des fichiers, je n'ai pas le m�me nombre de mots � chaque execution.

## Evaluation
- L'objectif est de r�aliser quelque chose comme nous avons vu dans le dernier exercice (plus complet)

### Objectifs
- R�aliser les op�rations asynchrones qui peuvent l'�tre et faire des calculs sur certains �l�ments
- Tout se fait dans un projet console

### R�alisations � faire
En utilisant le parall�lisme, r�alisez le workflow vu sur slides, dont voici quelques informations : 
- Faire un calcul de la somme de tous les nombres entre 1 et 3000 en op�ration parall�le
- Afficher le r�sultat du calcul de la somme des nombres entre 1 et 3000
- (Ce premier calcul doit �tre effectu� en amont, pas en parall�le des deux prochains)
- (N'oubliez pas la propri�t� "toujours copier" pour les fichiers Eval_file1.txt et Eval_file2.txt)
- Traiter deux fichiers pour compter le nombre de mots (s�parateur " ")
- Traiter deux fichiers pour compter d'occurences de "Lorem ipsum" (A vous de trouver un moyen de r�aliser cette �tape)
- (Ces deux �tapes pr�c�dentes doivent �tre faites en parall�le)
- Afficher le nombre de mots des deux fichiers 
- Afficher le nombre d'occurences de "Lorem ipsum" des deux fichiers
- R�aliser une op�rations finale qui affiche la somme des 5 nombres r�sultats pr�c�dents
- Afficher les informations pour chaque �tape, celle du r�sultat finale attendu et le temps de traitement dans la Console

### PS
- Attention � ce que votre r�sultat soit TOUJOURS coh�rent � chaque ex�cution de votre code. 
- Je dis �a, car en fonction de comment vous allez g�rer vos op�rations, vous risquez d'avoir des suprises.
