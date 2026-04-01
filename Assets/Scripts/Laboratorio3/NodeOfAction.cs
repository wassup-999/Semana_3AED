using UnityEngine;

public enum ActionType
{
    none,
    move,
    attack,
    defend,
}
public class NodeOfAction 
{
    public Vector3 moveDir;
    public ActionType actionType;
    public int attackValue;
    public int defendValue;
}
