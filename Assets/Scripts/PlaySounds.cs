using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySounds : MonoBehaviour {
	int[] currentTracks = new int[3];
	AudioSource playerFore;
	AudioSource playerMid;
	AudioSource playerBack;

	public AudioClip[] fore = new AudioClip[6];
	public AudioClip[] mid  = new AudioClip[6];
	public AudioClip[] back = new AudioClip[6];

	// Use this for initialization
	void Start () {
		AudioSource[] allplayers = GetComponents<AudioSource> ();

		if (allplayers.Length >= 3) {
			playerFore = allplayers [0];
			playerMid  = allplayers [1];
			playerBack = allplayers [2];
		} else
			print ("The button needs at least 3 audio sources to function.");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayRandomMusic()
	{
		for (int t = 0; t < 3; t++)
			currentTracks[t] = Random.Range (0, 2);

		playerFore.PlayOneShot (fore [currentTracks [0]]);
		playerMid.PlayOneShot  (mid  [currentTracks [1]]);
		playerBack.PlayOneShot (back [currentTracks [2]]);
	}
}
