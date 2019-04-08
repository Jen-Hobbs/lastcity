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
        foodCost = 10;
        woodCost = 10;
        stoneCost = 10;
    }
    /// <summary>
    /// takes food, stone and wood away from player when build building is instantiated
    /// </summary>
    public override void build()
    {
        Player.food -= foodCost;
        Player.wood -= woodCost;
        Player.stone -= stoneCost;
    }
}
