using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Author Jennifer Hobbs
/// Instantiat building on mouse down for UI
/// </summary>

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
    /// <summary>
    /// creates house to be moved around the map
    /// </summary>
    void Update()
    {

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spawn = new Vector2(Mathf.Round(mousePos.x / 2) * 2, Mathf.Round(mousePos.y));
    }
    /// <summary>
    /// spawns an unbuilt house on mouse click
    /// </summary>
    void OnMouseDown()
    {
        house = (GameObject)Instantiate(house, spawn, Quaternion.identity);
    }


}

