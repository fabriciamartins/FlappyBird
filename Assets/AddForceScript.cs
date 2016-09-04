using UnityEngine;
using System.Collections;

public class AddForceScript : MonoBehaviour {

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump"))
		{
			Debug.Log (KeyCode.UpArrow.ToString());
			rb = GetComponent<Rigidbody> ();
			rb.AddForce(0,10, 0, ForceMode.Impulse);
		}

	}
}
