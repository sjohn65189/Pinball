using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void restart()
    {
        mainMenu.SetActive(true);
        gameOver.SetActive(false);
    }
}
