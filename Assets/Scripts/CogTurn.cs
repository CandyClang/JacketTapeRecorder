using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogTurn : MonoBehaviour
{
    public AudioSource audioSource1, audioSource2, audioSource3;

    // Update is called once per frame
    void Update()
    {
        if (audioSource1.isPlaying || audioSource2.isPlaying || audioSource3.isPlaying)
        {
            transform.Rotate(new Vector3(0f, 0f, 100f) * Time.deltaTime);
        }
    }
}
