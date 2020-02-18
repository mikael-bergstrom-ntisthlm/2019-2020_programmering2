using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : TileGenerator
{

    protected override void MakeTile(Vector3 offset, int x, int y)
    {
        if (x == 0)
        {
            base.MakeTile(offset, x, y);
        }

    }


}
