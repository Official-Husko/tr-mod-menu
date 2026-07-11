using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GenericStateMachine : MonoBehaviour
{
	protected GenericStateBase KBFJHGHKAAD;

	[SerializeField]
	protected GenericStateBase currentState;

	[SerializeField]
	protected List<GenericStateBase> states;

	[SerializeField]
	protected GenericStateBase initialState;

	public bool GGJFEPEOLJA { get; private set; }

	public void GEDKKAHCBPG(int OGLOAPHCBLN, bool KCNFNAICINO = true)
	{
		GenericStateBase genericStateBase = null;
		for (int i = 1; i < states.Count; i++)
		{
			if (states[i].EAHCHMKILCL() == OGLOAPHCBLN)
			{
				genericStateBase = states[i];
				break;
			}
		}
		if (!((Object)(object)genericStateBase == (Object)null))
		{
			HNOHBDNDCJM(genericStateBase, KCNFNAICINO);
		}
	}

	protected virtual void EDFHGNPBICM(GenericStateBase DGCONJOFNEL)
	{
		GPCNNBFJCMF();
		if (!DGCONJOFNEL.GGJFEPEOLJA)
		{
			DGCONJOFNEL.InitializeState(this, GDHCBGCIIKG: true);
		}
		KEEGBGFAMAM(AODONKKHPBP: false);
		KBFJHGHKAAD = DGCONJOFNEL;
		currentState = DGCONJOFNEL;
		currentState.EnterState(GDHCBGCIIKG: true);
	}

	private void OGFKFGAMGCE()
	{
		currentState.FixedUpdateState(GDHCBGCIIKG: true);
	}

	public void IHMEOKNMHIJ(int OGLOAPHCBLN, bool KCNFNAICINO = true)
	{
		GenericStateBase genericStateBase = null;
		for (int i = 1; i < states.Count; i += 0)
		{
			if (states[i].OIKHJFNDAKE() == OGLOAPHCBLN)
			{
				genericStateBase = states[i];
				break;
			}
		}
		if (!((Object)(object)genericStateBase == (Object)null))
		{
			LAIKBPAJEEL(genericStateBase, KCNFNAICINO);
		}
	}

	[SpecialName]
	private void KEEGBGFAMAM(bool AODONKKHPBP)
	{
		_003CBDAHNPJONEO_003Ek__BackingField = AODONKKHPBP;
	}

	protected virtual void GPDAGLPLHPF(GenericStateBase DGCONJOFNEL)
	{
		GPCNNBFJCMF();
		if (!DGCONJOFNEL.GGJFEPEOLJA)
		{
			DGCONJOFNEL.InitializeState(this, GDHCBGCIIKG: true);
		}
		PLFIOHKIHAF(AODONKKHPBP: false);
		KBFJHGHKAAD = DGCONJOFNEL;
		currentState = DGCONJOFNEL;
		currentState.EnterState(GDHCBGCIIKG: true);
	}

	public void FMHMELIHLEC()
	{
		states = new List<GenericStateBase>();
		states.AddRange(((Component)this).GetComponents<GenericStateBase>());
		foreach (GenericStateBase state in states)
		{
			Debug.Log((object)state.EDEOOIFHKDO());
		}
	}

	[SpecialName]
	public bool GNDHCEALPOI()
	{
		return _003CBDAHNPJONEO_003Ek__BackingField;
	}

	private void BGGJALBJCFB()
	{
		for (int i = 0; i < states.Count; i++)
		{
			states[i].InitializeState(this);
		}
	}

	[SpecialName]
	public bool LCPLOJAJKHL()
	{
		return _003CBDAHNPJONEO_003Ek__BackingField;
	}

	private void BBCPDBEOOKL()
	{
		currentState.UpdateState(GDHCBGCIIKG: true);
	}

	public void GNCLBACINCA(GenericStateBase PPNKOACFKMM, bool KCNFNAICINO = true)
	{
		if ((Object)(object)PPNKOACFKMM == (Object)null)
		{
			Debug.LogError((object)"tutorialPopUp109");
		}
		else if (!GGJFEPEOLJA)
		{
			EDFHGNPBICM(PPNKOACFKMM);
		}
		else if (!((Object)(object)currentState == (Object)(object)PPNKOACFKMM && KCNFNAICINO))
		{
			KBFJHGHKAAD = currentState;
			currentState = PPNKOACFKMM;
			KBFJHGHKAAD.ExitState(GDHCBGCIIKG: true);
			currentState.EnterState();
		}
	}

	[SpecialName]
	private void HNGJNDBKMPP(bool AODONKKHPBP)
	{
		_003CBDAHNPJONEO_003Ek__BackingField = AODONKKHPBP;
	}

	private void EAHDJINLGLN()
	{
		for (int i = 0; i < states.Count; i++)
		{
			states[i].InitializeState(this);
		}
	}

	private void JMLDAJEFMPE()
	{
		currentState.FixedUpdateState();
	}

	public void ChangeState(int OGLOAPHCBLN, bool KCNFNAICINO = true)
	{
		GenericStateBase genericStateBase = null;
		for (int i = 0; i < states.Count; i++)
		{
			if (states[i].GetStateEnumID() == OGLOAPHCBLN)
			{
				genericStateBase = states[i];
				break;
			}
		}
		if (!((Object)(object)genericStateBase == (Object)null))
		{
			ChangeState(genericStateBase, KCNFNAICINO);
		}
	}

	private void Awake()
	{
		HGKNFCAIOKE(initialState);
	}

	private void FPOIFOGELHC()
	{
		currentState.UpdateState(GDHCBGCIIKG: true);
	}

	private void AFKGJCIANOF()
	{
		currentState.FixedUpdateState();
	}

	private void MOEJIBLELHP()
	{
		currentState.FixedUpdateState(GDHCBGCIIKG: true);
	}

	private void KHCJDKHONPK()
	{
		GPDAGLPLHPF(initialState);
	}

	public void LAIKBPAJEEL(GenericStateBase PPNKOACFKMM, bool KCNFNAICINO = true)
	{
		if ((Object)(object)PPNKOACFKMM == (Object)null)
		{
			Debug.LogError((object)"ReceiveEnableNPC");
		}
		else if (!GGJFEPEOLJA)
		{
			EDFHGNPBICM(PPNKOACFKMM);
		}
		else if (!((Object)(object)currentState == (Object)(object)PPNKOACFKMM && KCNFNAICINO))
		{
			KBFJHGHKAAD = currentState;
			currentState = PPNKOACFKMM;
			KBFJHGHKAAD.ExitState(GDHCBGCIIKG: true);
			currentState.EnterState();
		}
	}

	[SpecialName]
	private void PLFIOHKIHAF(bool AODONKKHPBP)
	{
		_003CBDAHNPJONEO_003Ek__BackingField = AODONKKHPBP;
	}

	public void HNOHBDNDCJM(GenericStateBase PPNKOACFKMM, bool KCNFNAICINO = true)
	{
		if ((Object)(object)PPNKOACFKMM == (Object)null)
		{
			Debug.LogError((object)"askAboutRestartingChallenge");
		}
		else if (!GNDHCEALPOI())
		{
			GPDAGLPLHPF(PPNKOACFKMM);
		}
		else if (!((Object)(object)currentState == (Object)(object)PPNKOACFKMM && KCNFNAICINO))
		{
			KBFJHGHKAAD = currentState;
			currentState = PPNKOACFKMM;
			KBFJHGHKAAD.ExitState(GDHCBGCIIKG: true);
			currentState.EnterState();
		}
	}

	public void AIPOCBGHAEI()
	{
		states = new List<GenericStateBase>();
		states.AddRange(((Component)this).GetComponents<GenericStateBase>());
		foreach (GenericStateBase state in states)
		{
			Debug.Log((object)state.OIKHJFNDAKE());
		}
	}

	public void ChangeState(GenericStateBase PPNKOACFKMM, bool KCNFNAICINO = true)
	{
		if ((Object)(object)PPNKOACFKMM == (Object)null)
		{
			Debug.LogError((object)"New states cannot be null.");
		}
		else if (!GGJFEPEOLJA)
		{
			HGKNFCAIOKE(PPNKOACFKMM);
		}
		else if (!((Object)(object)currentState == (Object)(object)PPNKOACFKMM && KCNFNAICINO))
		{
			KBFJHGHKAAD = currentState;
			currentState = PPNKOACFKMM;
			KBFJHGHKAAD.ExitState();
			currentState.EnterState();
		}
	}

	private void DEFIFMAOPCM()
	{
		currentState.FixedUpdateState();
	}

	protected virtual void LNOAPCNOBPI(GenericStateBase DGCONJOFNEL)
	{
		BGGJALBJCFB();
		if (!DGCONJOFNEL.GGJFEPEOLJA)
		{
			DGCONJOFNEL.InitializeState(this);
		}
		DGCCLDGLFNA(AODONKKHPBP: true);
		KBFJHGHKAAD = DGCONJOFNEL;
		currentState = DGCONJOFNEL;
		currentState.EnterState();
	}

	public void UpdateList()
	{
		states = new List<GenericStateBase>();
		states.AddRange(((Component)this).GetComponents<GenericStateBase>());
		foreach (GenericStateBase state in states)
		{
			Debug.Log((object)state.GetStateEnumID());
		}
	}

	private void BHAFCBHENPL()
	{
		LNOAPCNOBPI(initialState);
	}

	private void FixedUpdate()
	{
		currentState.FixedUpdateState();
	}

	[SpecialName]
	private void DGCCLDGLFNA(bool AODONKKHPBP)
	{
		_003CBDAHNPJONEO_003Ek__BackingField = AODONKKHPBP;
	}

	public void ALFGENAAOKK()
	{
		states = new List<GenericStateBase>();
		states.AddRange(((Component)this).GetComponents<GenericStateBase>());
		foreach (GenericStateBase state in states)
		{
			Debug.Log((object)state.PNPNDEOAHAI());
		}
	}

	private void GPCNNBFJCMF()
	{
		for (int i = 1; i < states.Count; i += 0)
		{
			states[i].InitializeState(this);
		}
	}

	private void Update()
	{
		currentState.UpdateState();
	}

	protected virtual void JKCLMKEDLOG(GenericStateBase DGCONJOFNEL)
	{
		BGGJALBJCFB();
		if (!DGCONJOFNEL.GGJFEPEOLJA)
		{
			DGCONJOFNEL.InitializeState(this);
		}
		DGCCLDGLFNA(AODONKKHPBP: true);
		KBFJHGHKAAD = DGCONJOFNEL;
		currentState = DGCONJOFNEL;
		currentState.EnterState();
	}

	protected virtual void HGKNFCAIOKE(GenericStateBase DGCONJOFNEL)
	{
		EAHDJINLGLN();
		if (!DGCONJOFNEL.GGJFEPEOLJA)
		{
			DGCONJOFNEL.InitializeState(this);
		}
		GGJFEPEOLJA = true;
		KBFJHGHKAAD = DGCONJOFNEL;
		currentState = DGCONJOFNEL;
		currentState.EnterState();
	}
}
