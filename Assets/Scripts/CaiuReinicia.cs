using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //para gerenciar cenas
using UnityEngine.UI;

public class CaiuReinicia : MonoBehaviour {

	public Transform StartPos;

	// Use this for initialization
	void Start () {
	
	}

	//identificar quando o Player colidiu com o cubo
	void OnTriggerEnter(Collider jogador){
		if (jogador.tag == "Player") {
			if (jogador.name == "jogador") {
				jogador.gameObject.transform.position = GameManager.Instance.lastCheckPoint.position;
			}
		}


	}

}//fim classe