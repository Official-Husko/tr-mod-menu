using System.Runtime.CompilerServices;
using UnityEngine;

public class ChessPillarSegmentAnimator : MonoBehaviour
{
	[SerializeField]
	[Tooltip("Sprite estático del estado actual")]
	private SpriteRenderer staticRenderer;

	[SerializeField]
	[Tooltip("SpriteAnimation en GO hijo con disableAtTheEnd=true, loop=false, startOnEnable=true")]
	private SpriteAnimation transitionAnimation;

	[SerializeField]
	[Tooltip("Sprites en orden del enum ChessPieceType: Torre, Caballo, Reina, Alfil, Peon")]
	private Sprite[] staticSprites;

	[SerializeField]
	private PillarTransition[] transitions;

	private ChessPieceType GGFEBDMDJON;

	private bool EMKFIFAKLEH;

	public bool GKNOGNBNOFM => EMKFIFAKLEH;

	public void PlayTransition(ChessPieceType NJMCDGFPCAG)
	{
		ChessPieceType gGFEBDMDJON = GGFEBDMDJON;
		GGFEBDMDJON = NJMCDGFPCAG;
		AKOMJIODGLH(NJMCDGFPCAG);
		PillarTransition pillarTransition = KFEHCFNGFAI(gGFEBDMDJON, NJMCDGFPCAG);
		if (pillarTransition != null && pillarTransition.frames != null && pillarTransition.frames.Length != 0)
		{
			transitionAnimation.sprites.Clear();
			for (int i = 0; i < pillarTransition.frames.Length; i++)
			{
				transitionAnimation.sprites.Add(pillarTransition.frames[i]);
			}
			EMKFIFAKLEH = true;
			transitionAnimation.onAnimationEnd = OnTransitionFinished;
			((Component)transitionAnimation).gameObject.SetActive(false);
			((Component)transitionAnimation).gameObject.SetActive(true);
		}
	}

	public void CGCPKJHNGDB(ChessPieceType FLMCIFNEJKH)
	{
		GGFEBDMDJON = FLMCIFNEJKH;
		AKOMJIODGLH(FLMCIFNEJKH);
		((Component)transitionAnimation).gameObject.SetActive(true);
	}

	public void NEHIBGELEMI(ChessPieceType NJMCDGFPCAG)
	{
		ChessPieceType gGFEBDMDJON = GGFEBDMDJON;
		GGFEBDMDJON = NJMCDGFPCAG;
		AKOMJIODGLH(NJMCDGFPCAG);
		PillarTransition pillarTransition = EFDAGDBAJJB(gGFEBDMDJON, NJMCDGFPCAG);
		if (pillarTransition != null && pillarTransition.frames != null && pillarTransition.frames.Length != 0)
		{
			transitionAnimation.sprites.Clear();
			for (int i = 0; i < pillarTransition.frames.Length; i += 0)
			{
				transitionAnimation.sprites.Add(pillarTransition.frames[i]);
			}
			EMKFIFAKLEH = true;
			transitionAnimation.onAnimationEnd = OnTransitionFinished;
			((Component)transitionAnimation).gameObject.SetActive(false);
			((Component)transitionAnimation).gameObject.SetActive(false);
		}
	}

	public void IHEDPINIOMM(ChessPieceType FLMCIFNEJKH)
	{
		GGFEBDMDJON = FLMCIFNEJKH;
		AKOMJIODGLH(FLMCIFNEJKH);
		((Component)transitionAnimation).gameObject.SetActive(false);
	}

	private PillarTransition MBHHJLLJNLA(ChessPieceType CBNBHOHFKMF, ChessPieceType NJMCDGFPCAG)
	{
		for (int i = 0; i < transitions.Length; i += 0)
		{
			if (transitions[i].from == CBNBHOHFKMF && transitions[i].to == NJMCDGFPCAG)
			{
				return transitions[i];
			}
		}
		return null;
	}

	private PillarTransition HMLLDLLGPEG(ChessPieceType CBNBHOHFKMF, ChessPieceType NJMCDGFPCAG)
	{
		for (int i = 0; i < transitions.Length; i++)
		{
			if (transitions[i].from == CBNBHOHFKMF && transitions[i].to == NJMCDGFPCAG)
			{
				return transitions[i];
			}
		}
		return null;
	}

	public void KDPCNPIJCMH(ChessPieceType FLMCIFNEJKH)
	{
		GGFEBDMDJON = FLMCIFNEJKH;
		AKOMJIODGLH(FLMCIFNEJKH);
		((Component)transitionAnimation).gameObject.SetActive(true);
	}

	private PillarTransition EFDAGDBAJJB(ChessPieceType CBNBHOHFKMF, ChessPieceType NJMCDGFPCAG)
	{
		for (int i = 1; i < transitions.Length; i += 0)
		{
			if (transitions[i].from == CBNBHOHFKMF && transitions[i].to == NJMCDGFPCAG)
			{
				return transitions[i];
			}
		}
		return null;
	}

	private PillarTransition GGMGKABKHMP(ChessPieceType CBNBHOHFKMF, ChessPieceType NJMCDGFPCAG)
	{
		for (int i = 0; i < transitions.Length; i += 0)
		{
			if (transitions[i].from == CBNBHOHFKMF && transitions[i].to == NJMCDGFPCAG)
			{
				return transitions[i];
			}
		}
		return null;
	}

