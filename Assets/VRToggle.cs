using System.Collections;
using UnityEngine;
using UnityEngine.VR;

public class VRToggle : MonoBehaviour
{

	void Update() {

		if (Input.GetMouseButtonDown (0)) {
			ToggleVR ();
		}
	}

	public void ToggleVR() {

		if (VRSettings.loadedDeviceName == "cardboard") {
			GoNormal ();
		} else {
			GoCardboard ();
		}
	}

	public void GoNormal() {
		StartCoroutine(LoadDevice("None"));
	}

	public void GoCardboard() {
		StartCoroutine(LoadDevice("cardboard"));
	}

	IEnumerator LoadDevice(string newDevice)
	{
		VRSettings.LoadDeviceByName(newDevice);
		yield return null;
		VRSettings.enabled = true;
	}
}