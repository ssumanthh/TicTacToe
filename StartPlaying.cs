using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPlaying : MonoBehaviour
{
    
    [SerializeField] private GameObject play;

    /// <summary>
    /// on click start the game
    /// </summary>
    public void Clicked()
    {
        SceneManager.LoadScene("PlayGame");

    }
}
