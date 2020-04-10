using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoExplosion : MonoBehaviour
{

	public AudioSource theAudioSource;
	public AudioClip explosionSound;
	public GameObject gameModel;

	private GameObject logoCopy;
	private bool exploded, canRewind;

	private void Start()
	{
		exploded = false;
		canRewind = false;
	}

	void OnMouseDown()
	{
		if (!exploded)
		{
			Explode();
		}
		if (canRewind && exploded)
		{
			Rewind();
		}
	}

	private void Explode()
	{
		exploded = true;
		PlaySounds(explosionSound);
		for (int i = 0; i < logoCopy.gameObject.transform.childCount; i++)
		{
			if (logoCopy.gameObject.transform.GetChild(i).tag == "Cube")
			{
				logoCopy.gameObject.transform.GetChild(i).GetComponent<Rigidbody>().isKinematic = false;
				logoCopy.gameObject.transform.GetChild(i).GetComponent<Rigidbody>().useGravity = true;
			}
		}
		canRewind = true;
	}

	private void Rewind()
	{
		exploded = false;
	}

	private void OnEnable()
	{
		CreateGameModel();
	}

	private void OnDisable()
	{
		DeleteGameModel();
	}

	private void PlaySounds(AudioClip theSound)
	{
		if (!theAudioSource.isPlaying)
		{
			theAudioSource.PlayOneShot(theSound);
		}
	}

	public void CreateGameModel()
	{
		logoCopy = Instantiate(gameModel, this.gameObject.transform);
	}

	public void DeleteGameModel()
	{
		Destroy(logoCopy);
	}
}
