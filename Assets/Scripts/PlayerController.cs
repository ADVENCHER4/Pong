using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 mousePose;
    public float limitPose = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            mousePose = Input.mousePosition;
            mousePose = Camera.main.ScreenToWorldPoint(mousePose);
            mousePose.x = transform.position.x;
            mousePose.y = Mathf.Clamp(mousePose.y, -limitPose, limitPose);
            transform.position = mousePose;
        }
    }
}
