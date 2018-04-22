using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEmiiter : MonoBehaviour {

	public AudioManager am;

	void Start () {
		am.Play("machineClacking");
		am.Play("machineDistant");
	}
}
