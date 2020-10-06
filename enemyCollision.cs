
using UnityEngine;

public class enemyCollision : MonoBehaviour
{
void OnCollisionEnter (Collision collisionInfo)
{
    if(collisionInfo.collider.tag=="enemy")
    {
        Destroy(this.gameObject);
    }
    if(collisionInfo.collider.tag=="points")
    {
        Destroy(this.gameObject);
    }
    if(collisionInfo.collider.tag=="Player")
    {
        Destroy(this.gameObject);
    }
    

}}


