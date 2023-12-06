using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps2 : MonoBehaviour
{
    public AudioSource footsteps;
    void Start()
    {
        footsteps = GetComponent<AudioSource>();
    }
    private void Awake()
    {
        if (gameObject == isActiveAndEnabled) 
        {
            footsteps.Play();
        }
    }
    void Update()
    {
    }
}
