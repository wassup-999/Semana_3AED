using Sirenix.OdinInspector;
using System;
using System.Collections;
using UnityEngine;

//Aqui se hace casi toda la implementacion del recorrido de las acciones, se hace la implementacion de la lista enlazada y se hace el recorrido de esta para ejecutar las acciones, se hace uso de los nodos de accion para almacenar las acciones a ejecutar
public class ActionLinkedList: LinkedList<NodeOfAction>
{
    public Player Player;   
    public ActionType actionType;
    public void Set(ActionType action)
    {
        actionType = action;
        
    }
    public override void Add(NodeOfAction value)
    {
        base.Add(value);
    }
    public void ExecuteAction(NodeOfAction actionNode)
    {
        if(head == null)
        {
            Debug.Log("No hay acciones para ejecutar");
            return;
        }
        switch (actionNode.actionsType)
        {
            case ActionType.none:
                
                Debug.Log("None action");
                break;

            case ActionType.attack:
                Player.Attack();
                Debug.Log("AttackPower : " + Player.attackPower );
                
                break;

            case ActionType.defense:  
                Player.Defend();
                Debug.Log("Defense : " + Player.defendQuantity);               
                break;

            case ActionType.move:
                
                Player.Move();             
                Debug.Log("The player move " );
                break;
        }
        RemoveFirst();
    }
    
    /*
    public IEnumerator ExecuteTurn()
    {
        Node<NodeOfAction> current = head;

        while (current != null)
        {
            ExecuteAction(current.Value);

            yield return new WaitForSeconds(1f);

            current = current.Next;
        }
    }
    */

}

