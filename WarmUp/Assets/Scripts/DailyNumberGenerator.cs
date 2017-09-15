using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyNumberGenerator : NumberGenerator {

	// Use this for initialization
	void Start () {
		int seed = System.DateTime.Now.Year * 1000 + System.DateTime.Now.DayOfYear;

		Random.InitState(seed);
	}

}
