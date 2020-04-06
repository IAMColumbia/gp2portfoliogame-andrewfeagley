using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour, IDamageable
{
    private float moveSpeed;
    private int health;
    private int shields;
    public int Health { get => health; set => health = value; }
    public int Shields { get => shields; set => shields = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2.MoveTowards(this.transform.position, Vector2.zero, moveSpeed);
    }
}
