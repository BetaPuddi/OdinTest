using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public static BattleManager instance;
    public PlayerParty playerParty;
    public GameObject playerPrefab;
    public EnemyParty enemyParty;
    public GameObject enemyPrefab;

    private void Awake()
    {
        instance = this;
    }
    public void SetPlayerParty(PlayerParty playerParty)
    {
        this.playerParty = playerParty;
        CreatePlayerPrefabs();
    }
    public void CreatePlayerPrefabs()
    {
        foreach (Entity player in playerParty.partyMembers)
        {
            //GameObject playerCharacter = Instantiate(playerPrefab, )
        }
    }
    public void SetEnemyParty(EnemyParty enemyParty)
    {
        this.enemyParty = enemyParty;
        CreateEnemyPrefabs();
    }
    public void CreateEnemyPrefabs()
    {

    }
}
