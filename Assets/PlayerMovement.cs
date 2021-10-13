using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //reference to rigidbody
    Rigidbody rb;

    [Tooltip("Speed multiplier for Horizontal and Vertical Movement")]
    [Range(5,50)]
    public float speed = 10;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    //create functionality for movement
    public void MoveHorizontal(float force)
    {
        rb.AddForce(force * speed,0,0);
    }
    public void MoveVertical(float force)
    {
        rb.AddForce(0,0,force * speed);
    }
}
