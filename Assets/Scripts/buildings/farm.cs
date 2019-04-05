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

    }

    public override void gather()
    {
        Player.food += 5;
    }

}
