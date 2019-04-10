using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *Author: Jennifer Hobbs
 *tree material
 **/
public class Food : Material
{
    public Food(int position, GameObject gameObject) : base(position, gameObject)
    {
    }

    public override string type()
    {
        return "food";
    }
}

