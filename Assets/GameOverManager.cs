using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Restarts the game
    public void Restart()
    {
        SceneManager.LoadScene("MainScene");
    }

    //Quits the game
    public void QuitGame()
    {
        Application.Quit();
    }
}
