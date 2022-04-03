using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulesList : MonoBehaviour
{
    public GameObject[] capsules;
    public GameObject player;
    public GameObject enemy;

    void Update() {
        for (int i = 0; i < 5; i++) {
            if (i < player.GetComponent<Player>().health)
                capsules[i].SetActive(true);
            else
                capsules[i].SetActive(false);
        }
    }
}
