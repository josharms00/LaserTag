﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUShootLasers : MonoBehaviour
{
    LineRenderer laserLine;

    Light laserLight;

    Ray shootRay = new Ray();
    RaycastHit shootHit;

    float effectsDisplayTime = 0.5f;

    int shootableMask;

    public float timeBetweenLasers = 0.15f;
    public float range = 100f;
    float timer;

    Tagged Playerhit;

    Tagged self;

    CPUSight sight;

    void Awake()
    {
        laserLine = GetComponent <LineRenderer> ();

        laserLight = GetComponent<Light> ();

        // Create a layer mask for the Shootable layer.
        shootableMask = LayerMask.GetMask ("Shootable");

        sight = GetComponentInParent<CPUSight> ();

        self = GetComponentInParent<Tagged> ();
    }

    // Update is called once per frame
    void Update()
    {
        // Add the time since Update was last called to the timer.
        timer += Time.deltaTime;

        if (timer >= timeBetweenLasers && Time.timeScale != 0)
        {
            // If the player is in sight and this character is it
            if (sight.playerInView && self.It)
            {
                // ... shoot the gun.
                Shoot();
            }
        }
        
        // If the timer has exceeded the proportion of timeBetweenBullets that the effects should be displayed for...
        if(timer >= (timeBetweenLasers * effectsDisplayTime))
        {
            // ... disable the effects.
            DisableEffects ();
        }
    }

    public void DisableEffects ()
    {
        // Disable the line renderer and the light.
        laserLine.enabled = false;
        laserLight.enabled = false;
    }

    void Shoot()
    {
        timer = 0;

        laserLine.enabled = true;
        laserLight.enabled = true;
        laserLine.SetPosition (0, transform.position);

        shootRay.origin = transform.position;
        shootRay.direction = transform.forward;

        // Perform the raycast against gameobjects on the shootable layer and if it hits something...
        if(Physics.Raycast (shootRay, out shootHit, range, shootableMask))
        {
            // Set the second position of the line renderer to the point the raycast hit.
            laserLine.SetPosition (1, shootHit.point);

            Playerhit = shootHit.collider.GetComponent <Tagged> ();

            if(Playerhit != null)
            {
                Playerhit.It = true;
                self.It = false;
            }
        }
        // If the raycast didn't hit anything on the shootable layer...
        else
        {
            // ... set the second position of the line renderer to the fullest extent of the gun's range.
            laserLine.SetPosition (1, shootRay.origin + shootRay.direction * range);
        }
    }

}