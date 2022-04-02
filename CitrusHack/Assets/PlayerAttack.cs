using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    private int damage = 1;
    private OnButtonPress(GameObject victim)
    {
        if (victim.GetComponent<Health>() != 0)
        {
            Health health = victim.GetComponent<Health>();
            health.Damage(damage);
        }
    }
    // // Update is called once per frame

}
