using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI txt;
    private int currentScore;
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<TextMeshProUGUI>();
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Score\n" + currentScore.ToString();
    }


    public void AddScore(int amount)
    {
        currentScore += amount;
    }
}
