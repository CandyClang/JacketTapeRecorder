using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownManager : MonoBehaviour
{
    public GameObject[] quoteDropdowns = new GameObject[21];

    public void HandleInputData(int val)
    {
        #region Masking Up
        if (val == 1) //Masking Up
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for(int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Calling Crewmates
        if (val == 2) //Calling Crewmates
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Dominating
        if (val == 3) //Dominating
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Completing a heist
        if (val == 4) //Completing a heist
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Stealth
        if (val == 5) //Stealth
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Assault Wave Inbound
        if (val == 6) //Assault Wave Inbound
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Special Enemies
        if (val == 7) //Special Enemies
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Using Inspire Skill
        if (val == 8) //Using Inspire Skill
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Pager Responses
        if (val == 9) //Pager Responses
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Deployables
        if (val == 10) //Deployables
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Throwables
        if (val == 11) //Throwables
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Tear Gas
        if (val == 12) //Tear Gas
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Flashbangs
        if (val == 13) //Flashbangs
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Smoke Grenade
        if (val == 14) //Smoke Grenade
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Directions
        if (val == 15) //Directions
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Health & Bleedout
        if (val == 16) //Health & Bleedout
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Low Ammunition
        if (val == 17) //Low Ammunition
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Objectives
        if (val == 18) //Objectives
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Map Specific Quotes
        if (val == 19) // Map Specific Quotes
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region CPU-Controlled Only
        if (val == 20) //CPU-Controlled Only
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
        #region Other
        if (val == 21) //Other
        {
            if (quoteDropdowns[val - 1] != null)
                quoteDropdowns[val - 1].SetActive(true);

            for (int i = 0; i < quoteDropdowns.Length; i++)
            {
                if (i != val - 1)
                    quoteDropdowns[i].SetActive(false);
            }
        }
        #endregion
    }
}
