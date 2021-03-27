using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyerScript : MonoBehaviour
{
    public Text playerScore;
    int scorePlayer;
    public Text enemyScore;
    int scoreEnemy;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(tag == "EnemyBorder"){
            scoreEnemy++;
            enemyScore.text = scoreEnemy.ToString();
        } else if(tag == "PlayerBorder"){
            scorePlayer++;
            playerScore.text = scorePlayer.ToString();
        }
        other.transform.position = new Vector2(0,0);
        //  TODO: переделать обновление текста через менеджер, добавить задержку перед рестартом
    }
}
