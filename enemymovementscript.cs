using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovementscript : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody rb;
    public Vector3 screenBounds;

    // Update is called once per frame
    void FixedUpdate () {
        rb.AddForce(-speed*Time.deltaTime,0,0,ForceMode.VelocityChange);
        if(transform.position.x < screenBounds.x ){
            Destroy(this.gameObject);
        }
}
}