using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public float speed = 1f;
    public GameObject target;// Start is called before the first frame update
    void Start()
    {
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Move(){
        if(target.transform.position.y > transform.position.y){
            transform.Translate(0, 0.5f, 0);
        } else if(target.transform.position.y < transform.position.y){
            transform.Translate(0, -0.5f, 0);
        }
        Invoke("Move", speed);
    }
}
