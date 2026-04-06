using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public LinkedList<string> ListaDeNombres = new();
    public CustomLinkedList HordaManagment;
    //public ActionLinkedList ActionManagment;
    public ActionLinkedList<ActionType> TypesOfActions = new();

    public ActionType actionType;
    public Enemy enemyPref;
    void Start()
    {

        /*
        HordaManagment.Set(enemyPref);
        
        HordaManagment.Add(new());
        HordaManagment.Add(new());
        HordaManagment.Add(new());
        HordaManagment.Add(new());
        HordaManagment.Add(new());
        HordaManagment.Add(new());
        Debug.Log(HordaManagment.Count);
        */
    }


    void Update()
    {

    }

    
    public void TestMethod()
    {
        Debug.Log("j3zzz");
    }
    
    public void TestModes()
    {
        Node<string> a = new("juan");
        Node<string> b = new("juan2");
        Node<string> c = new("juan3");
        Node<string> d = new("juan4");
        Node<string> e = new("juan5");
        a.SetNext(b);
        b.SetNext(c);
        c.SetNext(d);
        d.SetNext(e);
        Node<string> Evaluator = a;

        while(Evaluator.Next != null)
        {
            Debug.Log(Evaluator.Value);
            Evaluator = Evaluator.Next;
        }
    }

    [Button]
    public void TestLinkedList(List<string> ListaNombres) 
    {
        LinkedList<string> ListaDeNombres = new();
        foreach (string n in ListaNombres) 
        { 
            ListaDeNombres.Add(n);
        }
             
            //ListaDeNombres.RemoveFirst();
            ListaDeNombres.RemoveLast();


        ListaDeNombres.Traverse(value => Debug.Log(value.Value));      
    }
    
    [Button]
    public void HordeSpawnTest()
    {
        HordaManagment.SpawnHorde();
    }

    [Button]
    public void TestActionList(List<ActionType> ActionManagment)
    {
        ActionLinkedList<ActionType> TypesOfActions = new();
        foreach (ActionType n in ActionManagment)
        {
            ActionManagment.Add((ActionType.none));
            ActionManagment.Add((ActionType.attack));
            ActionManagment.Add(ActionType.defense);
            ActionManagment.Add(ActionType.move);
        }
      
        //ActionManagment.Traverse(value => Debug.Log(value.Value));
    }
    

    
    /*
    [Button]
    
    public void ActionsTest(NodeOfAction actionNode)
    {
        
        ActionManagment.ExecuteAction(actionNode);
        ActionManagment.Set(actionType);
        ActionManagment.Add(new());
        ActionManagment.Add(new ());
        ActionManagment.Add(new());
        ActionManagment.Add(new());      
        
    }
    */
}

