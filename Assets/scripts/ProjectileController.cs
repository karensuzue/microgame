using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//using static ProjectileActions;

public class ProjectileController : MonoBehaviour
{
    public GameObject projectile; //projectile prefab
    private InputAction movement;

    private GameObject bullet;
    private float speed = 5f;
    
    private void OnFire() 
    {
        bullet = Instantiate(projectile, transform.position, new Quaternion());
        bullet.GetComponent<Rigidbody>().AddForce(new Vector3 (0, 0, speed), ForceMode.Impulse);  
    }
}


