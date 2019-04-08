using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Builds Lab object based on cost
/// Author: Jennifer Hobbs
/// </summary>
public class buildLab : buildBuilding
{
    /// <summary>
    /// sets cost of food wood and stone
    /// </summary>
    public buildLab() : base()
    {
        foodCost = 10;
        woodCost = 110;
        stoneCost = 10;
    }
    /// <summary>
    /// deletes cost of building resource
    /// </summary>
    public override void build()
    {
        Player.food -= foodCost;
        Player.wood -= woodCost;
        Player.stone -= stoneCost;
    }
}
