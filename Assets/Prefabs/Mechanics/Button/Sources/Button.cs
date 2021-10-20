using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    S'active quand un joueur ou un cube est dessus.
*/
public class Button : Activator
{
    public PickablePlacementArea ppa;
    private bool is_activated = false;

    public void activate()
    {
        if(!is_activated)
        {
            is_activated = true;
            objectToActivate.activate();
        }
    }

    public void deactivate()
    {
        if(is_activated)
        {
            objectToActivate.deactivate();
            is_activated = false;
        }
    }

    void Update()
    {
        if(!ppa.canPlace())
        {
            activate();
        }
        else
        {
            deactivate();
        }
    }
}
