using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayJacketVoicelines : MonoBehaviour
{
    public AudioClip[] tapeScratchesClips;
    public AudioClip[] maskingUpClips;
    public AudioClip[] callingCrewmatesClips;
    public AudioClip[] dominatingClips;
    public AudioClip[] completingAHeistClips;
    public AudioClip[] stealthClips;
    public AudioClip[] assaultWaveInboundClips;
    public AudioClip[] specialEnemiesClips;
    public AudioClip[] usingInspireSkillClips;
    public AudioClip[] pagerResponsesClips;
    public AudioClip[] deplopyablesClips;
    public AudioClip[] throwablesClips;
    public AudioClip[] tearGasClips;
    public AudioClip[] flashbangsClips;
    public AudioClip[] smokeGrenadeClips;
    public AudioClip[] directionsClips;
    public AudioClip[] healthAndBleedoutClips;
    public AudioClip[] lowAmmunitionClips;
    public AudioClip[] objectivesClips;
    public AudioClip[] mapSpecificQuotesClips;
    public AudioClip[] cpuControlledClips;
    public AudioClip[] otherClips;

    public AudioSource[] audioSources;

    private AudioClip[] audioSequence = new AudioClip[3];

    public void PlayMaskingUp(int val)
    {
        #region
        if (val == 1)
        {
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (maskingUpClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
        }
        #endregion
        #region
        if (val == 2)
        {
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (maskingUpClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
        }
        #endregion
    }
}
