using UnityEngine;


public class Enemy : MonoBehaviour
{
    AudioManager audioManager;
    [SerializeField] private GameObject _cloudParticlePrefab;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Chicken bird = collision.collider.GetComponent<Chicken>();
        if (bird != null)
        {
            Instantiate(_cloudParticlePrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            audioManager.PlaySFX(audioManager.hitTheMonster);
            return;
        }

        Enemy enemy = collision.collider.GetComponent<Enemy>();
        if (enemy != null)
        {
            return;
        }

        if (collision.contacts[0].normal.y < -0.5)
        {
            Instantiate(_cloudParticlePrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            audioManager.PlaySFX(audioManager.hitTheMonster);
        }
    }
}
