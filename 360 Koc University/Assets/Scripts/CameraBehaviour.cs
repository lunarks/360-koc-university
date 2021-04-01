using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

	public float minX = -360.0f;
	public float maxX = 360.0f;

	public float minY = -45.0f;
	public float maxY = 45.0f;

	public float sensX = 100.0f;
	public float sensY = 100.0f;

	float rotationY = 0.0f;
	float rotationX = 0.0f;

	

	void Update()
	{

		if (Input.GetMouseButton(0))
		{
			rotationX += Input.GetAxis("Mouse X") * sensX * Time.deltaTime;
			rotationY += Input.GetAxis("Mouse Y") * sensY * Time.deltaTime;
			rotationY = Mathf.Clamp(rotationY, minY, 90.0f);
			transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
		}
	}
}