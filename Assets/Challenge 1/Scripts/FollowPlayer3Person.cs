using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer3Person : MonoBehaviour
{
    
    public GameObject plane;
    private Vector3 offset = new Vector3(0f, 3.0f, -8.0f);

    // Update is called once per frame
    void Update()
    {
        if (plane != null)
        {
            transform.position = plane.transform.position + offset;
        }
    }
}
