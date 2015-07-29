using UnityEngine;
using System.Collections;

public class MouseEvent : MonoBehaviour
{
	public AudioSource audio;

	public void EnterSound ()
	{
		audio.Play ();
	}
}
 