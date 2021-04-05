using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void quitGame() {
        Application.Quit();
    }

    public void backToMenu() {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
        if (SceneManager.sceneCount > nextSceneIndex) {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
