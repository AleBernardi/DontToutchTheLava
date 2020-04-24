using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
	public float velocidade = 0.5f;
	public Vector3 direcao;

	void Update()
	{
		transform.Translate(Vector3.up * velocidade);
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        //update the position
        direcao = transform.position + new Vector3(verticalInput * velocidade * Time.deltaTime, 0);

        //output to log the position change
        // Debug.Log("Posição: " + direcao.y);

        if(direcao.y == 1250) {
            SceneManager.LoadScene("Jogo");
            int y = SceneManager.GetActiveScene().buildIndex;
            SceneManager.UnloadSceneAsync(y);
        }
	}
}