using UnityEngine;
using UnityEngine.AI;

public class NavMesh2D : MonoBehaviour
{
    [SerializeField] Transform target;

    [SerializeField] ParticleSystem deathParticles;

    NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 0;
    }

    private void Update()
    {
        agent.SetDestination(target.position);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet"))
        {
            ParticleSystem particles = Instantiate(deathParticles, transform.position, Quaternion.identity);
            particles.Play();
            Destroy(gameObject);
        } else if(collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Health>().damage();
            Destroy(gameObject);
        }
    }
}