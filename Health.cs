using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Health : MonoBehaviour
{
    [SerializeField] int lives = 3;

    [SerializeField] AudioSource hitSource;

    [SerializeField] Animator deadAnim;

    [SerializeField] ParticleSystem deadParticles;

    [SerializeField] Timer timer;

    [SerializeField] Camera mainCamera;

    public bool IsDead { get; set; }
    public bool Imortal { get; set; }

    private void Start()
    {
        Imortal = false;
        IsDead = false;
    }
    public void damage()
    {
        if (!Imortal) { 
        lives--;
        mainCamera.GetComponent<CameraShake>().shake();
        FindObjectOfType<InGameUI>().updateLivesText(lives);
        hitSource.Play();
            if (lives == 0)
            {
                IsDead = true;
                deadAnim.SetTrigger("DeadAnim");
                deadParticles.Play();
                GetComponent<SpriteRenderer>().enabled = false;
                GetComponent<CircleCollider2D>().enabled = false;
                GetComponent<Shooting>().enabled = false;
            }
        }
    }
}
