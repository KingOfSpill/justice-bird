using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {

	public GameObject gridObject;
	public int gridHeight = 3;
    public int gridWidth = 3;

    public GameObject[,] grid;

    public Camera gridCamera;
    
	public void Start ()
    {
		
		grid = new GameObject[gridWidth,gridHeight];

		Vector3 gridViewportPosition = gridCamera.WorldToViewportPoint( transform.position );		

		for( int i = 0; i < gridWidth; i++ )
		{
			for( int j = 0; j < gridHeight; j++)
			{

				float xScreenPosition = (i + 0.5f)/gridWidth;
				float yScreenPosition = (j + 0.5f)/gridHeight;

				Vector3 position = gridCamera.ViewportToWorldPoint( new Vector3( xScreenPosition, yScreenPosition, gridViewportPosition.z ) );

				grid[i,j] = Instantiate( gridObject, position, transform.rotation, transform );

			}
		}

	}

	public Vector3 gridToWorldPosition( int x, int y ){

		x = clampXToGrid( x );
		y = clampYToGrid( y );

		return grid[x,y].transform.position;

	}

	public Vector3 gridToForwardAxis( int x, int y ){

		x = clampXToGrid( x );
		y = clampYToGrid( y );

		return grid[x,y].transform.forward;

	}

	public int clampXToGrid( int x ){

		return Mathf.Clamp( x, 0, gridWidth-1 );

	}

	public int clampYToGrid( int y ){

		return Mathf.Clamp( y, 0, gridHeight-1 );

	}

	public int getXCenter( ){

		return (gridWidth/2);

	}

	public int getYCenter( ){

		return (gridHeight/2);

	}

}
