using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
	void Update() 
	{
		this.transform.Rotate(new Vector3(45, 45, 0) * Time.deltaTime);
	}
}
