using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 5;
    public int energy = 5;

    public GameObject basic;
    public GameObject special;
    public GameObject megaSpecial;
    public GameObject enemy;

    public void takeDamage(int damage)
    {
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
            print("gake over");
    }

    public void attack(int attackNum)
    {
        //Swing n' Slice (1 dmg, 0 energy)
        //Axe-slingin (2 dmg, 2 energy)
        //Axe-nado (4 dmg, 5 energy)

        if (attackNum == 2)
        {
            print("test");
            gameObject.GetComponent<Player>().energy -= 2;
            enemy.GetComponent<Player>().health -= 2;
            return;
        }

        else if (attackNum == 4)
        {
            gameObject.GetComponent<Player>().energy -= 5;
            enemy.GetComponent<Player>().health -= 4;
            return;
        }
        else
        {
            enemy.GetComponent<Player>().health -= 1;
            return;
        }

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
