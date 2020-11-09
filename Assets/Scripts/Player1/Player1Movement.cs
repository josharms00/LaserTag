using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    // public variables
        public float speed = 6f;

        // private variables
        Vector3 movement;
        Animator anim;
        Rigidbody playerRigidBody;

        public GameObject menu;

        PauseManager p;


        // always is called regardless of if script is enabled
        void Awake()
        {
            anim = GetComponent<Animator>();
            playerRigidBody = GetComponent <Rigidbody> ();

            p = menu.GetComponent<PauseManager>();
        }

        // fires every physics update
        void FixedUpdate()
        {
            if(!p.paused)
            {
                // raw axis only has -1, 0, 1
                float h = Input.GetAxisRaw("Horizontal"); // a and d keys
                float v = Input.GetAxisRaw("Vertical"); // w and s keys

                Move(h, v);
                Animating(h, v);
            }
            
        }

        void Move (float h, float v)
        {
            movement.Set(h, 0f, v);

            // if moving diagonally then it would be faster than moving on one axis so we have to normalize
            // multiplied by delta time so every update it won't be crazy fast
            // delta time is the time since the last update
            movement = movement.normalized * speed * Time.deltaTime;

            // new position is current rigidbody plus new movement
            transform.Translate(movement, Space.Self);
        }

        void Animating(float h, float v)
        {
            bool moving = ( h != 0f || v != 0f );
            anim.SetBool("IsMoving", moving);
        }
}

