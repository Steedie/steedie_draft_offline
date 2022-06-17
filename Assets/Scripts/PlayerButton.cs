using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerButton : MonoBehaviour
{
    public player player;
    public GameObject biddingPanel;

    private void Awake()
    {
        biddingPanel = GameObject.Find("Manager").GetComponent<Groups>().biddingPanel;
    }

    private void Start()
    {
        //biddingPanel.SetActive(false);
        GetComponent<Button>().onClick.AddListener(listen);
    }

    void listen()
    {
        GameObject.Find("Manager").GetComponent<Bidding>().currentPlayer = player;
        GameObject.Find("Manager").GetComponent<Bidding>().currentBid = GetDefaultBid();
        biddingPanel = GameObject.Find("Manager").GetComponent<Groups>().biddingPanel;
        biddingPanel.SetActive(true);
        ChangeBidPic();
        GameObject.Find("Canvas/BiddingPanel/InputField/Text").GetComponent<Text>().text = GameObject.Find("Manager").GetComponent<Bidding>().currentBid.ToString();
        GameObject.Find("Canvas/BiddingPanel/TxtCurrentBid").GetComponent<Text>().text = GameObject.Find("Manager").GetComponent<Bidding>().currentBid.ToString();
        GameObject.Find("Canvas/BiddingPanel/TxtPlayerName").GetComponent<Text>().text = player.name.ToUpper();
        GameObject.Find("Canvas/BiddingPanel/TxtTier").GetComponent<Text>().text = GetTier(player, GameObject.Find("Canvas/BiddingPanel/TxtTier").GetComponent<Text>());
    }

    void ChangeBidPic()
    {
        if (player.name == "Stouty")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().Stouty;
        }
        else if(player.name == "stouty")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().Stouty;
        }
        else if(player.name == "GIRU")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().GIRU;
        }
        else if(player.name == "rise")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().rise;
        }
        else if(player.name == "Bruno")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().Bruno;
        }
        else if(player.name == "rattgift")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().rattgift;
        }
        else if(player.name == "Devilman")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().dman;
        }
        else if(player.name == "Miyamoto")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().dman;
        }
        else if(player.name == "Slayer Hans")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().dman;
        }
        else if(player.name == "Steedie")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().steedie;
        }
        else if(player.name == "steedie")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().steedie;
        }
        else if(player.name == "Sol")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().sol;
        }
        else if(player.name == "Cain")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().cain;
        }
        else if(player.name == "redblue")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().poge;
        }
        else if(player.name == "RedBlue")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().poge;
        }
        else if(player.name == "Redblue")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().poge;
        }
        else if(player.name == "RedBlueBerries")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().poge;
        }
        else if(player.name == "Redblueberries")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().poge;
        }
        else if(player.name == "redblueberries")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().redblue;
        }
        else if(player.name == "bear")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().redblue;
        }
        else if(player.name == "Bear")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().redblue;
        }
        else if(player.name == "mordhaubear")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().redblue;
        }
        else if(player.name == "poge")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().poge;
        }
        else if(player.name == "Poge")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().poge;
        }
        else if(player.name == "Diamond")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().na2;
        }
        else if(player.name == "Shtabbbe")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().na1;
        }
        else if(player.name == "DiamondNA")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().na2;
        }
        else if(player.name == "ShtabbbeNA")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().na1;
        }
        else if(player.name == "ShtabbeNA")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().na1;
        }
        else if(player.name == "Xeonyz1")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().xeonyz1;
        }
        else if(player.name == "Xeonzy1")
        {
            biddingPanel.GetComponent<Image>().sprite = GameObject.Find("Manager").GetComponent<Groups>().xeonyz1;
        }
        else
        {
            biddingPanel.GetComponent<Image>().sprite = null;
        }
    }

    int GetDefaultBid()
    {
        return 0;
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
