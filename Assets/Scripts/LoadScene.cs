﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
	public void LoadSceneName (string name)
	{
		Application.LoadLevel (name);
	}
}
