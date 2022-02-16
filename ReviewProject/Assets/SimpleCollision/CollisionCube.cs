using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCube : CollisionEvents
{
    public override void OnCollisionEnter()
    {
        base.OnCollisionEnter();
        Debug.LogError("OnCollisionEnter");
    }

    public override void OnColllisionStay()
    {
        base.OnColllisionStay();
        Debug.LogError("OnColllisionStay");
    }

    public override void OnCollisionExit()
    {
        base.OnCollisionExit();
        Debug.LogError("OnCollisionExit");
    }
}
