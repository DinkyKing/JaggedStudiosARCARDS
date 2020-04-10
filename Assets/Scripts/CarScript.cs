using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public Renderer mainCarMaterial;
    public AudioSource theAudioSource;
    public AudioClip theRev;

    public void ChangeColor(string _theColor)
    {
        if (_theColor == "red")
        {
            mainCarMaterial.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
        if (_theColor == "white")
        {
            mainCarMaterial.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
        }
        if (_theColor == "black")
        {
            mainCarMaterial.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
        }
    }

    private void OnMouseDown()
    {
        PlayAudio();
    }

    private void PlayAudio()
    {
        if (!theAudioSource.isPlaying)
        {
            theAudioSource.PlayOneShot(theRev);
        }
    }

}

