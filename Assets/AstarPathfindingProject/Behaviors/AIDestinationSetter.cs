using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace Pathfinding {
	/// <summary>
	/// Sets the destination of an AI to the position of a specified object.
	/// This component should be attached to a GameObject together with a movement script such as AIPath, RichAI or AILerp.
	/// This component will then make the AI move towards the <see cref="target"/> set on this component.
	///
	/// See: <see cref="Pathfinding.IAstarAI.destination"/>
	///
	/// [Open online documentation to see images]
	/// </summary>
	[UniqueComponent(tag = "ai.destination")]
	[HelpURL("http://arongranberg.com/astar/docs/class_pathfinding_1_1_a_i_destination_setter.php")]
	public class AIDestinationSetter : VersionedMonoBehaviour {
		Vector3 mouse;
		/// <summary>The object that the AI should move to</summary>
		public Transform target;
		IAstarAI ai;
		public Camera cam;
		public Animator animator;
		public GameObject Player;
		int mouseCount = 0;
		void OnEnable () {
			ai = GetComponent<IAstarAI>();
			// Update the destination right before searching for a path as well.
			// This is enough in theory, but this script will also update the destination every
			// frame as the destination is used for debugging and may be used for other things by other
			// scripts as well. So it makes sense that it is up to date every frame.
			if (ai != null) ai.onSearchPath += Update;
		}

		void OnDisable () {
			if (ai != null) ai.onSearchPath -= Update;
		}

		/// <summary>Updates the AI's destination every frame</summary>
		void Update () {

			Vector3 newPosition = Vector3.zero;
			
			if (Input.GetButtonDown("Fire1"))
			{
				PlayerPrefs.SetInt("NewGameOutside",0);
				bool positionFound = false;
				mouseCount++;
				newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
				newPosition.z = 0;
				positionFound = true;
				if(newPosition.x>Player.transform.position.x){
					transform.localScale = new Vector2(-0.3f, transform.localScale.y);
				}
				else{
					transform.localScale = new Vector2(0.3f, transform.localScale.y);
				}

				if (positionFound && newPosition != ai.destination)
				{
					if (ai != null) ai.destination = newPosition;
				}
			}
			var distanceToEnd = Player.GetComponent<AIPath>().remainingDistance;
			if(distanceToEnd >= 0.1f && mouseCount>0){
				animator.SetBool("isWalking",true);
			}
			else{
				animator.SetBool("isWalking",false);
			}
		}

		void OnTriggerEnter2D(Collider2D collide){
			if(collide.gameObject.tag == "Garden"){
				SceneManager.LoadScene("Garden-Try", LoadSceneMode.Single);
				PlayerPrefs.SetInt("Task3",1);
			}
			else if(collide.gameObject.tag == "House"){
				SceneManager.LoadScene("Shop", LoadSceneMode.Single);
			}
		}
	}
}
