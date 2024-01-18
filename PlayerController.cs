// TODO: Problem 4: Write in the comments what each line of code is doing
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{   private string username;
    // TODO: Problem 1: Define a private variable for your player or character's name and print it out to Unity's console
    // Start is called before the first frame update
    void Start()
    {
        username = "SANS";
        Debug.Log("My player's name is" + username);
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

    private void OnEnable()
    {
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }
}