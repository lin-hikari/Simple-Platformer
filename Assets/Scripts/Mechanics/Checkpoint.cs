using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Mechanics
{
    public class Checkpoint : MonoBehaviour
    {
        private bool isActive = false;

        private Vector2 respawnPos;

        public AudioClip checkpointAudio;

        private void Start()
        {
            //Adjusts position of the spawn relative to the checkpoint object in the scene
            respawnPos = this.gameObject.transform.position - new Vector3(0f, 0.4f);
        }

        void OnTriggerEnter2D(Collider2D col)
        {
            if((col.tag == "Player")&&(!isActive))
            {
                isActive = true;

                col.gameObject.GetComponent<PlayerController>().respawnPoint = respawnPos;

                GetComponent<SpriteRenderer>().color = Color.white;

                GetComponent<AudioSource>().PlayOneShot(checkpointAudio);
            }
        }
    }
}