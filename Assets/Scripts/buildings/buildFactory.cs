using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildFactory : buildBuilding
{
    /// <summary>
    /// sets cost to buld factory
    /// author : Jennifer Hobbs
    /// </summary>
    public buildFactory() : base()
    {
        foodCost = 10;
        woodCost = 10;
        stoneCost = 10;
    }
    /// <summary>
    /// takes costs away from player
    /// </summary>
    public override void build()
    {
        Player.food -= foodCost;
        Player.wood -= woodCost;
        Player.stone -= stoneCost;
    }
}
