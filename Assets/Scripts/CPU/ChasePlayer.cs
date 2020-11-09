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

    Animator anim;

    public GameObject menu;

    PauseManager p;

    Rigidbody rb;


    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player").transform;

        nav = GetComponent<NavMeshAgent>();

        tagged = GetComponent<Tagged> ();

        anim = GetComponent<Animator>();

        p = menu.GetComponent<PauseManager>();

        rb = GetComponent<Rigidbody> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(p.paused)
        {
            nav.isStopped = true;
            anim.SetBool("IsMoving", false);
        }
        else{
            nav.isStopped = false;

            if(tagged.It)
            {
                nav.SetDestination(player.position);
            }
            else
            {
                nav.SetDestination(10*player.forward);
            }
            
            anim.SetBool("IsMoving", true);
        }

        
        
        
        
    }
}
