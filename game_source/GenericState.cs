using UnityEngine;

public abstract class GenericState : MonoBehaviour
{
	public bool GGJFEPEOLJA { get; protected set; }

	public abstract void UpdateState(bool GDHCBGCIIKG = false);

	public abstract void FixedUpdateState(bool GDHCBGCIIKG = false);

	public abstract void EnterState(bool GDHCBGCIIKG = false);

	public abstract void ExitState(bool GDHCBGCIIKG = false);

	public abstract void InitializeState(GenericStateMachine ELKILIBAAKF, bool GDHCBGCIIKG = false);
}
