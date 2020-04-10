using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSwitcher : MonoBehaviour
{
    public GameObject parentObject;
    private int currentIndex;

    private void Start()
    {
        currentIndex = 0;
        NextPrefab(0);
    }
    
    public void NextPrefab(int increment)
    {
        currentIndex += increment;
        if(currentIndex >= parentObject.transform.childCount - 1)
        {
            currentIndex = 0;
        }
        else if(currentIndex <= -1)
        {
            currentIndex = 2;
        }

        for(int i = 0; i < parentObject.transform.childCount - 1; i++)
        {
            if (i == currentIndex)
            {
                parentObject.transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                parentObject.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
