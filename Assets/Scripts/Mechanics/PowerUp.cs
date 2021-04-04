using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Mechanics
{
    public class PowerUp : MonoBehaviour
    {
        public AudioClip powerUpAudio;

        public PowerUpType powerType;

        void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Player")
            {
                PlayerController pc = col.gameObject.GetComponent<PlayerController>();

                switch(powerType)
                {
                    case PowerUpType.SuperJump:
                        pc.jumpTakeOffSpeed = 10;
                        break;
                    case PowerUpType.SuperSpeed:
                        pc.maxSpeed = 5;
                        break;
                    case PowerUpType.Shield:
                        pc.shield.SetActive(true);
                        col.GetComponent<SpriteRenderer>().color = Color.magenta;
                        break;
                }
            }

            GetComponent<AudioSource>().PlayOneShot(powerUpAudio);

            GetComponent<SpriteRenderer>().enabled = false;

            GetComponent<CircleCollider2D>().enabled = false;
        }

        public enum PowerUpType
        {
            SuperJump,
            SuperSpeed,
            Shield
        }
    }
}