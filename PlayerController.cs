// TODO: Problem 4: Write in the comments what each line of code is doing
using System.Collections;	//importing library functions and types
using System.Collections.Generic;	//importing library functions and types
using UnityEngine;	//importing library functions and types

//Declaring player controller class
public class PlayerController : MonoBehaviour

{
	private string playerName;
    // TODO: Problem 1: Define a private variable for your player or character's name and print it out to Unity's console
    // Start is called before the first frame update
    void Start()
    {
		//assigning a player name
		playerName = "Deckard Cain";
		// Print the player's name to the console
        Debug.Log(playerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Header("General Setup Settings")]
    [SerializeField] private InputAction movement;
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f;
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f;
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f;

    private void OnEnable()	//calling this function when checkbox is ticked
    {
        movement.Enable();	//calling enable function on movement
    }

    private void OnDisable()	//calling this function when checkbox is ticked
    {
        movement.Disable();	//calling disable function on movement
    }
}