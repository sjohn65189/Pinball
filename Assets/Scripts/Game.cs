using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [HideInInspector] public PinballInput input;
    public Ball ball;


    public static Game Instance
    { get; private set; }

    public int CScore { get; private set; }
    public int HScore { get; private set; }


    // Start is called before the first frame update
    private void Awake()
    {
        input = new PinballInput();
        input.Enable();
        Instance = this;
    }

    private void Start()
    {
        HScore = PlayerPrefs.GetInt(Consts.PlayerPrefs.HIGHSCORE, 0);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt(Consts.PlayerPrefs.HIGHSCORE, HScore);
    }

    public void resetScore()
    {
        CScore = 0;
    }

    public void AddScore(int amount)
    {
        CScore += amount;
        if (CScore > HScore)
        {
            HScore = CScore;
        }
    }
}
