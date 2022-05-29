using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayJacketVoicelines : MonoBehaviour
{
    [Header("Voicelines")]
    [SerializeField] private AudioClipList[] maskingUpClips;
    [SerializeField] private AudioClipList[] callingCrewmatesClips;
    [SerializeField] private AudioClipList[] dominatingClips;
    [SerializeField] private AudioClipList[] completingAHeistClips;
    [SerializeField] private AudioClipList[] stealthClips;
    [SerializeField] private AudioClipList[] assaultWaveInboundClips;
    [SerializeField] private AudioClipList[] specialEnemiesClips;
    [SerializeField] private AudioClipList[] usingInspireSkillClips;
    [SerializeField] private AudioClipList[] pagerResponsesClips;
    [SerializeField] private AudioClipList[] deplopyablesClips;
    [SerializeField] private AudioClipList[] throwablesClips;
    [SerializeField] private AudioClipList[] hazardsClips;
    [SerializeField] private AudioClipList[] directionsClips;
    [SerializeField] private AudioClipList[] healthAndBleedoutClips;
    [SerializeField] private AudioClipList[] lowAmmunitionClips;
    [SerializeField] private AudioClipList[] objectivesClips;
    [SerializeField] private AudioClipList[] mapSpecificQuotesClips;
    [SerializeField] private AudioClipList[] cpuControlledClips;
    [SerializeField] private AudioClip[] otherClips; //Keep as normal Audioclip array (for now)

    [Header("Tape Scratch Clips")]
    [SerializeField] private AudioClip[] tapeScratchesClips;

    [Header("Audio Sources & Sequence")]
    [SerializeField] private AudioSource[] audioSources;
    [SerializeField] private AudioClip[] audioSequence = new AudioClip[3];
    
    #region Masking Up
    public void PlayMaskingUp(int val)
    {
        for (int i = 1; i < maskingUpClips.Length + 1; i++)
        {
            if (val == i) { MaskingUpFunction(val); }
        }
    }
    #endregion

    #region Calling Crewmates
    public void PlayCallingCrewmates(int val)
    {
        for (int i = 1; i < callingCrewmatesClips.Length + 1; i++)
        {
            if (val == i) { CallingCrewmatesFunction(val); }
        }
    }
    #endregion

    #region Dominating
    public void PlayDominating(int val)
    {
        for (int i = 1; i < dominatingClips.Length + 1; i++)
        {
            if (val == i) { DominatingFunction(val); }
        }
    }
    #endregion

    #region Completing A Heist
    public void PlayCompletingAHeist(int val)
    {
        for (int i = 1; i < completingAHeistClips.Length + 1; i++)
        {
            if (val == i) { CompletingAHeistFunction(val); }
        }
    }
    #endregion

    #region Stealth
    public void PlayStealth(int val)
    {
        for (int i = 1; i < stealthClips.Length + 1; i++)
        {
            if (val == i) { StealthFunction(val); }
        }
    }
    #endregion

    #region Assault Wave Inbound
    public void PlayAssaultWaveInbound(int val)
    {
        for (int i = 1; i < assaultWaveInboundClips.Length + 1; i++)
        {
            if (val == i) { AssaultWaveInboundFunction(val); }
        }
    }
    #endregion

    #region Special Enemies
    public void PlaySpecialEnemies(int val)
    {
        for (int i = 1; i < specialEnemiesClips.Length + 1; i++)
        {
            if (val == i) { SpecialEnemiesFunction(val); }
        }
    }
    #endregion

    #region Using Inspire Skill
    public void PlayUsingInspireSkill(int val)
    {
        for (int i = 1; i < usingInspireSkillClips.Length + 1; i++)
        {
            if (val == i) { UsingInspireSkillFunction(val); }
        }
    }
    #endregion

    #region Pager Responses
    public void PlayPagerResponses(int val)
    {
        for (int i = 1; i < pagerResponsesClips.Length + 1; i++)
        {
            if (val == i) { PagerResponsesFunction(val); }
        }
    }
    #endregion

    #region Deployables
    public void PlayDeployables(int val)
    {
        for (int i = 1; i < deplopyablesClips.Length + 1; i++)
        {
            if (val == i) { DeployablesFunction(val); }
        }
    }
    #endregion

    #region Throwables
    public void PlayThrowables(int val)
    {
        for (int i = 1; i < throwablesClips.Length + 1; i++)
        {
            if (val == i) { ThrowablesFunction(val); }
        }
    }
    #endregion

    #region Hazards
    public void PlayHazards(int val)
    {
        for (int i = 1; i < hazardsClips.Length + 1; i++)
        {
            if (val == i) { HazardsFunction(val); }
        }
    }
    #endregion

    #region Directions
    public void PlayDirections(int val)
    {
        for (int i = 1; i < directionsClips.Length + 1; i++)
        {
            if (val == i) { DirectionsFunction(val); }
        }
    }
    #endregion

    #region Health & Bleedout
    public void PlayHealthAndBleedout(int val)
    {
        for (int i = 1; i < healthAndBleedoutClips.Length + 1; i++)
        {
            if (val == i) { HealthandBleedoutFunction(val); }
        }
    }
    #endregion

    #region Low Ammunition
    public void PlayLowAmmunition(int val)
    {
        for (int i = 1; i < lowAmmunitionClips.Length + 1; i++)
        {
            if (val == i) { LowAmmunitionFunction(val); }
        }
    }
    #endregion

    #region Objectives
    public void PlayObjectives(int val)
    {
        for (int i = 1; i < objectivesClips.Length + 1; i++)
        {
            if (val == i) { ObjectivesFunction(val); }
        }
    }
    #endregion

    #region Map Specific Quotes
    public void PlayMapSpecificQuotes(int val)
    {
        for (int i = 1; i < mapSpecificQuotesClips.Length + 1; i++)
        {
            if (val == i) { MapSpecificQuotesFunction(val); }
        }
    }
    #endregion

    #region CPU Controlled Clips
    public void PlayCPUControlledClips(int val)
    {
        for (int i = 1; i < cpuControlledClips.Length + 1; i++)
        {
            if (val == i) { CPUControlledClipsFunction(val); }
        }
    }
    #endregion

    #region Other
    public void PlayOther(int val)
    {
        for (int i = 1; i < otherClips.Length + 1; i++)
        {
            if (val == i) { OtherFunction(val); }
        }
    }
    #endregion

    
    #region Logic for playing clips
    private void MaskingUpFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (maskingUpClips[clipNum - 1].audioclips[Random.Range(0, (maskingUpClips[clipNum - 1].audioclips).Length)]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void CallingCrewmatesFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (callingCrewmatesClips[clipNum - 1].audioclips[Random.Range(0, (callingCrewmatesClips[clipNum - 1].audioclips).Length)]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void DominatingFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (dominatingClips[clipNum - 1].audioclips[Random.Range(0, (dominatingClips[clipNum - 1].audioclips).Length)]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void CompletingAHeistFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (completingAHeistClips[clipNum - 1].audioclips[Random.Range(0, (completingAHeistClips[clipNum - 1].audioclips).Length)]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void StealthFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (stealthClips[clipNum - 1].audioclips[Random.Range(0, (stealthClips[clipNum - 1].audioclips).Length)]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);

    }

    private void AssaultWaveInboundFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (assaultWaveInboundClips[clipNum - 1].audioclips[Random.Range(0, (assaultWaveInboundClips[clipNum - 1].audioclips).Length)]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void SpecialEnemiesFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (specialEnemiesClips[clipNum - 1].audioclips[Random.Range(0, (specialEnemiesClips[clipNum - 1].audioclips).Length)]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void UsingInspireSkillFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (usingInspireSkillClips[clipNum - 1].audioclips[Random.Range(0, (usingInspireSkillClips[clipNum - 1].audioclips).Length)]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void PagerResponsesFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (pagerResponsesClips[clipNum - 1].audioclips[Random.Range(0, (pagerResponsesClips[clipNum - 1].audioclips).Length)]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void DeployablesFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (deplopyablesClips[clipNum - 1].audioclips[Random.Range(0, (deplopyablesClips[clipNum - 1].audioclips).Length)]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void ThrowablesFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (throwablesClips[clipNum - 1].audioclips[Random.Range(0, (throwablesClips[clipNum - 1].audioclips).Length)]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void HazardsFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (hazardsClips[clipNum - 1].audioclips[Random.Range(0, (hazardsClips[clipNum - 1].audioclips).Length)]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void DirectionsFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (directionsClips[clipNum - 1].audioclips[Random.Range(0, (directionsClips[clipNum - 1].audioclips).Length)]);        
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void HealthandBleedoutFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (healthAndBleedoutClips[clipNum - 1].audioclips[Random.Range(0, (healthAndBleedoutClips[clipNum - 1].audioclips).Length)]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void LowAmmunitionFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (lowAmmunitionClips[clipNum - 1].audioclips[Random.Range(0, (lowAmmunitionClips[clipNum - 1].audioclips).Length)]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void ObjectivesFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (objectivesClips[clipNum - 1].audioclips[Random.Range(0, (objectivesClips[clipNum - 1].audioclips).Length)]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void MapSpecificQuotesFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (mapSpecificQuotesClips[clipNum - 1].audioclips[Random.Range(0, (mapSpecificQuotesClips[clipNum - 1].audioclips).Length)]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void CPUControlledClipsFunction(int clipNum)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (cpuControlledClips[clipNum - 1].audioclips[Random.Range(0, (cpuControlledClips[clipNum - 1].audioclips).Length)]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void OtherFunction(int clipNum) //Keep as normal Audioclip array (for now)
    {
        audioSequence[0] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);
        audioSequence[1] = (otherClips[clipNum - 1]);
        audioSequence[2] = (tapeScratchesClips[Random.Range(0, tapeScratchesClips.Length)]);

        StartAudioSequencing(audioSequence[0], audioSequence[1], audioSequence[2]);
    }

    private void StartAudioSequencing(AudioClip clip1, AudioClip clip2, AudioClip clip3)
    {
        /*
        Audio Sequence:
            1. Play random tape scratch clip
            2. Play voiceline corresponding to selected dropdown
                2.1 Audioclip matrix: AudioClipList containing adjustable list of audioclips (row by column)
            3. Play random tape scratch clip
        */

        double startTime = AudioSettings.dspTime;

        //First tape scratch
        audioSources[0].clip = clip1;
        audioSources[0].PlayScheduled(startTime);

        //Voiceline
        double duration1 = (double)clip1.samples / clip1.frequency;
        audioSources[1].clip = clip2;
        audioSources[1].PlayScheduled(startTime + duration1);

        //Second tape scratch
        double duration2 = (double)clip2.samples / clip2.frequency;
        audioSources[2].clip = clip3;
        audioSources[2].PlayScheduled(startTime + duration1 + duration2);
    }
    #endregion
}