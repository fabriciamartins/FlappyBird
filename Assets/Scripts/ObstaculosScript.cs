using UnityEngine;
using System.Collections;

public class ObstaculosScript : MonoBehaviour {

	public float velocidade;
	public float range = 4;

	// Use this for initialization
	void Start () {
		transform.position += new Vector3 (transform.position.x, transform.position.y - range * Random.value, 0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (velocidade, 0, 0)*Time.deltaTime;
	}
}