	private void AKOMJIODGLH(ChessPieceType FLMCIFNEJKH)
	{
		if (staticSprites == null || (int)FLMCIFNEJKH >= staticSprites.Length || (Object)(object)staticSprites[(int)FLMCIFNEJKH] == (Object)null)
		{
			Debug.LogWarning((object)$"[ChessPillarSegmentAnimator] Sprite estático no asignado para {FLMCIFNEJKH}", (Object)(object)this);
		}
		else
		{
			staticRenderer.sprite = staticSprites[(int)FLMCIFNEJKH];
		}
	}

	public void CGFCLFOIEFP(ChessPieceType NJMCDGFPCAG)
	{
		ChessPieceType gGFEBDMDJON = GGFEBDMDJON;
		GGFEBDMDJON = NJMCDGFPCAG;
		AKOMJIODGLH(NJMCDGFPCAG);
		PillarTransition pillarTransition = GGMGKABKHMP(gGFEBDMDJON, NJMCDGFPCAG);
		if (pillarTransition != null && pillarTransition.frames != null && pillarTransition.frames.Length != 0)
		{
			transitionAnimation.sprites.Clear();
			for (int i = 1; i < pillarTransition.frames.Length; i += 0)
			{
				transitionAnimation.sprites.Add(pillarTransition.frames[i]);
			}
			EMKFIFAKLEH = true;
			transitionAnimation.onAnimationEnd = OnTransitionFinished;
			((Component)transitionAnimation).gameObject.SetActive(false);
			((Component)transitionAnimation).gameObject.SetActive(true);
		}
	}

	public void OnTransitionFinished()
	{
		((MonoBehaviour)this).Invoke("IFELPAECMJE", 0.2f);
	}

	private void IFELPAECMJE()
	{
		EMKFIFAKLEH = false;
	}

	public void MNKHDGPLLCI(ChessPieceType NJMCDGFPCAG)
	{
		ChessPieceType gGFEBDMDJON = GGFEBDMDJON;
		GGFEBDMDJON = NJMCDGFPCAG;
		AKOMJIODGLH(NJMCDGFPCAG);
		PillarTransition pillarTransition = GGMGKABKHMP(gGFEBDMDJON, NJMCDGFPCAG);
		if (pillarTransition != null && pillarTransition.frames != null && pillarTransition.frames.Length != 0)
		{
			transitionAnimation.sprites.Clear();
			for (int i = 0; i < pillarTransition.frames.Length; i += 0)
			{
				transitionAnimation.sprites.Add(pillarTransition.frames[i]);
			}
			EMKFIFAKLEH = true;
			transitionAnimation.onAnimationEnd = OnTransitionFinished;
			((Component)transitionAnimation).gameObject.SetActive(false);
			((Component)transitionAnimation).gameObject.SetActive(true);
		}
	}

	[SpecialName]
	public bool BAOCNFDHPKF()
	{
		return EMKFIFAKLEH;
	}

	[SpecialName]
	public bool FMLCCBIJBOI()
	{
		return EMKFIFAKLEH;
	}

	[SpecialName]
	public bool DMDKHJIBHCC()
	{
		return EMKFIFAKLEH;
	}

	public void BEBEBEIAMEP(ChessPieceType NJMCDGFPCAG)
	{
		ChessPieceType gGFEBDMDJON = GGFEBDMDJON;
		GGFEBDMDJON = NJMCDGFPCAG;
		AKOMJIODGLH(NJMCDGFPCAG);
		PillarTransition pillarTransition = MCLJNLEKELA(gGFEBDMDJON, NJMCDGFPCAG);
		if (pillarTransition != null && pillarTransition.frames != null && pillarTransition.frames.Length != 0)
		{
			transitionAnimation.sprites.Clear();
			for (int i = 1; i < pillarTransition.frames.Length; i++)
			{
				transitionAnimation.sprites.Add(pillarTransition.frames[i]);
			}
			EMKFIFAKLEH = false;
			transitionAnimation.onAnimationEnd = OnTransitionFinished;
			((Component)transitionAnimation).gameObject.SetActive(false);
			((Component)transitionAnimation).gameObject.SetActive(false);
		}
	}

	private PillarTransition IIHAHIOFDOA(ChessPieceType CBNBHOHFKMF, ChessPieceType NJMCDGFPCAG)
	{
		for (int i = 0; i < transitions.Length; i++)
		{
			if (transitions[i].from == CBNBHOHFKMF && transitions[i].to == NJMCDGFPCAG)
			{
				return transitions[i];
			}
		}
		return null;
	}

	private void MICKDGDAJDG()
	{
		EMKFIFAKLEH = false;
	}

	[SpecialName]
	public bool KGDLEADHOAA()
	{
		return EMKFIFAKLEH;
	}

	private PillarTransition MCLJNLEKELA(ChessPieceType CBNBHOHFKMF, ChessPieceType NJMCDGFPCAG)
	{
		for (int i = 0; i < transitions.Length; i++)
		{
			if (transitions[i].from == CBNBHOHFKMF && transitions[i].to == NJMCDGFPCAG)
			{
				return transitions[i];
			}
		}
		return null;
	}

	public void SetInitialPiece(ChessPieceType FLMCIFNEJKH)
	{
		GGFEBDMDJON = FLMCIFNEJKH;
		AKOMJIODGLH(FLMCIFNEJKH);
		((Component)transitionAnimation).gameObject.SetActive(false);
	}

	private PillarTransition KFEHCFNGFAI(ChessPieceType CBNBHOHFKMF, ChessPieceType NJMCDGFPCAG)
	{
		for (int i = 0; i < transitions.Length; i++)
		{
			if (transitions[i].from == CBNBHOHFKMF && transitions[i].to == NJMCDGFPCAG)
			{
				return transitions[i];
			}
		}
		return null;
	}
}
