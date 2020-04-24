using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void abrirCutscene() {
        SceneManager.LoadScene("Cutscene");
        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.UnloadSceneAsync(y);
    }

    public void abrirJogo() {
        SceneManager.LoadScene("Jogo");
        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.UnloadSceneAsync(y);
    }

    public void abrirSobre() {
        SceneManager.LoadScene("Sobre");
        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.UnloadSceneAsync(y);
    }

    public void abrirMenu() {
        Cursor.visible = true;
        Time.timeScale = 1f;
        PauseMenu1.GameIsPaused = false;
        SceneManager.LoadScene("Menu");
        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.UnloadSceneAsync(y);
    }

    public void fecharJogo() {
        Application.Quit();
        
    }

}
