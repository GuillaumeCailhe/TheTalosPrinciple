using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Cette classe gère tous les objets qui peuvent être ramassés : Cubes, Jammers, Connecteurs...
    Elle implémente l'interface Interactive.
*/
public class Pickable : MonoBehaviour, Interactive
{
    public string objectName = "Object";
    public GhostObject ghostObject;
    private PickablePlacementArea objectPlacedOn = null;
    public PickablePlacementArea placementArea;

    // Retourne le message d'interaction qu'on voit sur l'UI
    public string getInteractionMessage()
    {
        return "Pick " + objectName;
    }

    // Retourne l'objet de prévisualisation
    public GhostObject getGhostObject()
    {
        return ghostObject;
    }

    // On peut toujours prendre un Pickable (sauf si c'est un cube et qu'il y a un objet au dessus).
    public bool canInteractWith()
    {
        if(placementArea)
        {
            return placementArea.canPlace();
        }
        return true;
    }
    /*
        Désactive l'objet quand il est ramassé par le joueur.
        On ne le supprime pas pour conserver une trace de l'objet et le téléporter plus tard.
    */
    public void interactWith()
    {
        // Si cet objet était placé sur un cube/bouton, on prévient cet objet que ça n'est plus le cas.
        if(objectPlacedOn)
        {
            objectPlacedOn.reset();
            objectPlacedOn = null;
        }

        // Pour éviter qu'on puisse placer quelque chose sur l'objet désactivé
        if(placementArea)
        {
            placementArea.gameObject.SetActive(false);
        }

        // Désactivation de l'affichage / collisions
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;
    }

    // Est appelé quand l'objet est placé quelque part
    public void drop()
    {
        GetComponent<BoxCollider>().enabled = true;
        GetComponent<MeshRenderer>().enabled = true;

        if(placementArea)
        {
            placementArea.gameObject.SetActive(true);
        }
    }

    // Place un objet sur une Pickable Placement Area (un cube ou un bouton)
    public void placeOn(PickablePlacementArea ppa)
    {
        objectPlacedOn = ppa;
    }
}
