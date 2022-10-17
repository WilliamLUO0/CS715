using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEffect : MonoBehaviour
{

	private float radian = 0;
	// starting radian

	private float perRad = 0.03f;
	// Variation in radians
	private float add = 0f;
	// Store the offset of the displacement
	private Vector3 posOri;
	// Store the actual coordinates of the object when it was generated

	// Use this for initialization
	void Start()
	{
		posOri = transform.position;
		// Record the coordinates of the object when it was just generated
	}

	// Update is called once per frame
	void Update()
	{
		radian += perRad;
		// The arc keeps increasing
		add = Mathf.Sin(radian);
		// get the offset value
		transform.position = posOri + new Vector3(0, add, 0);
		// float the object


		transform.Rotate(0, Time.deltaTime * 25f, 0, Space.World);
		// Rotate on the Y axis based on world coordinates
	}
}
