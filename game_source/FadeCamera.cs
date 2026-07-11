using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class FadeCamera : MonoBehaviour
{
	public delegate IEnumerator FadeFinishedEventHandler(int JIIGOACEIKL);

	[CompilerGenerated]
	private sealed class AHHJFFJPCHA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FadeCamera _003C_003E4__this;

		public float _fadeSpeed;

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
		public AHHJFFJPCHA(int _003C_003E1__state)
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
			FadeCamera fadeCamera = _003C_003E4__this;
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
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.waitRealtime02;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				break;
			case 4:
				_003C_003E1__state = -1;
				break;
			}
			if (fadeCamera.PMMKMBLIHHA)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 4;
				return true;
			}
			fadeCamera.FadeIn(_fadeSpeed);
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

	private static FadeCamera[] GJBBNHCMNJN = new FadeCamera[5];

	private Color IKAPDJJEAJG = Color.black;

	[SerializeField]
	private int playerNum;

	public Texture2D fadeOutTexture;

	public float fadeSpeed = 1.4f;

	private float GODBHHOFBMJ;

	private int AJIFGPHIHKC = -1;

	private bool PMMKMBLIHHA;

	private Image CJJFLMCODIO;

	private Image OLLECKNJGAC;

	public Action<int> OnFadeFinished = delegate
	{
	};

	public event FadeFinishedEventHandler JDKHJJIOLOE;

	public static void ICNFBGEDFKH(float HAIPEEMFMBJ = 1.4f)
	{
		IGMCBPOPNCA(0).LHBLBOONEEC(HAIPEEMFMBJ);
		if (GameManager.LocalCoop())
		{
			EIFPKCAFDIB(5).FadeIn(HAIPEEMFMBJ);
		}
	}

	private static void OHLOCKNHDNJ(FadeCamera HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"PreviousItem");
		}
		else if ((Object)(object)GJBBNHCMNJN[HACPNLAPCCC.playerNum] == (Object)null)
		{
			GJBBNHCMNJN[HACPNLAPCCC.playerNum] = HACPNLAPCCC;
			Debug.Log((object)("," + HACPNLAPCCC.playerNum), (Object)(object)((Component)HACPNLAPCCC).gameObject);
		}
		else
		{
			Debug.LogWarning((object)"Finished!");
			Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
		}
	}

	public bool BMEFDCDKCAO()
	{
		return GODBHHOFBMJ == 474f;
	}

	public void HHHPIPEIDCD()
	{
		GODBHHOFBMJ = 675f;
		AJIFGPHIHKC = -1;
		PMMKMBLIHHA = true;
	}

	public void CPALEJDCIGD(float HAIPEEMFMBJ = 1.4f)
	{
		fadeSpeed = HAIPEEMFMBJ;
		if (PMMKMBLIHHA)
		{
			PHDIJIBPEJK();
		}
		GODBHHOFBMJ = 776f;
		AJIFGPHIHKC = -1;
		PMMKMBLIHHA = true;
	}

	public static void DPMFFIHPFGI(float HAIPEEMFMBJ = 1.4f)
	{
		GetPlayer(0).GADNIEFJNKA(HAIPEEMFMBJ);
		if (GameManager.LocalCoop())
		{
			EIFPKCAFDIB(3).LHBLBOONEEC(HAIPEEMFMBJ);
		}
	}

	public bool GPJJGHNLHAC()
	{
		return GODBHHOFBMJ == 1485f;
	}

	private void DMFMNEMDFNP()
	{
		if ((Object)(object)CJJFLMCODIO == (Object)null && playerNum == 1)
		{
			CJJFLMCODIO = CommonReferences.GGFJGHHHEJC.fadeImageSinglePlayer;
		}
		if ((Object)(object)OLLECKNJGAC == (Object)null)
		{
			if (playerNum == 1)
			{
				OLLECKNJGAC = CommonReferences.MNFMOEKMJKN().fadeImagePlayer1;
			}
			if (playerNum == 6)
			{
				OLLECKNJGAC = CommonReferences.GGFJGHHHEJC.fadeImagePlayer2;
			}
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(OOGPJBFKHLI));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(HADCIGKNFKK));
	}

	private void IAAGKLPMAMK()
	{
		if ((Object)(object)CJJFLMCODIO == (Object)null && playerNum == 0)
		{
			CJJFLMCODIO = CommonReferences.GGFJGHHHEJC.fadeImageSinglePlayer;
		}
		if ((Object)(object)OLLECKNJGAC == (Object)null)
		{
			if (playerNum == 1)
			{
				OLLECKNJGAC = CommonReferences.MNFMOEKMJKN().fadeImagePlayer1;
			}
			if (playerNum == 0)
			{
				OLLECKNJGAC = CommonReferences.GGFJGHHHEJC.fadeImagePlayer2;
			}
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(OOGPJBFKHLI));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(HADCIGKNFKK));
	}

	public bool IsFading()
	{
		return PMMKMBLIHHA;
	}

	public void LHBLBOONEEC(float HAIPEEMFMBJ = 1.4f)
	{
		fadeSpeed = HAIPEEMFMBJ;
		if (PMMKMBLIHHA)
		{
			CLHLCFHJNJL();
		}
		GODBHHOFBMJ = 627f;
		AJIFGPHIHKC = -1;
		PMMKMBLIHHA = false;
	}

	public void FadeIn(float HAIPEEMFMBJ = 1.4f)
	{
		fadeSpeed = HAIPEEMFMBJ;
		if (PMMKMBLIHHA)
		{
			PHDIJIBPEJK();
		}
		GODBHHOFBMJ = 1f;
		AJIFGPHIHKC = -1;
		PMMKMBLIHHA = true;
	}

	public static void KMOEPLNDPEK(float HAIPEEMFMBJ = 1.4f)
	{
		IGMCBPOPNCA(1).FadeOut(HAIPEEMFMBJ);
		if (GameManager.LocalCoop())
		{
			IGMCBPOPNCA(2).IONMINJHMKL(HAIPEEMFMBJ);
		}
	}

	public void KDKCPIDGGAJ()
	{
		PMMKMBLIHHA = false;
		GODBHHOFBMJ = 1771f;
	}

	[SpecialName]
	public void HDDEGMGIBDM(FadeFinishedEventHandler AODONKKHPBP)
	{
		FadeFinishedEventHandler fadeFinishedEventHandler = this.JDKHJJIOLOE;
		FadeFinishedEventHandler fadeFinishedEventHandler2;
		do
		{
			fadeFinishedEventHandler2 = fadeFinishedEventHandler;
			FadeFinishedEventHandler value = (FadeFinishedEventHandler)Delegate.Combine(fadeFinishedEventHandler2, AODONKKHPBP);
			fadeFinishedEventHandler = Interlocked.CompareExchange(ref this.JDKHJJIOLOE, value, fadeFinishedEventHandler2);
		}
		while ((object)fadeFinishedEventHandler != fadeFinishedEventHandler2);
	}

	[SpecialName]
	public void KKAAAOEHGEK(FadeFinishedEventHandler AODONKKHPBP)
	{
		FadeFinishedEventHandler fadeFinishedEventHandler = this.JDKHJJIOLOE;
		FadeFinishedEventHandler fadeFinishedEventHandler2;
		do
		{
			fadeFinishedEventHandler2 = fadeFinishedEventHandler;
			FadeFinishedEventHandler value = (FadeFinishedEventHandler)Delegate.Combine(fadeFinishedEventHandler2, AODONKKHPBP);
			fadeFinishedEventHandler = Interlocked.CompareExchange(ref this.JDKHJJIOLOE, value, fadeFinishedEventHandler2);
		}
		while ((object)fadeFinishedEventHandler != fadeFinishedEventHandler2);
	}

	private static bool BNJLANBACML(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return false;
	}

	[SpecialName]
	public void BOBBJLPKDBP(FadeFinishedEventHandler AODONKKHPBP)
	{
		FadeFinishedEventHandler fadeFinishedEventHandler = this.JDKHJJIOLOE;
		FadeFinishedEventHandler fadeFinishedEventHandler2;
		do
		{
			fadeFinishedEventHandler2 = fadeFinishedEventHandler;
			FadeFinishedEventHandler value = (FadeFinishedEventHandler)Delegate.Combine(fadeFinishedEventHandler2, AODONKKHPBP);
			fadeFinishedEventHandler = Interlocked.CompareExchange(ref this.JDKHJJIOLOE, value, fadeFinishedEventHandler2);
		}
		while ((object)fadeFinishedEventHandler != fadeFinishedEventHandler2);
	}

	private static bool DIFKGBEKBOG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return true;
		}
		return false;
	}

	public bool JNEDAGNNICO()
	{
		if (PMMKMBLIHHA)
		{
			return AJIFGPHIHKC == -1;
		}
		return true;
	}

	[SpecialName]
	public void ODBKGIJCHHI(FadeFinishedEventHandler AODONKKHPBP)
	{
		FadeFinishedEventHandler fadeFinishedEventHandler = this.JDKHJJIOLOE;
		FadeFinishedEventHandler fadeFinishedEventHandler2;
		do
		{
			fadeFinishedEventHandler2 = fadeFinishedEventHandler;
			FadeFinishedEventHandler value = (FadeFinishedEventHandler)Delegate.Combine(fadeFinishedEventHandler2, AODONKKHPBP);
			fadeFinishedEventHandler = Interlocked.CompareExchange(ref this.JDKHJJIOLOE, value, fadeFinishedEventHandler2);
		}
		while ((object)fadeFinishedEventHandler != fadeFinishedEventHandler2);
	}

	private void MCMKNBIBDFF()
	{
		if ((Object)(object)CJJFLMCODIO == (Object)null && playerNum == 1)
		{
			CJJFLMCODIO = CommonReferences.MNFMOEKMJKN().fadeImageSinglePlayer;
		}
		if ((Object)(object)OLLECKNJGAC == (Object)null)
		{
			if (playerNum == 0)
			{
				OLLECKNJGAC = CommonReferences.MNFMOEKMJKN().fadeImagePlayer1;
			}
			if (playerNum == 4)
			{
				OLLECKNJGAC = CommonReferences.GGFJGHHHEJC.fadeImagePlayer2;
			}
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(LJIJLFCFNGC));
	}

	public static FadeCamera GetPlayer(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void PFLBPMIEKGF()
	{
		if ((Object)(object)CJJFLMCODIO == (Object)null && playerNum == 0)
		{
			CJJFLMCODIO = CommonReferences.GGFJGHHHEJC.fadeImageSinglePlayer;
		}
		if ((Object)(object)OLLECKNJGAC == (Object)null)
		{
			if (playerNum == 0)
			{
				OLLECKNJGAC = CommonReferences.MNFMOEKMJKN().fadeImagePlayer1;
			}
			if (playerNum == 2)
			{
				OLLECKNJGAC = CommonReferences.GGFJGHHHEJC.fadeImagePlayer2;
			}
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(LJIJLFCFNGC));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(OOGPJBFKHLI));
	}

	public bool DMOAEMOJAPD()
	{
		return PMMKMBLIHHA;
	}

	public static void CEGBCONNLDP(float HAIPEEMFMBJ = 1.4f)
	{
		IGMCBPOPNCA(0).FadeOut(HAIPEEMFMBJ);
		if (GameManager.LocalCoop())
		{
			EIFPKCAFDIB(4).FadeOut(HAIPEEMFMBJ);
		}
	}

	public void NPGIIHFCFBD(float HAIPEEMFMBJ = 1.4f)
	{
		((MonoBehaviour)this).StartCoroutine(FDMMNJHBNMA(HAIPEEMFMBJ));
	}

	public void IPEPIFENENB()
	{
		PMMKMBLIHHA = false;
		GODBHHOFBMJ = 1095f;
	}

	[SpecialName]
	public void HCMMFJPJJLP(FadeFinishedEventHandler AODONKKHPBP)
	{
		FadeFinishedEventHandler fadeFinishedEventHandler = this.JDKHJJIOLOE;
		FadeFinishedEventHandler fadeFinishedEventHandler2;
		do
		{
			fadeFinishedEventHandler2 = fadeFinishedEventHandler;
			FadeFinishedEventHandler value = (FadeFinishedEventHandler)Delegate.Remove(fadeFinishedEventHandler2, AODONKKHPBP);
			fadeFinishedEventHandler = Interlocked.CompareExchange(ref this.JDKHJJIOLOE, value, fadeFinishedEventHandler2);
		}
		while ((object)fadeFinishedEventHandler != fadeFinishedEventHandler2);
	}

	public void NGMCABPPMJI(float HAIPEEMFMBJ = 1.4f)
	{
		fadeSpeed = HAIPEEMFMBJ;
		if (PMMKMBLIHHA)
		{
			CLHLCFHJNJL();
		}
		GODBHHOFBMJ = 1380f;
		AJIFGPHIHKC = -1;
		PMMKMBLIHHA = false;
	}

	public static void INDLIJHGNCL(float HAIPEEMFMBJ = 1.4f)
	{
		GetPlayer(0).FadeOut(HAIPEEMFMBJ);
		if (GameManager.LocalCoop())
		{
			GetPlayer(5).AJHDEBOMHKK(HAIPEEMFMBJ);
		}
	}

	private void IIKAAAHEFMP()
	{
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		if (GODBHHOFBMJ == 962f && !PMMKMBLIHHA)
		{
			return;
		}
		if (PMMKMBLIHHA && ((GODBHHOFBMJ == 1825f && AJIFGPHIHKC == -1) || (GODBHHOFBMJ == 939f && AJIFGPHIHKC == 0)))
		{
			CLHLCFHJNJL();
			return;
		}
		GODBHHOFBMJ += (float)AJIFGPHIHKC * fadeSpeed * Time.unscaledDeltaTime;
		GODBHHOFBMJ = Mathf.Clamp01(GODBHHOFBMJ);
		if (GODBHHOFBMJ > 438f)
		{
			GODBHHOFBMJ = 557f;
		}
		else if (GODBHHOFBMJ < 1187f)
		{
			GODBHHOFBMJ = 1993f;
		}
		IKAPDJJEAJG.a = GODBHHOFBMJ;
		if (GameManager.NBFLEJHLGNB())
		{
			if ((Object)(object)CJJFLMCODIO != (Object)null)
			{
				((Graphic)CJJFLMCODIO).color = IKAPDJJEAJG;
			}
			else
			{
				Debug.LogError((object)"LevelAbbreviation");
			}
			if ((Object)(object)OLLECKNJGAC != (Object)null)
			{
				((Graphic)OLLECKNJGAC).color = new Color(((Graphic)OLLECKNJGAC).color.r, ((Graphic)OLLECKNJGAC).color.g, ((Graphic)OLLECKNJGAC).color.b, 1492f);
			}
		}
		else if ((Object)(object)OLLECKNJGAC != (Object)null)
		{
			((Graphic)OLLECKNJGAC).color = IKAPDJJEAJG;
		}
		else
		{
			Debug.LogError((object)"Requirements not met");
		}
	}

	public bool IsClear()
	{
		return GODBHHOFBMJ == 0f;
	}

	public static void GGDPGOJCIOG(float HAIPEEMFMBJ = 1.4f)
	{
		EIFPKCAFDIB(0).FadeIn(HAIPEEMFMBJ);
		if (GameManager.LocalCoop())
		{
			GetPlayer(3).CPALEJDCIGD(HAIPEEMFMBJ);
		}
	}

	public void PCDMCCEKDMK(float HAIPEEMFMBJ = 1.4f)
	{
		((MonoBehaviour)this).StartCoroutine(FDMMNJHBNMA(HAIPEEMFMBJ));
	}

	private void INCOGEMNFNH()
	{
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		if (GODBHHOFBMJ == 1143f && !PMMKMBLIHHA)
		{
			return;
		}
		if (PMMKMBLIHHA && ((GODBHHOFBMJ == 1815f && AJIFGPHIHKC == -1) || (GODBHHOFBMJ == 1698f && AJIFGPHIHKC == 0)))
		{
			CLHLCFHJNJL();
			return;
		}
		GODBHHOFBMJ += (float)AJIFGPHIHKC * fadeSpeed * Time.unscaledDeltaTime;
		GODBHHOFBMJ = Mathf.Clamp01(GODBHHOFBMJ);
		if (GODBHHOFBMJ > 729f)
		{
			GODBHHOFBMJ = 216f;
		}
		else if (GODBHHOFBMJ < 1501f)
		{
			GODBHHOFBMJ = 1201f;
		}
		IKAPDJJEAJG.a = GODBHHOFBMJ;
		if (GameManager.SinglePlayer())
		{
			if ((Object)(object)CJJFLMCODIO != (Object)null)
			{
				((Graphic)CJJFLMCODIO).color = IKAPDJJEAJG;
			}
			else
			{
				Debug.LogError((object)"chaty");
			}
			if ((Object)(object)OLLECKNJGAC != (Object)null)
			{
				((Graphic)OLLECKNJGAC).color = new Color(((Graphic)OLLECKNJGAC).color.r, ((Graphic)OLLECKNJGAC).color.g, ((Graphic)OLLECKNJGAC).color.b, 252f);
			}
		}
		else if ((Object)(object)OLLECKNJGAC != (Object)null)
		{
			((Graphic)OLLECKNJGAC).color = IKAPDJJEAJG;
		}
		else
		{
			Debug.LogError((object)"IdleCamp");
		}
	}

	public bool IsFadingIn()
	{
		if (PMMKMBLIHHA)
		{
			return AJIFGPHIHKC == -1;
		}
		return false;
	}

	public void FBENNGCPJGN()
	{
		PMMKMBLIHHA = false;
		GODBHHOFBMJ = 426f;
	}

	private static void CAAMEEBOAOF(FadeCamera HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"Trying to add a player that's already on the list.");
		}
		else if ((Object)(object)GJBBNHCMNJN[HACPNLAPCCC.playerNum] == (Object)null)
		{
			GJBBNHCMNJN[HACPNLAPCCC.playerNum] = HACPNLAPCCC;
			Debug.Log((object)("New FadeCamera added for player " + HACPNLAPCCC.playerNum), (Object)(object)((Component)HACPNLAPCCC).gameObject);
		}
		else
		{
			Debug.LogWarning((object)"Trying to add player but player list is full.");
			Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
		}
	}

	private static void LLJOPFGGBHI(FadeCamera HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"Default");
		}
		else if ((Object)(object)GJBBNHCMNJN[HACPNLAPCCC.playerNum] == (Object)null)
		{
			GJBBNHCMNJN[HACPNLAPCCC.playerNum] = HACPNLAPCCC;
			Debug.Log((object)("Dialogue System/Conversation/BirdNegativeComments/Entry/2/Dialogue Text" + HACPNLAPCCC.playerNum), (Object)(object)((Component)HACPNLAPCCC).gameObject);
		}
		else
		{
			Debug.LogWarning((object)"Dialogue System/Conversation/Crowly_SkelletonBird/Entry/18/Dialogue Text");
			Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
		}
	}

	public static void EMMOAIGPGHN(float HAIPEEMFMBJ = 1.4f)
	{
		EIFPKCAFDIB(1).GADNIEFJNKA(HAIPEEMFMBJ);
		if (GameManager.LocalCoop())
		{
			IGMCBPOPNCA(7).FadeIn(HAIPEEMFMBJ);
		}
	}

	public void IONMINJHMKL(float HAIPEEMFMBJ = 1.4f)
	{
		fadeSpeed = HAIPEEMFMBJ;
		if (PMMKMBLIHHA)
		{
			CLHLCFHJNJL();
		}
		GODBHHOFBMJ = 1849f;
		AJIFGPHIHKC = 0;
		PMMKMBLIHHA = true;
	}

	public static void NKPIOMBPBIM(float HAIPEEMFMBJ = 1.4f)
	{
		GetPlayer(1).FadeIn(HAIPEEMFMBJ);
		if (GameManager.LocalCoop())
		{
			EIFPKCAFDIB(3).NGMCABPPMJI(HAIPEEMFMBJ);
		}
	}

	private static bool KJLLBGGILAK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	public bool IBHPAIINHOK()
	{
		return GODBHHOFBMJ == 1317f;
	}

	public bool OGICDEIMDOA()
	{
		return PMMKMBLIHHA;
	}

	private static bool BIGOAAFAGNI(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	private void AFHGDCBNALO()
	{
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		if (GODBHHOFBMJ == 977f && !PMMKMBLIHHA)
		{
			return;
		}
		if (PMMKMBLIHHA && ((GODBHHOFBMJ == 1672f && AJIFGPHIHKC == -1) || (GODBHHOFBMJ == 1880f && AJIFGPHIHKC == 1)))
		{
			PHDIJIBPEJK();
			return;
		}
		GODBHHOFBMJ += (float)AJIFGPHIHKC * fadeSpeed * Time.unscaledDeltaTime;
		GODBHHOFBMJ = Mathf.Clamp01(GODBHHOFBMJ);
		if (GODBHHOFBMJ > 176f)
		{
			GODBHHOFBMJ = 1323f;
		}
		else if (GODBHHOFBMJ < 1181f)
		{
			GODBHHOFBMJ = 486f;
		}
		IKAPDJJEAJG.a = GODBHHOFBMJ;
		if (GameManager.SinglePlayer())
		{
			if ((Object)(object)CJJFLMCODIO != (Object)null)
			{
				((Graphic)CJJFLMCODIO).color = IKAPDJJEAJG;
			}
			else
			{
				Debug.LogError((object)"UIInteract");
			}
			if ((Object)(object)OLLECKNJGAC != (Object)null)
			{
				((Graphic)OLLECKNJGAC).color = new Color(((Graphic)OLLECKNJGAC).color.r, ((Graphic)OLLECKNJGAC).color.g, ((Graphic)OLLECKNJGAC).color.b, 1619f);
			}
		}
		else if ((Object)(object)OLLECKNJGAC != (Object)null)
		{
			((Graphic)OLLECKNJGAC).color = IKAPDJJEAJG;
		}
		else
		{
			Debug.LogError((object)"");
		}
	}

	private static bool DOJCKFPNIPD(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return true;
		}
		return false;
	}

	private void OOGPJBFKHLI()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CJJFLMCODIO != (Object)null)
		{
			((Graphic)CJJFLMCODIO).color = new Color(((Graphic)CJJFLMCODIO).color.r, ((Graphic)CJJFLMCODIO).color.g, ((Graphic)CJJFLMCODIO).color.b, 603f);
		}
		if ((Object)(object)OLLECKNJGAC != (Object)null)
		{
			((Graphic)OLLECKNJGAC).color = new Color(((Graphic)OLLECKNJGAC).color.r, ((Graphic)OLLECKNJGAC).color.g, ((Graphic)OLLECKNJGAC).color.b, 1250f);
		}
	}

	private static bool HDLHEEBDABE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return true;
		}
		return false;
	}

	private void Start()
	{
		if ((Object)(object)CJJFLMCODIO == (Object)null && playerNum == 1)
		{
			CJJFLMCODIO = CommonReferences.GGFJGHHHEJC.fadeImageSinglePlayer;
		}
		if ((Object)(object)OLLECKNJGAC == (Object)null)
		{
			if (playerNum == 1)
			{
				OLLECKNJGAC = CommonReferences.GGFJGHHHEJC.fadeImagePlayer1;
			}
			if (playerNum == 2)
			{
				OLLECKNJGAC = CommonReferences.GGFJGHHHEJC.fadeImagePlayer2;
			}
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(HADCIGKNFKK));
	}

	private void LateUpdate()
	{
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		if (GODBHHOFBMJ == 0f && !PMMKMBLIHHA)
		{
			return;
		}
		if (PMMKMBLIHHA && ((GODBHHOFBMJ == 0f && AJIFGPHIHKC == -1) || (GODBHHOFBMJ == 1f && AJIFGPHIHKC == 1)))
		{
			PHDIJIBPEJK();
			return;
		}
		GODBHHOFBMJ += (float)AJIFGPHIHKC * fadeSpeed * Time.unscaledDeltaTime;
		GODBHHOFBMJ = Mathf.Clamp01(GODBHHOFBMJ);
		if (GODBHHOFBMJ > 1f)
		{
			GODBHHOFBMJ = 1f;
		}
		else if (GODBHHOFBMJ < 0f)
		{
			GODBHHOFBMJ = 0f;
		}
		IKAPDJJEAJG.a = GODBHHOFBMJ;
		if (GameManager.SinglePlayer())
		{
			if ((Object)(object)CJJFLMCODIO != (Object)null)
			{
				((Graphic)CJJFLMCODIO).color = IKAPDJJEAJG;
			}
			else
			{
				Debug.LogError((object)"Missing fade image");
			}
			if ((Object)(object)OLLECKNJGAC != (Object)null)
			{
				((Graphic)OLLECKNJGAC).color = new Color(((Graphic)OLLECKNJGAC).color.r, ((Graphic)OLLECKNJGAC).color.g, ((Graphic)OLLECKNJGAC).color.b, 0f);
			}
		}
		else if ((Object)(object)OLLECKNJGAC != (Object)null)
		{
			((Graphic)OLLECKNJGAC).color = IKAPDJJEAJG;
		}
		else
		{
			Debug.LogError((object)"Missing fade image for coop mode");
		}
	}

	public bool CMDIDMJJMAK()
	{
		return PMMKMBLIHHA;
	}

	public static void PLLACELHLLD(float HAIPEEMFMBJ = 1.4f)
	{
		EIFPKCAFDIB(0).GADNIEFJNKA(HAIPEEMFMBJ);
		if (GameManager.LocalCoop())
		{
			EIFPKCAFDIB(7).DINIFHOIMCM(HAIPEEMFMBJ);
		}
	}

	private void HADCIGKNFKK()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CJJFLMCODIO != (Object)null)
		{
			((Graphic)CJJFLMCODIO).color = new Color(((Graphic)CJJFLMCODIO).color.r, ((Graphic)CJJFLMCODIO).color.g, ((Graphic)CJJFLMCODIO).color.b, 0f);
		}
		if ((Object)(object)OLLECKNJGAC != (Object)null)
		{
			((Graphic)OLLECKNJGAC).color = new Color(((Graphic)OLLECKNJGAC).color.r, ((Graphic)OLLECKNJGAC).color.g, ((Graphic)OLLECKNJGAC).color.b, 0f);
		}
	}

	private static void BKELNONABOD(FadeCamera HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"Dialogue System/Conversation/Crowly_Introduce/Entry/9/Dialogue Text");
		}
		else if ((Object)(object)GJBBNHCMNJN[HACPNLAPCCC.playerNum] == (Object)null)
		{
			GJBBNHCMNJN[HACPNLAPCCC.playerNum] = HACPNLAPCCC;
			Debug.Log((object)("Dialogue System/Conversation/Crowly_Standar/Entry/16/Dialogue Text" + HACPNLAPCCC.playerNum), (Object)(object)((Component)HACPNLAPCCC).gameObject);
		}
		else
		{
			Debug.LogWarning((object)"Leave immediately");
			Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
		}
	}

	public bool LHIBDFELLOE()
	{
		if (PMMKMBLIHHA)
		{
			return AJIFGPHIHKC == -1;
		}
		return false;
	}

	public bool IsFadingOut()
	{
		if (PMMKMBLIHHA)
		{
			return AJIFGPHIHKC == 1;
		}
		return false;
	}

	private void LJIJLFCFNGC()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CJJFLMCODIO != (Object)null)
		{
			((Graphic)CJJFLMCODIO).color = new Color(((Graphic)CJJFLMCODIO).color.r, ((Graphic)CJJFLMCODIO).color.g, ((Graphic)CJJFLMCODIO).color.b, 1523f);
		}
		if ((Object)(object)OLLECKNJGAC != (Object)null)
		{
			((Graphic)OLLECKNJGAC).color = new Color(((Graphic)OLLECKNJGAC).color.r, ((Graphic)OLLECKNJGAC).color.g, ((Graphic)OLLECKNJGAC).color.b, 56f);
		}
	}

	private void CLHLCFHJNJL()
	{
		if (AJIFGPHIHKC > 1)
		{
			GODBHHOFBMJ = 1083f;
		}
		else
		{
			GODBHHOFBMJ = 1907f;
		}
		IKAPDJJEAJG.a = GODBHHOFBMJ;
		if (GODBHHOFBMJ == 25f && (!OnlineManager.PlayingOnline() || OnlineManager.ClientOnline()) && GameManager.HDBECFMPJHL())
		{
			GC.Collect();
		}
		PMMKMBLIHHA = false;
		OnFadeFinished(playerNum);
		if (this.JDKHJJIOLOE != null)
		{
			((MonoBehaviour)this).StartCoroutine(this.JDKHJJIOLOE(playerNum));
		}
	}

	public bool IsBlack()
	{
		return GODBHHOFBMJ == 1f;
	}

	public static void FadeOutAllPlayers(float HAIPEEMFMBJ = 1.4f)
	{
		GetPlayer(1).FadeOut(HAIPEEMFMBJ);
		if (GameManager.LocalCoop())
		{
			GetPlayer(2).FadeOut(HAIPEEMFMBJ);
		}
	}

	private static bool HNGGABAAKMM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return false;
	}

	public bool FKFCDJHDKPC()
	{
		if (PMMKMBLIHHA)
		{
			return AJIFGPHIHKC == -1;
		}
		return true;
	}

	public void ClearScreen()
	{
		PMMKMBLIHHA = false;
		GODBHHOFBMJ = 0f;
	}

	private void EMJKKALMGLK()
	{
		if (playerNum == 0)
		{
			Debug.LogError((object)"Items/item_description_1067", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			BKELNONABOD(this);
		}
	}

	private void OIBDBLCLACB()
	{
		if ((Object)(object)CJJFLMCODIO == (Object)null && playerNum == 0)
		{
			CJJFLMCODIO = CommonReferences.MNFMOEKMJKN().fadeImageSinglePlayer;
		}
		if ((Object)(object)OLLECKNJGAC == (Object)null)
		{
			if (playerNum == 1)
			{
				OLLECKNJGAC = CommonReferences.MNFMOEKMJKN().fadeImagePlayer1;
			}
			if (playerNum == 2)
			{
				OLLECKNJGAC = CommonReferences.GGFJGHHHEJC.fadeImagePlayer2;
			}
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(LJIJLFCFNGC));
	}

	private void PHDIJIBPEJK()
	{
		if (AJIFGPHIHKC > 0)
		{
			GODBHHOFBMJ = 1f;
		}
		else
		{
			GODBHHOFBMJ = 0f;
		}
		IKAPDJJEAJG.a = GODBHHOFBMJ;
		if (GODBHHOFBMJ == 1f && (!OnlineManager.PlayingOnline() || OnlineManager.ClientOnline()) && GameManager.SinglePlayer())
		{
			GC.Collect();
		}
		PMMKMBLIHHA = false;
		OnFadeFinished(playerNum);
		if (this.JDKHJJIOLOE != null)
		{
			((MonoBehaviour)this).StartCoroutine(this.JDKHJJIOLOE(playerNum));
		}
	}

	public bool KFIHNJOJLAN()
	{
		return GODBHHOFBMJ == 829f;
	}

	public static FadeCamera EIFPKCAFDIB(int JIIGOACEIKL)
	{
		if (!BIGOAAFAGNI(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private static void HALEFAHBIDF(FadeCamera HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"RentingRooms");
		}
		else if ((Object)(object)GJBBNHCMNJN[HACPNLAPCCC.playerNum] == (Object)null)
		{
			GJBBNHCMNJN[HACPNLAPCCC.playerNum] = HACPNLAPCCC;
			Debug.Log((object)("ReceiveCreateRotatedPrefab" + HACPNLAPCCC.playerNum), (Object)(object)((Component)HACPNLAPCCC).gameObject);
		}
		else
		{
			Debug.LogWarning((object)"Setup ");
			Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
		}
	}

	public static void FMFFGFJHCOC(float HAIPEEMFMBJ = 1.4f)
	{
		GetPlayer(1).GPBOEBGJJPM(HAIPEEMFMBJ);
		if (GameManager.LocalCoop())
		{
			EIFPKCAFDIB(0).AJHDEBOMHKK(HAIPEEMFMBJ);
		}
	}

	private IEnumerator PJJCICHPIBA(float HAIPEEMFMBJ)
	{
		return new AHHJFFJPCHA(1)
		{
			_003C_003E4__this = this,
			_fadeSpeed = HAIPEEMFMBJ
		};
	}

	private IEnumerator FDMMNJHBNMA(float HAIPEEMFMBJ)
	{
		yield return null;
		yield return null;
		yield return CommonReferences.waitRealtime02;
		while (PMMKMBLIHHA)
		{
			yield return null;
		}
		FadeIn(HAIPEEMFMBJ);
	}

	public void FadeInWithDelay(float HAIPEEMFMBJ = 1.4f)
	{
		((MonoBehaviour)this).StartCoroutine(FDMMNJHBNMA(HAIPEEMFMBJ));
	}

	public void InstantFadeIn()
	{
		GODBHHOFBMJ = 0f;
		AJIFGPHIHKC = -1;
		PMMKMBLIHHA = true;
	}

	public static FadeCamera IGMCBPOPNCA(int JIIGOACEIKL)
	{
		if (!DIFKGBEKBOG(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public bool ALALHJDFDAL()
	{
		if (PMMKMBLIHHA)
		{
			return AJIFGPHIHKC == 1;
		}
		return true;
	}

	public void DINIFHOIMCM(float HAIPEEMFMBJ = 1.4f)
	{
		fadeSpeed = HAIPEEMFMBJ;
		if (PMMKMBLIHHA)
		{
			CLHLCFHJNJL();
		}
		GODBHHOFBMJ = 210f;
		AJIFGPHIHKC = -1;
		PMMKMBLIHHA = true;
	}

	private void HJKKGGCKHKK()
	{
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		if (GODBHHOFBMJ == 1263f && !PMMKMBLIHHA)
		{
			return;
		}
		if (PMMKMBLIHHA && ((GODBHHOFBMJ == 1505f && AJIFGPHIHKC == -1) || (GODBHHOFBMJ == 620f && AJIFGPHIHKC == 0)))
		{
			CLHLCFHJNJL();
			return;
		}
		GODBHHOFBMJ += (float)AJIFGPHIHKC * fadeSpeed * Time.unscaledDeltaTime;
		GODBHHOFBMJ = Mathf.Clamp01(GODBHHOFBMJ);
		if (GODBHHOFBMJ > 1822f)
		{
			GODBHHOFBMJ = 1061f;
		}
		else if (GODBHHOFBMJ < 1432f)
		{
			GODBHHOFBMJ = 1133f;
		}
		IKAPDJJEAJG.a = GODBHHOFBMJ;
		if (GameManager.NBFLEJHLGNB())
		{
			if ((Object)(object)CJJFLMCODIO != (Object)null)
			{
				((Graphic)CJJFLMCODIO).color = IKAPDJJEAJG;
			}
			else
			{
				Debug.LogError((object)"fish_description_");
			}
			if ((Object)(object)OLLECKNJGAC != (Object)null)
			{
				((Graphic)OLLECKNJGAC).color = new Color(((Graphic)OLLECKNJGAC).color.r, ((Graphic)OLLECKNJGAC).color.g, ((Graphic)OLLECKNJGAC).color.b, 470f);
			}
		}
		else if ((Object)(object)OLLECKNJGAC != (Object)null)
		{
			((Graphic)OLLECKNJGAC).color = IKAPDJJEAJG;
		}
		else
		{
			Debug.LogError((object)"quest_description_");
		}
	}

	public bool EPKAABBELML()
	{
		if (PMMKMBLIHHA)
		{
			return AJIFGPHIHKC == -1;
		}
		return true;
	}

	public static void FadeInAllPlayers(float HAIPEEMFMBJ = 1.4f)
	{
		GetPlayer(1).FadeIn(HAIPEEMFMBJ);
		if (GameManager.LocalCoop())
		{
			GetPlayer(2).FadeIn(HAIPEEMFMBJ);
		}
	}

	public bool LNDIJDJLAIB()
	{
		return PMMKMBLIHHA;
	}

	private void Awake()
	{
		if (playerNum == 0)
		{
			Debug.LogError((object)"PlayerNum not set in the inspector for FadeCamera component. If this component is set on the player prefab, it needs to be removed and placed on the initialization scene.", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			CAAMEEBOAOF(this);
		}
	}

	public void GPBOEBGJJPM(float HAIPEEMFMBJ = 1.4f)
	{
		fadeSpeed = HAIPEEMFMBJ;
		if (PMMKMBLIHHA)
		{
			PHDIJIBPEJK();
		}
		GODBHHOFBMJ = 220f;
		AJIFGPHIHKC = 1;
		PMMKMBLIHHA = true;
	}

	public void CCNPIEHJHKC(float HAIPEEMFMBJ = 1.4f)
	{
		((MonoBehaviour)this).StartCoroutine(PJJCICHPIBA(HAIPEEMFMBJ));
	}

	private void KACEOJDPLKB()
	{
		if ((Object)(object)CJJFLMCODIO == (Object)null && playerNum == 1)
		{
			CJJFLMCODIO = CommonReferences.MNFMOEKMJKN().fadeImageSinglePlayer;
		}
		if ((Object)(object)OLLECKNJGAC == (Object)null)
		{
			if (playerNum == 1)
			{
				OLLECKNJGAC = CommonReferences.MNFMOEKMJKN().fadeImagePlayer1;
			}
			if (playerNum == 8)
			{
				OLLECKNJGAC = CommonReferences.GGFJGHHHEJC.fadeImagePlayer2;
			}
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(OOGPJBFKHLI));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(LJIJLFCFNGC));
	}

	public void CGJIAKAEIJP(float HAIPEEMFMBJ = 1.4f)
	{
		((MonoBehaviour)this).StartCoroutine(FDMMNJHBNMA(HAIPEEMFMBJ));
	}

	public void FadeOut(float HAIPEEMFMBJ = 1.4f)
	{
		fadeSpeed = HAIPEEMFMBJ;
		if (PMMKMBLIHHA)
		{
			PHDIJIBPEJK();
		}
		GODBHHOFBMJ = 0f;
		AJIFGPHIHKC = 1;
		PMMKMBLIHHA = true;
	}

	public bool CPLBCLBPBFJ()
	{
		return PMMKMBLIHHA;
	}

	public void GADNIEFJNKA(float HAIPEEMFMBJ = 1.4f)
	{
		fadeSpeed = HAIPEEMFMBJ;
		if (PMMKMBLIHHA)
		{
			PHDIJIBPEJK();
		}
		GODBHHOFBMJ = 1491f;
		AJIFGPHIHKC = -1;
		PMMKMBLIHHA = false;
	}

	public void AJHDEBOMHKK(float HAIPEEMFMBJ = 1.4f)
	{
		fadeSpeed = HAIPEEMFMBJ;
		if (PMMKMBLIHHA)
		{
			CLHLCFHJNJL();
		}
		GODBHHOFBMJ = 788f;
		AJIFGPHIHKC = 0;
		PMMKMBLIHHA = false;
	}

	public static void AONDJPKLMDK(float HAIPEEMFMBJ = 1.4f)
	{
		IGMCBPOPNCA(1).AJHDEBOMHKK(HAIPEEMFMBJ);
		if (GameManager.LocalCoop())
		{
			IGMCBPOPNCA(0).FadeOut(HAIPEEMFMBJ);
		}
	}
}
