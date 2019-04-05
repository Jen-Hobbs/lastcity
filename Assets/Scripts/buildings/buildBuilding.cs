using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class buildBuilding : MonoBehaviour
{

    [SerializeField]private GameObject building;
    [SerializeField] private int buildturns;
    private int counter;
    internal int foodCost;
    internal int woodCost;
    internal int stoneCost;
    void Start()
    {
        build();
        counter = 0;
    }
    public abstract void build();
    public bool buildable()
    {
        if (foodCost > Player.food || woodCost > Player.wood || stoneCost > Player.stone)
        {
            return false;
        }
        return true;
    }
    // Start is called before the first frame update
    public void countTurn()
    {
        if (counter == buildturns)
        {
            building = (GameObject) Instantiate(building, transform.position, Quaternion.identity);
            
            Destroy(this.gameObject);
        }
        counter++;
        
    }
}
