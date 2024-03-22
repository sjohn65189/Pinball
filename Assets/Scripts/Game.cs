using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [HideInInspector] public Input input;
    public Score score;
    public Ball ball;

    public static Game Instance
    { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        input = new Input();
        input.Enable();
        Instance = this;
    }



    // Update is called once per frame
    void Update()
    {
        
        if(input.Actions.LaunchBall.WasReleasedThisFrame())
        {
            ball.Launch();
        }
    }

    public void AddScore(int amount)
    {
        score.AddScore(amount);
    }
}
