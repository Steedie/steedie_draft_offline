using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PButFix : MonoBehaviour
{
    public player player;
    GameObject biddingPanel;

    private void Awake()
    {
        biddingPanel = GameObject.Find("Canvas/BiddingPanel");
    }

    private void Start()
    {
        biddingPanel.SetActive(false);
        GetComponent<Button>().onClick.AddListener(listen);
    }

    void listen()
    {
        GameObject.Find("Manager").GetComponent<Bidding>().currentPlayer = player;
        GameObject.Find("Manager").GetComponent<Bidding>().currentBid = GetDefaultBid();
        biddingPanel.SetActive(true);
        GameObject.Find("Canvas/BiddingPanel/TxtCurrentBid").GetComponent<Text>().text = "current bid: " + GameObject.Find("Manager").GetComponent<Bidding>().currentBid.ToString();
        GameObject.Find("Canvas/BiddingPanel/TxtPlayerName").GetComponent<Text>().text = player.name.ToUpper();
        GameObject.Find("Canvas/BiddingPanel/TxtTier").GetComponent<Text>().text = GetTier(player, GameObject.Find("Canvas/BiddingPanel/TxtTier").GetComponent<Text>());
    }

    int GetDefaultBid()
    {
        switch (player.tier)
        {
            case 1:
                return 20;
            case 2:
                return 15;
            case 3:
                return 10;
            case 4:
                return 5;
            case 5:
                return 1;
            case 6:
                return 0;
        }
        return 0;
    }

    string GetTier(player player, Text text)
    {
        switch (player.tier)
        {
            /*case 1:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().S;
                return "S TIER";
            case 2:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().A;
                return "A TIER";
            case 3:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().X;
                return "B+ TIER";
            case 4:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().B;
                return "B TIER";
            case 5:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().C;
                return "C TIER";
            case 6:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().D;
                return "D TIER";*/
            case 1:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().S;
                return "";
            case 2:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().A;
                return "";
            case 3:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().X;
                return "";
            case 4:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().B;
                return "";
            case 5:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().C;
                return "";
            case 6:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().D;
                return "";
        }
        return "error: couldn't get tier";
    }
}
