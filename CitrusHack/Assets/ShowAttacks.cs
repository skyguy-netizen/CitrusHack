using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAttacks : MonoBehaviour
{
    public GameObject AttackButtons;

    public void toggleAttacks() {
        print("test");
        if (!AttackButtons.active)
        {
            AttackButtons.SetActive(true);
        }
        else
            AttackButtons.SetActive(false);
    }
}
