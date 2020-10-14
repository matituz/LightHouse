using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameObject Win;
    int points = 0;
    private void OnTriggerExit(Collider other)
    {
        if(other.name == "fishing_boat_left")
        {
            points++;
            if (points == 2)
            {
                WinGame();
            }
        }
        if (other.name == "fishing_boat_right")
        {
            points++;
            if (points == 2)
            {
                WinGame();
            }
        }
    }
    void WinGame()
    {
        Win.SetActive(true);
    }
}
