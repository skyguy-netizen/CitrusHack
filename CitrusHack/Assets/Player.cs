using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using TMPro;

public class Player : MonoBehaviour
{
    public int health = 5;
    public int energy = 5;

    public GameObject basic;
    public GameObject special;
    public GameObject megaSpecial;
    public GameObject enemy;

    public Animator animator;

    public TMP_Text dialogue;

    public void takeDamage(int damage)
    {
        if (gameObject.name == "Baron Von Baron")
        {
            animator.Play("BaronAnimation", 0, 0.0f);
        }
        else
            animator.Play("TyHurt", 0, 0.0f);

        ManageMove.playerTurn = !ManageMove.playerTurn;
        if (damage == 2)
        {
            if (gameObject.name == "Baron Von Baron")
            {
                dialogue.gameObject.SetActive(true);
                dialogue.text = "Ty used axe slingin'! It did 2+ damage";
            }
            enemy.GetComponent<Player>().energy -= 2;
        }
        else
            if (damage == 4)
        {
            enemy.GetComponent<Player>().energy -= 5;
        }
        else
        {
            if (gameObject.name == "Baron Von Baron")
            {
                dialogue.gameObject.SetActive(true);
                dialogue.text = "Ty used swing n' slice!";
            }
        }
        health -= damage;
        if (enemy.GetComponent<Player>().energy < 5)
            enemy.GetComponent<Player>().energy += 1;
        if (health <= 0)
            print("game over");
    }

    public void heal() {
        health += 1;
        ManageMove.playerTurn = !ManageMove.playerTurn;
        if (gameObject.GetComponent<Player>().energy < 5)
            gameObject.GetComponent<Player>().energy += 1;
        if (gameObject.name == "Baron Von Baron")
        {
            dialogue.gameObject.SetActive(true);
            dialogue.text = "Baron healed! 1+ health";
        }
        else {
            dialogue.gameObject.SetActive(true);
            dialogue.text = "Ty healed! 1+ health";
        }
    }

    public void Update()
    {
        if (gameObject.name == "Baron Von Baron")
        {
            return;
        }
        if (gameObject.GetComponent<Player>().energy < 5)
        {
            megaSpecial.SetActive(false);
        }
        else
        {
            megaSpecial.SetActive(true);
        }


        if (gameObject.GetComponent<Player>().energy < 2)
        {
            special.SetActive(false);
        }
        else
        {
            special.SetActive(true);

        }
    }
}
