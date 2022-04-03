using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAttacks : MonoBehaviour
{
    public GameObject AttackButtons;

    public void toggleAttacks() {
        AttackButtons.SetActive(!AttackButtons.activeInHierarchy);
    }
}
