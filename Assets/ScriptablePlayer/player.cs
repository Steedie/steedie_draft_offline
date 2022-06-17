using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new player", menuName = "Menu/player")]
public class player : ScriptableObject
{
    public new string name;
    public int tier; // 1 = S, 2 = A, 3 = B, 4 = C, 5 = D
    public leader captain;
    public int sellPrice;
}