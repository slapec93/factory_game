using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupplierController : MonoBehaviour {

    float nextActionTime = 0.0f;
    float productionRate = 3f;
    bool productionIsEnabled = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextActionTime && productionIsEnabled) {
            nextActionTime += productionRate;
            print("Produce");
        }
    }
}
