using Sirenix.OdinInspector;
using UnityEngine;

//Aqui se hace casi toda la implementacion del recorrido de las acciones, se hace la implementacion de la lista enlazada y se hace el recorrido de esta para ejecutar las acciones, se hace uso de los nodos de accion para almacenar las acciones a ejecutar
public class ActionLinkedList : LinkedList<NodeOfAction>
{
    public Player Player;

    public void Set(Player player)
    {
        Player = player;
    }
    public override void Add(NodeOfAction value)
    {
        base.Add(value);
    }


    public void ExecuteAction(NodeOfAction actionNode)
    {
        switch (actionNode.actionsType)
        {
            case ActionType.none:
                Debug.Log("Nada");
                break;

            case ActionType.attack:
                Debug.Log("Atacar" );
                break;

            case ActionType.defense:
                Debug.Log("Defender");
                break;

            case ActionType.move:
                Vector3 dir = actionNode.moveDir.normalized;

                Player.transform.position += dir * Player.Speed;

                Debug.Log("Moverse");
                break;
        }
    }
   
}

