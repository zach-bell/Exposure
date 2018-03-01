using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFlashlightscript : MonoBehaviour {
	public GameObject flashLight;
	private bool lockIt = true;
	void LateUpdate () {
		if (Input.GetKeyDown(KeyCode.F)) {
			if (lockIt) {
				if (flashLight.activeSelf) {
					flashLight.SetActive(false);
				}
				else {
					flashLight.SetActive(true);
				}
				lockIt = false;
			}
		}
		else {
			lockIt = true;
		}
	}
}
