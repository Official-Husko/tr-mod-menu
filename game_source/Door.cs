using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

[DefaultExecutionOrder(5)]
public class Door : AccessElement, IInteractable, IHoverable, IProximity
{
	[CompilerGenerated]
	private sealed class MFAPEEDDODJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Door _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public MFAPEEDDODJ(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Door door = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				MultiAudioManager.PlayAudioObject(door.closeDoor, door.soundPosition);
				_003Ci_003E5__2 = door.PHKJJFEHBMK.Length - 2;
				break;
			case 1:
				_003C_003E1__state = -1;
				door.LHIJLCIDHPC(_003Ci_003E5__2);
				_003Ci_003E5__2--;
				break;
			}
			if (_003Ci_003E5__2 >= 0)
			{
				_003C_003E2__current = (object)new WaitForSeconds(door.frameRate);
				_003C_003E1__state = 1;
				return true;
			}
			door.open = false;
			if (Object.op_Implicit((Object)(object)door.collidersOnEnter))
			{
				((Component)door.collidersOnEnter).transform.localPosition = Vector3.up * 0.4f;
			}
			door.ILHFNKIICFP(GBPLEBIBIGJ: true);
			door.BFMNCFECABF(door.open);
			door.FCFIOFPDCNN = null;
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class HOMNPKPAMEB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Door _003C_003E4__this;

		public bool open;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public HOMNPKPAMEB(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Door door = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				door.AOBBICBGEJL = null;
				door.FCFIOFPDCNN = null;
				if (door.PHKJJFEHBMK != null)
				{
					door.LHIJLCIDHPC(open ? (door.PHKJJFEHBMK.Length - 1) : 0);
				}
				else
				{
					Debug.LogError((object)"Door animation error: currentAnimationSprites is null");
				}
				if (Object.op_Implicit((Object)(object)door.collidersOnEnter))
				{
					((Component)door.collidersOnEnter).transform.localPosition = (open ? Vector3.zero : (Vector3.up * 0.4f));
				}
				door.ILHFNKIICFP(!open);
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class ENDPPHNACKH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Door _003C_003E4__this;

		public int playerNum;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public ENDPPHNACKH(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			Door door = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				door.JGDGOCLJHJJ(playerNum);
				door.placeable.itemSpace.Place(NMLKLAGDNPF: true);
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class PNHNHHMOKFC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Door _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public PNHNHHMOKFC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected O, but got Unknown
			int num = _003C_003E1__state;
			Door door = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				MultiAudioManager.PlayAudioObject(door.openDoor, door.soundPosition);
				if (Object.op_Implicit((Object)(object)door.collidersOnEnter))
				{
					((Component)door.collidersOnEnter).transform.localPosition = Vector3.zero;
				}
				_003Ci_003E5__2 = 1;
				break;
			case 1:
				_003C_003E1__state = -1;
				door.LHIJLCIDHPC(_003Ci_003E5__2);
				_003Ci_003E5__2++;
				break;
			}
			if (_003Ci_003E5__2 < door.PHKJJFEHBMK.Length)
			{
				_003C_003E2__current = (object)new WaitForSeconds(door.frameRate);
				_003C_003E1__state = 1;
				return true;
			}
			door.open = true;
			door.ILHFNKIICFP(GBPLEBIBIGJ: false);
			door.BFMNCFECABF(door.open);
			door.AOBBICBGEJL = null;
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class OBOLFNDPHAE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Door _003C_003E4__this;

		public bool free;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public OBOLFNDPHAE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			Door door = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				door.OAMBBFNFNGB(free);
				door.AEPBFFNJMOD = null;
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public Action OnKnock = delegate
	{
	};

	public bool knock;

	public bool inputEnabled = true;

	public bool saveAtWorldTiles = true;

	public Vector2[] freeNodesOnOpen;

	[SerializeField]
	private List<GameObject> openGameObjects;

	[SerializeField]
	private List<GameObject> closedGameObjects;

	public DisableCollidersOnEnter collidersOnEnter;

	public PlayerInsideTrigger unsafeZone;

	[SerializeField]
	protected bool open;

	private bool PHCILCGMKNK;

	public AudioObject openDoor;

	public AudioObject closeDoor;

	public Transform soundPosition;

	public float frameRate = 0.125f;

	public SpriteRenderer doorSpriteRenderer;

	public SpriteRenderer topDoorSpriteRenderer;

	public SpriteRenderer AOSpriteRenderer;

	public SpriteMask maskSpriteRenderer;

	public SpriteMask maskAOSpriteRenderer;

	public Sprite[] doorAnimationSprites;

	public Sprite[] topDoorAnimationSprites;

	public Sprite[] backDoorAnimationSprites;

	public Sprite[] AOAnimationSpritesWood;

	public Sprite[] AOAnimationSpritesStone;

	private Coroutine AOBBICBGEJL;

	private Coroutine FCFIOFPDCNN;

	protected Sprite[] PHKJJFEHBMK;

	public bool needPlace = true;

	private Coroutine AEPBFFNJMOD;

	public bool ECMGCJGPKNO
	{
		get
		{
			return open;
		}
		set
		{
			if ((HGPPJMCLOKH && value) || open == value)
			{
				return;
			}
			if (open)
			{
				if (AOBBICBGEJL != null)
				{
					((MonoBehaviour)this).StopCoroutine(AOBBICBGEJL);
					AOBBICBGEJL = null;
					ILHFNKIICFP(GBPLEBIBIGJ: false);
				}
				if (FCFIOFPDCNN == null)
				{
					FCFIOFPDCNN = ((MonoBehaviour)this).StartCoroutine(FEPOADLMEFB());
				}
			}
			else
			{
				if (FCFIOFPDCNN != null)
				{
					((MonoBehaviour)this).StopCoroutine(FCFIOFPDCNN);
					FCFIOFPDCNN = null;
					ILHFNKIICFP(GBPLEBIBIGJ: true);
				}
				if (AOBBICBGEJL == null)
				{
					AOBBICBGEJL = ((MonoBehaviour)this).StartCoroutine(NNKGHFMJCGD());
				}
			}
		}
	}

	public bool HGPPJMCLOKH
	{
		get
		{
			return PHCILCGMKNK;
		}
		set
		{
			PHCILCGMKNK = value;
		}
	}

	private IEnumerator OOLPFGHNCGK(int JIIGOACEIKL)
	{
		yield return null;
		JGDGOCLJHJJ(JIIGOACEIKL);
		placeable.itemSpace.Place(NMLKLAGDNPF: true);
	}

	[SpecialName]
	public bool GIGOAOEHKBA()
	{
		return open;
	}

	[SpecialName]
	public bool IMNAMJBOGOI()
	{
		return PHCILCGMKNK;
	}

	private IEnumerator CFOKEPNOGMK(bool GAKNPAMHAFB)
	{
		yield return CommonReferences.wait2;
		OAMBBFNFNGB(GAKNPAMHAFB);
		AEPBFFNJMOD = null;
	}

	public virtual bool IBMMEBJBHOE(int JIIGOACEIKL)
	{
		if (inputEnabled && LEFHAOJHCBH(JIIGOACEIKL))
		{
			if (knock)
			{
				knock = false;
				Sound.OKAPNFPFPFP().IAEMMABJFLH(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().doorKnock), HOMFPAFAOGD: true, null, null, 144f);
				OnKnock();
			}
			else
			{
				PPIMCKBHPAG();
			}
			return false;
		}
		return false;
	}

