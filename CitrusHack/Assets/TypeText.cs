using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypeText : MonoBehaviour
{
    public TMP_Text text1;
    void Update() {
        if (Input.GetKeyDown("space")) {
            text1.text = "";
        }
    }
}
