using UnityEngine;

public class RotateDireita : MonoBehaviour
{
	public float velocidade = 0.5f;
	private bool inverte = true;
	Vector3 movimentarir = new Vector3 (0f, 1f, 0f);
	Vector3 movimentarVoltar = new Vector3 (0f, -1f, 0f);


	void Update()
    {
		// Debug.Log(gameObject.transform.position.x);
		if (gameObject.transform.position.x >= -13.450 && inverte == true){
			if(gameObject.transform.position.x <= global::System.Single.Parse("-13,43")){
				inverte = false;
			}
			transform.Translate(movimentarir * (velocidade * Time.deltaTime));
		} 
		if (gameObject.transform.position.x <= -10.7 && inverte == false){
			if(gameObject.transform.position.x >= -10.9){
				inverte = true;
			}
			transform.Translate(movimentarVoltar * (velocidade * Time.deltaTime));
		} 
		
    }
}