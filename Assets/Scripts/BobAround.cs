using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobAround : MonoBehaviour
{
	private float degreesPerSecond = 15f, amplitude = 0.01f, frequency = 1f;
	private Vector2 posOffSet = new Vector3 (0,0,0), tempPos = new Vector3 ();

	private void Update ()
	{
		Bob ();
	}
		
	private void Bob ()
	{
		if (this.gameObject.name == "Frame") {
			transform.Rotate (Vector3.up, 50 * Time.deltaTime);
		} else {
			transform.Rotate (Vector3.up, 20 * Time.deltaTime);
		}
	}
}