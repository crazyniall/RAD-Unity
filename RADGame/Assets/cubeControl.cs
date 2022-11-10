using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeControl : MonoBehaviour
{
    float speed = 10f;
    float turningSpeed = 90f;
    float rotation = 90f;

    Rigidbody ourRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponentInChildren<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ourRigidBody.AddExplosionForce(400, transform.position + Vector3.down, 3);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed * transform.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(transform.up, turningSpeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(transform.up, -turningSpeed * Time.deltaTime);

        }


        //if (Input.GetKey(KeyCode.UpArrow ))
        //{
        //    transform.position += speed * Vector3.up * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.position += speed * Vector3.down * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.position += speed * Vector3.left * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.position += speed * Vector3.right * Time.deltaTime;
        //}
        

        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.Rotate(transform.right, 5f);

        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.Rotate(transform.right, -5f);

        //}

    }
}
