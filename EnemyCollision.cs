using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // TODO: Problem 2: Call the Movement and Shoot functions.
    // Start is called before the first frame update

    // Problem 2
    void Start()
    {
        Movement();
        Shoot();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    void Movement ()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        
        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }
    
    
    void Shoot ()
    {
        if(Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            myStuff.bullets--;
        }
    }

    // TODO: Problem 3: Define a public class named Weapon. In the class, define 3 int variables for arrow, sword, and rocket.


    // Problem 3
    public class Weapons
    {
        public int arrow;
        public int sword;
        public int rocket;
    }
}