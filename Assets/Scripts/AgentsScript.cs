using UnityEngine;
using System.Collections;

public class AgentsScript : MonoBehaviour {

	public GameObject prefab;
	public GameObject[] gos;
	public Transform goal;
	public static int GlobalCounter;
	//public GameObject player;

	GameObject cam;
	private Vector3 targetPosition;
	const int LEFT_MOUSE_BUTTON = 0;
	NavMeshAgent agent;
	//private GameObject myObject;


	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();

		//Creates 8 capsule players

		gos = new GameObject[8];

		if (GlobalCounter < 7) {
			GameObject clone = (GameObject)Instantiate (prefab, new Vector3 (30, 1, (30 - GlobalCounter * 2.0f)), Quaternion.identity);
			GlobalCounter++;
			gos[GlobalCounter] = clone;

		}

		print ("Starting Agent. Current position: " + transform.position);
	}

	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hitInfo;
			Ray ray =  Camera.main.ScreenPointToRay(Input.mousePosition);
			Physics.Raycast (ray, out hitInfo);
			Transform objectHit = hitInfo.transform;

			if (hitInfo.transform.tag == "Agent") {
	
				print ("AgentsSelected; Agent position:"+ objectHit.position );


			} else {
				print ("Not an agent selected - order to move");
				print ("Move position:"+ objectHit.position );
				print ("Move point:" + hitInfo.point );
				//agent.destination = hitInfo.point;
				Transform ObjectHit = hitInfo.transform;
				print ("Object Hit:" + hitInfo.transform );
				//agent.destination = hitInfo.point;
				agent.SetDestination(hitInfo.point);

			}

		}
	}
}
