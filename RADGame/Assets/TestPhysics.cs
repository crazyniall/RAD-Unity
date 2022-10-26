using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPhysics : MonoBehaviour
{
    Rigidbody ourRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    { 

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ourRigidbody.AddExplosionForce(1000,transform.position+ Vector3.down+ Vector3.back,2);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ourRigidbody.AddExplosionForce(500, transform.position + Vector3.left + Vector3.back, 2);
        }
    if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ourRigidbody.AddExplosionForce(500, transform.position + Vector3.right + Vector3.back, 2);
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");
    }

}
