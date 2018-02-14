# middleoffice
Middle Office avec les �tudiants ESAIP IR 2018

# kinectreception
Kinect Reception permet la transition entre les votes via la Kinect pour une demande r�cup�r�e dans le Middle Office

# api signature
POST /requests : ajoute une demande de vote
GET /requests : liste toutes les demandes en attente
GET /requests/{id} : affiche une demande pour lecture et vote �ventuel
POST /requests/{id}/vote : donne un choix de vote pour une demande

# deploiement sur esaip.westeurope.cloudapp.azure.com
Connexion au SSH 22 avec user esaip / mot de passe donn� en cours

# affectation des ports
80 : JP (Prof)
83 : Alexandre
86 : Antoine
87 : Benjamin

# commandes git 
Pour importer le projet sur le serveur (il faut �tre positionn� dans le dossier qui porte son nom):

	git clone (url du git)

Pour supprimer le dossier du projet qui a �t� clon� :

	rm -rf (nomduprojet)/

# commandes Docker
Pour compiler, c'est-�-dire cr�er une image � partir du Dockerfile dans le r�pertoire courant :

    docker build -t jpgouigoux/middleoffice .

Pour d�marrer un conteneur � partir de l'image sur un port donn�, avec un nom :

    docker run -d -p 80:80 --name jp jpgouigoux/middleoffice

Pour lister tous les conteneurs lanc�s (y compris ceux arr�t�s) :

    docker ps -a

Pour afficher toutes les images disponibles dans le cache local :

	docker images

Pour afficher les logs d'un conteneur :

	docker logs jp

Pour supprimer compl�tement un conteneur, en for�ant son arr�t et en supprimant ses donn�es :

    docker rm -fv jp

