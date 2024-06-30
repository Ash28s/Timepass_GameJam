// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class Collectable_control : MonoBehaviour
// {
//     public static int CoinCount;
//     public GameObject CoinCountDisplay;

//     void Update()
//     {
//         CoinCountDisplay.GetComponent<Text>().text = "" + CoinCount;
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable_control : MonoBehaviour
{
    public static int CoinCount;
    public GameObject CoinCountDisplay;
    public GameObject CoinEndDisplay;


    void Start()
    {
        CoinCount = 0; // Initialize the coin count at the start of the game
    }

    void Update()
    {
        CoinCountDisplay.GetComponent<Text>().text = "" + CoinCount;
        CoinEndDisplay.GetComponent<Text>().text = "" + CoinCount;
    }
}

