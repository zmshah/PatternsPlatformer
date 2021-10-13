using UnityEngine;
using UnityEngine.Events;

public class CharacterController: MonoBehaviour
{
	//[SerializeField] private float m_JumpForce = 400f;                          // Amount of force added when the player jumps.
	//[Range(0, 1)] [SerializeField] private float m_CrouchSpeed = .36f;          // Amount of maxSpeed applied to crouching movement. 1 = 100%
	//[Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;  // How much to smooth out the movement
	//[SerializeField] private bool m_AirControl = false;                         // Whether or not a player can steer while jumping;
	//[SerializeField] private LayerMask m_WhatIsGround;                          // A mask determining what is ground to the character
	//[SerializeField] private Transform m_GroundCheck;                           // A position marking where to check if the player is grounded.
	//[SerializeField] private Transform m_CeilingCheck;                          // A position marking where to check for ceilings
	//[SerializeField] private Collider2D m_CrouchDisableCollider;                // A collider that will be disabled when crouching

	//const float k_GroundedRadius = .2f; // Radius of the overlap circle to determine if grounded
	//private bool m_Grounded;            // Whether or not the player is grounded.
	//const float k_CeilingRadius = .2f; // Radius of the overlap circle to determine if the player can stand up
	//private Rigidbody2D m_Rigidbody2D;
	//private bool m_FacingRight = true;  // For determining which way the player is currently facing.
	//private Vector3 m_Velocity = Vector3.zero;

	public PlayerMovements chactercontrol;


	[Header("Events")]
	[Space]

	public UnityEvent OnLandEvent;

	[System.Serializable]
	public class BoolEvent : UnityEvent<bool> { }

	public BoolEvent OnCrouchEvent;
	private bool m_wasCrouching = false;

	private void Awake()
	{
		chactercontrol.facadeAwake();
	}

	private void FixedUpdate()
	{
		chactercontrol.facadefixedupdate();
	}


	public void Move(float move, bool crouch, bool jump)
	{
		chactercontrol.checkmove(move, crouch, jump);
	}


	private void Flip()
	{
		chactercontrol.Flip();
	}
}
