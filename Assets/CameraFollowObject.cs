using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowObject : MonoBehaviour
{
    public Motor objectA;
    public Motor objectB;
    
    void FixedUpdate() 
    {
        this.transform.position = new Vector3(objectB.transform.position.x,this.transform.position.y,this.transform.position.z);
    }
}
