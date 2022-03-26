/*
 ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
 ||	This Enemy AI is a basic version of BreadcrumbAi which can be purchased in the Asset Store here: http://u3d.as/7Wf ||
 ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
*/

using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	private Transform player;
	private CharacterAnimation anim;
	private RaycastHit hitPlayer, left, right, forLeft, forRight;
	
	public bool playerSpotted;
	
	// Last Position variables
	private GameObject[] lastPositions;
	private GameObject closestPosition;
	private LayerMask   lastPosLayer = (1 << 10),
						enemyLayer = (1 << 9),
						playerLayer = (1 << 8);
	
	private float speed = 8f;

	// AI wall avoidance variables
	private float   avoidDist = 2f,
					avoidAngleDist = 2f,
					avoidSpeed = 100f;
	
	void Start()
	{
		player = GameObject.Find("Player").transform; // Find the player GameObject
		anim = GetComponent<CharacterAnimation>(); // Get the animation script
	}
	
	// FixedUpdate is used for physics based movement
	void FixedUpdate ()
	{
		EnemyVision(); // Call the enemey vision function
		EnemyMove(); // Call the enemy movement function
		EnemyAvoid(); // Call the enemy avoidance function
	}
	
	void EnemyVision()
	{
		if(Physics.Linecast(transform.position,player.position, out hitPlayer, ~(lastPosLayer))) // Linecast towards the player ignoring the last position layer
		{
			if(hitPlayer.collider.tag == "Player") // if the raycast hits the player then continue
			{
				playerSpotted = true; // Player has been spotted
				Debug.DrawLine(transform.position, hitPlayer.point, Color.red); //Draw a red line from the enemy to the player
			} 
			else // If the raycast doesn't hit the player then continue with ELSE
			{ 
				playerSpotted = false; // Player has not been spotted
			}
		}
	}
	
	void EnemyMove()
	{
		if(playerSpotted) // If the player has been spotted then continue
		{
			if(Vector3.Distance(transform.position,player.position) > 2) // If the distance from the player is greater than a number then continue
			{
				EnemyRotate(player.position); // Calls the rotate function sending the players position
				GetComponent<Rigidbody>().MovePosition(Vector3.MoveTowards(transform.position, player.position, Time.deltaTime * speed)); // Move the enemy towards the players position
				anim._animRun = true; // Enable the run animation
			}
			else 	// If the distance from the player is not greater than a number then continue
			{
				anim._animRun = false; // Disable the run animation
			}
		}
		else if(FindLastPosition() != null) // If the player has NOT been spotted and a last position has been found then continue **FindLastPosition() returns a GameObject
		{
			EnemyRotate(FindLastPosition().transform.position); // Rotate enemy towards the found last position game object
			GetComponent<Rigidbody>().MovePosition(Vector3.MoveTowards(transform.position, FindLastPosition().transform.position, Time.deltaTime * speed)); // Move the enemy towards the found last position game object
			anim._animRun = true; // Enable the run animation
			Debug.DrawLine(transform.position, FindLastPosition().transform.position, Color.green); // Draw a green line between the enemy and the last position
		}
		else
		{
			anim._animRun = false; // Disable the run animation
		}
	}
	
	private void EnemyRotate(Vector3 position)
	{
		GetComponent<Rigidbody>().MoveRotation(Quaternion.LookRotation(position - transform.position)); // Rotate the enemy to look towards the players position
	}
	
	private void EnemyAvoid()
	{
		// Cast a line from the Ai to the left with a distance, if the line hits anything other than a last position, an enemy, or a player, then continue
		if (Physics.Raycast(transform.position,-transform.right,out left,avoidDist, ~(lastPosLayer | enemyLayer | playerLayer)))
		{
			Debug.DrawLine(transform.position, left.point, Color.cyan); // Draw a line between the Ai position and the left hit position
			GetComponent<Rigidbody>().AddForce(transform.right * avoidSpeed); 	// Add force to the right
		} 
		else // If the cast no is no longer hitting anything the continue
		{
			GetComponent<Rigidbody>().velocity = Vector3.zero; // Stops all rigidbody movement, this removes any sliding around
		}
		// Cast a line from the Ai to the right with a distance, if the line hits anything other than a last position, an enemy, or a player, then continue
		if (Physics.Raycast(transform.position,transform.right,out right,avoidDist, ~(lastPosLayer | enemyLayer | playerLayer)))
		{
			Debug.DrawLine(transform.position, right.point, Color.cyan);// Draw a line between the Ai position and the right hit position
			GetComponent<Rigidbody>().AddForce(-transform.right * avoidSpeed); // Add force to the left
		} 
		else // If the cast no is no longer hitting anything the continue
		{
			GetComponent<Rigidbody>().velocity = Vector3.zero;// Stops all rigidbody movement, this removes any sliding around
		}
		// Cast a line from the Ai to its forward left with a distance, if the line hits anything other than a last position, an enemy, or a player, then continue
		if (Physics.Raycast(transform.position,transform.forward + -transform.right *2,out forLeft,avoidAngleDist, ~(lastPosLayer | enemyLayer | playerLayer)))
		{
			Debug.DrawLine(transform.position, forLeft.point, Color.cyan);// Draw a line between the Ai position and the forward left hit position
			GetComponent<Rigidbody>().AddForce(transform.right * avoidSpeed);			// Add force to the right
		} 
		else // If the cast no is no longer hitting anything the continue
		{
			GetComponent<Rigidbody>().velocity = Vector3.zero;// Stops all rigidbody movement, this removes any sliding around
		}
		// Cast a line from the Ai to its forward right with a distance, if the line hits anything other than a last position, an enemy, or a player, then continue
		if (Physics.Raycast(transform.position,transform.forward + transform.right * 2,out forRight,avoidAngleDist, ~(lastPosLayer | enemyLayer | playerLayer)))
		{
			Debug.DrawLine(transform.position, forRight.point, Color.cyan);// Draw a line between the Ai position and the forward right hit position
			GetComponent<Rigidbody>().AddForce(-transform.right * avoidSpeed);// Add force to the left
		} 
		else // If the cast no is no longer hitting anything the continue
		{
			GetComponent<Rigidbody>().velocity = Vector3.zero;// Stops all rigidbody movement, this removes any sliding around
		}
	}
	
	private GameObject FindLastPosition()
	{
		lastPositions = GameObject.FindGameObjectsWithTag("LastPosition"); // Find all game objects with a tag
		float distance = Mathf.Infinity; // set a float for an infinit distance this (this can be changed to a distance value)
		
		for(int i = 0; i < lastPositions.Length; i++) // For every lastPositions that was found with the above tag
		{
			RaycastHit hitLastPos;
			if(Physics.Raycast(transform.position, lastPositions[i].transform.position - transform.position, out hitLastPos)) // Cast a line from the Ai to the next lastPosition in sequence
			{
				if(hitLastPos.collider.tag == "LastPosition") // If the raycast hits a game object with a tag then continue
				{
					Vector2 diff = lastPositions[i].transform.position - player.position; // Set a vector distance from the last position to the player
					float curDistance = diff.sqrMagnitude; // Apply squared magnitude to the vector for distance comparison
					if (curDistance < distance) // If the current distance from the last position is less than the set distance
					{
						closestPosition = lastPositions[i]; // Set the closestPosition game object to equal the last position that has been found
						distance = curDistance; // Set the distance to the current distance
					}
				}
			}
		}
		return closestPosition; // Return the closestPosition game object that was found
	}
}