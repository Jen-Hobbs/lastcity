using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building
{

    private int resource = 20;
    private int resourceType;
    private int position;
    private GameObject gameObject;

    public Building(int pos, GameObject g)
    {
        position = pos;
        gameObject = g;
    }
    public int build()
    {
        if (resource - 10 <= 0)
        {
            resource = 0;
            return resource;
        }
        resource -= 10;
        return 10;
    }
    public GameObject GetGameObject()
    {
        return gameObject;
    }
    public int getPosition()
    {
        return position;
    }

}
