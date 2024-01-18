// TODO: Problem 4: Write in the comments what each line of code is doing
using System.Collections;   //Using C#
using System.Collections.Generic;   //Using C#
using UnityEngine;  //The script will be used in Unity Game Engine



public class PlayerController : MonoBehaviour   //Defined PlayerController public class
{   private string username;    //Declared a private string variable called username
    // TODO: Problem 1: Define a private variable for your player or character's name and print it out to Unity's console
    // Start is called before the first frame update
    void Start()    //Start function
    {
        username = "SANS";  //defined username variable
        Debug.Log("My player's name is" + username);    //printing the username to the console
    }

    // Update is called once per frame
    void Update()   //update function
    {
        
    }

    [Header("General Setup Settings")]  //header shows up in the inspector
    [SerializeField] private InputAction movement;  //creating input action movement in the inspector
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f;    //creating tooltip in the inspector
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f;  //creating tooltip in the inspector
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f;    //creating tooltip in the inspector

    private void OnEnable()     //defined onEnable function
    {
        movement.Enable();      //defined what the function does
    }

    private void OnDisable()    //defined onDisable function
    {
        movement.Disable();     //defined what the function does
    }
}