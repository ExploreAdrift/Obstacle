using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // SerializeField connects VS Code to Unity
    // Start is called before the first frame update

    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        PrintInstructions(); // Call the function
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player");
        Debug.Log("Dodge everything");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        // STRING REFERENCE
        transform.Translate(xValue, 0, zValue);
    }


}
