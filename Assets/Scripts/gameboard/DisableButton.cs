using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Disables a buttons based on resource availability and the cost it takes to build
/// </summary>
//https://answers.unity.com/questions/785174/newui-46-how-to-change-button-state-to-disable.html

public class DisableButton : MonoBehaviour
{
    private buildBuilding[] buildings;
    private buildBuilding house;
    private buildBuilding lab;
    private buildBuilding farm;
    private buildBuilding factory;
    public Button[] buttons;
    /// <summary>
    /// check all buttons and the cost of each house disabling the buttons when resources available are less then
    /// food availability
    /// TODO: check if you have to go through all buttons as this is in update mode
    /// </summary>
    void Start()
    {
        house = new buildHouse();
        lab = new buildLab();
        factory= new buildFactory();
        farm = new buildFarm();
        buildings = new buildBuilding[4];
        buildings[0] = house;
        buildings[1] = factory;
        buildings[2] = house;
        buildings[3] = lab;
    }
    void Update()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buildings[i].buildable() == false)
            {
                buttons[i].interactable = false;
            }
            else{
                buttons[i].interactable = true;
            }

           
        }
        }
}




