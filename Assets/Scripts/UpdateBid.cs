using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateBid : MonoBehaviour
{
    public Text txtCurrentBid;

    public void SubmitBid()
    {
        int result;
        if (int.TryParse(GetComponentInChildren<Text>().text, out result)){
            GameObject.Find("Manager").GetComponent<Bidding>().currentBid = result;
            txtCurrentBid.text = GameObject.Find("Manager").GetComponent<Bidding>().currentBid.ToString();
        }        
    }
}
