﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recycling : MonoBehaviour
{
    public Spawner spawn;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Start Bag(Clone)")
        {
            print("Start Game");
            spawn.gamePlaying = true;
        }
    }
}
