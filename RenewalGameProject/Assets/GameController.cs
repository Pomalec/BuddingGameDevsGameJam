using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	[SerializeField] private List<GameObject> enemiePrefabs;

	private void Start()
	{
		enemiePrefabs.ForEach(e =>
		{
			Instantiate(e, transform);
		});
	}
}
