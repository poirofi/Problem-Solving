using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Problem7 : MonoBehaviour
{
    public Text ScoreText;
    private int Score;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        ScoreText.text = "Score : " + Score;
    }

    private void OnTriggerEnter2D(Collider2D Food)
    {
        if ( Food.tag == "Eat")
        {
            Score += 1;
            Destroy(Food.gameObject);
            ScoreText.text = "Score" + Score;
        }
    }
}
