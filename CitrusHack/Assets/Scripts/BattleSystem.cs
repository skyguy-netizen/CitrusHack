using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState {START, PLAYERTURN, ENEMYTURN, WON, LOST}
public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    playerStatus playerStatus;
    enemyStatus enemyStatus;

    public Text dialogueText;
    public BattleState state;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }
    
    void SetupBattle()
    {
        GameObject playerGO = Instantiate(playerPrefab);
        playerStatus = playerGO.GetComponent<playerStatus>();
        GameObject enemyGO = Instantiate(enemyPrefab);
        enemyStatus = enemyGO.GetComponent<enemyStatus>();

        dialogueText.text = enemyStatus.unitName;
    }
}
