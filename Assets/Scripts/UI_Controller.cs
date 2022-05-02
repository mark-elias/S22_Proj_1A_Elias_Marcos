using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class UI_Controller : MonoBehaviour {

    // -- --------------------------------------------------

    // Character Name
    public InputField Input_CharacterName;
    public Text Output_CharacterName;

    // Race
    public Dropdown Input_Race;
    public Text Output_Race;

    // Class
    public Dropdown Input_Class;
    public Text Output_Class;

    // Alignment
    public InputField Input_Alignment;
    public Text Output_Alignment;

    // Dice Roll
    private float sumOfAllRolls;

    // Abilities
    public Text Output_Strength;
    public Text Output_Dexterity;
    public Text Output_Constitution;
    public Text Output_Intelligence;
    public Text Output_Wisdom;
    public Text Output_Charisma;

    // Health Points & Experience Points
    public InputField Input_CurrentHealthPoints;
    public InputField Input_MaxHealthPoints;

    public Text Output_CurrentHealthPoints;
    public Text Output_MaxHealthPoints;

    public InputField Input_CurrentExperiencePoints;
    public InputField Input_MaxExperiencePoints;

    public Text Output_CurrentExperiencePoints;
    public Text Output_MaxExperiencePoints;

    // Armor
    public InputField Input_Armor;
    public Text Output_Armor;

    // Speed
    public Slider Input_WalkingSlider;
    public Text Output_WalkingSlider;


    // ------------- FUNCTIONS --------------------

    void Start()
    {
        
    }


    // -------------------------------------------------

    public void Display_CharacterName()
    {
        Output_CharacterName.text = Input_CharacterName.text;
    }

    public void Display_Race()
    {
        // Drop Down menu outputs INTEGER values
        // convert a STRING to TEXT by using .text

        if(Input_Race.value == 0)
        {
            Output_Race.text = "Dragonborn";
        }

        else if (Input_Race.value == 1)
        {
            Output_Race.text = "Dwarf";
        }

        else if (Input_Race.value == 2)
        {
            Output_Race.text = "Elf";
        }

        else if (Input_Race.value == 3)
        {
            Output_Race.text = "Gnome";
        }

        else if (Input_Race.value == 4)
        {
            Output_Race.text = "Half-Elf";
        }

        else if (Input_Race.value == 5)
        {
            Output_Race.text = "Half-Orc";
        }

        else if (Input_Race.value == 6)
        {
            Output_Race.text = "Halfling";
        }

        else if (Input_Race.value == 7)
        {
            Output_Race.text = "Human";
        }

        else if (Input_Race.value == 8)
        {
            Output_Race.text = "Tiefling";
        }

        else
        {
            Output_Race.text = "Choose a Race";
        }

    } // ---- end of display race function

    public void Display_Class()
    {
        // Drop Down menu outputs INTEGER values
        // convert a STRING to TEXT by using .text

        if (Input_Class.value == 0)
        {
            Output_Class.text = "Barbarian";
        }

        else if (Input_Class.value == 1)
        {
            Output_Class.text = "Bard";
        }

        else if (Input_Class.value == 2)
        {
            Output_Class.text = "Cleric";
        }

        else if (Input_Class.value == 3)
        {
            Output_Class.text = "Druid";
        }

        else if (Input_Class.value == 4)
        {
            Output_Class.text = "Fighter";
        }

        else if (Input_Class.value == 5)
        {
            Output_Class.text = "Monk";
        }

        else if (Input_Class.value == 6)
        {
            Output_Class.text = "Paladin";
        }

        else if (Input_Class.value == 7)
        {
            Output_Class.text = "Ranger";
        }

        else if (Input_Class.value == 8)
        {
            Output_Class.text = "Rogue";
        }

        else if (Input_Class.value == 9)
        {
            Output_Class.text = "Sorcerer";
        }

        else if (Input_Class.value == 10)
        {
            Output_Class.text = "Warlock";
        }

        else if (Input_Class.value == 11)
        {
            Output_Class.text = "Wizard";
        }

        else
        {
            Output_Class.text = "Choose a Class";
        }

    } // ---- end of display Class function

    public void Display_Alignment()
    {
        Output_Alignment.text = Input_Alignment.text;
    }

    // Abilities --------------------
    // Dice Rolling =----------

    public void DiceRoll()
    {

        Debug.Log("Dice roll called");

        int[] megaRolls = new int[3];

        //------- 3 Mega Rolls For Loop

        for (int z = 0; z < 3; z++)
        {

            // ---- One Mega Roll -----------------
            int[] Roll_5D8 = new int[5];

            int[] Roll_6D3 = new int[6];

            for (int i = 0; i < Roll_5D8.Length; i++)
            {
                Roll_5D8[i] = Random.Range(1, 8);
            }

            for (int i = 0; i < Roll_6D3.Length; i++)
            {
                Roll_6D3[i] = Random.Range(1, 3);

            }

            // combine the two array together
            int[] oneRoll = new int[11];

            int a = 0;

            for (int i = 0; i < Roll_5D8.Length; i++)
            {
                oneRoll[a] = Roll_5D8[i];
                a++;
            }

            int b = 5;

            for (int i = 0; i < Roll_6D3.Length; i++)
            {
                oneRoll[b] = Roll_6D3[i];
                b++;
            }

            // add the values in Array

            int oneRoll_sum = 0;

            for (int i = 0; i < oneRoll.Length; i++)
            {
                oneRoll_sum = oneRoll_sum + oneRoll[i];
            }

            // We now have one big mega roll of 5D8 + 6D3
            // Now save that value into an array for the 3 Mega Rolls

            megaRolls[z] = oneRoll_sum;

        }   //-------------- End For Loop ------------------------------

        // now we need to add the 3 highest rolls

        sumOfAllRolls = 0;

        for (int i = 0; i < megaRolls.Length; i++)
        {
            sumOfAllRolls = sumOfAllRolls + megaRolls[i];
        }

        // +2 modifier
        sumOfAllRolls = sumOfAllRolls + 2;

            
    }      // Function End ---- Dice Roll

    public void Ability_Strength()
    {
        DiceRoll();

        Output_Strength.text = sumOfAllRolls.ToString();
    }

    public void Ability_Dexterity()
    {
        DiceRoll();
        
        Output_Dexterity.text = sumOfAllRolls.ToString();
    }

    public void Ability_Constitution()
    {
        DiceRoll();
        
        Output_Constitution.text = sumOfAllRolls.ToString();
    }

    public void Ability_Intelligence()
    {
        DiceRoll();
        
        Output_Intelligence.text = sumOfAllRolls.ToString();
    }

    public void Ability_Wisdom()
    {
        DiceRoll();
        
        Output_Wisdom.text = sumOfAllRolls.ToString();
    }

    public void Ability_Charisma()
    {
        DiceRoll();
        
        Output_Charisma.text = sumOfAllRolls.ToString();
    }

    // Health & EXP --------------------------------------------
    public void Display_Current_HealthPoints()
    {
        Output_CurrentHealthPoints.text = Input_CurrentHealthPoints.text;
    }

    public void Display_Max_HealthPoints()
    {
        Output_MaxHealthPoints.text = Input_MaxHealthPoints.text;
    }

    public void Display_Current_EXP()
    {
        Output_CurrentExperiencePoints.text = Input_CurrentExperiencePoints.text;
    }

    public void Display_Max_EXP()
    {
        Output_MaxExperiencePoints.text = Input_MaxExperiencePoints.text;
    }

    // ------------------------------------------------------------------------

    public void Armor()
    {
       // (Input_Armor.text == int)
        Output_Armor.text = Input_Armor.text;
    }

    // ---- Speed --------------------------

    public void Speed_Walking()
    {
        Output_WalkingSlider.text = Input_WalkingSlider.ToString();
    }











}       // Class End
