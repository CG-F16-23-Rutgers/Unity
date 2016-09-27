using UnityEngine;
using System.Collections;

public class AgentsScript : MonoBehaviour {

	public GameObject prefab;
	public GameObject[] gos;

	// Use this for initialization
	void Start () {

		gos = new GameObject[8];
		for(int i = 0; i < gos.Length; i++)
		{
			GameObject clone = (GameObject)Instantiate(prefab, new Vector3(30, 1, (30 - i * 2.0f)), Quaternion.identity);
			gos[i] = clone;

		}
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
