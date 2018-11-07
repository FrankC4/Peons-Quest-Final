namespace VRTK
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEventHelper;

	public class Disarm : MonoBehaviour {

		public List <GameObject> Traps;
		public bool disarm = false;
		private VRTK_Control_UnityEvents controlEvents;

		// Use this for initialization
		private void Start () 
		{
			controlEvents = GetComponent<VRTK_Control_UnityEvents>();
			if (controlEvents == null)
			{
				controlEvents = gameObject.AddComponent<VRTK_Control_UnityEvents>();
			}

			controlEvents.OnValueChanged.AddListener (HandleChange);
		}
		
		// Update is called once per frame
		void Update () 
		{
		}
			
		private void HandleChange(object sender, Control3DEventArgs e)
		{
			if (e.normalizedValue <= 50)
			{
				disarm = false;
			}
			else if (e.normalizedValue >= 50)
			{
				disarm = true;
			}
				
		} 
	}
}
