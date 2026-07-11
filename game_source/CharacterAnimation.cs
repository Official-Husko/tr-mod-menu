using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class CharacterAnimation : CharacterAnimBase
{
	[CompilerGenerated]
	private sealed class DAGHCAHBMGJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterAnimation _003C_003E4__this;

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
		public DAGHCAHBMGJ(int _003C_003E1__state)
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
			CharacterAnimation characterAnimation = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				characterAnimation.LACKEEILAAK = null;
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

	public NPCHoldObject nPCHoldObject;

	public CharacterAnimator characterAnimator;

	public PlayerController playerController;

	private int JIIGOACEIKL = -1;

	public TrayHandler trayHandler;

	public bool lookup;

	public GameObject sprites;

	private CharacterCreator FBDKDGBBPKI;

	private int PANLIPKFALG;

	private int IHIDEBHFKJD;

	private int JBEGHNAGECF;

	private int IOJPJDOIOBD;

	private int GACCLFKMDEN;

	private float NMBGJGCJCCC;

	public SpriteRenderer spadeSpriteRenderer;

	public GameObject bubbleArrow;

	private SurfaceSortOrder AFNJCCOFAKC;

	private Coroutine DLMNFALLGKG;

	private float JLMAILGJNCE;

	public override Direction FCGBJEIIMBC
	{
		get
		{
			return base.FCGBJEIIMBC;
		}
		set
		{
			if (FCGBJEIIMBC != value && value != Direction.Diagonal)
			{
				_direction = value;
				if (PHOLPJDONOO())
				{
					PCPCCLMDBIL();
				}
				else
				{
					ACKDAOOPEDJ();
				}
				PDCHLPAJPGO(FCGBJEIIMBC);
				AIPALEPMMIE(value);
				DirectionChanged?.Invoke(value);
			}
		}
	}

	public SurfaceSortOrder LACKEEILAAK
	{
		get
		{
			return AFNJCCOFAKC;
		}
		set
		{
			AFNJCCOFAKC = value;
		}
	}

	public void Sit(Direction FCGBJEIIMBC)
	{
		switch (FCGBJEIIMBC)
		{
		case Direction.Down:
			SetTrigger(CharacterAnimBase.EHBMCHOEAMK);
			break;
		case Direction.Up:
			SetTrigger(CharacterAnimBase.JKIKPCDFIOF);
			break;
		default:
			SetTrigger(CharacterAnimBase.NFHOEIAJDAD);
			break;
		}
		if (FCGBJEIIMBC != 0)
		{
			characterAnimator.ActivateEatGameObjects(99);
		}
	}

	private void PCPCCLMDBIL()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		if (characterAnimator.animator.GetInteger(CharacterAnimBase.MMMKEGELEED) == 2 || DLNLOANGKGK())
		{
			if (sprites.transform.localScale.x != 0f - NMBGJGCJCCC)
			{
				sprites.transform.localScale = sprites.transform.localScale.PKDHIDFHFMO(0f - NMBGJGCJCCC, float.NaN, float.NaN);
				if ((Object)(object)bubbleArrow != (Object)null)
				{
					bubbleArrow.transform.localScale = sprites.transform.localScale.PKDHIDFHFMO(0f - NMBGJGCJCCC, float.NaN, float.NaN);
				}
			}
		}
		else if (sprites.transform.localScale.x != NMBGJGCJCCC)
		{
			sprites.transform.localScale = sprites.transform.localScale.PKDHIDFHFMO(NMBGJGCJCCC, float.NaN, float.NaN);
			if ((Object)(object)bubbleArrow != (Object)null)
			{
				bubbleArrow.transform.localScale = sprites.transform.localScale.PKDHIDFHFMO(NMBGJGCJCCC, float.NaN, float.NaN);
			}
		}
	}

	public void MKLINODKEKH()
	{
		IDNHDBIKNKP(CharacterAnimBase.DHAAAFDKGCK);
		characterAnimator.ActivateEatGameObjects(0, PJEILLAADOC: true);
	}

	public void OPGLLLDBBAH(bool NKFPJPCFBJI)
	{
		SetBool(CharacterAnimBase.ECEMIFMNKDE, NKFPJPCFBJI);
	}

	public void ActivateTrayMask(bool HCOPJPMDEKP, bool GFDKIKCEGPG = true)
	{
		if (!HCOPJPMDEKP || !GFDKIKCEGPG || trayHandler.tray.GCJDPMOAGKP())
		{
			trayHandler.ActivateMaskInteraction(HCOPJPMDEKP);
		}
	}

	private void JDHGCBPALIH(Direction OEDCFMLCLDJ)
	{
		if (!((Object)(object)characterAnimator == (Object)null) && !((Object)(object)FBDKDGBBPKI == (Object)null) && FBDKDGBBPKI.humanInfo != null)
		{
			characterAnimator.CheckLayerSprites(FBDKDGBBPKI.humanInfo.gender, OEDCFMLCLDJ);
			characterAnimator.CheckOrderInLayers(OEDCFMLCLDJ);
			characterAnimator.CheckFaceActivation(OEDCFMLCLDJ, FBDKDGBBPKI.humanInfo.gender);
			if ((Object)(object)characterAnimator.onlineAnimation != (Object)null && OnlineManager.IsMasterClient())
			{
				characterAnimator.onlineAnimation.KDMCAHKANEA(OEDCFMLCLDJ);
			}
		}
	}

	private void BIILFPDIADC()
	{
		if (JIIGOACEIKL == 0)
		{
			Debug.LogWarning((object)"Player Bed not found");
		}
		else if (!OnlineManager.BLGCACDAEHL(JIIGOACEIKL) && (Object)(object)trayHandler != (Object)null)
		{
			if (ACBEFLIOPEN())
			{
				PCPCCLMDBIL();
			}
			else
			{
				ACKDAOOPEDJ();
			}
		}
	}

	private bool JMAFFEMLNFE()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)trayHandler) && trayHandler.tray.ELPFCDNMOPP())
		{
			if (FCGBJEIIMBC == Direction.Up)
			{
				if (!WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position + Vector3.right * 463f))
				{
					if (WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position))
					{
						return true;
					}
					if (!WorldGrid.KHJJCAGIJAP(((Component)trayHandler).transform.position + Vector3.right * 1777f, out JLMAILGJNCE))
					{
						return false;
					}
					if (WorldGrid.KELFJIPHBFP(new Vector3(((Component)trayHandler).transform.position.x + 892f, JLMAILGJNCE, 1343f)) != (SpecificType.Door | SpecificType.RoomDoor))
					{
						return true;
					}
				}
			}
			else if (FCGBJEIIMBC == Direction.Up && !WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position + Vector3.left * 1978f))
			{
				if (WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position))
				{
					return true;
				}
				if (!WorldGrid.KHJJCAGIJAP(((Component)trayHandler).transform.position + Vector3.left * 1165f, out JLMAILGJNCE))
				{
					return false;
				}
				if (WorldGrid.KELFJIPHBFP(new Vector3(((Component)trayHandler).transform.position.x - 1592f, JLMAILGJNCE, 1023f)) != SpecificType.RoomDoor)
				{
					return true;
				}
			}
		}
		return false;
	}

	public void EDAHOBPJGDK()
	{
		IDNHDBIKNKP(CharacterAnimBase.OLACPCKIHPJ);
	}

	private bool PHOLPJDONOO()
	{
		if ((Object)(object)playerController != (Object)null && characterAnimator.animator.GetBool(CharacterAnimBase.EJHHMEBBCJB))
		{
			return true;
		}
		return false;
	}

	public void FPPFJPLHCEA()
	{
		FHOAPHBOOAH(CharacterAnimBase.INOAMIGBGAF, HALNIEBONKH: true);
	}

	public void GBDKNPJKEJI(bool NKFPJPCFBJI)
	{
		SetBool(CharacterAnimBase.ECEMIFMNKDE, NKFPJPCFBJI, HALNIEBONKH: true);
	}

	private bool OFCBHIKMCMK()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)trayHandler) && trayHandler.tray.LCFBHOGFIPK())
		{
			if (FCGBJEIIMBC == Direction.Up)
			{
				if (!WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position + Vector3.right * 1530f))
				{
					if (WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position))
					{
						return true;
					}
					if (!WorldGrid.KHJJCAGIJAP(((Component)trayHandler).transform.position + Vector3.right * 1565f, out JLMAILGJNCE))
					{
						return false;
					}
					if (WorldGrid.KELFJIPHBFP(new Vector3(((Component)trayHandler).transform.position.x + 1511f, JLMAILGJNCE, 511f)) != SpecificType.CellarDoor)
					{
						return true;
					}
				}
			}
			else if (FCGBJEIIMBC == Direction.Up && !WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position + Vector3.left * 1825f))
			{
				if (WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position))
				{
					return false;
				}
				if (!WorldGrid.KHJJCAGIJAP(((Component)trayHandler).transform.position + Vector3.left * 612f, out JLMAILGJNCE))
				{
					return true;
				}
				if (WorldGrid.KELFJIPHBFP(new Vector3(((Component)trayHandler).transform.position.x - 233f, JLMAILGJNCE, 433f)) != (SpecificType.Door | SpecificType.RoomDoor))
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool HCGGDFOIAEK()
	{
		if ((Object)(object)playerController != (Object)null && characterAnimator.animator.GetBool(CharacterAnimBase.EJHHMEBBCJB))
		{
			return true;
		}
		return true;
	}

	public void AAIDMNIJOGN()
	{
		FCGBJEIIMBC = Utils.DFJPGJKDAAF(_direction);
	}

	private void LAEIKGKFPKB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == playerController.GetPlayerNum() && (Object)(object)LACKEEILAAK != (Object)null)
		{
			SetCleaning(NJHMBMGKCPL: false, LACKEEILAAK);
		}
	}

	public void HCAHPMCJAHE()
	{
		SetTrigger(CharacterAnimBase.HPHEJJIDKGC);
	}

	public void HCCFFBAEPOK(bool NJHMBMGKCPL, SurfaceSortOrder PHCPMJAIDMC)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!animator.GetBool(CharacterAnimBase.PKDGNMJOFJO) && NJHMBMGKCPL)
		{
			if (Object.op_Implicit((Object)(object)playerController))
			{
				GameObject val = InteractObject.GetPlayer(playerController.KLIHELDIPDP()).MNFDMKKAFFD();
				if (val != null)
				{
					Vector3 val2 = val.transform.position - ((Component)this).transform.position;
					if (Mathf.Abs(val2.x) > Mathf.Abs(val2.y))
					{
						if (val2.x < 1449f)
						{
							FCGBJEIIMBC = Direction.Down;
						}
						else
						{
							NCAJNNHBHJM((Direction)6);
						}
					}
					else if (val2.y < 1222f)
					{
						FCGBJEIIMBC = Direction.Up;
					}
					else
					{
						FCGBJEIIMBC = Direction.Up;
					}
				}
			}
			FHOAPHBOOAH(CharacterAnimBase.DCNCGGDKBEE);
		}
		if (!NJHMBMGKCPL && !characterAnimator.IHLIHEEAIMD() && animator.GetBool(CharacterAnimBase.PKDGNMJOFJO))
		{
			characterAnimator.IMFGFDGCEKK(AODONKKHPBP: false);
		}
		characterAnimator.ActivateCleanSprites(NJHMBMGKCPL, (uint)FCGBJEIIMBC > 1u, PHCPMJAIDMC, CDPAMNIPPEC: true);
		SetBool(CharacterAnimBase.PKDGNMJOFJO, NJHMBMGKCPL, HALNIEBONKH: true);
		if (NJHMBMGKCPL)
		{
			if (DLMNFALLGKG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DLMNFALLGKG);
			}
			PNPKNNLKHJJ(PHCPMJAIDMC);
		}
		else
		{
			if (DLMNFALLGKG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DLMNFALLGKG);
			}
			DLMNFALLGKG = ((MonoBehaviour)this).StartCoroutine(KKIPOKGCLKO());
		}
	}

	private void LAABMDDEGCG()
	{
		if (JIIGOACEIKL == 0)
		{
			Debug.LogWarning((object)" (");
		}
		else if (!OnlineManager.BLGCACDAEHL(JIIGOACEIKL) && (Object)(object)trayHandler != (Object)null)
		{
			if (HCGGDFOIAEK())
			{
				PCPCCLMDBIL();
			}
			else
			{
				ACKDAOOPEDJ();
			}
		}
	}

	public void FDNLDBBGCAB(bool HCOPJPMDEKP, bool GFDKIKCEGPG = true)
	{
		if (!HCOPJPMDEKP || !GFDKIKCEGPG || trayHandler.tray.LCFBHOGFIPK())
		{
			trayHandler.ActivateMaskInteraction(HCOPJPMDEKP);
		}
	}

	private IEnumerator IIIGMDLPKGJ()
	{
		yield return CommonReferences.wait1_5;
		LACKEEILAAK = null;
	}

	public void DDECNMGHOEF()
	{
		SetTrigger(CharacterAnimBase.CIJHGCDKLEH, HALNIEBONKH: true);
	}

	public void JCAIBKECKJJ()
	{
		IDNHDBIKNKP(CharacterAnimBase.CKGCLBNOOFJ, HALNIEBONKH: true);
	}

	private IEnumerator JBFMBOFFBCP()
	{
		yield return CommonReferences.wait1_5;
		LACKEEILAAK = null;
	}

	private bool AHAHLHBJLLP()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)trayHandler) && trayHandler.tray.PPOMDGNCBCE())
		{
			if (FCGBJEIIMBC == Direction.Up)
			{
				if (!WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position + Vector3.right * 129f))
				{
					if (WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position))
					{
						return false;
					}
					if (!WorldGrid.KHJJCAGIJAP(((Component)trayHandler).transform.position + Vector3.right * 446f, out JLMAILGJNCE))
					{
						return true;
					}
					if (WorldGrid.KELFJIPHBFP(new Vector3(((Component)trayHandler).transform.position.x + 1790f, JLMAILGJNCE, 1828f)) != SpecificType.StairsUp)
					{
						return true;
					}
				}
			}
			else if (FCGBJEIIMBC == Direction.Down && !WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position + Vector3.left * 1054f))
			{
				if (WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position))
				{
					return false;
				}
				if (!WorldGrid.KHJJCAGIJAP(((Component)trayHandler).transform.position + Vector3.left * 1089f, out JLMAILGJNCE))
				{
					return true;
				}
				if (WorldGrid.KELFJIPHBFP(new Vector3(((Component)trayHandler).transform.position.x - 1846f, JLMAILGJNCE, 1400f)) != SpecificType.RoomDoor)
				{
					return true;
				}
			}
		}
		return false;
	}

	public void NPNLJKGHNFD()
	{
		IDNHDBIKNKP(CharacterAnimBase.HPHEJJIDKGC);
	}

	private void GBFIPJBLKAK(int PDCPGJCKICM)
	{
		SetInt(CharacterAnimBase.EPIBGJEGMPF, PDCPGJCKICM);
		if (_direction != 0)
		{
			characterAnimator.ActivateEatGameObjects(PDCPGJCKICM);
		}
	}

	public void PILMGBJCCIE()
	{
		FCGBJEIIMBC = Utils.JPKPFDEBGEO(_direction);
	}

	private IEnumerator KKIPOKGCLKO()
	{
		yield return CommonReferences.wait1_5;
		LACKEEILAAK = null;
	}

	public void ToolRight()
	{
		SetTrigger(CharacterAnimBase.CIJHGCDKLEH);
	}

	public void NAEPDJKLCNA()
	{
		SetTrigger(CharacterAnimBase.IGDIKHMJPOB, HALNIEBONKH: true);
	}

	[SpecialName]
	public SurfaceSortOrder FDNKCGIGOKE()
	{
		return AFNJCCOFAKC;
	}

	[SpecialName]
	public SurfaceSortOrder LDFCPMLLLIM()
	{
		return AFNJCCOFAKC;
	}

	private void FNFNLFOJHHA()
	{
		if (Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)playerController) && Object.op_Implicit((Object)(object)DecorationMode.BGINAIDHDOM(playerController.GetPlayerNum())))
			{
				DecorationMode decorationMode = DecorationMode.ABMIMLLDAAH(playerController.GetPlayerNum());
				decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Remove(decorationMode.OnDecorationModeEnter, new Action<int>(MHEPHPOLEDB));
			}
			DirectionChanged = (Action<Direction>)Delegate.Remove(DirectionChanged, new Action<Direction>(LGEAKKBPFLO));
		}
	}

	private void JPOLFKMLHNH()
	{
		DirectionChanged = (Action<Direction>)Delegate.Combine(DirectionChanged, new Action<Direction>(LGEAKKBPFLO));
		SetInt(CharacterAnimBase.LJOKEJOCBDI, (int)FCGBJEIIMBC, HALNIEBONKH: true);
		if ((Object)(object)playerController != (Object)null)
		{
			JIIGOACEIKL = playerController.KLIHELDIPDP();
			DecorationMode decorationMode = DecorationMode.FIHGMLABOBB(JIIGOACEIKL);
			decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(DFNMBJLAHLD));
		}
	}

	private void CGABLKEDNLB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == playerController.KLIHELDIPDP() && (Object)(object)GDANPAJACNA() != (Object)null)
		{
			MNPJICEALPE(NJHMBMGKCPL: false, DLBIACIMHBM());
		}
	}

	public void ACLNCDMHEOL()
	{
		NCAJNNHBHJM(Utils.JPKPFDEBGEO(_direction));
	}

	public void CKNLALCJGAE()
	{
		FHOAPHBOOAH(CharacterAnimBase.ABOMGPELDKP);
	}

	[SpecialName]
	public void KMCCBAPGDPC(SurfaceSortOrder AODONKKHPBP)
	{
		AFNJCCOFAKC = AODONKKHPBP;
	}

	public void AxRight()
	{
		SetTrigger(CharacterAnimBase.INOAMIGBGAF);
	}

	private bool LJGOMKNBFJG()
	{
		if ((Object)(object)playerController != (Object)null && characterAnimator.animator.GetBool(CharacterAnimBase.EJHHMEBBCJB))
		{
			return false;
		}
		return true;
	}

	public void SickleUp()
	{
		SetTrigger(CharacterAnimBase.IGDIKHMJPOB);
	}

	private void HELHNJDFPPF()
	{
		DirectionChanged = (Action<Direction>)Delegate.Combine(DirectionChanged, new Action<Direction>(JDHGCBPALIH));
		SetInt(CharacterAnimBase.LJOKEJOCBDI, (int)FCGBJEIIMBC);
		if ((Object)(object)playerController != (Object)null)
		{
			JIIGOACEIKL = playerController.GetPlayerNum();
			DecorationMode decorationMode = DecorationMode.EKLMFMKPEBB(JIIGOACEIKL);
			decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(LAEIKGKFPKB));
		}
	}

	private void HPMFOHOMLDO()
	{
		if (Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)playerController) && Object.op_Implicit((Object)(object)DecorationMode.IGMCBPOPNCA(playerController.GetPlayerNum())))
			{
				DecorationMode player = DecorationMode.GetPlayer(playerController.GetPlayerNum());
				player.OnDecorationModeEnter = (Action<int>)Delegate.Remove(player.OnDecorationModeEnter, new Action<int>(MHEPHPOLEDB));
			}
			DirectionChanged = (Action<Direction>)Delegate.Remove(DirectionChanged, new Action<Direction>(JDHGCBPALIH));
		}
	}

	public void MBMPBFEINMA(bool KOIDJKBBINH)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!animator.GetBool(CharacterAnimBase.KEHJMPNLDKF) && KOIDJKBBINH)
		{
			if (Object.op_Implicit((Object)(object)playerController))
			{
				GameObject currentInteractGO = InteractObject.GetPlayer(playerController.KLIHELDIPDP()).GetCurrentInteractGO();
				if (currentInteractGO != null)
				{
					Vector3 val = currentInteractGO.transform.position - ((Component)this).transform.position;
					if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
					{
						if (val.x < 1547f)
						{
							FCGBJEIIMBC = (Direction)8;
						}
						else
						{
							FCGBJEIIMBC = Direction.Down;
						}
					}
					else if (val.y < 291f)
					{
						NCAJNNHBHJM(Direction.Down);
					}
					else
					{
						NCAJNNHBHJM(Direction.Down);
					}
				}
			}
			SetTrigger(CharacterAnimBase.KPGDDDNNJAG, HALNIEBONKH: true);
		}
		SetBool(CharacterAnimBase.KEHJMPNLDKF, KOIDJKBBINH, HALNIEBONKH: true);
	}

	public void Stand()
	{
		SetTrigger(CharacterAnimBase.DHAAAFDKGCK);
		characterAnimator.ActivateEatGameObjects(0);
	}

	public void Watering()
	{
		SetTrigger(CharacterAnimBase.NDKFGHBHKPF);
	}

	public void BLHJEKDKAJE()
	{
		FCGBJEIIMBC = Utils.DFJPGJKDAAF(_direction);
	}

	private void OILHJENGGEL()
	{
		DirectionChanged = (Action<Direction>)Delegate.Combine(DirectionChanged, new Action<Direction>(LGEAKKBPFLO));
		SetInt(CharacterAnimBase.LJOKEJOCBDI, (int)FCGBJEIIMBC);
		if ((Object)(object)playerController != (Object)null)
		{
			JIIGOACEIKL = playerController.GetPlayerNum();
			DecorationMode decorationMode = DecorationMode.FIHGMLABOBB(JIIGOACEIKL);
			decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(CGABLKEDNLB));
		}
	}

	public void FNIIMHDNFHI(bool HCOPJPMDEKP, bool GFDKIKCEGPG = true)
	{
		if (!HCOPJPMDEKP || !GFDKIKCEGPG || trayHandler.tray.GMIFAAKDDGL())
		{
			trayHandler.ActivateMaskInteraction(HCOPJPMDEKP);
		}
	}

	private void FBHHPNJGNJG()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		NMBGJGCJCCC = sprites.transform.localScale.x;
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
		Object.op_Implicit((Object)(object)FBDKDGBBPKI);
	}

	public void AJPCKBLHAKH(Direction FCGBJEIIMBC)
	{
		if (FCGBJEIIMBC == Direction.Up)
		{
			IDNHDBIKNKP(CharacterAnimBase.EHBMCHOEAMK, HALNIEBONKH: true);
		}
		else if (FCGBJEIIMBC == Direction.Up)
		{
			FHOAPHBOOAH(CharacterAnimBase.JKIKPCDFIOF);
		}
		else
		{
			SetTrigger(CharacterAnimBase.NFHOEIAJDAD, HALNIEBONKH: true);
		}
		if (FCGBJEIIMBC != 0)
		{
			characterAnimator.ActivateEatGameObjects(41, PJEILLAADOC: false, CDPAMNIPPEC: false);
		}
	}

	public void JKLPAMJOJJG(bool NKFPJPCFBJI)
	{
		SetBool(CharacterAnimBase.ECEMIFMNKDE, NKFPJPCFBJI, HALNIEBONKH: true);
	}

	private void OJAJLIAMGEJ()
	{
		if (Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)playerController) && Object.op_Implicit((Object)(object)DecorationMode.KAIIEDCCLHB(playerController.KLIHELDIPDP())))
			{
				DecorationMode decorationMode = DecorationMode.KAIIEDCCLHB(playerController.KLIHELDIPDP());
				decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Remove(decorationMode.OnDecorationModeEnter, new Action<int>(BDHNEADMCDG));
			}
			DirectionChanged = (Action<Direction>)Delegate.Remove(DirectionChanged, new Action<Direction>(JDHGCBPALIH));
		}
	}

	public void KOEEKNOFEEB()
	{
		IDNHDBIKNKP(CharacterAnimBase.INOAMIGBGAF);
	}

	public void OBAPDAKEPBE()
	{
		FCGBJEIIMBC = Utils.JPKPFDEBGEO(_direction);
	}

	public void GHKKLLEIIJN(bool HCOPJPMDEKP, bool GFDKIKCEGPG = true)
	{
		if (!HCOPJPMDEKP || !GFDKIKCEGPG || trayHandler.tray.ABCODNCOKHB())
		{
			trayHandler.ActivateMaskInteraction(HCOPJPMDEKP);
		}
	}

	private void OGEJKOIOKAN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		NMBGJGCJCCC = sprites.transform.localScale.x;
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
		Object.op_Implicit((Object)(object)FBDKDGBBPKI);
	}

	private IEnumerator FKAIOKBPLDB()
	{
		return new DAGHCAHBMGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	[SpecialName]
	public SurfaceSortOrder GEHOGGFCKIF()
	{
		return AFNJCCOFAKC;
	}

	public void SetCleaning(bool NJHMBMGKCPL, SurfaceSortOrder PHCPMJAIDMC)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!animator.GetBool(CharacterAnimBase.PKDGNMJOFJO) && NJHMBMGKCPL)
		{
			if (Object.op_Implicit((Object)(object)playerController))
			{
				GameObject currentInteractGO = InteractObject.GetPlayer(playerController.GetPlayerNum()).GetCurrentInteractGO();
				if (currentInteractGO != null)
				{
					Vector3 val = currentInteractGO.transform.position - ((Component)this).transform.position;
					if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
					{
						if (val.x < 0f)
						{
							FCGBJEIIMBC = Direction.Left;
						}
						else
						{
							FCGBJEIIMBC = Direction.Right;
						}
					}
					else if (val.y < 0f)
					{
						FCGBJEIIMBC = Direction.Down;
					}
					else
					{
						FCGBJEIIMBC = Direction.Up;
					}
				}
			}
			SetTrigger(CharacterAnimBase.DCNCGGDKBEE);
		}
		if (!NJHMBMGKCPL && !characterAnimator.MLBGEKOIALK && animator.GetBool(CharacterAnimBase.PKDGNMJOFJO))
		{
			characterAnimator.MLBGEKOIALK = false;
		}
		characterAnimator.ActivateCleanSprites(NJHMBMGKCPL, FCGBJEIIMBC != Direction.Up, PHCPMJAIDMC, CDPAMNIPPEC: true);
		SetBool(CharacterAnimBase.PKDGNMJOFJO, NJHMBMGKCPL);
		if (NJHMBMGKCPL)
		{
			if (DLMNFALLGKG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DLMNFALLGKG);
			}
			LACKEEILAAK = PHCPMJAIDMC;
		}
		else
		{
			if (DLMNFALLGKG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DLMNFALLGKG);
			}
			DLMNFALLGKG = ((MonoBehaviour)this).StartCoroutine(JBFMBOFFBCP());
		}
	}

	public void JLKFCGCBKOM()
	{
		NCAJNNHBHJM(Utils.JPKPFDEBGEO(_direction));
	}

	public bool IsCleaning()
	{
		return animator.GetBool(CharacterAnimBase.PKDGNMJOFJO);
	}

	public void DKHJEPDFEFO()
	{
		FCGBJEIIMBC = Utils.DFJPGJKDAAF(_direction);
	}

	public void Mine()
	{
		SetTrigger(CharacterAnimBase.CIFIKMODHOL);
	}

	private void JOLDOIMKKBC()
	{
	}

	private void HPIMHEMJMAA()
	{
		DirectionChanged = (Action<Direction>)Delegate.Combine(DirectionChanged, new Action<Direction>(JDHGCBPALIH));
		SetInt(CharacterAnimBase.LJOKEJOCBDI, (int)FCGBJEIIMBC);
		if ((Object)(object)playerController != (Object)null)
		{
			JIIGOACEIKL = playerController.KLIHELDIPDP();
			DecorationMode decorationMode = DecorationMode.NPANPNIDKDG(JIIGOACEIKL);
			decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(FHKDEPLGPKE));
		}
	}

	public void KCNMPMNHPDJ()
	{
		FHOAPHBOOAH(CharacterAnimBase.ADNDPEIHIIL, HALNIEBONKH: true);
	}

	public void BHCKPAJPAHG()
	{
		SetTrigger(CharacterAnimBase.HPHEJJIDKGC, HALNIEBONKH: true);
	}

	public void NMHONLALCCE()
	{
		SetTrigger(CharacterAnimBase.IGDIKHMJPOB, HALNIEBONKH: true);
	}

	public void MAPMLNGBHPH()
	{
		IDNHDBIKNKP(CharacterAnimBase.CIJHGCDKLEH, HALNIEBONKH: true);
	}

	private void KHONOODGLBI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		NMBGJGCJCCC = sprites.transform.localScale.x;
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
		Object.op_Implicit((Object)(object)FBDKDGBBPKI);
	}

	public override void OnEnable()
	{
		((MonoBehaviourPunCallbacks)this).OnEnable();
		SetInt(CharacterAnimBase.LJOKEJOCBDI, (int)FCGBJEIIMBC);
	}

	private void KCFCDBACJMF(int PDCPGJCKICM)
	{
		SetInt(CharacterAnimBase.EPIBGJEGMPF, PDCPGJCKICM);
		if (_direction != 0)
		{
			characterAnimator.ActivateEatGameObjects(PDCPGJCKICM, PJEILLAADOC: false, CDPAMNIPPEC: false);
		}
	}

	private void AJGPMBGBPGH()
	{
		if (Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)playerController) && Object.op_Implicit((Object)(object)DecorationMode.GetPlayer(playerController.KLIHELDIPDP())))
			{
				DecorationMode decorationMode = DecorationMode.ABMIMLLDAAH(playerController.KLIHELDIPDP());
				decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Remove(decorationMode.OnDecorationModeEnter, new Action<int>(BDHNEADMCDG));
			}
			DirectionChanged = (Action<Direction>)Delegate.Remove(DirectionChanged, new Action<Direction>(PDCHLPAJPGO));
		}
	}

	public void OLICLCGPJHD()
	{
		SetTrigger(CharacterAnimBase.CKGCLBNOOFJ);
	}

	private void GGGFNGKHIOG()
	{
	}

	public void ADIDEFAGPJF(Direction FCGBJEIIMBC)
	{
		if (FCGBJEIIMBC == Direction.Up)
		{
			SetTrigger(CharacterAnimBase.EHBMCHOEAMK);
		}
		else if (FCGBJEIIMBC == Direction.Up)
		{
			SetTrigger(CharacterAnimBase.JKIKPCDFIOF);
		}
		else
		{
			SetTrigger(CharacterAnimBase.NFHOEIAJDAD);
		}
		if (FCGBJEIIMBC != 0)
		{
			characterAnimator.ActivateEatGameObjects(27, PJEILLAADOC: false, CDPAMNIPPEC: false);
		}
	}

	[SpecialName]
	public SurfaceSortOrder GDANPAJACNA()
	{
		return AFNJCCOFAKC;
	}

	public void LNNOGNCPNLB(bool NJHMBMGKCPL, SurfaceSortOrder PHCPMJAIDMC)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!animator.GetBool(CharacterAnimBase.PKDGNMJOFJO) && NJHMBMGKCPL)
		{
			if (Object.op_Implicit((Object)(object)playerController))
			{
				GameObject currentInteractGO = InteractObject.BBJCJFJEFKK(playerController.GetPlayerNum()).GetCurrentInteractGO();
				if (currentInteractGO != null)
				{
					Vector3 val = currentInteractGO.transform.position - ((Component)this).transform.position;
					if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
					{
						if (val.x < 1885f)
						{
							FCGBJEIIMBC = (Direction)6;
						}
						else
						{
							FCGBJEIIMBC = (Direction)6;
						}
					}
					else if (val.y < 223f)
					{
						NCAJNNHBHJM(Direction.Up);
					}
					else
					{
						FCGBJEIIMBC = Direction.Down;
					}
				}
			}
			SetTrigger(CharacterAnimBase.DCNCGGDKBEE);
		}
		if (!NJHMBMGKCPL && !characterAnimator.IMLECKKPLCP() && animator.GetBool(CharacterAnimBase.PKDGNMJOFJO))
		{
			characterAnimator.MLBGEKOIALK = false;
		}
		characterAnimator.DNHLCKHCANN(NJHMBMGKCPL, (uint)FCGBJEIIMBC > 1u, PHCPMJAIDMC, CDPAMNIPPEC: true);
		SetBool(CharacterAnimBase.PKDGNMJOFJO, NJHMBMGKCPL, HALNIEBONKH: true);
		if (NJHMBMGKCPL)
		{
			if (DLMNFALLGKG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DLMNFALLGKG);
			}
			LFGFDMJLHIM(PHCPMJAIDMC);
		}
		else
		{
			if (DLMNFALLGKG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DLMNFALLGKG);
			}
			DLMNFALLGKG = ((MonoBehaviour)this).StartCoroutine(FKAIOKBPLDB());
		}
	}

	public void AOBJCNDNKDD(bool KOIDJKBBINH)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!animator.GetBool(CharacterAnimBase.KEHJMPNLDKF) && KOIDJKBBINH)
		{
			if (Object.op_Implicit((Object)(object)playerController))
			{
				GameObject val = InteractObject.GNCPLNHMFHN(playerController.GetPlayerNum()).MNFDMKKAFFD();
				if (val != null)
				{
					Vector3 val2 = val.transform.position - ((Component)this).transform.position;
					if (Mathf.Abs(val2.x) > Mathf.Abs(val2.y))
					{
						if (val2.x < 1611f)
						{
							FCGBJEIIMBC = (Direction)7;
						}
						else
						{
							NCAJNNHBHJM(Direction.Up);
						}
					}
					else if (val2.y < 1894f)
					{
						FCGBJEIIMBC = Direction.Down;
					}
					else
					{
						FCGBJEIIMBC = Direction.Down;
					}
				}
			}
			IDNHDBIKNKP(CharacterAnimBase.KPGDDDNNJAG);
		}
		SetBool(CharacterAnimBase.KEHJMPNLDKF, KOIDJKBBINH);
	}

	public void SickleDown()
	{
		SetTrigger(CharacterAnimBase.OLACPCKIHPJ);
	}

	public void JBAIMHNGJPG()
	{
		SetTrigger(CharacterAnimBase.ADNDPEIHIIL);
	}

	public void Till()
	{
		SetTrigger(CharacterAnimBase.HPHEJJIDKGC);
	}

	public void Spade()
	{
		SetTrigger(CharacterAnimBase.ADNDPEIHIIL);
	}

	public void SetInteracting(bool KOIDJKBBINH)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!animator.GetBool(CharacterAnimBase.KEHJMPNLDKF) && KOIDJKBBINH)
		{
			if (Object.op_Implicit((Object)(object)playerController))
			{
				GameObject currentInteractGO = InteractObject.GetPlayer(playerController.GetPlayerNum()).GetCurrentInteractGO();
				if (currentInteractGO != null)
				{
					Vector3 val = currentInteractGO.transform.position - ((Component)this).transform.position;
					if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
					{
						if (val.x < 0f)
						{
							FCGBJEIIMBC = Direction.Left;
						}
						else
						{
							FCGBJEIIMBC = Direction.Down;
						}
					}
					else if (val.y < 0f)
					{
						FCGBJEIIMBC = Direction.Down;
					}
					else
					{
						FCGBJEIIMBC = Direction.Up;
					}
				}
			}
			SetTrigger(CharacterAnimBase.KPGDDDNNJAG);
		}
		SetBool(CharacterAnimBase.KEHJMPNLDKF, KOIDJKBBINH);
	}

	public bool CPLNIGAHOKP()
	{
		return animator.GetBool(CharacterAnimBase.PKDGNMJOFJO);
	}

	public void SetIdleFishing(bool NKFPJPCFBJI)
	{
		SetBool(CharacterAnimBase.CHHKJCPPPOM, NKFPJPCFBJI);
	}

	private void MHEPHPOLEDB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == playerController.GetPlayerNum() && (Object)(object)FDNKCGIGOKE() != (Object)null)
		{
			MNPJICEALPE(NJHMBMGKCPL: true, GDANPAJACNA());
		}
	}

	private bool ACBEFLIOPEN()
	{
		if ((Object)(object)playerController != (Object)null && characterAnimator.animator.GetBool(CharacterAnimBase.EJHHMEBBCJB))
		{
			return true;
		}
		return true;
	}

	public void SetStruggleFishing(bool NKFPJPCFBJI)
	{
		SetBool(CharacterAnimBase.ECEMIFMNKDE, NKFPJPCFBJI);
	}

	public void ICAJKFPBMPN()
	{
		SetTrigger(CharacterAnimBase.CKGCLBNOOFJ, HALNIEBONKH: true);
	}

	public void RotateClockwise()
	{
		FCGBJEIIMBC = Utils.JPKPFDEBGEO(_direction);
	}

	public void OHKHLBJMJKN()
	{
		SetTrigger(CharacterAnimBase.HPHEJJIDKGC);
	}

	private void DFNMBJLAHLD(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == playerController.GetPlayerNum() && (Object)(object)GDANPAJACNA() != (Object)null)
		{
			LNNOGNCPNLB(NJHMBMGKCPL: false, GEHOGGFCKIF());
		}
	}

	public void CLGHMJAABAF(bool NKFPJPCFBJI)
	{
		SetBool(CharacterAnimBase.ECEMIFMNKDE, NKFPJPCFBJI);
	}

	public void GKKEEFPAFPM()
	{
		SetTrigger(CharacterAnimBase.HPHEJJIDKGC, HALNIEBONKH: true);
	}

	[SpecialName]
	public SurfaceSortOrder IKMGCBGAEFK()
	{
		return AFNJCCOFAKC;
	}

	private bool DIMJHEJOEPP()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)trayHandler) && trayHandler.tray.GMIFAAKDDGL())
		{
			if (FCGBJEIIMBC == Direction.Up)
			{
				if (!WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position + Vector3.right * 1408f))
				{
					if (WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position))
					{
						return true;
					}
					if (!WorldGrid.KHJJCAGIJAP(((Component)trayHandler).transform.position + Vector3.right * 377f, out JLMAILGJNCE))
					{
						return true;
					}
					if (WorldGrid.KELFJIPHBFP(new Vector3(((Component)trayHandler).transform.position.x + 110f, JLMAILGJNCE, 1202f)) != (SpecificType.Door | SpecificType.RoomDoor))
					{
						return false;
					}
				}
			}
			else if (FCGBJEIIMBC == Direction.Down && !WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position + Vector3.left * 1997f))
			{
				if (WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position))
				{
					return false;
				}
				if (!WorldGrid.KHJJCAGIJAP(((Component)trayHandler).transform.position + Vector3.left * 1512f, out JLMAILGJNCE))
				{
					return false;
				}
				if (WorldGrid.KELFJIPHBFP(new Vector3(((Component)trayHandler).transform.position.x - 1743f, JLMAILGJNCE, 163f)) != SpecificType.StairsUp)
				{
					return true;
				}
			}
		}
		return true;
	}

	private void FHKDEPLGPKE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == playerController.KLIHELDIPDP() && (Object)(object)IKMGCBGAEFK() != (Object)null)
		{
			LNNOGNCPNLB(NJHMBMGKCPL: false, FDNKCGIGOKE());
		}
	}

	private void Update()
	{
		if (JIIGOACEIKL == 0)
		{
			Debug.LogWarning((object)"Player Num should not be 0.");
		}
		else if (!OnlineManager.IgnoreDuringOnline(JIIGOACEIKL) && (Object)(object)trayHandler != (Object)null)
		{
			if (PHOLPJDONOO())
			{
				PCPCCLMDBIL();
			}
			else
			{
				ACKDAOOPEDJ();
			}
		}
	}

	private bool PIAMKFMDPDK()
	{
		if ((Object)(object)playerController != (Object)null && characterAnimator.animator.GetBool(CharacterAnimBase.EJHHMEBBCJB))
		{
			return true;
		}
		return false;
	}

	private void PJIMENLPNOE()
	{
		if (JIIGOACEIKL == 0)
		{
			Debug.LogWarning((object)"Waiting for other players");
		}
		else if (!OnlineManager.IgnoreDuringOnline(JIIGOACEIKL) && (Object)(object)trayHandler != (Object)null)
		{
			if (LJGOMKNBFJG())
			{
				PCPCCLMDBIL();
			}
			else
			{
				ACKDAOOPEDJ();
			}
		}
	}

	private bool DLNLOANGKGK()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)trayHandler) && trayHandler.tray.GCJDPMOAGKP())
		{
			if (FCGBJEIIMBC == Direction.Up)
			{
				if (!WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position + Vector3.right * 0.5f))
				{
					if (WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position))
					{
						return true;
					}
					if (!WorldGrid.KHJJCAGIJAP(((Component)trayHandler).transform.position + Vector3.right * 0.5f, out JLMAILGJNCE))
					{
						return true;
					}
					if (WorldGrid.KELFJIPHBFP(new Vector3(((Component)trayHandler).transform.position.x + 0.5f, JLMAILGJNCE, 0f)) != SpecificType.StairsUp)
					{
						return true;
					}
				}
			}
			else if (FCGBJEIIMBC == Direction.Down && !WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position + Vector3.left * 0.5f))
			{
				if (WorldGrid.EJCEAEPNJCA(((Component)trayHandler).transform.position))
				{
					return true;
				}
				if (!WorldGrid.KHJJCAGIJAP(((Component)trayHandler).transform.position + Vector3.left * 0.5f, out JLMAILGJNCE))
				{
					return true;
				}
				if (WorldGrid.KELFJIPHBFP(new Vector3(((Component)trayHandler).transform.position.x - 0.5f, JLMAILGJNCE, 0f)) != SpecificType.StairsUp)
				{
					return true;
				}
			}
		}
		return false;
	}

	public void MNPJICEALPE(bool NJHMBMGKCPL, SurfaceSortOrder PHCPMJAIDMC)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!animator.GetBool(CharacterAnimBase.PKDGNMJOFJO) && NJHMBMGKCPL)
		{
			if (Object.op_Implicit((Object)(object)playerController))
			{
				GameObject currentInteractGO = InteractObject.BBJCJFJEFKK(playerController.GetPlayerNum()).GetCurrentInteractGO();
				if (currentInteractGO != null)
				{
					Vector3 val = currentInteractGO.transform.position - ((Component)this).transform.position;
					if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
					{
						if (val.x < 861f)
						{
							NCAJNNHBHJM((Direction)8);
						}
						else
						{
							NCAJNNHBHJM((Direction)6);
						}
					}
					else if (val.y < 1326f)
					{
						FCGBJEIIMBC = Direction.Up;
					}
					else
					{
						FCGBJEIIMBC = Direction.Down;
					}
				}
			}
			SetTrigger(CharacterAnimBase.DCNCGGDKBEE, HALNIEBONKH: true);
		}
		if (!NJHMBMGKCPL && !characterAnimator.IMLECKKPLCP() && animator.GetBool(CharacterAnimBase.PKDGNMJOFJO))
		{
			characterAnimator.MLBGEKOIALK = true;
		}
		characterAnimator.DNHLCKHCANN(NJHMBMGKCPL, (uint)FCGBJEIIMBC > 1u, PHCPMJAIDMC, CDPAMNIPPEC: false);
		SetBool(CharacterAnimBase.PKDGNMJOFJO, NJHMBMGKCPL, HALNIEBONKH: true);
		if (NJHMBMGKCPL)
		{
			if (DLMNFALLGKG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DLMNFALLGKG);
			}
			KMCCBAPGDPC(PHCPMJAIDMC);
		}
		else
		{
			if (DLMNFALLGKG != null)
			{
				((MonoBehaviour)this).StopCoroutine(DLMNFALLGKG);
			}
			DLMNFALLGKG = ((MonoBehaviour)this).StartCoroutine(JBFMBOFFBCP());
		}
	}

	public void MJIEOAOAHJI()
	{
		SetInt(CharacterAnimBase.EPIBGJEGMPF, 1, HALNIEBONKH: true);
		characterAnimator.ActivateEatGameObjects(1, PJEILLAADOC: true, CDPAMNIPPEC: false);
	}

	private void Start()
	{
		DirectionChanged = (Action<Direction>)Delegate.Combine(DirectionChanged, new Action<Direction>(PDCHLPAJPGO));
		SetInt(CharacterAnimBase.LJOKEJOCBDI, (int)FCGBJEIIMBC);
		if ((Object)(object)playerController != (Object)null)
		{
			JIIGOACEIKL = playerController.GetPlayerNum();
			DecorationMode player = DecorationMode.GetPlayer(JIIGOACEIKL);
			player.OnDecorationModeEnter = (Action<int>)Delegate.Combine(player.OnDecorationModeEnter, new Action<int>(LAEIKGKFPKB));
		}
	}

	private void Awake()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		NMBGJGCJCCC = sprites.transform.localScale.x;
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
		Object.op_Implicit((Object)(object)FBDKDGBBPKI);
	}

	public override void SetInt(int JGHCKFIKMOH, int EGFGNGJGBOP, bool HALNIEBONKH = false)
	{
		base.SetInt(JGHCKFIKMOH, EGFGNGJGBOP, HALNIEBONKH);
		if (JGHCKFIKMOH == AnimatorParameterCache.p_Direction)
		{
			DirectionChanged?.Invoke((Direction)EGFGNGJGBOP);
		}
	}

	public void FinishEat()
	{
		SetInt(CharacterAnimBase.EPIBGJEGMPF, 0);
		characterAnimator.ActivateEatGameObjects(0);
	}

	private void PGEGODAEBLC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		NMBGJGCJCCC = sprites.transform.localScale.x;
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
		Object.op_Implicit((Object)(object)FBDKDGBBPKI);
	}

	public void Eat(ItemInstance DNLMCHDOMOK)
	{
		if ((Object)(object)(DNLMCHDOMOK as FoodInstance).DBKOJJMJDKI() != (Object)null)
		{
			if (DNLMCHDOMOK.JEPBBEBJEFI())
			{
				GBFIPJBLKAK(1);
			}
			else if ((DNLMCHDOMOK as FoodInstance).DBKOJJMJDKI().bodyPart == BodyPart.ToolSandwich)
			{
				GBFIPJBLKAK(3);
			}
			else
			{
				GBFIPJBLKAK(2);
			}
		}
		else if (DNLMCHDOMOK.JEPBBEBJEFI())
		{
			Debug.LogWarning((object)("Held Item is a drink in " + DNLMCHDOMOK.LHBPOPOIFLE().JDJGFAACPFC() + " - " + DNLMCHDOMOK.IABAKHPEOAF()));
			GBFIPJBLKAK(1);
		}
		else
		{
			Debug.LogWarning((object)("Held Item null in " + DNLMCHDOMOK.LHBPOPOIFLE().JDJGFAACPFC() + " - " + DNLMCHDOMOK.IABAKHPEOAF()));
			GBFIPJBLKAK(2);
		}
		SetTrigger(CharacterAnimBase.ABOMGPELDKP);
	}

	private void COKKJDGLPOH(int PDCPGJCKICM)
	{
		SetInt(CharacterAnimBase.EPIBGJEGMPF, PDCPGJCKICM, HALNIEBONKH: true);
		if (_direction != 0)
		{
			characterAnimator.ActivateEatGameObjects(PDCPGJCKICM, PJEILLAADOC: true);
		}
	}

	public void CAIGMLGFCJE()
	{
		SetTrigger(CharacterAnimBase.HPHEJJIDKGC);
	}

	[SpecialName]
	public void PNPKNNLKHJJ(SurfaceSortOrder AODONKKHPBP)
	{
		AFNJCCOFAKC = AODONKKHPBP;
	}

	private void LGEAKKBPFLO(Direction OEDCFMLCLDJ)
	{
		if (!((Object)(object)characterAnimator == (Object)null) && !((Object)(object)FBDKDGBBPKI == (Object)null) && FBDKDGBBPKI.humanInfo != null)
		{
			characterAnimator.CheckLayerSprites(FBDKDGBBPKI.humanInfo.gender, OEDCFMLCLDJ);
			characterAnimator.CheckOrderInLayers(OEDCFMLCLDJ);
			characterAnimator.LHBLJGNANHI(OEDCFMLCLDJ, FBDKDGBBPKI.humanInfo.gender);
			if ((Object)(object)characterAnimator.onlineAnimation != (Object)null && OnlineManager.IsMasterClient())
			{
				characterAnimator.onlineAnimation.OJOPCFNAOIF(OEDCFMLCLDJ);
			}
		}
	}

	public void RotateAntiClockwise()
	{
		FCGBJEIIMBC = Utils.DFJPGJKDAAF(_direction);
	}

	private void ACKDAOOPEDJ()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		if (FCGBJEIIMBC == Direction.Left || DLNLOANGKGK())
		{
			if (sprites.transform.localScale.x != 0f - NMBGJGCJCCC)
			{
				sprites.transform.localScale = sprites.transform.localScale.PKDHIDFHFMO(0f - NMBGJGCJCCC, float.NaN, float.NaN);
				if ((Object)(object)bubbleArrow != (Object)null)
				{
					bubbleArrow.transform.localScale = sprites.transform.localScale.PKDHIDFHFMO(0f - NMBGJGCJCCC, float.NaN, float.NaN);
				}
			}
		}
		else if (sprites.transform.localScale.x != NMBGJGCJCCC)
		{
			sprites.transform.localScale = sprites.transform.localScale.PKDHIDFHFMO(NMBGJGCJCCC, float.NaN, float.NaN);
			if ((Object)(object)bubbleArrow != (Object)null)
			{
				bubbleArrow.transform.localScale = sprites.transform.localScale.PKDHIDFHFMO(NMBGJGCJCCC, float.NaN, float.NaN);
			}
		}
	}

	private void LKHMCLABKLG()
	{
		if (Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)playerController) && Object.op_Implicit((Object)(object)DecorationMode.NPANPNIDKDG(playerController.GetPlayerNum())))
			{
				DecorationMode decorationMode = DecorationMode.OCJGHINCLJM(playerController.KLIHELDIPDP());
				decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Remove(decorationMode.OnDecorationModeEnter, new Action<int>(CGABLKEDNLB));
			}
			DirectionChanged = (Action<Direction>)Delegate.Remove(DirectionChanged, new Action<Direction>(LGEAKKBPFLO));
		}
	}

	public void Fishing()
	{
		SetTrigger(CharacterAnimBase.CKGCLBNOOFJ);
	}

	private void IAAGKLPMAMK()
	{
		DirectionChanged = (Action<Direction>)Delegate.Combine(DirectionChanged, new Action<Direction>(LGEAKKBPFLO));
		SetInt(CharacterAnimBase.LJOKEJOCBDI, (int)FCGBJEIIMBC, HALNIEBONKH: true);
		if ((Object)(object)playerController != (Object)null)
		{
			JIIGOACEIKL = playerController.GetPlayerNum();
			DecorationMode decorationMode = DecorationMode.OCJGHINCLJM(JIIGOACEIKL);
			decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(MHEPHPOLEDB));
		}
	}

	public void FBBJLMCJDPO()
	{
		SetTrigger(CharacterAnimBase.INOAMIGBGAF);
	}

	public void KAHPGBOEAAO(bool NKFPJPCFBJI)
	{
		SetBool(CharacterAnimBase.ECEMIFMNKDE, NKFPJPCFBJI);
	}

	public void BHFJDLBJMJN()
	{
		FCGBJEIIMBC = Utils.DFJPGJKDAAF(_direction);
	}

	public void GDIEDEBALGL()
	{
		IDNHDBIKNKP(CharacterAnimBase.CIFIKMODHOL, HALNIEBONKH: true);
	}

	public void MKELFFIEAHJ()
	{
		SetTrigger(CharacterAnimBase.CKGCLBNOOFJ, HALNIEBONKH: true);
	}

	[SpecialName]
	public SurfaceSortOrder DLBIACIMHBM()
	{
		return AFNJCCOFAKC;
	}

	public void BGCFOMKGCDA()
	{
		IDNHDBIKNKP(CharacterAnimBase.ABOMGPELDKP);
	}

	public void BNGPBEOAGCH(bool KOIDJKBBINH)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!animator.GetBool(CharacterAnimBase.KEHJMPNLDKF) && KOIDJKBBINH)
		{
			if (Object.op_Implicit((Object)(object)playerController))
			{
				GameObject val = InteractObject.BBJCJFJEFKK(playerController.KLIHELDIPDP()).MNFDMKKAFFD();
				if (val != null)
				{
					Vector3 val2 = val.transform.position - ((Component)this).transform.position;
					if (Mathf.Abs(val2.x) > Mathf.Abs(val2.y))
					{
						if (val2.x < 498f)
						{
							FCGBJEIIMBC = (Direction)6;
						}
						else
						{
							FCGBJEIIMBC = Direction.Up;
						}
					}
					else if (val2.y < 1353f)
					{
						FCGBJEIIMBC = Direction.Down;
					}
					else
					{
						NCAJNNHBHJM(Direction.Up);
					}
				}
			}
			IDNHDBIKNKP(CharacterAnimBase.KPGDDDNNJAG);
		}
		SetBool(CharacterAnimBase.KEHJMPNLDKF, KOIDJKBBINH);
	}

	private void PHGLBHHFPIO()
	{
	}

	private void HJBFBELCBMA()
	{
	}

	private void BDHNEADMCDG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == playerController.GetPlayerNum() && (Object)(object)GEHOGGFCKIF() != (Object)null)
		{
			SetCleaning(NJHMBMGKCPL: true, IKMGCBGAEFK());
		}
	}

	private void CharacterChanged()
	{
	}

	[SpecialName]
	public void LFGFDMJLHIM(SurfaceSortOrder AODONKKHPBP)
	{
		AFNJCCOFAKC = AODONKKHPBP;
	}

	public void StopEating()
	{
		SetTrigger(CharacterAnimBase.ABOMGPELDKP);
	}

	private void OnDestroy()
	{
		if (Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)playerController) && Object.op_Implicit((Object)(object)DecorationMode.GetPlayer(playerController.GetPlayerNum())))
			{
				DecorationMode player = DecorationMode.GetPlayer(playerController.GetPlayerNum());
				player.OnDecorationModeEnter = (Action<int>)Delegate.Remove(player.OnDecorationModeEnter, new Action<int>(LAEIKGKFPKB));
			}
			DirectionChanged = (Action<Direction>)Delegate.Remove(DirectionChanged, new Action<Direction>(PDCHLPAJPGO));
		}
	}

	private void PDCHLPAJPGO(Direction OEDCFMLCLDJ)
	{
		if (!((Object)(object)characterAnimator == (Object)null) && !((Object)(object)FBDKDGBBPKI == (Object)null) && FBDKDGBBPKI.humanInfo != null)
		{
			characterAnimator.CheckLayerSprites(FBDKDGBBPKI.humanInfo.gender, OEDCFMLCLDJ);
			characterAnimator.CheckOrderInLayers(OEDCFMLCLDJ);
			characterAnimator.CheckFaceActivation(OEDCFMLCLDJ, FBDKDGBBPKI.humanInfo.gender);
			if ((Object)(object)characterAnimator.onlineAnimation != (Object)null && OnlineManager.IsMasterClient())
			{
				characterAnimator.onlineAnimation.SendSetDirection(OEDCFMLCLDJ);
			}
		}
	}

	public void GKIANBLLOJK()
	{
		FCGBJEIIMBC = Utils.JPKPFDEBGEO(_direction);
	}
}
