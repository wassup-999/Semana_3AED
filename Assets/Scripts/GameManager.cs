using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;
public class GameManager : MonoBehaviour
{
    //public LinkedList<string> ListaDeNombres = new();
    public CustomLinkedList HordaManagment ;
    public ActionLinkedList ActionManagment;

    public Player player;
    public Enemy enemyPref;
    void Start()
    {
        ActionManagment.Set(player);

        ActionManagment.Add(new());
        ActionManagment.Add(new());
        ActionManagment.Add(new());


        /*
        HordaManagment.Set(enemyPref);

        HordaManagment.Add(new());
        HordaManagment.Add(new());
        HordaManagment.Add(new());
        HordaManagment.Add(new());
        HordaManagment.Add(new());
        HordaManagment.Add(new());
        Debug.Log(HordaManagment.Count);*/
    }

    
    void Update()
    {
        
    }
    
    /*
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
        /*ListaDeNombres.Add("Juan");
        ListaDeNombres.Add("Juan2");
        ListaDeNombres.Add("Juan3");
        ListaDeNombres.Add("Juan4");
        ListaDeNombres.Add("Juan5");
        LinkedList<string> ListaDeNombres = new();
        foreach (string n in ListaNombres) 
        { 
            ListaDeNombres.Add(n);
        }
            //ListaDeNombres.RemoveFirst();
            ListaDeNombres.RemoveLast();


        ListaDeNombres.Traverse(value => Debug.Log(value.Value));      
    }
    */
    /*[Button]
    public void HordeSpawnTest()
    {
        HordaManagment.SpawnHorde();
    }*/
    [Button]
    public void ActionTest()
    {
        ActionManagment.ExecuteActions();
    }
}
