using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *Author: Jennifer Hobbs
 *initial farm class
 **/
public class farm : Building
{
    // Start is called before the first frame update
    public farm():base()
    {

    }

    public override void build()
    {
        Player.food -= 20;
        Player.wood -= 30;
        Player.stone -= 30;
    }
    public override void gather()
    {
        Player.food += 5;
    }
}
