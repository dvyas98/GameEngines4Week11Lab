using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Systems.Health;
using System;

public class HealthComponent : MonoBehaviour, Idamagable
{

    public float Health => CurrentHealth;
    public float MaxHealth => TotalHealth;

    [SerializeField] private float CurrentHealth;
    [SerializeField] private float TotalHealth;


    private void Awake()
    {
        CurrentHealth = TotalHealth;
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        //CurrentHealth = TotalHealth;
    }

    internal void HealPlayer(int effect)
    {
        if (CurrentHealth < MaxHealth && CurrentHealth > 0)
        {
            CurrentHealth += effect;
        }
        if (CurrentHealth <=0)
        {
            Destroy();
        }
    }

    public virtual void Destroy()
    {
        Destroy(gameObject);
    }

    public virtual void TakeDamage(float damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth<=0)
        {
            Destroy();
        }
    }

}
