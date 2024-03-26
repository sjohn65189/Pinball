using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject gameOver;
    public GameObject gameHUD;
    public GameObject options;
    public Game game;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        gameOver.SetActive(false);
        gameHUD.SetActive(false);
        options.SetActive(false);
        Game.Instance.input.Disable();
    }

    public void startgame()
    { 
        mainMenu.SetActive(false);
        gameHUD.SetActive(true);
        Game.Instance.input.Enable();

    }

    public void GameOver() {
        gameOver.SetActive(true);
        gameHUD.SetActive(false);
        Game.Instance.input.Disable();
    }
    
    public void Restart()
    {
        gameOver.SetActive(false);
        game.resetScore();
        gameHUD.SetActive(true);

        Game.Instance.input.Enable();
    }
    public void Settings()
    {
        mainMenu.SetActive(false);
        options.SetActive(true);
    }
    public void Exit()
    {
        options.SetActive(false);
        mainMenu.SetActive(true);
    }    
}
