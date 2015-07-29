using UnityEngine;
using System.Collections;

public class MouseEvent : MonoBehaviour
{
	public AudioSource audio;

	void Start ()
	{
		audio = GetComponent<AudioSource> ();
	}
	
	void OnMouseEnter ()
	{
		audio.Play ();
	}
}
 