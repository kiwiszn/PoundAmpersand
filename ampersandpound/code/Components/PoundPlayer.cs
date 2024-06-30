using Sandbox;
using Sandbox.Citizen;

public sealed class PoundPlayer : Component
{
	[Property]
	public GameObject Camera {  get; set; }
	
	[Property]
	public CharacterController Controller { get; set; }
	[Property]
	CitizenAnimationHelper Animator { get; set; }
	[Property]
	public float WalkSpeed { get; set; } = 120f;
	[Property]
	public float RunSpeed { get; set; } = 250f;
	[Property]
	public float JumpStrength { get; set; } = 400f;

	protected override void OnUpdate()
	{
		
	}
	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
	}

	protected override void OnStart()
	{
		base.OnStart();
	}

	protected override void OnEnabled()
	{
		base.OnEnabled();
	}

	protected override void OnDisabled()
	{
		base.OnDisabled();
	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
	}
}
