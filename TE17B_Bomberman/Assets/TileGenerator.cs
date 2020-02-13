using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject tile;

    [SerializeField]
    int width = 5;

    [SerializeField]
    int height = 5;

    // Start is called before the first frame update
    void Start()
    {
        /*float offsetX = width / 2f - 0.5f;
        float offsetY = height / 2f - 0.5f;*/

        Vector3 offset = new Vector3(
            width / 2f - 0.5f,
            height / 2f - 0.5f
            );

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                PlaceTile(offset, x, y);

            }

        }
    }

    private void PlaceTile(Vector3 offset, int x, int y)
    {
        GameObject newTile = Instantiate(tile,
            new Vector3(x, y) - offset,
            Quaternion.identity);

        newTile.name = "(" + x + "," + y + ")";

        newTile.transform.parent = this.transform;
    }

    private void PlaceTile()
    {

    }

}
