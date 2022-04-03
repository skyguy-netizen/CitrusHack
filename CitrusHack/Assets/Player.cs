using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Player : MonoBehaviour
{
    public int health = 5;
    public int energy = 5;

    public GameObject basic;
    public GameObject special;
    public GameObject megaSpecial;
    public GameObject enemy;

    public Animator animator;

    public void takeDamage(int damage)
    {
        animator.Play("BaronAnimation", 0, 0.0f);
        ManageMove.playerTurn = !ManageMove.playerTurn;
        if (damage == 2)
        {
            enemy.GetComponent<Player>().energy -= 2;
        }
        else
            if(damage == 4)
            {
            enemy.GetComponent<Player>().energy -= 5;
            }
        health -= damage;
        if (health <= 0)
            print("game over");
    }

    public void heal() {
        health += 1;
        ManageMove.playerTurn = !ManageMove.playerTurn;
    }

    public void Update()
    {
        if (gameObject.name == "Baron Von Baron")
        {
            return;
        }
        if (energy < 5)
        {
            megaSpecial.SetActive(false);
        }
        else
        {
            megaSpecial.SetActive(true);
        }


        if (energy < 2)
        {
            megaSpecial.SetActive(false);
        }
        else
        {
            megaSpecial.SetActive(true);

        }
    }
}
