using UnityEngine;
using System.Collections;

public class AverageJoeScript : MonoBehaviour {

    Animator anim;

	void Start () {
        anim = GetComponent<Animator>();
	}
	
	
	void Update () {
        float moveV = Input.GetAxis("Vertical");
        anim.SetFloat("Vertical", moveV);
	}
}
