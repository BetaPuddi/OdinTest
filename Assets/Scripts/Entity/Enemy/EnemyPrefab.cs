using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyPrefab : MonoBehaviour
{
    public TextMeshProUGUI enemyNameText;
    public TextMeshProUGUI enemyHealthText;
    public Enemy enemy;

    private void Start()
    {
        enemyNameText.text = enemy.entityName;
    }
    private void Update()
    {
        enemyHealthText.text = enemy.currentHealth.ToString() + " / " + enemy.maxHealth.ToString();
    }
}
