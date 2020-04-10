using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmailButton : MonoBehaviour
{
	/// <summary>
	/// Fill in these deets
	/// </summary>
	public void SendEmail()
	{
		string email = "";
		string subject = MyEscapeURL("Augmented Reality Demo Jagged Studios");
		string body = MyEscapeURL("How Cool Is This Demo?!");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}

	private string MyEscapeURL(string url)
	{
		return WWW.EscapeURL(url).Replace("+", "%20");
	}
}
