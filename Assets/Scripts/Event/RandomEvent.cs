﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RandomEvent : MonoBehaviour {

	public string Name = "Random";

	public string Avatar = "random.jpg";

	public string Message = "A random event occurred!";

	public abstract void Fire ();

}
