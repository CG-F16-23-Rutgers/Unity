using UnityEngine;
using System.Collections;

public class IOScript : MonoBehaviour {

    public float camSpeed = 1;
    public float lookSpeed = 3; //controls up/down
    public float rotateSpeed = 100; //controls left/right

	// Controls camera
    // Controls:
    /*      W: Forward
     *      S: Backward
     *      A: Turn Left
     *      D: Turn Right
     *      Q: Look Up
     *      E: Look Down
     * */
	void Update () {

        // Allow camera to move forward and backwards
	    if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(Vector3.forward * camSpeed * Input.GetAxis("Vertical"));
        }

        // Rotate camera up and down
        if (Input.GetKey(KeyCode.E) && (transform.rotation.x < 90))
        {
            transform.Rotate(lookSpeed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.Q) && (transform.rotation.x > -90))
        {
            transform.Rotate(-lookSpeed, 0, 0);
        }

        // Rotate camera left and right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0, Space.World);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0, Space.World);
        }
	}
}
