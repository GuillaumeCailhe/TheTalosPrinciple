using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Cette classe abstraite est la classe mère à tous les objets qui peuvent être activés ou désactivés.
    Par exemple les portes et les mines
*/
public abstract class Activatable:MonoBehaviour
{
    public bool isActivatedByDefault = true;

    public abstract void activate();
    public abstract void deactivate();
}
