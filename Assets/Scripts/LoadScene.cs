using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour
{
	public void LoadSceneName (string name)
	{
		Application.LoadLevel (name);
	}
}
