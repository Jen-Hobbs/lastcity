using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Material
{
    public Rock(int position) : base(position)
    {
    }
    public override string type()
    {
        return "rock";
    }
}
