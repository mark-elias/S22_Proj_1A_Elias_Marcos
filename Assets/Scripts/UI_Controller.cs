using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class UI_Controller : MonoBehaviour {

    // ---- old code
    public Text CharacterName_Output;
    public InputField CharNameIn;


    // get reference for the Strength button
    public Text Text_RollDiceStrength_OUTPUT;

    // -- --------------------------------------------------

    public InputField Input_CharacterName;
    public Text Output_CharacterName;

    public InputField Input_Alignment;
    public Text Output_Alignment;



    // ------------- FUNCTIONS --------------------

    void Start()
    {
        CharacterName_Output.text = "outputting text";
    }


    // -------------------------------------------------

    public void Display_CharacterName()
    {
        Output_CharacterName.text = Input_CharacterName.text;
    }

    public void Display_Alignment()
    {
        Output_Alignment.text = Input_Alignment.text;
    }

    public void DiceRollStrength()
    {
        int randomNumber = Random.Range(1, 18);
        Text_RollDiceStrength_OUTPUT.text = randomNumber.ToString();
    }

    // ---------------------------------------------------------------------
}
