using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioSequence : MonoBehaviour
{
    private PlayJacketVoicelines jvlScript;

    [SerializeField] private AudioSource[] audioSources;

    private void Awake()
    {
        GameObject audioManager = GameObject.FindGameObjectWithTag("AudioManager");
        jvlScript = audioManager.GetComponent<PlayJacketVoicelines>();
    }
    
    public void PlaySequence()
    {
        double duration1 = jvlScript.duration1;
        double duration2 = jvlScript.duration2;

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].PlayScheduled(startTime);

        //Voiceline
        audioSources[1].PlayScheduled(startTime + duration1);

        //Second tape scratch
        audioSources[2].PlayScheduled(startTime + duration1 + duration2);
    }
}
