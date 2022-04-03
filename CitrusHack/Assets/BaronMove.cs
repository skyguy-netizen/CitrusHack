using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaronMove : MonoBehaviour
{
    public GameObject enemy;
    // Update is called once per frame
    void Update()
    {
        if (!ManageMove.playerTurn) {
            MakeMove();
        }
    }

    private void MakeMove() {
        for (int i = 0; i < 1000; i++) { }
        print("test");
        //ManageMove.playerTurn = !ManageMove.playerTurn;
    }
}
