using UnityEngine;

public enum ActionType
{
    none,
    attack,
    defense,
    move,
}
public class NodeOfAction 
{
    public Vector3 moveDir;
    public ActionType actionsType;   
}
