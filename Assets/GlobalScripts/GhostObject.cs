using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Gère la prévisualisation des objets Pickable.
    Sa principale fonction est de vérifier qu'il n'y a aucune collisions avant de placer l'objet en question.
*/
public class GhostObject : MonoBehaviour
{
    // Cette classe se charge de compter les objets avec lesquels on a des collisions.
    
    private List<GameObject> touchingObjects;

    void Start() {
        touchingObjects = new List<GameObject>();
    }

    void OnTriggerEnter(Collider collision) {
        if(collision.tag != "Floor")
        {
            if (!touchingObjects.Contains(collision.gameObject))
            {
                touchingObjects.Add(collision.gameObject);
            }
        }
    } 
    
    void OnTriggerExit(Collider collision) {
        if (touchingObjects.Contains(collision.gameObject))
        {
            touchingObjects.Remove(collision.gameObject);
        }
    }

    public bool isColliding()
    {
        return touchingObjects.Count != 0;
    }
}
