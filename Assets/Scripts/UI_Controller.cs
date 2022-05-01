using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour {


    public Text CharacterName_Output;
    public InputField CharNameIn;


    // get reference for the Strength button
    public Text Text_RollDiceStrength_OUTPUT;


    void Start()
    {
        CharacterName_Output.text = "outputting text";
    }

    public void CallBack_EditEnd()
    {
        Debug.Log("CallBack_EditEnd was called");
    }

    public void DiceRollStrength()
    {
        int randomNumber = Random.Range(1, 18);
        Text_RollDiceStrength_OUTPUT.text = randomNumber.ToString();
    }
}
