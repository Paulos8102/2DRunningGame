//PaulJabez_LevelGame2D
//For the movement of the platform in between the specified WAYPOINTS

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;

    [SerializeField] private float speed = 2f;
  
    private void Update()
    {
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)     // to know if we're touching the platform
        {
            currentWaypointIndex++;

            if (currentWaypointIndex >= waypoints.Length)   //to know if we're at the last waypoint
            { 
                currentWaypointIndex = 0; 
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}
