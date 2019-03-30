using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *Author: Jennifer Hobbs
 *initial farm class
 **/
public class farm : Building
{

    farm() : base()
    {
        foodCost = 10;
        woodCost = 10;
        stoneCost = 10;
    }
    // Start is called before the first frame update
    public override void build()
    {
        Player.food -= foodCost;
        Player.wood -= woodCost;
        Player.stone -= stoneCost;
    }
    public override void gather()
    {
        Player.food += 5;
    }

}
