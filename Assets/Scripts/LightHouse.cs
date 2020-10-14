using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHouse : MonoBehaviour
{
    public GameObject Fire, Text;
    float time = 3;

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "fishing_boat_left" || other.name == "fishing_boat_right" || other.name == "fishing_boat_up" || other.name == "fishing_boat_down")
        {
            Destroy(other.gameObject);
            Fire.SetActive(true);
            Text.SetActive(true);
        }
    }
}
