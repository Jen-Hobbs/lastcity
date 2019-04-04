using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildBuilding : MonoBehaviour
{
    [SerializeField]private GameObject building;
    [SerializeField] private int buildturns;
    private int counter;

    void Start()
    {
        counter = 0;
    }
    // Start is called before the first frame update
    public void countTurn()
    {
        if (counter == buildturns)
        {
            building = (GameObject) Instantiate(building, transform.position, Quaternion.identity);
            
            Destroy(this.gameObject);
        }
        counter++;
        
    }
}
