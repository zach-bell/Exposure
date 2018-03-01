using UnityEngine;

public class FirstPersonCam : MonoBehaviour {

	[Header("Mouse Controls")]
	public bool lockCursor;
	public float mouseSensitivity = 10;
	public float rotationSmoothTime = 0.12f;
	Vector3 rotationSmoothVelocity;
	Vector3 currentRotation;
	public Vector2 pitchMinMax = new Vector2(-40, 85);
	
	[Header("Camera Target Controls")]
	public Transform target;
	public float distFromTarget = 2;
	public float distFromFace = 0.5f;
	public Vector3 Offset;
	public Controller controller;
	public float shakeTime = 0.4f;
	Vector3 shakeSmoothVelocity;
	Vector3 currentPosition;

	float yaw, pitch;
	private void Start() {
		if (lockCursor) {
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}
	}
	void LateUpdate () {
		yaw += Input.GetAxis("Mouse X") * mouseSensitivity;
		pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
		pitch = Mathf.Clamp(pitch, pitchMinMax.x, pitchMinMax.y);

		currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(pitch, yaw), ref rotationSmoothVelocity, rotationSmoothTime);
		transform.eulerAngles = currentRotation;

		currentPosition = Vector3.SmoothDamp(currentPosition, ((Random.insideUnitSphere * 2) * controller.animationSpeedPercent), ref shakeSmoothVelocity, shakeTime * 0.75f);
		transform.position = target.position + (transform.forward * distFromFace) + Offset + currentPosition * 0.6f;
	}
}
