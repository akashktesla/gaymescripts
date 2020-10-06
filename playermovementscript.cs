
using UnityEngine;

public class playermovementscript : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    public float force = 100f;
    
    void FixedUpdate()
    {
        //add a frwd force
            if( Input.GetKey("a"))
        {
            if(player.position.z>3)
                {
                //move right
                
                    rb.AddForce(0,0,-force*Time.deltaTime,ForceMode.VelocityChange);
                }      
                else
                {
                //move left
                    rb.AddForce(0,0,force*Time.deltaTime,ForceMode.VelocityChange);
                
                }
        }    
    }

}
