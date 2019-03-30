using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class house : Building
{
    // Start is called before the first frame update
    public override void build()
    {
        Player.food -= 20;
        Player.wood -= 30;
        Player.stone -= 30;
    }
}
