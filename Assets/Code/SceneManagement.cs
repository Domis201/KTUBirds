using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
	private static int _nextLevelIndex=1;
	private Enemy[] _enemies;
	// Start is called before the first frame update
	private void OnEnable()
	{
		_enemies = FindObjectsOfType<Enemy>();
	}

	// Update is called once per frame
	void Update()
    {
		foreach (Enemy enemy in _enemies)
		{
			if (enemy != null) { return; }
		}
		string nextLevelName = "Level" + _nextLevelIndex;
		_nextLevelIndex++;
		SceneManager.LoadScene(nextLevelName);
	}
}
