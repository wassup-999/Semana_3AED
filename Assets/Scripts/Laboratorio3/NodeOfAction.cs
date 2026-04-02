using UnityEngine;

public enum ActionType
{
    none,
    move,
    attack,
    defense,
}
public class NodeOfAction 
{
    public Vector3 moveDir;
    public ActionType actionsType;
    public int attackValue;
    public int defendValue;
}
