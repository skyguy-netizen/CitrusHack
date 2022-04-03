using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BaronMove : MonoBehaviour
{
    public GameObject enemy;
    public TMP_Text dialogue;
    // Update is called once per frame
    void Update()
    {
        if (!ManageMove.playerTurn && dialogue.text == "") {
            dialogue.text = "Baron is thinking about his next move...";
        }
    }

    public void MakeMove() {
        if (gameObject.GetComponent<Player>().health < 3)
            gameObject.GetComponent<Player>().heal();
        else
        { 
            int[] values = new int[]{1, 2, 4};
            int randomNumber = 0;
            if (gameObject.GetComponent<Player>().energy < 2)
                randomNumber = Random.Range(0, 1);
            else
                if (gameObject.GetComponent<Player>().energy < 3)
                randomNumber = Random.Range(0, 2);
            else
                    if (gameObject.GetComponent<Player>().energy < 5)
                        randomNumber = Random.Range(0, 3);
            enemy.GetComponent<Player>().takeDamage(values[randomNumber]);
        }
    }
}
