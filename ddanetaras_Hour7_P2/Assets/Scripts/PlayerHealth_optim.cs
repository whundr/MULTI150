using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth_optim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health = 1004;
        float poisonDamage = 125.5f;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        while (health > 0)
        {
            health -= poisonDamage;
            Debug.Log(health);
        }
        Debug.Log("Player is Dead!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
