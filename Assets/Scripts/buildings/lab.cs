using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab : Building
{
    public override void build()
    {
        Player.food -= 20;
        Player.wood -= 30;
        Player.stone -= 30;
    }
    
}
