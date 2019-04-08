using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// https://stackoverflow.com/questions/1531695/round-to-nearest-five
/// https://www.youtube.com/watch?time_continue=5&v=D9ZU0mfukQE
/// Author Jennifer Hobbs
/// Allows building to move across the map
/// TODO: add game object to add building of actuall buildt object rather then unbuilt game object?
/// </summary>

public class buildingMovement : MonoBehaviour
{
    
    [SerializeField] private GridLayout world;
    [SerializeField] private GameObject house;
    private Vector2 mousePos;


    /// <summary>
    /// From camera main at a sceen to world point transform curser to only follow grid pattern
    /// if mouse is clicked building is addded to list and an unbuilt game object is added to game
    /// </summary>
    // Update is called once per frame
    void Update()
    {
        
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(Mathf.Round(mousePos.x / 2) * 2, Mathf.Round(mousePos.y / 2) * 2);

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = world.WorldToCell(transform.position);
            Vector2 mouse = Input.mousePosition;
            
            if (mouse.y < 200)
            {
                Destroy(this.gameObject);
            }
            else if(!buildinglist.containsBuilding(position) && !resourceslist.containsResource(position))
            {
                
                house = (GameObject) Instantiate(house, transform.position, Quaternion.identity);
                buildinglist.addBuilding(position, house);
                Destroy(this.gameObject);
            }
 
        }

    }
 
}
