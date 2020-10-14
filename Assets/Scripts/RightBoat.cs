using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBoat : MonoBehaviour
{
    void Update()
    {
        if (this.gameObject.name == "fishing_boat_right")
        {
            this.gameObject.GetComponent<Rigidbody>().transform.Translate(-0.01f * transform.right);
        }
        if (this.gameObject.name == "fishing_boat_left")
        {
            this.gameObject.GetComponent<Rigidbody>().transform.Translate(0.01f * transform.right);
        }
        if (this.gameObject.name == "fishing_boat_up")
        {
            this.gameObject.GetComponent<Rigidbody>().transform.Translate(-0.01f * transform.right);
        }
        if (this.gameObject.name == "fishing_boat_down")
        {
            this.gameObject.GetComponent<Rigidbody>().transform.Translate(0.01f * transform.right);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.name == "light 1")
        {
            if (this.gameObject.name == "fishing_boat_right")
            {
                if (this.gameObject.transform.rotation.y * 360 > 357)
                {
                    if (PlayerMovment.button == true)
                    {
                        this.gameObject.transform.Rotate(-0.1f * transform.up);
                    }
                }
            }
            if (this.gameObject.name == "fishing_boat_left")
            {
                if (this.gameObject.transform.rotation.y * 360 > -30)
                {
                    if (PlayerMovment.button == true)
                    {
                        this.gameObject.transform.Rotate(-0.1f * transform.up);
                    }
                }
            }
            if (this.gameObject.name == "fishing_boat_up")
            {
                if (this.gameObject.transform.rotation.y * 360 > 357)
                {
                    if (PlayerMovment.button == true)
                    {
                        this.gameObject.transform.Rotate(-0.1f * transform.up);
                    }
                }
            }
            if (this.gameObject.name == "fishing_boat_down")
            {
                if (this.gameObject.transform.rotation.y * 360 > -30)
                {
                    if (PlayerMovment.button == true)
                    {
                        this.gameObject.transform.Rotate(-0.1f * transform.up);
                        Debug.Log(this.gameObject.transform.rotation.y * 360);
                    }
                }
            }
        }
    }
}
