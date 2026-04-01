using UnityEngine;

public class Player : MonoBehaviour
{
    public int attackPower;
    public int defendPower;
    public int Speed;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void Move(Vector3 dir)
    {
        Vector3 Dir = transform.forward * Speed*Time.deltaTime;
    }
    public void Attack()
    {
        Debug.Log("Attack" + attackPower);
    }
    public void Defend()
    {
        Debug.Log("Defence" + defendPower);
    }
}
