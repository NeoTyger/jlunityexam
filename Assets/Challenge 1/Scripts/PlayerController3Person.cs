using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3Person : MonoBehaviour
{
    
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
    }
}
