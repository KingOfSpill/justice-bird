using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class BirdControllerTests {

	GameObject mockBird;
	BirdController birdController;

	[Test]
	public void BirdMovesUpWithPositiveVerticalInput() {

		mockBird = new GameObject();

		birdController = mockBird.AddComponent<BirdController>();

		birdController.grid = mockBird.AddComponent<Grid>();

		birdController.gridY = 0;

		int gridY = birdController.gridY;

		birdController.updateGridPosition( 1f, 0f );

		Assert.IsTrue( birdController.gridY > gridY );

	}

	[Test]
	public void BirdMovesDownWithNegativeVerticalInput() {

		mockBird = new GameObject();

		birdController = mockBird.AddComponent<BirdController>();

		birdController.grid = mockBird.AddComponent<Grid>();

		birdController.gridY = birdController.grid.gridHeight - 1;

		int gridY = birdController.gridY;

		birdController.updateGridPosition( -1f, 0f );

		Assert.IsTrue( birdController.gridY < gridY );

	}

	[Test]
	public void BirdMovesRightWithPositiveHorizontalInput() {

		mockBird = new GameObject();

		birdController = mockBird.AddComponent<BirdController>();

		birdController.grid = mockBird.AddComponent<Grid>();

		birdController.gridX = 0;

		int gridX = birdController.gridX;

		birdController.updateGridPosition( 0f, 1f );

		Assert.IsTrue( birdController.gridX > gridX );

	}

	[Test]
	public void BirdMovesLeftWithNegativeHorizontalInput() {

		mockBird = new GameObject();

		birdController = mockBird.AddComponent<BirdController>();

		birdController.grid = mockBird.AddComponent<Grid>();

		birdController.gridX = birdController.grid.gridWidth - 1;

		int gridX = birdController.gridX;

		birdController.updateGridPosition( 0f, -1f );

		Assert.IsTrue( birdController.gridX < gridX );

	}

	[Test]
	public void BirdCantMoveOffGridUp() {

		mockBird = new GameObject();

		birdController = mockBird.AddComponent<BirdController>();

		birdController.grid = mockBird.AddComponent<Grid>();

		birdController.gridY = birdController.grid.gridHeight - 1;

		birdController.updateGridPosition( 1f, 0f );

		Assert.IsTrue( birdController.gridY == birdController.grid.gridHeight - 1 );

	}

	[Test]
	public void BirdCantMoveOffGridDown() {

		mockBird = new GameObject();

		birdController = mockBird.AddComponent<BirdController>();

		birdController.grid = mockBird.AddComponent<Grid>();

		birdController.gridY = 0;

		birdController.updateGridPosition( -1f, 0f );

		Assert.IsTrue( birdController.gridY == 0 );

	}

	[Test]
	public void BirdCantMoveOffGridLeft() {

		mockBird = new GameObject();

		birdController = mockBird.AddComponent<BirdController>();

		birdController.grid = mockBird.AddComponent<Grid>();

		birdController.gridX = 0;

		birdController.updateGridPosition( 0f, -1f );

		Assert.IsTrue( birdController.gridX == 0 );

	}

	[Test]
	public void BirdCantMoveOffGridRight() {

		mockBird = new GameObject();

		birdController = mockBird.AddComponent<BirdController>();

		birdController.grid = mockBird.AddComponent<Grid>();

		birdController.gridX = birdController.grid.gridWidth - 1;

		birdController.updateGridPosition( 0f, 1f );

		Assert.IsTrue( birdController.gridX == birdController.grid.gridWidth - 1 );

	}

}
