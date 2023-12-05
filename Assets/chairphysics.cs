using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chairphysics : MonoBehaviour
{
    Rigidbody rb;
    AudioSource hit;
    void Start()
    {
        hit = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(3,1,-10),ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        hit.Play();
    }
}
