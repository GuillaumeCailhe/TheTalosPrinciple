using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Cette interface est la base de tous les objets avec lesquels le joueur peut interagir.
*/
public interface Interactive
{
    // Retourne le message d'interaction visible sur le HUD lorsqu'on interagit avec un objet.
    public string getInteractionMessage();

    // Définit ce qui se passe quand le joueur interagit avec l'objet.
    public void interactWith();

    // Vérifie qu'on peut bien interagir avec un objet.
    public bool canInteractWith();
}
