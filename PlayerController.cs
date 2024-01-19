// TODO: Problem 4: Write in the comments what each line of code is doing
using System.Collections; //enable me to use the classes and functionalities
using System.Collections.Generic; // enable me to extend the basic collection classes and introduce generic-based collection classes
using UnityEngine; // allow me to gain access to the Unity-specific classes and functionalities

public class PlayerController : MonoBehaviour
{
    // TODO: Problem 1: Define a private variable for your player or character's name and print it out to Unity's console
    // Start is called before the first frame update
    



    // Problem 1
    // Declaring a variable
    string username; // define a string variable 
    username = Console.ReadLine("vv"); // Assigning a value to a variable   
    Console.WriteLine("My player's name is " + username); // Retrieving its current value
    



    void Start() // Start function
    {

        
    }

    // Update is called once per frame
    void Update() // Update function
    {
        
    }

    [Header("General Setup Settings")] // "[Header()]" attribute is employed to visually organize and label sections of variables or settings within the Inspector
    [SerializeField] private InputAction movement; //the "movement" InputAction variable will be serialized and visible in the Unity Editor
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f; // set a variable named "controlSpeed" and assign value
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f; // set a variable for player's movement in x dimension and assign value
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f; // set a variable for player's movement in y dimension and assign value

    private void OnEnable() // define a private function
    {
        movement.Enable();  // invoke the Enable() method on the movement variable
    }

    private void OnDisable() // define a private function
    {
        movement.Disable();  // invoke the Disable() method on the movement variable
    }
}