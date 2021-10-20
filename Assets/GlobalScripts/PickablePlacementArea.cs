using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Permet de placer les objets Pickable ailleurs que sur un sol.
    Utilisé par les cubes et les boutons.
*/
public class PickablePlacementArea : MonoBehaviour
{
    public GameObject placementPosition;
    private Pickable placedObject;

    /*
        Place un objet sur l'emplacement.
    */
    public void place(Pickable pickable)
    {
        placedObject = pickable;
        placedObject.placeOn(this);
    }

    // Enlève l'objet placé.
    public void reset()
    {
        placedObject = null;
    }

    // Vérifie qu'on peut bien placer un objet sur cet emplacement.
    public bool canPlace()
    {
        return placedObject == null;
    }

    // Renvoie la position où placer l'objet en question.
    public Vector3 getPlacementPosition()
    {
        return placementPosition.transform.position;
    }

}