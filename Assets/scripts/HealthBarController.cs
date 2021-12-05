using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    private Image healthBar;
    // private float healthMax = 0;
    private float healthCurrent;
    private int obstacleCount;

    [SerializeField] private GameObject winTextObj;
    
    void Start()
    {
        winTextObj.SetActive(false);
        healthBar = GetComponent<Image>();
        healthBar.fillAmount = 0;

        // healthCurrent = healthMax;
    }

    /*void Update()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Enemy");
        obstacleCount = obstacles.Length;

        float total = 0;
        for (int i = 0; i < obstacleCount; i++) 
        {
            ObstacleController obctrl = obstacles[i].GetComponent<ObstacleController>();
            total += obctrl.health;
        }

        healthCurrent = total;
        healthBar.fillAmount = healthCurrent / healthMax;

        if (healthCurrent == 0) 
        {
            winTextObj.SetActive(true);
        }
    }*/

    void Update()
    {
        
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Enemy");
        obstacleCount = obstacles.Length;
        
        for (int i = 0; i < obstacleCount; i++) 
        {
            ObstacleController obctrl = obstacles[i].GetComponent<ObstacleController>();
            //healthMax += obctrl.health;  
            if (obctrl.clicked == true)
            {
                healthCurrent = obctrl.health;
                healthBar.fillAmount = healthCurrent / 100;
                obctrl.clicked = false;

                if (healthCurrent == 0) {
                    Destroy(obctrl.gameObject);
                }
 
                
            }
        }        

        if (obstacleCount == 0) 
        {
            winTextObj.SetActive(true);
        }


    }


}
