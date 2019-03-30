using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *Author: Nate
 *obsolete
 **/
public class Tile
{
    public int food;
    public int wood;
    public int stone;
    public Building building;
    public Worker worker;

    public Tile()
    {
        food = 0;
        wood = 0;
        stone = 0;
        building = null;
        worker = null;
    }

    //Selects this tile
    public void Select()
    {

    }

    //Harvest resources from tile
    public void Harvest()
    {

    }
    
    //Builds a building on this tile
    public void build()
    {

    }
}
