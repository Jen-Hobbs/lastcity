using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : Material{
    public tree(int position) : base(position)
    {
    }

    public override string type()
    {
        return "tree";
    }
}
