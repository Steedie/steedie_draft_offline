using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new captain", menuName = "Menu/captain")]
public class leader : ScriptableObject
{
    public new string name;
    public int points;
    public List<player> members = new List<player>();
}