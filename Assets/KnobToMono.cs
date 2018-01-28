﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnobToMono : mono {

	public Knob input;

	protected override void getSignal(List<bool[]> doneBoxes) {
	float val = input.Value();
		for (int i = 0; i < length; i++) {
			fill[i] = val;
		}
	}
}
