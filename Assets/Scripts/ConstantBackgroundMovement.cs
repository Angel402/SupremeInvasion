using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantBackgroundMovement
{
    private float velocity = 2;

    public void MoveBackground(GameObject background)
    {
        var position = background.transform.position;
        position = new Vector3(position.x,(position.y-velocity*Time.deltaTime),0);
        background.transform.position = position;
    }

}
