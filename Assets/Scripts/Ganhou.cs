using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //para gerenciar cenas
using UnityEngine.UI;

public class Ganhou : MonoBehaviour {

	public Text texto; //declarando uma variavel publica no , ela passa
	//a aparecer no Inspector

	// Use this for initialization
	void Start () {
		
	}

	//identificar quando o Player colidiu com o cubo
	void OnTriggerEnter(Collider jogador){
		if (jogador.tag == "Player") {
			if (jogador.name == "jogador") {
				//mostra a msg na tela
				texto.text = "Você Venceu!!!";
				//esperar um tempo e REINICIAR A CENA
				StartCoroutine(pausarPorUmTempo()); //chama a Corotina (a Thread)
			}
		}


	}

	//IEnumerator - é como se fosse uma Thread que roda em paralelo no 
	IEnumerator pausarPorUmTempo(){
		//laço infinito que encerra o processo após N segundos
		while (true) {
			yield return new WaitForSeconds (2.2f); //f para indicar valores float
			proximaCena();
		}
	}


	//reiniciar a cena (ou ir para outra cena)
	void proximaCena(){
		Cursor.visible = true;
		SceneManager.LoadScene("Jogo2");
        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.UnloadSceneAsync(y);
	}

}//fim classe