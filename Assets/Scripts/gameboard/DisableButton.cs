using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//https://answers.unity.com/questions/785174/newui-46-how-to-change-button-state-to-disable.html

public class DisableButton : MonoBehaviour
{
    private buildBuilding building;
    public Button button;
    void Start()
    {
        building = new buildHouse();
    }
    void Update()
    {
            if (building.buildable() == false)
            {
                button.interactable = false;
            }
            else{
                button.interactable = true;
            }
        }
}




