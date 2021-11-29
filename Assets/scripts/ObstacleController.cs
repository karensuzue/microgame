using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public int health;   
    private void Start()
    {
        health = 100;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet") 
        {
            health -= 10;
            
            if (health <= 0) 
            { 
                // Destroys when health is 0 
                Destroy(gameObject); 
            }
        }
    }
}
