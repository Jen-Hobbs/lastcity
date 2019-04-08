﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildLab : buildBuilding
{
    public buildLab() : base()
    {
        foodCost = 10;
        woodCost = 110;
        stoneCost = 10;
    }
    // Start is called before the first frame update
    public override void build()
    {
        Player.food -= foodCost;
        Player.wood -= woodCost;
        Player.stone -= stoneCost;
    }
}
