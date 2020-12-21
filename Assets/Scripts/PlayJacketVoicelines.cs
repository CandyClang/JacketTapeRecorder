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

    #region Masking Up - DONE
    public void PlayMaskingUp(int val)
    {
        if (val == 1)
        {
            #region
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
            #endregion
        }
        if (val == 2)
        {
            #region
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
            #endregion
        }
        if (val == 3)
        {
            #region
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
            #endregion
        }
        if (val == 4)
        {
            #region
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
            #endregion
        }
        if (val == 5)
        {
            #region
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
            #endregion
        }
    }
    #endregion

    #region Calling Crewmates
    public void PlayCallingCrewmates(int val)
    {
        if (val == 1)
        {
            #region
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
            #endregion
        }
        if (val == 2)
        {
            #region
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
            #endregion
        }
        if (val == 3)
        {
            #region
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
            #endregion
        }
        if (val == 4)
        {
            #region
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
            #endregion
        }
        if (val == 5)
        {
            #region
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
            #endregion
        }
    }
    #endregion

    #region Dominating - DONE
    public void PlayDominating(int val)
    {
        if (val == 1)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 2)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 3)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 4)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 5)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 6)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 7)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 8)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 9)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 10)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 11)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 12)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 13)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 14)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 15)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 16)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 17)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 18)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 19)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 20)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 21)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 22)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 23)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 24)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
        if (val == 25)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (dominatingClips[val - 1]);
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
            #endregion
        }
    }
    #endregion

    #region Completing A Heist - DONE
    public void PlayCompletingAHeist(int val)
    {
        if (val == 1)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 2)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 3)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 4)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 5)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 6)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 7)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 8)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 9)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 10)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 11)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 12)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 13)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 14)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 15)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 16)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 17)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 18)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 19)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
        if (val == 20)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (completingAHeistClips[val - 1]);
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
            #endregion
        }
    }
    #endregion

    #region Stealth - DONE
    public void PlayStealth(int val)
    {
        if (val == 1)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
        if (val == 2)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
        if (val == 3)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
        if (val == 4)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
        if (val == 5)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
        if (val == 6)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
        if (val == 7)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
        if (val == 8)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
        if (val == 9)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
        if (val == 10)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
        if (val == 11)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
        if (val == 12)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
        if (val == 13)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
        if (val == 14)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
        if (val == 15)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
        if (val == 16)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
        if (val == 17)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
        if (val == 18)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (stealthClips[val - 1]);
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
            #endregion
        }
    }
    #endregion

    #region Assault Wave Inbound - DONE
    public void PlayAssaultWaveInbound(int val)
    {
        if (val == 1)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 2)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 3)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 4)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 5)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 6)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 7)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 8)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 9)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 10)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 11)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 12)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 13)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 14)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 15)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 16)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 17)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 18)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 19)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 20)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
        if (val == 21)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (assaultWaveInboundClips[val - 1]);
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
            #endregion
        }
    }
    #endregion

    #region Special Enemies
    public void PlaySpecialEnemies(int val)
    {
        if (val == 1)
        {
            #region
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
            #endregion
        }
        if (val == 2)
        {
            #region
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
            #endregion
        }
        if (val == 3)
        {
            #region
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
            #endregion
        }
        if (val == 4)
        {
            #region
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
            #endregion
        }
        if (val == 5)
        {
            #region
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
            #endregion
        }
    }
    #endregion

    #region Using Inspire Skill - Done
    public void PlayUsingInspireSkill(int val)
    {
        if (val == 1)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (usingInspireSkillClips[val - 1]);
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
            #endregion
        }
        if (val == 2)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (usingInspireSkillClips[val - 1]);
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
            #endregion
        }
        if (val == 3)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (usingInspireSkillClips[val - 1]);
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
            #endregion
        }
        if (val == 4)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (usingInspireSkillClips[val - 1]);
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
            #endregion
        }
        if (val == 5)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (usingInspireSkillClips[val - 1]);
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
            #endregion
        }
        if (val == 6)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (usingInspireSkillClips[val - 1]);
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
            #endregion
        }
        if (val == 7)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (usingInspireSkillClips[val - 1]);
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
            #endregion
        }
        if (val == 8)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (usingInspireSkillClips[val - 1]);
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
            #endregion
        }
        if (val == 9)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (usingInspireSkillClips[val - 1]);
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
            #endregion
        }
        if (val == 10)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (usingInspireSkillClips[val - 1]);
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
            #endregion
        }
        if (val == 11)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (usingInspireSkillClips[val - 1]);
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
            #endregion
        }
        if (val == 12)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (usingInspireSkillClips[val - 1]);
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
            #endregion
        }
        if (val == 13)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (usingInspireSkillClips[val - 1]);
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
            #endregion
        }
        if (val == 14)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (usingInspireSkillClips[val - 1]);
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
            #endregion
        }
        if (val == 15)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (usingInspireSkillClips[val - 1]);
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
            #endregion
        }
        if (val == 16)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (usingInspireSkillClips[val - 1]);
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
            #endregion
        }
    }
    #endregion

    #region Pager Responses - DONE
    public void PlayPagerResponses(int val)
    {
        if (val == 1)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (pagerResponsesClips[val - 1]);
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
            #endregion
        }
        if (val == 2)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (pagerResponsesClips[val - 1]);
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
            #endregion
        }
        if (val == 3)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (pagerResponsesClips[val - 1]);
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
            #endregion
        }
        if (val == 4)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (pagerResponsesClips[val - 1]);
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
            #endregion
        }
        if (val == 5)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (pagerResponsesClips[val - 1]);
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
            #endregion
        }
        if (val == 6)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (pagerResponsesClips[val - 1]);
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
            #endregion
        }
        if (val == 7)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (pagerResponsesClips[val - 1]);
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
            #endregion
        }
    }
    #endregion

    #region Deployables - DONE
    public void PlayDeployables(int val)
    {
        if (val == 1)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (deplopyablesClips[val - 1]);
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
            #endregion
        }
        if (val == 2)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (deplopyablesClips[val - 1]);
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
            #endregion
        }
        if (val == 3)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (deplopyablesClips[val - 1]);
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
            #endregion
        }
        if (val == 4)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (deplopyablesClips[val - 1]);
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
            #endregion
        }
        if (val == 5)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (deplopyablesClips[val - 1]);
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
            #endregion
        }
        if (val == 6)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (deplopyablesClips[val - 1]);
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
            #endregion
        }
        if (val == 7)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (deplopyablesClips[val - 1]);
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
            #endregion
        }
        if (val == 8)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (deplopyablesClips[val - 1]);
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
            #endregion
        }
        if (val == 9)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (deplopyablesClips[val - 1]);
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
            #endregion
        }
        if (val == 10)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (deplopyablesClips[val - 1]);
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
            #endregion
        }
        if (val == 11)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (deplopyablesClips[val - 1]);
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
            #endregion
        }
        if (val == 12)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (deplopyablesClips[val - 1]);
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
            #endregion
        }
        if (val == 13)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (deplopyablesClips[val - 1]);
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
            #endregion
        }
        if (val == 14)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (deplopyablesClips[val - 1]);
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
            #endregion
        }
        if (val == 15)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (deplopyablesClips[val - 1]);
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
            #endregion
        }
    }
    #endregion

    #region Throwables - DONE
    public void PlayThrowables(int val)
    {
        if (val == 1)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (throwablesClips[val - 1]);
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
            #endregion
        }
        if (val == 2)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (throwablesClips[val - 1]);
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
            #endregion
        }
        if (val == 3)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (throwablesClips[val - 1]);
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
            #endregion
        }
        if (val == 4)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (throwablesClips[val - 1]);
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
            #endregion
        }
        if (val == 5)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (throwablesClips[val - 1]);
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
            #endregion
        }
        if (val == 6)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (throwablesClips[val - 1]);
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
            #endregion
        }
        if (val == 7)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (throwablesClips[val - 1]);
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
            #endregion
        }
        if (val == 8)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (throwablesClips[val - 1]);
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
            #endregion
        }
        if (val == 9)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (throwablesClips[val - 1]);
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
            #endregion
        }
        if (val == 10)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (throwablesClips[val - 1]);
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
            #endregion
        }
    }
    #endregion

    #region Tear Gas - DONE
    public void PlayTearGas(int val)
    {
        if (val == 1)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (tearGasClips[val - 1]);
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
            #endregion
        }
        if (val == 2)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (tearGasClips[val - 1]);
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
            #endregion
        }
        if (val == 3)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (tearGasClips[val - 1]);
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
            #endregion
        }
        if (val == 4)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (tearGasClips[val - 1]);
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
            #endregion
        }
    }
    #endregion

    #region Flashbangs - DONE
    public void PlayFlashbangs(int val)
    {
        if (val == 1)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (flashbangsClips[val - 1]);
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
            #endregion
        }
        if (val == 2)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (flashbangsClips[val - 1]);
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
            #endregion
        }
        if (val == 3)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (flashbangsClips[val - 1]);
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
            #endregion
        }
        if (val == 4)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (flashbangsClips[val - 1]);
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
            #endregion
        }
    }
    #endregion

    #region Smoke Grenade - DONE
    public void PlaySmokeGrenade(int val)
    {
        if (val == 1)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (smokeGrenadeClips[val - 1]);
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
            #endregion
        }
        if (val == 2)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (smokeGrenadeClips[val - 1]);
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
            #endregion
        }
        if (val == 3)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (smokeGrenadeClips[val - 1]);
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
            #endregion
        }
        if (val == 4)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (smokeGrenadeClips[val - 1]);
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
            #endregion
        }
        if (val == 5)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (smokeGrenadeClips[val - 1]);
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
            #endregion
        }
        if (val == 6)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (smokeGrenadeClips[val - 1]);
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
            #endregion
        }
    }
    #endregion

    #region Directions
    public void PlayDirections(int val)
    {
        if (val == 1)
        {
            #region
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
            #endregion
        }
        if (val == 2)
        {
            #region
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
            #endregion
        }
        if (val == 3)
        {
            #region
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
            #endregion
        }
        if (val == 4)
        {
            #region
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
            #endregion
        }
        if (val == 5)
        {
            #region
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
            #endregion
        }
    }
    #endregion

    #region Health & Bleedout - DONE
    public void PlayHealthAndBleedout(int val)
    {
        if (val == 1)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 2)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 3)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 4)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 5)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 6)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 7)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 8)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 9)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 10)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 11)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 12)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 13)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 14)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 15)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 16)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 17)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 18)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 19)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 20)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 21)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 22)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 23)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 24)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 25)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 26)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 27)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 28)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 29)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 30)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 31)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 32)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
        if (val == 33)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (healthAndBleedoutClips[val - 1]);
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
            #endregion
        }
    }
    #endregion

    #region Low Ammunition - DONE
    public void PlayLowAmmunition(int val)
    {
        if (val == 1)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (lowAmmunitionClips[val - 1]);
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
            #endregion
        }
        if (val == 2)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (lowAmmunitionClips[val - 1]);
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
            #endregion
        }
        if (val == 3)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (lowAmmunitionClips[val - 1]);
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
            #endregion
        }
        if (val == 4)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (lowAmmunitionClips[val - 1]);
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
            #endregion
        }
        if (val == 5)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (lowAmmunitionClips[val - 1]);
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
            #endregion
        }
        if (val == 6)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (lowAmmunitionClips[val - 1]);
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
            #endregion
        }
        if (val == 7)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (lowAmmunitionClips[val - 1]);
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
            #endregion
        }
        if (val == 8)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (lowAmmunitionClips[val - 1]);
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
            #endregion
        }
        if (val == 9)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (lowAmmunitionClips[val - 1]);
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
            #endregion
        }
        if (val == 10)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (lowAmmunitionClips[val - 1]);
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
            #endregion
        }
        if (val == 11)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (lowAmmunitionClips[val - 1]);
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
            #endregion
        }
        if (val == 12)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (lowAmmunitionClips[val - 1]);
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
            #endregion
        }
    }
    #endregion

    #region Objectives - DONE
    public void PlayObjectives(int val)
    {
        if (val == 1)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 2)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 3)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 4)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 5)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 6)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 7)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 8)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 9)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 10)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 11)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 12)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 13)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 14)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 15)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 16)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 17)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 18)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 19)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
        if (val == 20)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (objectivesClips[val - 1]);
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
            #endregion
        }
    }
    #endregion

    #region Map Specific Quotes
    public void PlayMapSpecificQuotes(int val)
    {
        if (val == 1)
        {
            #region
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
            #endregion
        }
        if (val == 2)
        {
            #region
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
            #endregion
        }
        if (val == 3)
        {
            #region
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
            #endregion
        }
        if (val == 4)
        {
            #region
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
            #endregion
        }
        if (val == 5)
        {
            #region
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
            #endregion
        }
    }
    #endregion

    #region CPU Controlled Clips
    public void PlayCPUControlledClips(int val)
    {
        if (val == 1)
        {
            #region
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
            #endregion
        }
        if (val == 2)
        {
            #region
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
            #endregion
        }
        if (val == 3)
        {
            #region
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
            #endregion
        }
        if (val == 4)
        {
            #region
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
            #endregion
        }
        if (val == 5)
        {
            #region
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
            #endregion
        }
    }
    #endregion

    #region Other - DONE
    public void PlayOther(int val)
    {
        if (val == 1)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 2)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 3)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 4)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 5)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 6)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 7)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 8)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 9)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 10)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 11)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 12)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 13)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 14)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 15)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 16)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 17)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 18)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 19)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 20)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 21)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 22)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 23)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 24)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 25)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 26)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 27)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 28)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 29)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 30)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 31)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 32)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 33)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 34)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 35)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 36)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
        if (val == 37)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (otherClips[val - 1]);
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
            #endregion
        }
    }
    #endregion
}
