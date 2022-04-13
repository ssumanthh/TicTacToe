using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class  CheckResult : MonoBehaviour
{
    [SerializeField] private Text[] textObject;
    [SerializeField] GameObject[] line;
    [SerializeField] GameObject result ;
    private Text resultText;

    
    private void Start()
    {
        //button = GameObject.Find("Result");
        resultText =  result.GetComponent<Text> ();
        for(int i=0;i<8;i++)
            line[i].SetActive(false);
    }



    //private void Update()
    //{
    //    Result();
    //}

    /// <summary>
    /// checks for the result of the game
    /// </summary>
    public bool Result()
    {
        bool hasWon = false;
        if ( Check(0, 1, 2))
        {
            hasWon = true;
            if (textObject[2].text == "X")
            {
            line[0].SetActive(true);
                
                 resultText.color = Color.black;
                 resultText.text = "Player 1 wins!!!";
            }

            else if (textObject[2].text == "O")
            {
                line[0].SetActive(true);
                resultText.text = "Player 2 wins!!!";
            }
        }
        else if ( Check(3, 4, 5))
        {
            hasWon = true;
            if (textObject[5].text == "X")
            {
            line[1].SetActive(true);
                 resultText.color = Color.black;
                 resultText.text = "Player 1 wins!!!";
            }
            else if (textObject[5].text == "O")
            {
                line[1].SetActive(true);
                resultText.text = "Player 2 wins!!!";
            }
        }
        else if ( Check(6, 7, 8))
        {
            hasWon = true;
            if (textObject[8].text == "X")
            {
            line[2].SetActive(true);
                 resultText.color = Color.black;
                 resultText.text = "Player 1 wins!!!";
            }
            else if (textObject[8].text == "O")
            {
                line[2].SetActive(true);
                resultText.text = "Player 2 wins!!!";
            }
        }
        else if ( Check(0, 3, 6))
        {
            hasWon = true;
            
            if (textObject[6].text == "X")
            {
                line[3].SetActive(true);
                 resultText.color = Color.black;
                 resultText.text = "Player 1 wins!!!";
            }
            else if (textObject[6].text == "O")
            {

                line[3].SetActive(true);
                resultText.text = "Player 2 wins!!!";
            }
        }
        else if ( Check(1, 4, 7))
        {
            hasWon = true;
            
            if (textObject[7].text == "X")
            {
                line[4].SetActive(true);
                resultText.color = Color.black;
                 resultText.text = "Player 1 wins!!!";
            }

            else if (textObject[7].text == "O")
            {
                line[4].SetActive(true);
                resultText.text = "Player 2 wins!!!";
            }
        }
        else if ( Check(2, 5, 8))
        {
            hasWon = true;
            
            if (textObject[8].text == "X")
            {
                line[5].SetActive(true);
                resultText.color = Color.black;
                 resultText.text = "Player 1 wins!!!";
            }
            else if (textObject[8].text == "O")
            {
                line[5].SetActive(true);
                resultText.text = "Player 2 wins!!!";
            }


        }
        else if ( Check(0, 4, 8))
        {
            hasWon = true;
            
            if (textObject[8].text == "X")
            {
                line[6].SetActive(true);
                resultText.color = Color.black;
                 resultText.text = "Player 1 wins!!!";
            }
            else if (textObject[8].text == "O")
            {
                line[6].SetActive(true);
                resultText.text = "Player 2 wins!!!";
            }
        }
        else if ( Check(2, 4, 6))
        {
            
            hasWon = true;
            if (textObject[2].text == "X")
            {
                line[7].SetActive(true);
                resultText.color = Color.black;
                 resultText.text = "Player 1 wins!!!";
            }

            else if (textObject[2].text == "O")
            {
                line[7].SetActive(true);
                resultText.text = "Player 2 wins!!!";
            }
        }
        return hasWon;

    }

    /// <summary>
    ///  Check if button text values are same or not
    /// </summary>
    /// <param name="i"></param>
    /// <param name="j"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    bool  Check(int i,int j,int k)
    {
        return (textObject[i].text.Equals(textObject[j].text) && textObject[j].text.Equals(textObject[k].text)&&textObject[i].text!="");
        
        
    }
    
}
