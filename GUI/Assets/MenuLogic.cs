using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void menu()
    {
        SceneManager.LoadScene("menu", LoadSceneMode.Single);
    }

    public void reset()
    {
        play();
    }

    public void play()
    {
        SceneManager.LoadScene("ingame", LoadSceneMode.Single);
    }

    public void won()
    {
        SceneManager.LoadScene("gameover", LoadSceneMode.Single);
    }
}
