using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    public float tumble;

    private Rigidbody Rb;

    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
        Rb.angularVelocity = Random.insideUnitSphere * tumble;
    }

}
