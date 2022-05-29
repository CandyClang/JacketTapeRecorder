using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownManager : MonoBehaviour
{
    public GameObject[] quoteDropdowns;

    public void HandleInputData(int val)
    {
        for (int i = 1; i < quoteDropdowns.Length + 1; i++)
        {
            if (val == i)
            {
                if (quoteDropdowns[val - 1] != null)
                    quoteDropdowns[val - 1].SetActive(true);

                for (int j = 0; j < quoteDropdowns.Length; j++)
                {
                    if (j != val - 1)
                        quoteDropdowns[j].SetActive(false);
                }
            }
        }
    }
}
