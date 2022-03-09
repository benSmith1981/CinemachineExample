using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectStanding : MonoBehaviour
{
	public GameObject timeLinePlayer;
	TimeLinePlayer player;
    // Start is called before the first frame update
    void Start()
    {
        player = timeLinePlayer.GetComponent<TimeLinePlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        player.StartTimeline();
    }
    private void OnCollisionEnter(Collision collision)
    {
    	player.StartTimeline();

    }
}
