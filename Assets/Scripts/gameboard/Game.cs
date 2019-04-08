using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
   

    public map map;
    public int turn;

    public Text foodText;
    public Text woodText;
    public Text stoneText;
    public Text popText;
    public Text turnText;

    // Start is called before the first frame update
    void Start()
    {
       
        turn = 1;

        foodText.text = "Food: " + Player.food;
        woodText.text = "Wood: " + Player.wood;
        stoneText.text = "Stone: " + Player.stone;
        popText.text = "Population: " + Player.population;
        turnText.text = "Turn: " + turn;
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.food < 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        foodText.text = "Food: " + Player.food;
        woodText.text = "Wood: " + Player.wood;
        stoneText.text = "Stone: " + Player.stone;
        popText.text = "Population: " + Player.population;
        turnText.text = "Turn: " + turn;
    }

    //Takes a turn.
    public void TakeTurn()
    {
        turn++;
        Player.food -= Player.population;
        buildingTurn();
        
        
        foreach (Vector3 v in map.people)
        {
            if (buildinglist.containsBuilding(v))
            {
                buildBuilding();
            }
            if(map.materials.ContainsKey(v))
            {
                
                map.materials[v].farm();
                if(map.materials[v].type() == "tree")
                {
                    Player.wood += 10;
                }
                if (map.materials[v].type() == "rock")
                {
                    Player.stone += 10;
                }

                if(map.materials[v].getResource() == 0)
                {
                    
                    Destroy(map.materials[v].GetGameObject());
                    map.materials.Remove(v);
                }
            }
        }
    }
    /// <summary>
    /// checks each building that to gather food
    /// TODO: base it on list and not TAG?
    /// </summary>
    private void buildingTurn()
    {
        GameObject[] house = GameObject.FindGameObjectsWithTag("house");
        foreach(GameObject i in house)
        {
            i.GetComponent<Building>().gather();
        }
    }
    /// <summary>
    /// work on building building if player is on the building at the end of the turn
    /// </summary>
    private void buildBuilding()
    {
        GameObject[] house = GameObject.FindGameObjectsWithTag("unbuilt");
        foreach (GameObject i in house)
        {
            i.GetComponent<buildBuilding>().countTurn();
        }
    }
    
}
