using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouv : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 9);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
