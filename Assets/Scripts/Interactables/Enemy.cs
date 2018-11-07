using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This makes our enemy interactable. */

[RequireComponent(typeof(CharacterStats))]
public class Enemy : Interactable {

	CharacterStats stats;
    Animation anim;
	int health;
	public RagdollManager ragdoll;

	void Start ()
	{
		stats = GetComponent<CharacterStats>();
        anim = GetComponent<Animation>();
        health = GetComponent<CharacterStats> ().currentHealth;
		stats.OnHealthReachedZero += Die;
	}

	// When we interact with the enemy: We attack it.
	public override void Interact()
	{
		print ("Interact");
		CharacterCombat combatManager = Player.instance.playerCombatManager;
		combatManager.Attack(stats);
	}

	void Die() {
		ragdoll.transform.parent = null;
		ragdoll.Setup ();
		Destroy (gameObject);
        if (GameObject.FindWithTag("Boss"))
        {
            anim.Play("Die");
        }
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Blade") 
		{
			GetComponent<CharacterStats> ().TakeDamage (50);
		}
	}
}
