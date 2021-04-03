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
                switch(powerType)
                {
                    case PowerUpType.SuperJump:
                        return;
                    case PowerUpType.SuperSpeed:
                        return;
                    case PowerUpType.Shield:
                        return;
                }
            }
        }

        public enum PowerUpType
        {
            SuperJump,
            SuperSpeed,
            Shield
        }
    }
}