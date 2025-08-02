using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeNumber : MonoBehaviour
{
    NumberController controller;
    public int number;
    public float range = 0.6f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindWithTag("NumberController").GetComponent<NumberController>();
    }

    void Update()
    {
        Attack();
    }

    void Attack()
    {
        Collider2D[] enemies = Physics2D.OverlapCircleAll(transform.position, range);

        foreach (Collider2D enemy in enemies)
        {
            if (enemy.CompareTag("Player"))
            {
               
                    controller.NumberZ = number;
                    controller.check = true;
                    controller.Z.sprite = controller.Numbers[number];
                Destroy(gameObject); 
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
