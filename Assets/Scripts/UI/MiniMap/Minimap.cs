using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour 
{
	public Transform player;

	void Update()
	{
		Vector3 newPostition = player.position;
		newPostition.y = transform.position.y;
		transform.position = newPostition;

		//Rotates Camera With Player
		//transform.rotation = Quaternion.Euler (90f, player.eulerAngles.y, 0f);
	}
}
