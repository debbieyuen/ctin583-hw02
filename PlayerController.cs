// TODO: Problem 4: Write in the comments what each line of code is doing
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    // TODO: Problem 1: Define a private variable for your player or character's name and print it out to Unity's console

    private string username; // create private variable for player's name

    // Start is called before the first frame update
    void Start()
    {
        username = "Ashley"; // Assigning value to a variable
        Debug.Log("My player's name is " + username); // Retrieving its current value
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Header("General Setup Settings")] // UI header title
    [SerializeField] private InputAction movement; // displays and makes editable this variable Input Action
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f; // displays and makes editable this variable in inspector
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f; // displays and makes editable this variable in inspector
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f; // displays and makes editable this variable in inspector

    private void OnEnable() // enable actions
    {
        movement.Enable(); // enable movement variable
    }

    private void OnDisable() // disable actions
    {
        movement.Disable(); // disable movement variable
    }
}