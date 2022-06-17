using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class CaptainStats : MonoBehaviour
{
    public leader captain;
    public Text txtCaptain, txtPoints;
    Transform memberList;
    public GameObject txtMember;

    private void Start()
    {
        memberList = GameObject.Find(transform.parent.name + "/PanelList/ImgUnits").transform;
    }

    public void AddMember()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.X))
        {
            transform.parent.gameObject.SetActive(false);
        }

        if (GameObject.Find("Manager").GetComponent<Bidding>().currentPlayer != null && captain.points >= GameObject.Find("Manager").GetComponent<Bidding>().currentBid)
        {
            captain.members.Add(GameObject.Find("Manager").GetComponent<Bidding>().currentPlayer);
            GameObject.Find("Manager").GetComponent<Bidding>().currentPlayer.captain = captain;
            GameObject newPlayer = Instantiate(txtMember, memberList);
            GameObject.Find("Manager").GetComponent<Bidding>().currentPlayer.sellPrice = GameObject.Find("Manager").GetComponent<Bidding>().currentBid;
            newPlayer.GetComponent<Text>().text = GetTier(GameObject.Find("Manager").GetComponent<Bidding>().currentPlayer, newPlayer.GetComponent<Text>()) + " " + GameObject.Find("Manager").GetComponent<Bidding>().currentPlayer.name + " - " + GameObject.Find("Manager").GetComponent<Bidding>().currentPlayer.sellPrice + " POINTS";
            newPlayer.GetComponent<RestorePlayer>().member = GameObject.Find("Manager").GetComponent<Bidding>().currentPlayer;

            GameObject.FindGameObjectWithTag("AuctionLog").GetComponent<Text>().text = captain.name + " just bought " + GameObject.Find("Manager").GetComponent<Bidding>().currentPlayer.name + " for " + GameObject.Find("Manager").GetComponent<Bidding>().currentPlayer.sellPrice + " points";

            captain.points -= GameObject.Find("Manager").GetComponent<Bidding>().currentBid;
            GameObject.Find("Manager").GetComponent<Groups>().UpdateGlobalPoints();
            txtPoints.text = "REMAINING POINTS: " + captain.points.ToString();
            GameObject.Find("Manager").GetComponent<Bidding>().currentPlayer.sellPrice = GameObject.Find("Manager").GetComponent<Bidding>().currentBid;
            GameObject.Find("Manager").GetComponent<Bidding>().currentBid = 0;
            RemoveFromPlayerList(GameObject.Find("Manager").GetComponent<Bidding>().currentPlayer);
            GameObject.Find("Manager").GetComponent<Bidding>().currentPlayer = null;            
            GameObject.Find("Canvas/BiddingPanel").SetActive(false);

        }
    }

    void RemoveFromPlayerList(player player)
    {
        foreach (Transform x in GameObject.Find("Canvas/PlayersPanel/ImgUnits").transform)
        {
            if (x.GetComponent<PlayerButton>().player == player)
            {
                x.gameObject.SetActive(false);
            }
        }
    }

    string GetTier(player player, Text text)
    {
        switch (player.tier)
        {
            /*case 1:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().S;
                return "[S]";
            case 2:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().A;
                return "[A]";
            case 3:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().X;
                return "[B+]";
            case 4:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().B;
                return "[B]";
            case 5:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().C;
                return "[C]";
            case 6:
                text.color = GameObject.Find("Manager").GetComponent<Bidding>().D;
                return "[D]";*/
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
        return "[E]";
    }
}
