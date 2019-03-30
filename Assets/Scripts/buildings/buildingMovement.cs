using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * https://stackoverflow.com/questions/1531695/round-to-nearest-five
 * https://www.youtube.com/watch?time_continue=5&v=D9ZU0mfukQE
 */
/**
*Author: Jennifer Hobbs
*move house around the map
**/
public class buildingMovement : MonoBehaviour
{
    [SerializeField] private GridLayout world;
    [SerializeField] private GameObject house;
    private Vector2 mousePos;
    // Start is called before the first frame update
    void Start()
    {

    }

    
    // Update is called once per frame
    void Update()
    {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(Mathf.Round(mousePos.x / 2) * 2, Mathf.Round(mousePos.y / 2) * 2);

       

    }
    
    void OnMouseDown()
    {
        Vector3 position = world.WorldToCell(transform.position);
        if (!buildinglist.containsBuilding(position))
        {
            house = (GameObject) Instantiate(house, transform.position, Quaternion.identity);
            buildinglist.addBuilding(position, house);
            Destroy(this.gameObject);
        }

    }

    
}
