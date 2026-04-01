using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string EnemyName;
    public int Life;
    public float Str;
    public Material Mat;
    public void Awake()
    {
        Mat=GetComponent<MeshRenderer>().material;
        
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void SetMath(Color color)
    {
        Mat.color=color;
    }
}
