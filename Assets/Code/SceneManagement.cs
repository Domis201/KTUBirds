using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
	private static int _nextLevelIndex=2;
	private Enemy[] _enemies;
	private Boss[] _boss;
	// Start is called before the first frame update

	void Start()
	{
		if ( (SceneManager.GetActiveScene().buildIndex+1) == (_nextLevelIndex+1))
		{
            _nextLevelIndex++;
        }

    }

	private void OnEnable()
	{
		_enemies = FindObjectsOfType<Enemy>();
		_boss = FindObjectsOfType<Boss>();
	}

	// Update is called once per frame
	void Update()
    {
		foreach (Enemy enemy in _enemies)
		{
			if (enemy != null) { return; }
		}
		foreach (Boss boss in _boss) 
		{ 
			if (boss != null) 
			{ 
				return; 
			}
		}
		string nextLevelName = "Level" + _nextLevelIndex;
		SceneManager.LoadScene(nextLevelName);
	}
}
