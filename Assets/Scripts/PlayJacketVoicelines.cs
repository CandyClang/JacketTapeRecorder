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
        if (val == 1) { MaskingUpFunction(val); }
        if (val == 2) { MaskingUpFunction(val); }
        if (val == 3) { MaskingUpFunction(val); }
        if (val == 4) { MaskingUpFunction(val); }
        if (val == 5) { MaskingUpFunction(val); }
    }
    #endregion

    #region Calling Crewmates
    public void PlayCallingCrewmates(int val)
    {
        if (val == 1) { CallingCrewmatesFunction(val); }
        if (val == 2) { CallingCrewmatesFunction(val); }
        if (val == 3) { CallingCrewmatesFunction(val); }
        if (val == 4) { CallingCrewmatesFunction(val); }
        if (val == 5) { CallingCrewmatesFunction(val); }
        if (val == 6) { CallingCrewmatesFunction(val); }
        if (val == 7) { CallingCrewmatesFunction(val); }
        if (val == 8) { CallingCrewmatesFunction(val); }
        if (val == 9) { CallingCrewmatesFunction(val); }
        if (val == 10) { CallingCrewmatesFunction(val); }
        if (val == 11) { CallingCrewmatesFunction(val); }
        if (val == 12) { CallingCrewmatesFunction(val); }
        if (val == 13) { CallingCrewmatesFunction(val); }
        if (val == 14) { CallingCrewmatesFunction(val); }
        if (val == 15) { CallingCrewmatesFunction(val); }
        if (val == 16) { CallingCrewmatesFunction(val); }
        if (val == 17) { CallingCrewmatesFunction(val); }
        if (val == 18) { CallingCrewmatesFunction(val); }
        if (val == 19) { CallingCrewmatesFunction(val); }
        if (val == 20) { CallingCrewmatesFunction(val); }
        if (val == 21) { CallingCrewmatesFunction(val); }
        if (val == 22) { CallingCrewmatesFunction(val); }
        if (val == 23) { CallingCrewmatesFunction(val); }
        if (val == 24) { CallingCrewmatesFunction(val); }
        if (val == 25) { CallingCrewmatesFunction(val); }
        if (val == 26) { CallingCrewmatesFunction(val); }
        if (val == 27) { CallingCrewmatesFunction(val); }
        if (val == 28) { CallingCrewmatesFunction(val); }
        if (val == 29) { CallingCrewmatesFunction(val); }
        if (val == 30) { CallingCrewmatesFunction(val); }
        if (val == 31) { CallingCrewmatesFunction(val); }
        if (val == 32) { CallingCrewmatesFunction(val); }
        if (val == 33) { CallingCrewmatesFunction(val); }
        if (val == 34) { CallingCrewmatesFunction(val); }
        if (val == 35) { CallingCrewmatesFunction(val); }
        if (val == 36) { CallingCrewmatesFunction(val); }
        if (val == 37) { CallingCrewmatesFunction(val); }
        if (val == 38) { CallingCrewmatesFunction(val); }
        if (val == 39) { CallingCrewmatesFunction(val); }
        if (val == 40) { CallingCrewmatesFunction(val); }
        if (val == 41) { CallingCrewmatesFunction(val); }
        if (val == 42) { CallingCrewmatesFunction(val); }
        if (val == 43) { CallingCrewmatesFunction(val); }
        if (val == 44) { CallingCrewmatesFunction(val); }
        if (val == 45) { CallingCrewmatesFunction(val); }
        if (val == 46) { CallingCrewmatesFunction(val); }
        if (val == 47) { CallingCrewmatesFunction(val); }
        if (val == 48) { CallingCrewmatesFunction(val); }
        if (val == 49) { CallingCrewmatesFunction(val); }
        if (val == 50) { CallingCrewmatesFunction(val); }
        if (val == 51) { CallingCrewmatesFunction(val); }
        if (val == 52) { CallingCrewmatesFunction(val); }
        if (val == 53) { CallingCrewmatesFunction(val); }
        if (val == 54) { CallingCrewmatesFunction(val); }
        if (val == 55) { CallingCrewmatesFunction(val); }
        if (val == 56) { CallingCrewmatesFunction(val); }
        if (val == 57) { CallingCrewmatesFunction(val); }
        if (val == 58) { CallingCrewmatesFunction(val); }
        if (val == 59) { CallingCrewmatesFunction(val); }
        if (val == 60) { CallingCrewmatesFunction(val); }
        if (val == 61) { CallingCrewmatesFunction(val); }
        if (val == 62) { CallingCrewmatesFunction(val); }
        if (val == 63) { CallingCrewmatesFunction(val); }
        if (val == 64) { CallingCrewmatesFunction(val); }
        if (val == 65) { CallingCrewmatesFunction(val); }
        if (val == 66) { CallingCrewmatesFunction(val); }
        if (val == 67) { CallingCrewmatesFunction(val); }
        if (val == 68) { CallingCrewmatesFunction(val); }
        if (val == 69) { CallingCrewmatesFunction(val); }
        if (val == 70) { CallingCrewmatesFunction(val); }
        if (val == 71) { CallingCrewmatesFunction(val); }
        if (val == 72) { CallingCrewmatesFunction(val); }
        if (val == 73) { CallingCrewmatesFunction(val); }
        if (val == 74) { CallingCrewmatesFunction(val); }
        if (val == 75) { CallingCrewmatesFunction(val); }
        if (val == 76) { CallingCrewmatesFunction(val); }
        if (val == 77) { CallingCrewmatesFunction(val); }
        if (val == 78) { CallingCrewmatesFunction(val); }
        if (val == 79) { CallingCrewmatesFunction(val); }
        if (val == 80) { CallingCrewmatesFunction(val); }
        if (val == 81) { CallingCrewmatesFunction(val); }
        if (val == 82) { CallingCrewmatesFunction(val); }
        if (val == 83) { CallingCrewmatesFunction(val); }
        if (val == 84) { CallingCrewmatesFunction(val); }
        if (val == 85) { CallingCrewmatesFunction(val); }
        if (val == 86) { CallingCrewmatesFunction(val); }
        if (val == 87) { CallingCrewmatesFunction(val); }
        if (val == 88) { CallingCrewmatesFunction(val); }
        if (val == 89) { CallingCrewmatesFunction(val); }
        if (val == 90) { CallingCrewmatesFunction(val); }
        if (val == 91) { CallingCrewmatesFunction(val); }
        if (val == 92) { CallingCrewmatesFunction(val); }
        if (val == 93) { CallingCrewmatesFunction(val); }
        if (val == 94) { CallingCrewmatesFunction(val); }
    }
    #endregion

    #region Dominating
    public void PlayDominating(int val)
    {
        if (val == 1) { DominatingFunction(val); }
        if (val == 2) { DominatingFunction(val); }
        if (val == 3) { DominatingFunction(val); }
        if (val == 4) { DominatingFunction(val); }
        if (val == 5) { DominatingFunction(val); }
        if (val == 6) { DominatingFunction(val); }
        if (val == 7) { DominatingFunction(val); }
        if (val == 8) { DominatingFunction(val); }
        if (val == 9) { DominatingFunction(val); }
        if (val == 10) { DominatingFunction(val); }
        if (val == 11) { DominatingFunction(val); }
        if (val == 12) { DominatingFunction(val); }
        if (val == 13) { DominatingFunction(val); }
        if (val == 14) { DominatingFunction(val); }
        if (val == 15) { DominatingFunction(val); }
        if (val == 16) { DominatingFunction(val); }
        if (val == 17) { DominatingFunction(val); }
        if (val == 18) { DominatingFunction(val); }
        if (val == 19) { DominatingFunction(val); }
        if (val == 20) { DominatingFunction(val); }
        if (val == 21) { DominatingFunction(val); }
        if (val == 22) { DominatingFunction(val); }
        if (val == 23) { DominatingFunction(val); }
        if (val == 24) { DominatingFunction(val); }
        if (val == 25) { DominatingFunction(val); }
    }
    #endregion

    #region Completing A Heist
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

    #region Stealth
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

    #region Assault Wave Inbound
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 38)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 39)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 40)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 41)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 42)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 43)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 44)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 45)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 46)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 47)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 48)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 49)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 50)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 51)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 52)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 53)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 54)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 55)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 56)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 57)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 58)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 59)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 60)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 61)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 62)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 63)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 64)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 65)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 66)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 67)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 68)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 69)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 70)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 71)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 72)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 73)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 74)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 75)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 76)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 77)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 78)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 79)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 80)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 81)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 82)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (specialEnemiesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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

    #region Pager Responses
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

    #region Deployables
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

    #region Throwables
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

    #region Tear Gas
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

    #region Flashbangs
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

    #region Smoke Grenade
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 38)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 39)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 40)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 41)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 42)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 43)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 44)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 45)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 46)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 47)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 48)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 49)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 50)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 51)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 52)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 53)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 54)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 55)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 56)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 57)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 58)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 59)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 60)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 61)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (directionsClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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

    #region Low Ammunition
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

    #region Objectives
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 38)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 39)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 40)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 41)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 42)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 43)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 44)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 45)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 46)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 47)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 48)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 49)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 50)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 51)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 52)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 53)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 54)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 55)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 56)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 57)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 58)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 59)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 60)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 61)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 62)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 63)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 64)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 65)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 66)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 67)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 68)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 69)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 70)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 71)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 72)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 73)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 74)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 75)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 76)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 77)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 78)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 79)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 80)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 81)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 82)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 83)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 84)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 85)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 86)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 87)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 88)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 89)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 90)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 91)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 92)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 93)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 94)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 95)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 96)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 97)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 98)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 99)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 100)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 101)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 102)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 103)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 104)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 105)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 106)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 107)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 108)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 109)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val ==110)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 111)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 112)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (mapSpecificQuotesClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 38)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 39)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 40)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 41)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 42)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 43)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 44)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 45)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 46)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
            double duration1 = (double)audioSequence[0].samples / audioSequence[0].frequency;
            audioSources[1].clip = audioSequence[1];
            audioSources[1].PlayScheduled(startTime + duration1);

            //Second tape scratch
            double duration2 = (double)audioSequence[1].samples / audioSequence[1].frequency;
            audioSources[2].clip = audioSequence[2];
            audioSources[2].PlayScheduled(startTime + duration1 + duration2);
            #endregion
        }
        if (val == 47)
        {
            #region
            audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
            audioSequence[1] = (cpuControlledClips[val - 1]);
            audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

            double startTime = AudioSettings.dspTime;

            //First tape scratch
            audioSources[0].clip = audioSequence[0];
            audioSources[0].PlayScheduled(startTime);

            //Voiceline
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


    #region Logic for playing clips
    private void MaskingUpFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (maskingUpClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void CallingCrewmatesFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (callingCrewmatesClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void DominatingFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (dominatingClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void CompletingAHeistFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (completingAHeistClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void StealthFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (stealthClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void AssaultWaveInboundFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (assaultWaveInboundClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void SpecialEnemiesFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (specialEnemiesClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void UsingInspireSkillFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (usingInspireSkillClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void PagerResponsesFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (pagerResponsesClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void DeployablesFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (deplopyablesClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void ThrowablesFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (throwablesClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void TearGasFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (tearGasClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void FlashbangsFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (flashbangsClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void SmokeGrenadeFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (smokeGrenadeClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void DirectionsFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (directionsClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void HealthandBleedoutFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (healthAndBleedoutClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void LowAmmunitionFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (lowAmmunitionClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void ObjectivesFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (objectivesClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void MapSpecificQuotesFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (mapSpecificQuotesClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void CPUControlledClipsFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (cpuControlledClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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

    private void OtherFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (otherClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = audioSequence[0];
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
