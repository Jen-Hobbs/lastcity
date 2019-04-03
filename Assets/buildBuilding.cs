using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildBuilding : MonoBehaviour
{
    [SerializeField]private GameObject building;
    private int counter;

    void Start()
    {
        counter = 0;
    }
    // Start is called before the first frame update
    void countTurn()
    {
        if (counter == 3)
        {
            building = (GameObject) Instantiate(building, transform.position, Quaternion.identity);
            
            Destroy(this.gameObject);
        }
        counter++;
        
    }
}
