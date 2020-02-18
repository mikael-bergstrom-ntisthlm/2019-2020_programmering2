using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : TileGenerator
{

    public GameObject sideWall;
    protected override void PlaceTile(Vector3 offset, int x, int y)
    {
        if ( x == 0 || y == 0)
        {
            base.PlaceTile(offset, x, y);
        }
        else if (x == width-1 || y == height-1)
        {
            base.PlaceTile(offset, x, y);
        }
        else if (x % 3 == 0 && y % 3 == 0)
        {
            base.PlaceTile(offset, x, y);
        }
        else if (y == height-2)
        {
            base.PlaceTile(sideWall, offset, x, y);
        }
        
    }
}
