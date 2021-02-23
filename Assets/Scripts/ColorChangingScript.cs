using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangingScript : MonoBehaviour
{

    Light lt;
    //bool colorChanged = false;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
        StartCoroutine(updateColor());
        //lt.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator updateColor() {
    
        while(true) {

            lt.color = Color.blue;
            yield return new WaitForSeconds(2);
            lt.color = new Color(.8666667f, 0.3333333f, 0.04705882f);
            yield return new WaitForSeconds(2);
        }
    }
}
