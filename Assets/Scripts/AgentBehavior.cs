using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentBehavior : MonoBehaviour
{
    public NavMeshAgent agent;
    public transform[] targets;
    //public Transform target;
    //public Transform target2;
    //public Transform targetAux;

    // Start is called before the first frame update
    void Start()
    {
        targetAux = target[0];
        agent.destination = targetAux.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (agent.hasPath && agent.remainingDistance < 1)
        {
            if(targetAux == targets[0])
            {
                targetAux = targets[1];
            }
            else
            {
                targetAux = targets[0];
            }
            agent.destination = targetAux.position;
        }
    }
}
