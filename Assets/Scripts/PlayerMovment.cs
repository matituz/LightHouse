using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    float angle,rot,time, time2;
    public Light light1, light2;
    Vector3 dir;
    public static bool button;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            button = true;
        }
        if(Input.GetMouseButtonUp(0))
        {
            button = false;
            light1.intensity = 0;
            light2.intensity = 0;
            time = 0;
        }
        if(button == true)
        {
            time += Time.deltaTime;
            dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            light1.intensity = time * 2;
            light2.intensity = time / 2;
            if(time > 1)
            {
                light1.intensity = 2;
                light2.intensity = 1f;
            }
        }
        this.transform.rotation = Quaternion.AngleAxis(-angle, Vector3.up);
    }
}
