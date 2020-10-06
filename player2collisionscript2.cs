using UnityEngine;

public class player2collisionscript2 : MonoBehaviour
{
    public int t = 0;
        void OnCollisionEnter (Collision collisionInfo)
    {
    if(collisionInfo.collider.tag=="enemy")
    {
        FindObjectOfType<GameManager>().End();
    }
    if(collisionInfo.collider.tag=="points")
    {
        t=t+1;
    }
    }   
}


