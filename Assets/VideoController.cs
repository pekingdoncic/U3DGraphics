using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour {
    VideoPlayer videoPlayer;
	// Use this for initialization
	void Start () {
        videoPlayer = GetComponent<VideoPlayer>();
        Debug.Assert(videoPlayer);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            if (videoPlayer.isPlaying)
                videoPlayer.Pause();
            else
                videoPlayer.Play();
        }
	}
}
