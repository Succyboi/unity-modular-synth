﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monoBridge : mono
{
	public mono source;
	protected override void getSignal(List<bool[]> doneBoxes) {
		fill = source.gibSignal(doneBoxes);
	}
}
