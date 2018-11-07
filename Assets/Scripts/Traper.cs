namespace VRTK
{
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class Traper : CharacterStats 
	{
		public Animation trapAnim;
		public GameObject lever;
		bool disarm;


		// Use this for initialization
		public override void Start () 
		{
			trapAnim = GetComponent<Animation> ();		
		}
		
		// Update is called once per frame
		void Update () 
		{
			disarm = lever.GetComponent<Disarm> ().disarm;
		}

		void OnTriggerEnter(Collider other)
		{
			if (disarm == false && other.gameObject.tag == "Player") 
			{
				trapAnim.Play ();

			}
		}

		void OnTriggerExit(Collider other)
		{
			trapAnim.Stop ();
		}

	}
}
