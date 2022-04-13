using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVal : MonoBehaviour
{
    public enum Player
    {
        player1,
        player2
    }

    
    public Button button;
    public static Player player ;
    [SerializeField] private Text textObject, resultText;
    [SerializeField] GameObject reslut;
    [SerializeField] private CheckResult checkResult;
    [SerializeField] private AIScript Ai;
    static int count;
    
    private void Start()
    {
        player = Player.player1;
        count = 0;
        //reslut= GameObject.Find("Result");
        resultText.text = "";
        
    }
    

    public void SetText()
    {

        if (textObject.text == "" && resultText.text == "") 
        {
            //increment for every move
            count++;
            print(count);
            if (AIScript.ai==true && player ==Player.player1)
            {
                textObject.text = "X";
                textObject.color = Color.black;
                Ai.Aimove();
            }
            
           else if (player == Player.player1)
            {


                

                

                textObject.text = "X";
                textObject.color = Color.black;
                player = Player.player2;
            }
            else
            {
                textObject.text = "O";
                textObject.color = Color.white;
                player = Player.player1;

            }
            var hasWon = checkResult.Result();
            if(count == 9 && !hasWon)
            {
                resultText.text = "Draw";
            }

        }

        
    }
}


