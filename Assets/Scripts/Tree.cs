using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *Author: Jennifer Hobbs
 *tree material
 **/
public class tree : Material{
    public tree(int position, GameObject gameObject) : base(position, gameObject)
    {
    }

    public override string type()
    {
        return "tree";
    }
}
