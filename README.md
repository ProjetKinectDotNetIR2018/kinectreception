# middleoffice
Middle Office avec les étudiants ESAIP IR 2018

# kinectreception
Kinect Reception permet la transition entre les votes via la Kinect pour une demande récupérée dans le Middle Office
la partie du projet kinectreception repart du projet initial prévu sur VSCode, avec les classes de base défini avec vous en cours.
le problème est un soucis d'autorisation de connexion depuis le port 83 (le miens) je ne sais pas si c'est dû à un problème logiciel ou réseau ou code... on a fait ce qu'on a pu dans le peu de temps perso que nous avons eu ces derniers jours.

# api signature
POST /requests : ajoute une demande de vote
GET /requests : liste toutes les demandes en attente
GET /requests/{id} : affiche une demande pour lecture et vote éventuel
POST /requests/{id}/vote : donne un choix de vote pour une demande

# deploiement sur esaip.westeurope.cloudapp.azure.com
Connexion au SSH 22 avec user esaip / mot de passe donné en cours

# affectation des ports
80 : JP (Prof)
83 : Alexandre
86 : Antoine
87 : Benjamin

# commandes git 
Pour importer le projet sur le serveur (il faut être positionné dans le dossier qui porte son nom):

	git clone (url du git)

Pour supprimer le dossier du projet qui a été cloné :

	rm -rf (nomduprojet)/

# commandes Docker
Pour compiler, c'est-à-dire créer une image à partir du Dockerfile dans le répertoire courant :

    docker build -t jpgouigoux/middleoffice .

Pour démarrer un conteneur à partir de l'image sur un port donné, avec un nom :

    docker run -d -p 80:80 --name jp jpgouigoux/middleoffice

Pour lister tous les conteneurs lancés (y compris ceux arrêtés) :

    docker ps -a

Pour afficher toutes les images disponibles dans le cache local :

	docker images

Pour afficher les logs d'un conteneur :

	docker logs jp

Pour supprimer complètement un conteneur, en forçant son arrêt et en supprimant ses données :

    docker rm -fv jp

