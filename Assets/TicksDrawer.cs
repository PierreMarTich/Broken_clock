using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicksDrawer : MonoBehaviour
{
    public GameObject objectToDraw;

    // Start is called before the first frame update
    void Start()
    {
        // Draw the ticks on the clock
        for(int tick = 0; tick <= 11; tick++)
        {
        GameObject currentTick = Instantiate(objectToDraw, transform);
            currentTick.transform.Rotate(0, 0, 30*tick, Space.Self);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
