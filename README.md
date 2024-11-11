Introduction
Le Calculateur de Masque Réseau est une application qui facilite le calcul des adresses réseau en entrant une adresse IPv4 et un masque d'adresse. 
Cette application fournit des résultats détaillés incluant :
  La classe de l'adresse IP
  L'adresse réseau et l'adresse de diffusion (broadcast)
  La première et la dernière adresse IP
  Le nombre total d'adresses IP et de machines disponibles

Fonctionnalités
  Saisie des Données
    L'utilisateur entre une adresse IPv4 en 4 octets, soit en décimal soit en binaire. La conversion est automatique.
    L'utilisateur choisit également le masque d'adresse en utilisant soit un masque CIDR, soit un masque sur 4 octets.
    Un bouton "Calculer" permet de valider les informations et obtenir les résultats.
    
  Vérification des Données
    Adresse IPv4 : Chaque octet est vérifié pour être compris entre 0 et 255 en décimal, et doit être composé uniquement de 1 et de 0 en binaire.
    Masque d'adresse : Le masque CIDR doit être compris entre 8 et 32.
      Classe A : >= 8
      Classe B : >= 16
      Classe C : >= 24
      
  Calculs
    Classe de l'adresse IP : En fonction du premier octet en binaire, l'application détermine la classe de l'adresse.
      Classe A : 0 - 127
      Classe B : 128 - 191
      Classe C : 192 - 223
      Classe D : 224 - 239
      Classe E : 240 - 255
  Adresse réseau et adresse de diffusion (broadcast) 
  Première et dernière adresse IP 
  Nombre d'adresses IP et de machines 
  
Interface Utilisateur (Windows Forms)
  L'application dispose d'une interface graphique simple développée avec Windows Forms. L'utilisateur peut facilement entrer les données et afficher les résultats dans des champs dédiés. L'interface inclut les éléments suivants :
    Zones de saisie pour l'adresse IPv4 (en décimal et en binaire).
    Sélecteur pour le masque d'adresse (CIDR ou masque sur 4 octets).
    Bouton "Calculer" pour afficher les résultats.
    Zones de texte pour afficher la classe de l'adresse IP, l'adresse réseau, l'adresse de diffusion, la première et la dernière adresse IP, ainsi que le nombre d'adresses IP et de machines.

Tests et Validation L'application comprend également une suite de tests unitaires pour valider les calculs. Ces tests garantissent la conformité avec les spécifications du RFC 5735, et vérifient que les résultats sont corrects pour divers scénarios d'adresses IP et de masques. Les tests incluent :
  Validation de la saisie des adresses IP en décimal et binaire.
  Vérification des calculs des adresses réseau, de diffusion, et des plages d'adresses.
  Tests de la conversion automatique entre les formats d'adresse IP (binaire, décimal) et le masque CIDR.
