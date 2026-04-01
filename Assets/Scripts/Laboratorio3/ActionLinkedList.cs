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

    
    public void ExecuteActions()
    {
        if (head == null)
        {
            Debug.Log("No hay más nodos");
            return;
        }
        
        while (head != null)
        {
            switch (head.Value.actionType)
            {
                case ActionType.none:
                    Debug.Log("No hay acción");
                    break;

                case ActionType.move:
                    Player.Move(head.Value.moveDir);
                    break;

                case ActionType.attack:
                    Player.Attack();
                    break;


                case ActionType.defend:
                    Player.Defend();
                    break;
            }
            head = head.Next;
        }       
    }
}
