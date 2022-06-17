using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestorePlayer : MonoBehaviour
{
    public player member;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(listen);
    }

    void listen()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            member.captain.points += member.sellPrice;
            GameObject.Find("Manager").GetComponent<Groups>().UpdateGlobalPoints();
            GameObject.Find(transform.parent.transform.parent.transform.parent.name + "/PanelHeader").GetComponent<CaptainStats>().txtPoints.text = "REMAINING POINTS: "+ member.captain.points;
            member.captain = null;
            GameObject.Find("Manager").GetComponent<Groups>().SortPlayer(member.name + " " + member.tier + " 0");
            Destroy(gameObject);
        }
    }
}