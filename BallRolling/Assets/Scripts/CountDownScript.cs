using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownScript : MonoBehaviour {

	[SerializeField]
	Text uiText;

	[SerializeField]
	float mainTimer;


	private float timer;
	private bool canCount = true;
	private bool doOnce = false;

	void Start()
    {
		timer = mainTimer;

    }

	void Update()
    {
		if (timer >= 0.0f && canCount)
        {
			timer -= Time.deltaTime;
			uiText.text = timer.ToString("F");
        } else
        {
			SceneManager.LoadScene("GameOver");
		}
    }
}
