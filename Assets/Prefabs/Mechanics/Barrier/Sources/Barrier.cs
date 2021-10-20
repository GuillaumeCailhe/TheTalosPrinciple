using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Portails bleus qui peuvent être ouvert ou fermés.
*/
public class Barrier : Activatable
{   
    public void Start()
    {
        if(!isActivatedByDefault)
        {
            deactivate();
        }
    }

    public override void deactivate()
    {
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<BoxCollider>().enabled = true;
    }

    public override void activate()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
    }
}
