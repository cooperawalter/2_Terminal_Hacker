using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    // Game state
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen; 

	// Use this for initialization
	void Start () {
        ShowMainMenu();
    }   

	// Update is called once per frame
	void Update () {
		
	}

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu; 
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for your cat's iPad");
        Terminal.WriteLine("Press 2 for the neighbor's wifi");
        Terminal.WriteLine("Press 3 for your gmail account");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection:");
    }
  
    void OnUserInput(string input)
    {
        if (input == "menu") // we can always go directly to main menu
        {
            ShowMainMenu();
        } else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else if (input == "42") // easter egg
        {
            Terminal.WriteLine("Ah, I see someone is enlightened. But the real question is: What is the question?");
        }
        else
        {
            Terminal.WriteLine("Please chooser a valid level");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen " + level);
    }
}
