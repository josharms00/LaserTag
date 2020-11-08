using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChasePlayer : MonoBehaviour
{

    Transform player;
    NavMeshAgent nav;
    float distanceAway;

    Tagged tagged;

    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player").transform;

        nav = GetComponent<NavMeshAgent>();

        tagged = GetComponent<Tagged> ();
    }

    // Update is called once per frame
    void Update()
    {
        

        if(tagged.It)
        {
            nav.SetDestination(player.position);
        }
        else
        {
            nav.SetDestination(10*player.forward);
        }
        
        
    }
}
