using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySounds : MonoBehaviour {
	int[] currentTracks = new int[3];

	public AudioSource[] fore = new AudioSource[6];
	public AudioSource[] mid  = new AudioSource[6];
	public AudioSource[] back = new AudioSource[6];

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayRandomMusic()
	{
		for (int t = 0; t < 3; t++)
			currentTracks[t] = Random.Range (0, 5);

		fore [currentTracks [0]].Play ();
		mid  [currentTracks [1]].Play ();
		back [currentTracks [2]].Play ();
	}
}
