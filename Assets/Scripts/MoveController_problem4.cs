using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController_problem4 : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        transform.Translate(
            Input.GetAxis("Horizontal") * speed * Time.deltaTime,
            Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f);
    }
}
