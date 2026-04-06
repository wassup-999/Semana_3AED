using UnityEngine;

public class Player : MonoBehaviour
{
    public int attackPower;
    public int defendQuantity;
    public int Speed;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
   
    public void Move()
    {     
        Vector3 dir = new Vector3(Random.Range(-1, 1), 0, Random.Range(-1, 1));
        transform.position += dir * Speed;
    }
    public void Attack()
    {
        attackPower = Random.Range(0, 100);             
    }
    public void Defend()
    {
        
        defendQuantity = Random.Range(0, 10);
    }
}
