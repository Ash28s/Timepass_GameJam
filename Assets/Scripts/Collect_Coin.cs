using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect_Coin : MonoBehaviour
{
    public AudioSource Coin;

    void OnTriggerEnter(Collider other)
    {
        Coin.Play();
        Collectable_control.CoinCount += 1;
        this.gameObject.SetActive(false);
    }
}
