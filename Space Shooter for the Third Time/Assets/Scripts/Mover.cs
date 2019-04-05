using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed; 
    private Rigidbody Rb;

    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        Rb.velocity = transform.forward * speed;
    }

}
