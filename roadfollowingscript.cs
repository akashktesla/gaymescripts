using UnityEngine;

public class roadfollowingscript : MonoBehaviour
{
    public Transform road;
    public Vector3 offset;
    // Update is called once per frame
    void FixedUpdate()
    {
        road.position = transform.position + offset;
    }
}
