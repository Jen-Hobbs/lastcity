using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//https://answers.unity.com/questions/785174/newui-46-how-to-change-button-state-to-disable.html

public class DisableButton : MonoBehaviour
{
    public Transform button;
    public GameObject buildingType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //If space is pressed, and the button is currently interactable, make it so its not interactable
            if (button.GetComponent<Button>().IsInteractable() == true)
            {
                button.GetComponent<Button>().interactable = false;
            }
            else //Else make it interactable
            {
                button.GetComponent<Button>().interactable = true;
            }

        }

    }

}

