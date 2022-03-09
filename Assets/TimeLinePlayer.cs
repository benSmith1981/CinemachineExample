using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class TimeLinePlayer : MonoBehaviour
{
	private PlayableDirector director;
	public GameObject controlPanel;

	void Awake(){
		director = GetComponent<PlayableDirector>();
		director.played += Director_Player;
		director.stopped += Director_Stopped;
	}

	private void Director_Stopped(PlayableDirector obj){
		controlPanel.SetActive(true);
	}
	private void Director_Player(PlayableDirector obj){
		controlPanel.SetActive(false);
	}

	public void StartTimeline() {
		director.Play();
	}

}
