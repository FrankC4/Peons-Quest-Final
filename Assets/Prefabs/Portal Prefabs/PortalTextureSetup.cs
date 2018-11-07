using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour {

	//public Camera cameraA;
	//public Camera cameraB;

//	public Material cameraMatA;
//	public Material cameraMatB;

	public List <Camera> cameraA;
	public List <Camera> cameraB;

	public List <Material> cameraMatA;
	public List <Material> cameraMatB;

	// Use this for initialization
	void Start () 
	{
		for (int i = 0; i < cameraA.Count; i++) 
		{
			if (cameraA[i].targetTexture != null) 
			{
				cameraA[i].targetTexture.Release ();
			}
			cameraA[i].targetTexture = new RenderTexture (Screen.width, Screen.height, 24);
			cameraMatA[i].mainTexture = cameraA[i].targetTexture;
		}

		for (int i = 0; i < cameraB.Count; i++)
		{
			if (cameraB [i].targetTexture != null) 
			{
				cameraB[i].targetTexture.Release ();
			}
			cameraB[i].targetTexture = new RenderTexture (Screen.width, Screen.height, 24);
			cameraMatB[i].mainTexture = cameraB[i].targetTexture;
		}
	}
	
}
