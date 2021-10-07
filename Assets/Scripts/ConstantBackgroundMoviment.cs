using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantBackgroundMoviment
{
    
    public void MoveBackground(GameObject backgroundGO, float velocidad)
    {
        var position = backgroundGO.transform.position;
        position = new Vector3(position.x,(position.y-velocidad*Time.deltaTime),0);
        backgroundGO.transform.position = position;
        
    }
    
    
    
}
