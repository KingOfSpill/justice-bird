using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class GridTests {

	[Test]
	public void startPopulatesGrid() {

        GameObject gridContainer = new GameObject();
        Grid grid = gridContainer.AddComponent<Grid>();

        grid.gridObject = new GameObject();

        grid.gridCamera = gridContainer.AddComponent<Camera>();

        grid.Start();

        Assert.IsFalse(grid.grid.Length == 0);

	}

}
