using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateButtonStatus : MonoBehaviour
{
    public GameObject Buttons1;
    public GameObject Buttons2;

    // Update is called once per frame
    void Update()
    {
        if (!ManageMove.playerTurn)
        {
            Buttons1.SetActive(false);
            Buttons2.SetActive(false);
        }
        else
            Buttons1.SetActive(true);
    }
}
