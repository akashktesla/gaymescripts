using UnityEngine;
public class playercollision : MonoBehaviour
{
    public int s = 0;
    void OnCollisionEnter (Collision collisionInfo)
    {
    if(collisionInfo.collider.tag=="enemy")
    {
        FindObjectOfType<GameManager>().End();
    }
    if(collisionInfo.collider.tag=="points")
    {
        s=s+1;
    }
    }   
}
