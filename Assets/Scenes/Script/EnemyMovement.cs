using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public GameObject goal;

    // Update is called once per frame
    void Update()
    {
        goal = GameObject.FindWithTag("Home");
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.transform.position;
    }
}
