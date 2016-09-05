using UnityEngine;
using System.Collections;

public class GeradorObstaculosScript : MonoBehaviour {

	//Objeto que será gerado automaticamente
	public GameObject obstaculos;

	// Use this for initialization
	void Start () {
		//InvokeRepeating é um método que chamará outro método repetidas vezes
		//1º Parametro: nome do método que será chamado varias vezes
		//2º Parametro: numero de segundos de atraso das chamadas
		//3º Parametro: numero de segundos entre as chamadas
		InvokeRepeating ("CriarObstaculos", 1f, 2.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CriarObstaculos()
	{
		//Método que irá instancias os obstaculos automaticamente
		Instantiate (obstaculos);
	}
}
