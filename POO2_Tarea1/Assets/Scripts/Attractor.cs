﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    //Todo fue sacado del canal Brackeys de Youtube
    //https://youtu.be/Ouu3D_VHx9o
    const float G = 667.4f;

    public Rigidbody rb;

    public static List<Attractor> Attractors;

    private void FixedUpdate()
    {
        
        foreach (Attractor attractor in Attractors)
        {
            if (attractor != this)
            {
                Attract(attractor);
            } 
        }

    }

    void OnEnable()
    {
        if (Attractors == null)
        {
            Attractors = new List<Attractor>();
        }
        Attractors.Add(this);
    }

    private void OnDisable()
    {
        Attractors.Remove(this);
    }

    void Attract (Attractor objToAttract)
    {
        Rigidbody rbToAttract = objToAttract.rb;
        
        Vector3 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;
        if (distance == 0f)
        {
            return;
        }
        
        float forceMagnitude = G * (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
        Vector3 force = direction.normalized * forceMagnitude;

        rbToAttract.AddForce(force);
    }
}
