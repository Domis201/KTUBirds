using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
	AudioManager audioManager;
	[SerializeField] private GameObject _cloudParticlePrefab;
	// Speed at which the boss moves
	public float moveSpeed = 2f;

	// Movement direction
	private int moveDirection = 1; // 1 for right, -1 for left

	// Initial position of the boss
	private Vector3 initialPosition;

	private void Awake()
	{
		audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
		initialPosition = transform.position;
	}

	private void Update()
	{
		// Move the boss in the current direction
		transform.Translate(Vector3.right * moveDirection * moveSpeed * Time.deltaTime);

		// Check if the boss reached the end of its current direction
		if (Mathf.Abs(transform.position.x - initialPosition.x) >= 1f)
		{
			// Change direction
			moveDirection *= -1;
		}
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

	}

}
