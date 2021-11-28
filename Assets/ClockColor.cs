using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ClockColor : MonoBehaviour
{
    public SpriteRenderer clockSprite;
    public Aiguille petiteAiguille;
    public Aiguille grandeAiguille;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // If the clock is at the right time, it lights up
        if (System.DateTime.UtcNow.Minute == grandeAiguille.value && (System.DateTime.UtcNow.Hour == petiteAiguille.value || System.DateTime.UtcNow.Hour == petiteAiguille.value + 12))
        {
            clockSprite.color = new Color(1f, 1f, 1f);
        }
        else
        {
            clockSprite.color = new Color(0.5f, 0.5f, 0.5f);
        }
    }
}
