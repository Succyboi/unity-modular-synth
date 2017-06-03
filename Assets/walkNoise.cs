﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkNoise : MonoBehaviour, mono {

    public Component width;

    private float lastVal=0f;

    private System.Random mr = new System.Random();

    public float[] getSignal(int length)
    {
        float[] fill = new float[length];

        float[] widths = ((mono)width).getSignal(length);

        for (int i = 0; i < length; i++)
        {
            lastVal = Mathf.Clamp(lastVal+((float)mr.NextDouble()*2f-1f)*widths[i],-1f, 1f);
            fill[i] = lastVal;
        }
        return fill;
    }
}