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
    }

    public void startgame()
    { 
        mainMenu.SetActive(false);
       
    }

    public void GameOver() {
        gameOver.SetActive(true);
    }
    
    public void Restart()
    {
        gameOver.SetActive(false);
        mainMenu.SetActive(true);
    }
}
