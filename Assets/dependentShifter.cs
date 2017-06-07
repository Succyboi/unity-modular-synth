﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dependentShifter : MonoBehaviour, mono {

	public Component input;
	public Component sourceMin;
	public Component sourceMax;
	public Component outMin;
	public Component outMax;

public float[] getSignal(int length)
	{
		float[] fill = new float[length];
		float[] datt = ((mono)input).getSignal(length);
		float[] inmins = ((mono)sourceMin).getSignal(length);
		float[] inmaxs = ((mono)sourceMax).getSignal(length);
		float[] outmins = ((mono)outMin).getSignal(length);
		float[] outmaxs = ((mono)outMax).getSignal(length);
		for (int i = 0; i < datt.Length; i++)
		{
			fill[i] = (datt[i] - inmins[i]) / (inmaxs[i] - inmins[i]) * (outmaxs[i] - outmins[i]) + outmins[i];
		}
		return fill;
	}
}