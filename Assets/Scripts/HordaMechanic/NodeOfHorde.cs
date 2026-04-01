using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;
public class NodeOfHorde 
{
    [Range(10,30)]
    public int Life;
    public int Str;
    public List<Color> Colors = new List<Color>() { Color.black,Color.white ,Color.red};
    public List<string> EnemyNames = new List<string>() { "Bica", "Trica ", "Func", "Vectores", "Lambda" };
    public int Quantity = 5;
}