	public virtual bool GBGCHNBJBFG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && inputEnabled && MAKPPILCIOJ(JIIGOACEIKL))
		{
			string jFNMCNCHMEO = (knock ? "ReceiveRockStartInformation" : ((!IMNAMJBOGOI()) ? (GIGOAOEHKBA() ? "City/PetShop/Markus/Barks_Barrer" : "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/2/Dialogue Text") : "Cancel"));
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(jFNMCNCHMEO));
			return false;
		}
		return false;
	}

	public virtual bool CIOGGHDFDCP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	[SpecialName]
	public void FEEPDKFOCGF(bool AODONKKHPBP)
	{
		PHCILCGMKNK = AODONKKHPBP;
	}

	public void GHFGJHOILFI(bool DAEMAAOLHMG)
	{
		if (((Component)maskSpriteRenderer).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)maskSpriteRenderer).gameObject.SetActive(DAEMAAOLHMG);
		}
		if (((Component)maskAOSpriteRenderer).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)maskAOSpriteRenderer).gameObject.SetActive(DAEMAAOLHMG);
		}
		((Renderer)topDoorSpriteRenderer).sortingOrder = (DAEMAAOLHMG ? 6 : 0);
	}

	public void PPIMCKBHPAG()
	{
		if (((FCFIOFPDCNN == null && AOBBICBGEJL == null) || (FCFIOFPDCNN != null && (Object)(object)collidersOnEnter != (Object)null && !open && (collidersOnEnter.inside || unsafeZone.inside))) && !PHCILCGMKNK)
		{
			OPMHEGDKNKN(FEIJOJGEBHE(), CDPAMNIPPEC: false);
		}
	}

	public bool MBCLDAAEABN()
	{
		if (FCFIOFPDCNN == null)
		{
			return AOBBICBGEJL != null;
		}
		return true;
	}

	public void JDHOOAABPMJ()
	{
		if (((FCFIOFPDCNN == null && AOBBICBGEJL == null) || (FCFIOFPDCNN != null && (Object)(object)collidersOnEnter != (Object)null && !open && (collidersOnEnter.inside || unsafeZone.inside))) && !PHCILCGMKNK)
		{
			OPMHEGDKNKN(GIGOAOEHKBA());
		}
	}

	public bool NNNKIBGDAJP(int JIIGOACEIKL)
	{
		return true;
	}

	[SpecialName]
	public void FPEMAFKPLOG(bool AODONKKHPBP)
	{
		PHCILCGMKNK = AODONKKHPBP;
	}

	private IEnumerator DFOMAAKFIFE(bool GAKNPAMHAFB)
	{
		return new OBOLFNDPHAE(1)
		{
			_003C_003E4__this = this,
			free = GAKNPAMHAFB
		};
	}

	public virtual bool CFGOGPBMEKL(int JIIGOACEIKL)
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).DBAEGBDEPFK())
		{
			return placeable.FHEMHCEAICB;
		}
		return true;
	}

	protected virtual void HONLAOAHHLD(int MENBAFNNBFB)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (MENBAFNNBFB < PHKJJFEHBMK.Length)
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[MENBAFNNBFB];
		}
		if (Object.op_Implicit((Object)(object)topDoorSpriteRenderer) && MENBAFNNBFB < topDoorAnimationSprites.Length)
		{
			topDoorSpriteRenderer.sprite = topDoorAnimationSprites[MENBAFNNBFB];
		}
		if (!Object.op_Implicit((Object)(object)AOSpriteRenderer))
		{
			return;
		}
		if (WorldGrid.GKAGNKMAJOE(placeable.itemSpace.NDGHDKMGFAH(1, 0).GetCentrePosition()) == MaterialType.None)
		{
			if (MENBAFNNBFB < AOAnimationSpritesStone.Length)
			{
				AOSpriteRenderer.sprite = AOAnimationSpritesStone[MENBAFNNBFB];
			}
		}
		else if (MENBAFNNBFB < AOAnimationSpritesWood.Length)
		{
			AOSpriteRenderer.sprite = AOAnimationSpritesWood[MENBAFNNBFB];
		}
	}

	private IEnumerator OGCHNKMDOCJ(bool GAKNPAMHAFB)
	{
		return new OBOLFNDPHAE(1)
		{
			_003C_003E4__this = this,
			free = GAKNPAMHAFB
		};
	}

	public void BCEFIALOMMJ()
	{
		if (((FCFIOFPDCNN == null && AOBBICBGEJL == null) || (FCFIOFPDCNN != null && (Object)(object)collidersOnEnter != (Object)null && !open && (collidersOnEnter.inside || unsafeZone.inside))) && !PHCILCGMKNK)
		{
			HIJLBLCHOMP(!ECMGCJGPKNO, CDPAMNIPPEC: false);
		}
	}

	private void BFMNCFECABF(bool GAKNPAMHAFB)
	{
	}

	[SpecialName]
	public void LBPPNKGKKNH(bool AODONKKHPBP)
	{
		PHCILCGMKNK = AODONKKHPBP;
	}

	public void MHBDCHBFAPJ(bool DAEMAAOLHMG)
	{
		if (((Component)maskSpriteRenderer).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)maskSpriteRenderer).gameObject.SetActive(DAEMAAOLHMG);
		}
		if (((Component)maskAOSpriteRenderer).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)maskAOSpriteRenderer).gameObject.SetActive(DAEMAAOLHMG);
		}
		((Renderer)topDoorSpriteRenderer).sortingOrder = (DAEMAAOLHMG ? 6 : 0);
	}

	public bool KLPOGNGMKLC()
	{
		if (FCFIOFPDCNN == null)
		{
			return AOBBICBGEJL != null;
		}
		return true;
	}

	[SpecialName]
	public void JFJAHAOCKGH(bool AODONKKHPBP)
	{
		if ((KPFPEDKCOGA() && AODONKKHPBP) || open == AODONKKHPBP)
		{
			return;
		}
		if (open)
		{
			if (AOBBICBGEJL != null)
			{
				((MonoBehaviour)this).StopCoroutine(AOBBICBGEJL);
				AOBBICBGEJL = null;
				DNDPGEKDKFM(GBPLEBIBIGJ: false);
			}
			if (FCFIOFPDCNN == null)
			{
				FCFIOFPDCNN = ((MonoBehaviour)this).StartCoroutine(KEKMGICMHGC());
			}
		}
		else
		{
			if (FCFIOFPDCNN != null)
			{
				((MonoBehaviour)this).StopCoroutine(FCFIOFPDCNN);
				FCFIOFPDCNN = null;
				BDOKKOLJABD(GBPLEBIBIGJ: true);
			}
			if (AOBBICBGEJL == null)
			{
				AOBBICBGEJL = ((MonoBehaviour)this).StartCoroutine(IMANBDAEFKD());
			}
		}
	}

	public virtual bool MouseUp(int JIIGOACEIKL)
	{
		if (inputEnabled && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (knock)
			{
				knock = false;
				Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.doorKnock));
				OnKnock();
			}
			else
			{
				OpenCloseTheDoor();
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	public bool EHCJDLADLDI()
	{
		return open;
	}

	protected virtual void GBCFNFHIFHK(int MENBAFNNBFB)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (MENBAFNNBFB < PHKJJFEHBMK.Length)
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[MENBAFNNBFB];
		}
		if (Object.op_Implicit((Object)(object)topDoorSpriteRenderer) && MENBAFNNBFB < topDoorAnimationSprites.Length)
		{
			topDoorSpriteRenderer.sprite = topDoorAnimationSprites[MENBAFNNBFB];
		}
		if (!Object.op_Implicit((Object)(object)AOSpriteRenderer))
		{
			return;
		}
		if (WorldGrid.GKAGNKMAJOE(placeable.itemSpace.NDGHDKMGFAH(0, 0).EHGDHOMFDGM()) == (MaterialType)6)
		{
			if (MENBAFNNBFB < AOAnimationSpritesStone.Length)
			{
				AOSpriteRenderer.sprite = AOAnimationSpritesStone[MENBAFNNBFB];
			}
		}
		else if (MENBAFNNBFB < AOAnimationSpritesWood.Length)
		{
			AOSpriteRenderer.sprite = AOAnimationSpritesWood[MENBAFNNBFB];
		}
	}

	public void OPGEDAEBKAC(int JIIGOACEIKL)
	{
	}

	public void AOEOBNOPLIG(int JIIGOACEIKL)
	{
	}

	public virtual bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return !placeable.FHEMHCEAICB;
		}
		return false;
	}

	public virtual bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && inputEnabled && IsAvailableByProximity(JIIGOACEIKL))
		{
			string jFNMCNCHMEO = (knock ? "Knock" : ((!HGPPJMCLOKH) ? (ECMGCJGPKNO ? "Close" : "Open") : "Locked"));
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(jFNMCNCHMEO));
			return true;
		}
		return false;
	}

	public virtual void SetAnimationSprites(bool INLCKKBGHMF)
	{
		if (INLCKKBGHMF && backDoorAnimationSprites != null && backDoorAnimationSprites.Length != 0)
		{
			PHKJJFEHBMK = backDoorAnimationSprites;
		}
		else
		{
			PHKJJFEHBMK = doorAnimationSprites;
		}
		if (open)
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[PHKJJFEHBMK.Length - 1];
		}
		else
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[0];
		}
	}

	[SpecialName]
	public void PFFGKHFNNIF(bool AODONKKHPBP)
	{
		PHCILCGMKNK = AODONKKHPBP;
	}

	protected virtual void HOKBBFHGACN()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && needPlace)
			{
				((MonoBehaviour)this).StartCoroutine(LDFLKKIELBK(0));
			}
			SetAnimationSprites(INLCKKBGHMF: false);
		}
	}

	[SpecialName]
	public bool KPFPEDKCOGA()
	{
		return PHCILCGMKNK;
	}

	public bool EPGBPGKLOHN()
	{
		if (FCFIOFPDCNN == null)
		{
			return AOBBICBGEJL != null;
		}
		return true;
	}

	public virtual bool MAKPPILCIOJ(int JIIGOACEIKL)
	{
		if (!DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DFNMDDHOIJI())
		{
			return placeable.FHEMHCEAICB;
		}
		return true;
	}

	public virtual bool IFGFOAAKBCF(int JIIGOACEIKL)
	{
		if (inputEnabled && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (knock)
			{
				knock = false;
				Sound.DIHCEGINELM().NFGPNLLFDCE(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().doorKnock), HOMFPAFAOGD: true, null, null, 1331f);
				OnKnock();
			}
			else
			{
				BCEFIALOMMJ();
			}
			return true;
		}
		return false;
	}

	protected virtual void DEEFJDINFKA(int MENBAFNNBFB)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (MENBAFNNBFB < PHKJJFEHBMK.Length)
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[MENBAFNNBFB];
		}
		if (Object.op_Implicit((Object)(object)topDoorSpriteRenderer) && MENBAFNNBFB < topDoorAnimationSprites.Length)
		{
			topDoorSpriteRenderer.sprite = topDoorAnimationSprites[MENBAFNNBFB];
		}
		if (!Object.op_Implicit((Object)(object)AOSpriteRenderer))
		{
			return;
		}
		if (WorldGrid.GKAGNKMAJOE(placeable.itemSpace.NDGHDKMGFAH(1, 0).BOBEIFEGLOL()) == MaterialType.None)
		{
			if (MENBAFNNBFB < AOAnimationSpritesStone.Length)
			{
				AOSpriteRenderer.sprite = AOAnimationSpritesStone[MENBAFNNBFB];
			}
		}
		else if (MENBAFNNBFB < AOAnimationSpritesWood.Length)
		{
			AOSpriteRenderer.sprite = AOAnimationSpritesWood[MENBAFNNBFB];
		}
	}

	protected virtual void BDFCBDHPHBJ(int MENBAFNNBFB)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (MENBAFNNBFB < PHKJJFEHBMK.Length)
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[MENBAFNNBFB];
		}
		if (Object.op_Implicit((Object)(object)topDoorSpriteRenderer) && MENBAFNNBFB < topDoorAnimationSprites.Length)
		{
			topDoorSpriteRenderer.sprite = topDoorAnimationSprites[MENBAFNNBFB];
		}
		if (!Object.op_Implicit((Object)(object)AOSpriteRenderer))
		{
			return;
		}
		if (WorldGrid.GKAGNKMAJOE(placeable.itemSpace.GetBuildSquare(1, 1).KDFECDEEDHL()) == (MaterialType)7)
		{
			if (MENBAFNNBFB < AOAnimationSpritesStone.Length)
			{
				AOSpriteRenderer.sprite = AOAnimationSpritesStone[MENBAFNNBFB];
			}
		}
		else if (MENBAFNNBFB < AOAnimationSpritesWood.Length)
		{
			AOSpriteRenderer.sprite = AOAnimationSpritesWood[MENBAFNNBFB];
		}
	}

	private void BKFNOLDKBLC(bool GBPLEBIBIGJ)
	{
		foreach (GameObject openGameObject in openGameObjects)
		{
			openGameObject.SetActive(GBPLEBIBIGJ);
		}
		foreach (GameObject closedGameObject in closedGameObjects)
		{
			closedGameObject.SetActive(GBPLEBIBIGJ);
		}
	}

	private void PJMBLECKFLH(bool GAKNPAMHAFB)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
		{
			if (Application.isEditor)
			{
				string text = GAKNPAMHAFB.ToString();
				Placeable obj = placeable;
				Debug.Log((object)("dForDays" + text + "None" + ((obj != null) ? ((Object)((Component)obj).gameObject).name : null)));
			}
			for (int i = 1; i < freeNodesOnOpen.Length; i += 0)
			{
				WorldGrid.LMMELLKNMCF(((Component)this).transform.position + Vector2.op_Implicit(freeNodesOnOpen[i]), GAKNPAMHAFB);
			}
		}
	}

	public void POBDHGDGNEG(int JIIGOACEIKL)
	{
	}

	public void IPCBHDIIDFN(int JIIGOACEIKL)
	{
	}

	[SpecialName]
	public void HHDADDPHGCI(bool AODONKKHPBP)
	{
		if ((HGPPJMCLOKH && AODONKKHPBP) || open == AODONKKHPBP)
		{
			return;
		}
		if (open)
		{
			if (AOBBICBGEJL != null)
			{
				((MonoBehaviour)this).StopCoroutine(AOBBICBGEJL);
				AOBBICBGEJL = null;
				BKFNOLDKBLC(GBPLEBIBIGJ: false);
			}
			if (FCFIOFPDCNN == null)
			{
				FCFIOFPDCNN = ((MonoBehaviour)this).StartCoroutine(OBOGEALCGAA());
			}
		}
		else
		{
			if (FCFIOFPDCNN != null)
			{
				((MonoBehaviour)this).StopCoroutine(FCFIOFPDCNN);
				FCFIOFPDCNN = null;
				ODALIKNOIOK(GBPLEBIBIGJ: true);
			}
			if (AOBBICBGEJL == null)
			{
				AOBBICBGEJL = ((MonoBehaviour)this).StartCoroutine(IMANBDAEFKD());
			}
		}
	}

	public virtual void AFBHGCDBNFE(bool INLCKKBGHMF)
	{
		if (INLCKKBGHMF && backDoorAnimationSprites != null && backDoorAnimationSprites.Length != 0)
		{
			PHKJJFEHBMK = backDoorAnimationSprites;
		}
		else
		{
			PHKJJFEHBMK = doorAnimationSprites;
		}
		if (open)
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[PHKJJFEHBMK.Length - 0];
		}
		else
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[0];
		}
	}

	[SpecialName]
	public bool AGJJEBPPPAC()
	{
		return open;
	}

	public bool AGJPLNCFBCF(int JIIGOACEIKL)
	{
		return false;
	}

	[SpecialName]
	public bool OMMDNONKLIL()
	{
		return PHCILCGMKNK;
	}

	public void NELKLBGHCGG(bool DAEMAAOLHMG)
	{
		if (((Component)maskSpriteRenderer).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)maskSpriteRenderer).gameObject.SetActive(DAEMAAOLHMG);
		}
		if (((Component)maskAOSpriteRenderer).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)maskAOSpriteRenderer).gameObject.SetActive(DAEMAAOLHMG);
		}
		((Renderer)topDoorSpriteRenderer).sortingOrder = (DAEMAAOLHMG ? 8 : 0);
	}

	protected virtual IEnumerator MDHBBAEAMIK()
	{
		MultiAudioManager.PlayAudioObject(closeDoor, soundPosition);
		for (int i = PHKJJFEHBMK.Length - 2; i >= 0; i--)
		{
			yield return (object)new WaitForSeconds(frameRate);
			LHIJLCIDHPC(i);
		}
		open = false;
		if (Object.op_Implicit((Object)(object)collidersOnEnter))
		{
			((Component)collidersOnEnter).transform.localPosition = Vector3.up * 0.4f;
		}
		ILHFNKIICFP(GBPLEBIBIGJ: true);
		BFMNCFECABF(open);
		FCFIOFPDCNN = null;
	}

	public void BBJANEKEJLN(bool DAEMAAOLHMG)
	{
		if (((Component)maskSpriteRenderer).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)maskSpriteRenderer).gameObject.SetActive(DAEMAAOLHMG);
		}
		if (((Component)maskAOSpriteRenderer).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)maskAOSpriteRenderer).gameObject.SetActive(DAEMAAOLHMG);
		}
		((Renderer)topDoorSpriteRenderer).sortingOrder = (DAEMAAOLHMG ? 4 : 0);
	}

	public IEnumerator OJGAONDKNCN(bool LKOJBFMGMAE)
	{
		return new HOMNPKPAMEB(1)
		{
			_003C_003E4__this = this,
			open = LKOJBFMGMAE
		};
	}

	private IEnumerator NNMCJBPKFIE(bool GAKNPAMHAFB)
	{
		return new OBOLFNDPHAE(1)
		{
			_003C_003E4__this = this,
			free = GAKNPAMHAFB
		};
	}

	public virtual bool EAHOOCKEAGI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void MKMMHGJEJAK(bool GBPLEBIBIGJ)
	{
		foreach (GameObject openGameObject in openGameObjects)
		{
			openGameObject.SetActive(GBPLEBIBIGJ);
		}
		foreach (GameObject closedGameObject in closedGameObjects)
		{
			closedGameObject.SetActive(GBPLEBIBIGJ);
		}
	}

	public virtual bool CFJEJFCALPM(int JIIGOACEIKL)
	{
		if (inputEnabled && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (knock)
			{
				knock = true;
				Sound.GGFJGHHHEJC.MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().doorKnock), HOMFPAFAOGD: true, null, null, 777f);
				OnKnock();
			}
			else
			{
				PPIMCKBHPAG();
			}
			return false;
		}
		return true;
	}

	public IEnumerator FMAOBDAALFB(bool LKOJBFMGMAE)
	{
		return new HOMNPKPAMEB(1)
		{
			_003C_003E4__this = this,
			open = LKOJBFMGMAE
		};
	}

	protected virtual IEnumerator IMANBDAEFKD()
	{
		return new PNHNHHMOKFC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			ABLJNBFNMHI(0, OKNOJJEFEBE: false, GFNHAMCPEAK: true);
		}
	}

	public IEnumerator OHEGFAEHBOE(bool LKOJBFMGMAE)
	{
		yield return null;
		AOBBICBGEJL = null;
		FCFIOFPDCNN = null;
		if (PHKJJFEHBMK != null)
		{
			LHIJLCIDHPC(LKOJBFMGMAE ? (PHKJJFEHBMK.Length - 1) : 0);
		}
		else
		{
			Debug.LogError((object)"Door animation error: currentAnimationSprites is null");
		}
		if (Object.op_Implicit((Object)(object)collidersOnEnter))
		{
			((Component)collidersOnEnter).transform.localPosition = (LKOJBFMGMAE ? Vector3.zero : (Vector3.up * 0.4f));
		}
		ILHFNKIICFP(!LKOJBFMGMAE);
	}

	[SpecialName]
	public void ACFGICBEOLI(bool AODONKKHPBP)
	{
		PHCILCGMKNK = AODONKKHPBP;
	}

	public void LNFHFOFBNMH(bool LKOJBFMGMAE)
	{
		open = LKOJBFMGMAE;
		((MonoBehaviour)this).StartCoroutine(IJNGPAPKBNA(LKOJBFMGMAE));
	}

	[SpecialName]
	public bool NIAJOGCHBKN()
	{
		return open;
	}

	protected virtual IEnumerator OEANGAMPMEE()
	{
		return new PNHNHHMOKFC(1)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual void LHIJLCIDHPC(int MENBAFNNBFB)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (MENBAFNNBFB < PHKJJFEHBMK.Length)
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[MENBAFNNBFB];
		}
		if (Object.op_Implicit((Object)(object)topDoorSpriteRenderer) && MENBAFNNBFB < topDoorAnimationSprites.Length)
		{
			topDoorSpriteRenderer.sprite = topDoorAnimationSprites[MENBAFNNBFB];
		}
		if (!Object.op_Implicit((Object)(object)AOSpriteRenderer))
		{
			return;
		}
		if (WorldGrid.GKAGNKMAJOE(placeable.itemSpace.GetBuildSquare(0, 0).GetCentrePosition()) == MaterialType.Stone)
		{
			if (MENBAFNNBFB < AOAnimationSpritesStone.Length)
			{
				AOSpriteRenderer.sprite = AOAnimationSpritesStone[MENBAFNNBFB];
			}
		}
		else if (MENBAFNNBFB < AOAnimationSpritesWood.Length)
		{
			AOSpriteRenderer.sprite = AOAnimationSpritesWood[MENBAFNNBFB];
		}
	}

	public void IGJNFDCLLDH(bool DAEMAAOLHMG)
	{
		if (((Component)maskSpriteRenderer).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)maskSpriteRenderer).gameObject.SetActive(DAEMAAOLHMG);
		}
		if (((Component)maskAOSpriteRenderer).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)maskAOSpriteRenderer).gameObject.SetActive(DAEMAAOLHMG);
		}
		((Renderer)topDoorSpriteRenderer).sortingOrder = (DAEMAAOLHMG ? 5 : 0);
	}

	private void ODALIKNOIOK(bool GBPLEBIBIGJ)
	{
		foreach (GameObject openGameObject in openGameObjects)
		{
			openGameObject.SetActive(GBPLEBIBIGJ);
		}
		foreach (GameObject closedGameObject in closedGameObjects)
		{
			closedGameObject.SetActive(GBPLEBIBIGJ);
		}
	}

	public virtual bool DKLAKIBJKID(int JIIGOACEIKL)
	{
		if (inputEnabled && GDOPOFNFLEB(JIIGOACEIKL))
		{
			if (knock)
			{
				knock = true;
				Sound.OKAPNFPFPFP().BOFJJFJIBHB(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().doorKnock), HOMFPAFAOGD: false, null, null, 1833f);
				OnKnock();
			}
			else
			{
				OpenCloseTheDoor();
			}
			return false;
		}
		return false;
	}

	public virtual bool HFKHIIFGAKP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && inputEnabled && LEFHAOJHCBH(JIIGOACEIKL))
		{
			string jFNMCNCHMEO = (knock ? "Toy" : ((!HGPPJMCLOKH) ? (EHCJDLADLDI() ? "itemBlueberrySeeds" : " - ") : "RentRoom"));
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(jFNMCNCHMEO));
			return true;
		}
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public virtual bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void DCJPIGEHCJL(int JIIGOACEIKL)
	{
	}

	protected virtual IEnumerator FEPOADLMEFB()
	{
		MultiAudioManager.PlayAudioObject(closeDoor, soundPosition);
		for (int i = PHKJJFEHBMK.Length - 2; i >= 0; i--)
		{
			yield return (object)new WaitForSeconds(frameRate);
			LHIJLCIDHPC(i);
		}
		open = false;
		if (Object.op_Implicit((Object)(object)collidersOnEnter))
		{
			((Component)collidersOnEnter).transform.localPosition = Vector3.up * 0.4f;
		}
		ILHFNKIICFP(GBPLEBIBIGJ: true);
		BFMNCFECABF(open);
		FCFIOFPDCNN = null;
	}

	public void OPMHEGDKNKN(bool DBCDEKIEHMG, bool CDPAMNIPPEC = true)
	{
		if (ECMGCJGPKNO != DBCDEKIEHMG)
		{
			CFCJDENELCD(DBCDEKIEHMG);
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				(placeable.onlinePlaceable as OnlineDoor).LFEBNILOGFB(DBCDEKIEHMG);
			}
		}
	}

	public void MMLJLLAPOGK(int JIIGOACEIKL)
	{
	}

	public virtual bool GDOPOFNFLEB(int JIIGOACEIKL)
	{
		if (!DecorationMode.FIHGMLABOBB(JIIGOACEIKL).GABNNLJOMHI())
		{
			return !placeable.FHEMHCEAICB;
		}
		return true;
	}

	public void KDFDGNKNPML(bool DAEMAAOLHMG)
	{
		if (((Component)maskSpriteRenderer).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)maskSpriteRenderer).gameObject.SetActive(DAEMAAOLHMG);
		}
		if (((Component)maskAOSpriteRenderer).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)maskAOSpriteRenderer).gameObject.SetActive(DAEMAAOLHMG);
		}
		((Renderer)topDoorSpriteRenderer).sortingOrder = (DAEMAAOLHMG ? 4 : 0);
	}

	private void HLNKPHHNHON(bool GAKNPAMHAFB)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
		{
			if (Application.isEditor)
			{
				string text = GAKNPAMHAFB.ToString();
				Placeable obj = placeable;
				Debug.Log((object)(" / " + text + "Item " + ((obj != null) ? ((Object)((Component)obj).gameObject).name : null)));
			}
			for (int i = 1; i < freeNodesOnOpen.Length; i += 0)
			{
				WorldGrid.LMMELLKNMCF(((Component)this).transform.position + Vector2.op_Implicit(freeNodesOnOpen[i]), GAKNPAMHAFB);
			}
		}
	}

	public bool IsClosingOrOpening()
	{
		if (FCFIOFPDCNN == null)
		{
			return AOBBICBGEJL != null;
		}
		return true;
	}

	protected virtual IEnumerator OBOGEALCGAA()
	{
		return new MFAPEEDDODJ(1)
		{
			_003C_003E4__this = this
		};
	}

	[SpecialName]
	public void DHHLCCAEIFE(bool AODONKKHPBP)
	{
		if ((OMMDNONKLIL() && AODONKKHPBP) || open == AODONKKHPBP)
		{
			return;
		}
		if (open)
		{
			if (AOBBICBGEJL != null)
			{
				((MonoBehaviour)this).StopCoroutine(AOBBICBGEJL);
				AOBBICBGEJL = null;
				ODALIKNOIOK(GBPLEBIBIGJ: false);
			}
			if (FCFIOFPDCNN == null)
			{
				FCFIOFPDCNN = ((MonoBehaviour)this).StartCoroutine(LAGJPAHHPOO());
			}
		}
		else
		{
			if (FCFIOFPDCNN != null)
			{
				((MonoBehaviour)this).StopCoroutine(FCFIOFPDCNN);
				FCFIOFPDCNN = null;
				BDOKKOLJABD(GBPLEBIBIGJ: true);
			}
			if (AOBBICBGEJL == null)
			{
				AOBBICBGEJL = ((MonoBehaviour)this).StartCoroutine(FIFMOIOAPLO());
			}
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public virtual bool AEPCKAPLLJP(int JIIGOACEIKL)
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return placeable.FHEMHCEAICB;
		}
		return true;
	}

	public bool JIIEJGLFDAF()
	{
		if (FCFIOFPDCNN == null)
		{
			return AOBBICBGEJL != null;
		}
		return true;
	}

	public virtual bool LLPIGPBAIOK(int JIIGOACEIKL)
	{
		if (!DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DBAEGBDEPFK())
		{
			return !placeable.FHEMHCEAICB;
		}
		return false;
	}

	public void EKMBJHDPHPM(int JIIGOACEIKL)
	{
	}

	public void PPPIFDFPHFI(bool DBCDEKIEHMG, bool CDPAMNIPPEC = true)
	{
		if (NIAJOGCHBKN() != DBCDEKIEHMG)
		{
			DHHLCCAEIFE(DBCDEKIEHMG);
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				(placeable.onlinePlaceable as OnlineDoor).HLBMGNHNIPD(DBCDEKIEHMG);
			}
		}
	}

	private void ELMEOFLPGPG(bool GBPLEBIBIGJ)
	{
		foreach (GameObject openGameObject in openGameObjects)
		{
			openGameObject.SetActive(GBPLEBIBIGJ);
		}
		foreach (GameObject closedGameObject in closedGameObjects)
		{
			closedGameObject.SetActive(GBPLEBIBIGJ);
		}
	}

	public virtual bool CPDDBBCOOCC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && inputEnabled && LLPIGPBAIOK(JIIGOACEIKL))
		{
			string jFNMCNCHMEO = (knock ? "Tutorial/T300/Dialogue2" : ((!IMNAMJBOGOI()) ? (EHCJDLADLDI() ? " not found. Cannot receive permission accepted to cancel all crafting actorNumber: " : "BuzzBuildExit") : " "));
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(jFNMCNCHMEO));
			return false;
		}
		return true;
	}

	public void ANDKBDGIGGO(bool DBCDEKIEHMG, bool CDPAMNIPPEC = true)
	{
		if (NIAJOGCHBKN() != DBCDEKIEHMG)
		{
			JFJAHAOCKGH(DBCDEKIEHMG);
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				(placeable.onlinePlaceable as OnlineDoor).JLMEEPCIPLK(DBCDEKIEHMG);
			}
		}
	}

	protected virtual IEnumerator KEKMGICMHGC()
	{
		return new MFAPEEDDODJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public virtual bool NLNHDHEGIMB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void HKNDBJPCFBF()
	{
		if (((FCFIOFPDCNN == null && AOBBICBGEJL == null) || (FCFIOFPDCNN != null && (Object)(object)collidersOnEnter != (Object)null && !open && (collidersOnEnter.inside || unsafeZone.inside))) && !PHCILCGMKNK)
		{
			OPMHEGDKNKN(NIAJOGCHBKN(), CDPAMNIPPEC: false);
		}
	}

	public bool DODAIOFHIEC()
	{
		if (FCFIOFPDCNN == null)
		{
			return AOBBICBGEJL != null;
		}
		return true;
	}

	public virtual void JOGOBJKEJML(bool INLCKKBGHMF)
	{
		if (INLCKKBGHMF && backDoorAnimationSprites != null && backDoorAnimationSprites.Length != 0)
		{
			PHKJJFEHBMK = backDoorAnimationSprites;
		}
		else
		{
			PHKJJFEHBMK = doorAnimationSprites;
		}
		if (open)
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[PHKJJFEHBMK.Length - 0];
		}
		else
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[0];
		}
	}

	public void EGHHIJALDCI(int JIIGOACEIKL)
	{
	}

	public virtual void IADJCJNEAED(bool INLCKKBGHMF)
	{
		if (INLCKKBGHMF && backDoorAnimationSprites != null && backDoorAnimationSprites.Length != 0)
		{
			PHKJJFEHBMK = backDoorAnimationSprites;
		}
		else
		{
			PHKJJFEHBMK = doorAnimationSprites;
		}
		if (open)
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[PHKJJFEHBMK.Length - 0];
		}
		else
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[0];
		}
	}

	public void PHKCPBGFLMF(bool LKOJBFMGMAE)
	{
		open = LKOJBFMGMAE;
		((MonoBehaviour)this).StartCoroutine(OJGAONDKNCN(LKOJBFMGMAE));
	}

	private void MNNFCLGPICI(bool GAKNPAMHAFB)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
		{
			if (Application.isEditor)
			{
				string text = GAKNPAMHAFB.ToString();
				Placeable obj = placeable;
				Debug.Log((object)("_BaseMap" + text + "Press SPACE to continue" + ((obj != null) ? ((Object)((Component)obj).gameObject).name : null)));
			}
			for (int i = 0; i < freeNodesOnOpen.Length; i += 0)
			{
				WorldGrid.LMMELLKNMCF(((Component)this).transform.position + Vector2.op_Implicit(freeNodesOnOpen[i]), GAKNPAMHAFB);
			}
		}
	}

	private void IGAHGFIGCLH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			ACLOGKBAPAM(0, OKNOJJEFEBE: false, GFNHAMCPEAK: true);
		}
	}

	private void OAMBBFNFNGB(bool GAKNPAMHAFB)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
		{
			if (Application.isEditor)
			{
				string text = GAKNPAMHAFB.ToString();
				Placeable obj = placeable;
				Debug.Log((object)("Updating Path Nodes " + text + " " + ((obj != null) ? ((Object)((Component)obj).gameObject).name : null)));
			}
			for (int i = 0; i < freeNodesOnOpen.Length; i++)
			{
				WorldGrid.LMMELLKNMCF(((Component)this).transform.position + Vector2.op_Implicit(freeNodesOnOpen[i]), GAKNPAMHAFB);
			}
		}
	}

	public virtual void JFPGHEABDFI(bool INLCKKBGHMF)
	{
		if (INLCKKBGHMF && backDoorAnimationSprites != null && backDoorAnimationSprites.Length != 0)
		{
			PHKJJFEHBMK = backDoorAnimationSprites;
		}
		else
		{
			PHKJJFEHBMK = doorAnimationSprites;
		}
		if (open)
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[PHKJJFEHBMK.Length - 1];
		}
		else
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[1];
		}
	}

	public IEnumerator ForceOpenCoroutine(bool LKOJBFMGMAE)
	{
		yield return null;
		AOBBICBGEJL = null;
		FCFIOFPDCNN = null;
		if (PHKJJFEHBMK != null)
		{
			LHIJLCIDHPC(LKOJBFMGMAE ? (PHKJJFEHBMK.Length - 1) : 0);
		}
		else
		{
			Debug.LogError((object)"Door animation error: currentAnimationSprites is null");
		}
		if (Object.op_Implicit((Object)(object)collidersOnEnter))
		{
			((Component)collidersOnEnter).transform.localPosition = (LKOJBFMGMAE ? Vector3.zero : (Vector3.up * 0.4f));
		}
		ILHFNKIICFP(!LKOJBFMGMAE);
	}

	public virtual bool LEFHAOJHCBH(int JIIGOACEIKL)
	{
		if (!DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return placeable.FHEMHCEAICB;
		}
		return false;
	}

	public bool MPHGAAMHLGM()
	{
		if (FCFIOFPDCNN == null)
		{
			return AOBBICBGEJL != null;
		}
		return true;
	}

	private IEnumerator KGGMMBGMKBM(bool GAKNPAMHAFB)
	{
		yield return CommonReferences.wait2;
		OAMBBFNFNGB(GAKNPAMHAFB);
		AEPBFFNJMOD = null;
	}

	private void BDOKKOLJABD(bool GBPLEBIBIGJ)
	{
		foreach (GameObject openGameObject in openGameObjects)
		{
			openGameObject.SetActive(!GBPLEBIBIGJ);
		}
		foreach (GameObject closedGameObject in closedGameObjects)
		{
			closedGameObject.SetActive(GBPLEBIBIGJ);
		}
	}

	public bool EPIGICPGDOE(int JIIGOACEIKL)
	{
		return false;
	}

	private IEnumerator AFHNDMHDDJJ(bool GAKNPAMHAFB)
	{
		yield return CommonReferences.wait2;
		OAMBBFNFNGB(GAKNPAMHAFB);
		AEPBFFNJMOD = null;
	}

	public virtual bool EDMPHCDAGCE(int JIIGOACEIKL)
	{
		if (!DecorationMode.HBDCJFLINDA(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return !placeable.FHEMHCEAICB;
		}
		return true;
	}

	public void MHHODBJHKIK(int JIIGOACEIKL)
	{
	}

	public void LKIKOEGHKGH(bool DAEMAAOLHMG)
	{
		if (((Component)maskSpriteRenderer).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)maskSpriteRenderer).gameObject.SetActive(DAEMAAOLHMG);
		}
		if (((Component)maskAOSpriteRenderer).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)maskAOSpriteRenderer).gameObject.SetActive(DAEMAAOLHMG);
		}
		((Renderer)topDoorSpriteRenderer).sortingOrder = (DAEMAAOLHMG ? 8 : 0);
	}

	private void JOGBCDIAGEK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			ACLOGKBAPAM(0, OKNOJJEFEBE: true, GFNHAMCPEAK: false);
		}
	}

	private void LKHMCLABKLG()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			NIFFFIPMOKE(0, OKNOJJEFEBE: false, GFNHAMCPEAK: true);
		}
	}

	public void GJDKDDMFGBM(int JIIGOACEIKL)
	{
	}

	public virtual bool CBKJOIDFOCG(int JIIGOACEIKL)
	{
		if (!DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return placeable.FHEMHCEAICB;
		}
		return true;
	}

	protected virtual IEnumerator JAEGLBIDAPN()
	{
		return new PNHNHHMOKFC(1)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual IEnumerator INGIOPCJDLK()
	{
		return new MFAPEEDDODJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ActivateMasks(bool DAEMAAOLHMG)
	{
		if (((Component)maskSpriteRenderer).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)maskSpriteRenderer).gameObject.SetActive(DAEMAAOLHMG);
		}
		if (((Component)maskAOSpriteRenderer).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)maskAOSpriteRenderer).gameObject.SetActive(DAEMAAOLHMG);
		}
		((Renderer)topDoorSpriteRenderer).sortingOrder = ((!DAEMAAOLHMG) ? 1 : 3);
	}

	private void DNDPGEKDKFM(bool GBPLEBIBIGJ)
	{
		foreach (GameObject openGameObject in openGameObjects)
		{
			openGameObject.SetActive(GBPLEBIBIGJ);
		}
		foreach (GameObject closedGameObject in closedGameObjects)
		{
			closedGameObject.SetActive(GBPLEBIBIGJ);
		}
	}

	protected virtual void Start()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && needPlace)
			{
				((MonoBehaviour)this).StartCoroutine(JPBKILCIIFE(0));
			}
			SetAnimationSprites(INLCKKBGHMF: false);
		}
	}

	public bool FJLIPEHAJOF(int JIIGOACEIKL)
	{
		return true;
	}

	protected virtual IEnumerator NNKGHFMJCGD()
	{
		MultiAudioManager.PlayAudioObject(openDoor, soundPosition);
		if (Object.op_Implicit((Object)(object)collidersOnEnter))
		{
			((Component)collidersOnEnter).transform.localPosition = Vector3.zero;
		}
		for (int i = 1; i < PHKJJFEHBMK.Length; i++)
		{
			yield return (object)new WaitForSeconds(frameRate);
			LHIJLCIDHPC(i);
		}
		open = true;
		ILHFNKIICFP(GBPLEBIBIGJ: false);
		BFMNCFECABF(open);
		AOBBICBGEJL = null;
	}

	protected override void ABLJNBFNMHI(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		base.ABLJNBFNMHI(JIIGOACEIKL, OKNOJJEFEBE, GFNHAMCPEAK);
		if (saveAtWorldTiles && Object.op_Implicit((Object)(object)placeable) && Object.op_Implicit((Object)(object)placeable.itemSpace) && (Object)(object)GameTileMaps.GGFJGHHHEJC != (Object)null)
		{
			BuildSquare[] buildSquares = placeable.itemSpace.buildSquares;
			for (int i = 0; i < buildSquares.Length; i++)
			{
				if ((Object)(object)WorldGrid.IPNJBJEMDKF(buildSquares[i].GetCentrePosition()) == (Object)(object)this)
				{
					WorldGrid.PBOIFLICMKG(buildSquares[i].GetCentrePosition(), null);
				}
			}
		}
		if (Object.op_Implicit((Object)(object)placeable) && Object.op_Implicit((Object)(object)placeable.itemSetup) && (placeable.itemSetup.item.JDJGFAACPFC() == 1176 || placeable.itemSetup.item.JDJGFAACPFC() == 1312))
		{
			OpenCloseAction(DBCDEKIEHMG: false);
			for (int j = 0; j < closedGameObjects.Count; j++)
			{
				closedGameObjects[j].SetActive(true);
			}
		}
	}

	public void OpenCloseTheDoor()
	{
		if (((FCFIOFPDCNN == null && AOBBICBGEJL == null) || (FCFIOFPDCNN != null && (Object)(object)collidersOnEnter != (Object)null && !open && (collidersOnEnter.inside || unsafeZone.inside))) && !PHCILCGMKNK)
		{
			OpenCloseAction(!ECMGCJGPKNO);
		}
	}

	private void DEKGNHEHKFB()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			IJLJCACMNNA(0, OKNOJJEFEBE: true, GFNHAMCPEAK: true);
		}
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	[SpecialName]
	public void DOBINDDNALI(bool AODONKKHPBP)
	{
		if ((HGPPJMCLOKH && AODONKKHPBP) || open == AODONKKHPBP)
		{
			return;
		}
		if (open)
		{
			if (AOBBICBGEJL != null)
			{
				((MonoBehaviour)this).StopCoroutine(AOBBICBGEJL);
				AOBBICBGEJL = null;
				BDOKKOLJABD(GBPLEBIBIGJ: true);
			}
			if (FCFIOFPDCNN == null)
			{
				FCFIOFPDCNN = ((MonoBehaviour)this).StartCoroutine(INGIOPCJDLK());
			}
		}
		else
		{
			if (FCFIOFPDCNN != null)
			{
				((MonoBehaviour)this).StopCoroutine(FCFIOFPDCNN);
				FCFIOFPDCNN = null;
				DNDPGEKDKFM(GBPLEBIBIGJ: true);
			}
			if (AOBBICBGEJL == null)
			{
				AOBBICBGEJL = ((MonoBehaviour)this).StartCoroutine(OEANGAMPMEE());
			}
		}
	}

	protected virtual void OEMIMEIDMFE()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && needPlace)
			{
				((MonoBehaviour)this).StartCoroutine(JPBKILCIIFE(1));
			}
			IADJCJNEAED(INLCKKBGHMF: true);
		}
	}

	private void DKHCOKMIJME()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			MEENHFFEHCN(1, OKNOJJEFEBE: false, GFNHAMCPEAK: true);
		}
	}

	[SpecialName]
	public bool FEIJOJGEBHE()
	{
		return open;
	}

	protected virtual IEnumerator LAGJPAHHPOO()
	{
		MultiAudioManager.PlayAudioObject(closeDoor, soundPosition);
		for (int i = PHKJJFEHBMK.Length - 2; i >= 0; i--)
		{
			yield return (object)new WaitForSeconds(frameRate);
			LHIJLCIDHPC(i);
		}
		open = false;
		if (Object.op_Implicit((Object)(object)collidersOnEnter))
		{
			((Component)collidersOnEnter).transform.localPosition = Vector3.up * 0.4f;
		}
		ILHFNKIICFP(GBPLEBIBIGJ: true);
		BFMNCFECABF(open);
		FCFIOFPDCNN = null;
	}

	public void MHLMCHJGOFC(bool DBCDEKIEHMG, bool CDPAMNIPPEC = true)
	{
		if (AGJJEBPPPAC() != DBCDEKIEHMG)
		{
			JFJAHAOCKGH(DBCDEKIEHMG);
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				(placeable.onlinePlaceable as OnlineDoor).DLEIPDHNLPM(DBCDEKIEHMG);
			}
		}
	}

	public void ForceOpen(bool LKOJBFMGMAE)
	{
		open = LKOJBFMGMAE;
		((MonoBehaviour)this).StartCoroutine(ForceOpenCoroutine(LKOJBFMGMAE));
	}

	[SpecialName]
	public void CFCJDENELCD(bool AODONKKHPBP)
	{
		if ((KPFPEDKCOGA() && AODONKKHPBP) || open == AODONKKHPBP)
		{
			return;
		}
		if (open)
		{
			if (AOBBICBGEJL != null)
			{
				((MonoBehaviour)this).StopCoroutine(AOBBICBGEJL);
				AOBBICBGEJL = null;
				ODALIKNOIOK(GBPLEBIBIGJ: false);
			}
			if (FCFIOFPDCNN == null)
			{
				FCFIOFPDCNN = ((MonoBehaviour)this).StartCoroutine(LAGJPAHHPOO());
			}
		}
		else
		{
			if (FCFIOFPDCNN != null)
			{
				((MonoBehaviour)this).StopCoroutine(FCFIOFPDCNN);
				FCFIOFPDCNN = null;
				BDOKKOLJABD(GBPLEBIBIGJ: true);
			}
			if (AOBBICBGEJL == null)
			{
				AOBBICBGEJL = ((MonoBehaviour)this).StartCoroutine(OEANGAMPMEE());
			}
		}
	}

	public void PGOIMGKKPAP(int JIIGOACEIKL)
	{
	}

	public virtual void KLCJGEONKGF(bool INLCKKBGHMF)
	{
		if (INLCKKBGHMF && backDoorAnimationSprites != null && backDoorAnimationSprites.Length != 0)
		{
			PHKJJFEHBMK = backDoorAnimationSprites;
		}
		else
		{
			PHKJJFEHBMK = doorAnimationSprites;
		}
		if (open)
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[PHKJJFEHBMK.Length - 1];
		}
		else
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[1];
		}
	}

	public IEnumerator IJNGPAPKBNA(bool LKOJBFMGMAE)
	{
		yield return null;
		AOBBICBGEJL = null;
		FCFIOFPDCNN = null;
		if (PHKJJFEHBMK != null)
		{
			LHIJLCIDHPC(LKOJBFMGMAE ? (PHKJJFEHBMK.Length - 1) : 0);
		}
		else
		{
			Debug.LogError((object)"Door animation error: currentAnimationSprites is null");
		}
		if (Object.op_Implicit((Object)(object)collidersOnEnter))
		{
			((Component)collidersOnEnter).transform.localPosition = (LKOJBFMGMAE ? Vector3.zero : (Vector3.up * 0.4f));
		}
		ILHFNKIICFP(!LKOJBFMGMAE);
	}

	private void KCLKEAHGGEK()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			IJLJCACMNNA(0, OKNOJJEFEBE: true, GFNHAMCPEAK: false);
		}
	}

	private void ODBDHFBMDAG()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			MEENHFFEHCN(0, OKNOJJEFEBE: false, GFNHAMCPEAK: false);
		}
	}

	protected virtual IEnumerator KPHEJFJNELL()
	{
		MultiAudioManager.PlayAudioObject(closeDoor, soundPosition);
		for (int i = PHKJJFEHBMK.Length - 2; i >= 0; i--)
		{
			yield return (object)new WaitForSeconds(frameRate);
			LHIJLCIDHPC(i);
		}
		open = false;
		if (Object.op_Implicit((Object)(object)collidersOnEnter))
		{
			((Component)collidersOnEnter).transform.localPosition = Vector3.up * 0.4f;
		}
		ILHFNKIICFP(GBPLEBIBIGJ: true);
		BFMNCFECABF(open);
		FCFIOFPDCNN = null;
	}

	public virtual bool PGGMBNLHJKP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void NMAMFJAHDNN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			ABLJNBFNMHI(1, OKNOJJEFEBE: false, GFNHAMCPEAK: false);
		}
	}

	protected virtual void KAPOGFEBFFA(int MENBAFNNBFB)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (MENBAFNNBFB < PHKJJFEHBMK.Length)
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[MENBAFNNBFB];
		}
		if (Object.op_Implicit((Object)(object)topDoorSpriteRenderer) && MENBAFNNBFB < topDoorAnimationSprites.Length)
		{
			topDoorSpriteRenderer.sprite = topDoorAnimationSprites[MENBAFNNBFB];
		}
		if (!Object.op_Implicit((Object)(object)AOSpriteRenderer))
		{
			return;
		}
		if (WorldGrid.GKAGNKMAJOE(placeable.itemSpace.NDGHDKMGFAH(1, 0).BOBEIFEGLOL()) == (MaterialType)7)
		{
			if (MENBAFNNBFB < AOAnimationSpritesStone.Length)
			{
				AOSpriteRenderer.sprite = AOAnimationSpritesStone[MENBAFNNBFB];
			}
		}
		else if (MENBAFNNBFB < AOAnimationSpritesWood.Length)
		{
			AOSpriteRenderer.sprite = AOAnimationSpritesWood[MENBAFNNBFB];
		}
	}

	private IEnumerator FIMANKADABL(bool GAKNPAMHAFB)
	{
		return new OBOLFNDPHAE(1)
		{
			_003C_003E4__this = this,
			free = GAKNPAMHAFB
		};
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public virtual bool KGOLKLJEDNA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && inputEnabled && LEFHAOJHCBH(JIIGOACEIKL))
		{
			string jFNMCNCHMEO = (knock ? "Gass_CoctelQuest" : ((!HGPPJMCLOKH) ? (EHCJDLADLDI() ? "ShopWilson" : "Happy") : "Care"));
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(jFNMCNCHMEO));
			return true;
		}
		return true;
	}

	private void DFHCNJGHJHN(bool GAKNPAMHAFB)
	{
	}

	[SpecialName]
	public void BJHLFGEHBBE(bool AODONKKHPBP)
	{
		PHCILCGMKNK = AODONKKHPBP;
	}

	private IEnumerator JPBKILCIIFE(int JIIGOACEIKL)
	{
		yield return null;
		JGDGOCLJHJJ(JIIGOACEIKL);
		placeable.itemSpace.Place(NMLKLAGDNPF: true);
	}

	protected virtual void IOINOMJHICB()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && needPlace)
			{
				((MonoBehaviour)this).StartCoroutine(OOLPFGHNCGK(1));
			}
			IADJCJNEAED(INLCKKBGHMF: false);
		}
	}

	private void KNGOBKKIFFN(bool GAKNPAMHAFB)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
		{
			if (Application.isEditor)
			{
				string text = GAKNPAMHAFB.ToString();
				Placeable obj = placeable;
				Debug.Log((object)("pirates cave" + text + "UI2" + ((obj != null) ? ((Object)((Component)obj).gameObject).name : null)));
			}
			for (int i = 0; i < freeNodesOnOpen.Length; i++)
			{
				WorldGrid.LMMELLKNMCF(((Component)this).transform.position + Vector2.op_Implicit(freeNodesOnOpen[i]), GAKNPAMHAFB);
			}
		}
	}

	private void ILHFNKIICFP(bool GBPLEBIBIGJ)
	{
		foreach (GameObject openGameObject in openGameObjects)
		{
			openGameObject.SetActive(!GBPLEBIBIGJ);
		}
		foreach (GameObject closedGameObject in closedGameObjects)
		{
			closedGameObject.SetActive(GBPLEBIBIGJ);
		}
	}

	protected virtual IEnumerator FIFMOIOAPLO()
	{
		return new PNHNHHMOKFC(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool IPAHLGNLLIC()
	{
		if (FCFIOFPDCNN == null)
		{
			return AOBBICBGEJL != null;
		}
		return false;
	}

	protected virtual void PLHEHGHFCJI()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && needPlace)
			{
				((MonoBehaviour)this).StartCoroutine(LDFLKKIELBK(0));
			}
			IADJCJNEAED(INLCKKBGHMF: true);
		}
	}

	public virtual bool GKJKEDDHMCO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private IEnumerator LDFLKKIELBK(int JIIGOACEIKL)
	{
		return new ENDPPHNACKH(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	protected override void JGDGOCLJHJJ(int JIIGOACEIKL)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		base.JGDGOCLJHJJ(JIIGOACEIKL);
		BFMNCFECABF(open);
		if (!saveAtWorldTiles)
		{
			return;
		}
		BuildSquare[] buildSquares = placeable.itemSpace.buildSquares;
		for (int i = 0; i < buildSquares.Length; i++)
		{
			if (i % 2 == 1)
			{
				WorldGrid.PBOIFLICMKG(buildSquares[i].GetCentrePosition(), (MonoBehaviour)(object)this);
			}
		}
	}

	public void HIJLBLCHOMP(bool DBCDEKIEHMG, bool CDPAMNIPPEC = true)
	{
		if (AGJJEBPPPAC() != DBCDEKIEHMG)
		{
			HHDADDPHGCI(DBCDEKIEHMG);
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				(placeable.onlinePlaceable as OnlineDoor).MFGDBFIDCKB(DBCDEKIEHMG);
			}
		}
	}

	protected virtual void BMBKDPGLLHM(int MENBAFNNBFB)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (MENBAFNNBFB < PHKJJFEHBMK.Length)
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[MENBAFNNBFB];
		}
		if (Object.op_Implicit((Object)(object)topDoorSpriteRenderer) && MENBAFNNBFB < topDoorAnimationSprites.Length)
		{
			topDoorSpriteRenderer.sprite = topDoorAnimationSprites[MENBAFNNBFB];
		}
		if (!Object.op_Implicit((Object)(object)AOSpriteRenderer))
		{
			return;
		}
		if (WorldGrid.GKAGNKMAJOE(placeable.itemSpace.GetBuildSquare(1, 1).EHGDHOMFDGM()) == MaterialType.None)
		{
			if (MENBAFNNBFB < AOAnimationSpritesStone.Length)
			{
				AOSpriteRenderer.sprite = AOAnimationSpritesStone[MENBAFNNBFB];
			}
		}
		else if (MENBAFNNBFB < AOAnimationSpritesWood.Length)
		{
			AOSpriteRenderer.sprite = AOAnimationSpritesWood[MENBAFNNBFB];
		}
	}

	protected virtual IEnumerator DJMLAMGMGAP()
	{
		return new MFAPEEDDODJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public virtual bool PHJEHEOFJFN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	protected virtual IEnumerator CALGEIKINMB()
	{
		MultiAudioManager.PlayAudioObject(closeDoor, soundPosition);
		for (int i = PHKJJFEHBMK.Length - 2; i >= 0; i--)
		{
			yield return (object)new WaitForSeconds(frameRate);
			LHIJLCIDHPC(i);
		}
		open = false;
		if (Object.op_Implicit((Object)(object)collidersOnEnter))
		{
			((Component)collidersOnEnter).transform.localPosition = Vector3.up * 0.4f;
		}
		ILHFNKIICFP(GBPLEBIBIGJ: true);
		BFMNCFECABF(open);
		FCFIOFPDCNN = null;
	}

	public virtual void PCCIFEFKFGM(bool INLCKKBGHMF)
	{
		if (INLCKKBGHMF && backDoorAnimationSprites != null && backDoorAnimationSprites.Length != 0)
		{
			PHKJJFEHBMK = backDoorAnimationSprites;
		}
		else
		{
			PHKJJFEHBMK = doorAnimationSprites;
		}
		if (open)
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[PHKJJFEHBMK.Length - 1];
		}
		else
		{
			doorSpriteRenderer.sprite = PHKJJFEHBMK[1];
		}
	}

	public bool NCOPEIEMBCI(int JIIGOACEIKL)
	{
		return false;
	}

	public bool DAKHAHICKMO(int JIIGOACEIKL)
	{
		return false;
	}

	protected virtual void JNBFKJDCBGN()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && needPlace)
			{
				((MonoBehaviour)this).StartCoroutine(OOLPFGHNCGK(0));
			}
			SetAnimationSprites(INLCKKBGHMF: false);
		}
	}

	private void PDBNAFJJLCM(bool GAKNPAMHAFB)
	{
	}

	public void OpenCloseAction(bool DBCDEKIEHMG, bool CDPAMNIPPEC = true)
	{
		if (ECMGCJGPKNO != DBCDEKIEHMG)
		{
			ECMGCJGPKNO = DBCDEKIEHMG;
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				(placeable.onlinePlaceable as OnlineDoor).SendOpen(DBCDEKIEHMG);
			}
		}
	}

	public virtual bool HGBPIJGKALA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}
}
