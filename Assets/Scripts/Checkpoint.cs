using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider jogador){
		if (jogador.tag == "Player") {
			if (jogador.name == "jogador") {
                GameManager.Instance.lastCheckPoint = transform; 

			}
		}


	}
}
