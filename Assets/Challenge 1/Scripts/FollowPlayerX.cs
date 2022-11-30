﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(50.0f, 0, 0);

    // Update is called once per frame
    void Update()
    {
        if (plane != null)
        {
            transform.position = plane.transform.position + offset;
        }
        
    }
}
