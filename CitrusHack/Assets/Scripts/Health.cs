using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // [SerializeField] private int health = 5;

    // private int MAX_HEALTH = 5;
    private const int MAX_HEALTH = 5;
    private int currentHealth;

    void Start()
    {
        currentHealth = 5;
    }

    
    void Update()
    {
        for (int i = 0; i < currentHealth; i++){
            
        }
    }
}
