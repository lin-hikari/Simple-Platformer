using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Platformer.Core.Simulation;
using Platformer.Gameplay;

namespace Platformer.Mechanics
{
    public class PlayerShield : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Enemy")
            {
                var enemy = col.GetComponent<EnemyController>();

                Schedule<EnemyDeath>().enemy = enemy;
            }
        }
    }
}