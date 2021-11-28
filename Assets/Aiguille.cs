using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiguille : MonoBehaviour
{
    public string hourOrMinute = "minute";
    public int value;
    // Start is called before the first frame update
    void Start()
    {
        // Put it at the right spot
        if (hourOrMinute == "minute")
        {
            transform.Rotate(0, 0, (-180 / 30) * value, Space.Self);
        }
        if (hourOrMinute == "hour")
        {
            transform.Rotate(0, 0, (-180 / 6)*value, Space.Self);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
