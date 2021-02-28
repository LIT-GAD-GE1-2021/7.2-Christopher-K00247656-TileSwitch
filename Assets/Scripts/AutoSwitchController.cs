using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AutoSwitchController : MonoBehaviour
{
    private bool switchOff = true;
    public LevelManager levelManager;
    public GameObject tileGreen;
    public GameObject tileRed;

    void Awake()
    {

        turnOff();
    }

    public void turnOn()
    {
        switchOff = false;
        levelManager.SwitchTile();
    }

    public void turnOff()
    {
        switchOff = true;
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        this.turnOn();
    }

    void OnTriggerExit2D(Collider2D other)
    {

        this.turnOff();
    }
}

