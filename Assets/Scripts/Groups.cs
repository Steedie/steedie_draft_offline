using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class Groups : MonoBehaviour
{
    protected FileInfo theSourceFile = null;
    protected StreamReader reader = null;
    protected string text = " "; // assigned to allow first line to be read below

    public List<leader> leaders = new List<leader>();
    public List<player> players = new List<player>();

    public List<GameObject> leaderPanels = new List<GameObject>();
    int leaderCount = 0;

    public leader captainPrefab;
    public player playerPrefab;

    public Transform playerListHolder;
    public GameObject playerTextPrefab;

    public GameObject biddingPanel;

    public int globalPoints;

    public Sprite GIRU, Stouty, Bruno, rise, rattgift, dman, steedie, sol, cain, redblue, xeonyz1, na1, na2, poge;

    void Start() // this order is important
    {
        AssignPlayers(); // this order is important
        biddingPanel = GameObject.Find("Manager").GetComponent<Groups>().biddingPanel; // this order is important
        GameObject.Find("Manager").GetComponent<Groups>().UpdateGlobalPoints();
        biddingPanel.SetActive(false);// this order is important
    }

    void AssignPlayers()
    {
        theSourceFile = new FileInfo("players.txt");
        reader = theSourceFile.OpenText();

        for (int i = 0; i < File.ReadAllLines("players.txt").Length; i++)
        {
            if (text != null)
            {
                text = reader.ReadLine();
                SortPlayer(text);
                //print(text);
            }
        }
    }

    public GameObject ecoBar;
    public Transform ecoBarParent;
    public Text globalEcoText;
    public Text ecoHealth;

    public void UpdateGlobalPoints()
    {
        globalPoints = 0;
        for (int i = 0; i < leaders.Count; i++)
        {
            globalPoints += leaders[i].points;
        }
        globalEcoText.text = "GLOBAL ECONOMY: " + globalPoints + " POINTS";

        float gp = globalPoints;
        GameObject newEcoBar = Instantiate(ecoBar, ecoBarParent);
        newEcoBar.GetComponent<Image>().fillAmount = gp / 1880;

        //ecoHealth.text = "GLOBAL ECONOMY GRAPH (economy health: " + (gp / 1880) * 100 + "%)";
    }

    public void SortPlayer(string line)
    {
        char[] chars = line.ToCharArray();
        //print(chars[chars.Length-3]);
        if (line[line.Length-1] == char.Parse("1")) // if captain
        {
            leader newLeader = Instantiate(captainPrefab);
            newLeader.name = GetName(line);
            newLeader.points = 150;

            DeductPoints(newLeader, GetName(line));

            leaders.Add(newLeader);
            leaderPanels[leaderCount].GetComponentInChildren<CaptainStats>().captain = newLeader;
            leaderPanels[leaderCount].GetComponentInChildren<CaptainStats>().txtCaptain.text = newLeader.name.ToUpper();
            leaderPanels[leaderCount].GetComponentInChildren<CaptainStats>().txtPoints.text = "REMAINING POINTS: " + newLeader.points;
            //leaderPanels[leaderCount].GetComponent<LeaderStat>().leader = newLeader;
            leaderCount++;
        }
        else
        {
            player newPlayer = Instantiate(playerPrefab);
            newPlayer.name = GetName(line);
            newPlayer.tier = int.Parse(line[line.Length - 3].ToString());
            players.Add(newPlayer);

            GameObject newPlayerText = Instantiate(playerTextPrefab, playerListHolder);
            newPlayerText.GetComponent<PlayerButton>().player = newPlayer;
            newPlayerText.GetComponent<Text>().text = GetTier(line, newPlayerText) + " " + newPlayer.name;
        }
    }

    void DeductPoints(leader ldr, string n)
    {
        return;
        if (n.ToUpper() == "POGE")
        {
            ldr.points -= 50;
        }
        if (n.ToUpper() == "STOUTY")
        {
            ldr.points -= 30;
        }
        if (n.ToUpper() == "MIYAMOTO")
        {
            ldr.points -= 30;
        }
        if (n.ToUpper() == "HONDA")
        {
            ldr.points -= 30;
        }
        if (n.ToUpper() == "XEONYZ1")
        {
            ldr.points -= 30;
        }
        if (n.ToUpper() == "XEONZY1")
        {
            ldr.points -= 30;
        }
        if (n.ToUpper() == "REDBLUE")
        {
            ldr.points -= 15;
        }
        if (n.ToUpper() == "THE LORD")
        {
            ldr.points -= 10;
        }
        if (n.ToUpper() == "LORD")
        {
            ldr.points -= 10;
        }
        if (n.ToUpper() == "JURIS")
        {
            ldr.points -= 10;
        }
        if (n.ToUpper() == "STOLLY")
        {
            ldr.points -= 10;
        }
        if (n.ToUpper() == "AUREATE")
        {
            ldr.points -= 1;
        }
        if (n.ToUpper() == "BEEF")
        {
            ldr.points -= 1;
        }
        if (n.ToUpper() == "ELK")
        {
            ldr.points -= 1;
        }
        if (n.ToUpper() == "OLDNOOB")
        {
            ldr.points -= 1;
        }
        if (n.ToUpper() == "OLD NOOB")
        {
            ldr.points -= 1;
        }
        if (n.ToUpper() == "GOWEN")
        {
            ldr.points -= 1;
        }
    }

    int GetCaptainReduction(string text)
    {
        string tierReturn = text[text.Length - 3].ToString();
        print(Int32.Parse(tierReturn));
        return Int32.Parse(tierReturn);
    }

    string GetTier(string text, GameObject txtColor)
    {
        string tierReturn = text[text.Length - 3].ToString();
        switch (tierReturn)
        {
            case "1":
                txtColor.GetComponent<Text>().color = GameObject.Find("Manager").GetComponent<Bidding>().S;
                return "";
            case "2":
                txtColor.GetComponent<Text>().color = GameObject.Find("Manager").GetComponent<Bidding>().A;
                return "";
            case "3":
                txtColor.GetComponent<Text>().color = GameObject.Find("Manager").GetComponent<Bidding>().X;
                return "";
            case "4":
                txtColor.GetComponent<Text>().color = GameObject.Find("Manager").GetComponent<Bidding>().B;
                return "";
            case "5":
                txtColor.GetComponent<Text>().color = GameObject.Find("Manager").GetComponent<Bidding>().C;
                return "";
            case "6":
                txtColor.GetComponent<Text>().color = GameObject.Find("Manager").GetComponent<Bidding>().D;
                return "";
            /*case "1":
                txtColor.GetComponent<Text>().color = GameObject.Find("Manager").GetComponent<Bidding>().S;
                return "[S]";
            case "2":
                txtColor.GetComponent<Text>().color = GameObject.Find("Manager").GetComponent<Bidding>().A;
                return "[A]";
            case "3":
                txtColor.GetComponent<Text>().color = GameObject.Find("Manager").GetComponent<Bidding>().X;
                return "[B+]";
            case "4":
                txtColor.GetComponent<Text>().color = GameObject.Find("Manager").GetComponent<Bidding>().B;
                return "[B]";
            case "5":
                txtColor.GetComponent<Text>().color = GameObject.Find("Manager").GetComponent<Bidding>().C;
                return "[C]";
            case "6":
                txtColor.GetComponent<Text>().color = GameObject.Find("Manager").GetComponent<Bidding>().D;
                return "[D]";*/
        }
        return "[error]";
    }

    string GetName(string text)
    {
        return text.Substring(0, text.Length - 4);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && Input.GetKey(KeyCode.LeftShift))
        {
            reader.Close();
        }
    }
}
