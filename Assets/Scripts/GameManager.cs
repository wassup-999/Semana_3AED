using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    
    public void CreateActions()
    {

        NodeOfAction attack = new NodeOfAction
        {
            actionsType = ActionType.attack,
            attackValue = 10
        };

        NodeOfAction defense = new NodeOfAction
        {
            actionsType = ActionType.defense,
            defendValue = 5
        };

        NodeOfAction move = new NodeOfAction
        {
            actionsType = ActionType.move,
            moveDir = new Vector3(Random.Range(-1, 1), 0, Random.Range(-1, 1)),
        };

        ActionManagment.Add(attack);
        ActionManagment.Add(defense);
        ActionManagment.Add(move);


    }
    public IEnumerator ExecuteTurn()
    {
        Node<NodeOfAction> current = ActionManagment.head;

        while (current != null)
        {
            ActionManagment.ExecuteAction(current.Value);

            yield return new WaitForSeconds(1f);

            current = current.Next;
        }
    }
}
