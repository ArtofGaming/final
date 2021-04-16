using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
	public static TimerController instance;
	public GameObject GameManager;
	public Text timeCounter;
	public float startTime;
	public float timePlaying = 0f;
	private bool timerGoing;
	public static float elapsedTime;

	//Allows timer to not be deleted between scenes
	private void Awake()
	{
		instance = this;
		DontDestroyOnLoad(GameManager);
	}

	//Calls timer to start
	private void Start()
	{
		timerGoing = false;
		BeginTimer();
	}

	//Begins the timer
	public void BeginTimer()
	{
		timerGoing = true;
		startTime = Time.time;
		elapsedTime = 0f;

		StartCoroutine(UpdateTimer());
	}

	//Ends timer
	public void EndTimer()
	{
		timerGoing = false;
	}

	// Makes the timer work
    private IEnumerator UpdateTimer()
	{
		while (timerGoing)
		{
			elapsedTime += Time.deltaTime;
			int secondsPassed = (int)elapsedTime%60;
			int minutesPassed = (int)(elapsedTime / 60) % 60;

            string timePlayingStr = string.Format("{0:00}:{1:00}",minutesPassed, secondsPassed);
			timeCounter.text = timePlayingStr;

			yield return null;
		}
	}
}
