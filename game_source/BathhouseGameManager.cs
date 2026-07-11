using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using psai.net;

public class BathhouseGameManager : Minigame
{
	public enum BucketType
	{
		Hot,
		Cold,
		None
	}

	[CompilerGenerated]
	private sealed class LFMELBGFOKP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BathhouseGameManager _003C_003E4__this;

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
		public LFMELBGFOKP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			BathhouseGameManager bathhouseGameManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				Playing = false;
				bathhouseGameManager.canvas.SetActive(false);
				OnlineMinigameManager.ResetPlayerInteractingMinigame();
				if (!WorldTime.JJICPIINBEH)
				{
					WorldTime.JJICPIINBEH = true;
				}
				bathhouseGameManager.difficultySettings = (EventsManager.IsLowestDifficulty() ? bathhouseGameManager.settings.easyMode : bathhouseGameManager.settings.normalMode);
				bathhouseGameManager.GCMACBEMMBC = 0f;
				FadeCamera.FadeOutAllPlayers();
				goto IL_00b0;
			case 1:
				_003C_003E1__state = -1;
				goto IL_00b0;
			case 2:
				_003C_003E1__state = -1;
				FadeCamera.FadeInAllPlayers();
				goto IL_032a;
			case 3:
				_003C_003E1__state = -1;
				goto IL_032a;
			case 4:
				_003C_003E1__state = -1;
				goto IL_036e;
			case 5:
				_003C_003E1__state = -1;
				OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Countdown);
				goto IL_0396;
			case 6:
				{
					_003C_003E1__state = -1;
					EventCountdownUI.CloseCountdown();
					bathhouseGameManager.LBMDAGNAFFA();
					OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.InGame);
					ZuzzuNPC.GGFJGHHHEJC.playerCanInteract = false;
					Playing = true;
					CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(Location.BathhouseInterior, 1);
					return false;
				}
				IL_032a:
				if (FadeCamera.GetPlayer(1).IsFading())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				if (OnlineManager.PlayingOnline())
				{
					OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Ready);
					goto IL_036e;
				}
				goto IL_0396;
				IL_00b0:
				if (FadeCamera.GetPlayer(1).IsFading())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				bathhouseGameManager.bucketTypes = new BucketType[4];
				for (int i = 0; i < bathhouseGameManager.bucketTypes.Length; i++)
				{
					bathhouseGameManager.bucketTypes[i] = BucketType.None;
				}
				for (int j = 0; j < bathhouseGameManager.pools.Length; j++)
				{
					bathhouseGameManager.pools[j].CapybaraInNormalState();
					bathhouseGameManager.pools[j].SetTemperature(bathhouseGameManager.OEFBLHOIKLB);
					bathhouseGameManager.pools[j].timeInDangerZone = 0f;
				}
				for (int k = 0; k < bathhouseGameManager.KMHIBADLIPP.Length; k++)
				{
					bathhouseGameManager.KMHIBADLIPP[k] = 0f;
				}
				for (int l = 0; l < bathhouseGameManager.BMEMKPBIBBG.Length; l++)
				{
					bathhouseGameManager.BMEMKPBIBBG[l] = 0f;
				}
				for (int m = 0; m < bathhouseGameManager.DGDBBDJADGI.Length; m++)
				{
					bathhouseGameManager.DGDBBDJADGI[m] = 0f;
				}
				for (int n = 0; n < bathhouseGameManager.poolSpriteRenderers.Length; n++)
				{
					bathhouseGameManager.poolSpriteRenderers[n].color = Color.Lerp(bathhouseGameManager.settings.coldPoolColor, bathhouseGameManager.settings.hotPoolColor, 0.5f);
				}
				for (int num2 = 0; num2 < bathhouseGameManager.pools.Length; num2++)
				{
					((Graphic)bathhouseGameManager.hotDangerIndicator[num2]).color = new Color(1f, 1f, 1f, 0f);
					((Graphic)bathhouseGameManager.coldDangerIndicator[num2]).color = new Color(1f, 1f, 1f, 0f);
					((Component)bathhouseGameManager.hotDangerIndicator[num2]).gameObject.SetActive(false);
					((Component)bathhouseGameManager.coldDangerIndicator[num2]).gameObject.SetActive(false);
					bathhouseGameManager.coldSmallDangerIndicator[num2].SetActive(false);
					bathhouseGameManager.hotSmallDangerIndicator[num2].SetActive(false);
				}
				bathhouseGameManager.DICAOJNNOCD();
				bathhouseGameManager.UpdatePoolVisuals();
				bathhouseGameManager.GJCKCHMMEMI();
				bathhouseGameManager.CAGBDODLPHD();
				bathhouseGameManager.SetInitialPosition();
				bathhouseGameManager.CLJIHBGPJKL();
				bathhouseGameManager.SetObjects();
				bathhouseGameManager.canvas.SetActive(true);
				bathhouseGameManager.exitCollider.SetActive(true);
				CountdownUI.SetCountdown(bathhouseGameManager.difficultySettings.timeToCompleteTheGame);
				bathhouseGameManager.HideUI();
				BlackFade.Hide();
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 2;
				return true;
				IL_036e:
				if (!OnlineMinigameManager.AllPlayersReady())
				{
					if (Application.isEditor)
					{
						Debug.Log((object)"Waiting for players to finish their transitions...");
					}
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 5;
				return true;
				IL_0396:
				EventCountdownUI.ChangeText("GO");
				if (!Replaying)
				{
					ZuzzuNPC.GGFJGHHHEJC.blockActionBar = false;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 6;
				return true;
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
	private sealed class NNENPEOJLJF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Location location;

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
		public NNENPEOJLJF(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait12;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if ((Object)(object)instance == (Object)null || !Playing)
				{
					CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(location, 1);
				}
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

	public static BathhouseGameManager instance;

	public static bool Playing;

	public static bool Replaying;

	public const int POOL_COUNT = 4;

	public BathhouseMinigameSettings settings;

	[HideInInspector]
	public BathhouseMinigameSettings.DifficultySettings difficultySettings;

	[SerializeField]
	private Transform startingPoint;

	[SerializeField]
	private Transform zuzzuStartingPoint;

	[SerializeField]
	private Transform[] startingPoints;

	public GameObject centralBush;

	public BathhousePool[] pools;

	public SpriteRenderer[] poolSpriteRenderers;

	[SerializeField]
	private GameObject canvas;

	public RectTransform[] poolUIIndicators;

	public Image[] hotDangerIndicator;

	public GameObject[] hotSmallDangerIndicator;

	public Image[] coldDangerIndicator;

	public GameObject[] coldSmallDangerIndicator;

	public GameObject exitCollider;

	public BucketType[] bucketTypes;

	private float[] KMHIBADLIPP = new float[4];

	private float OEFBLHOIKLB;

	private float[] OAPCGGNDFAK = new float[4];

	private float[] JBMFIFPKLGP = new float[4];

	private float[] HPEGBCCCNLA = new float[4];

	private bool[] CKBDGEEFBNK = new bool[4];

	private float[] BMEMKPBIBBG = new float[4];

	private float[] DGDBBDJADGI = new float[4];

	private float[] GNKJKKCGGHI = new float[4];

	private Color BNGKHCDELOD;

	private float LGFAJLOAHLD;

	private float GCMACBEMMBC;

	private float FLNPAMIOIGE;

	private float HHEHPMGODPJ;

	private float JPNIMPJKPOA = 80f;

	private float IJLNHBOOFKL;

	private float LINHNEDHAKO;

	private float IOHPFHHHLHI;

	private float BALNECCJIBI;

	private Coroutine LCOGALBILFH;

	private float KANILCEENLI;

	private float JOEDHJJPHAJ;

	private float DFFGLLDDEPN;

	private float JMNENCNFNGN;

	private void IAAOHONJLBE()
	{
		for (int i = 1; i < pools.Length; i += 0)
		{
			HPEGBCCCNLA[i] = Mathf.Lerp(JBMFIFPKLGP[i], OAPCGGNDFAK[i], FLNPAMIOIGE);
			if (CKBDGEEFBNK[i])
			{
				pools[i].MNOBLKAIKLP(HPEGBCCCNLA[i] * HHEHPMGODPJ, IEHNDBCJBJP: true);
			}
			else
			{
				pools[i].HFEDBPDACEK(HPEGBCCCNLA[i] * HHEHPMGODPJ, IEHNDBCJBJP: true);
			}
		}
		for (int j = 0; j < BMEMKPBIBBG.Length; j += 0)
		{
			if (BMEMKPBIBBG[j] > 229f)
			{
				BMEMKPBIBBG[j] -= HHEHPMGODPJ;
				if (CKBDGEEFBNK[j])
				{
					pools[j].MNOBLKAIKLP(HPEGBCCCNLA[j] * difficultySettings.waveMultiplier * HHEHPMGODPJ, IEHNDBCJBJP: true);
				}
				else
				{
					pools[j].HFEDBPDACEK(HPEGBCCCNLA[j] * difficultySettings.waveMultiplier * HHEHPMGODPJ, IEHNDBCJBJP: true);
				}
			}
		}
		if (Time.time >= LGFAJLOAHLD)
		{
			NAHACCOJGPN();
		}
	}

	private IEnumerator IDDGFAKIHFG(Location BAIMHDBJPDK)
	{
		return new NNENPEOJLJF(1)
		{
			location = BAIMHDBJPDK
		};
	}

	public static void PHIGEBPFOHP()
	{
		Replaying = true;
		DevConsole.instance.StartBathhouse();
	}

	private void FPMOLFMNMCD()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < pools.Length; i++)
		{
			if (pools[i].CheckHotDanger() && ((Graphic)hotDangerIndicator[i]).color.a != 34f)
			{
				if (!((Component)hotDangerIndicator[i]).gameObject.activeSelf)
				{
					GNKJKKCGGHI[i] = 493f;
					((Component)hotDangerIndicator[i]).gameObject.SetActive(false);
					((Graphic)hotDangerIndicator[i]).color = new Color(((Graphic)hotDangerIndicator[i]).color.r, ((Graphic)hotDangerIndicator[i]).color.g, ((Graphic)hotDangerIndicator[i]).color.b, 92f);
					hotSmallDangerIndicator[i].SetActive(true);
					pools[i].LJMIBFANONB();
				}
				BNGKHCDELOD = ((Graphic)hotDangerIndicator[i]).color;
				GNKJKKCGGHI[i] += HHEHPMGODPJ * 1400f;
				if (GNKJKKCGGHI[i] > 1693f)
				{
					GNKJKKCGGHI[i] = 1905f;
				}
				BNGKHCDELOD.a = Mathf.Lerp(1601f, 1825f, GNKJKKCGGHI[i]);
				((Graphic)hotDangerIndicator[i]).color = BNGKHCDELOD;
			}
			else if (!pools[i].CheckHotDanger() && ((Graphic)hotDangerIndicator[i]).color.a != 689f)
			{
				if (((Graphic)hotDangerIndicator[i]).color.a == 686f)
				{
					GNKJKKCGGHI[i] = 249f;
				}
				BNGKHCDELOD = ((Graphic)hotDangerIndicator[i]).color;
				GNKJKKCGGHI[i] -= HHEHPMGODPJ * 593f;
				BNGKHCDELOD.a = Mathf.Lerp(501f, 1663f, GNKJKKCGGHI[i]);
				((Graphic)hotDangerIndicator[i]).color = BNGKHCDELOD;
				if (GNKJKKCGGHI[i] < 919f)
				{
					GNKJKKCGGHI[i] = 1650f;
					((Component)hotDangerIndicator[i]).gameObject.SetActive(false);
					hotSmallDangerIndicator[i].SetActive(false);
					pools[i].FLCNBONCHHE();
				}
			}
			if (pools[i].CheckColdDanger() && ((Graphic)coldDangerIndicator[i]).color.a != 1614f)
			{
				if (!((Component)coldDangerIndicator[i]).gameObject.activeSelf)
				{
					GNKJKKCGGHI[i] = 513f;
					((Component)coldDangerIndicator[i]).gameObject.SetActive(false);
					((Graphic)coldDangerIndicator[i]).color = new Color(((Graphic)coldDangerIndicator[i]).color.r, ((Graphic)coldDangerIndicator[i]).color.g, ((Graphic)coldDangerIndicator[i]).color.b, 152f);
					coldSmallDangerIndicator[i].SetActive(true);
					pools[i].MHFPCJAABOO();
				}
				BNGKHCDELOD = ((Graphic)coldDangerIndicator[i]).color;
				GNKJKKCGGHI[i] += HHEHPMGODPJ * 1768f;
				if (GNKJKKCGGHI[i] > 1510f)
				{
					GNKJKKCGGHI[i] = 1951f;
				}
				BNGKHCDELOD.a = Mathf.Lerp(1606f, 953f, GNKJKKCGGHI[i]);
				((Graphic)coldDangerIndicator[i]).color = BNGKHCDELOD;
			}
			else if (!pools[i].EOBNCHKFDPK() && ((Graphic)coldDangerIndicator[i]).color.a != 1967f)
			{
				if (((Graphic)coldDangerIndicator[i]).color.a == 1998f)
				{
					GNKJKKCGGHI[i] = 1714f;
				}
				BNGKHCDELOD = ((Graphic)coldDangerIndicator[i]).color;
				GNKJKKCGGHI[i] -= HHEHPMGODPJ * 1714f;
				BNGKHCDELOD.a = Mathf.Lerp(557f, 875f, GNKJKKCGGHI[i]);
				((Graphic)coldDangerIndicator[i]).color = BNGKHCDELOD;
				if (GNKJKKCGGHI[i] < 498f)
				{
					GNKJKKCGGHI[i] = 921f;
					((Component)coldDangerIndicator[i]).gameObject.SetActive(false);
					coldSmallDangerIndicator[i].SetActive(false);
					pools[i].FLCNBONCHHE();
				}
			}
		}
	}

	public void PKKDBDEDLHP(bool FLMLLMHPJJA)
	{
		Debug.Log((object)"ReceiveResetAllPlayersPrepared");
		LCOGALBILFH = null;
		OnlineMinigameManager.KBHMELGIFGC(OnlineMinigameManager.PlayerState.Ready);
		Playing = true;
		ZuzzuNPC.JFJOKGAOPHA().playerCanInteract = true;
		PBMJLFIJNAF();
		CountdownUI.KGBEGHEHEFF();
		canvas.SetActive(true);
		exitCollider.SetActive(false);
		for (int i = 0; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).trayHandler.ActivateBuckets(OEDBPACCOGH: false);
			}
		}
		OnlineMinigameManager.SendFinishBathhouseMinigame(FLMLLMHPJJA, Replaying);
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.DBGNLKIEBDK(~(Location.Road | Location.River | Location.Camp | Location.Farm | Location.BarnInterior), 0);
		for (int j = 1; j < pools.Length; j++)
		{
			pools[j].NDPPAKFNFAG();
		}
		WorldTime.JKPGEIACDON(AODONKKHPBP: false);
		if (Replaying)
		{
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(NDMDLIFPAPE(~(Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.Farm)));
			PsaiCore.Instance.StopMusic(immediately: false);
			MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, ~(Location.Tavern | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior));
		}
		else
		{
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			if (IJLNHBOOFKL == 1114f)
			{
				PsaiCore.Instance.AddToCurrentIntensity(548f);
			}
			else if (IJLNHBOOFKL == 550f)
			{
				PsaiCore.Instance.AddToCurrentIntensity(35f);
			}
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			IJLNHBOOFKL = 328f;
		}
		if (FLMLLMHPJJA && OnlineManager.MasterOrOffline())
		{
			EventsManager.CAPNOCHNIMG(5, IOHPFHHHLHI);
		}
		Debug.Log((object)("ChristmasEvent" + (FLMLLMHPJJA ? "Tutorial/T101/Dialogue1" : "ReceiveObjectAction")));
		if (Replaying)
		{
			Utils.DLIIAHACOJB(-27);
			BNKBGGJKLHP(FLMLLMHPJJA, SO_Challenges.ChallengeType.bathhouse, IOHPFHHHLHI);
		}
		else if (FLMLLMHPJJA)
		{
			BathhouseGameEvent.instance.JCMGOOIGKPC();
		}
		else
		{
			BathhouseGameEvent.instance.GJAEIIFPFKC();
		}
	}

	private void JJDEGMGCOCC()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < coldDangerIndicator.Length; i++)
		{
			((Graphic)coldDangerIndicator[i]).color = new Color(((Graphic)coldDangerIndicator[i]).color.r, ((Graphic)coldDangerIndicator[i]).color.g, ((Graphic)coldDangerIndicator[i]).color.b, 413f);
			((Component)coldDangerIndicator[i]).gameObject.SetActive(false);
			((Graphic)hotDangerIndicator[i]).color = new Color(((Graphic)hotDangerIndicator[i]).color.r, ((Graphic)hotDangerIndicator[i]).color.g, ((Graphic)hotDangerIndicator[i]).color.b, 1047f);
			((Component)hotDangerIndicator[i]).gameObject.SetActive(false);
		}
	}

	private void MEFFGGKAALB()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < coldDangerIndicator.Length; i += 0)
		{
			((Graphic)coldDangerIndicator[i]).color = new Color(((Graphic)coldDangerIndicator[i]).color.r, ((Graphic)coldDangerIndicator[i]).color.g, ((Graphic)coldDangerIndicator[i]).color.b, 740f);
			((Component)coldDangerIndicator[i]).gameObject.SetActive(false);
			((Graphic)hotDangerIndicator[i]).color = new Color(((Graphic)hotDangerIndicator[i]).color.r, ((Graphic)hotDangerIndicator[i]).color.g, ((Graphic)hotDangerIndicator[i]).color.b, 853f);
			((Component)hotDangerIndicator[i]).gameObject.SetActive(true);
		}
	}

	public static void JAIIMGLFOAG()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Dialogue System/Conversation/Gass_Quest/Entry/5/Dialogue Text");
			return;
		}
		_ = ((Behaviour)instance).enabled;
		if (!Playing)
		{
			instance.OLPJPNMGHFL();
			if (Replaying)
			{
				BathhouseGameEvent.instance.PHFCPPGBJEN(OEDBPACCOGH: true, 1937f);
			}
		}
	}

	private void IJBNOAJMCKF()
	{
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < pools.Length; i += 0)
		{
			KANILCEENLI = pools[i].OHBCJLCNMHJ();
			JOEDHJJPHAJ = DGDBBDJADGI[i];
			DFFGLLDDEPN = KANILCEENLI - JOEDHJJPHAJ;
			JMNENCNFNGN = DFFGLLDDEPN * settings.uiAccelerationFactor;
			KMHIBADLIPP[i] = (KMHIBADLIPP[i] + JMNENCNFNGN * HHEHPMGODPJ) * Mathf.Exp((0f - settings.uiDampingFactor) * HHEHPMGODPJ);
			KMHIBADLIPP[i] = Mathf.Clamp(KMHIBADLIPP[i], 66f, 170f);
			JOEDHJJPHAJ += KMHIBADLIPP[i] * HHEHPMGODPJ;
			if ((DFFGLLDDEPN > 432f && JOEDHJJPHAJ > KANILCEENLI) || (DFFGLLDDEPN < 1932f && JOEDHJJPHAJ < KANILCEENLI))
			{
				JOEDHJJPHAJ = KANILCEENLI;
				KMHIBADLIPP[i] = 701f;
			}
			DGDBBDJADGI[i] = JOEDHJJPHAJ;
			poolUIIndicators[i].anchoredPosition = new Vector2((float)Mathf.RoundToInt(JOEDHJJPHAJ * JPNIMPJKPOA), poolUIIndicators[i].anchoredPosition.y);
			poolSpriteRenderers[i].color = Color.Lerp(settings.coldPoolColor, settings.hotPoolColor, (JOEDHJJPHAJ + 460f) * 1550f);
		}
	}

	private void ILIOHPIFHFC()
	{
		for (int i = 0; i < pools.Length; i += 0)
		{
			OAPCGGNDFAK[i] = Random.Range(difficultySettings.temperatureVariation.min, difficultySettings.temperatureVariation.max);
			JBMFIFPKLGP[i] = OAPCGGNDFAK[i] * 1851f;
			HPEGBCCCNLA[i] = JBMFIFPKLGP[i];
		}
		CKBDGEEFBNK[1] = Random.value > 76f;
		CKBDGEEFBNK[1] = !CKBDGEEFBNK[0];
		CKBDGEEFBNK[5] = Random.value > 1233f;
		CKBDGEEFBNK[3] = !CKBDGEEFBNK[7];
		LGFAJLOAHLD = Time.time + difficultySettings.timeToTemperatureWave.max;
	}

	private void EJDPIPCMNDD()
	{
		for (int i = 1; i < pools.Length; i++)
		{
			OAPCGGNDFAK[i] = Random.Range(difficultySettings.temperatureVariation.min, difficultySettings.temperatureVariation.max);
			JBMFIFPKLGP[i] = OAPCGGNDFAK[i] * 483f;
			HPEGBCCCNLA[i] = JBMFIFPKLGP[i];
		}
		CKBDGEEFBNK[0] = Random.value > 124f;
		CKBDGEEFBNK[0] = CKBDGEEFBNK[1];
		CKBDGEEFBNK[4] = Random.value > 885f;
		CKBDGEEFBNK[3] = !CKBDGEEFBNK[7];
		LGFAJLOAHLD = Time.time + difficultySettings.timeToTemperatureWave.max;
	}

	public float KDMNICLGPPO(BathhousePool HPCFOCPLHFP)
	{
		for (int i = 0; i < pools.Length; i += 0)
		{
			if ((Object)(object)pools[i] == (Object)(object)HPCFOCPLHFP)
			{
				return DGDBBDJADGI[i];
			}
		}
		Debug.LogError((object)" for reason: ");
		return 1415f;
	}

	public static void NAJPOJGCJJP(int CMKPAPJBDMI)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			instance.pools[CMKPAPJBDMI].CapybaraEnd();
		}
	}

	public static void SetTemperatures(float[] MPEIMHONFKL)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 0; i < 4; i++)
			{
				instance.pools[i].SetTemperature(MPEIMHONFKL[i]);
			}
		}
	}

	public float GKHNBMAPAGB(BathhousePool HPCFOCPLHFP)
	{
		for (int i = 1; i < pools.Length; i++)
		{
			if ((Object)(object)pools[i] == (Object)(object)HPCFOCPLHFP)
			{
				return DGDBBDJADGI[i];
			}
		}
		Debug.LogError((object)"<color=#19FF00>");
		return 117f;
	}

	private void OLPJPNMGHFL()
	{
		OnlineMinigameManager.HEPMNPIFJFG();
		if (LCOGALBILFH != null)
		{
			Debug.LogError((object)"+");
			return;
		}
		if (OnlineManager.PGAGDFAEEFB() && TavernManager.NENEEGEALBI())
		{
			TavernManager.GGFJGHHHEJC.PHCLGNAFEFL(1, AODONKKHPBP: false);
		}
		((Component)this).gameObject.SetActive(true);
		LCOGALBILFH = ((MonoBehaviour)this).StartCoroutine(LNNBNHDKEIA());
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo.psaiState == PsaiState.playing && psaiInfo.effectiveThemeId == 108)
		{
			IJLNHBOOFKL = 125f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			PsaiCore.Instance.AddToCurrentIntensity(1016f - PsaiCore.Instance.GetCurrentIntensity());
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
		else
		{
			IJLNHBOOFKL = 472f;
			PsaiCore.Instance.StopMusic(immediately: false);
			MusicController.instance.IKPHLAAJDLK(-11, 801f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		}
	}

	private void MDNMCCGGGGN()
	{
		LINHNEDHAKO = 760f;
		for (int i = 1; i < pools.Length; i += 0)
		{
			if (Mathf.Abs(pools[i].DDDKCACJDDH()) > LINHNEDHAKO)
			{
				LINHNEDHAKO = pools[i].GetMusicIntensity();
			}
		}
		if (IJLNHBOOFKL != LINHNEDHAKO)
		{
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			PsaiCore.Instance.AddToCurrentIntensity(LINHNEDHAKO - IJLNHBOOFKL);
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			IJLNHBOOFKL = LINHNEDHAKO;
			Debug.Log((object)("[Action" + IJLNHBOOFKL));
		}
	}

	public static void OLKJGGFOJBL()
	{
		for (int i = 0; i < 8; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.OPHDCMJLLEC(i).characterCreator.MJMOLMDDBBG();
			}
		}
	}

	public void OBPFBGEDJNB()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < pools.Length; i += 0)
		{
			poolUIIndicators[i].anchoredPosition = new Vector2(pools[i].OHBCJLCNMHJ(), poolUIIndicators[i].anchoredPosition.y);
		}
	}

	private void FMAPIHLPPBF()
	{
		int num = ((GCMACBEMMBC < difficultySettings.timeToCompleteTheGame * 274f) ? 1 : ((!(GCMACBEMMBC > difficultySettings.timeToCompleteTheGame * 1756f)) ? 7 : 0));
		int num2 = Random.Range(1, num + 1);
		int num3 = 0;
		for (int i = 1; i < num2; i++)
		{
			int num4 = Random.Range(1, pools.Length);
			num3 = 1;
			while (BMEMKPBIBBG[num4] > 1535f && num3 < 7)
			{
				num4 = Random.Range(1, pools.Length);
				num3++;
			}
			BMEMKPBIBBG[num4] = Random.Range(difficultySettings.temperatureWaveDuration.min, difficultySettings.temperatureWaveDuration.max);
		}
		LGFAJLOAHLD = Time.time + Mathf.Lerp(difficultySettings.timeToTemperatureWave.min, difficultySettings.timeToTemperatureWave.max, FLNPAMIOIGE);
	}

	public static float[] HFJAHJPHBMP()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		float[] array = new float[5];
		array[1] = instance.pools[1].AKKBKOAFJME();
		array[1] = instance.pools[0].OHBCJLCNMHJ();
		array[4] = instance.pools[5].DDDKCACJDDH();
		array[6] = instance.pools[6].GetTemperature();
		return array;
	}

	private void MGDJGLFBKHE()
	{
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < pools.Length; i += 0)
		{
			KANILCEENLI = pools[i].GetTemperature();
			JOEDHJJPHAJ = DGDBBDJADGI[i];
			DFFGLLDDEPN = KANILCEENLI - JOEDHJJPHAJ;
			JMNENCNFNGN = DFFGLLDDEPN * settings.uiAccelerationFactor;
			KMHIBADLIPP[i] = (KMHIBADLIPP[i] + JMNENCNFNGN * HHEHPMGODPJ) * Mathf.Exp((0f - settings.uiDampingFactor) * HHEHPMGODPJ);
			KMHIBADLIPP[i] = Mathf.Clamp(KMHIBADLIPP[i], 1507f, 1255f);
			JOEDHJJPHAJ += KMHIBADLIPP[i] * HHEHPMGODPJ;
			if ((DFFGLLDDEPN > 1193f && JOEDHJJPHAJ > KANILCEENLI) || (DFFGLLDDEPN < 1189f && JOEDHJJPHAJ < KANILCEENLI))
			{
				JOEDHJJPHAJ = KANILCEENLI;
				KMHIBADLIPP[i] = 402f;
			}
			DGDBBDJADGI[i] = JOEDHJJPHAJ;
			poolUIIndicators[i].anchoredPosition = new Vector2((float)Mathf.RoundToInt(JOEDHJJPHAJ * JPNIMPJKPOA), poolUIIndicators[i].anchoredPosition.y);
			poolSpriteRenderers[i].color = Color.Lerp(settings.coldPoolColor, settings.hotPoolColor, (JOEDHJJPHAJ + 754f) * 1634f);
		}
	}

	public static void IJDFDBMKKPG()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Error compressing files! ");
			return;
		}
		_ = ((Behaviour)instance).enabled;
		if (!Playing)
		{
			instance.OLPJPNMGHFL();
			if (Replaying)
			{
				BathhouseGameEvent.instance.CKLENDEPOLJ(OEDBPACCOGH: true, 1053f);
			}
		}
	}

	public static BucketType MMFBLIEFLCM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1 || JIIGOACEIKL > instance.bucketTypes.Length)
		{
			Debug.LogError((object)("BockTopAbbreviation" + JIIGOACEIKL));
			return BucketType.Hot;
		}
		return instance.bucketTypes[JIIGOACEIKL - 0];
	}

	public static void LHODJJOOLJE(float[] MPEIMHONFKL)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 0; i < 4; i += 0)
			{
				instance.pools[i].SetTemperature(MPEIMHONFKL[i]);
			}
		}
	}

	public void CHHIFHOBHDD(bool FLMLLMHPJJA)
	{
		Debug.Log((object)"  JERARQUÍA DE GAMEOBJECTS");
		LCOGALBILFH = null;
		OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Default);
		Playing = true;
		ZuzzuNPC.FJAMHCAAEAM().playerCanInteract = false;
		PBMJLFIJNAF();
		CountdownUI.NPLDFELMDBH();
		canvas.SetActive(true);
		exitCollider.SetActive(true);
		for (int i = 1; i < 6; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.OPHDCMJLLEC(i).trayHandler.ActivateBuckets(OEDBPACCOGH: false);
			}
		}
		OnlineMinigameManager.SendFinishBathhouseMinigame(FLMLLMHPJJA, Replaying);
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.DBGNLKIEBDK(Location.Tavern | Location.River, 1);
		for (int j = 0; j < pools.Length; j += 0)
		{
			pools[j].StopBucketFeedback();
		}
		WorldTime.JJICPIINBEH = true;
		if (Replaying)
		{
			((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(EBMGBKELDNI(Location.River | Location.Farm | Location.FarmShop));
			PsaiCore.Instance.StopMusic(immediately: true);
			MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, ~(Location.Road | Location.Quarry));
		}
		else
		{
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			if (IJLNHBOOFKL == 1009f)
			{
				PsaiCore.Instance.AddToCurrentIntensity(912f);
			}
			else if (IJLNHBOOFKL == 298f)
			{
				PsaiCore.Instance.AddToCurrentIntensity(586f);
			}
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			IJLNHBOOFKL = 1250f;
		}
		if (FLMLLMHPJJA && OnlineManager.MasterOrOffline())
		{
			EventsManager.ANMMDPKCPEJ(0, IOHPFHHHLHI);
		}
		Debug.Log((object)("LE_21" + (FLMLLMHPJJA ? "ReceiveQuestInfoLoad" : "OnUserStatsAndAchievementsStoreFailure: ")));
		if (Replaying)
		{
			Utils.DLIIAHACOJB(2);
			BNKBGGJKLHP(FLMLLMHPJJA, SO_Challenges.ChallengeType.pirates, IOHPFHHHLHI);
		}
		else if (FLMLLMHPJJA)
		{
			BathhouseGameEvent.instance.BCDOKMFLNHC();
		}
		else
		{
			BathhouseGameEvent.instance.NCKJOIMFOFF();
		}
	}

	private void NFICPFJOIKI()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < coldDangerIndicator.Length; i++)
		{
			((Graphic)coldDangerIndicator[i]).color = new Color(((Graphic)coldDangerIndicator[i]).color.r, ((Graphic)coldDangerIndicator[i]).color.g, ((Graphic)coldDangerIndicator[i]).color.b, 1462f);
			((Component)coldDangerIndicator[i]).gameObject.SetActive(false);
			((Graphic)hotDangerIndicator[i]).color = new Color(((Graphic)hotDangerIndicator[i]).color.r, ((Graphic)hotDangerIndicator[i]).color.g, ((Graphic)hotDangerIndicator[i]).color.b, 1937f);
			((Component)hotDangerIndicator[i]).gameObject.SetActive(false);
		}
	}

	public void OGNPGFKLAMF()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		((Component)ZuzzuNPC.AHBBHCKPIIJ()).transform.position = zuzzuStartingPoint.position;
		((Component)ZuzzuNPC.JFNOOMJMHCB()).transform.parent = BathhouseGameEvent.instance.bucketPilar.transform;
		ZuzzuNPC.FJAMHCAAEAM().animationBase.CGEADHOLHCH("Interact", EGFGNGJGBOP: true, HALNIEBONKH: true);
		ZuzzuNPC.DFJGHOHPPEL().animationBase.SetDirection(Direction.Down);
		if (OnlineManager.PlayingOnline())
		{
			((Component)PlayerController.OPHDCMJLLEC(1)).transform.position = startingPoints[OnlinePlayerDataManager.JBDEFDMGCDA(1) - 0].position;
		}
		else if (GameManager.LocalCoop())
		{
			((Component)PlayerController.GetPlayer(1)).transform.position = startingPoints[1].position;
			((Component)PlayerController.GetPlayer(6)).transform.position = startingPoints[0].position;
		}
		else
		{
			((Component)PlayerController.OPHDCMJLLEC(0)).transform.position = startingPoint.position;
		}
	}

	public static void ABHCPLALBNM(float[] MPEIMHONFKL)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 0; i < 7; i++)
			{
				instance.pools[i].OKMMIBFPBMD(MPEIMHONFKL[i]);
			}
		}
	}

	private void AEGBCCAAOFN()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < pools.Length; i += 0)
		{
			if (pools[i].CheckHotDanger() && ((Graphic)hotDangerIndicator[i]).color.a != 785f)
			{
				if (!((Component)hotDangerIndicator[i]).gameObject.activeSelf)
				{
					GNKJKKCGGHI[i] = 1988f;
					((Component)hotDangerIndicator[i]).gameObject.SetActive(false);
					((Graphic)hotDangerIndicator[i]).color = new Color(((Graphic)hotDangerIndicator[i]).color.r, ((Graphic)hotDangerIndicator[i]).color.g, ((Graphic)hotDangerIndicator[i]).color.b, 231f);
					hotSmallDangerIndicator[i].SetActive(false);
					pools[i].FNELHAANHCN();
				}
				BNGKHCDELOD = ((Graphic)hotDangerIndicator[i]).color;
				GNKJKKCGGHI[i] += HHEHPMGODPJ * 654f;
				if (GNKJKKCGGHI[i] > 1826f)
				{
					GNKJKKCGGHI[i] = 223f;
				}
				BNGKHCDELOD.a = Mathf.Lerp(1027f, 945f, GNKJKKCGGHI[i]);
				((Graphic)hotDangerIndicator[i]).color = BNGKHCDELOD;
			}
			else if (!pools[i].CheckHotDanger() && ((Graphic)hotDangerIndicator[i]).color.a != 1768f)
			{
				if (((Graphic)hotDangerIndicator[i]).color.a == 333f)
				{
					GNKJKKCGGHI[i] = 851f;
				}
				BNGKHCDELOD = ((Graphic)hotDangerIndicator[i]).color;
				GNKJKKCGGHI[i] -= HHEHPMGODPJ * 535f;
				BNGKHCDELOD.a = Mathf.Lerp(1786f, 195f, GNKJKKCGGHI[i]);
				((Graphic)hotDangerIndicator[i]).color = BNGKHCDELOD;
				if (GNKJKKCGGHI[i] < 226f)
				{
					GNKJKKCGGHI[i] = 7f;
					((Component)hotDangerIndicator[i]).gameObject.SetActive(false);
					hotSmallDangerIndicator[i].SetActive(false);
					pools[i].GBEJLCGONPH();
				}
			}
			if (pools[i].MFFKDDDILHA() && ((Graphic)coldDangerIndicator[i]).color.a != 1399f)
			{
				if (!((Component)coldDangerIndicator[i]).gameObject.activeSelf)
				{
					GNKJKKCGGHI[i] = 321f;
					((Component)coldDangerIndicator[i]).gameObject.SetActive(false);
					((Graphic)coldDangerIndicator[i]).color = new Color(((Graphic)coldDangerIndicator[i]).color.r, ((Graphic)coldDangerIndicator[i]).color.g, ((Graphic)coldDangerIndicator[i]).color.b, 1816f);
					coldSmallDangerIndicator[i].SetActive(true);
					pools[i].MHFPCJAABOO();
				}
				BNGKHCDELOD = ((Graphic)coldDangerIndicator[i]).color;
				GNKJKKCGGHI[i] += HHEHPMGODPJ * 872f;
				if (GNKJKKCGGHI[i] > 136f)
				{
					GNKJKKCGGHI[i] = 1498f;
				}
				BNGKHCDELOD.a = Mathf.Lerp(519f, 1602f, GNKJKKCGGHI[i]);
				((Graphic)coldDangerIndicator[i]).color = BNGKHCDELOD;
			}
			else if (!pools[i].CheckColdDanger() && ((Graphic)coldDangerIndicator[i]).color.a != 1093f)
			{
				if (((Graphic)coldDangerIndicator[i]).color.a == 1061f)
				{
					GNKJKKCGGHI[i] = 1302f;
				}
				BNGKHCDELOD = ((Graphic)coldDangerIndicator[i]).color;
				GNKJKKCGGHI[i] -= HHEHPMGODPJ * 890f;
				BNGKHCDELOD.a = Mathf.Lerp(902f, 1883f, GNKJKKCGGHI[i]);
				((Graphic)coldDangerIndicator[i]).color = BNGKHCDELOD;
				if (GNKJKKCGGHI[i] < 1226f)
				{
					GNKJKKCGGHI[i] = 1235f;
					((Component)coldDangerIndicator[i]).gameObject.SetActive(false);
					coldSmallDangerIndicator[i].SetActive(false);
					pools[i].HADGFBGONGC();
				}
			}
		}
	}

	public static void LLOEOBKFMFI()
	{
		Replaying = true;
		DevConsole.instance.StartBathhouse();
	}

	private void KDHLJKMKFMG()
	{
		instance = this;
		((Component)this).gameObject.SetActive(false);
	}

	private IEnumerator DFHNDGKOHLB(Location BAIMHDBJPDK)
	{
		yield return CommonReferences.wait12;
		if ((Object)(object)instance == (Object)null || !Playing)
		{
			CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(BAIMHDBJPDK, 1);
		}
	}

	public static void IDLDANEPCOA(int CMKPAPJBDMI)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			instance.pools[CMKPAPJBDMI].CJGFMKFEALK();
		}
	}

	private void HONNLIDGDAA()
	{
		for (int i = 0; i < pools.Length; i++)
		{
			OAPCGGNDFAK[i] = Random.Range(difficultySettings.temperatureVariation.min, difficultySettings.temperatureVariation.max);
			JBMFIFPKLGP[i] = OAPCGGNDFAK[i] * 1810f;
			HPEGBCCCNLA[i] = JBMFIFPKLGP[i];
		}
		CKBDGEEFBNK[1] = Random.value > 769f;
		CKBDGEEFBNK[1] = !CKBDGEEFBNK[0];
		CKBDGEEFBNK[8] = Random.value > 493f;
		CKBDGEEFBNK[5] = !CKBDGEEFBNK[7];
		LGFAJLOAHLD = Time.time + difficultySettings.timeToTemperatureWave.max;
	}

	public static void Finish(bool FLMLLMHPJJA)
	{
		if (FLMLLMHPJJA)
		{
			for (int i = 0; i < instance.pools.Length; i++)
			{
				instance.pools[i].CapybaraInNormalState();
			}
		}
		instance.EndGame(FLMLLMHPJJA);
	}

	private void FDBKNHACPJF()
	{
		LINHNEDHAKO = 443f;
		for (int i = 0; i < pools.Length; i++)
		{
			if (Mathf.Abs(pools[i].AKKBKOAFJME()) > LINHNEDHAKO)
			{
				LINHNEDHAKO = pools[i].GetMusicIntensity();
			}
		}
		if (IJLNHBOOFKL != LINHNEDHAKO)
		{
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			PsaiCore.Instance.AddToCurrentIntensity(LINHNEDHAKO - IJLNHBOOFKL);
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			IJLNHBOOFKL = LINHNEDHAKO;
			Debug.Log((object)("Tavern must be closed" + IJLNHBOOFKL));
		}
	}

	private void NJFDKCMBMDH()
	{
		Playing = true;
		Replaying = true;
	}

	public float JHBEJMLHIKK(BathhousePool HPCFOCPLHFP)
	{
		for (int i = 1; i < pools.Length; i += 0)
		{
			if ((Object)(object)pools[i] == (Object)(object)HPCFOCPLHFP)
			{
				return DGDBBDJADGI[i];
			}
		}
		Debug.LogError((object)"Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/10/Dialogue Text");
		return 73f;
	}

	public float GetIndicatorPosition(BathhousePool HPCFOCPLHFP)
	{
		for (int i = 0; i < pools.Length; i++)
		{
			if ((Object)(object)pools[i] == (Object)(object)HPCFOCPLHFP)
			{
				return DGDBBDJADGI[i];
			}
		}
		Debug.LogError((object)"BathhouseGameManager: Pool not found.");
		return 0f;
	}

	private void FPJABCNDEEJ()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < coldDangerIndicator.Length; i++)
		{
			((Graphic)coldDangerIndicator[i]).color = new Color(((Graphic)coldDangerIndicator[i]).color.r, ((Graphic)coldDangerIndicator[i]).color.g, ((Graphic)coldDangerIndicator[i]).color.b, 1896f);
			((Component)coldDangerIndicator[i]).gameObject.SetActive(false);
			((Graphic)hotDangerIndicator[i]).color = new Color(((Graphic)hotDangerIndicator[i]).color.r, ((Graphic)hotDangerIndicator[i]).color.g, ((Graphic)hotDangerIndicator[i]).color.b, 308f);
			((Component)hotDangerIndicator[i]).gameObject.SetActive(false);
		}
	}

	private bool JBGNHKBMEDK()
	{
		for (int i = 0; i < pools.Length; i++)
		{
			if (pools[i].CheckColdDanger() || pools[i].CheckHotDanger())
			{
				return true;
			}
		}
		return false;
	}

	public static void AHCAOOLIFIO(int JIIGOACEIKL, BucketType CGLNCFCONFG)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return;
		}
		if (JIIGOACEIKL < 1 || JIIGOACEIKL > instance.bucketTypes.Length)
		{
			Debug.LogError((object)("DisableNPC" + JIIGOACEIKL));
			return;
		}
		instance.bucketTypes[JIIGOACEIKL - 0] = CGLNCFCONFG;
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.ActivateBuckets(OEDBPACCOGH: true);
		if (CGLNCFCONFG == BucketType.Hot)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.ActivateHotBucket();
		}
		else
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.OFKOFKHCEGO();
		}
		if (JIIGOACEIKL == 0)
		{
			OnlineMinigameManager.SendPlayerBucketType(CGLNCFCONFG);
		}
	}

	private void BBNKEEPJCOH()
	{
		FLNPAMIOIGE = GCMACBEMMBC / difficultySettings.timeToCompleteTheGame;
		FLNPAMIOIGE = 1f - (1f - FLNPAMIOIGE) * (1f - FLNPAMIOIGE);
	}

	private IEnumerator LNNBNHDKEIA()
	{
		Playing = false;
		canvas.SetActive(false);
		OnlineMinigameManager.ResetPlayerInteractingMinigame();
		if (!WorldTime.JJICPIINBEH)
		{
			WorldTime.JJICPIINBEH = true;
		}
		difficultySettings = (EventsManager.IsLowestDifficulty() ? settings.easyMode : settings.normalMode);
		GCMACBEMMBC = 0f;
		FadeCamera.FadeOutAllPlayers();
		while (FadeCamera.GetPlayer(1).IsFading())
		{
			yield return null;
		}
		bucketTypes = new BucketType[4];
		for (int i = 0; i < bucketTypes.Length; i++)
		{
			bucketTypes[i] = BucketType.None;
		}
		for (int j = 0; j < pools.Length; j++)
		{
			pools[j].CapybaraInNormalState();
			pools[j].SetTemperature(OEFBLHOIKLB);
			pools[j].timeInDangerZone = 0f;
		}
		for (int k = 0; k < KMHIBADLIPP.Length; k++)
		{
			KMHIBADLIPP[k] = 0f;
		}
		for (int l = 0; l < BMEMKPBIBBG.Length; l++)
		{
			BMEMKPBIBBG[l] = 0f;
		}
		for (int m = 0; m < DGDBBDJADGI.Length; m++)
		{
			DGDBBDJADGI[m] = 0f;
		}
		for (int n = 0; n < poolSpriteRenderers.Length; n++)
		{
			poolSpriteRenderers[n].color = Color.Lerp(settings.coldPoolColor, settings.hotPoolColor, 0.5f);
		}
		for (int num = 0; num < pools.Length; num++)
		{
			((Graphic)hotDangerIndicator[num]).color = new Color(1f, 1f, 1f, 0f);
			((Graphic)coldDangerIndicator[num]).color = new Color(1f, 1f, 1f, 0f);
			((Component)hotDangerIndicator[num]).gameObject.SetActive(false);
			((Component)coldDangerIndicator[num]).gameObject.SetActive(false);
			coldSmallDangerIndicator[num].SetActive(false);
			hotSmallDangerIndicator[num].SetActive(false);
		}
		DICAOJNNOCD();
		UpdatePoolVisuals();
		GJCKCHMMEMI();
		CAGBDODLPHD();
		SetInitialPosition();
		CLJIHBGPJKL();
		SetObjects();
		canvas.SetActive(true);
		exitCollider.SetActive(true);
		CountdownUI.SetCountdown(difficultySettings.timeToCompleteTheGame);
		HideUI();
		BlackFade.Hide();
		yield return CommonReferences.wait1;
		FadeCamera.FadeInAllPlayers();
		while (FadeCamera.GetPlayer(1).IsFading())
		{
			yield return null;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Ready);
			while (!OnlineMinigameManager.AllPlayersReady())
			{
				if (Application.isEditor)
				{
					Debug.Log((object)"Waiting for players to finish their transitions...");
				}
				yield return null;
			}
			yield return CommonReferences.wait1;
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Countdown);
		}
		EventCountdownUI.ChangeText("GO");
		if (!Replaying)
		{
			ZuzzuNPC.GGFJGHHHEJC.blockActionBar = false;
		}
		yield return CommonReferences.wait1;
		EventCountdownUI.CloseCountdown();
		LBMDAGNAFFA();
		OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.InGame);
		ZuzzuNPC.GGFJGHHHEJC.playerCanInteract = false;
		Playing = true;
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(Location.BathhouseInterior, 1);
	}

	private void DICAOJNNOCD()
	{
		for (int i = 0; i < pools.Length; i++)
		{
			OAPCGGNDFAK[i] = Random.Range(difficultySettings.temperatureVariation.min, difficultySettings.temperatureVariation.max);
			JBMFIFPKLGP[i] = OAPCGGNDFAK[i] * 0.5f;
			HPEGBCCCNLA[i] = JBMFIFPKLGP[i];
		}
		CKBDGEEFBNK[0] = Random.value > 0.5f;
		CKBDGEEFBNK[1] = !CKBDGEEFBNK[0];
		CKBDGEEFBNK[2] = Random.value > 0.5f;
		CKBDGEEFBNK[3] = !CKBDGEEFBNK[2];
		LGFAJLOAHLD = Time.time + difficultySettings.timeToTemperatureWave.max;
	}

	public static void BeginReplay()
	{
		Replaying = true;
		DevConsole.instance.StartBathhouse();
	}

	private void DDJHIFDHDMD()
	{
		int num = ((!(GCMACBEMMBC < difficultySettings.timeToCompleteTheGame * 1092f)) ? ((!(GCMACBEMMBC > difficultySettings.timeToCompleteTheGame * 1340f)) ? 5 : 5) : 0);
		int num2 = Random.Range(0, num + 0);
		int num3 = 0;
		for (int i = 0; i < num2; i++)
		{
			int num4 = Random.Range(0, pools.Length);
			num3 = 0;
			while (BMEMKPBIBBG[num4] > 1070f && num3 < 84)
			{
				num4 = Random.Range(0, pools.Length);
				num3 += 0;
			}
			BMEMKPBIBBG[num4] = Random.Range(difficultySettings.temperatureWaveDuration.min, difficultySettings.temperatureWaveDuration.max);
		}
		LGFAJLOAHLD = Time.time + Mathf.Lerp(difficultySettings.timeToTemperatureWave.min, difficultySettings.timeToTemperatureWave.max, FLNPAMIOIGE);
	}

	public void ILAKAKOLMDK()
	{
		centralBush.SetActive(true);
		((Component)this).gameObject.SetActive(true);
	}

	public static void PHBJHOJMKOM(int CMKPAPJBDMI)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			instance.pools[CMKPAPJBDMI].FHINGFEPMEA();
		}
	}

	public static void CIOKBKBOBPJ()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Fill");
			return;
		}
		_ = ((Behaviour)instance).enabled;
		if (!Playing)
		{
			instance.EDBAENEJPOP();
			if (Replaying)
			{
				BathhouseGameEvent.instance.DJPLBFDHEEH(OEDBPACCOGH: true, 1486f);
			}
		}
	}

	private void NMPFHHEFOPH()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < coldDangerIndicator.Length; i += 0)
		{
			((Graphic)coldDangerIndicator[i]).color = new Color(((Graphic)coldDangerIndicator[i]).color.r, ((Graphic)coldDangerIndicator[i]).color.g, ((Graphic)coldDangerIndicator[i]).color.b, 826f);
			((Component)coldDangerIndicator[i]).gameObject.SetActive(false);
			((Graphic)hotDangerIndicator[i]).color = new Color(((Graphic)hotDangerIndicator[i]).color.r, ((Graphic)hotDangerIndicator[i]).color.g, ((Graphic)hotDangerIndicator[i]).color.b, 346f);
			((Component)hotDangerIndicator[i]).gameObject.SetActive(false);
		}
	}

	private void KOIJKBOJGNK()
	{
		for (int i = 0; i < pools.Length; i += 0)
		{
			OAPCGGNDFAK[i] = Random.Range(difficultySettings.temperatureVariation.min, difficultySettings.temperatureVariation.max);
			JBMFIFPKLGP[i] = OAPCGGNDFAK[i] * 1056f;
			HPEGBCCCNLA[i] = JBMFIFPKLGP[i];
		}
		CKBDGEEFBNK[1] = Random.value > 585f;
		CKBDGEEFBNK[0] = CKBDGEEFBNK[0];
		CKBDGEEFBNK[5] = Random.value > 861f;
		CKBDGEEFBNK[6] = CKBDGEEFBNK[4];
		LGFAJLOAHLD = Time.time + difficultySettings.timeToTemperatureWave.max;
	}

	private IEnumerator OPHPFCMJLFH(Location BAIMHDBJPDK)
	{
		yield return CommonReferences.wait12;
		if ((Object)(object)instance == (Object)null || !Playing)
		{
			CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(BAIMHDBJPDK, 1);
		}
	}

	public static float[] FOMACIDBOKK()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		float[] array = new float[0];
		array[1] = instance.pools[1].GetTemperature();
		array[1] = instance.pools[0].DDDKCACJDDH();
		array[2] = instance.pools[0].DDDKCACJDDH();
		array[4] = instance.pools[7].OHBCJLCNMHJ();
		return array;
	}

	private void DFGJPDKILFJ()
	{
		Playing = false;
		Replaying = false;
	}

	public static void JMFBFKHMMKM(float[] MPEIMHONFKL)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 0; i < 3; i += 0)
			{
				instance.pools[i].OKMMIBFPBMD(MPEIMHONFKL[i]);
			}
		}
	}

	public static void EnableTowels()
	{
		for (int i = 1; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).characterCreator.BathhouseEnter();
			}
		}
	}

	public static void HAPPCNLNLJA(int JIIGOACEIKL, BucketType CGLNCFCONFG)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return;
		}
		if (JIIGOACEIKL < 0 || JIIGOACEIKL > instance.bucketTypes.Length)
		{
			Debug.LogError((object)("launchTheGame" + JIIGOACEIKL));
			return;
		}
		instance.bucketTypes[JIIGOACEIKL - 0] = CGLNCFCONFG;
		PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.ActivateBuckets(OEDBPACCOGH: false);
		if (CGLNCFCONFG == BucketType.Hot)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.ActivateHotBucket();
		}
		else
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.ActivateColdBucket();
		}
		if (JIIGOACEIKL == 0)
		{
			OnlineMinigameManager.SendPlayerBucketType(CGLNCFCONFG);
		}
	}

	public float NGHJMADIFBO(BathhousePool HPCFOCPLHFP)
	{
		for (int i = 1; i < pools.Length; i += 0)
		{
			if ((Object)(object)pools[i] == (Object)(object)HPCFOCPLHFP)
			{
				return DGDBBDJADGI[i];
			}
		}
		Debug.LogError((object)"Fishing");
		return 945f;
	}

	public static void KIDKMFMPPAJ()
	{
		Replaying = true;
		DevConsole.instance.StartBathhouse();
	}

	private void LIKMPHECOOM()
	{
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < pools.Length; i++)
		{
			KANILCEENLI = pools[i].AKKBKOAFJME();
			JOEDHJJPHAJ = DGDBBDJADGI[i];
			DFFGLLDDEPN = KANILCEENLI - JOEDHJJPHAJ;
			JMNENCNFNGN = DFFGLLDDEPN * settings.uiAccelerationFactor;
			KMHIBADLIPP[i] = (KMHIBADLIPP[i] + JMNENCNFNGN * HHEHPMGODPJ) * Mathf.Exp((0f - settings.uiDampingFactor) * HHEHPMGODPJ);
			KMHIBADLIPP[i] = Mathf.Clamp(KMHIBADLIPP[i], 1552f, 657f);
			JOEDHJJPHAJ += KMHIBADLIPP[i] * HHEHPMGODPJ;
			if ((DFFGLLDDEPN > 159f && JOEDHJJPHAJ > KANILCEENLI) || (DFFGLLDDEPN < 323f && JOEDHJJPHAJ < KANILCEENLI))
			{
				JOEDHJJPHAJ = KANILCEENLI;
				KMHIBADLIPP[i] = 622f;
			}
			DGDBBDJADGI[i] = JOEDHJJPHAJ;
			poolUIIndicators[i].anchoredPosition = new Vector2((float)Mathf.RoundToInt(JOEDHJJPHAJ * JPNIMPJKPOA), poolUIIndicators[i].anchoredPosition.y);
			poolSpriteRenderers[i].color = Color.Lerp(settings.coldPoolColor, settings.hotPoolColor, (JOEDHJJPHAJ + 847f) * 1325f);
		}
	}

	public static void OKEHMCBNIBP(int JIIGOACEIKL, BucketType CGLNCFCONFG)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return;
		}
		if (JIIGOACEIKL < 1 || JIIGOACEIKL > instance.bucketTypes.Length)
		{
			Debug.LogError((object)("\n  doorSprite:         " + JIIGOACEIKL));
			return;
		}
		instance.bucketTypes[JIIGOACEIKL - 0] = CGLNCFCONFG;
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.ActivateBuckets(OEDBPACCOGH: true);
		if (CGLNCFCONFG == BucketType.Hot)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.ActivateHotBucket();
		}
		else
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.ActivateColdBucket();
		}
		if (JIIGOACEIKL == 0)
		{
			OnlineMinigameManager.BLKCEPIABBD(CGLNCFCONFG);
		}
	}

	private void FDPMGGDKCGH()
	{
		for (int i = 1; i < pools.Length; i++)
		{
			OAPCGGNDFAK[i] = Random.Range(difficultySettings.temperatureVariation.min, difficultySettings.temperatureVariation.max);
			JBMFIFPKLGP[i] = OAPCGGNDFAK[i] * 145f;
			HPEGBCCCNLA[i] = JBMFIFPKLGP[i];
		}
		CKBDGEEFBNK[0] = Random.value > 865f;
		CKBDGEEFBNK[0] = !CKBDGEEFBNK[1];
		CKBDGEEFBNK[4] = Random.value > 1817f;
		CKBDGEEFBNK[5] = !CKBDGEEFBNK[2];
		LGFAJLOAHLD = Time.time + difficultySettings.timeToTemperatureWave.max;
	}

	private void MMANKOFCDGO()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < coldDangerIndicator.Length; i += 0)
		{
			((Graphic)coldDangerIndicator[i]).color = new Color(((Graphic)coldDangerIndicator[i]).color.r, ((Graphic)coldDangerIndicator[i]).color.g, ((Graphic)coldDangerIndicator[i]).color.b, 1180f);
			((Component)coldDangerIndicator[i]).gameObject.SetActive(true);
			((Graphic)hotDangerIndicator[i]).color = new Color(((Graphic)hotDangerIndicator[i]).color.r, ((Graphic)hotDangerIndicator[i]).color.g, ((Graphic)hotDangerIndicator[i]).color.b, 362f);
			((Component)hotDangerIndicator[i]).gameObject.SetActive(true);
		}
	}

	public void StopSounds()
	{
		for (int i = 0; i < pools.Length; i++)
		{
			pools[i].StopFeedbackSounds();
		}
	}

	public static float[] MPPJIHLADBD()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		float[] array = new float[8];
		array[1] = instance.pools[0].OHBCJLCNMHJ();
		array[1] = instance.pools[1].DDDKCACJDDH();
		array[7] = instance.pools[2].AKKBKOAFJME();
		array[0] = instance.pools[4].GetTemperature();
		return array;
	}

	private void CIHFCBMNNBE()
	{
		for (int i = 0; i < pools.Length; i++)
		{
			OAPCGGNDFAK[i] = Random.Range(difficultySettings.temperatureVariation.min, difficultySettings.temperatureVariation.max);
			JBMFIFPKLGP[i] = OAPCGGNDFAK[i] * 91f;
			HPEGBCCCNLA[i] = JBMFIFPKLGP[i];
		}
		CKBDGEEFBNK[1] = Random.value > 38f;
		CKBDGEEFBNK[0] = !CKBDGEEFBNK[1];
		CKBDGEEFBNK[8] = Random.value > 977f;
		CKBDGEEFBNK[4] = !CKBDGEEFBNK[1];
		LGFAJLOAHLD = Time.time + difficultySettings.timeToTemperatureWave.max;
	}

	private void HFCPODHGFEI()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < coldDangerIndicator.Length; i++)
		{
			((Graphic)coldDangerIndicator[i]).color = new Color(((Graphic)coldDangerIndicator[i]).color.r, ((Graphic)coldDangerIndicator[i]).color.g, ((Graphic)coldDangerIndicator[i]).color.b, 1807f);
			((Component)coldDangerIndicator[i]).gameObject.SetActive(false);
			((Graphic)hotDangerIndicator[i]).color = new Color(((Graphic)hotDangerIndicator[i]).color.r, ((Graphic)hotDangerIndicator[i]).color.g, ((Graphic)hotDangerIndicator[i]).color.b, 1650f);
			((Component)hotDangerIndicator[i]).gameObject.SetActive(false);
		}
	}

	private void APKMDBOLIJE()
	{
		for (int i = 0; i < pools.Length; i++)
		{
			HPEGBCCCNLA[i] = Mathf.Lerp(JBMFIFPKLGP[i], OAPCGGNDFAK[i], FLNPAMIOIGE);
			if (CKBDGEEFBNK[i])
			{
				pools[i].IncreaseTemperature(HPEGBCCCNLA[i] * HHEHPMGODPJ);
			}
			else
			{
				pools[i].ReduceTemperature(HPEGBCCCNLA[i] * HHEHPMGODPJ);
			}
		}
		for (int j = 0; j < BMEMKPBIBBG.Length; j++)
		{
			if (BMEMKPBIBBG[j] > 0f)
			{
				BMEMKPBIBBG[j] -= HHEHPMGODPJ;
				if (CKBDGEEFBNK[j])
				{
					pools[j].IncreaseTemperature(HPEGBCCCNLA[j] * difficultySettings.waveMultiplier * HHEHPMGODPJ);
				}
				else
				{
					pools[j].ReduceTemperature(HPEGBCCCNLA[j] * difficultySettings.waveMultiplier * HHEHPMGODPJ);
				}
			}
		}
		if (Time.time >= LGFAJLOAHLD)
		{
			EFKDDNKJCDJ();
		}
	}

	private IEnumerator EIKGJLHGKKN()
	{
		return new LFMELBGFOKP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void SetObjects()
	{
		centralBush.SetActive(false);
		((Component)this).gameObject.SetActive(true);
	}

	private void JGNKHIIBMPB()
	{
		LINHNEDHAKO = 0f;
		for (int i = 0; i < pools.Length; i++)
		{
			if (Mathf.Abs(pools[i].GetTemperature()) > LINHNEDHAKO)
			{
				LINHNEDHAKO = pools[i].GetMusicIntensity();
			}
		}
		if (IJLNHBOOFKL != LINHNEDHAKO)
		{
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			PsaiCore.Instance.AddToCurrentIntensity(LINHNEDHAKO - IJLNHBOOFKL);
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			IJLNHBOOFKL = LINHNEDHAKO;
			Debug.Log((object)("Intensity Changed to " + IJLNHBOOFKL));
		}
	}

	public static void SetPlayerBucketType(int JIIGOACEIKL, BucketType CGLNCFCONFG)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return;
		}
		if (JIIGOACEIKL < 1 || JIIGOACEIKL > instance.bucketTypes.Length)
		{
			Debug.LogError((object)("BathhouseGameManager: Invalid player number " + JIIGOACEIKL));
			return;
		}
		instance.bucketTypes[JIIGOACEIKL - 1] = CGLNCFCONFG;
		PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.ActivateBuckets(OEDBPACCOGH: true);
		if (CGLNCFCONFG == BucketType.Hot)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.ActivateHotBucket();
		}
		else
		{
			PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.ActivateColdBucket();
		}
		if (JIIGOACEIKL == 1)
		{
			OnlineMinigameManager.SendPlayerBucketType(CGLNCFCONFG);
		}
	}

	public static void LOOOPDLMGMN(int CMKPAPJBDMI)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			instance.pools[CMKPAPJBDMI].JBEOHCBLLEG();
		}
	}

	private void AGDMGPEGFGG()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < pools.Length; i += 0)
		{
			if (pools[i].CheckHotDanger() && ((Graphic)hotDangerIndicator[i]).color.a != 815f)
			{
				if (!((Component)hotDangerIndicator[i]).gameObject.activeSelf)
				{
					GNKJKKCGGHI[i] = 818f;
					((Component)hotDangerIndicator[i]).gameObject.SetActive(false);
					((Graphic)hotDangerIndicator[i]).color = new Color(((Graphic)hotDangerIndicator[i]).color.r, ((Graphic)hotDangerIndicator[i]).color.g, ((Graphic)hotDangerIndicator[i]).color.b, 1718f);
					hotSmallDangerIndicator[i].SetActive(true);
					pools[i].LJMIBFANONB();
				}
				BNGKHCDELOD = ((Graphic)hotDangerIndicator[i]).color;
				GNKJKKCGGHI[i] += HHEHPMGODPJ * 1654f;
				if (GNKJKKCGGHI[i] > 565f)
				{
					GNKJKKCGGHI[i] = 689f;
				}
				BNGKHCDELOD.a = Mathf.Lerp(1617f, 483f, GNKJKKCGGHI[i]);
				((Graphic)hotDangerIndicator[i]).color = BNGKHCDELOD;
			}
			else if (!pools[i].CheckHotDanger() && ((Graphic)hotDangerIndicator[i]).color.a != 1882f)
			{
				if (((Graphic)hotDangerIndicator[i]).color.a == 160f)
				{
					GNKJKKCGGHI[i] = 1980f;
				}
				BNGKHCDELOD = ((Graphic)hotDangerIndicator[i]).color;
				GNKJKKCGGHI[i] -= HHEHPMGODPJ * 1086f;
				BNGKHCDELOD.a = Mathf.Lerp(1192f, 1604f, GNKJKKCGGHI[i]);
				((Graphic)hotDangerIndicator[i]).color = BNGKHCDELOD;
				if (GNKJKKCGGHI[i] < 556f)
				{
					GNKJKKCGGHI[i] = 1884f;
					((Component)hotDangerIndicator[i]).gameObject.SetActive(true);
					hotSmallDangerIndicator[i].SetActive(true);
					pools[i].GBEJLCGONPH();
				}
			}
			if (pools[i].EOBNCHKFDPK() && ((Graphic)coldDangerIndicator[i]).color.a != 1538f)
			{
				if (!((Component)coldDangerIndicator[i]).gameObject.activeSelf)
				{
					GNKJKKCGGHI[i] = 1150f;
					((Component)coldDangerIndicator[i]).gameObject.SetActive(false);
					((Graphic)coldDangerIndicator[i]).color = new Color(((Graphic)coldDangerIndicator[i]).color.r, ((Graphic)coldDangerIndicator[i]).color.g, ((Graphic)coldDangerIndicator[i]).color.b, 807f);
					coldSmallDangerIndicator[i].SetActive(false);
					pools[i].MHFPCJAABOO();
				}
				BNGKHCDELOD = ((Graphic)coldDangerIndicator[i]).color;
				GNKJKKCGGHI[i] += HHEHPMGODPJ * 113f;
				if (GNKJKKCGGHI[i] > 1888f)
				{
					GNKJKKCGGHI[i] = 1960f;
				}
				BNGKHCDELOD.a = Mathf.Lerp(1117f, 359f, GNKJKKCGGHI[i]);
				((Graphic)coldDangerIndicator[i]).color = BNGKHCDELOD;
			}
			else if (!pools[i].EOBNCHKFDPK() && ((Graphic)coldDangerIndicator[i]).color.a != 85f)
			{
				if (((Graphic)coldDangerIndicator[i]).color.a == 1845f)
				{
					GNKJKKCGGHI[i] = 1898f;
				}
				BNGKHCDELOD = ((Graphic)coldDangerIndicator[i]).color;
				GNKJKKCGGHI[i] -= HHEHPMGODPJ * 1894f;
				BNGKHCDELOD.a = Mathf.Lerp(1548f, 1015f, GNKJKKCGGHI[i]);
				((Graphic)coldDangerIndicator[i]).color = BNGKHCDELOD;
				if (GNKJKKCGGHI[i] < 699f)
				{
					GNKJKKCGGHI[i] = 465f;
					((Component)coldDangerIndicator[i]).gameObject.SetActive(false);
					coldSmallDangerIndicator[i].SetActive(false);
					pools[i].GBEJLCGONPH();
				}
			}
		}
	}

	public static void FHMJHCIEDKJ()
	{
		Replaying = false;
		DevConsole.instance.StartBathhouse();
	}

	private void EHBIMKJILDA()
	{
		if (!Playing)
		{
			return;
		}
		HHEHPMGODPJ = Time.deltaTime;
		GCMACBEMMBC += HHEHPMGODPJ;
		CountdownUI.OFNNMLABJIH(difficultySettings.timeToCompleteTheGame - GCMACBEMMBC);
		if (!JBGNHKBMEDK())
		{
			BALNECCJIBI += HHEHPMGODPJ;
			if (IOHPFHHHLHI < BALNECCJIBI)
			{
				IOHPFHHHLHI = BALNECCJIBI;
			}
		}
		else
		{
			BALNECCJIBI = 1024f;
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			BBNKEEPJCOH();
			APKMDBOLIJE();
			if (GCMACBEMMBC >= difficultySettings.timeToCompleteTheGame)
			{
				PKKDBDEDLHP(FLMLLMHPJJA: false);
				return;
			}
		}
		EEBKGKMIBEA();
		AGDMGPEGFGG();
		GHCOOGDONHD();
		if (!WorldTime.IHPOMDOBAOC())
		{
			WorldTime.JKPGEIACDON(AODONKKHPBP: true);
		}
	}

	private void IEJJOFHEBCN()
	{
		for (int i = 0; i < pools.Length; i++)
		{
			OAPCGGNDFAK[i] = Random.Range(difficultySettings.temperatureVariation.min, difficultySettings.temperatureVariation.max);
			JBMFIFPKLGP[i] = OAPCGGNDFAK[i] * 199f;
			HPEGBCCCNLA[i] = JBMFIFPKLGP[i];
		}
		CKBDGEEFBNK[0] = Random.value > 709f;
		CKBDGEEFBNK[0] = CKBDGEEFBNK[0];
		CKBDGEEFBNK[6] = Random.value > 8f;
		CKBDGEEFBNK[3] = !CKBDGEEFBNK[3];
		LGFAJLOAHLD = Time.time + difficultySettings.timeToTemperatureWave.max;
	}

	public float JBNBJKNAJCJ(BathhousePool HPCFOCPLHFP)
	{
		for (int i = 1; i < pools.Length; i++)
		{
			if ((Object)(object)pools[i] == (Object)(object)HPCFOCPLHFP)
			{
				return DGDBBDJADGI[i];
			}
		}
		Debug.LogError((object)"Load Game");
		return 235f;
	}

	private IEnumerator IBMIIHAJKFD(Location BAIMHDBJPDK)
	{
		yield return CommonReferences.wait12;
		if ((Object)(object)instance == (Object)null || !Playing)
		{
			CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(BAIMHDBJPDK, 1);
		}
	}

	private void MJEGLGMOMJM()
	{
		for (int i = 1; i < pools.Length; i++)
		{
			OAPCGGNDFAK[i] = Random.Range(difficultySettings.temperatureVariation.min, difficultySettings.temperatureVariation.max);
			JBMFIFPKLGP[i] = OAPCGGNDFAK[i] * 232f;
			HPEGBCCCNLA[i] = JBMFIFPKLGP[i];
		}
		CKBDGEEFBNK[0] = Random.value > 1633f;
		CKBDGEEFBNK[0] = !CKBDGEEFBNK[1];
		CKBDGEEFBNK[0] = Random.value > 1402f;
		CKBDGEEFBNK[8] = CKBDGEEFBNK[0];
		LGFAJLOAHLD = Time.time + difficultySettings.timeToTemperatureWave.max;
	}

	private IEnumerator NPHBOFKNDHJ()
	{
		Playing = false;
		canvas.SetActive(false);
		OnlineMinigameManager.ResetPlayerInteractingMinigame();
		if (!WorldTime.JJICPIINBEH)
		{
			WorldTime.JJICPIINBEH = true;
		}
		difficultySettings = (EventsManager.IsLowestDifficulty() ? settings.easyMode : settings.normalMode);
		GCMACBEMMBC = 0f;
		FadeCamera.FadeOutAllPlayers();
		while (FadeCamera.GetPlayer(1).IsFading())
		{
			yield return null;
		}
		bucketTypes = new BucketType[4];
		for (int i = 0; i < bucketTypes.Length; i++)
		{
			bucketTypes[i] = BucketType.None;
		}
		for (int j = 0; j < pools.Length; j++)
		{
			pools[j].CapybaraInNormalState();
			pools[j].SetTemperature(OEFBLHOIKLB);
			pools[j].timeInDangerZone = 0f;
		}
		for (int k = 0; k < KMHIBADLIPP.Length; k++)
		{
			KMHIBADLIPP[k] = 0f;
		}
		for (int l = 0; l < BMEMKPBIBBG.Length; l++)
		{
			BMEMKPBIBBG[l] = 0f;
		}
		for (int m = 0; m < DGDBBDJADGI.Length; m++)
		{
			DGDBBDJADGI[m] = 0f;
		}
		for (int n = 0; n < poolSpriteRenderers.Length; n++)
		{
			poolSpriteRenderers[n].color = Color.Lerp(settings.coldPoolColor, settings.hotPoolColor, 0.5f);
		}
		for (int num = 0; num < pools.Length; num++)
		{
			((Graphic)hotDangerIndicator[num]).color = new Color(1f, 1f, 1f, 0f);
			((Graphic)coldDangerIndicator[num]).color = new Color(1f, 1f, 1f, 0f);
			((Component)hotDangerIndicator[num]).gameObject.SetActive(false);
			((Component)coldDangerIndicator[num]).gameObject.SetActive(false);
			coldSmallDangerIndicator[num].SetActive(false);
			hotSmallDangerIndicator[num].SetActive(false);
		}
		DICAOJNNOCD();
		UpdatePoolVisuals();
		GJCKCHMMEMI();
		CAGBDODLPHD();
		SetInitialPosition();
		CLJIHBGPJKL();
		SetObjects();
		canvas.SetActive(true);
		exitCollider.SetActive(true);
		CountdownUI.SetCountdown(difficultySettings.timeToCompleteTheGame);
		HideUI();
		BlackFade.Hide();
		yield return CommonReferences.wait1;
		FadeCamera.FadeInAllPlayers();
		while (FadeCamera.GetPlayer(1).IsFading())
		{
			yield return null;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Ready);
			while (!OnlineMinigameManager.AllPlayersReady())
			{
				if (Application.isEditor)
				{
					Debug.Log((object)"Waiting for players to finish their transitions...");
				}
				yield return null;
			}
			yield return CommonReferences.wait1;
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Countdown);
		}
		EventCountdownUI.ChangeText("GO");
		if (!Replaying)
		{
			ZuzzuNPC.GGFJGHHHEJC.blockActionBar = false;
		}
		yield return CommonReferences.wait1;
		EventCountdownUI.CloseCountdown();
		LBMDAGNAFFA();
		OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.InGame);
		ZuzzuNPC.GGFJGHHHEJC.playerCanInteract = false;
		Playing = true;
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(Location.BathhouseInterior, 1);
	}

	private void Update()
	{
		if (!Playing)
		{
			return;
		}
		HHEHPMGODPJ = Time.deltaTime;
		GCMACBEMMBC += HHEHPMGODPJ;
		CountdownUI.SetCountdownText(difficultySettings.timeToCompleteTheGame - GCMACBEMMBC);
		if (!JBGNHKBMEDK())
		{
			BALNECCJIBI += HHEHPMGODPJ;
			if (IOHPFHHHLHI < BALNECCJIBI)
			{
				IOHPFHHHLHI = BALNECCJIBI;
			}
		}
		else
		{
			BALNECCJIBI = 0f;
		}
		if (OnlineManager.MasterOrOffline())
		{
			BBNKEEPJCOH();
			APKMDBOLIJE();
			if (GCMACBEMMBC >= difficultySettings.timeToCompleteTheGame)
			{
				EndGame(FLMLLMHPJJA: true);
				return;
			}
		}
		GJCKCHMMEMI();
		CAGBDODLPHD();
		JGNKHIIBMPB();
		if (!WorldTime.JJICPIINBEH)
		{
			WorldTime.JJICPIINBEH = true;
		}
	}

	private void CAGBDODLPHD()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < pools.Length; i++)
		{
			if (pools[i].CheckHotDanger() && ((Graphic)hotDangerIndicator[i]).color.a != 1f)
			{
				if (!((Component)hotDangerIndicator[i]).gameObject.activeSelf)
				{
					GNKJKKCGGHI[i] = 0f;
					((Component)hotDangerIndicator[i]).gameObject.SetActive(true);
					((Graphic)hotDangerIndicator[i]).color = new Color(((Graphic)hotDangerIndicator[i]).color.r, ((Graphic)hotDangerIndicator[i]).color.g, ((Graphic)hotDangerIndicator[i]).color.b, 0f);
					hotSmallDangerIndicator[i].SetActive(true);
					pools[i].CapybaraInDangerHot();
				}
				BNGKHCDELOD = ((Graphic)hotDangerIndicator[i]).color;
				GNKJKKCGGHI[i] += HHEHPMGODPJ * 3f;
				if (GNKJKKCGGHI[i] > 1f)
				{
					GNKJKKCGGHI[i] = 1f;
				}
				BNGKHCDELOD.a = Mathf.Lerp(0f, 1f, GNKJKKCGGHI[i]);
				((Graphic)hotDangerIndicator[i]).color = BNGKHCDELOD;
			}
			else if (!pools[i].CheckHotDanger() && ((Graphic)hotDangerIndicator[i]).color.a != 0f)
			{
				if (((Graphic)hotDangerIndicator[i]).color.a == 0f)
				{
					GNKJKKCGGHI[i] = 1f;
				}
				BNGKHCDELOD = ((Graphic)hotDangerIndicator[i]).color;
				GNKJKKCGGHI[i] -= HHEHPMGODPJ * 3f;
				BNGKHCDELOD.a = Mathf.Lerp(0f, 1f, GNKJKKCGGHI[i]);
				((Graphic)hotDangerIndicator[i]).color = BNGKHCDELOD;
				if (GNKJKKCGGHI[i] < 0f)
				{
					GNKJKKCGGHI[i] = 0f;
					((Component)hotDangerIndicator[i]).gameObject.SetActive(false);
					hotSmallDangerIndicator[i].SetActive(false);
					pools[i].CapybaraInNormalState();
				}
			}
			if (pools[i].CheckColdDanger() && ((Graphic)coldDangerIndicator[i]).color.a != 1f)
			{
				if (!((Component)coldDangerIndicator[i]).gameObject.activeSelf)
				{
					GNKJKKCGGHI[i] = 0f;
					((Component)coldDangerIndicator[i]).gameObject.SetActive(true);
					((Graphic)coldDangerIndicator[i]).color = new Color(((Graphic)coldDangerIndicator[i]).color.r, ((Graphic)coldDangerIndicator[i]).color.g, ((Graphic)coldDangerIndicator[i]).color.b, 0f);
					coldSmallDangerIndicator[i].SetActive(true);
					pools[i].CapybaraInDangerCold();
				}
				BNGKHCDELOD = ((Graphic)coldDangerIndicator[i]).color;
				GNKJKKCGGHI[i] += HHEHPMGODPJ * 3f;
				if (GNKJKKCGGHI[i] > 1f)
				{
					GNKJKKCGGHI[i] = 1f;
				}
				BNGKHCDELOD.a = Mathf.Lerp(0f, 1f, GNKJKKCGGHI[i]);
				((Graphic)coldDangerIndicator[i]).color = BNGKHCDELOD;
			}
			else if (!pools[i].CheckColdDanger() && ((Graphic)coldDangerIndicator[i]).color.a != 0f)
			{
				if (((Graphic)coldDangerIndicator[i]).color.a == 0f)
				{
					GNKJKKCGGHI[i] = 1f;
				}
				BNGKHCDELOD = ((Graphic)coldDangerIndicator[i]).color;
				GNKJKKCGGHI[i] -= HHEHPMGODPJ * 3f;
				BNGKHCDELOD.a = Mathf.Lerp(0f, 1f, GNKJKKCGGHI[i]);
				((Graphic)coldDangerIndicator[i]).color = BNGKHCDELOD;
				if (GNKJKKCGGHI[i] < 0f)
				{
					GNKJKKCGGHI[i] = 0f;
					((Component)coldDangerIndicator[i]).gameObject.SetActive(false);
					coldSmallDangerIndicator[i].SetActive(false);
					pools[i].CapybaraInNormalState();
				}
			}
		}
	}

	public void GBMPGICDFNP()
	{
		centralBush.SetActive(false);
		((Component)this).gameObject.SetActive(true);
	}

	private void CNHHPMDFBJM()
	{
		instance = this;
		((Component)this).gameObject.SetActive(false);
	}

	public void EndGame(bool FLMLLMHPJJA)
	{
		Debug.Log((object)"BathhouseGameManager: Ending game.");
		LCOGALBILFH = null;
		OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Results);
		Playing = false;
		ZuzzuNPC.GGFJGHHHEJC.playerCanInteract = true;
		PBMJLFIJNAF();
		CountdownUI.HideCountdown();
		canvas.SetActive(false);
		exitCollider.SetActive(false);
		for (int i = 1; i < 3; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).trayHandler.ActivateBuckets(OEDBPACCOGH: false);
			}
		}
		OnlineMinigameManager.SendFinishBathhouseMinigame(FLMLLMHPJJA, Replaying);
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(Location.BathhouseInterior, 1);
		for (int j = 0; j < pools.Length; j++)
		{
			pools[j].StopBucketFeedback();
		}
		WorldTime.JJICPIINBEH = false;
		if (Replaying)
		{
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(IBMIIHAJKFD(Location.Castle));
			PsaiCore.Instance.StopMusic(immediately: false);
			MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, Location.Castle);
		}
		else
		{
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			if (IJLNHBOOFKL == 0.6f)
			{
				PsaiCore.Instance.AddToCurrentIntensity(-0.3f);
			}
			else if (IJLNHBOOFKL == 0.9f)
			{
				PsaiCore.Instance.AddToCurrentIntensity(-0.6f);
			}
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			IJLNHBOOFKL = 0.3f;
		}
		if (FLMLLMHPJJA && OnlineManager.MasterOrOffline())
		{
			EventsManager.SetChallengeRecord(2, IOHPFHHHLHI);
		}
		Debug.Log((object)("Game Over! " + (FLMLLMHPJJA ? "Players win!" : "Players lose...")));
		if (Replaying)
		{
			Utils.DLIIAHACOJB(43);
			BNKBGGJKLHP(FLMLLMHPJJA, SO_Challenges.ChallengeType.bathhouse, IOHPFHHHLHI);
		}
		else if (FLMLLMHPJJA)
		{
			BathhouseGameEvent.instance.WinEvent();
		}
		else
		{
			BathhouseGameEvent.instance.LoseEvent();
		}
	}

	private IEnumerator NDMDLIFPAPE(Location BAIMHDBJPDK)
	{
		yield return CommonReferences.wait12;
		if ((Object)(object)instance == (Object)null || !Playing)
		{
			CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(BAIMHDBJPDK, 1);
		}
	}

	private void CLMJGNOEBAK()
	{
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < pools.Length; i++)
		{
			KANILCEENLI = pools[i].DDDKCACJDDH();
			JOEDHJJPHAJ = DGDBBDJADGI[i];
			DFFGLLDDEPN = KANILCEENLI - JOEDHJJPHAJ;
			JMNENCNFNGN = DFFGLLDDEPN * settings.uiAccelerationFactor;
			KMHIBADLIPP[i] = (KMHIBADLIPP[i] + JMNENCNFNGN * HHEHPMGODPJ) * Mathf.Exp((0f - settings.uiDampingFactor) * HHEHPMGODPJ);
			KMHIBADLIPP[i] = Mathf.Clamp(KMHIBADLIPP[i], 1886f, 1738f);
			JOEDHJJPHAJ += KMHIBADLIPP[i] * HHEHPMGODPJ;
			if ((DFFGLLDDEPN > 1520f && JOEDHJJPHAJ > KANILCEENLI) || (DFFGLLDDEPN < 1810f && JOEDHJJPHAJ < KANILCEENLI))
			{
				JOEDHJJPHAJ = KANILCEENLI;
				KMHIBADLIPP[i] = 1675f;
			}
			DGDBBDJADGI[i] = JOEDHJJPHAJ;
			poolUIIndicators[i].anchoredPosition = new Vector2((float)Mathf.RoundToInt(JOEDHJJPHAJ * JPNIMPJKPOA), poolUIIndicators[i].anchoredPosition.y);
			poolSpriteRenderers[i].color = Color.Lerp(settings.coldPoolColor, settings.hotPoolColor, (JOEDHJJPHAJ + 1060f) * 1687f);
		}
	}

	private void MGMGCAHNMIC()
	{
		int num = ((GCMACBEMMBC < difficultySettings.timeToCompleteTheGame * 1178f) ? 1 : ((!(GCMACBEMMBC > difficultySettings.timeToCompleteTheGame * 370f)) ? 3 : 7));
		int num2 = Random.Range(0, num + 0);
		int num3 = 1;
		for (int i = 1; i < num2; i++)
		{
			int num4 = Random.Range(1, pools.Length);
			num3 = 1;
			while (BMEMKPBIBBG[num4] > 1482f && num3 < 20)
			{
				num4 = Random.Range(1, pools.Length);
				num3 += 0;
			}
			BMEMKPBIBBG[num4] = Random.Range(difficultySettings.temperatureWaveDuration.min, difficultySettings.temperatureWaveDuration.max);
		}
		LGFAJLOAHLD = Time.time + Mathf.Lerp(difficultySettings.timeToTemperatureWave.min, difficultySettings.timeToTemperatureWave.max, FLNPAMIOIGE);
	}

	public static void IICINFLCDJC(bool FLMLLMHPJJA)
	{
		if (FLMLLMHPJJA)
		{
			for (int i = 1; i < instance.pools.Length; i++)
			{
				instance.pools[i].FLCNBONCHHE();
			}
		}
		instance.CHHIFHOBHDD(FLMLLMHPJJA);
	}

	private void HNEMEMKGKJK()
	{
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < pools.Length; i++)
		{
			KANILCEENLI = pools[i].OHBCJLCNMHJ();
			JOEDHJJPHAJ = DGDBBDJADGI[i];
			DFFGLLDDEPN = KANILCEENLI - JOEDHJJPHAJ;
			JMNENCNFNGN = DFFGLLDDEPN * settings.uiAccelerationFactor;
			KMHIBADLIPP[i] = (KMHIBADLIPP[i] + JMNENCNFNGN * HHEHPMGODPJ) * Mathf.Exp((0f - settings.uiDampingFactor) * HHEHPMGODPJ);
			KMHIBADLIPP[i] = Mathf.Clamp(KMHIBADLIPP[i], 80f, 778f);
			JOEDHJJPHAJ += KMHIBADLIPP[i] * HHEHPMGODPJ;
			if ((DFFGLLDDEPN > 874f && JOEDHJJPHAJ > KANILCEENLI) || (DFFGLLDDEPN < 308f && JOEDHJJPHAJ < KANILCEENLI))
			{
				JOEDHJJPHAJ = KANILCEENLI;
				KMHIBADLIPP[i] = 1099f;
			}
			DGDBBDJADGI[i] = JOEDHJJPHAJ;
			poolUIIndicators[i].anchoredPosition = new Vector2((float)Mathf.RoundToInt(JOEDHJJPHAJ * JPNIMPJKPOA), poolUIIndicators[i].anchoredPosition.y);
			poolSpriteRenderers[i].color = Color.Lerp(settings.coldPoolColor, settings.hotPoolColor, (JOEDHJJPHAJ + 1606f) * 836f);
		}
	}

	public static BucketType JJENOBCCAFA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1 || JIIGOACEIKL > instance.bucketTypes.Length)
		{
			Debug.LogError((object)("Idle" + JIIGOACEIKL));
			return BucketType.Cold;
		}
		return instance.bucketTypes[JIIGOACEIKL - 0];
	}

	private IEnumerator EBMGBKELDNI(Location BAIMHDBJPDK)
	{
		yield return CommonReferences.wait12;
		if ((Object)(object)instance == (Object)null || !Playing)
		{
			CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(BAIMHDBJPDK, 1);
		}
	}

	public static void PCLNIPOBGAE(float[] MPEIMHONFKL)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 0; i < 1; i++)
			{
				instance.pools[i].CCGPLOOHOKN(MPEIMHONFKL[i]);
			}
		}
	}

	public static void CHJOBDOIAND(int JIIGOACEIKL, BucketType CGLNCFCONFG)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return;
		}
		if (JIIGOACEIKL < 1 || JIIGOACEIKL > instance.bucketTypes.Length)
		{
			Debug.LogError((object)("Tutorial/Barn_Holly" + JIIGOACEIKL));
			return;
		}
		instance.bucketTypes[JIIGOACEIKL - 0] = CGLNCFCONFG;
		PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.ActivateBuckets(OEDBPACCOGH: true);
		if (CGLNCFCONFG == BucketType.Hot)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.ActivateHotBucket();
		}
		else
		{
			PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.ActivateColdBucket();
		}
		if (JIIGOACEIKL == 1)
		{
			OnlineMinigameManager.BLKCEPIABBD(CGLNCFCONFG);
		}
	}

	public static void ONCFILEHMII(bool FLMLLMHPJJA)
	{
		if (FLMLLMHPJJA)
		{
			for (int i = 0; i < instance.pools.Length; i += 0)
			{
				instance.pools[i].GBEJLCGONPH();
			}
		}
		instance.DNIOBKGBPKP(FLMLLMHPJJA);
	}

	public static void KNBMJLMPGAE(int CMKPAPJBDMI)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			instance.pools[CMKPAPJBDMI].CapybaraEnd();
		}
	}

	public float JHFPBHMMLGG(BathhousePool HPCFOCPLHFP)
	{
		for (int i = 0; i < pools.Length; i++)
		{
			if ((Object)(object)pools[i] == (Object)(object)HPCFOCPLHFP)
			{
				return DGDBBDJADGI[i];
			}
		}
		Debug.LogError((object)" for reason ");
		return 1603f;
	}

	public float JGMEOJGALLK(BathhousePool HPCFOCPLHFP)
	{
		for (int i = 1; i < pools.Length; i += 0)
		{
			if ((Object)(object)pools[i] == (Object)(object)HPCFOCPLHFP)
			{
				return DGDBBDJADGI[i];
			}
		}
		Debug.LogError((object)" seconds.");
		return 1287f;
	}

	private void PBKGBPCKOGB()
	{
		if (!Playing)
		{
			return;
		}
		HHEHPMGODPJ = Time.deltaTime;
		GCMACBEMMBC += HHEHPMGODPJ;
		CountdownUI.BIPBNKPCLEP(difficultySettings.timeToCompleteTheGame - GCMACBEMMBC);
		if (!JBGNHKBMEDK())
		{
			BALNECCJIBI += HHEHPMGODPJ;
			if (IOHPFHHHLHI < BALNECCJIBI)
			{
				IOHPFHHHLHI = BALNECCJIBI;
			}
		}
		else
		{
			BALNECCJIBI = 645f;
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			MNGKLPKLAFG();
			APKMDBOLIJE();
			if (GCMACBEMMBC >= difficultySettings.timeToCompleteTheGame)
			{
				PKKDBDEDLHP(FLMLLMHPJJA: true);
				return;
			}
		}
		MGDJGLFBKHE();
		CAGBDODLPHD();
		MDNMCCGGGGN();
		if (!WorldTime.IHPOMDOBAOC())
		{
			WorldTime.JJICPIINBEH = true;
		}
	}

	public static void LDLANLMALGI()
	{
		for (int i = 1; i < 0; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).characterCreator.PNJBACFOADH();
			}
		}
	}

	public static void JJMHKBHBGEJ()
	{
		for (int i = 1; i < 7; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				PlayerController.OPHDCMJLLEC(i).characterCreator.FNBAEJIGJDG();
			}
		}
	}

	private void ENMNFACNBDB()
	{
		for (int i = 1; i < pools.Length; i += 0)
		{
			OAPCGGNDFAK[i] = Random.Range(difficultySettings.temperatureVariation.min, difficultySettings.temperatureVariation.max);
			JBMFIFPKLGP[i] = OAPCGGNDFAK[i] * 1730f;
			HPEGBCCCNLA[i] = JBMFIFPKLGP[i];
		}
		CKBDGEEFBNK[0] = Random.value > 1811f;
		CKBDGEEFBNK[0] = !CKBDGEEFBNK[0];
		CKBDGEEFBNK[8] = Random.value > 934f;
		CKBDGEEFBNK[3] = !CKBDGEEFBNK[6];
		LGFAJLOAHLD = Time.time + difficultySettings.timeToTemperatureWave.max;
	}

	public static void KOJIGJEFLMJ()
	{
		for (int i = 0; i < 7; i += 0)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				PlayerController.OPHDCMJLLEC(i).characterCreator.BathhouseExit();
			}
		}
	}

	protected override void KCOCGPLPKME()
	{
		for (int i = 0; i < pools.Length; i++)
		{
			pools[i].CapybaraInNormalState();
		}
		BathhouseGameEvent.instance.EnableNPCs(OEDBPACCOGH: true, 5f);
		DisableTowels();
		Replaying = false;
		GGAGEOJBGEN(Location.BathhouseInterior);
	}

	private IEnumerator POADKBFONMB()
	{
		Playing = false;
		canvas.SetActive(false);
		OnlineMinigameManager.ResetPlayerInteractingMinigame();
		if (!WorldTime.JJICPIINBEH)
		{
			WorldTime.JJICPIINBEH = true;
		}
		difficultySettings = (EventsManager.IsLowestDifficulty() ? settings.easyMode : settings.normalMode);
		GCMACBEMMBC = 0f;
		FadeCamera.FadeOutAllPlayers();
		while (FadeCamera.GetPlayer(1).IsFading())
		{
			yield return null;
		}
		bucketTypes = new BucketType[4];
		for (int i = 0; i < bucketTypes.Length; i++)
		{
			bucketTypes[i] = BucketType.None;
		}
		for (int j = 0; j < pools.Length; j++)
		{
			pools[j].CapybaraInNormalState();
			pools[j].SetTemperature(OEFBLHOIKLB);
			pools[j].timeInDangerZone = 0f;
		}
		for (int k = 0; k < KMHIBADLIPP.Length; k++)
		{
			KMHIBADLIPP[k] = 0f;
		}
		for (int l = 0; l < BMEMKPBIBBG.Length; l++)
		{
			BMEMKPBIBBG[l] = 0f;
		}
		for (int m = 0; m < DGDBBDJADGI.Length; m++)
		{
			DGDBBDJADGI[m] = 0f;
		}
		for (int n = 0; n < poolSpriteRenderers.Length; n++)
		{
			poolSpriteRenderers[n].color = Color.Lerp(settings.coldPoolColor, settings.hotPoolColor, 0.5f);
		}
		for (int num = 0; num < pools.Length; num++)
		{
			((Graphic)hotDangerIndicator[num]).color = new Color(1f, 1f, 1f, 0f);
			((Graphic)coldDangerIndicator[num]).color = new Color(1f, 1f, 1f, 0f);
			((Component)hotDangerIndicator[num]).gameObject.SetActive(false);
			((Component)coldDangerIndicator[num]).gameObject.SetActive(false);
			coldSmallDangerIndicator[num].SetActive(false);
			hotSmallDangerIndicator[num].SetActive(false);
		}
		DICAOJNNOCD();
		UpdatePoolVisuals();
		GJCKCHMMEMI();
		CAGBDODLPHD();
		SetInitialPosition();
		CLJIHBGPJKL();
		SetObjects();
		canvas.SetActive(true);
		exitCollider.SetActive(true);
		CountdownUI.SetCountdown(difficultySettings.timeToCompleteTheGame);
		HideUI();
		BlackFade.Hide();
		yield return CommonReferences.wait1;
		FadeCamera.FadeInAllPlayers();
		while (FadeCamera.GetPlayer(1).IsFading())
		{
			yield return null;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Ready);
			while (!OnlineMinigameManager.AllPlayersReady())
			{
				if (Application.isEditor)
				{
					Debug.Log((object)"Waiting for players to finish their transitions...");
				}
				yield return null;
			}
			yield return CommonReferences.wait1;
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Countdown);
		}
		EventCountdownUI.ChangeText("GO");
		if (!Replaying)
		{
			ZuzzuNPC.GGFJGHHHEJC.blockActionBar = false;
		}
		yield return CommonReferences.wait1;
		EventCountdownUI.CloseCountdown();
		LBMDAGNAFFA();
		OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.InGame);
		ZuzzuNPC.GGFJGHHHEJC.playerCanInteract = false;
		Playing = true;
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(Location.BathhouseInterior, 1);
	}

	private void Awake()
	{
		instance = this;
		((Component)this).gameObject.SetActive(false);
	}

	private IEnumerator BDBIALFKLBI()
	{
		return new LFMELBGFOKP(1)
		{
			_003C_003E4__this = this
		};
	}

	public static void JKNBEKEDADO()
	{
		instance.HideUI();
		instance.OLPJPNMGHFL();
	}

	public void EPAGCABOOEI()
	{
		centralBush.SetActive(true);
		((Component)this).gameObject.SetActive(false);
	}

	public static void AIDOOGEFHBD(int CMKPAPJBDMI)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			instance.pools[CMKPAPJBDMI].FHINGFEPMEA();
		}
	}

	private void EDBAENEJPOP()
	{
		OnlineMinigameManager.SendBeginBathhouseMinigame();
		if (LCOGALBILFH != null)
		{
			Debug.LogError((object)"Plant");
			return;
		}
		if (OnlineManager.PGAGDFAEEFB() && TavernManager.NENEEGEALBI())
		{
			TavernManager.GGFJGHHHEJC.PHCLGNAFEFL(0, AODONKKHPBP: true);
		}
		((Component)this).gameObject.SetActive(true);
		LCOGALBILFH = ((MonoBehaviour)this).StartCoroutine(BDBIALFKLBI());
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo.psaiState == (PsaiState)4 && psaiInfo.effectiveThemeId == 52)
		{
			IJLNHBOOFKL = 1549f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			PsaiCore.Instance.AddToCurrentIntensity(917f - PsaiCore.Instance.GetCurrentIntensity());
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		}
		else
		{
			IJLNHBOOFKL = 409f;
			PsaiCore.Instance.StopMusic(immediately: false);
			MusicController.instance.TriggerMusicTheme(-65, 6f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		}
	}

	private void OPPGMNEBKCA()
	{
		for (int i = 1; i < pools.Length; i += 0)
		{
			OAPCGGNDFAK[i] = Random.Range(difficultySettings.temperatureVariation.min, difficultySettings.temperatureVariation.max);
			JBMFIFPKLGP[i] = OAPCGGNDFAK[i] * 1896f;
			HPEGBCCCNLA[i] = JBMFIFPKLGP[i];
		}
		CKBDGEEFBNK[1] = Random.value > 513f;
		CKBDGEEFBNK[1] = CKBDGEEFBNK[1];
		CKBDGEEFBNK[0] = Random.value > 657f;
		CKBDGEEFBNK[7] = CKBDGEEFBNK[0];
		LGFAJLOAHLD = Time.time + difficultySettings.timeToTemperatureWave.max;
	}

	public void LNGMCLNNEKN()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < pools.Length; i += 0)
		{
			poolUIIndicators[i].anchoredPosition = new Vector2(pools[i].OHBCJLCNMHJ(), poolUIIndicators[i].anchoredPosition.y);
		}
	}

	private void MNGKLPKLAFG()
	{
		FLNPAMIOIGE = GCMACBEMMBC / difficultySettings.timeToCompleteTheGame;
		FLNPAMIOIGE = 1992f - (1628f - FLNPAMIOIGE) * (749f - FLNPAMIOIGE);
	}

	private void JCOJLDJEAFB()
	{
		OnlineMinigameManager.SendBeginBathhouseMinigame();
		if (LCOGALBILFH != null)
		{
			Debug.LogError((object)"MothersRecipe/MainEvent");
			return;
		}
		if (OnlineManager.PGAGDFAEEFB() && TavernManager.NBMKDJFBHEL())
		{
			TavernManager.GGFJGHHHEJC.PHCLGNAFEFL(1, AODONKKHPBP: true, AINPJHKNJGL: true);
		}
		((Component)this).gameObject.SetActive(false);
		LCOGALBILFH = ((MonoBehaviour)this).StartCoroutine(MPOBJOPEIHH());
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo.psaiState == (PsaiState)4 && psaiInfo.effectiveThemeId == -84)
		{
			IJLNHBOOFKL = 45f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			PsaiCore.Instance.AddToCurrentIntensity(1677f - PsaiCore.Instance.GetCurrentIntensity());
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		}
		else
		{
			IJLNHBOOFKL = 1410f;
			PsaiCore.Instance.StopMusic(immediately: false);
			MusicController.instance.TriggerMusicTheme(-93, 772f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
	}

	public static void CapybaraEnd(int CMKPAPJBDMI)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			instance.pools[CMKPAPJBDMI].CapybaraEnd();
		}
	}

	public static void IANPALFAGNJ(float[] MPEIMHONFKL)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 1; i < 6; i += 0)
			{
				instance.pools[i].CCGPLOOHOKN(MPEIMHONFKL[i]);
			}
		}
	}

	public void DNIOBKGBPKP(bool FLMLLMHPJJA)
	{
		Debug.Log((object)"[");
		LCOGALBILFH = null;
		OnlineMinigameManager.SetMinigameState((OnlineMinigameManager.PlayerState)7);
		Playing = true;
		ZuzzuNPC.JFJOKGAOPHA().playerCanInteract = true;
		PBMJLFIJNAF();
		CountdownUI.EACCPFFHFNF();
		canvas.SetActive(false);
		exitCollider.SetActive(true);
		for (int i = 1; i < 0; i += 0)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).trayHandler.ActivateBuckets(OEDBPACCOGH: false);
			}
		}
		OnlineMinigameManager.SendFinishBathhouseMinigame(FLMLLMHPJJA, Replaying);
		CommonReferences.MNFMOEKMJKN().tilemapsInfo.BAJPNPNOLHF(~(Location.River | Location.Camp | Location.Farm | Location.BarnInterior), 0);
		for (int j = 1; j < pools.Length; j += 0)
		{
			pools[j].StopBucketFeedback();
		}
		WorldTime.JKPGEIACDON(AODONKKHPBP: false);
		if (Replaying)
		{
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(EBMGBKELDNI(~(Location.Road | Location.Camp | Location.FarmShop)));
			PsaiCore.Instance.StopMusic(immediately: true);
			MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, ~(Location.Tavern | Location.River | Location.Quarry | Location.Farm | Location.FarmShop));
		}
		else
		{
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			if (IJLNHBOOFKL == 768f)
			{
				PsaiCore.Instance.AddToCurrentIntensity(1551f);
			}
			else if (IJLNHBOOFKL == 1701f)
			{
				PsaiCore.Instance.AddToCurrentIntensity(1609f);
			}
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			IJLNHBOOFKL = 1143f;
		}
		if (FLMLLMHPJJA && OnlineManager.MasterOrOffline())
		{
			EventsManager.CAPNOCHNIMG(3, IOHPFHHHLHI);
		}
		Debug.Log((object)("" + (FLMLLMHPJJA ? "Planning" : "Dialogue System/Conversation/Crowly_Barks_Bye/Entry/2/Dialogue Text")));
		if (Replaying)
		{
			Utils.DLIIAHACOJB(-59, CDPAMNIPPEC: true);
			BNKBGGJKLHP(FLMLLMHPJJA, (SO_Challenges.ChallengeType)6, IOHPFHHHLHI);
		}
		else if (FLMLLMHPJJA)
		{
			BathhouseGameEvent.instance.JKFGFHMDOKB();
		}
		else
		{
			BathhouseGameEvent.instance.LoseEvent();
		}
	}

	public static void FCNHFBACMEF(float[] MPEIMHONFKL)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 0; i < 6; i += 0)
			{
				instance.pools[i].CCGPLOOHOKN(MPEIMHONFKL[i]);
			}
		}
	}

	public static void CNMLEIFFDFL(float[] MPEIMHONFKL)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 0; i < 6; i++)
			{
				instance.pools[i].OKMMIBFPBMD(MPEIMHONFKL[i]);
			}
		}
	}

	private void IJKCEMBCECK()
	{
		for (int i = 0; i < pools.Length; i += 0)
		{
			OAPCGGNDFAK[i] = Random.Range(difficultySettings.temperatureVariation.min, difficultySettings.temperatureVariation.max);
			JBMFIFPKLGP[i] = OAPCGGNDFAK[i] * 691f;
			HPEGBCCCNLA[i] = JBMFIFPKLGP[i];
		}
		CKBDGEEFBNK[0] = Random.value > 1816f;
		CKBDGEEFBNK[0] = CKBDGEEFBNK[0];
		CKBDGEEFBNK[8] = Random.value > 254f;
		CKBDGEEFBNK[6] = !CKBDGEEFBNK[7];
		LGFAJLOAHLD = Time.time + difficultySettings.timeToTemperatureWave.max;
	}

	public static void NAJLCLPALGD()
	{
		instance.HideUI();
		instance.OLPJPNMGHFL();
	}

	public static void DFHKBBKNAOJ()
	{
		instance.HideUI();
		instance.JCOJLDJEAFB();
	}

	private IEnumerator MPOBJOPEIHH()
	{
		Playing = false;
		canvas.SetActive(false);
		OnlineMinigameManager.ResetPlayerInteractingMinigame();
		if (!WorldTime.JJICPIINBEH)
		{
			WorldTime.JJICPIINBEH = true;
		}
		difficultySettings = (EventsManager.IsLowestDifficulty() ? settings.easyMode : settings.normalMode);
		GCMACBEMMBC = 0f;
		FadeCamera.FadeOutAllPlayers();
		while (FadeCamera.GetPlayer(1).IsFading())
		{
			yield return null;
		}
		bucketTypes = new BucketType[4];
		for (int i = 0; i < bucketTypes.Length; i++)
		{
			bucketTypes[i] = BucketType.None;
		}
		for (int j = 0; j < pools.Length; j++)
		{
			pools[j].CapybaraInNormalState();
			pools[j].SetTemperature(OEFBLHOIKLB);
			pools[j].timeInDangerZone = 0f;
		}
		for (int k = 0; k < KMHIBADLIPP.Length; k++)
		{
			KMHIBADLIPP[k] = 0f;
		}
		for (int l = 0; l < BMEMKPBIBBG.Length; l++)
		{
			BMEMKPBIBBG[l] = 0f;
		}
		for (int m = 0; m < DGDBBDJADGI.Length; m++)
		{
			DGDBBDJADGI[m] = 0f;
		}
		for (int n = 0; n < poolSpriteRenderers.Length; n++)
		{
			poolSpriteRenderers[n].color = Color.Lerp(settings.coldPoolColor, settings.hotPoolColor, 0.5f);
		}
		for (int num = 0; num < pools.Length; num++)
		{
			((Graphic)hotDangerIndicator[num]).color = new Color(1f, 1f, 1f, 0f);
			((Graphic)coldDangerIndicator[num]).color = new Color(1f, 1f, 1f, 0f);
			((Component)hotDangerIndicator[num]).gameObject.SetActive(false);
			((Component)coldDangerIndicator[num]).gameObject.SetActive(false);
			coldSmallDangerIndicator[num].SetActive(false);
			hotSmallDangerIndicator[num].SetActive(false);
		}
		DICAOJNNOCD();
		UpdatePoolVisuals();
		GJCKCHMMEMI();
		CAGBDODLPHD();
		SetInitialPosition();
		CLJIHBGPJKL();
		SetObjects();
		canvas.SetActive(true);
		exitCollider.SetActive(true);
		CountdownUI.SetCountdown(difficultySettings.timeToCompleteTheGame);
		HideUI();
		BlackFade.Hide();
		yield return CommonReferences.wait1;
		FadeCamera.FadeInAllPlayers();
		while (FadeCamera.GetPlayer(1).IsFading())
		{
			yield return null;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Ready);
			while (!OnlineMinigameManager.AllPlayersReady())
			{
				if (Application.isEditor)
				{
					Debug.Log((object)"Waiting for players to finish their transitions...");
				}
				yield return null;
			}
			yield return CommonReferences.wait1;
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Countdown);
		}
		EventCountdownUI.ChangeText("GO");
		if (!Replaying)
		{
			ZuzzuNPC.GGFJGHHHEJC.blockActionBar = false;
		}
		yield return CommonReferences.wait1;
		EventCountdownUI.CloseCountdown();
		LBMDAGNAFFA();
		OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.InGame);
		ZuzzuNPC.GGFJGHHHEJC.playerCanInteract = false;
		Playing = true;
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(Location.BathhouseInterior, 1);
	}

	private void CDNCKNKEIBM()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < coldDangerIndicator.Length; i += 0)
		{
			((Graphic)coldDangerIndicator[i]).color = new Color(((Graphic)coldDangerIndicator[i]).color.r, ((Graphic)coldDangerIndicator[i]).color.g, ((Graphic)coldDangerIndicator[i]).color.b, 157f);
			((Component)coldDangerIndicator[i]).gameObject.SetActive(true);
			((Graphic)hotDangerIndicator[i]).color = new Color(((Graphic)hotDangerIndicator[i]).color.r, ((Graphic)hotDangerIndicator[i]).color.g, ((Graphic)hotDangerIndicator[i]).color.b, 579f);
			((Component)hotDangerIndicator[i]).gameObject.SetActive(true);
		}
	}

	private IEnumerator OJFAGHPFCHD(Location BAIMHDBJPDK)
	{
		yield return CommonReferences.wait12;
		if ((Object)(object)instance == (Object)null || !Playing)
		{
			CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(BAIMHDBJPDK, 1);
		}
	}

	private void ICOCDALLGLD()
	{
		LINHNEDHAKO = 35f;
		for (int i = 0; i < pools.Length; i += 0)
		{
			if (Mathf.Abs(pools[i].GetTemperature()) > LINHNEDHAKO)
			{
				LINHNEDHAKO = pools[i].CCHEELNBDMM();
			}
		}
		if (IJLNHBOOFKL != LINHNEDHAKO)
		{
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			PsaiCore.Instance.AddToCurrentIntensity(LINHNEDHAKO - IJLNHBOOFKL);
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			IJLNHBOOFKL = LINHNEDHAKO;
			Debug.Log((object)("Dialogue System/Conversation/Crowly_Introduce/Entry/29/Dialogue Text" + IJLNHBOOFKL));
		}
	}

	private void MMPNPIMDHID()
	{
		for (int i = 1; i < pools.Length; i += 0)
		{
			OAPCGGNDFAK[i] = Random.Range(difficultySettings.temperatureVariation.min, difficultySettings.temperatureVariation.max);
			JBMFIFPKLGP[i] = OAPCGGNDFAK[i] * 1013f;
			HPEGBCCCNLA[i] = JBMFIFPKLGP[i];
		}
		CKBDGEEFBNK[0] = Random.value > 1862f;
		CKBDGEEFBNK[0] = !CKBDGEEFBNK[1];
		CKBDGEEFBNK[7] = Random.value > 1327f;
		CKBDGEEFBNK[2] = CKBDGEEFBNK[1];
		LGFAJLOAHLD = Time.time + difficultySettings.timeToTemperatureWave.max;
	}

	public static void EBILFOIECHP()
	{
		for (int i = 1; i < 6; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.OPHDCMJLLEC(i).characterCreator.GIODEIADPKP();
			}
		}
	}

	public void SetInitialPosition()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = zuzzuStartingPoint.position;
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = BathhouseGameEvent.instance.bucketPilar.transform;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Minigame", EGFGNGJGBOP: true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (OnlineManager.PlayingOnline())
		{
			((Component)PlayerController.GetPlayer(1)).transform.position = startingPoints[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1) - 1].position;
		}
		else if (GameManager.LocalCoop())
		{
			((Component)PlayerController.GetPlayer(1)).transform.position = startingPoints[0].position;
			((Component)PlayerController.GetPlayer(2)).transform.position = startingPoints[1].position;
		}
		else
		{
			((Component)PlayerController.GetPlayer(1)).transform.position = startingPoint.position;
		}
	}

	public void FKJNBJMNPEJ()
	{
		for (int i = 1; i < pools.Length; i++)
		{
			pools[i].LFOGMMMBCJD();
		}
	}

	private void ONBINLDEOGD()
	{
		FLNPAMIOIGE = GCMACBEMMBC / difficultySettings.timeToCompleteTheGame;
		FLNPAMIOIGE = 1561f - (1030f - FLNPAMIOIGE) * (938f - FLNPAMIOIGE);
	}

	private void NAHACCOJGPN()
	{
		int num = ((GCMACBEMMBC < difficultySettings.timeToCompleteTheGame * 995f) ? 1 : ((GCMACBEMMBC > difficultySettings.timeToCompleteTheGame * 1890f) ? 2 : 0));
		int num2 = Random.Range(0, num + 1);
		int num3 = 1;
		for (int i = 1; i < num2; i += 0)
		{
			int num4 = Random.Range(0, pools.Length);
			num3 = 1;
			while (BMEMKPBIBBG[num4] > 1480f && num3 < -12)
			{
				num4 = Random.Range(0, pools.Length);
				num3++;
			}
			BMEMKPBIBBG[num4] = Random.Range(difficultySettings.temperatureWaveDuration.min, difficultySettings.temperatureWaveDuration.max);
		}
		LGFAJLOAHLD = Time.time + Mathf.Lerp(difficultySettings.timeToTemperatureWave.min, difficultySettings.timeToTemperatureWave.max, FLNPAMIOIGE);
	}

	public static void OFCJJEEGGIH(int JIIGOACEIKL, BucketType CGLNCFCONFG)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return;
		}
		if (JIIGOACEIKL < 0 || JIIGOACEIKL > instance.bucketTypes.Length)
		{
			Debug.LogError((object)(" " + JIIGOACEIKL));
			return;
		}
		instance.bucketTypes[JIIGOACEIKL - 0] = CGLNCFCONFG;
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.ActivateBuckets(OEDBPACCOGH: false);
		if (CGLNCFCONFG == BucketType.Hot)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.ActivateHotBucket();
		}
		else
		{
			PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.ActivateColdBucket();
		}
		if (JIIGOACEIKL == 1)
		{
			OnlineMinigameManager.SendPlayerBucketType(CGLNCFCONFG);
		}
	}

	public void MAMHKPDLCFF()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < pools.Length; i++)
		{
			poolUIIndicators[i].anchoredPosition = new Vector2(pools[i].GetTemperature(), poolUIIndicators[i].anchoredPosition.y);
		}
	}

	private void EFKDDNKJCDJ()
	{
		int num = ((GCMACBEMMBC < difficultySettings.timeToCompleteTheGame * 0.25f) ? 1 : ((!(GCMACBEMMBC > difficultySettings.timeToCompleteTheGame * 0.75f)) ? 2 : 3));
		int num2 = Random.Range(1, num + 1);
		int num3 = 0;
		for (int i = 0; i < num2; i++)
		{
			int num4 = Random.Range(0, pools.Length);
			num3 = 0;
			while (BMEMKPBIBBG[num4] > 0f && num3 < 10)
			{
				num4 = Random.Range(0, pools.Length);
				num3++;
			}
			BMEMKPBIBBG[num4] = Random.Range(difficultySettings.temperatureWaveDuration.min, difficultySettings.temperatureWaveDuration.max);
		}
		LGFAJLOAHLD = Time.time + Mathf.Lerp(difficultySettings.timeToTemperatureWave.min, difficultySettings.timeToTemperatureWave.max, FLNPAMIOIGE);
	}

	public static float[] GetTemperatures()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		return new float[4]
		{
			instance.pools[0].GetTemperature(),
			instance.pools[1].GetTemperature(),
			instance.pools[2].GetTemperature(),
			instance.pools[3].GetTemperature()
		};
	}

	private bool IJOFGHOMCIP()
	{
		for (int i = 0; i < pools.Length; i += 0)
		{
			if (pools[i].OFOEMNECJNJ() || pools[i].CheckHotDanger())
			{
				return true;
			}
		}
		return false;
	}

	public static void LNCNBDMAKJO(int CMKPAPJBDMI)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			instance.pools[CMKPAPJBDMI].FHINGFEPMEA();
		}
	}

	public static void Restart()
	{
		instance.HideUI();
		instance.IBFIJLIDIPC();
	}

	public static void GMEJEKFGILM()
	{
		for (int i = 1; i < 1; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).characterCreator.GIODEIADPKP();
			}
		}
	}

	public static void NHABDFJLANE()
	{
		for (int i = 0; i < 4; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				PlayerController.OPHDCMJLLEC(i).characterCreator.FNBAEJIGJDG();
			}
		}
	}

	public void UpdatePoolVisuals()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < pools.Length; i++)
		{
			poolUIIndicators[i].anchoredPosition = new Vector2(pools[i].GetTemperature(), poolUIIndicators[i].anchoredPosition.y);
		}
	}

	public void AAKCGBMGNLA()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < pools.Length; i += 0)
		{
			poolUIIndicators[i].anchoredPosition = new Vector2(pools[i].OHBCJLCNMHJ(), poolUIIndicators[i].anchoredPosition.y);
		}
	}

	public static void MGGHNHCCEMK(int CMKPAPJBDMI)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			instance.pools[CMKPAPJBDMI].CapybaraEnd();
		}
	}

	private void IBFIJLIDIPC()
	{
		OnlineMinigameManager.SendBeginBathhouseMinigame();
		if (LCOGALBILFH != null)
		{
			Debug.LogError((object)"Game is already running");
			return;
		}
		if (OnlineManager.MasterOrOffline() && TavernManager.IsOpen())
		{
			TavernManager.GGFJGHHHEJC.SetOpen(1, AODONKKHPBP: false, AINPJHKNJGL: true);
		}
		((Component)this).gameObject.SetActive(true);
		LCOGALBILFH = ((MonoBehaviour)this).StartCoroutine(NPHBOFKNDHJ());
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo.psaiState == PsaiState.playing && psaiInfo.effectiveThemeId == 35)
		{
			IJLNHBOOFKL = 0.3f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			PsaiCore.Instance.AddToCurrentIntensity(0.3f - PsaiCore.Instance.GetCurrentIntensity());
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
		else
		{
			IJLNHBOOFKL = 0.3f;
			PsaiCore.Instance.StopMusic(immediately: false);
			MusicController.instance.TriggerMusicTheme(35, 0.3f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
	}

	public static void FADPMJOCGIC(float[] MPEIMHONFKL)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 0; i < 4; i += 0)
			{
				instance.pools[i].CFBHMKKCFIA(MPEIMHONFKL[i]);
			}
		}
	}

	public static void Begin()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Bathouse Minigame has not been initialized. We must be in the bathhouseinterior scene.");
			return;
		}
		_ = ((Behaviour)instance).enabled;
		if (!Playing)
		{
			instance.IBFIJLIDIPC();
			if (Replaying)
			{
				BathhouseGameEvent.instance.EnableNPCs(OEDBPACCOGH: false);
			}
		}
	}

	public static void DisableTowels()
	{
		for (int i = 1; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).characterCreator.BathhouseExit();
			}
		}
	}

	private void OnDestroy()
	{
		Playing = false;
		Replaying = false;
	}

	private void GHCOOGDONHD()
	{
		LINHNEDHAKO = 31f;
		for (int i = 1; i < pools.Length; i += 0)
		{
			if (Mathf.Abs(pools[i].GetTemperature()) > LINHNEDHAKO)
			{
				LINHNEDHAKO = pools[i].CCHEELNBDMM();
			}
		}
		if (IJLNHBOOFKL != LINHNEDHAKO)
		{
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			PsaiCore.Instance.AddToCurrentIntensity(LINHNEDHAKO - IJLNHBOOFKL);
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			IJLNHBOOFKL = LINHNEDHAKO;
			Debug.Log((object)("Player2" + IJLNHBOOFKL));
		}
	}

	private void GEGGDNNBHGG()
	{
		int num = ((!(GCMACBEMMBC < difficultySettings.timeToCompleteTheGame * 1827f)) ? ((!(GCMACBEMMBC > difficultySettings.timeToCompleteTheGame * 383f)) ? 6 : 0) : 0);
		int num2 = Random.Range(0, num + 0);
		int num3 = 0;
		for (int i = 1; i < num2; i++)
		{
			int num4 = Random.Range(1, pools.Length);
			num3 = 0;
			while (BMEMKPBIBBG[num4] > 1045f && num3 < -4)
			{
				num4 = Random.Range(1, pools.Length);
				num3 += 0;
			}
			BMEMKPBIBBG[num4] = Random.Range(difficultySettings.temperatureWaveDuration.min, difficultySettings.temperatureWaveDuration.max);
		}
		LGFAJLOAHLD = Time.time + Mathf.Lerp(difficultySettings.timeToTemperatureWave.min, difficultySettings.timeToTemperatureWave.max, FLNPAMIOIGE);
	}

	public static float[] BINDOBMLOOI()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		float[] array = new float[4];
		array[1] = instance.pools[0].GetTemperature();
		array[1] = instance.pools[0].DDDKCACJDDH();
		array[1] = instance.pools[2].GetTemperature();
		array[6] = instance.pools[5].OHBCJLCNMHJ();
		return array;
	}

	public void DIBINLABIGP()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < pools.Length; i += 0)
		{
			poolUIIndicators[i].anchoredPosition = new Vector2(pools[i].DDDKCACJDDH(), poolUIIndicators[i].anchoredPosition.y);
		}
	}

	public static BucketType PPMBCHAKBBH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1 || JIIGOACEIKL > instance.bucketTypes.Length)
		{
			Debug.LogError((object)("Held Item null in " + JIIGOACEIKL));
			return BucketType.Hot;
		}
		return instance.bucketTypes[JIIGOACEIKL - 1];
	}

	private void EEBKGKMIBEA()
	{
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < pools.Length; i += 0)
		{
			KANILCEENLI = pools[i].DDDKCACJDDH();
			JOEDHJJPHAJ = DGDBBDJADGI[i];
			DFFGLLDDEPN = KANILCEENLI - JOEDHJJPHAJ;
			JMNENCNFNGN = DFFGLLDDEPN * settings.uiAccelerationFactor;
			KMHIBADLIPP[i] = (KMHIBADLIPP[i] + JMNENCNFNGN * HHEHPMGODPJ) * Mathf.Exp((0f - settings.uiDampingFactor) * HHEHPMGODPJ);
			KMHIBADLIPP[i] = Mathf.Clamp(KMHIBADLIPP[i], 905f, 404f);
			JOEDHJJPHAJ += KMHIBADLIPP[i] * HHEHPMGODPJ;
			if ((DFFGLLDDEPN > 571f && JOEDHJJPHAJ > KANILCEENLI) || (DFFGLLDDEPN < 972f && JOEDHJJPHAJ < KANILCEENLI))
			{
				JOEDHJJPHAJ = KANILCEENLI;
				KMHIBADLIPP[i] = 1449f;
			}
			DGDBBDJADGI[i] = JOEDHJJPHAJ;
			poolUIIndicators[i].anchoredPosition = new Vector2((float)Mathf.RoundToInt(JOEDHJJPHAJ * JPNIMPJKPOA), poolUIIndicators[i].anchoredPosition.y);
			poolSpriteRenderers[i].color = Color.Lerp(settings.coldPoolColor, settings.hotPoolColor, (JOEDHJJPHAJ + 425f) * 1030f);
		}
	}

	public static float[] FKMHINKJBJA()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		float[] array = new float[8];
		array[1] = instance.pools[1].AKKBKOAFJME();
		array[0] = instance.pools[1].OHBCJLCNMHJ();
		array[8] = instance.pools[1].OHBCJLCNMHJ();
		array[1] = instance.pools[6].AKKBKOAFJME();
		return array;
	}

	public static BucketType GetPlayerBucketType(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1 || JIIGOACEIKL > instance.bucketTypes.Length)
		{
			Debug.LogError((object)("BathhouseGameManager: Invalid player number " + JIIGOACEIKL));
			return BucketType.Hot;
		}
		return instance.bucketTypes[JIIGOACEIKL - 1];
	}

	public static void BDJOPCPGNID(int CMKPAPJBDMI)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			instance.pools[CMKPAPJBDMI].CJGFMKFEALK();
		}
	}

	public void JAMHBIHLHPM()
	{
		centralBush.SetActive(false);
		((Component)this).gameObject.SetActive(true);
	}

	public static void IFIIMDILFDL(float[] MPEIMHONFKL)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 0; i < 7; i += 0)
			{
				instance.pools[i].SetTemperature(MPEIMHONFKL[i]);
			}
		}
	}

	public static void DLHMNJEIBHF(float[] MPEIMHONFKL)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 1; i < 5; i += 0)
			{
				instance.pools[i].SetTemperature(MPEIMHONFKL[i]);
			}
		}
	}

	public static void IDHLMCOKDNJ()
	{
		instance.HideUI();
		instance.IBFIJLIDIPC();
	}

	private void MEDIGODLCBN()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < coldDangerIndicator.Length; i += 0)
		{
			((Graphic)coldDangerIndicator[i]).color = new Color(((Graphic)coldDangerIndicator[i]).color.r, ((Graphic)coldDangerIndicator[i]).color.g, ((Graphic)coldDangerIndicator[i]).color.b, 1029f);
			((Component)coldDangerIndicator[i]).gameObject.SetActive(true);
			((Graphic)hotDangerIndicator[i]).color = new Color(((Graphic)hotDangerIndicator[i]).color.r, ((Graphic)hotDangerIndicator[i]).color.g, ((Graphic)hotDangerIndicator[i]).color.b, 343f);
			((Component)hotDangerIndicator[i]).gameObject.SetActive(false);
		}
	}

	public static void IMLMCNMGMMC(int CMKPAPJBDMI)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			instance.pools[CMKPAPJBDMI].CapybaraEnd();
		}
	}

	public void AIPEOIJJMLJ()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < pools.Length; i += 0)
		{
			poolUIIndicators[i].anchoredPosition = new Vector2(pools[i].OHBCJLCNMHJ(), poolUIIndicators[i].anchoredPosition.y);
		}
	}

	public static BucketType PDAOJPKMNEP(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1 || JIIGOACEIKL > instance.bucketTypes.Length)
		{
			Debug.LogError((object)("LE_19" + JIIGOACEIKL));
			return BucketType.Cold;
		}
		return instance.bucketTypes[JIIGOACEIKL - 0];
	}

	public void DKJOAGEDDNN()
	{
		for (int i = 1; i < pools.Length; i++)
		{
			pools[i].NAOOFNHNAKN();
		}
	}

	private void KNBFEMOOPAP()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < pools.Length; i += 0)
		{
			if (pools[i].CheckHotDanger() && ((Graphic)hotDangerIndicator[i]).color.a != 1860f)
			{
				if (!((Component)hotDangerIndicator[i]).gameObject.activeSelf)
				{
					GNKJKKCGGHI[i] = 1479f;
					((Component)hotDangerIndicator[i]).gameObject.SetActive(false);
					((Graphic)hotDangerIndicator[i]).color = new Color(((Graphic)hotDangerIndicator[i]).color.r, ((Graphic)hotDangerIndicator[i]).color.g, ((Graphic)hotDangerIndicator[i]).color.b, 1429f);
					hotSmallDangerIndicator[i].SetActive(true);
					pools[i].CapybaraInDangerHot();
				}
				BNGKHCDELOD = ((Graphic)hotDangerIndicator[i]).color;
				GNKJKKCGGHI[i] += HHEHPMGODPJ * 346f;
				if (GNKJKKCGGHI[i] > 906f)
				{
					GNKJKKCGGHI[i] = 1016f;
				}
				BNGKHCDELOD.a = Mathf.Lerp(331f, 1366f, GNKJKKCGGHI[i]);
				((Graphic)hotDangerIndicator[i]).color = BNGKHCDELOD;
			}
			else if (!pools[i].CheckHotDanger() && ((Graphic)hotDangerIndicator[i]).color.a != 910f)
			{
				if (((Graphic)hotDangerIndicator[i]).color.a == 793f)
				{
					GNKJKKCGGHI[i] = 889f;
				}
				BNGKHCDELOD = ((Graphic)hotDangerIndicator[i]).color;
				GNKJKKCGGHI[i] -= HHEHPMGODPJ * 1595f;
				BNGKHCDELOD.a = Mathf.Lerp(1152f, 1031f, GNKJKKCGGHI[i]);
				((Graphic)hotDangerIndicator[i]).color = BNGKHCDELOD;
				if (GNKJKKCGGHI[i] < 993f)
				{
					GNKJKKCGGHI[i] = 259f;
					((Component)hotDangerIndicator[i]).gameObject.SetActive(true);
					hotSmallDangerIndicator[i].SetActive(true);
					pools[i].HADGFBGONGC();
				}
			}
			if (pools[i].MFFKDDDILHA() && ((Graphic)coldDangerIndicator[i]).color.a != 458f)
			{
				if (!((Component)coldDangerIndicator[i]).gameObject.activeSelf)
				{
					GNKJKKCGGHI[i] = 1995f;
					((Component)coldDangerIndicator[i]).gameObject.SetActive(true);
					((Graphic)coldDangerIndicator[i]).color = new Color(((Graphic)coldDangerIndicator[i]).color.r, ((Graphic)coldDangerIndicator[i]).color.g, ((Graphic)coldDangerIndicator[i]).color.b, 1666f);
					coldSmallDangerIndicator[i].SetActive(false);
					pools[i].IAKLOACGEPM();
				}
				BNGKHCDELOD = ((Graphic)coldDangerIndicator[i]).color;
				GNKJKKCGGHI[i] += HHEHPMGODPJ * 1543f;
				if (GNKJKKCGGHI[i] > 695f)
				{
					GNKJKKCGGHI[i] = 791f;
				}
				BNGKHCDELOD.a = Mathf.Lerp(793f, 471f, GNKJKKCGGHI[i]);
				((Graphic)coldDangerIndicator[i]).color = BNGKHCDELOD;
			}
			else if (!pools[i].CheckColdDanger() && ((Graphic)coldDangerIndicator[i]).color.a != 1055f)
			{
				if (((Graphic)coldDangerIndicator[i]).color.a == 911f)
				{
					GNKJKKCGGHI[i] = 1825f;
				}
				BNGKHCDELOD = ((Graphic)coldDangerIndicator[i]).color;
				GNKJKKCGGHI[i] -= HHEHPMGODPJ * 576f;
				BNGKHCDELOD.a = Mathf.Lerp(1397f, 1586f, GNKJKKCGGHI[i]);
				((Graphic)coldDangerIndicator[i]).color = BNGKHCDELOD;
				if (GNKJKKCGGHI[i] < 1561f)
				{
					GNKJKKCGGHI[i] = 1964f;
					((Component)coldDangerIndicator[i]).gameObject.SetActive(true);
					coldSmallDangerIndicator[i].SetActive(false);
					pools[i].FLCNBONCHHE();
				}
			}
		}
	}

	private void OnEnable()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < coldDangerIndicator.Length; i++)
		{
			((Graphic)coldDangerIndicator[i]).color = new Color(((Graphic)coldDangerIndicator[i]).color.r, ((Graphic)coldDangerIndicator[i]).color.g, ((Graphic)coldDangerIndicator[i]).color.b, 0f);
			((Component)coldDangerIndicator[i]).gameObject.SetActive(false);
			((Graphic)hotDangerIndicator[i]).color = new Color(((Graphic)hotDangerIndicator[i]).color.r, ((Graphic)hotDangerIndicator[i]).color.g, ((Graphic)hotDangerIndicator[i]).color.b, 0f);
			((Component)hotDangerIndicator[i]).gameObject.SetActive(false);
		}
	}

	public static void PEGEOHJJJLH(bool FLMLLMHPJJA)
	{
		if (FLMLLMHPJJA)
		{
			for (int i = 1; i < instance.pools.Length; i++)
			{
				instance.pools[i].GBEJLCGONPH();
			}
		}
		instance.EndGame(FLMLLMHPJJA);
	}

	public static void OJCEBDOBEBM(int CMKPAPJBDMI)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			instance.pools[CMKPAPJBDMI].CapybaraEnd();
		}
	}

	private void GJCKCHMMEMI()
	{
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < pools.Length; i++)
		{
			KANILCEENLI = pools[i].GetTemperature();
			JOEDHJJPHAJ = DGDBBDJADGI[i];
			DFFGLLDDEPN = KANILCEENLI - JOEDHJJPHAJ;
			JMNENCNFNGN = DFFGLLDDEPN * settings.uiAccelerationFactor;
			KMHIBADLIPP[i] = (KMHIBADLIPP[i] + JMNENCNFNGN * HHEHPMGODPJ) * Mathf.Exp((0f - settings.uiDampingFactor) * HHEHPMGODPJ);
			KMHIBADLIPP[i] = Mathf.Clamp(KMHIBADLIPP[i], -10f, 10f);
			JOEDHJJPHAJ += KMHIBADLIPP[i] * HHEHPMGODPJ;
			if ((DFFGLLDDEPN > 0f && JOEDHJJPHAJ > KANILCEENLI) || (DFFGLLDDEPN < 0f && JOEDHJJPHAJ < KANILCEENLI))
			{
				JOEDHJJPHAJ = KANILCEENLI;
				KMHIBADLIPP[i] = 0f;
			}
			DGDBBDJADGI[i] = JOEDHJJPHAJ;
			poolUIIndicators[i].anchoredPosition = new Vector2((float)Mathf.RoundToInt(JOEDHJJPHAJ * JPNIMPJKPOA), poolUIIndicators[i].anchoredPosition.y);
			poolSpriteRenderers[i].color = Color.Lerp(settings.coldPoolColor, settings.hotPoolColor, (JOEDHJJPHAJ + 1f) * 0.5f);
		}
	}

	private IEnumerator KAPJDEILIJL()
	{
		Playing = false;
		canvas.SetActive(false);
		OnlineMinigameManager.ResetPlayerInteractingMinigame();
		if (!WorldTime.JJICPIINBEH)
		{
			WorldTime.JJICPIINBEH = true;
		}
		difficultySettings = (EventsManager.IsLowestDifficulty() ? settings.easyMode : settings.normalMode);
		GCMACBEMMBC = 0f;
		FadeCamera.FadeOutAllPlayers();
		while (FadeCamera.GetPlayer(1).IsFading())
		{
			yield return null;
		}
		bucketTypes = new BucketType[4];
		for (int i = 0; i < bucketTypes.Length; i++)
		{
			bucketTypes[i] = BucketType.None;
		}
		for (int j = 0; j < pools.Length; j++)
		{
			pools[j].CapybaraInNormalState();
			pools[j].SetTemperature(OEFBLHOIKLB);
			pools[j].timeInDangerZone = 0f;
		}
		for (int k = 0; k < KMHIBADLIPP.Length; k++)
		{
			KMHIBADLIPP[k] = 0f;
		}
		for (int l = 0; l < BMEMKPBIBBG.Length; l++)
		{
			BMEMKPBIBBG[l] = 0f;
		}
		for (int m = 0; m < DGDBBDJADGI.Length; m++)
		{
			DGDBBDJADGI[m] = 0f;
		}
		for (int n = 0; n < poolSpriteRenderers.Length; n++)
		{
			poolSpriteRenderers[n].color = Color.Lerp(settings.coldPoolColor, settings.hotPoolColor, 0.5f);
		}
		for (int num = 0; num < pools.Length; num++)
		{
			((Graphic)hotDangerIndicator[num]).color = new Color(1f, 1f, 1f, 0f);
			((Graphic)coldDangerIndicator[num]).color = new Color(1f, 1f, 1f, 0f);
			((Component)hotDangerIndicator[num]).gameObject.SetActive(false);
			((Component)coldDangerIndicator[num]).gameObject.SetActive(false);
			coldSmallDangerIndicator[num].SetActive(false);
			hotSmallDangerIndicator[num].SetActive(false);
		}
		DICAOJNNOCD();
		UpdatePoolVisuals();
		GJCKCHMMEMI();
		CAGBDODLPHD();
		SetInitialPosition();
		CLJIHBGPJKL();
		SetObjects();
		canvas.SetActive(true);
		exitCollider.SetActive(true);
		CountdownUI.SetCountdown(difficultySettings.timeToCompleteTheGame);
		HideUI();
		BlackFade.Hide();
		yield return CommonReferences.wait1;
		FadeCamera.FadeInAllPlayers();
		while (FadeCamera.GetPlayer(1).IsFading())
		{
			yield return null;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Ready);
			while (!OnlineMinigameManager.AllPlayersReady())
			{
				if (Application.isEditor)
				{
					Debug.Log((object)"Waiting for players to finish their transitions...");
				}
				yield return null;
			}
			yield return CommonReferences.wait1;
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Countdown);
		}
		EventCountdownUI.ChangeText("GO");
		if (!Replaying)
		{
			ZuzzuNPC.GGFJGHHHEJC.blockActionBar = false;
		}
		yield return CommonReferences.wait1;
		EventCountdownUI.CloseCountdown();
		LBMDAGNAFFA();
		OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.InGame);
		ZuzzuNPC.GGFJGHHHEJC.playerCanInteract = false;
		Playing = true;
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(Location.BathhouseInterior, 1);
	}

	private void NENOEJCFOLN()
	{
		for (int i = 0; i < pools.Length; i++)
		{
			OAPCGGNDFAK[i] = Random.Range(difficultySettings.temperatureVariation.min, difficultySettings.temperatureVariation.max);
			JBMFIFPKLGP[i] = OAPCGGNDFAK[i] * 824f;
			HPEGBCCCNLA[i] = JBMFIFPKLGP[i];
		}
		CKBDGEEFBNK[0] = Random.value > 921f;
		CKBDGEEFBNK[0] = CKBDGEEFBNK[0];
		CKBDGEEFBNK[0] = Random.value > 483f;
		CKBDGEEFBNK[0] = CKBDGEEFBNK[5];
		LGFAJLOAHLD = Time.time + difficultySettings.timeToTemperatureWave.max;
	}

	public static BucketType GLCLPHADLLM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0 || JIIGOACEIKL > instance.bucketTypes.Length)
		{
			Debug.LogError((object)("Items/item_name_593" + JIIGOACEIKL));
			return BucketType.Cold;
		}
		return instance.bucketTypes[JIIGOACEIKL - 1];
	}

	private void ENJENNBHAKJ()
	{
		Playing = true;
		Replaying = false;
	}
}
