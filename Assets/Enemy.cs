using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject Player;

    private NavMeshAgent Agent;

    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        Agent.SetDestination(Player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Agent.SetDestination(Player.transform.position);
    }
}
