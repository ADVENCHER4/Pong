using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text playerScore;
    int scorePlayer;
    public Text enemyScore;
    int scoreEnemy;
    public GameObject restartField;
    public EnemyMover enemySpeed;
    int speedUp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddPlayerScore(Collider2D ball){
        scorePlayer++;
        speedUp++;
        if(speedUp == 5){
            speedUp = 0;
            enemySpeed.speed -= 0.1f;
        }
        playerScore.text = scorePlayer.ToString();
        ball.transform.position = new Vector2(0,0);
        StopGame();
    }
     public void AddEnemyScore(Collider2D ball){
        scoreEnemy++;
        enemyScore.text = scoreEnemy.ToString();
        ball.transform.position = new Vector2(0,0);
        StopGame();
    }
    void StopGame(){
        Time.timeScale = 0;
        restartField.SetActive(true);
    }
    public void StartGame(){
       Time.timeScale = 1;
       restartField.SetActive(false); 
    }
}
