using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangingScript : MonoBehaviour
{

    Light lt;
    public Light leftLight;
    public Light rightLight;
    public List<Color> colors;
    
    void Start()
    {
        lt = GetComponent<Light>();
        //StartCoroutine(updateColor());
        //lt.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha1)) {
            if(colors.Count > 0 && colors[0] != null) {
                lt.color = colors[0];
            }
        }

        if(Input.GetKey(KeyCode.Alpha2)) {
            if(colors.Count > 1 && colors[1] != null) {
                lt.color = colors[1];
            }
        }

        if(Input.GetKey(KeyCode.Alpha3)) {
            if(colors.Count > 2 && colors[2] != null) {
                lt.color = colors[2];
            }
        }

        if(Input.GetKey(KeyCode.Alpha4)) {
            if(colors.Count > 3 && colors[3] != null) {
                lt.color = colors[3];
            }
        }

        if(Input.GetKey(KeyCode.Alpha5)) {
            if(colors.Count > 3 && colors[3] != null) {
                lt.color = colors[4];
            }
        }

        if(Input.GetKey(KeyCode.Alpha6)) {
            if(colors.Count > 3 && colors[3] != null) {
                lt.color = colors[5];
            }
        }

        if(Input.GetKey(KeyCode.J)) {
            if (leftLight != null) {
                 StartCoroutine(updateLight(leftLight, this.lt.color));
            }
        }

        if(Input.GetKey(KeyCode.K)) {
            if(rightLight != null) {
                StartCoroutine(updateLight(rightLight, this.lt.color));
            } else {
                //light.color = new Color(207, 131, 28);
            }
        }

        if(Input.GetKey(KeyCode.B)){
            lt.color = Color.red;
        }

        if(Input.GetKey(KeyCode.N)){
            lt.color = Color.green;
        }

        if(Input.GetKey(KeyCode.M)){
            lt.color = Color.blue;
        }
    }

    IEnumerator updateLight(Light light, Color color) {
        yield return new WaitForSeconds(.1f);
        light.color = color;
    }
}
