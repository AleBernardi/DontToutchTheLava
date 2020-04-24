using UnityEngine;

public class RotateEsquerda : MonoBehaviour
{
	public float velocidade = 0.5f;
	private bool inverte = true;
	Vector3 movimentarir = new Vector3 (0f, -1f, 0f);
	Vector3 movimentarVoltar = new Vector3 (0f, 1f, 0f);


	void Update()
    {
    
		if (gameObject.transform.position.x <= -16.450 && inverte == true){
			if(gameObject.transform.position.x >= global::System.Single.Parse("-16,48")){
                
				inverte = false;
			}
			transform.Translate(movimentarir * (velocidade * Time.deltaTime));
		} 
		if (gameObject.transform.position.x >= -19.43 && inverte == false){
            // Debug.Log(gameObject.transform.position.x);
			if(gameObject.transform.position.x <= global::System.Single.Parse("-19,40")){
				inverte = true;
			}
			transform.Translate(movimentarVoltar * (velocidade * Time.deltaTime));
		} 
		
    }
}