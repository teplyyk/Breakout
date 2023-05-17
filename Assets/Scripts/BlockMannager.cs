using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class BlockMannager : MonoBehaviour
{
    public GameObject BlockPrefab;
    public float RowHeight;
    public float BlockHorizontalDistance;
    public float BlockVerticalDistance;
    void Start()
    {
        Vector3 BlockPosition = new Vector3(0 - BlockHorizontalDistance * 3.5f, RowHeight, 0);

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Instantiate(BlockPrefab, BlockPosition, Quaternion.identity);
                BlockPosition.x += BlockHorizontalDistance;
            }
            
        }
    }
}


