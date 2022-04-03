using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulesList : MonoBehaviour
{
    public GameObject[] enemyHealthCapsules;
    public GameObject[] playerEnergyCapsules;
    public GameObject player;
    public GameObject enemy;

    void Update() {
        for (int i = 0; i < 5; i++) {
            if (i < enemy.GetComponent<Player>().health)
            {
                enemyHealthCapsules[i].SetActive(true);
            }
            else
            {
                enemyHealthCapsules[i].SetActive(false);
            }
        }

        for (int j = 0; j < 5; j++) {
            if (j < player.GetComponent<Player>().energy)
            {
                playerEnergyCapsules[j].SetActive(true);
            }
            else
                playerEnergyCapsules[j].SetActive(false);
        }
    }
}
