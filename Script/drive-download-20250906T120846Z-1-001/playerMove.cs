using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    //Variable used to set the movement speed of the player
		public int runSpeed = 5;
		//variable used to hold the horizontal value
		public float horizontal;
		//variable used to hold the vertical value
		public float vertical;
        public float shootingInterval = 0.5f; // Time between shots
        private bool Shoot = false; 
        public GameObject projectilePrefab; // Assign your projectile prefab in the inspector
        public Transform firePoint; // Assign the point from where the projectile will be fired
        private float nextShootTime = 0f;
		
		void Update()
		{
			//check if the user is pressing Horizontal inputs
			horizontal = Input.GetAxis("Horizontal");
			//checkif the user is pressing Vertical inputs
			vertical = Input.GetAxis("Vertical");

            if (Input.GetKeyDown(KeyCode.I))
            {
                Shoot = true;
            }

            if (Input.GetKeyUp(KeyCode.I))
            {
                Shoot = false;
            }

            if (Shoot && Time.time >= nextShootTime)
            {
                willShoot();
                nextShootTime = Time.time + shootingInterval;
            }
		}
		
		void FixedUpdate()
		{
			//Set the value vector movement of the player depending on the user input
			Vector3 movement = new Vector3(horizontal * runSpeed, 0.0f, vertical * runSpeed);
			//move the player to the set vector location according the movement value
			transform.position = transform.position + movement * Time.deltaTime;
		}

         void willShoot()
    {
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        // Add any additional logic here (like adding force to the projectile)
    }

}

