using UnityEngine;

/// <summary>
/// Open URL button
/// </summary>
public class OpenURL : MonoBehaviour
{
	/// <summary>
	/// Opens the link.
	/// </summary>
	/// <param name="_link">"Follow this style to make sure it works for all OS http://www.jaggedstudios.com.au/links-and-other/".</param>
	public void OpenLink(string _link)
	{
		Application.OpenURL(_link);
	}
}