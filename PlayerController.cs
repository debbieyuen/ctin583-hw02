// TODO: Problem 4: Write in the comments what each line of code is doing
using System.Collections; //phrase "using" tells script where to get base functions
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // TODO: Problem 1: Define a private variable for your player or character's name and print it out to Unity's console
    private string username; //instantiates a private variable
    // Start is called before the first frame update
    void Start()
    {
        username = "WHATTSUPPP"; //the string variable is defined
        Debug.Log("Your character is called " + username); //unity's way of print()
    }

    // Update is called once per frame
    void Update()
    {
        //pass
    }

    [Header("General Setup Settings")] //ui
    [SerializeField] private InputAction movement; //puts the variable in inspector, variable recieves input
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f; //ui, mouse hover over
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f;
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f;

    private void OnEnable() //unity library
    {
        movement.Enable(); //movement variable able to recieve player input
    }

    private void OnDisable() //unity library
    {
        movement.Disable(); //no input possible
    }
}