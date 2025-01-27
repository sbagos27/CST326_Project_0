using UnityEngine;
using UnityEngine.AI;

using System.Collections;
using System.Collections.Generic;


public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        
    }

    void Update()
    {
        if(player != null){
            navMeshAgent.SetDestination(player.position);
        }
        
    }
}
