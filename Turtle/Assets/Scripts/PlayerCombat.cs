using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public LayerMask enemyLayers;

    public float attackRange = 0.5f;
    public int attackDamage = 40;

    public float attackRate = 3f;
    float nextAttackTime = 0f;

 

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            // currently in conflict with  die if (Input.GetKeyDown(KeyCode.Space))
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }


     
    }


  




    void Attack()
    {
        //Play Attack animation
        animator.SetTrigger("Attack");

        //Detect enemies in range of attack
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        // Damage enemy
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }

    }



    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.color = new Color(1, 1, 0, 0.75F);
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);


    }



}

 
