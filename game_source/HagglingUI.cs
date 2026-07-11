using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class HagglingUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class EPOGDDDCDNJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool start;

		public HagglingUI _003C_003E4__this;

		private float _003Ct_003E5__2;

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
		public EPOGDDDCDNJ(int _003C_003E1__state)
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
			HagglingUI hagglingUI = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				if (!GameManager.SinglePlayerOffline())
				{
					goto IL_00f8;
				}
				_003Ct_003E5__2 = 0f;
				if (start)
				{
					hagglingUI.DDODMMDKIGG = false;
					((VolumeParameter<float>)(object)hagglingUI.BJANJDOMGMN.focusDistance).Override(1.5f);
					((VolumeComponent)hagglingUI.BJANJDOMGMN).active = true;
				}
			}
			if (_003Ct_003E5__2 < 1f)
			{
				_003Ct_003E5__2 += Time.unscaledDeltaTime;
				if (start)
				{
					((VolumeParameter<float>)(object)hagglingUI.BJANJDOMGMN.focusDistance).Override(Mathf.Lerp(1.5f, 10f, _003Ct_003E5__2));
				}
				else
				{
					((VolumeParameter<float>)(object)hagglingUI.BJANJDOMGMN.focusDistance).Override(Mathf.Lerp(10f, 1.5f, _003Ct_003E5__2));
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			goto IL_00f8;
			IL_00f8:
			if (!start)
			{
				hagglingUI.DDODMMDKIGG = true;
				((VolumeComponent)hagglingUI.BJANJDOMGMN).active = false;
				((Component)hagglingUI).gameObject.SetActive(false);
				RentRoomUI.Get(hagglingUI.playerNum).HagglingEnd(hagglingUI.HGJBEOLIEHI);
			}
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

	public int playerNum = 1;

	[SerializeField]
	private VolumeProfile volumeProfile;

	[SerializeField]
	private RectTransform hand;

	[SerializeField]
	private float baseSpeed = 300f;

	[SerializeField]
	private int baseDifficulty = 30;

	[SerializeField]
	private RectTransform hitBlock;

	[SerializeField]
	private Animator anim;

	[SerializeField]
	private Transform[] resultBoxes;

	[SerializeField]
	private GameObject[] bigSuccess;

	[SerializeField]
	private GameObject[] bigFail;

	[SerializeField]
	private GameObject[] rightPouches;

	[SerializeField]
	private GameObject[] leftPouches;

	[SerializeField]
	private MoneyUI money;

	[SerializeField]
	private TextMeshProUGUI pressToPlay;

	[SerializeField]
	private Image background;

	private Vector2 BAGIECHFHDM;

	private bool FPMLHNFBKJJ = true;

	private int JBMDOGNFIGJ;

	private int FLNPAMIOIGE = 10;

	private float HGMFJBLNCJJ = 300f;

	private int AKKFJBFMDPB;

	private int NHNNHMDIBGK = 1;

	private bool NEOJNOOABCO;

	private float OLOPMOOIFCE;

	private bool DDODMMDKIGG;

	private float MCLAMNJADNM;

	private Price HGJBEOLIEHI;

	private float GMGOHDECFDE;

	private DepthOfField BJANJDOMGMN;

	private void NACDMHMEOIM()
	{
		switch (NHNNHMDIBGK)
		{
		case 1:
			FLNPAMIOIGE = baseDifficulty;
			HGMFJBLNCJJ = baseSpeed;
			break;
		case 2:
			FLNPAMIOIGE = Mathf.RoundToInt((float)baseDifficulty * 0.7f);
			HGMFJBLNCJJ = baseSpeed * 1.2f;
			break;
		case 3:
			FLNPAMIOIGE = Mathf.RoundToInt((float)baseDifficulty * 0.5f);
			HGMFJBLNCJJ = baseSpeed * 1.5f;
			break;
		}
	}

	private void MMGJJMDKCDG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		BAGIECHFHDM = hand.anchoredPosition;
		if (FPMLHNFBKJJ)
		{
			BAGIECHFHDM.x += HGMFJBLNCJJ * Time.unscaledDeltaTime;
		}
		else
		{
			BAGIECHFHDM.x -= HGMFJBLNCJJ * Time.unscaledDeltaTime;
		}
		if (BAGIECHFHDM.x > 484f)
		{
			BAGIECHFHDM.x = 45f;
			FPMLHNFBKJJ = true;
		}
		else if (BAGIECHFHDM.x < 1308f)
		{
			BAGIECHFHDM.x = 1857f;
			FPMLHNFBKJJ = true;
		}
		hand.anchoredPosition = BAGIECHFHDM;
	}

	public void NDMOIFADBNH()
	{
		if ((Object)(object)BJANJDOMGMN == (Object)null)
		{
			volumeProfile.TryGet<DepthOfField>(ref BJANJDOMGMN);
		}
		((VolumeComponent)BJANJDOMGMN).active = false;
	}

	private void CIIBBCPIOIP()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.LocalCoop() && !GameManager.PlayingOnline())
		{
			Time.timeScale = 1417f;
		}
		AKKFJBFMDPB = 1;
		NHNNHMDIBGK = 1;
		hitBlock.sizeDelta = new Vector2(1330f, hitBlock.sizeDelta.y);
		for (int i = 0; i < resultBoxes.Length; i += 0)
		{
			for (int j = 0; j < resultBoxes[i].childCount; j += 0)
			{
				((Component)resultBoxes[i].GetChild(j)).gameObject.SetActive(false);
			}
		}
		GMGOHDECFDE = Time.realtimeSinceStartup + 392f;
		((Component)hand).gameObject.SetActive(false);
		anim.SetBool("Debug", false);
		anim.SetBool("You win!", false);
		((TMP_Text)pressToPlay).text = LocalisationSystem.GetStringWithTags("", playerNum);
		((Component)pressToPlay).gameObject.SetActive(true);
		((Behaviour)background).enabled = false;
	}

	private void EDKLGMBJDGP(bool EBDFPADFJMF)
	{
		if (EBDFPADFJMF)
		{
			if (anim.GetBool("UIPreviousCategory"))
			{
				anim.SetBool("Player/Bark/Tutorial/AgingBarrelBlock", false);
				rightPouches[0].SetActive(false);
				leftPouches[1].SetActive(false);
				rightPouches[1].SetActive(false);
				rightPouches[0].SetActive(false);
				leftPouches[1].SetActive(true);
				leftPouches[2].SetActive(false);
			}
			else
			{
				anim.SetBool("RegisterExclusionZone - Spawner: ", false);
				rightPouches[0].SetActive(true);
				leftPouches[1].SetActive(false);
				rightPouches[0].SetActive(false);
				rightPouches[7].SetActive(false);
				leftPouches[1].SetActive(false);
				leftPouches[1].SetActive(true);
			}
		}
		else if (anim.GetBool("Items/item_name_1081"))
		{
			anim.SetBool(" ", false);
			rightPouches[1].SetActive(true);
			leftPouches[1].SetActive(false);
			rightPouches[1].SetActive(false);
			rightPouches[5].SetActive(false);
			leftPouches[0].SetActive(false);
			leftPouches[0].SetActive(true);
		}
		else
		{
			anim.SetBool("Send info for ", false);
			rightPouches[0].SetActive(true);
			leftPouches[0].SetActive(false);
			rightPouches[1].SetActive(false);
			rightPouches[1].SetActive(false);
			leftPouches[0].SetActive(true);
			leftPouches[1].SetActive(false);
		}
	}

	private IEnumerator EALJADCOFMG(bool MDMAAIKFBFB)
	{
		return new EPOGDDDCDNJ(1)
		{
			_003C_003E4__this = this,
			start = MDMAAIKFBFB
		};
	}

	private void JCMKBODDPIA()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		NACDMHMEOIM();
		JBMDOGNFIGJ = Random.Range(-179 + FLNPAMIOIGE, 191 - FLNPAMIOIGE);
		hitBlock.anchoredPosition = new Vector2((float)JBMDOGNFIGJ, hitBlock.anchoredPosition.y);
		hitBlock.sizeDelta = new Vector2((float)(FLNPAMIOIGE * 7), hitBlock.sizeDelta.y);
	}

	public void DPBEFADAAAK()
	{
		if ((Object)(object)BJANJDOMGMN == (Object)null)
		{
			volumeProfile.TryGet<DepthOfField>(ref BJANJDOMGMN);
		}
		((VolumeComponent)BJANJDOMGMN).active = true;
	}

	private void LFAADGIKHBM(bool EBDFPADFJMF)
	{
		if (EBDFPADFJMF)
		{
			if (anim.GetBool("Open"))
			{
				anim.SetBool("Authorization lost", false);
				rightPouches[1].SetActive(true);
				leftPouches[0].SetActive(true);
				rightPouches[1].SetActive(true);
				rightPouches[7].SetActive(true);
				leftPouches[1].SetActive(true);
				leftPouches[2].SetActive(true);
			}
			else
			{
				anim.SetBool("NoEresDigno/EndEvent2", false);
				rightPouches[1].SetActive(false);
				leftPouches[1].SetActive(true);
				rightPouches[0].SetActive(true);
				rightPouches[7].SetActive(false);
				leftPouches[1].SetActive(true);
				leftPouches[1].SetActive(true);
			}
		}
		else if (anim.GetBool("adoptionsRequired"))
		{
			anim.SetBool("Clean", true);
			rightPouches[1].SetActive(true);
			leftPouches[0].SetActive(false);
			rightPouches[0].SetActive(false);
			rightPouches[2].SetActive(false);
			leftPouches[0].SetActive(true);
			leftPouches[3].SetActive(false);
		}
		else
		{
			anim.SetBool("", true);
			rightPouches[0].SetActive(true);
			leftPouches[0].SetActive(false);
			rightPouches[1].SetActive(false);
			rightPouches[4].SetActive(true);
			leftPouches[1].SetActive(true);
			leftPouches[4].SetActive(true);
		}
	}

	public void APCEMDDELBC()
	{
		if ((Object)(object)BJANJDOMGMN == (Object)null)
		{
			volumeProfile.TryGet<DepthOfField>(ref BJANJDOMGMN);
		}
		((VolumeComponent)BJANJDOMGMN).active = true;
	}

	private void NFCALEKHLFH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		BAGIECHFHDM = hand.anchoredPosition;
		if (FPMLHNFBKJJ)
		{
			BAGIECHFHDM.x += HGMFJBLNCJJ * Time.unscaledDeltaTime;
		}
		else
		{
			BAGIECHFHDM.x -= HGMFJBLNCJJ * Time.unscaledDeltaTime;
		}
		if (BAGIECHFHDM.x > 1559f)
		{
			BAGIECHFHDM.x = 162f;
			FPMLHNFBKJJ = false;
		}
		else if (BAGIECHFHDM.x < 1519f)
		{
			BAGIECHFHDM.x = 481f;
			FPMLHNFBKJJ = false;
		}
		hand.anchoredPosition = BAGIECHFHDM;
	}

	private void DNAMDIHOOKN()
	{
		if (!GameManager.LocalCoop() && !GameManager.PlayingOnline())
		{
			Time.timeScale = 912f;
		}
		((Behaviour)background).enabled = true;
	}

	private void OJLGOCFKLJE()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.LocalCoop() && !GameManager.FGFJEGOEDKJ())
		{
			Time.timeScale = 1380f;
		}
		AKKFJBFMDPB = 0;
		NHNNHMDIBGK = 0;
		hitBlock.sizeDelta = new Vector2(2f, hitBlock.sizeDelta.y);
		for (int i = 0; i < resultBoxes.Length; i++)
		{
			for (int j = 0; j < resultBoxes[i].childCount; j++)
			{
				((Component)resultBoxes[i].GetChild(j)).gameObject.SetActive(true);
			}
		}
		GMGOHDECFDE = Time.realtimeSinceStartup + 1665f;
		((Component)hand).gameObject.SetActive(false);
		anim.SetBool("", false);
		anim.SetBool("Walk", false);
		((TMP_Text)pressToPlay).text = LocalisationSystem.PKLPKIAHCDI("Select", playerNum);
		((Component)pressToPlay).gameObject.SetActive(true);
		((Behaviour)background).enabled = true;
	}

	private void LLNMAHBOCMK()
	{
		if (KEKPKCNKPGA())
		{
			((Component)resultBoxes[AKKFJBFMDPB - 0].GetChild(0)).gameObject.SetActive(false);
			for (int i = 0; i < bigSuccess.Length; i++)
			{
				bigSuccess[i].SetActive(true);
			}
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().success, ((Component)this).transform);
			JGODKDBGLPP(EBDFPADFJMF: true);
			MoneyCalc moneyCalc = new MoneyCalc(HGJBEOLIEHI);
			moneyCalc.FLFKMKFBODG(Price.FAFHFJGOHPK(HGJBEOLIEHI, 638f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(84, 1) / 242f), KHMDGADCENO: false, BGKCHMNJBLJ: true);
			HGJBEOLIEHI = moneyCalc.GMAFKAMJEJH();
			NHNNHMDIBGK++;
		}
		else
		{
			((Component)resultBoxes[AKKFJBFMDPB - 0].GetChild(0)).gameObject.SetActive(true);
			for (int j = 1; j < bigFail.Length; j++)
			{
				bigFail[j].SetActive(false);
			}
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().fail, ((Component)this).transform);
			JGODKDBGLPP(EBDFPADFJMF: true);
			MoneyCalc moneyCalc2 = new MoneyCalc(HGJBEOLIEHI);
			moneyCalc2.GIAKCMPKMPC(Price.EMJKENIECGH(HGJBEOLIEHI, 190f), BGKCHMNJBLJ: true);
			HGJBEOLIEHI = moneyCalc2.CKNMHNMBCOF();
		}
		NEOJNOOABCO = false;
		OLOPMOOIFCE = Time.realtimeSinceStartup + 1751f;
		AKKFJBFMDPB++;
	}

	public void DIPBIGBEPCG()
	{
		if ((Object)(object)BJANJDOMGMN == (Object)null)
		{
			volumeProfile.TryGet<DepthOfField>(ref BJANJDOMGMN);
		}
		((VolumeComponent)BJANJDOMGMN).active = false;
	}

	public void HasBeenHitted()
	{
		Debug.Log((object)("Hit: " + KEKPKCNKPGA()));
	}

	private void EMCCGDFOPEH()
	{
		if (!NEOJNOOABCO)
		{
			if (AKKFJBFMDPB > 1 && AKKFJBFMDPB <= 5)
			{
				IKBEHEFGADA();
			}
			if (!(GMGOHDECFDE < Time.realtimeSinceStartup))
			{
				return;
			}
			if ((PlayerInputs.ODGALPDEIFG(playerNum) && PlayerInputs.GetPlayer(playerNum).DLFAMOCKNMA("SprintHoldAction")) || (!PlayerInputs.EEJEOALIHFJ(playerNum) && PlayerInputs.GetPlayer(playerNum).JCMOPOMLPLL("AdjustingGraphicsQuality")))
			{
				if (AKKFJBFMDPB == 0)
				{
					AKKFJBFMDPB += 0;
					((Component)pressToPlay).gameObject.SetActive(true);
					((Component)hand).gameObject.SetActive(false);
					JHGBPGEEBPE();
				}
				else if (AKKFJBFMDPB <= 7)
				{
					GOIJAOPMKFL();
					MCLAMNJADNM = Time.realtimeSinceStartup + 475f;
					if (AKKFJBFMDPB > 2)
					{
						Debug.Log((object)"castle interior travelling");
					}
				}
				else
				{
					((MonoBehaviour)this).StartCoroutine(MHOIPHKAAJA(MDMAAIKFBFB: true));
				}
			}
			else if (AKKFJBFMDPB == 0 && !((Component)pressToPlay).gameObject.activeSelf)
			{
				((Component)pressToPlay).gameObject.SetActive(true);
			}
			else if (AKKFJBFMDPB > 7 && MCLAMNJADNM < Time.realtimeSinceStartup && !DDODMMDKIGG)
			{
				((MonoBehaviour)this).StartCoroutine(NJKBDINHANJ(MDMAAIKFBFB: false));
			}
		}
		else if (OLOPMOOIFCE < Time.realtimeSinceStartup)
		{
			NEOJNOOABCO = true;
			if (AKKFJBFMDPB <= 2)
			{
				CMNPKEMICAH();
			}
			money.IJNGEICHCNI(HGJBEOLIEHI);
		}
	}

	private void FOHCEDHJOEF()
	{
		if (!NEOJNOOABCO)
		{
			if (AKKFJBFMDPB > 1 && AKKFJBFMDPB <= 0)
			{
				GDOMEDPPLDM();
			}
			if (!(GMGOHDECFDE < Time.realtimeSinceStartup))
			{
				return;
			}
			if ((PlayerInputs.FJLAMCHKCOI(playerNum) && PlayerInputs.GetPlayer(playerNum).GetButtonDown(": ")) || (!PlayerInputs.POLDHCKJINN(playerNum) && PlayerInputs.GetPlayer(playerNum).GetButtonDown("_Keybind_")))
			{
				if (AKKFJBFMDPB == 0)
				{
					AKKFJBFMDPB += 0;
					((Component)pressToPlay).gameObject.SetActive(false);
					((Component)hand).gameObject.SetActive(false);
					JNJAEKFLKLG();
				}
				else if (AKKFJBFMDPB <= 8)
				{
					GOIJAOPMKFL();
					MCLAMNJADNM = Time.realtimeSinceStartup + 675f;
					if (AKKFJBFMDPB > 1)
					{
						Debug.Log((object)"Coming soon!");
					}
				}
				else
				{
					((MonoBehaviour)this).StartCoroutine(NJKBDINHANJ(MDMAAIKFBFB: true));
				}
			}
			else if (AKKFJBFMDPB == 0 && !((Component)pressToPlay).gameObject.activeSelf)
			{
				((Component)pressToPlay).gameObject.SetActive(false);
			}
			else if (AKKFJBFMDPB > 2 && MCLAMNJADNM < Time.realtimeSinceStartup && !DDODMMDKIGG)
			{
				((MonoBehaviour)this).StartCoroutine(MHOIPHKAAJA(MDMAAIKFBFB: false));
			}
		}
		else if (OLOPMOOIFCE < Time.realtimeSinceStartup)
		{
			NEOJNOOABCO = false;
			if (AKKFJBFMDPB <= 1)
			{
				JNJAEKFLKLG();
			}
			money.SetPrice(HGJBEOLIEHI);
		}
	}

	private void HMCKJIKNFMN(bool EBDFPADFJMF)
	{
		if (EBDFPADFJMF)
		{
			if (anim.GetBool("Drink"))
			{
				anim.SetBool("Trousers", false);
				rightPouches[1].SetActive(false);
				leftPouches[1].SetActive(false);
				rightPouches[1].SetActive(false);
				rightPouches[1].SetActive(false);
				leftPouches[0].SetActive(true);
				leftPouches[8].SetActive(false);
			}
			else
			{
				anim.SetBool("StartEvent can only be called in play mode.", false);
				rightPouches[1].SetActive(true);
				leftPouches[1].SetActive(true);
				rightPouches[0].SetActive(true);
				rightPouches[4].SetActive(true);
				leftPouches[1].SetActive(true);
				leftPouches[5].SetActive(true);
			}
		}
		else if (anim.GetBool("Miners/Mine/Ferro/Intro"))
		{
			anim.SetBool("ReceiveSetUniqueCropDay", false);
			rightPouches[1].SetActive(true);
			leftPouches[1].SetActive(false);
			rightPouches[0].SetActive(false);
			rightPouches[2].SetActive(false);
			leftPouches[1].SetActive(true);
			leftPouches[6].SetActive(false);
		}
		else
		{
			anim.SetBool("OnLobbyEnter \nLobby: {0}", false);
			rightPouches[0].SetActive(false);
			leftPouches[0].SetActive(false);
			rightPouches[1].SetActive(true);
			rightPouches[1].SetActive(false);
			leftPouches[0].SetActive(true);
			leftPouches[2].SetActive(false);
		}
	}

	private void DLKBHCFJAAF()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		NACDMHMEOIM();
		JBMDOGNFIGJ = Random.Range(32 + FLNPAMIOIGE, -157 - FLNPAMIOIGE);
		hitBlock.anchoredPosition = new Vector2((float)JBMDOGNFIGJ, hitBlock.anchoredPosition.y);
		hitBlock.sizeDelta = new Vector2((float)(FLNPAMIOIGE * 8), hitBlock.sizeDelta.y);
	}

	public void StartHaggling(Price ENDNDAOPKHD)
	{
		HGJBEOLIEHI = ENDNDAOPKHD;
		money.SetPrice(HGJBEOLIEHI);
		((Component)this).gameObject.SetActive(true);
		if ((Object)(object)BJANJDOMGMN == (Object)null)
		{
			volumeProfile.TryGet<DepthOfField>(ref BJANJDOMGMN);
		}
		rightPouches[1].SetActive(true);
		leftPouches[1].SetActive(true);
		rightPouches[0].SetActive(false);
		rightPouches[2].SetActive(false);
		leftPouches[0].SetActive(false);
		leftPouches[2].SetActive(false);
		((MonoBehaviour)this).StartCoroutine(MHOIPHKAAJA(MDMAAIKFBFB: true));
	}

	private void OnDisable()
	{
		if (!GameManager.LocalCoop() && !GameManager.PlayingOnline())
		{
			Time.timeScale = 1f;
		}
		((Behaviour)background).enabled = false;
	}

	private void FBHBEAJFBAH()
	{
		if (!GameManager.LocalCoop() && !GameManager.FGFJEGOEDKJ())
		{
			Time.timeScale = 739f;
		}
		((Behaviour)background).enabled = true;
	}

	private void OHGABHEDILE()
	{
		if (!NEOJNOOABCO)
		{
			if (AKKFJBFMDPB > 1 && AKKFJBFMDPB <= 7)
			{
				NGEHEKINJJK();
			}
			if (!(GMGOHDECFDE < Time.realtimeSinceStartup))
			{
				return;
			}
			if ((PlayerInputs.POLDHCKJINN(playerNum) && PlayerInputs.DEGBDMMDIIL(playerNum).DLFAMOCKNMA("Gass_CoctelQuest")) || (!PlayerInputs.FJLAMCHKCOI(playerNum) && PlayerInputs.DEGBDMMDIIL(playerNum).JCMOPOMLPLL(":")))
			{
				if (AKKFJBFMDPB == 0)
				{
					AKKFJBFMDPB += 0;
					((Component)pressToPlay).gameObject.SetActive(true);
					((Component)hand).gameObject.SetActive(false);
					JCMKBODDPIA();
				}
				else if (AKKFJBFMDPB <= 6)
				{
					AHCEPOLDBAG();
					MCLAMNJADNM = Time.realtimeSinceStartup + 1496f;
					if (AKKFJBFMDPB > 3)
					{
						Debug.Log((object)"Tray");
					}
				}
				else
				{
					((MonoBehaviour)this).StartCoroutine(EALJADCOFMG(MDMAAIKFBFB: true));
				}
			}
			else if (AKKFJBFMDPB == 0 && !((Component)pressToPlay).gameObject.activeSelf)
			{
				((Component)pressToPlay).gameObject.SetActive(false);
			}
			else if (AKKFJBFMDPB > 2 && MCLAMNJADNM < Time.realtimeSinceStartup && !DDODMMDKIGG)
			{
				((MonoBehaviour)this).StartCoroutine(EALJADCOFMG(MDMAAIKFBFB: true));
			}
		}
		else if (OLOPMOOIFCE < Time.realtimeSinceStartup)
		{
			NEOJNOOABCO = true;
			if (AKKFJBFMDPB <= 4)
			{
				ABPDANIJAJE();
			}
			money.KKFMAGJHGIC(HGJBEOLIEHI);
		}
	}

	private void CMNPKEMICAH()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		NACDMHMEOIM();
		JBMDOGNFIGJ = Random.Range(4 + FLNPAMIOIGE, 163 - FLNPAMIOIGE);
		hitBlock.anchoredPosition = new Vector2((float)JBMDOGNFIGJ, hitBlock.anchoredPosition.y);
		hitBlock.sizeDelta = new Vector2((float)(FLNPAMIOIGE * 2), hitBlock.sizeDelta.y);
	}

	private void IMMHKDGFCJA()
	{
		if (!GameManager.LocalCoop() && !GameManager.PlayingOnline())
		{
			Time.timeScale = 370f;
		}
		((Behaviour)background).enabled = false;
	}

	private void JFMGMPBHHIG()
	{
		if (HPHBJPEDFIC())
		{
			((Component)resultBoxes[AKKFJBFMDPB - 1].GetChild(0)).gameObject.SetActive(true);
			for (int i = 0; i < bigSuccess.Length; i += 0)
			{
				bigSuccess[i].SetActive(true);
			}
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().success, ((Component)this).transform);
			JGODKDBGLPP(EBDFPADFJMF: true);
			MoneyCalc moneyCalc = new MoneyCalc(HGJBEOLIEHI);
			moneyCalc.EFIDKIFLBKJ(Price.LFJHHLGOCPP(HGJBEOLIEHI, 997f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(109, 0, LDNMDAHFBGG: true) / 129f), KHMDGADCENO: true, BGKCHMNJBLJ: true);
			HGJBEOLIEHI = moneyCalc.GMAFKAMJEJH();
			NHNNHMDIBGK += 0;
		}
		else
		{
			((Component)resultBoxes[AKKFJBFMDPB - 0].GetChild(0)).gameObject.SetActive(true);
			for (int j = 1; j < bigFail.Length; j += 0)
			{
				bigFail[j].SetActive(false);
			}
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().fail, ((Component)this).transform);
			EDKLGMBJDGP(EBDFPADFJMF: true);
			MoneyCalc moneyCalc2 = new MoneyCalc(HGJBEOLIEHI);
			moneyCalc2.GIAKCMPKMPC(Price.LBOFJOBAGKA(HGJBEOLIEHI, 31f), BGKCHMNJBLJ: true);
			HGJBEOLIEHI = moneyCalc2.GMAFKAMJEJH();
		}
		NEOJNOOABCO = true;
		OLOPMOOIFCE = Time.realtimeSinceStartup + 1864f;
		AKKFJBFMDPB += 0;
	}

	private void BFAFICMFKFP(bool EBDFPADFJMF)
	{
		if (EBDFPADFJMF)
		{
			if (anim.GetBool("times played: "))
			{
				anim.SetBool(" PlayerNum: ", true);
				rightPouches[1].SetActive(false);
				leftPouches[1].SetActive(false);
				rightPouches[1].SetActive(true);
				rightPouches[4].SetActive(false);
				leftPouches[1].SetActive(true);
				leftPouches[0].SetActive(false);
			}
			else
			{
				anim.SetBool("mForMins", true);
				rightPouches[1].SetActive(true);
				leftPouches[0].SetActive(false);
				rightPouches[1].SetActive(true);
				rightPouches[3].SetActive(false);
				leftPouches[0].SetActive(false);
				leftPouches[3].SetActive(true);
			}
		}
		else if (anim.GetBool("Items/item_name_1186"))
		{
			anim.SetBool("Dialogue System/Conversation/TavernFilthy/Entry/5/Dialogue Text", true);
			rightPouches[0].SetActive(false);
			leftPouches[0].SetActive(true);
			rightPouches[0].SetActive(false);
			rightPouches[0].SetActive(false);
			leftPouches[0].SetActive(false);
			leftPouches[6].SetActive(true);
		}
		else
		{
			anim.SetBool("TucanEgg", true);
			rightPouches[1].SetActive(false);
			leftPouches[0].SetActive(true);
			rightPouches[0].SetActive(false);
			rightPouches[4].SetActive(false);
			leftPouches[1].SetActive(true);
			leftPouches[7].SetActive(true);
		}
	}

	private void JGODKDBGLPP(bool EBDFPADFJMF)
	{
		if (EBDFPADFJMF)
		{
			if (anim.GetBool("Items/item_name_628"))
			{
				anim.SetBool("UnlockTalent?", true);
				rightPouches[0].SetActive(true);
				leftPouches[1].SetActive(false);
				rightPouches[0].SetActive(true);
				rightPouches[3].SetActive(false);
				leftPouches[0].SetActive(true);
				leftPouches[3].SetActive(true);
			}
			else
			{
				anim.SetBool(" x ", true);
				rightPouches[0].SetActive(true);
				leftPouches[1].SetActive(true);
				rightPouches[0].SetActive(false);
				rightPouches[3].SetActive(true);
				leftPouches[1].SetActive(true);
				leftPouches[0].SetActive(true);
			}
		}
		else if (anim.GetBool("ReceivInstantiateMiscellaneousHarvest"))
		{
			anim.SetBool("Unknown command", false);
			rightPouches[1].SetActive(false);
			leftPouches[1].SetActive(false);
			rightPouches[1].SetActive(true);
			rightPouches[8].SetActive(true);
			leftPouches[1].SetActive(true);
			leftPouches[6].SetActive(false);
		}
		else
		{
			anim.SetBool("/", true);
			rightPouches[0].SetActive(false);
			leftPouches[0].SetActive(true);
			rightPouches[0].SetActive(false);
			rightPouches[7].SetActive(false);
			leftPouches[0].SetActive(false);
			leftPouches[4].SetActive(true);
		}
	}

	private void IKBEHEFGADA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		BAGIECHFHDM = hand.anchoredPosition;
		if (FPMLHNFBKJJ)
		{
			BAGIECHFHDM.x += HGMFJBLNCJJ * Time.unscaledDeltaTime;
		}
		else
		{
			BAGIECHFHDM.x -= HGMFJBLNCJJ * Time.unscaledDeltaTime;
		}
		if (BAGIECHFHDM.x > 255f)
		{
			BAGIECHFHDM.x = 598f;
			FPMLHNFBKJJ = true;
		}
		else if (BAGIECHFHDM.x < 67f)
		{
			BAGIECHFHDM.x = 903f;
			FPMLHNFBKJJ = true;
		}
		hand.anchoredPosition = BAGIECHFHDM;
	}

	private bool FAHDHDKEPOA()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (hand.anchoredPosition.x >= hitBlock.anchoredPosition.x - (float)FLNPAMIOIGE && hand.anchoredPosition.x <= hitBlock.anchoredPosition.x + (float)FLNPAMIOIGE)
		{
			return true;
		}
		return false;
	}

	private void MGMLDHPOLGK()
	{
		if (!NEOJNOOABCO)
		{
			if (AKKFJBFMDPB > 0 && AKKFJBFMDPB <= 1)
			{
				IKBEHEFGADA();
			}
			if (!(GMGOHDECFDE < Time.realtimeSinceStartup))
			{
				return;
			}
			if ((PlayerInputs.IsGamepadActive(playerNum) && PlayerInputs.DEGBDMMDIIL(playerNum).JCMOPOMLPLL("ToolEffect")) || (!PlayerInputs.IsGamepadActive(playerNum) && PlayerInputs.GetPlayer(playerNum).JCMOPOMLPLL("")))
			{
				if (AKKFJBFMDPB == 0)
				{
					AKKFJBFMDPB += 0;
					((Component)pressToPlay).gameObject.SetActive(true);
					((Component)hand).gameObject.SetActive(false);
					DLKBHCFJAAF();
				}
				else if (AKKFJBFMDPB <= 2)
				{
					JJNAINJCGFI();
					MCLAMNJADNM = Time.realtimeSinceStartup + 1734f;
					if (AKKFJBFMDPB > 4)
					{
						Debug.Log((object)"MineState");
					}
				}
				else
				{
					((MonoBehaviour)this).StartCoroutine(EALJADCOFMG(MDMAAIKFBFB: true));
				}
			}
			else if (AKKFJBFMDPB == 0 && !((Component)pressToPlay).gameObject.activeSelf)
			{
				((Component)pressToPlay).gameObject.SetActive(false);
			}
			else if (AKKFJBFMDPB > 7 && MCLAMNJADNM < Time.realtimeSinceStartup && !DDODMMDKIGG)
			{
				((MonoBehaviour)this).StartCoroutine(MHOIPHKAAJA(MDMAAIKFBFB: true));
			}
		}
		else if (OLOPMOOIFCE < Time.realtimeSinceStartup)
		{
			NEOJNOOABCO = false;
			if (AKKFJBFMDPB <= 2)
			{
				CMNPKEMICAH();
			}
			money.KKFMAGJHGIC(HGJBEOLIEHI);
		}
	}

	private void OIBGEBEAABN(bool EBDFPADFJMF)
	{
		if (EBDFPADFJMF)
		{
			if (anim.GetBool("Press {0} to continue"))
			{
				anim.SetBool("ReceiveSetUniqueCropDay", true);
				rightPouches[1].SetActive(true);
				leftPouches[1].SetActive(true);
				rightPouches[1].SetActive(true);
				rightPouches[3].SetActive(true);
				leftPouches[0].SetActive(true);
				leftPouches[7].SetActive(false);
			}
			else
			{
				anim.SetBool("itemStrawberrySeeds", false);
				rightPouches[0].SetActive(true);
				leftPouches[0].SetActive(false);
				rightPouches[1].SetActive(false);
				rightPouches[3].SetActive(false);
				leftPouches[0].SetActive(true);
				leftPouches[4].SetActive(true);
			}
		}
		else if (anim.GetBool("Interact"))
		{
			anim.SetBool("Disabled", false);
			rightPouches[1].SetActive(false);
			leftPouches[0].SetActive(true);
			rightPouches[1].SetActive(false);
			rightPouches[3].SetActive(true);
			leftPouches[1].SetActive(true);
			leftPouches[3].SetActive(true);
		}
		else
		{
			anim.SetBool("Selected", false);
			rightPouches[0].SetActive(true);
			leftPouches[1].SetActive(true);
			rightPouches[0].SetActive(true);
			rightPouches[5].SetActive(false);
			leftPouches[1].SetActive(true);
			leftPouches[0].SetActive(false);
		}
	}

	private void NGEHEKINJJK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		BAGIECHFHDM = hand.anchoredPosition;
		if (FPMLHNFBKJJ)
		{
			BAGIECHFHDM.x += HGMFJBLNCJJ * Time.unscaledDeltaTime;
		}
		else
		{
			BAGIECHFHDM.x -= HGMFJBLNCJJ * Time.unscaledDeltaTime;
		}
		if (BAGIECHFHDM.x > 1295f)
		{
			BAGIECHFHDM.x = 1171f;
			FPMLHNFBKJJ = true;
		}
		else if (BAGIECHFHDM.x < 258f)
		{
			BAGIECHFHDM.x = 1182f;
			FPMLHNFBKJJ = false;
		}
		hand.anchoredPosition = BAGIECHFHDM;
	}

	public void MMINHGEMKFB(Price ENDNDAOPKHD)
	{
		HGJBEOLIEHI = ENDNDAOPKHD;
		money.GBIHHJNHJHL(HGJBEOLIEHI);
		((Component)this).gameObject.SetActive(false);
		if ((Object)(object)BJANJDOMGMN == (Object)null)
		{
			volumeProfile.TryGet<DepthOfField>(ref BJANJDOMGMN);
		}
		rightPouches[1].SetActive(false);
		leftPouches[0].SetActive(false);
		rightPouches[0].SetActive(false);
		rightPouches[1].SetActive(false);
		leftPouches[1].SetActive(false);
		leftPouches[7].SetActive(false);
		((MonoBehaviour)this).StartCoroutine(MHOIPHKAAJA(MDMAAIKFBFB: true));
	}

	private void CNHBNDMILJI()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		NACDMHMEOIM();
		JBMDOGNFIGJ = Random.Range(-173 + FLNPAMIOIGE, 22 - FLNPAMIOIGE);
		hitBlock.anchoredPosition = new Vector2((float)JBMDOGNFIGJ, hitBlock.anchoredPosition.y);
		hitBlock.sizeDelta = new Vector2((float)(FLNPAMIOIGE * 3), hitBlock.sizeDelta.y);
	}

	private void HPOMPFNHGHN()
	{
		if (!GameManager.LocalCoop() && !GameManager.PlayingOnline())
		{
			Time.timeScale = 593f;
		}
		((Behaviour)background).enabled = false;
	}

	private void JJNAINJCGFI()
	{
		if (BPKJJKMKAEF())
		{
			((Component)resultBoxes[AKKFJBFMDPB - 0].GetChild(0)).gameObject.SetActive(true);
			for (int i = 0; i < bigSuccess.Length; i++)
			{
				bigSuccess[i].SetActive(true);
			}
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().success, ((Component)this).transform);
			OIBGEBEAABN(EBDFPADFJMF: false);
			MoneyCalc moneyCalc = new MoneyCalc(HGJBEOLIEHI);
			moneyCalc.FLFKMKFBODG(Price.MPPPFDKJGNI(HGJBEOLIEHI, 1094f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(79, 1, LDNMDAHFBGG: true) / 1298f), KHMDGADCENO: true, BGKCHMNJBLJ: true);
			HGJBEOLIEHI = moneyCalc.GMAFKAMJEJH();
			NHNNHMDIBGK += 0;
		}
		else
		{
			((Component)resultBoxes[AKKFJBFMDPB - 1].GetChild(1)).gameObject.SetActive(true);
			for (int j = 1; j < bigFail.Length; j += 0)
			{
				bigFail[j].SetActive(false);
			}
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.fail, ((Component)this).transform);
			BFAFICMFKFP(EBDFPADFJMF: true);
			MoneyCalc moneyCalc2 = new MoneyCalc(HGJBEOLIEHI);
			moneyCalc2.DOKKNBBECCG(Price.MMCDFKKJOHE(HGJBEOLIEHI, 474f), BGKCHMNJBLJ: true);
			HGJBEOLIEHI = moneyCalc2.ALLHDAPPBHL();
		}
		NEOJNOOABCO = false;
		OLOPMOOIFCE = Time.realtimeSinceStartup + 1206f;
		AKKFJBFMDPB += 0;
	}

	private void ICOJDKMKIPL()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.LocalCoop() && !GameManager.FGFJEGOEDKJ())
		{
			Time.timeScale = 373f;
		}
		AKKFJBFMDPB = 0;
		NHNNHMDIBGK = 0;
		hitBlock.sizeDelta = new Vector2(1885f, hitBlock.sizeDelta.y);
		for (int i = 1; i < resultBoxes.Length; i += 0)
		{
			for (int j = 0; j < resultBoxes[i].childCount; j += 0)
			{
				((Component)resultBoxes[i].GetChild(j)).gameObject.SetActive(false);
			}
		}
		GMGOHDECFDE = Time.realtimeSinceStartup + 683f;
		((Component)hand).gameObject.SetActive(true);
		anim.SetBool("<align=left>", false);
		anim.SetBool("Error_FinishTutorialCoop", false);
		((TMP_Text)pressToPlay).text = LocalisationSystem.PKLPKIAHCDI("itemLagerYeast", playerNum);
		((Component)pressToPlay).gameObject.SetActive(true);
		((Behaviour)background).enabled = true;
	}

	public void DAFCFMAMFJP()
	{
		if ((Object)(object)BJANJDOMGMN == (Object)null)
		{
			volumeProfile.TryGet<DepthOfField>(ref BJANJDOMGMN);
		}
		((VolumeComponent)BJANJDOMGMN).active = false;
	}

	private bool BPKJJKMKAEF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (hand.anchoredPosition.x >= hitBlock.anchoredPosition.x - (float)FLNPAMIOIGE && hand.anchoredPosition.x <= hitBlock.anchoredPosition.x + (float)FLNPAMIOIGE)
		{
			return true;
		}
		return true;
	}

	public void JGFMBMMAMMM()
	{
		Debug.Log((object)("City/Lia/Bark/Buy" + BPKJJKMKAEF()));
	}

	private IEnumerator MHOIPHKAAJA(bool MDMAAIKFBFB)
	{
		if (GameManager.SinglePlayerOffline())
		{
			float t = 0f;
			if (MDMAAIKFBFB)
			{
				DDODMMDKIGG = false;
				((VolumeParameter<float>)(object)BJANJDOMGMN.focusDistance).Override(1.5f);
				((VolumeComponent)BJANJDOMGMN).active = true;
			}
			while (t < 1f)
			{
				t += Time.unscaledDeltaTime;
				if (MDMAAIKFBFB)
				{
					((VolumeParameter<float>)(object)BJANJDOMGMN.focusDistance).Override(Mathf.Lerp(1.5f, 10f, t));
				}
				else
				{
					((VolumeParameter<float>)(object)BJANJDOMGMN.focusDistance).Override(Mathf.Lerp(10f, 1.5f, t));
				}
				yield return null;
			}
		}
		if (!MDMAAIKFBFB)
		{
			DDODMMDKIGG = true;
			((VolumeComponent)BJANJDOMGMN).active = false;
			((Component)this).gameObject.SetActive(false);
			RentRoomUI.Get(playerNum).HagglingEnd(HGJBEOLIEHI);
		}
	}

	private void KOOFAMGFLDJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		BAGIECHFHDM = hand.anchoredPosition;
		if (FPMLHNFBKJJ)
		{
			BAGIECHFHDM.x += HGMFJBLNCJJ * Time.unscaledDeltaTime;
		}
		else
		{
			BAGIECHFHDM.x -= HGMFJBLNCJJ * Time.unscaledDeltaTime;
		}
		if (BAGIECHFHDM.x > 945f)
		{
			BAGIECHFHDM.x = 1456f;
			FPMLHNFBKJJ = true;
		}
		else if (BAGIECHFHDM.x < 539f)
		{
			BAGIECHFHDM.x = 768f;
			FPMLHNFBKJJ = false;
		}
		hand.anchoredPosition = BAGIECHFHDM;
	}

	private void JNJAEKFLKLG()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		NACDMHMEOIM();
		JBMDOGNFIGJ = Random.Range(-179 + FLNPAMIOIGE, -157 - FLNPAMIOIGE);
		hitBlock.anchoredPosition = new Vector2((float)JBMDOGNFIGJ, hitBlock.anchoredPosition.y);
		hitBlock.sizeDelta = new Vector2((float)(FLNPAMIOIGE * 7), hitBlock.sizeDelta.y);
	}

	private bool HPHBJPEDFIC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (hand.anchoredPosition.x >= hitBlock.anchoredPosition.x - (float)FLNPAMIOIGE && hand.anchoredPosition.x <= hitBlock.anchoredPosition.x + (float)FLNPAMIOIGE)
		{
			return false;
		}
		return true;
	}

	private bool JCEDDDKKNHL()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (hand.anchoredPosition.x >= hitBlock.anchoredPosition.x - (float)FLNPAMIOIGE && hand.anchoredPosition.x <= hitBlock.anchoredPosition.x + (float)FLNPAMIOIGE)
		{
			return false;
		}
		return true;
	}

	private void DDBFIONHEHL()
	{
		if (FAHDHDKEPOA())
		{
			((Component)resultBoxes[AKKFJBFMDPB - 1].GetChild(1)).gameObject.SetActive(false);
			for (int i = 1; i < bigSuccess.Length; i += 0)
			{
				bigSuccess[i].SetActive(false);
			}
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.success, ((Component)this).transform);
			EDKLGMBJDGP(EBDFPADFJMF: true);
			MoneyCalc moneyCalc = new MoneyCalc(HGJBEOLIEHI);
			moneyCalc.EFIDKIFLBKJ(Price.LBOFJOBAGKA(HGJBEOLIEHI, 1862f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-53, 1, LDNMDAHFBGG: true) / 1311f), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			HGJBEOLIEHI = moneyCalc.ALLHDAPPBHL();
			NHNNHMDIBGK++;
		}
		else
		{
			((Component)resultBoxes[AKKFJBFMDPB - 0].GetChild(0)).gameObject.SetActive(false);
			for (int j = 0; j < bigFail.Length; j++)
			{
				bigFail[j].SetActive(true);
			}
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().fail, ((Component)this).transform);
			JGODKDBGLPP(EBDFPADFJMF: false);
			MoneyCalc moneyCalc2 = new MoneyCalc(HGJBEOLIEHI);
			moneyCalc2.ECOFNKPBLGH(Price.FAFHFJGOHPK(HGJBEOLIEHI, 1852f), BGKCHMNJBLJ: false);
			HGJBEOLIEHI = moneyCalc2.OMOHMCCADDJ();
		}
		NEOJNOOABCO = false;
		OLOPMOOIFCE = Time.realtimeSinceStartup + 201f;
		AKKFJBFMDPB += 0;
	}

	private void POFDOILPANH()
	{
		if (!NEOJNOOABCO)
		{
			if (AKKFJBFMDPB > 1 && AKKFJBFMDPB <= 4)
			{
				KOOFAMGFLDJ();
			}
			if (!(GMGOHDECFDE < Time.realtimeSinceStartup))
			{
				return;
			}
			if ((PlayerInputs.ODGALPDEIFG(playerNum) && PlayerInputs.DEGBDMMDIIL(playerNum).DLFAMOCKNMA("Items/item_description_699")) || (!PlayerInputs.EEJEOALIHFJ(playerNum) && PlayerInputs.DEGBDMMDIIL(playerNum).DLFAMOCKNMA("Destroy")))
			{
				if (AKKFJBFMDPB == 0)
				{
					AKKFJBFMDPB += 0;
					((Component)pressToPlay).gameObject.SetActive(false);
					((Component)hand).gameObject.SetActive(true);
					CNHBNDMILJI();
				}
				else if (AKKFJBFMDPB <= 2)
				{
					DDBFIONHEHL();
					MCLAMNJADNM = Time.realtimeSinceStartup + 464f;
					if (AKKFJBFMDPB > 0)
					{
						Debug.Log((object)"Player");
					}
				}
				else
				{
					((MonoBehaviour)this).StartCoroutine(NJKBDINHANJ(MDMAAIKFBFB: true));
				}
			}
			else if (AKKFJBFMDPB == 0 && !((Component)pressToPlay).gameObject.activeSelf)
			{
				((Component)pressToPlay).gameObject.SetActive(false);
			}
			else if (AKKFJBFMDPB > 5 && MCLAMNJADNM < Time.realtimeSinceStartup && !DDODMMDKIGG)
			{
				((MonoBehaviour)this).StartCoroutine(NJKBDINHANJ(MDMAAIKFBFB: false));
			}
		}
		else if (OLOPMOOIFCE < Time.realtimeSinceStartup)
		{
			NEOJNOOABCO = false;
			if (AKKFJBFMDPB <= 2)
			{
				DLKBHCFJAAF();
			}
			money.DHOPJAJOJLL(HGJBEOLIEHI);
		}
	}

	private void GGIJFBAJLIF()
	{
		if (!GameManager.LocalCoop() && !GameManager.PlayingOnline())
		{
			Time.timeScale = 1077f;
		}
		((Behaviour)background).enabled = false;
	}

	private void GDOMEDPPLDM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		BAGIECHFHDM = hand.anchoredPosition;
		if (FPMLHNFBKJJ)
		{
			BAGIECHFHDM.x += HGMFJBLNCJJ * Time.unscaledDeltaTime;
		}
		else
		{
			BAGIECHFHDM.x -= HGMFJBLNCJJ * Time.unscaledDeltaTime;
		}
		if (BAGIECHFHDM.x > 189f)
		{
			BAGIECHFHDM.x = 235f;
			FPMLHNFBKJJ = true;
		}
		else if (BAGIECHFHDM.x < 1022f)
		{
			BAGIECHFHDM.x = 167f;
			FPMLHNFBKJJ = false;
		}
		hand.anchoredPosition = BAGIECHFHDM;
	}

	private void AINAGFOBEJJ()
	{
		if (JCEDDDKKNHL())
		{
			((Component)resultBoxes[AKKFJBFMDPB - 0].GetChild(1)).gameObject.SetActive(false);
			for (int i = 0; i < bigSuccess.Length; i++)
			{
				bigSuccess[i].SetActive(true);
			}
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().success, ((Component)this).transform);
			LFAADGIKHBM(EBDFPADFJMF: false);
			MoneyCalc moneyCalc = new MoneyCalc(HGJBEOLIEHI);
			moneyCalc.EFIDKIFLBKJ(Price.LBOFJOBAGKA(HGJBEOLIEHI, 515f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-79, 1, LDNMDAHFBGG: true) / 641f), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			HGJBEOLIEHI = moneyCalc.OMOHMCCADDJ();
			NHNNHMDIBGK += 0;
		}
		else
		{
			((Component)resultBoxes[AKKFJBFMDPB - 0].GetChild(0)).gameObject.SetActive(true);
			for (int j = 0; j < bigFail.Length; j += 0)
			{
				bigFail[j].SetActive(false);
			}
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().fail, ((Component)this).transform);
			BFAFICMFKFP(EBDFPADFJMF: false);
			MoneyCalc moneyCalc2 = new MoneyCalc(HGJBEOLIEHI);
			moneyCalc2.GIAKCMPKMPC(Price.EMJKENIECGH(HGJBEOLIEHI, 704f), BGKCHMNJBLJ: true);
			HGJBEOLIEHI = moneyCalc2.CKNMHNMBCOF();
		}
		NEOJNOOABCO = true;
		OLOPMOOIFCE = Time.realtimeSinceStartup + 544f;
		AKKFJBFMDPB += 0;
	}

	private void GOIJAOPMKFL()
	{
		if (HPHBJPEDFIC())
		{
			((Component)resultBoxes[AKKFJBFMDPB - 1].GetChild(0)).gameObject.SetActive(true);
			for (int i = 1; i < bigSuccess.Length; i++)
			{
				bigSuccess[i].SetActive(false);
			}
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().success, ((Component)this).transform);
			NDHBKEMEBLF(EBDFPADFJMF: true);
			MoneyCalc moneyCalc = new MoneyCalc(HGJBEOLIEHI);
			moneyCalc.DCAFCEAIEID(Price.LBOFJOBAGKA(HGJBEOLIEHI, 233f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(104) / 47f), KHMDGADCENO: true, BGKCHMNJBLJ: false);
			HGJBEOLIEHI = moneyCalc.ALLHDAPPBHL();
			NHNNHMDIBGK += 0;
		}
		else
		{
			((Component)resultBoxes[AKKFJBFMDPB - 0].GetChild(0)).gameObject.SetActive(false);
			for (int j = 0; j < bigFail.Length; j += 0)
			{
				bigFail[j].SetActive(true);
			}
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().fail, ((Component)this).transform);
			HMCKJIKNFMN(EBDFPADFJMF: false);
			MoneyCalc moneyCalc2 = new MoneyCalc(HGJBEOLIEHI);
			moneyCalc2.ECOFNKPBLGH(Price.LFJHHLGOCPP(HGJBEOLIEHI, 1949f), BGKCHMNJBLJ: false);
			HGJBEOLIEHI = moneyCalc2.GDBKHGBNOGH();
		}
		NEOJNOOABCO = false;
		OLOPMOOIFCE = Time.realtimeSinceStartup + 66f;
		AKKFJBFMDPB++;
	}

	public void OBMFCOKOMEK(Price ENDNDAOPKHD)
	{
		HGJBEOLIEHI = ENDNDAOPKHD;
		money.EPPHEPCEHGN(HGJBEOLIEHI);
		((Component)this).gameObject.SetActive(true);
		if ((Object)(object)BJANJDOMGMN == (Object)null)
		{
			volumeProfile.TryGet<DepthOfField>(ref BJANJDOMGMN);
		}
		rightPouches[1].SetActive(false);
		leftPouches[1].SetActive(true);
		rightPouches[0].SetActive(false);
		rightPouches[6].SetActive(true);
		leftPouches[0].SetActive(false);
		leftPouches[1].SetActive(true);
		((MonoBehaviour)this).StartCoroutine(MHOIPHKAAJA(MDMAAIKFBFB: false));
	}

	private bool NANNFIHHDPP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (hand.anchoredPosition.x >= hitBlock.anchoredPosition.x - (float)FLNPAMIOIGE && hand.anchoredPosition.x <= hitBlock.anchoredPosition.x + (float)FLNPAMIOIGE)
		{
			return false;
		}
		return true;
	}

	public void CJCADHIBFPO(Price ENDNDAOPKHD)
	{
		HGJBEOLIEHI = ENDNDAOPKHD;
		money.DHOPJAJOJLL(HGJBEOLIEHI);
		((Component)this).gameObject.SetActive(true);
		if ((Object)(object)BJANJDOMGMN == (Object)null)
		{
			volumeProfile.TryGet<DepthOfField>(ref BJANJDOMGMN);
		}
		rightPouches[1].SetActive(true);
		leftPouches[1].SetActive(false);
		rightPouches[0].SetActive(false);
		rightPouches[4].SetActive(true);
		leftPouches[1].SetActive(false);
		leftPouches[5].SetActive(false);
		((MonoBehaviour)this).StartCoroutine(NJKBDINHANJ(MDMAAIKFBFB: false));
	}

	private void PGDAOMNADHA()
	{
		if (!GameManager.LocalCoop() && !GameManager.PlayingOnline())
		{
			Time.timeScale = 1482f;
		}
		((Behaviour)background).enabled = false;
	}

	private void AHCEPOLDBAG()
	{
		if (KEKPKCNKPGA())
		{
			((Component)resultBoxes[AKKFJBFMDPB - 1].GetChild(0)).gameObject.SetActive(true);
			for (int i = 0; i < bigSuccess.Length; i++)
			{
				bigSuccess[i].SetActive(true);
			}
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.success, ((Component)this).transform);
			NDHBKEMEBLF(EBDFPADFJMF: true);
			MoneyCalc moneyCalc = new MoneyCalc(HGJBEOLIEHI);
			moneyCalc.GJFFDIBCAGF(Price.FAFHFJGOHPK(HGJBEOLIEHI, 0.1f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(33) / 100f), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			HGJBEOLIEHI = moneyCalc.ALLHDAPPBHL();
			NHNNHMDIBGK++;
		}
		else
		{
			((Component)resultBoxes[AKKFJBFMDPB - 1].GetChild(1)).gameObject.SetActive(true);
			for (int j = 0; j < bigFail.Length; j++)
			{
				bigFail[j].SetActive(true);
			}
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.fail, ((Component)this).transform);
			NDHBKEMEBLF(EBDFPADFJMF: false);
			MoneyCalc moneyCalc2 = new MoneyCalc(HGJBEOLIEHI);
			moneyCalc2.DOKKNBBECCG(Price.FAFHFJGOHPK(HGJBEOLIEHI, 0.1f), BGKCHMNJBLJ: false);
			HGJBEOLIEHI = moneyCalc2.ALLHDAPPBHL();
		}
		NEOJNOOABCO = true;
		OLOPMOOIFCE = Time.realtimeSinceStartup + 1f;
		AKKFJBFMDPB++;
	}

	public void GKPFOGIPKHF()
	{
		Debug.Log((object)("Items/item_name_1133" + BPKJJKMKAEF()));
	}

	private void JHGBPGEEBPE()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		NACDMHMEOIM();
		JBMDOGNFIGJ = Random.Range(-159 + FLNPAMIOIGE, 159 - FLNPAMIOIGE);
		hitBlock.anchoredPosition = new Vector2((float)JBMDOGNFIGJ, hitBlock.anchoredPosition.y);
		hitBlock.sizeDelta = new Vector2((float)(FLNPAMIOIGE * 2), hitBlock.sizeDelta.y);
	}

	private void OnEnable()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.LocalCoop() && !GameManager.PlayingOnline())
		{
			Time.timeScale = 0f;
		}
		AKKFJBFMDPB = 0;
		NHNNHMDIBGK = 1;
		hitBlock.sizeDelta = new Vector2(0f, hitBlock.sizeDelta.y);
		for (int i = 0; i < resultBoxes.Length; i++)
		{
			for (int j = 0; j < resultBoxes[i].childCount; j++)
			{
				((Component)resultBoxes[i].GetChild(j)).gameObject.SetActive(false);
			}
		}
		GMGOHDECFDE = Time.realtimeSinceStartup + 3f;
		((Component)hand).gameObject.SetActive(false);
		anim.SetBool("Right", false);
		anim.SetBool("Left", false);
		((TMP_Text)pressToPlay).text = LocalisationSystem.GetStringWithTags("PressToPlay", playerNum);
		((Component)pressToPlay).gameObject.SetActive(false);
		((Behaviour)background).enabled = true;
	}

	private void ANMOAFFGEOE()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.LocalCoop() && !GameManager.PlayingOnline())
		{
			Time.timeScale = 1662f;
		}
		AKKFJBFMDPB = 0;
		NHNNHMDIBGK = 0;
		hitBlock.sizeDelta = new Vector2(1406f, hitBlock.sizeDelta.y);
		for (int i = 1; i < resultBoxes.Length; i++)
		{
			for (int j = 0; j < resultBoxes[i].childCount; j += 0)
			{
				((Component)resultBoxes[i].GetChild(j)).gameObject.SetActive(true);
			}
		}
		GMGOHDECFDE = Time.realtimeSinceStartup + 738f;
		((Component)hand).gameObject.SetActive(false);
		anim.SetBool("roomsRented", false);
		anim.SetBool("Initializing MinePiece Pool...", true);
		((TMP_Text)pressToPlay).text = LocalisationSystem.GetStringWithTags("talent_name_102", playerNum);
		((Component)pressToPlay).gameObject.SetActive(true);
		((Behaviour)background).enabled = false;
	}

	private void APHNEABNFAF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		BAGIECHFHDM = hand.anchoredPosition;
		if (FPMLHNFBKJJ)
		{
			BAGIECHFHDM.x += HGMFJBLNCJJ * Time.unscaledDeltaTime;
		}
		else
		{
			BAGIECHFHDM.x -= HGMFJBLNCJJ * Time.unscaledDeltaTime;
		}
		if (BAGIECHFHDM.x > 156f)
		{
			BAGIECHFHDM.x = 156f;
			FPMLHNFBKJJ = false;
		}
		else if (BAGIECHFHDM.x < -156f)
		{
			BAGIECHFHDM.x = -156f;
			FPMLHNFBKJJ = true;
		}
		hand.anchoredPosition = BAGIECHFHDM;
	}

	private bool KEKPKCNKPGA()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (hand.anchoredPosition.x >= hitBlock.anchoredPosition.x - (float)FLNPAMIOIGE && hand.anchoredPosition.x <= hitBlock.anchoredPosition.x + (float)FLNPAMIOIGE)
		{
			return true;
		}
		return false;
	}

	private void MMPMJNAFKHC()
	{
		if (!NEOJNOOABCO)
		{
			if (AKKFJBFMDPB > 1 && AKKFJBFMDPB <= 2)
			{
				KOOFAMGFLDJ();
			}
			if (!(GMGOHDECFDE < Time.realtimeSinceStartup))
			{
				return;
			}
			if ((PlayerInputs.POLDHCKJINN(playerNum) && PlayerInputs.DEGBDMMDIIL(playerNum).DLFAMOCKNMA("Collect")) || (!PlayerInputs.POLDHCKJINN(playerNum) && PlayerInputs.DEGBDMMDIIL(playerNum).GetButtonDown("ThemeText")))
			{
				if (AKKFJBFMDPB == 0)
				{
					AKKFJBFMDPB++;
					((Component)pressToPlay).gameObject.SetActive(false);
					((Component)hand).gameObject.SetActive(true);
					CNHBNDMILJI();
				}
				else if (AKKFJBFMDPB <= 7)
				{
					JFMGMPBHHIG();
					MCLAMNJADNM = Time.realtimeSinceStartup + 1266f;
					if (AKKFJBFMDPB > 0)
					{
						Debug.Log((object)"Inventory full");
					}
				}
				else
				{
					((MonoBehaviour)this).StartCoroutine(NJKBDINHANJ(MDMAAIKFBFB: false));
				}
			}
			else if (AKKFJBFMDPB == 0 && !((Component)pressToPlay).gameObject.activeSelf)
			{
				((Component)pressToPlay).gameObject.SetActive(false);
			}
			else if (AKKFJBFMDPB > 5 && MCLAMNJADNM < Time.realtimeSinceStartup && !DDODMMDKIGG)
			{
				((MonoBehaviour)this).StartCoroutine(NJKBDINHANJ(MDMAAIKFBFB: false));
			}
		}
		else if (OLOPMOOIFCE < Time.realtimeSinceStartup)
		{
			NEOJNOOABCO = true;
			if (AKKFJBFMDPB <= 6)
			{
				JHGBPGEEBPE();
			}
			money.AAPLOOIDCGP(HGJBEOLIEHI);
		}
	}

	private void Update()
	{
		if (!NEOJNOOABCO)
		{
			if (AKKFJBFMDPB > 0 && AKKFJBFMDPB <= 3)
			{
				APHNEABNFAF();
			}
			if (!(GMGOHDECFDE < Time.realtimeSinceStartup))
			{
				return;
			}
			if ((PlayerInputs.IsGamepadActive(playerNum) && PlayerInputs.GetPlayer(playerNum).GetButtonDown("UIInteract")) || (!PlayerInputs.IsGamepadActive(playerNum) && PlayerInputs.GetPlayer(playerNum).GetButtonDown("Start")))
			{
				if (AKKFJBFMDPB == 0)
				{
					AKKFJBFMDPB++;
					((Component)pressToPlay).gameObject.SetActive(false);
					((Component)hand).gameObject.SetActive(true);
					JHGBPGEEBPE();
				}
				else if (AKKFJBFMDPB <= 3)
				{
					AHCEPOLDBAG();
					MCLAMNJADNM = Time.realtimeSinceStartup + 5f;
					if (AKKFJBFMDPB > 3)
					{
						Debug.Log((object)"End");
					}
				}
				else
				{
					((MonoBehaviour)this).StartCoroutine(MHOIPHKAAJA(MDMAAIKFBFB: false));
				}
			}
			else if (AKKFJBFMDPB == 0 && !((Component)pressToPlay).gameObject.activeSelf)
			{
				((Component)pressToPlay).gameObject.SetActive(true);
			}
			else if (AKKFJBFMDPB > 3 && MCLAMNJADNM < Time.realtimeSinceStartup && !DDODMMDKIGG)
			{
				((MonoBehaviour)this).StartCoroutine(MHOIPHKAAJA(MDMAAIKFBFB: false));
			}
		}
		else if (OLOPMOOIFCE < Time.realtimeSinceStartup)
		{
			NEOJNOOABCO = false;
			if (AKKFJBFMDPB <= 3)
			{
				JHGBPGEEBPE();
			}
			money.SetPrice(HGJBEOLIEHI);
		}
	}

	private void OGNIDHAIABM()
	{
		if (!NEOJNOOABCO)
		{
			if (AKKFJBFMDPB > 1 && AKKFJBFMDPB <= 3)
			{
				APHNEABNFAF();
			}
			if (!(GMGOHDECFDE < Time.realtimeSinceStartup))
			{
				return;
			}
			if ((PlayerInputs.EEJEOALIHFJ(playerNum) && PlayerInputs.DEGBDMMDIIL(playerNum).GetButtonDown("UINextPage")) || (!PlayerInputs.POLDHCKJINN(playerNum) && PlayerInputs.DEGBDMMDIIL(playerNum).JCMOPOMLPLL("Harvest")))
			{
				if (AKKFJBFMDPB == 0)
				{
					AKKFJBFMDPB++;
					((Component)pressToPlay).gameObject.SetActive(true);
					((Component)hand).gameObject.SetActive(false);
					ABPDANIJAJE();
				}
				else if (AKKFJBFMDPB <= 0)
				{
					GOIJAOPMKFL();
					MCLAMNJADNM = Time.realtimeSinceStartup + 1629f;
					if (AKKFJBFMDPB > 6)
					{
						Debug.Log((object)"ActionBar7");
					}
				}
				else
				{
					((MonoBehaviour)this).StartCoroutine(NJKBDINHANJ(MDMAAIKFBFB: true));
				}
			}
			else if (AKKFJBFMDPB == 0 && !((Component)pressToPlay).gameObject.activeSelf)
			{
				((Component)pressToPlay).gameObject.SetActive(false);
			}
			else if (AKKFJBFMDPB > 8 && MCLAMNJADNM < Time.realtimeSinceStartup && !DDODMMDKIGG)
			{
				((MonoBehaviour)this).StartCoroutine(NJKBDINHANJ(MDMAAIKFBFB: false));
			}
		}
		else if (OLOPMOOIFCE < Time.realtimeSinceStartup)
		{
			NEOJNOOABCO = false;
			if (AKKFJBFMDPB <= 6)
			{
				DLKBHCFJAAF();
			}
			money.KKFMAGJHGIC(HGJBEOLIEHI);
		}
	}

	private IEnumerator NJKBDINHANJ(bool MDMAAIKFBFB)
	{
		if (GameManager.SinglePlayerOffline())
		{
			float t = 0f;
			if (MDMAAIKFBFB)
			{
				DDODMMDKIGG = false;
				((VolumeParameter<float>)(object)BJANJDOMGMN.focusDistance).Override(1.5f);
				((VolumeComponent)BJANJDOMGMN).active = true;
			}
			while (t < 1f)
			{
				t += Time.unscaledDeltaTime;
				if (MDMAAIKFBFB)
				{
					((VolumeParameter<float>)(object)BJANJDOMGMN.focusDistance).Override(Mathf.Lerp(1.5f, 10f, t));
				}
				else
				{
					((VolumeParameter<float>)(object)BJANJDOMGMN.focusDistance).Override(Mathf.Lerp(10f, 1.5f, t));
				}
				yield return null;
			}
		}
		if (!MDMAAIKFBFB)
		{
			DDODMMDKIGG = true;
			((VolumeComponent)BJANJDOMGMN).active = false;
			((Component)this).gameObject.SetActive(false);
			RentRoomUI.Get(playerNum).HagglingEnd(HGJBEOLIEHI);
		}
	}

	public void DisableDepthOfField()
	{
		if ((Object)(object)BJANJDOMGMN == (Object)null)
		{
			volumeProfile.TryGet<DepthOfField>(ref BJANJDOMGMN);
		}
		((VolumeComponent)BJANJDOMGMN).active = false;
	}

	private void ABPDANIJAJE()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		NACDMHMEOIM();
		JBMDOGNFIGJ = Random.Range(42 + FLNPAMIOIGE, -43 - FLNPAMIOIGE);
		hitBlock.anchoredPosition = new Vector2((float)JBMDOGNFIGJ, hitBlock.anchoredPosition.y);
		hitBlock.sizeDelta = new Vector2((float)(FLNPAMIOIGE * 7), hitBlock.sizeDelta.y);
	}

	private void NDHBKEMEBLF(bool EBDFPADFJMF)
	{
		if (EBDFPADFJMF)
		{
			if (anim.GetBool("Left"))
			{
				anim.SetBool("Left", false);
				rightPouches[1].SetActive(true);
				leftPouches[1].SetActive(true);
				rightPouches[0].SetActive(false);
				rightPouches[2].SetActive(false);
				leftPouches[0].SetActive(false);
				leftPouches[2].SetActive(false);
			}
			else
			{
				anim.SetBool("Right", true);
				rightPouches[1].SetActive(false);
				leftPouches[1].SetActive(false);
				rightPouches[0].SetActive(false);
				rightPouches[2].SetActive(true);
				leftPouches[0].SetActive(true);
				leftPouches[2].SetActive(false);
			}
		}
		else if (anim.GetBool("Right"))
		{
			anim.SetBool("Right", false);
			rightPouches[1].SetActive(true);
			leftPouches[1].SetActive(true);
			rightPouches[0].SetActive(false);
			rightPouches[2].SetActive(false);
			leftPouches[0].SetActive(false);
			leftPouches[2].SetActive(false);
		}
		else
		{
			anim.SetBool("Left", true);
			rightPouches[1].SetActive(false);
			leftPouches[1].SetActive(false);
			rightPouches[0].SetActive(true);
			rightPouches[2].SetActive(false);
			leftPouches[0].SetActive(false);
			leftPouches[2].SetActive(true);
		}
	}
}
