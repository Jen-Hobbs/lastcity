using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factory : Building
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public override void build()
    {
        Player.food -= 20;
        Player.wood -= 30;
        Player.stone -= 30;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
