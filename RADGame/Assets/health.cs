using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthScript : MonoBehaviour
{
  

    int myHealth = 100;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }


    internal void takeDamage(int amountOfDamage)
    {
        myHealth -= amountOfDamage;
        if (myHealth <= 0)
        {
            Rigidbody myRigidBody = GetComponent<Rigidbody>();
            Destroy(myRigidBody);
            print("Im Dead!!");
        }

        print("You hurt me with " + amountOfDamage.ToString());
    }
}