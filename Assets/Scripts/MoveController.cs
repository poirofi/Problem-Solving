using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        Movement();
    }

    // untuk pergerakan bolanya ke arah random dengan kecepatan konstan
    void Movement()
    {
        float x = Random.Range(-100, 100);
        float y = Random.Range(-100, 100);

        rigidBody.AddForce(new Vector2(x, y).normalized * 50);
    }
}
