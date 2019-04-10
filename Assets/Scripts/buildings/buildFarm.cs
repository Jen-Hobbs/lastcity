using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// building a farm
/// Author: Jennifer Hobbs
/// </summary>
public class buildFarm : buildBuilding
{
    /// <summary>
    /// instantiates cost of building a farm
    /// </summary>
    public buildFarm() : base()
    {

        woodCost = 100;

    }
    /// <summary>
    /// takes food, stone and wood away from player when build building is instantiated
    /// </summary>
    public override void build()
    {
        Player.wood -= woodCost;
    }

    public override void countTurn()
    {
        if (counter == buildturns)
        {
            building = (GameObject)Instantiate(building, transform.position, Quaternion.identity);
            Debug.Log("Food Yield: " + Player.foodYield);
            Destroy(this.gameObject);
        }
        counter++;

    }
}
