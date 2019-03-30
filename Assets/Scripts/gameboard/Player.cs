using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *Author: Nate
 *update: Jennifer
 **/
public static class Player
{
    
    public static int food { get; set; }
    public static int wood { get; set; }
    public static int stone { get; set; }
    public static int population { get; set; }

    static Player()
    {
        food = 100;
        wood = 100;
        stone = 50;
        population = 20;
    }
}
