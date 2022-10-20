using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeControl : MonoBehaviour
{
    float speed = 10f;
    float rotationSpeed = 90f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed * transform.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow ))
        {
            transform.position += speed * Vector3.up * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += speed * Vector3.down * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += speed * Vector3.left * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += speed * Vector3.right * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(transform.forward, 5f);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(transform.forward, -5f);

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(transform.right, 5f);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(transform.right, -5f);

        }
    }
}
