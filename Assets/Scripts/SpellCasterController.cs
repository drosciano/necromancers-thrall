using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCasterController : MonoBehaviour
{
    public GameObject spellPrefab;
    public GameObject Player;
    public bool CanCast = true;
    public float CastCooldown = 1.0f;
    public bool IsAttacking = false;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            if (CanCast)
            {
                SpellAttack();
                
            }
        }
    }

    void SpellAttack()
    {
        IsAttacking = true;
        CanCast = false;
        Animator anim = Player.GetComponent<Animator>();
        anim.SetTrigger("Attack");
        StartCoroutine(AnimationTimer());
        Instantiate(spellPrefab, transform.position, transform.rotation);
        StartCoroutine(ResetAttackCooldown());

    }

    IEnumerator AnimationTimer()
    {
        yield return new WaitForSeconds(2f);
        IsAttacking = false;
    }

    IEnumerator ResetAttackCooldown()
    {
        yield return new WaitForSeconds(CastCooldown);
        CanCast = true;
    }
}
