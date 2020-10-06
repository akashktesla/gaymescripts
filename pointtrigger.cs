using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointtrigger : MonoBehaviour
{
    
    // Update is called once per frame
    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag=="points")
    {
        FindObjectOfType<GameManager>().End();
    }
    }
}
