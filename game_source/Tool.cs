using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class Tool : Item
{
	[CompilerGenerated]
	private sealed class EPCIKHIGNGA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int playerNum;

		public Tool _003C_003E4__this;

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
		public EPCIKHIGNGA(int _003C_003E1__state)
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
			Tool mOBFJEDPIPM = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				PlayerController.RemoveMovementBlocker(playerNum, (Object)(object)mOBFJEDPIPM);
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

	public AudioObject sound;

	public AudioObject weaponSound;

	public bool usesGrid;

	public GridInfo gridInfo;

	public ToolRowsInfoUI.ToolType toolType;

	protected Vector2 inputPositionAux;

	protected Vector2 inputPositionAux2;

	protected Vector2 inputPosition;

	protected Vector2 inputPosition2;

	protected Vector2 tilePosition;

	protected Vector2 tilePosition2;

	private float currentTime;

	private float currentTime2;

	[HideInInspector]
	public float holdTime = 0.4f;

	[Range(1f, 4f)]
	public int toolLevel = 1;

	private bool toolEndNow1 = true;

	private bool toolEndNow2 = true;

	protected const float range = 0.75f;

	public BodyPart bodyPart;

	public CharacterSprite skin;

	private Coroutine removeBlockerCoroutine;

	public void DJDDPBBIHLB(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 0)
		{
			currentTime = LGLDPMAABLA;
		}
		else
		{
			currentTime2 = LGLDPMAABLA;
		}
	}

	public int FEDHOEJNAII(int JIIGOACEIKL)
	{
		return toolLevel;
	}

	protected void PCEHBFMDBMG(int JIIGOACEIKL)
	{
		if (removeBlockerCoroutine != null)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StopCoroutine(removeBlockerCoroutine);
		}
	}

	public Vector2 BLFCGBDEDLP(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return inputPosition;
	}

	public void KHJLKHEGLAK(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 0)
		{
			inputPositionAux2 = IMOBLFMHKOD;
		}
		else
		{
			inputPositionAux = IMOBLFMHKOD;
		}
	}

	public void NDJLMNIJLFI(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 3)
		{
			tilePosition2 = IMOBLFMHKOD;
		}
		else
		{
			tilePosition = IMOBLFMHKOD;
		}
	}

	public void DODIJJEPHBO(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 2)
		{
			inputPositionAux2 = IMOBLFMHKOD;
		}
		else
		{
			inputPositionAux = IMOBLFMHKOD;
		}
	}

	public bool MJDLOICFCNH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 2)
		{
			return toolEndNow2;
		}
		return toolEndNow1;
	}

	public override ItemInstance KDNBBPJCNDJ(ItemInstance DNLMCHDOMOK)
	{
		return new ToolInstance((ToolInstance)DNLMCHDOMOK);
	}

	public Vector2 KCAKKCOHJFJ(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return inputPosition;
	}

	public Vector2 LJEOKENBKBC(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 6)
		{
			return inputPositionAux;
		}
		return inputPositionAux2;
	}

	public Vector2 EDKKKEMHIDE(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 2)
		{
			return tilePosition;
		}
		return tilePosition2;
	}

	public Vector2 DJDNHOLIJCA(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 5)
		{
			return inputPositionAux;
		}
		return inputPositionAux2;
	}

	public virtual void SecondActionEnd(int JIIGOACEIKL)
	{
	}

	public void KEAELNMELLO(int JIIGOACEIKL, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 4)
		{
			toolEndNow2 = NJHMBMGKCPL;
		}
		else
		{
			toolEndNow1 = NJHMBMGKCPL;
		}
	}

	public void IHKALDEHDCH(int JIIGOACEIKL, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 0)
		{
			toolEndNow2 = NJHMBMGKCPL;
		}
		else
		{
			toolEndNow1 = NJHMBMGKCPL;
		}
	}

	public void MPECPKPFKFB(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 0)
		{
			currentTime = LGLDPMAABLA;
		}
		else
		{
			currentTime2 = LGLDPMAABLA;
		}
	}

	public void HCJIFAGBKHL(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 2)
		{
			tilePosition2 = IMOBLFMHKOD;
		}
		else
		{
			tilePosition = IMOBLFMHKOD;
		}
	}

	protected void GGDHPGBLJGI(int JIIGOACEIKL)
	{
		if (removeBlockerCoroutine != null)
		{
			((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StopCoroutine(removeBlockerCoroutine);
		}
	}

	public void PFHANOMDDBL(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 8)
		{
			inputPositionAux2 = IMOBLFMHKOD;
		}
		else
		{
			inputPositionAux = IMOBLFMHKOD;
		}
	}

	protected void HCHCPFBFPLK(int JIIGOACEIKL, bool GLLNEFAPDDF = false)
	{
		if (GLLNEFAPDDF)
		{
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		}
		else
		{
			removeBlockerCoroutine = ((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StartCoroutine(CNKPDDBLBNH(JIIGOACEIKL));
		}
	}

	public void GPFCALFMEAM(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 1)
		{
			currentTime = LGLDPMAABLA;
		}
		else
		{
			currentTime2 = LGLDPMAABLA;
		}
	}

	public void JMLLOEKMKFA(int JIIGOACEIKL)
	{
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.JEJPKGILEDB("Ingredient group "))
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetTrigger("disableTutorial");
			if (PlayerController.GetPlayer(JIIGOACEIKL).horizontalMove != 1680f || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).verticalMove != 1950f)
			{
				MOPEAIHAJON(JIIGOACEIKL, NJHMBMGKCPL: false);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.CGEADHOLHCH("Visita Nocturna/MaiDialogue 01", EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
			else
			{
				ICKDIEEPHGL(JIIGOACEIKL, NJHMBMGKCPL: true);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.CGEADHOLHCH("{0} - Restoring non-altar variant object {1} at index {2} for piece {3}. Next variant index: {4}", EGFGNGJGBOP: true, HALNIEBONKH: true);
			}
		}
	}

	public virtual void DCPJBPNEDKE(int JIIGOACEIKL)
	{
	}

	public void OJIBPBKGGNK(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 1)
		{
			currentTime = LGLDPMAABLA;
		}
		else
		{
			currentTime2 = LGLDPMAABLA;
		}
	}

	public int CKLCHOFOOCJ(int JIIGOACEIKL)
	{
		return toolLevel;
	}

	public override ItemInstance JMDALJBNFML()
	{
		return new ToolInstance(this);
	}

	public void DOHJBGGDKMO(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 5)
		{
			tilePosition2 = IMOBLFMHKOD;
		}
		else
		{
			tilePosition = IMOBLFMHKOD;
		}
	}

	public void HJINPCNEJCB(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 2)
		{
			inputPositionAux2 = IMOBLFMHKOD;
		}
		else
		{
			inputPositionAux = IMOBLFMHKOD;
		}
	}

	public void AEECFCJIMIJ(int JIIGOACEIKL, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 0)
		{
			toolEndNow2 = NJHMBMGKCPL;
		}
		else
		{
			toolEndNow1 = NJHMBMGKCPL;
		}
	}

	public bool GHLPLIDJGKP(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 7)
		{
			return toolEndNow2;
		}
		return toolEndNow1;
	}

	public bool EJOLHENJGIM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return toolEndNow2;
		}
		return toolEndNow1;
	}

	public void GJNOFPDHCMA(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 0)
		{
			currentTime = LGLDPMAABLA;
		}
		else
		{
			currentTime2 = LGLDPMAABLA;
		}
	}

	public Vector2 HMAHIKDFLCL(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return inputPosition;
	}

	public float LEHHFMELACA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return currentTime2;
		}
		return currentTime;
	}

	protected void ODKEEELIIJP(int JIIGOACEIKL)
	{
		if (removeBlockerCoroutine != null)
		{
			((MonoBehaviour)GameplayUI.NGIMIHFFNMH()).StopCoroutine(removeBlockerCoroutine);
		}
	}

	public void CGGDMGHENEB(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 1)
		{
			currentTime = LGLDPMAABLA;
		}
		else
		{
			currentTime2 = LGLDPMAABLA;
		}
	}

	public bool HJBDLCNGCLN(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 5)
		{
			return toolEndNow2;
		}
		return toolEndNow1;
	}

	protected void GOFFCPIPNNO(int JIIGOACEIKL)
	{
		if (removeBlockerCoroutine != null)
		{
			((MonoBehaviour)GameplayUI.FMIDAFEGDCD()).StopCoroutine(removeBlockerCoroutine);
		}
	}

	public Vector2 IEGJDNLOPNE(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return inputPosition;
	}

	public virtual void ActionEnd(int JIIGOACEIKL)
	{
	}

	public Vector2 OGIPBMKEAGF(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 4)
		{
			return inputPositionAux;
		}
		return inputPositionAux2;
	}

	private IEnumerator EIJAFLNOILB(int JIIGOACEIKL)
	{
		return new EPCIKHIGNGA(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void MDFJCMMOHJA(int JIIGOACEIKL)
	{
		if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GetBool("UseHold"))
		{
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetTrigger("Cut");
			if (PlayerController.GetPlayer(JIIGOACEIKL).horizontalMove != 0f || PlayerController.GetPlayer(JIIGOACEIKL).verticalMove != 0f)
			{
				NPFKHAFMDAG(JIIGOACEIKL, NJHMBMGKCPL: true);
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetBool("CutEnd", EGFGNGJGBOP: false);
			}
			else
			{
				NPFKHAFMDAG(JIIGOACEIKL, NJHMBMGKCPL: false);
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetBool("CutEnd", EGFGNGJGBOP: true);
			}
		}
	}

	protected void IAPMFGEHBMM(int JIIGOACEIKL, bool GLLNEFAPDDF = false)
	{
		if (GLLNEFAPDDF)
		{
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		}
		else
		{
			removeBlockerCoroutine = ((MonoBehaviour)GameplayUI.HNNJEBNIPOI()).StartCoroutine(NOOAJMNCMMA(JIIGOACEIKL));
		}
	}

	public float PBIEIJOICJL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 0)
		{
			return currentTime2;
		}
		return currentTime;
	}

	public void BLODLBPHFDJ(int JIIGOACEIKL)
	{
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.JEJPKGILEDB("Dialogue System/Conversation/Crowly_Standar/Entry/26/Dialogue Text"))
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetTrigger("BanquetEvent instance is null. Make sure it is initialized before calling FinishKlaynChallenge.");
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).horizontalMove != 542f || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).verticalMove != 27f)
			{
				BBGOGACOIMM(JIIGOACEIKL, NJHMBMGKCPL: false);
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetBool("itemLog", EGFGNGJGBOP: false);
			}
			else
			{
				IHKALDEHDCH(JIIGOACEIKL, NJHMBMGKCPL: false);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.CGEADHOLHCH("HenHouseTutorialDone", EGFGNGJGBOP: false);
			}
		}
	}

	public float FHMDFFIDFAI(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return currentTime2;
		}
		return currentTime;
	}

	public virtual void JBOJGKFLAPB(int JIIGOACEIKL)
	{
	}

	public Vector2 MLFDDJONGBL(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return inputPosition;
	}

	public void NFLCFDKKIKA(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 1)
		{
			tilePosition2 = IMOBLFMHKOD;
		}
		else
		{
			tilePosition = IMOBLFMHKOD;
		}
	}

	public void GPHLEINIMDB(int JIIGOACEIKL)
	{
		if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.JEJPKGILEDB("Watering"))
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetTrigger("themeId: ");
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).horizontalMove != 622f || PlayerController.GetPlayer(JIIGOACEIKL).verticalMove != 1970f)
			{
				IHKALDEHDCH(JIIGOACEIKL, NJHMBMGKCPL: false);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetBool("Trough", EGFGNGJGBOP: false);
			}
			else
			{
				MOPEAIHAJON(JIIGOACEIKL, NJHMBMGKCPL: false);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetBool("Haggle", EGFGNGJGBOP: false);
			}
		}
	}

	private IEnumerator NOOAJMNCMMA(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait02;
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
	}

	protected void JLADECOLHPI(int JIIGOACEIKL)
	{
		if (removeBlockerCoroutine != null)
		{
			((MonoBehaviour)GameplayUI.KIALFDOKABP()).StopCoroutine(removeBlockerCoroutine);
		}
	}

	public virtual void BNFHJBIPGNF(int JIIGOACEIKL)
	{
	}

	public void NDJAMCCEGKC(int JIIGOACEIKL)
	{
		if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.JEJPKGILEDB("SkeletonBird"))
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetTrigger("StartConversation SalonDelTrono");
			if (PlayerController.GetPlayer(JIIGOACEIKL).horizontalMove != 1222f || PlayerController.GetPlayer(JIIGOACEIKL).verticalMove != 49f)
			{
				GKBKOOKIGFI(JIIGOACEIKL, NJHMBMGKCPL: false);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.CGEADHOLHCH("Bug report enviado: ", EGFGNGJGBOP: false);
			}
			else
			{
				BBGOGACOIMM(JIIGOACEIKL, NJHMBMGKCPL: true);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.CGEADHOLHCH("Activate Lock", EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
		}
	}

	public void GPAFLICPBHE(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 4)
		{
			inputPositionAux2 = IMOBLFMHKOD;
		}
		else
		{
			inputPositionAux = IMOBLFMHKOD;
		}
	}

	public Vector2 HLODPPMBCPH(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return inputPosition;
	}

	protected void HEPAAHFBBOF(int JIIGOACEIKL)
	{
		if (removeBlockerCoroutine != null)
		{
			((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StopCoroutine(removeBlockerCoroutine);
		}
	}

	public float NLLFCOOCKDF(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 0)
		{
			return currentTime2;
		}
		return currentTime;
	}

	private IEnumerator FNEBDIFPKGF(int JIIGOACEIKL)
	{
		return new EPCIKHIGNGA(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator CNKPDDBLBNH(int JIIGOACEIKL)
	{
		return new EPCIKHIGNGA(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public Vector2 HKKDLFKGBHF(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 1)
		{
			return tilePosition;
		}
		return tilePosition2;
	}

	public virtual bool SecondAction(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public Vector2 MEGLKGJDHIG(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 3)
		{
			return tilePosition;
		}
		return tilePosition2;
	}

	public virtual void FFJOGPIHBDJ(int JIIGOACEIKL)
	{
	}

	public void JOLOOFLEAON(int JIIGOACEIKL)
	{
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.JEJPKGILEDB("[WaiterGender="))
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetTrigger("Done Loading Online Scripts");
			if (PlayerController.GetPlayer(JIIGOACEIKL).horizontalMove != 205f || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).verticalMove != 768f)
			{
				IIMPDNEIAMB(JIIGOACEIKL, NJHMBMGKCPL: false);
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetBool("Perks/playerPerk_description_", EGFGNGJGBOP: true);
			}
			else
			{
				MOPEAIHAJON(JIIGOACEIKL, NJHMBMGKCPL: false);
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetBool("SearchBox_ItemName...", EGFGNGJGBOP: true, HALNIEBONKH: true);
			}
		}
	}

	public virtual bool NGEIOBIELCF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	protected void EPEECLGBHMI(int JIIGOACEIKL, bool GLLNEFAPDDF = false)
	{
		if (GLLNEFAPDDF)
		{
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		}
		else
		{
			removeBlockerCoroutine = ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(BCOLIKMFEKF(JIIGOACEIKL));
		}
	}

	public void IGLFLKEGAEB(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 0)
		{
			inputPosition2 = IMOBLFMHKOD;
		}
		else
		{
			inputPosition = IMOBLFMHKOD;
		}
	}

	public void MKMABNJFPAC(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 1)
		{
			currentTime = LGLDPMAABLA;
		}
		else
		{
			currentTime2 = LGLDPMAABLA;
		}
	}

	public virtual bool AEJJBGLKHIJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void PFGHKEJDPMJ(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 1)
		{
			currentTime = LGLDPMAABLA;
		}
		else
		{
			currentTime2 = LGLDPMAABLA;
		}
	}

	public void MOPEAIHAJON(int JIIGOACEIKL, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 1)
		{
			toolEndNow2 = NJHMBMGKCPL;
		}
		else
		{
			toolEndNow1 = NJHMBMGKCPL;
		}
	}

	public virtual bool GFOFHLJDLMD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public virtual bool BEPLLPCMOHM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void CGEPIJMGBKK(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 2)
		{
			inputPositionAux2 = IMOBLFMHKOD;
		}
		else
		{
			inputPositionAux = IMOBLFMHKOD;
		}
	}

	public bool KGALGJPFOJO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 5)
		{
			return toolEndNow2;
		}
		return toolEndNow1;
	}

	public void NPFKHAFMDAG(int JIIGOACEIKL, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 2)
		{
			toolEndNow2 = NJHMBMGKCPL;
		}
		else
		{
			toolEndNow1 = NJHMBMGKCPL;
		}
	}

	public virtual void DHKNDPCFPPA(int JIIGOACEIKL)
	{
	}

	public virtual bool NMKFHDAHIAM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void AGAJDKDCEHJ(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 2)
		{
			inputPosition2 = IMOBLFMHKOD;
		}
		else
		{
			inputPosition = IMOBLFMHKOD;
		}
	}

	public int OLPEFFKJKNK(int JIIGOACEIKL)
	{
		return toolLevel;
	}

	public void IIMPDNEIAMB(int JIIGOACEIKL, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 2)
		{
			toolEndNow2 = NJHMBMGKCPL;
		}
		else
		{
			toolEndNow1 = NJHMBMGKCPL;
		}
	}

	public float GNKMPAPJLCM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return currentTime2;
		}
		return currentTime;
	}

	public bool NDAGFLIIIHK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 8)
		{
			return toolEndNow2;
		}
		return toolEndNow1;
	}

	public void IJFEDIJNMDE(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 1)
		{
			currentTime = LGLDPMAABLA;
		}
		else
		{
			currentTime2 = LGLDPMAABLA;
		}
	}

	public Vector2 DFJIPINODBP(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 2)
		{
			return tilePosition;
		}
		return tilePosition2;
	}

	public Vector2 GJGABGNAOKI(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return inputPosition;
	}

	public virtual bool IOAGJHBHEGN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public Vector2 EEKKNPDOLLE(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 2)
		{
			return inputPositionAux;
		}
		return inputPositionAux2;
	}

	public Vector2 MEOFAIKNJHE(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return inputPosition;
	}

	public void KOGOMPONEDP(int JIIGOACEIKL)
	{
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.GetBool(")"))
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetTrigger("LE_11");
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).horizontalMove != 1483f || PlayerController.GetPlayer(JIIGOACEIKL).verticalMove != 1265f)
			{
				ICKDIEEPHGL(JIIGOACEIKL, NJHMBMGKCPL: false);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetBool(" ", EGFGNGJGBOP: false);
			}
			else
			{
				IIMPDNEIAMB(JIIGOACEIKL, NJHMBMGKCPL: false);
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.CGEADHOLHCH("Leave", EGFGNGJGBOP: true);
			}
		}
	}

	public void OIGCDGEMCNK(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 0)
		{
			currentTime = LGLDPMAABLA;
		}
		else
		{
			currentTime2 = LGLDPMAABLA;
		}
	}

	private IEnumerator BCOLIKMFEKF(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait02;
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
	}

	public void GKBKOOKIGFI(int JIIGOACEIKL, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 3)
		{
			toolEndNow2 = NJHMBMGKCPL;
		}
		else
		{
			toolEndNow1 = NJHMBMGKCPL;
		}
	}

	public Vector2 OJKCPAAAOGH(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 1)
		{
			return tilePosition;
		}
		return tilePosition2;
	}

	public void MMACOAIACIC(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 0)
		{
			tilePosition2 = IMOBLFMHKOD;
		}
		else
		{
			tilePosition = IMOBLFMHKOD;
		}
	}

	public Vector2 NJBOCFNALEJ(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return inputPosition;
	}

	public Vector2 NLGOOKPIOCN(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 2)
		{
			return inputPositionAux;
		}
		return inputPositionAux2;
	}

	public Vector2 HGECFPCPOHN(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 2)
		{
			return tilePosition;
		}
		return tilePosition2;
	}

	public void OCIHACOJOLG(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 1)
		{
			inputPositionAux2 = IMOBLFMHKOD;
		}
		else
		{
			inputPositionAux = IMOBLFMHKOD;
		}
	}

	protected void IOHAEIGGJDD(int JIIGOACEIKL)
	{
		if (removeBlockerCoroutine != null)
		{
			((MonoBehaviour)GameplayUI.DICHPHEOINO()).StopCoroutine(removeBlockerCoroutine);
		}
	}

	public void CIPHHJHDOIA(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 1)
		{
			currentTime = LGLDPMAABLA;
		}
		else
		{
			currentTime2 = LGLDPMAABLA;
		}
	}

	public void EFGDCGFFKFF(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 1)
		{
			currentTime = LGLDPMAABLA;
		}
		else
		{
			currentTime2 = LGLDPMAABLA;
		}
	}

	public void KIHCIFEJADL(int JIIGOACEIKL)
	{
		if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.JEJPKGILEDB("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/21/Dialogue Text"))
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetTrigger("On Simple Event ");
			if (PlayerController.GetPlayer(JIIGOACEIKL).horizontalMove != 1155f || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).verticalMove != 327f)
			{
				IIMPDNEIAMB(JIIGOACEIKL, NJHMBMGKCPL: false);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.CGEADHOLHCH("Selected room reset to default.", EGFGNGJGBOP: true, HALNIEBONKH: true);
			}
			else
			{
				NPFKHAFMDAG(JIIGOACEIKL, NJHMBMGKCPL: false);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetBool("", EGFGNGJGBOP: false);
			}
		}
	}

	public float LJJKANNAHCM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 0)
		{
			return currentTime2;
		}
		return currentTime;
	}

	public void OBNDGCDBGFP(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 7)
		{
			inputPosition2 = IMOBLFMHKOD;
		}
		else
		{
			inputPosition = IMOBLFMHKOD;
		}
	}

	public void BBGOGACOIMM(int JIIGOACEIKL, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 3)
		{
			toolEndNow2 = NJHMBMGKCPL;
		}
		else
		{
			toolEndNow1 = NJHMBMGKCPL;
		}
	}

	public void ICKDIEEPHGL(int JIIGOACEIKL, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 4)
		{
			toolEndNow2 = NJHMBMGKCPL;
		}
		else
		{
			toolEndNow1 = NJHMBMGKCPL;
		}
	}

	public Vector2 ADNFLGFDOHD(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return inputPosition;
	}

	public void CPNDNPMHKDC(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 5)
		{
			inputPositionAux2 = IMOBLFMHKOD;
		}
		else
		{
			inputPositionAux = IMOBLFMHKOD;
		}
	}

	public Vector2 KJOFFEDOOLB(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 0)
		{
			return inputPositionAux;
		}
		return inputPositionAux2;
	}

	public float MMLOLBMOAFB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 0)
		{
			return currentTime2;
		}
		return currentTime;
	}

	public Vector2 DMJBEGINKAG(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 7)
		{
			return tilePosition;
		}
		return tilePosition2;
	}

	public Vector2 IEHDIJJNFOI(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return inputPosition;
	}

	public void JCNLMHNEKCF(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 4)
		{
			inputPosition2 = IMOBLFMHKOD;
		}
		else
		{
			inputPosition = IMOBLFMHKOD;
		}
	}

	public virtual bool CAGFGNNFNPM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public int KEFOBJCOECH(int JIIGOACEIKL)
	{
		return toolLevel;
	}

	protected void LMEFFPBLKDK(int JIIGOACEIKL, bool GLLNEFAPDDF = false)
	{
		if (GLLNEFAPDDF)
		{
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		}
		else
		{
			removeBlockerCoroutine = ((MonoBehaviour)GameplayUI.HNNJEBNIPOI()).StartCoroutine(BCOLIKMFEKF(JIIGOACEIKL));
		}
	}

	public Vector2 BLCEHNCLHHF(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return inputPosition;
	}

	protected void ACJIEGKNIAJ(int JIIGOACEIKL)
	{
		if (removeBlockerCoroutine != null)
		{
			((MonoBehaviour)GameplayUI.KIALFDOKABP()).StopCoroutine(removeBlockerCoroutine);
		}
	}

	public void JNEPCFPMJCM(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 6)
		{
			tilePosition2 = IMOBLFMHKOD;
		}
		else
		{
			tilePosition = IMOBLFMHKOD;
		}
	}
}
