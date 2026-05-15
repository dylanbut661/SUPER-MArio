using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Este metodo se ejecuta cuando tocan START
    public void StartGame()
    {


        SceneManager.LoadScene("1-1");
    }

    // Este metodo se ejecuta cuando tocan QUIT
    public void QuitGame()
    {
        Debug.Log("Saliendo del juego...");

       
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else
        //  (ejecutable)
        Application.Quit();
#endif
    }
}