using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *Author: Jennifer Hobbs
 *instantiate building on mousedown for UI
 **/
public class createHouse : MonoBehaviour
{
    [SerializeField]
    private GameObject house;
    //public GameObject house2;
    Vector2 spawn;
    bool houseSpawned = true;

    bool objectspawned = false;
    // Start is called before the first frame update
     
    void Start()
    {
       
    }
    void Update()
    {

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spawn = new Vector2(Mathf.Round(mousePos.x / 2) * 2, Mathf.Round(mousePos.y));
    }
    void OnMouseDown()
    {
        house = (GameObject)Instantiate(house, spawn, Quaternion.identity);
    }


}

