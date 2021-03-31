using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    public GameManager manager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(tag == "PlayerBorder"){
            manager.AddEnemyScore(other);
            
        } else if(tag == "EnemyBorder"){
            manager.AddPlayerScore(other);
            
        }
        
        
    }
}
