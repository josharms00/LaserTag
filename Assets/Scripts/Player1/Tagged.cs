using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tagged : MonoBehaviour
{
    public bool It;

    public Text itText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (It)
        {
            itText.enabled = true;
        }
        else{
            itText.enabled = false;
        }
    }
}
