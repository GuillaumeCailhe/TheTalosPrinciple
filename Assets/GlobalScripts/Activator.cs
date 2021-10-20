using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Cette classe est héritée par tous les objets qui en activent d'autres comme les boutons
*/
public abstract class Activator:MonoBehaviour
{
    public Activatable objectToActivate;
}

