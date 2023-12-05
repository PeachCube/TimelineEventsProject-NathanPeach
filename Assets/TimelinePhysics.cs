using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelinePhysics : MonoBehaviour
{
    public PlayableDirector timeline;
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        timeline.Play();
    }
}
