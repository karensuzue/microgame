using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public int health;  
    public bool clicked;

    private void Start()
    {
        health = 100;
        clicked = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet") 
        {
            health -= 10;
            clicked = true;
        }
    }
}
