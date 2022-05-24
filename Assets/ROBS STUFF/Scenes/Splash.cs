using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {

	public VideoPlayer Intro_Movie;
	bool canProgress = false;
	public GameObject canvas;

	void Update()
	{

		if (Input.GetKey(KeyCode.Space) && canProgress == false) {
			Intro_Movie.Play();
			//Intro_Movie.Play();
			StartCoroutine("waitForMovieEnd");
		}

		if (Input.GetKey(KeyCode.A) && canProgress == true) {
			SceneManager.LoadScene("demo");
		}


	}
		
	IEnumerator waitForMovieEnd(){
		
		while(Intro_Movie.isPlaying) {
			yield return new WaitForEndOfFrame();
		}
		onMovieEnded();
	}
		
	void onMovieEnded() {
		canProgress = true;
		canvas.SetActive (true);
	}
}
