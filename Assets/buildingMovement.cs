using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * https://stackoverflow.com/questions/1531695/round-to-nearest-five
 * https://www.google.com/search?client=firefox-b-d&q=placing+object+on+grid+unity#kpvalbx=1
 */
public class buildingMovement : MonoBehaviour
{
    private Vector2 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       // transform.position = new Vector2(Mathf.Round(mousePos.x/2)*2, Mathf.Round(mousePos.y/2)*2);

    }
}
