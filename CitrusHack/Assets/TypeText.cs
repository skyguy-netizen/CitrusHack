using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypeText : MonoBehaviour
{
    public TMP_Text text1;
    public GameObject ButtonList;
    public GameObject enemy;

    void Update() {
        if (Input.GetKeyDown("space")) {
            if (text1.text == "Baron is thinking about his next move...")
            {
                text1.text = "";
                enemy.GetComponent<BaronMove>().MakeMove();
            }

            text1.text = "";

            ButtonList.SetActive(true);
        }
    }
}
