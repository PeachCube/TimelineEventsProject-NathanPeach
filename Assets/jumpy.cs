using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpy : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Jumpscare());
    }
    IEnumerator Jumpscare()
    {
        yield return new WaitForSecondsRealtime(0.125f);
        gameObject.SetActive(false);
    }

    void Update()
    {
        
    }
}
