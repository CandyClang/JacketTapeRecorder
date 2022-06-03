using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarScript : MonoBehaviour
{
    private float currScrollVal; //NEED TO FIND A WAY TO SAVE THE VALUES INDIVIDUAL TO THE SCROLLBAR IN CURRENT GAMEOBJECT

    private void Start()
    {
        currScrollVal = PlayerPrefs.GetFloat("scroll value");
        gameObject.GetComponent<Scrollbar>().value = currScrollVal;
    }

    private void Update()
    {
        gameObject.GetComponent<Scrollbar>().value = currScrollVal;
        PlayerPrefs.SetFloat("scroll value", currScrollVal);
    }

    private void UpdateScrollValue(float scrollVal)
    {
        currScrollVal = scrollVal;
    }
}
