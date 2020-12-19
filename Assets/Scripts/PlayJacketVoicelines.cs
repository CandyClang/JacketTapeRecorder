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

    #region Masking Up
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

    #region Dominating
    public void PlayDominating(int val)
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

    #region Completing A Heist
    public void PlayCompletingAHeist(int val)
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

    #region Stealth
    public void PlayStealth(int val)
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

    #region Assault Wave Inbound
    public void PlayAssaultWaveInbound(int val)
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

    #region Using Inspire Skill
    public void PlayUsingInspireSkill(int val)
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

    #region Pager Responses
    public void PlayPagerResponses(int val)
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

    #region Deployables
    public void PlayDeployables(int val)
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

    #region Throwables
    public void PlayThrowables(int val)
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

    #region Tear Gas
    public void PlayTearGas(int val)
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

    #region Flashbangs
    public void PlayFlashbangs(int val)
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

    #region Smoke Grenade
    public void PlaySmokeGrenade(int val)
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

    #region Health & Bleedout
    public void PlayHealthAndBleedout(int val)
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

    #region Low Ammunition
    public void PlayLowAmmunition(int val)
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

    #region Objectives
    public void PlayObjectives(int val)
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

    #region Other
    public void PlayOther(int val)
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
}
