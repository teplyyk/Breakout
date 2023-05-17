using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class BlockMannager : MonoBehaviour
{
	public GameObject BlockPrefab;
	public float RowHeight;
	public float RowDistance;
	public float ColumnDistance;

	void Start()
	{
		float y = RowHeight;
		for (int i = 0; i < 4; i++)
		{
			float x = -3.5f * ColumnDistance;
			for (int j = 0; j < 8; j++)
			{
				Instantiate(BlockPrefab, new Vector3(x, y, 0.0f), Quaternion.identity);
				x += ColumnDistance;
			}
			y -= RowDistance;
		}
	}
}


