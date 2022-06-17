using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bidding : MonoBehaviour
{
    public player currentPlayer;
    public int currentBid = 0;
    public Color S, A, X, B, C, D;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && GameObject.Find("Canvas/BiddingPanel").activeSelf)
        {
            GameObject.Find("Canvas/BiddingPanel").SetActive(false);
        }
    }
}
