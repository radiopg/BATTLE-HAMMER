using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnToTitleScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadOutScreen()
    {
        SceneManager.LoadScene(1);
    }

    public void StartLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void HighScoresTable()
    {
        SceneManager.LoadScene(3);
    }
}
