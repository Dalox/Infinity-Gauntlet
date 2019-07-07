using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent (typeof(AudioSource))]

public class Video : MonoBehaviour {

    public MovieTexture movie;
    private AudioSource aud;

	// Use this for initialization
	void Start ()
    {
        gameObject.GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
        aud = gameObject.GetComponent<AudioSource>();
        aud.clip = movie.audioClip;
        Debug.Log(movie.name);
        movie.Play();
        aud.Play();
	}
	
	// Update is called once per frame
	void Update () {
        if(!movie.isPlaying)
        {
            //Application.LoadLevel("Yggdrasil");
            SceneManager.LoadSceneAsync("Yggdrasil");
            //SceneManager.LoadSceneAsync("Yggdrasil");
        }
		
	}
}
