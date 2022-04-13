using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIScript : MonoBehaviour
{

    [SerializeField] private Text[] textObject;
   
    public static bool ai;
    [SerializeField] GameObject result;
    [SerializeField] GameObject[] line;
    private Text resultText;

    // Start is called before the first frame update
    void Start()
    {
        ai = false;
        print("calls");
        resultText = result.GetComponent<Text>();
    }

    public void ToggleAi()
    {
        ai = !ai;
        for (int i = 0; i < 9; i++)
        {
            textObject[i].text = "";
            textObject[i].color = Color.white;
        }
        resultText.text = "";
        ChangeVal.player = ChangeVal.Player.player1;
        for (int i = 0; i < 8; i++)
            line[i].SetActive(false);
    

}
    // Update is called once per frame
    public void Aimove()
    {
        print(ai);
        //ChangeVal.player = ChangeVal.Player.player1;
        //next.GetComponentInChildren<Text>().text = "O";

        if (textObject[0].text == "")
        {
            textObject[0].text = "O";
        }
        else if (textObject[2].text == "")
        {
            textObject[2].text = "O";
        }
        else if (textObject[6].text == "")
        {
            textObject[6].text = "O";
        }
        else if (textObject[8].text == "")
        {
            textObject[8].text = "O";
        }
        else
        {
            for(int i = 1; i < 8; i++)
            {
                if (textObject[i].text == "")
                {
                    textObject[i].text = "O";
                    break;
                }
            }
        }

    }


}
