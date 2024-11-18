using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolEnemy : MonoBehaviour
{
    public GameObject[] Waypoints;
    public float AcceptableDistance = .6f;
    private NavMeshAgent Agent;
    public int CurrentWaypoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        Agent.SetDestination(Waypoints[0].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (ArrivedAtDestination())
        {
            CurrentWaypoint++; //add one
            if (CurrentWaypoint > Waypoints.Length - 1)
            {
                CurrentWaypoint = 0;
            }
            Agent.SetDestination(Waypoints[CurrentWaypoint].transform.position);
        }
    }

    private bool ArrivedAtDestination()
    {
        float dist = Vector3.Distance(transform.position, Waypoints[CurrentWaypoint].transform.position);
        Debug.Log(dist);
        if (dist <= AcceptableDistance)
        {
            Debug.Log("Reached destination!");
            return true;
        }
        return false;
    }
}
