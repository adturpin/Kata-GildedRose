Bonjour et bienvenue dans l'équipe Gilded Rose. 
Comme vous le savez, nous sommes une petite auberge avec un emplacement privilégié dans une ville importantedirigé par un sympathique aubergiste nommé Allison. 
Nous achetons et vendons également uniquement les meilleurs produits.
Malheureusement, nos produits se dégradent constamment en qualité à l'approche de leur date de vente. Nous avons un système en place qui met à jour notre inventaire pour nous.
Il a été développé par un type no-nonsense nommé Leeroy, qui est passé à de nouveaux aventures.
Votre tâche consiste à ajouter la nouvelle fonctionnalité à notre système afin que nous puissions commencer à vendre une nouvelle catégorie de articles.
D'abord une introduction à notre système:
	Tous les articles ont une valeur SellIn qui indique le nombre de jours que nous devons vendre l'article
	Tous les articles ont une valeur de qualité qui indique la valeur de l'article

À la fin de chaque journée, notre système baisse les deux valeurs pour chaque article Assez simple, non?
Eh bien, c'est là que ça devient intéressant:
	Une fois la date limite de vente écoulée, la qualité se dégrade deux fois plus vite
	La qualité d'un article n'est jamais négative
	"Brie vieilli" augmente en fait de qualité plus il vieillit
	La qualité d'un article n'est jamais supérieure à 50
	"Sulfuras", étant un article légendaire, n'a jamais à être vendu ou diminue en qualité
	Les «coulisses des coulisses», comme le brie vieilli, augmentent en qualité à mesure que la valeur de SellIn approche; La qualité augmente par 2 quand il y a 10 jours ou moins et par 3 quand il y a 5 jours ou moins mais la qualité tombe à 0 après le concert
Nous avons récemment signé un fournisseur d'articles invoqués. 
Cela nécessite une mise à jour de notre système:
	Les objets «invoqués» se dégradent en qualité deux fois plus vite que les objets normaux
N'hésitez pas à apporter des modifications à la méthode UpdateQuality et à ajouter tout nouveau code tant que tout reste
fonctionne correctement. Cependant, ne modifiez pas la classe Item ou la propriété Items car celles-ci appartiennent au gobelin dans le
coin qui va insta-rage et one-shot vous car il ne croit pas en la propriété du code partagé (vous pouvez faire le
La méthode UpdateQuality et la propriété Items sont statiques si vous le souhaitez, nous couvrirons pour vous).
