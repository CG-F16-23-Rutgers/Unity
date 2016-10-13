using UnityEngine;
using System.Collections;

public class AverageJoeScript : MonoBehaviour {

    Animator anim;
    int runHash = Animator.StringToHash("Run");

	void Start () {
        anim = GetComponent<Animator>();
	}
	
	
	void Update () {
        float moveV = Input.GetAxis("Vertical");
        float moveH = Input.GetAxis("Horizontal");
        anim.SetFloat("Vertical", moveV);
        anim.SetFloat("Horizontal", moveH);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool(runHash, true);
        }
        else
        {
            anim.SetBool(runHash, false);
        }
	}
}
