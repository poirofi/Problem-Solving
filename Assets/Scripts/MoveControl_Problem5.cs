using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl_Problem5 : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    // Bola mengikuti kursor
    public void cursor()
    {
        Vector2 follow = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, follow, 5 * Time.deltaTime);

    }
    private void Update()
    {
        cursor();
    }
}
