using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;
public class CustomLinkedList : LinkedList<NodeOfHorde>
{
    public Enemy enemyPrefab =null ;

    public void Set(Enemy EnemyPrefab)
    {
        enemyPrefab = EnemyPrefab;
    }
    public override void Add(NodeOfHorde value)
    {
        base.Add(value);
    }
    public void SpawnHorde()
    {
        if (head == null)
        {
            Debug.Log("No hay más nodos");
            return;

        }
            
        for (int i = 0; i < head.Value.Quantity; i++) 
        { 
            Enemy enemy = Instantiate(enemyPrefab);
            List<string> names =new(head.Value.EnemyNames);
            enemy.EnemyName = names[Random.Range(0, names.Count)];
            enemy.Life = Random.Range(head.Value.Life -5, head.Value.Life+5);
            enemy.Str = Random.Range(head.Value.Str - 5, head.Value.Str + 5);
            enemy.SetMath(head.Value.Colors[Random.Range(0, head.Value.Colors.Count)]);
            enemy.transform.position = new Vector3(Random.Range(-10 , 10),0, Random.Range(-10, 10));

        }
        RemoveFirst();
    }
    
}
