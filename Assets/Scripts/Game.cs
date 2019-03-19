using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Tile[,] tiles;
    public Player player;
    public int turn;

    public Text foodText;
    public Text woodText;
    public Text stoneText;
    public Text popText;
    public Text turnText;

    // Start is called before the first frame update
    void Start()
    {
        player = new Player();
        turn = 1;

        foodText.text = "Food: " + player.food;
        woodText.text = "Wood: " + player.wood;
        stoneText.text = "Stone: " + player.stone;
        popText.text = "Population: " + player.population;
        turnText.text = "Turn: " + turn;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.food < 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        foodText.text = "Food: " + player.food;
        woodText.text = "Wood: " + player.wood;
        stoneText.text = "Stone: " + player.stone;
        popText.text = "Population: " + player.population;
        turnText.text = "Turn: " + turn;
    }

    //Takes a turn.
    public void TakeTurn()
    {
        turn++;
        player.food -= player.population;
    }
}
