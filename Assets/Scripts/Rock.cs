using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Material
{
    public Rock(int position, GameObject gameObject) : base(position, gameObject)
    {
    }
    public override string type()
    {
        return "rock";
    }
}
