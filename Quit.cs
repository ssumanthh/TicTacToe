using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    [SerializeField] private GameObject quit;

    /// <summary>
    /// on click end the game
    /// </summary>
    public void Clicked()
    {

        print("exit");
        Application.Quit();

    }
}
