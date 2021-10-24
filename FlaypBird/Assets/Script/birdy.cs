using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdy : MonoBehaviour
{

    public bool isDead;
    public float velocity = 1f;
    public  Rigidbody2D rb2D;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //havada kuþu zýplat
            rb2D.velocity = Vector2.up * velocity;
        }
        //if (Input.GetMouseButtonDow(0))
        //{
        //    rb2D.velocity = Vector2.vp * velocity;
        //}
    }
}
