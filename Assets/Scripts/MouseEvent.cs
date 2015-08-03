using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MouseEvent : MonoBehaviour
{
	public void HighlightedSound (AudioSource highlightedSound)
	{
		highlightedSound.Play ();
	}

	public void NormalImg (Sprite normalImg)
	{
		this.GetComponent<Image> ().sprite = normalImg;
	}

	public void HighlightedImg (Sprite highlightedImg)
	{
		this.GetComponent<Image> ().sprite = highlightedImg;
	}
}
 