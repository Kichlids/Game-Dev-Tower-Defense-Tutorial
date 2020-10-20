using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Navigation navigation;

    public Transform[] waypoints;
    public int waypointIndex = 0;

    public float speed = 0.5f;

    public float distThreshold = 0.01f;

    private void Start() {
        waypoints = navigation.waypoints;
    }

    private void Update() {

        if (waypointIndex >= waypoints.Length) {
            Destroy(gameObject);
            enabled = false;
            return;
        }

        float distance = Vector3.Distance(transform.position, waypoints[waypointIndex].position);

        if (distance < distThreshold) {
            // Go to next waypoint
            waypointIndex++;
        }
        else {
            print(waypoints[waypointIndex].position);
            transform.Translate((waypoints[waypointIndex].position - transform.position).normalized * speed * Time.deltaTime);
        }
    }
}
