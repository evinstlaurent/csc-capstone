using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{

    public void GoHome(){
        SceneManager.LoadSceneAsync("HomePage");
    }
    public void GoToExercise(){
        SceneManager.LoadSceneAsync("Exercise");
    }
    public void GoToPodiatry(){
        SceneManager.LoadSceneAsync("PodiatryPage");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
