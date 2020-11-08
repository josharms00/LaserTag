using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CPUSight : MonoBehaviour
{
    public float fov = 110f;
    public bool playerInView;
    SphereCollider coll;
    GameObject player;
    NavMeshAgent nav;

    void Awake()
    {
        nav = GetComponent<NavMeshAgent> ();

        player = GameObject.FindGameObjectWithTag("Player");

        coll = GetComponent<SphereCollider>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInView = false;

            // get the vector between the player and CPU
            Vector3 dir = other.transform.position - transform.position;

            // find the angle between the CPU forward vector and the direction vector
            float angle = Vector3.Angle(dir, transform.forward);

            // if the angle is less than half of the fov then the player is in view
            if( angle < (fov / 2f) )
            {
                // now we need to detect if there are any objects in front of the player
                RaycastHit hit;

                if ( Physics.Raycast(transform.position + transform.up, dir.normalized, out hit, coll.radius) )
                {
                    if(hit.collider.gameObject == player)
                    {
                        playerInView = true;
                    }
                }
            }
        }
    }
}
