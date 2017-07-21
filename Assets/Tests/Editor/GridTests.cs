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

    [Test]
    public void gridToWorldPositionGivesUpperRightMostPositionIfXAndYAreGreaterThanMax()
    {

        GameObject gridContainer = new GameObject();
        Grid grid = gridContainer.AddComponent<Grid>();

        grid.gridObject = new GameObject();

        grid.gridCamera = gridContainer.AddComponent<Camera>();
        grid.Start();

        Vector3 givenPosition = grid.gridToWorldPosition(grid.gridWidth, grid.gridHeight);
        Vector3 expectedPosition = grid.grid[grid.gridWidth - 1, grid.gridHeight - 1].transform.position;

        Assert.IsTrue(expectedPosition == givenPosition);

    }

    [Test]
    public void gridToWorldPositionGivesLowerRightMostPositionIfXAndYAreLessThanMin()
    {

        GameObject gridContainer = new GameObject();
        Grid grid = gridContainer.AddComponent<Grid>();

        grid.gridObject = new GameObject();

        grid.gridCamera = gridContainer.AddComponent<Camera>();
        grid.Start();

        Vector3 givenPosition = grid.gridToWorldPosition(-1, -1);
        Vector3 expectedPosition = grid.grid[0, 0].transform.position;

        Assert.IsTrue(expectedPosition == givenPosition);

    }

    [Test]
    public void gridToForwardAxisGivesUpperRightMostAxisIfXAndYAreGreaterThanMax()
    {

        GameObject gridContainer = new GameObject();
        Grid grid = gridContainer.AddComponent<Grid>();

        grid.gridObject = new GameObject();

        grid.gridCamera = gridContainer.AddComponent<Camera>();
        grid.Start();

        Vector3 givenAxis = grid.gridToForwardAxis(grid.gridWidth, grid.gridHeight);
        Vector3 expectedAxis = grid.grid[grid.gridWidth - 1, grid.gridHeight - 1].transform.forward;

        Assert.IsTrue(expectedAxis == givenAxis);

    }

    [Test]
    public void gridToForwardAxisGivesLowerRightMostAxisIfXAndYAreLessThanMin()
    {

        GameObject gridContainer = new GameObject();
        Grid grid = gridContainer.AddComponent<Grid>();

        grid.gridObject = new GameObject();

        grid.gridCamera = gridContainer.AddComponent<Camera>();
        grid.Start();

        Vector3 givenAxis = grid.gridToForwardAxis(-1, -1);
        Vector3 expectedAxis = grid.grid[0, 0].transform.forward;

        Assert.IsTrue(expectedAxis == givenAxis);

    }

}
