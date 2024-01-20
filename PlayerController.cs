// TODO: Problem 4: Write in the comments what each line of code is doing
using System.Collections;	//importing library functions and types
using System.Collections.Generic;	//importing library functions and types
using UnityEngine;	//importing library functions and types

public class PlayerController : MonoBehaviour	//Declaring player controller class

{
	private string playerName; //defining a private variable called playerName
    // TODO: Problem 1: Define a private variable for your player or character's name and print it out to Unity's console
    
    void Start()	// Start is called before the first frame update
    {
		playerName = "Deckard Cain";	//assigning a player name
        Debug.Log(playerName);	// Print the player's name to the console
    }

    void Update()	// Update is called once per frame
    {
        
    }

    [Header("General Setup Settings")]		//creating a header
    [SerializeField] private InputAction movement;	//declaring private variable named movement
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f; //declaring variable controlspeed
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f;	//declaring variable xRange
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f;	//declaring variavle yRange

    private void OnEnable()	//calling this function when checkbox is ticked
    {
        movement.Enable();	//calling enable function on movement
    }

    private void OnDisable()	//calling this function when checkbox is ticked
    {
        movement.Disable();	//calling disable function on movement
    }
}