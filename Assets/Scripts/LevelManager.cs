using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public static LevelManager instance;

    public bool doorState;
    public GameObject tileGreen;
    public GameObject tileRed;
    public bool redOn = false;
    public bool greenOn = true;

    private void Awake()
    {
        instance = this;
        doorState = false;
    }


    public void GreenOff()
    {
        tileGreen.SetActive(false);
        tileRed.SetActive(true);
    }

    public void RedOff()
    {
        tileGreen.SetActive(true);
        tileRed.SetActive(false);
    }

    public void SwitchTile()
    {
        if (greenOn == true)
        {
            greenOn = false;
        }
        else
        {
            greenOn = true;
        }

        if (greenOn == true)
        {
            RedOff();
        }
        else
        {
            GreenOff();
        }
    }
}

