using UnityEngine;

public class player2movementscript : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    
    public float sideforce = 500f;
    
    void FixedUpdate()
    {
        //add a frwd force
        
        if( Input.GetKey("l"))
        {
            if(player.position.z>-3)
                {
                rb.AddForce(0,0,-sideforce*Time.deltaTime,ForceMode.VelocityChange);
                }
                else
                {
                rb.AddForce(0,0,sideforce*Time.deltaTime,ForceMode.VelocityChange);
                }
        }    
    }

}

