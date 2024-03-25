using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        gameOver.SetActive(false);
        Game.Instance.input.Disable();
    }

    public void startgame()
    { 
        mainMenu.SetActive(false);
        Game.Instance.input.Enable();

    }

    public void GameOver() {
        gameOver.SetActive(true);
        Game.Instance.input.Disable();
    }
    
    public void Restart()
    {
        gameOver.SetActive(false);
        Game.Instance.input.Disable();
    }
}
