using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindEventCamera : MonoBehaviour
{
    private Canvas theCanvas;

    private void Start()
    {
        theCanvas = GetComponent<Canvas>();
        theCanvas.worldCamera = Camera.main;
    }
}
