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
        if (val == 1) { CompletingAHeistFunction(val); }
        if (val == 2) { CompletingAHeistFunction(val); }
        if (val == 3) { CompletingAHeistFunction(val); }
        if (val == 4) { CompletingAHeistFunction(val); }
        if (val == 5) { CompletingAHeistFunction(val); }
        if (val == 6) { CompletingAHeistFunction(val); }
        if (val == 7) { CompletingAHeistFunction(val); }
        if (val == 8) { CompletingAHeistFunction(val); }
        if (val == 9) { CompletingAHeistFunction(val); }
        if (val == 10) { CompletingAHeistFunction(val); }
        if (val == 11) { CompletingAHeistFunction(val); }
        if (val == 12) { CompletingAHeistFunction(val); }
        if (val == 13) { CompletingAHeistFunction(val); }
        if (val == 14) { CompletingAHeistFunction(val); }
        if (val == 15) { CompletingAHeistFunction(val); }
        if (val == 16) { CompletingAHeistFunction(val); }
        if (val == 17) { CompletingAHeistFunction(val); }
        if (val == 18) { CompletingAHeistFunction(val); }
        if (val == 19) { CompletingAHeistFunction(val); }
        if (val == 20) { CompletingAHeistFunction(val); }
    }
    #endregion

    #region Stealth
    public void PlayStealth(int val)
    {
        if (val == 1) { StealthFunction(val); }
        if (val == 2) { StealthFunction(val); }
        if (val == 3) { StealthFunction(val); }
        if (val == 4) { StealthFunction(val); }
        if (val == 5) { StealthFunction(val); }
        if (val == 6) { StealthFunction(val); }
        if (val == 7) { StealthFunction(val); }
        if (val == 8) { StealthFunction(val); }
        if (val == 9) { StealthFunction(val); }
        if (val == 10) { StealthFunction(val); }
        if (val == 11) { StealthFunction(val); }
        if (val == 12) { StealthFunction(val); }
        if (val == 13) { StealthFunction(val); }
        if (val == 14) { StealthFunction(val); }
        if (val == 15) { StealthFunction(val); }
        if (val == 16) { StealthFunction(val); }
        if (val == 17) { StealthFunction(val); }
        if (val == 18) { StealthFunction(val); }
    }
    #endregion

    #region Assault Wave Inbound
    public void PlayAssaultWaveInbound(int val)
    {
        if (val == 1) { AssaultWaveInboundFunction(val); }
        if (val == 2) { AssaultWaveInboundFunction(val); }
        if (val == 3) { AssaultWaveInboundFunction(val); }
        if (val == 4) { AssaultWaveInboundFunction(val); }
        if (val == 5) { AssaultWaveInboundFunction(val); }
        if (val == 6) { AssaultWaveInboundFunction(val); }
        if (val == 7) { AssaultWaveInboundFunction(val); }
        if (val == 8) { AssaultWaveInboundFunction(val); }
        if (val == 9) { AssaultWaveInboundFunction(val); }
        if (val == 10) { AssaultWaveInboundFunction(val); }
        if (val == 11) { AssaultWaveInboundFunction(val); }
        if (val == 12) { AssaultWaveInboundFunction(val); }
        if (val == 13) { AssaultWaveInboundFunction(val); }
        if (val == 14) { AssaultWaveInboundFunction(val); }
        if (val == 15) { AssaultWaveInboundFunction(val); }
        if (val == 16) { AssaultWaveInboundFunction(val); }
        if (val == 17) { AssaultWaveInboundFunction(val); }
        if (val == 18) { AssaultWaveInboundFunction(val); }
        if (val == 19) { AssaultWaveInboundFunction(val); }
        if (val == 20) { AssaultWaveInboundFunction(val); }
        if (val == 21) { AssaultWaveInboundFunction(val); }
    }
    #endregion

    #region Special Enemies
    public void PlaySpecialEnemies(int val)
    {
        if (val == 1) { SpecialEnemiesFunction(val); }
        if (val == 2) { SpecialEnemiesFunction(val); }
        if (val == 3) { SpecialEnemiesFunction(val); }
        if (val == 4) { SpecialEnemiesFunction(val); }
        if (val == 5) { SpecialEnemiesFunction(val); }
        if (val == 6) { SpecialEnemiesFunction(val); }
        if (val == 7) { SpecialEnemiesFunction(val); }
        if (val == 8) { SpecialEnemiesFunction(val); }
        if (val == 9) { SpecialEnemiesFunction(val); }
        if (val == 10) { SpecialEnemiesFunction(val); }
        if (val == 11) { SpecialEnemiesFunction(val); }
        if (val == 12) { SpecialEnemiesFunction(val); }
        if (val == 13) { SpecialEnemiesFunction(val); }
        if (val == 14) { SpecialEnemiesFunction(val); }
        if (val == 15) { SpecialEnemiesFunction(val); }
        if (val == 16) { SpecialEnemiesFunction(val); }
        if (val == 17) { SpecialEnemiesFunction(val); }
        if (val == 18) { SpecialEnemiesFunction(val); }
        if (val == 19) { SpecialEnemiesFunction(val); }
        if (val == 20) { SpecialEnemiesFunction(val); }
        if (val == 21) { SpecialEnemiesFunction(val); }
        if (val == 22) { SpecialEnemiesFunction(val); }
        if (val == 23) { SpecialEnemiesFunction(val); }
        if (val == 24) { SpecialEnemiesFunction(val); }
        if (val == 25) { SpecialEnemiesFunction(val); }
        if (val == 26) { SpecialEnemiesFunction(val); }
        if (val == 27) { SpecialEnemiesFunction(val); }
        if (val == 28) { SpecialEnemiesFunction(val); }
        if (val == 29) { SpecialEnemiesFunction(val); }
        if (val == 30) { SpecialEnemiesFunction(val); }
        if (val == 31) { SpecialEnemiesFunction(val); }
        if (val == 32) { SpecialEnemiesFunction(val); }
        if (val == 33) { SpecialEnemiesFunction(val); }
        if (val == 34) { SpecialEnemiesFunction(val); }
        if (val == 35) { SpecialEnemiesFunction(val); }
        if (val == 36) { SpecialEnemiesFunction(val); }
        if (val == 37) { SpecialEnemiesFunction(val); }
        if (val == 38) { SpecialEnemiesFunction(val); }
        if (val == 39) { SpecialEnemiesFunction(val); }
        if (val == 40) { SpecialEnemiesFunction(val); }
        if (val == 41) { SpecialEnemiesFunction(val); }
        if (val == 42) { SpecialEnemiesFunction(val); }
        if (val == 43) { SpecialEnemiesFunction(val); }
        if (val == 44) { SpecialEnemiesFunction(val); }
        if (val == 45) { SpecialEnemiesFunction(val); }
        if (val == 46) { SpecialEnemiesFunction(val); }
        if (val == 47) { SpecialEnemiesFunction(val); }
        if (val == 48) { SpecialEnemiesFunction(val); }
        if (val == 49) { SpecialEnemiesFunction(val); }
        if (val == 50) { SpecialEnemiesFunction(val); }
        if (val == 51) { SpecialEnemiesFunction(val); }
        if (val == 52) { SpecialEnemiesFunction(val); }
        if (val == 53) { SpecialEnemiesFunction(val); }
        if (val == 54) { SpecialEnemiesFunction(val); }
        if (val == 55) { SpecialEnemiesFunction(val); }
        if (val == 56) { SpecialEnemiesFunction(val); }
        if (val == 57) { SpecialEnemiesFunction(val); }
        if (val == 58) { SpecialEnemiesFunction(val); }
        if (val == 59) { SpecialEnemiesFunction(val); }
        if (val == 60) { SpecialEnemiesFunction(val); }
        if (val == 61) { SpecialEnemiesFunction(val); }
        if (val == 62) { SpecialEnemiesFunction(val); }
        if (val == 63) { SpecialEnemiesFunction(val); }
        if (val == 64) { SpecialEnemiesFunction(val); }
        if (val == 65) { SpecialEnemiesFunction(val); }
        if (val == 66) { SpecialEnemiesFunction(val); }
        if (val == 67) { SpecialEnemiesFunction(val); }
        if (val == 68) { SpecialEnemiesFunction(val); }
        if (val == 69) { SpecialEnemiesFunction(val); }
        if (val == 70) { SpecialEnemiesFunction(val); }
        if (val == 71) { SpecialEnemiesFunction(val); }
        if (val == 72) { SpecialEnemiesFunction(val); }
        if (val == 73) { SpecialEnemiesFunction(val); }
        if (val == 74) { SpecialEnemiesFunction(val); }
        if (val == 75) { SpecialEnemiesFunction(val); }
        if (val == 76) { SpecialEnemiesFunction(val); }
        if (val == 77) { SpecialEnemiesFunction(val); }
        if (val == 78) { SpecialEnemiesFunction(val); }
        if (val == 79) { SpecialEnemiesFunction(val); }
        if (val == 80) { SpecialEnemiesFunction(val); }
        if (val == 81) { SpecialEnemiesFunction(val); }
        if (val == 82) { SpecialEnemiesFunction(val); }
    }
    #endregion

    #region Using Inspire Skill
    public void PlayUsingInspireSkill(int val)
    {
        if (val == 1) { UsingInspireSkillFunction(val); }
        if (val == 2) { UsingInspireSkillFunction(val); }
        if (val == 3) { UsingInspireSkillFunction(val); }
        if (val == 4) { UsingInspireSkillFunction(val); }
        if (val == 5) { UsingInspireSkillFunction(val); }
        if (val == 6) { UsingInspireSkillFunction(val); }
        if (val == 7) { UsingInspireSkillFunction(val); }
        if (val == 8) { UsingInspireSkillFunction(val); }
        if (val == 9) { UsingInspireSkillFunction(val); }
        if (val == 10) { UsingInspireSkillFunction(val); }
        if (val == 11) { UsingInspireSkillFunction(val); }
        if (val == 12) { UsingInspireSkillFunction(val); }
        if (val == 13) { UsingInspireSkillFunction(val); }
        if (val == 14) { UsingInspireSkillFunction(val); }
        if (val == 15) { UsingInspireSkillFunction(val); }
        if (val == 16) { UsingInspireSkillFunction(val); }
    }
    #endregion

    #region Pager Responses
    public void PlayPagerResponses(int val)
    {
        if (val == 1) { PagerResponsesFunction(val); }
        if (val == 2) { PagerResponsesFunction(val); }
        if (val == 3) { PagerResponsesFunction(val); }
        if (val == 4) { PagerResponsesFunction(val); }
        if (val == 5) { PagerResponsesFunction(val); }
        if (val == 6) { PagerResponsesFunction(val); }
        if (val == 7) { PagerResponsesFunction(val); }
    }
    #endregion

    #region Deployables
    public void PlayDeployables(int val)
    {
        if (val == 1) { DeployablesFunction(val); }
        if (val == 2) { DeployablesFunction(val); }
        if (val == 3) { DeployablesFunction(val); }
        if (val == 4) { DeployablesFunction(val); }
        if (val == 5) { DeployablesFunction(val); }
        if (val == 6) { DeployablesFunction(val); }
        if (val == 7) { DeployablesFunction(val); }
        if (val == 8) { DeployablesFunction(val); }
        if (val == 9) { DeployablesFunction(val); }
        if (val == 10) { DeployablesFunction(val); }
        if (val == 11) { DeployablesFunction(val); }
        if (val == 12) { DeployablesFunction(val); }
        if (val == 13) { DeployablesFunction(val); }
        if (val == 14) { DeployablesFunction(val); }
        if (val == 15) { DeployablesFunction(val); }
    }
    #endregion

    #region Throwables
    public void PlayThrowables(int val)
    {
        if (val == 1) { ThrowablesFunction(val); }
        if (val == 2) { ThrowablesFunction(val); }
        if (val == 3) { ThrowablesFunction(val); }
        if (val == 4) { ThrowablesFunction(val); }
        if (val == 5) { ThrowablesFunction(val); }
        if (val == 6) { ThrowablesFunction(val); }
        if (val == 7) { ThrowablesFunction(val); }
        if (val == 8) { ThrowablesFunction(val); }
        if (val == 9) { ThrowablesFunction(val); }
        if (val == 10) { ThrowablesFunction(val); }
    }
    #endregion

    #region Tear Gas
    public void PlayTearGas(int val)
    {
        if (val == 1) { TearGasFunction(val); }
        if (val == 2) { TearGasFunction(val); }
        if (val == 3) { TearGasFunction(val); }
        if (val == 4) { TearGasFunction(val); }
    }
    #endregion

    #region Flashbangs
    public void PlayFlashbangs(int val)
    {
        if (val == 1) { FlashbangsFunction(val); }
        if (val == 2) { FlashbangsFunction(val); }
        if (val == 3) { FlashbangsFunction(val); }
        if (val == 4) { FlashbangsFunction(val); }
    }
    #endregion

    #region Smoke Grenade
    public void PlaySmokeGrenade(int val)
    {
        if (val == 1) { SmokeGrenadeFunction(val); }
        if (val == 2) { SmokeGrenadeFunction(val); }
        if (val == 3) { SmokeGrenadeFunction(val); }
        if (val == 4) { SmokeGrenadeFunction(val); }
        if (val == 5) { SmokeGrenadeFunction(val); }
        if (val == 6) { SmokeGrenadeFunction(val); }
    }
    #endregion

    #region Directions
    public void PlayDirections(int val)
    {
        if (val == 1) { DirectionsFunction(val); }
        if (val == 2) { DirectionsFunction(val); }
        if (val == 3) { DirectionsFunction(val); }
        if (val == 4) { DirectionsFunction(val); }
        if (val == 5) { DirectionsFunction(val); }
        if (val == 6) { DirectionsFunction(val); }
        if (val == 7) { DirectionsFunction(val); }
        if (val == 8) { DirectionsFunction(val); }
        if (val == 9) { DirectionsFunction(val); }
        if (val == 10) { DirectionsFunction(val); }
        if (val == 11) { DirectionsFunction(val); }
        if (val == 12) { DirectionsFunction(val); }
        if (val == 13) { DirectionsFunction(val); }
        if (val == 14) { DirectionsFunction(val); }
        if (val == 15) { DirectionsFunction(val); }
        if (val == 16) { DirectionsFunction(val); }
        if (val == 17) { DirectionsFunction(val); }
        if (val == 18) { DirectionsFunction(val); }
        if (val == 19) { DirectionsFunction(val); }
        if (val == 20) { DirectionsFunction(val); }
        if (val == 21) { DirectionsFunction(val); }
        if (val == 22) { DirectionsFunction(val); }
        if (val == 23) { DirectionsFunction(val); }
        if (val == 24) { DirectionsFunction(val); }
        if (val == 25) { DirectionsFunction(val); }
        if (val == 26) { DirectionsFunction(val); }
        if (val == 27) { DirectionsFunction(val); }
        if (val == 28) { DirectionsFunction(val); }
        if (val == 29) { DirectionsFunction(val); }
        if (val == 30) { DirectionsFunction(val); }
        if (val == 31) { DirectionsFunction(val); }
        if (val == 32) { DirectionsFunction(val); }
        if (val == 33) { DirectionsFunction(val); }
        if (val == 34) { DirectionsFunction(val); }
        if (val == 35) { DirectionsFunction(val); }
        if (val == 36) { DirectionsFunction(val); }
        if (val == 37) { DirectionsFunction(val); }
        if (val == 38) { DirectionsFunction(val); }
        if (val == 39) { DirectionsFunction(val); }
        if (val == 40) { DirectionsFunction(val); }
        if (val == 41) { DirectionsFunction(val); }
        if (val == 42) { DirectionsFunction(val); }
        if (val == 43) { DirectionsFunction(val); }
        if (val == 44) { DirectionsFunction(val); }
        if (val == 45) { DirectionsFunction(val); }
        if (val == 46) { DirectionsFunction(val); }
        if (val == 47) { DirectionsFunction(val); }
        if (val == 48) { DirectionsFunction(val); }
        if (val == 49) { DirectionsFunction(val); }
        if (val == 50) { DirectionsFunction(val); }
        if (val == 51) { DirectionsFunction(val); }
        if (val == 52) { DirectionsFunction(val); }
        if (val == 53) { DirectionsFunction(val); }
        if (val == 54) { DirectionsFunction(val); }
        if (val == 55) { DirectionsFunction(val); }
        if (val == 56) { DirectionsFunction(val); }
        if (val == 57) { DirectionsFunction(val); }
        if (val == 58) { DirectionsFunction(val); }
        if (val == 59) { DirectionsFunction(val); }
        if (val == 60) { DirectionsFunction(val); }
        if (val == 61) { DirectionsFunction(val); }
    }
    #endregion

    #region Health & Bleedout
    public void PlayHealthAndBleedout(int val)
    {
        if (val == 1) { HealthandBleedoutFunction(val); }
        if (val == 2) { HealthandBleedoutFunction(val); }
        if (val == 3) { HealthandBleedoutFunction(val); }
        if (val == 4) { HealthandBleedoutFunction(val); }
        if (val == 5) { HealthandBleedoutFunction(val); }
        if (val == 6) { HealthandBleedoutFunction(val); }
        if (val == 7) { HealthandBleedoutFunction(val); }
        if (val == 8) { HealthandBleedoutFunction(val); }
        if (val == 9) { HealthandBleedoutFunction(val); }
        if (val == 10) { HealthandBleedoutFunction(val); }
        if (val == 11) { HealthandBleedoutFunction(val); }
        if (val == 12) { HealthandBleedoutFunction(val); }
        if (val == 13) { HealthandBleedoutFunction(val); }
        if (val == 14) { HealthandBleedoutFunction(val); }
        if (val == 15) { HealthandBleedoutFunction(val); }
        if (val == 16) { HealthandBleedoutFunction(val); }
        if (val == 17) { HealthandBleedoutFunction(val); }
        if (val == 18) { HealthandBleedoutFunction(val); }
        if (val == 19) { HealthandBleedoutFunction(val); }
        if (val == 20) { HealthandBleedoutFunction(val); }
        if (val == 21) { HealthandBleedoutFunction(val); }
        if (val == 22) { HealthandBleedoutFunction(val); }
        if (val == 23) { HealthandBleedoutFunction(val); }
        if (val == 24) { HealthandBleedoutFunction(val); }
        if (val == 25) { HealthandBleedoutFunction(val); }
        if (val == 26) { HealthandBleedoutFunction(val); }
        if (val == 27) { HealthandBleedoutFunction(val); }
        if (val == 28) { HealthandBleedoutFunction(val); }
        if (val == 29) { HealthandBleedoutFunction(val); }
        if (val == 30) { HealthandBleedoutFunction(val); }
        if (val == 31) { HealthandBleedoutFunction(val); }
        if (val == 32) { HealthandBleedoutFunction(val); }
        if (val == 33) { HealthandBleedoutFunction(val); }
    }
    #endregion

    #region Low Ammunition
    public void PlayLowAmmunition(int val)
    {
        if (val == 1) { LowAmmunitionFunction(val); }
        if (val == 2) { LowAmmunitionFunction(val); }
        if (val == 3) { LowAmmunitionFunction(val); }
        if (val == 4) { LowAmmunitionFunction(val); }
        if (val == 5) { LowAmmunitionFunction(val); }
        if (val == 6) { LowAmmunitionFunction(val); }
        if (val == 7) { LowAmmunitionFunction(val); }
        if (val == 8) { LowAmmunitionFunction(val); }
        if (val == 9) { LowAmmunitionFunction(val); }
        if (val == 10) { LowAmmunitionFunction(val); }
        if (val == 11) { LowAmmunitionFunction(val); }
        if (val == 12) { LowAmmunitionFunction(val); }
    }
    #endregion

    #region Objectives
    public void PlayObjectives(int val)
    {
        if (val == 1) { ObjectivesFunction(val); }
        if (val == 2) { ObjectivesFunction(val); }
        if (val == 3) { ObjectivesFunction(val); }
        if (val == 4) { ObjectivesFunction(val); }
        if (val == 5) { ObjectivesFunction(val); }
        if (val == 6) { ObjectivesFunction(val); }
        if (val == 7) { ObjectivesFunction(val); }
        if (val == 8) { ObjectivesFunction(val); }
        if (val == 9) { ObjectivesFunction(val); }
        if (val == 10) { ObjectivesFunction(val); }
        if (val == 11) { ObjectivesFunction(val); }
        if (val == 12) { ObjectivesFunction(val); }
        if (val == 13) { ObjectivesFunction(val); }
        if (val == 14) { ObjectivesFunction(val); }
        if (val == 15) { ObjectivesFunction(val); }
        if (val == 16) { ObjectivesFunction(val); }
        if (val == 17) { ObjectivesFunction(val); }
        if (val == 18) { ObjectivesFunction(val); }
        if (val == 19) { ObjectivesFunction(val); }
        if (val == 20) { ObjectivesFunction(val); }
    }
    #endregion

    #region Map Specific Quotes
    public void PlayMapSpecificQuotes(int val)
    {
        if (val == 1) { MapSpecificQuotesFunction(val); }
        if (val == 2) { MapSpecificQuotesFunction(val); }
        if (val == 3) { MapSpecificQuotesFunction(val); }
        if (val == 4) { MapSpecificQuotesFunction(val); }
        if (val == 5) { MapSpecificQuotesFunction(val); }
        if (val == 6) { MapSpecificQuotesFunction(val); }
        if (val == 7) { MapSpecificQuotesFunction(val); }
        if (val == 8) { MapSpecificQuotesFunction(val); }
        if (val == 9) { MapSpecificQuotesFunction(val); }
        if (val == 10) { MapSpecificQuotesFunction(val); }
        if (val == 11) { MapSpecificQuotesFunction(val); }
        if (val == 12) { MapSpecificQuotesFunction(val); }
        if (val == 13) { MapSpecificQuotesFunction(val); }
        if (val == 14) { MapSpecificQuotesFunction(val); }
        if (val == 15) { MapSpecificQuotesFunction(val); }
        if (val == 16) { MapSpecificQuotesFunction(val); }
        if (val == 17) { MapSpecificQuotesFunction(val); }
        if (val == 18) { MapSpecificQuotesFunction(val); }
        if (val == 19) { MapSpecificQuotesFunction(val); }
        if (val == 20) { MapSpecificQuotesFunction(val); }
        if (val == 21) { MapSpecificQuotesFunction(val); }
        if (val == 22) { MapSpecificQuotesFunction(val); }
        if (val == 23) { MapSpecificQuotesFunction(val); }
        if (val == 24) { MapSpecificQuotesFunction(val); }
        if (val == 25) { MapSpecificQuotesFunction(val); }
        if (val == 26) { MapSpecificQuotesFunction(val); }
        if (val == 27) { MapSpecificQuotesFunction(val); }
        if (val == 28) { MapSpecificQuotesFunction(val); }
        if (val == 29) { MapSpecificQuotesFunction(val); }
        if (val == 30) { MapSpecificQuotesFunction(val); }
        if (val == 31) { MapSpecificQuotesFunction(val); }
        if (val == 32) { MapSpecificQuotesFunction(val); }
        if (val == 33) { MapSpecificQuotesFunction(val); }
        if (val == 34) { MapSpecificQuotesFunction(val); }
        if (val == 35) { MapSpecificQuotesFunction(val); }
        if (val == 36) { MapSpecificQuotesFunction(val); }
        if (val == 37) { MapSpecificQuotesFunction(val); }
        if (val == 38) { MapSpecificQuotesFunction(val); }
        if (val == 39) { MapSpecificQuotesFunction(val); }
        if (val == 40) { MapSpecificQuotesFunction(val); }
        if (val == 41) { MapSpecificQuotesFunction(val); }
        if (val == 42) { MapSpecificQuotesFunction(val); }
        if (val == 43) { MapSpecificQuotesFunction(val); }
        if (val == 44) { MapSpecificQuotesFunction(val); }
        if (val == 45) { MapSpecificQuotesFunction(val); }
        if (val == 46) { MapSpecificQuotesFunction(val); }
        if (val == 47) { MapSpecificQuotesFunction(val); }
        if (val == 48) { MapSpecificQuotesFunction(val); }
        if (val == 49) { MapSpecificQuotesFunction(val); }
        if (val == 50) { MapSpecificQuotesFunction(val); }
        if (val == 51) { MapSpecificQuotesFunction(val); }
        if (val == 52) { MapSpecificQuotesFunction(val); }
        if (val == 53) { MapSpecificQuotesFunction(val); }
        if (val == 54) { MapSpecificQuotesFunction(val); }
        if (val == 55) { MapSpecificQuotesFunction(val); }
        if (val == 56) { MapSpecificQuotesFunction(val); }
        if (val == 57) { MapSpecificQuotesFunction(val); }
        if (val == 58) { MapSpecificQuotesFunction(val); }
        if (val == 59) { MapSpecificQuotesFunction(val); }
        if (val == 60) { MapSpecificQuotesFunction(val); }
        if (val == 61) { MapSpecificQuotesFunction(val); }
        if (val == 62) { MapSpecificQuotesFunction(val); }
        if (val == 63) { MapSpecificQuotesFunction(val); }
        if (val == 64) { MapSpecificQuotesFunction(val); }
        if (val == 65) { MapSpecificQuotesFunction(val); }
        if (val == 66) { MapSpecificQuotesFunction(val); }
        if (val == 67) { MapSpecificQuotesFunction(val); }
        if (val == 68) { MapSpecificQuotesFunction(val); }
        if (val == 69) { MapSpecificQuotesFunction(val); }
        if (val == 70) { MapSpecificQuotesFunction(val); }
        if (val == 71) { MapSpecificQuotesFunction(val); }
        if (val == 72) { MapSpecificQuotesFunction(val); }
        if (val == 73) { MapSpecificQuotesFunction(val); }
        if (val == 74) { MapSpecificQuotesFunction(val); }
        if (val == 75) { MapSpecificQuotesFunction(val); }
        if (val == 76) { MapSpecificQuotesFunction(val); }
        if (val == 77) { MapSpecificQuotesFunction(val); }
        if (val == 78) { MapSpecificQuotesFunction(val); }
        if (val == 79) { MapSpecificQuotesFunction(val); }
        if (val == 80) { MapSpecificQuotesFunction(val); }
        if (val == 81) { MapSpecificQuotesFunction(val); }
        if (val == 82) { MapSpecificQuotesFunction(val); }
        if (val == 83) { MapSpecificQuotesFunction(val); }
        if (val == 84) { MapSpecificQuotesFunction(val); }
        if (val == 85) { MapSpecificQuotesFunction(val); }
        if (val == 86) { MapSpecificQuotesFunction(val); }
        if (val == 87) { MapSpecificQuotesFunction(val); }
        if (val == 88) { MapSpecificQuotesFunction(val); }
        if (val == 89) { MapSpecificQuotesFunction(val); }
        if (val == 90) { MapSpecificQuotesFunction(val); }
        if (val == 91) { MapSpecificQuotesFunction(val); }
        if (val == 92) { MapSpecificQuotesFunction(val); }
        if (val == 93) { MapSpecificQuotesFunction(val); }
        if (val == 94) { MapSpecificQuotesFunction(val); }
        if (val == 95) { MapSpecificQuotesFunction(val); }
        if (val == 96) { MapSpecificQuotesFunction(val); }
        if (val == 97) { MapSpecificQuotesFunction(val); }
        if (val == 98) { MapSpecificQuotesFunction(val); }
        if (val == 99) { MapSpecificQuotesFunction(val); }
        if (val == 100) { MapSpecificQuotesFunction(val); }
        if (val == 101) { MapSpecificQuotesFunction(val); }
        if (val == 102) { MapSpecificQuotesFunction(val); }
        if (val == 103) { MapSpecificQuotesFunction(val); }
        if (val == 104) { MapSpecificQuotesFunction(val); }
        if (val == 105) { MapSpecificQuotesFunction(val); }
        if (val == 106) { MapSpecificQuotesFunction(val); }
        if (val == 107) { MapSpecificQuotesFunction(val); }
        if (val == 108) { MapSpecificQuotesFunction(val); }
        if (val == 109) { MapSpecificQuotesFunction(val); }
        if (val == 110) { MapSpecificQuotesFunction(val); }
        if (val == 111) { MapSpecificQuotesFunction(val); }
        if (val == 112) { MapSpecificQuotesFunction(val); }
    }
    #endregion

    #region CPU Controlled Clips
    public void PlayCPUControlledClips(int val)
    {
        if (val == 1) { CPUControlledClipsFunction(val); }
        if (val == 2) { CPUControlledClipsFunction(val); }
        if (val == 3) { CPUControlledClipsFunction(val); }
        if (val == 4) { CPUControlledClipsFunction(val); }
        if (val == 5) { CPUControlledClipsFunction(val); }
        if (val == 6) { CPUControlledClipsFunction(val); }
        if (val == 7) { CPUControlledClipsFunction(val); }
        if (val == 8) { CPUControlledClipsFunction(val); }
        if (val == 9) { CPUControlledClipsFunction(val); }
        if (val == 10) { CPUControlledClipsFunction(val); }
        if (val == 11) { CPUControlledClipsFunction(val); }
        if (val == 12) { CPUControlledClipsFunction(val); }
        if (val == 13) { CPUControlledClipsFunction(val); }
        if (val == 14) { CPUControlledClipsFunction(val); }
        if (val == 15) { CPUControlledClipsFunction(val); }
        if (val == 16) { CPUControlledClipsFunction(val); }
        if (val == 17) { CPUControlledClipsFunction(val); }
        if (val == 18) { CPUControlledClipsFunction(val); }
        if (val == 19) { CPUControlledClipsFunction(val); }
        if (val == 20) { CPUControlledClipsFunction(val); }
        if (val == 21) { CPUControlledClipsFunction(val); }
        if (val == 22) { CPUControlledClipsFunction(val); }
        if (val == 23) { CPUControlledClipsFunction(val); }
        if (val == 24) { CPUControlledClipsFunction(val); }
        if (val == 25) { CPUControlledClipsFunction(val); }
        if (val == 26) { CPUControlledClipsFunction(val); }
        if (val == 27) { CPUControlledClipsFunction(val); }
        if (val == 28) { CPUControlledClipsFunction(val); }
        if (val == 29) { CPUControlledClipsFunction(val); }
        if (val == 30) { CPUControlledClipsFunction(val); }
        if (val == 31) { CPUControlledClipsFunction(val); }
        if (val == 32) { CPUControlledClipsFunction(val); }
        if (val == 33) { CPUControlledClipsFunction(val); }
        if (val == 34) { CPUControlledClipsFunction(val); }
        if (val == 35) { CPUControlledClipsFunction(val); }
        if (val == 36) { CPUControlledClipsFunction(val); }
        if (val == 37) { CPUControlledClipsFunction(val); }
        if (val == 38) { CPUControlledClipsFunction(val); }
        if (val == 39) { CPUControlledClipsFunction(val); }
        if (val == 40) { CPUControlledClipsFunction(val); }
        if (val == 41) { CPUControlledClipsFunction(val); }
        if (val == 42) { CPUControlledClipsFunction(val); }
        if (val == 43) { CPUControlledClipsFunction(val); }
        if (val == 44) { CPUControlledClipsFunction(val); }
        if (val == 45) { CPUControlledClipsFunction(val); }
        if (val == 46) { CPUControlledClipsFunction(val); }
        if (val == 47) { CPUControlledClipsFunction(val); }
    }
    #endregion

    #region Other
    public void PlayOther(int val)
    {
        if (val == 1) { OtherFunction(val); }
        if (val == 2) { OtherFunction(val); }
        if (val == 3) { OtherFunction(val); }
        if (val == 4) { OtherFunction(val); }
        if (val == 5) { OtherFunction(val); }
        if (val == 6) { OtherFunction(val); }
        if (val == 7) { OtherFunction(val); }
        if (val == 8) { OtherFunction(val); }
        if (val == 9) { OtherFunction(val); }
        if (val == 10) { OtherFunction(val); }
        if (val == 11) { OtherFunction(val); }
        if (val == 12) { OtherFunction(val); }
        if (val == 13) { OtherFunction(val); }
        if (val == 14) { OtherFunction(val); }
        if (val == 15) { OtherFunction(val); }
        if (val == 16) { OtherFunction(val); }
        if (val == 17) { OtherFunction(val); }
        if (val == 18) { OtherFunction(val); }
        if (val == 19) { OtherFunction(val); }
        if (val == 20) { OtherFunction(val); }
        if (val == 21) { OtherFunction(val); }
        if (val == 22) { OtherFunction(val); }
        if (val == 23) { OtherFunction(val); }
        if (val == 24) { OtherFunction(val); }
        if (val == 25) { OtherFunction(val); }
        if (val == 26) { OtherFunction(val); }
        if (val == 27) { OtherFunction(val); }
        if (val == 28) { OtherFunction(val); }
        if (val == 29) { OtherFunction(val); }
        if (val == 30) { OtherFunction(val); }
        if (val == 31) { OtherFunction(val); }
        if (val == 32) { OtherFunction(val); }
        if (val == 33) { OtherFunction(val); }
        if (val == 34) { OtherFunction(val); }
        if (val == 35) { OtherFunction(val); }
        if (val == 36) { OtherFunction(val); }
        if (val == 37) { OtherFunction(val); }
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