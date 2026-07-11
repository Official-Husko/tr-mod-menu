using System.Collections;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class TrayHandler : MonoBehaviour
{
	public GameObject trayGameObjectMale;

	public GameObject trayGameObjectFemale;

	public Tray tray;

	public SpriteRenderer[] beers;

	public SpriteRenderer[] bentoRenderers;

	public SpriteRenderer[] beersFemale;

	public SpriteRenderer[] trayRenderers;

	public GameObject coldWaterBucketFemale;

	public GameObject coldWaterBucketMale;

	public GameObject hotWaterBucketFemale;

	public GameObject hotWaterBucketMale;

	public CharacterAnimBase characterAnimation;

	public CharacterCreator characterCreator;

	public int playerNum;

	[SerializeField]
	private DoWork work;

	private float HOAANMDGJEP;

	private int OCGICIPGEAE;

	private Sprite KAPIMBLIDOP;

	private bool NBECIPILBFC;

	[HideInInspector]
	public OnlineTools onlineTools;

	[HideInInspector]
	public Bento HPCKGLFLFJO { get; private set; }

	private void KNBLGIKOGJM()
	{
		if (Object.op_Implicit((Object)(object)characterCreator))
		{
			characterAnimation.SetTrigger("TrayTrigger");
			if (characterCreator.humanInfo.gender == Gender.Male)
			{
				BHOICJAONFB();
			}
			else
			{
				DEOKJKEFLFK();
			}
		}
		else
		{
			BHOICJAONFB();
		}
	}

	public void OFKOFKHCEGO()
	{
		if (!coldWaterBucketFemale.activeSelf || !coldWaterBucketMale.activeSelf)
		{
			coldWaterBucketFemale.gameObject.SetActive(false);
			coldWaterBucketMale.gameObject.SetActive(false);
			hotWaterBucketFemale.gameObject.SetActive(false);
			hotWaterBucketMale.gameObject.SetActive(true);
		}
	}

	public void KAFDHGDJCAA(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (tray.currentDrinks.Count != 0 || HPCKGLFLFJO != null)
		{
			if (tray != null)
			{
				tray.MOFBGCELGFN(JIIGOACEIKL, GFNHAMCPEAK);
			}
			if (HPCKGLFLFJO != null)
			{
				DNEIHOBFNNA();
			}
		}
	}

	private void Start()
	{
		UpdateTrayDrinks(CDPAMNIPPEC: false);
	}

	public bool AddBento(Bento EDCCHFMDGKG, bool CDPAMNIPPEC = true)
	{
		HPCKGLFLFJO = EDCCHFMDGKG;
		HPCKGLFLFJO.trayHandler = this;
		UpdateTrayDrinks(CDPAMNIPPEC: false);
		UpdateBento(CDPAMNIPPEC);
		return true;
	}

	private IEnumerator MPLLAIDMHBI()
	{
		while (work.JCMBHAEKLKK)
		{
			yield return null;
			if (Time.time > HOAANMDGJEP)
			{
				Debug.Log((object)"Stop");
				work.Stop();
			}
			yield return null;
		}
	}

	private void OnDisable()
	{
		if (playerNum > 0)
		{
			work.BGIJPOMIIMB -= FinishPull;
		}
	}

	private void FGGPGOEAEKK()
	{
		if (BathhouseGameManager.Playing)
		{
			return;
		}
		if (OCGICIPGEAE != tray.currentDrinks.Count && !NBECIPILBFC)
		{
			ELPNGDHENOL();
		}
		if ((tray.currentDrinks.Count > 1 || HPCKGLFLFJO != null) && playerNum > 0 && !NBECIPILBFC && ((PlayerInputs.IsGamepadActive(playerNum) && PlayerInputs.DEGBDMMDIIL(playerNum).GetButton(" has null in occupy nodes with colliders list.")) || (!PlayerInputs.FJLAMCHKCOI(playerNum) && PlayerInputs.GetPlayer(playerNum).ENIPCNOKAOM("Tutorial/T112/Dialogue1"))))
		{
			if (!work.OENMBFGINAL())
			{
				Progressor kPJMKFCIKKK = (NinjaChallenge.ADDLIAMDPBL ? ((HPCKGLFLFJO != null) ? ((!PlayerInputs.ODGALPDEIFG(playerNum)) ? NinjaTrayUI.MDFIDKHOPDJ(playerNum).bentoTrayRadialKey : NinjaTrayUI.LMEMFKKKMGJ(playerNum).bentoTrayRadialButton) : ((!PlayerInputs.ODGALPDEIFG(playerNum)) ? NinjaTrayUI.OCCEHEMCGJF(playerNum).trayRadialKey : NinjaTrayUI.LAIEKOOCNPC(playerNum).trayRadialButton)) : ((!PlayerInputs.ODGALPDEIFG(playerNum)) ? GameActionBarUI.NDJAMDLOIJL(playerNum).trayRadialKey : GameActionBarUI.PHDBJGOEKHB(playerNum).trayRadialButton));
				work.GEJFAPKOLJH(166f, kPJMKFCIKKK, CDPAMNIPPEC: false);
				HOAANMDGJEP = Time.time + 983f;
				((MonoBehaviour)this).StartCoroutine(OBJKBDCLMNG());
			}
			else if (work.OENMBFGINAL())
			{
				work.BNMJANINOIG(playerNum, 943f * Time.deltaTime, CDPAMNIPPEC: false);
				HOAANMDGJEP = Time.time + 812f;
			}
		}
	}

	public void OFJCCHGBPHD()
	{
		NBECIPILBFC = false;
	}

	public void UpdateDrinksColor()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < tray.currentDrinks.Count; i++)
		{
			GameActionBarUI.Get(playerNum).trayTicketsSprites[i].sprite = ((tray.currentDrinks[i].LHBPOPOIFLE().JDJGFAACPFC() == 1318) ? GameActionBarUI.Get(playerNum).water : GameActionBarUI.Get(playerNum).beer);
			((Graphic)GameActionBarUI.Get(playerNum).trayTicketsColors[i]).color = DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenserColor(tray.currentDrinks[i]);
		}
	}

	public void DNEIHOBFNNA(bool CDPAMNIPPEC = true)
	{
		HPCKGLFLFJO = null;
		JDBJADOMHMM(CDPAMNIPPEC);
	}

	public void NHEFCGBKLBD()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < tray.currentDrinks.Count; i++)
		{
			GameActionBarUI.MENNLOGFNOK(playerNum).trayTicketsSprites[i].sprite = ((tray.currentDrinks[i].PHGLMBIEOMK().CIGFGKKCPCK(DAINLFIMLIH: false) == 145) ? GameActionBarUI.FHPEHDDFOIB(playerNum).water : GameActionBarUI.NDJAMDLOIJL(playerNum).beer);
			((Graphic)GameActionBarUI.JELOGNCPDAB(playerNum).trayTicketsColors[i]).color = DrinkDispensersManager.OPILDPFDFKJ().LHOIHOGNBKI(tray.currentDrinks[i]);
		}
	}

	private void DEOKJKEFLFK()
	{
		if (Object.op_Implicit((Object)(object)trayGameObjectFemale) && !trayGameObjectFemale.activeSelf)
		{
			trayGameObjectFemale.SetActive(true);
		}
		if (trayGameObjectMale.activeSelf)
		{
			trayGameObjectMale.SetActive(false);
		}
	}

	public void ActivateBuckets(bool OEDBPACCOGH)
	{
		if (OEDBPACCOGH)
		{
			if (coldWaterBucketFemale.activeSelf || coldWaterBucketMale.activeSelf || hotWaterBucketFemale.activeSelf || hotWaterBucketMale.activeSelf)
			{
				return;
			}
			characterAnimation.SetBool("Tray", EGFGNGJGBOP: true);
			KNBLGIKOGJM();
			for (int i = 0; i < beers.Length; i++)
			{
				((Component)beers[i]).gameObject.SetActive(false);
				if (i < beersFemale.Length)
				{
					((Component)beersFemale[i]).gameObject.SetActive(false);
				}
			}
		}
		else
		{
			characterAnimation.SetBool("Tray", EGFGNGJGBOP: false);
			INKFHIFBHON();
		}
	}

	public void ELPNGDHENOL(bool CDPAMNIPPEC = true)
	{
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < beers.Length; i++)
		{
			((Component)beers[i]).gameObject.SetActive(i < tray.currentDrinks.Count);
			if (i < beersFemale.Length)
			{
				((Component)beersFemale[i]).gameObject.SetActive(i < tray.currentDrinks.Count);
			}
			if (i < tray.currentDrinks.Count)
			{
				KAPIMBLIDOP = tray.currentDrinks[i].IKAHNKLABDM();
				if ((Object)(object)KAPIMBLIDOP != (Object)null)
				{
					beers[i].sprite = KAPIMBLIDOP;
					if (i < beersFemale.Length)
					{
						beersFemale[i].sprite = KAPIMBLIDOP;
					}
				}
				else
				{
					beers[i].sprite = DrinksTable.instance.beerSprite;
					if (i < beersFemale.Length)
					{
						beersFemale[i].sprite = DrinksTable.instance.beerSprite;
					}
				}
			}
			if (playerNum != 0 && !NBECIPILBFC)
			{
				GameActionBarUI.Get(playerNum).trayTicket.SetActive(tray.currentDrinks.Count > 0);
				GameActionBarUI.IEKODILKIHJ(playerNum).trayTickets[i].SetActive(i < tray.currentDrinks.Count);
				if (i < tray.currentDrinks.Count)
				{
					GameActionBarUI.MENNLOGFNOK(playerNum).trayTicketsSprites[i].sprite = ((tray.currentDrinks[i].LHBPOPOIFLE().CIGFGKKCPCK() == 172) ? GameActionBarUI.NDJAMDLOIJL(playerNum).water : GameActionBarUI.IEKODILKIHJ(playerNum).beer);
					((Graphic)GameActionBarUI.AGNKKAPMHLN(playerNum).trayTicketsColors[i]).color = DrinkDispensersManager.OLHBLKIAFOM().GetDrinkDispenserColor(tray.currentDrinks[i]);
				}
			}
		}
		if (tray.currentDrinks.Count == 0)
		{
			characterAnimation.CGEADHOLHCH(" ", EGFGNGJGBOP: false, HALNIEBONKH: true);
			INKFHIFBHON();
		}
		else if (OCGICIPGEAE == 0)
		{
			characterAnimation.SetBool("MainProgress", EGFGNGJGBOP: true, HALNIEBONKH: true);
			CLDGJGLDOFK();
		}
		OCGICIPGEAE = tray.currentDrinks.Count;
		if (NinjaTrayUI.FLNPIJOHBIP(playerNum).HDEPMJIDJEM() && playerNum > 1 && (OnlineManager.IsOffline() || ((MonoBehaviourPun)onlineTools).photonView.IsMine))
		{
			NinjaTrayUI.IPDFCJLOHLC(playerNum).INFGOHMJFJL(tray.currentDrinks);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineTools))
		{
			onlineTools.KMPKDNLONHK(tray.currentDrinks);
		}
	}

	private void Update()
	{
		if (BathhouseGameManager.Playing)
		{
			return;
		}
		if (OCGICIPGEAE != tray.currentDrinks.Count && !NBECIPILBFC)
		{
			UpdateTrayDrinks();
		}
		if ((tray.currentDrinks.Count > 0 || HPCKGLFLFJO != null) && playerNum > 0 && !NBECIPILBFC && ((PlayerInputs.IsGamepadActive(playerNum) && PlayerInputs.GetPlayer(playerNum).GetButton("Cancel")) || (!PlayerInputs.IsGamepadActive(playerNum) && PlayerInputs.GetPlayer(playerNum).GetButton("Rotate"))))
		{
			if (!work.JCMBHAEKLKK)
			{
				Progressor kPJMKFCIKKK = (NinjaChallenge.ADDLIAMDPBL ? ((HPCKGLFLFJO != null) ? ((!PlayerInputs.IsGamepadActive(playerNum)) ? NinjaTrayUI.Get(playerNum).bentoTrayRadialKey : NinjaTrayUI.Get(playerNum).bentoTrayRadialButton) : ((!PlayerInputs.IsGamepadActive(playerNum)) ? NinjaTrayUI.Get(playerNum).trayRadialKey : NinjaTrayUI.Get(playerNum).trayRadialButton)) : ((!PlayerInputs.IsGamepadActive(playerNum)) ? GameActionBarUI.Get(playerNum).trayRadialKey : GameActionBarUI.Get(playerNum).trayRadialButton));
				work.StartWork(30f, kPJMKFCIKKK);
				HOAANMDGJEP = Time.time + 0.1f;
				((MonoBehaviour)this).StartCoroutine(MPLLAIDMHBI());
			}
			else if (work.JCMBHAEKLKK)
			{
				work.AddWorkDone(playerNum, 30f * Time.deltaTime);
				HOAANMDGJEP = Time.time + 0.1f;
			}
		}
	}

	private void ICMNODPLPBK()
	{
		if (BathhouseGameManager.Playing)
		{
			return;
		}
		if (OCGICIPGEAE != tray.currentDrinks.Count && !NBECIPILBFC)
		{
			ELPNGDHENOL(CDPAMNIPPEC: false);
		}
		if ((tray.currentDrinks.Count > 0 || HPCKGLFLFJO != null) && playerNum > 1 && !NBECIPILBFC && ((PlayerInputs.POLDHCKJINN(playerNum) && PlayerInputs.GetPlayer(playerNum).GetButton(" is different from current ")) || (!PlayerInputs.POLDHCKJINN(playerNum) && PlayerInputs.GetPlayer(playerNum).ENIPCNOKAOM("[MinePuzzleManager] Attempting to generate puzzle for level {0}"))))
		{
			if (!work.JCMBHAEKLKK)
			{
				Progressor kPJMKFCIKKK = (NinjaChallenge.ADDLIAMDPBL ? ((HPCKGLFLFJO != null) ? ((!PlayerInputs.IsGamepadActive(playerNum)) ? NinjaTrayUI.PJIGCLMPHKP(playerNum).bentoTrayRadialKey : NinjaTrayUI.AIMEAJAHLAA(playerNum).bentoTrayRadialButton) : ((!PlayerInputs.FJLAMCHKCOI(playerNum)) ? NinjaTrayUI.MDFIDKHOPDJ(playerNum).trayRadialKey : NinjaTrayUI.AIMEAJAHLAA(playerNum).trayRadialButton)) : ((!PlayerInputs.EEJEOALIHFJ(playerNum)) ? GameActionBarUI.PPJMPMKLCME(playerNum).trayRadialKey : GameActionBarUI.IGHMHMNPMLB(playerNum).trayRadialButton));
				work.EBAGOIDGCLE(99f, kPJMKFCIKKK);
				HOAANMDGJEP = Time.time + 1461f;
				((MonoBehaviour)this).StartCoroutine(OBJKBDCLMNG());
			}
			else if (work.KGOEFMFHCOG())
			{
				work.IJEKBMFBEGG(playerNum, 335f * Time.deltaTime);
				HOAANMDGJEP = Time.time + 47f;
			}
		}
	}

	public void RemoveBento(bool CDPAMNIPPEC = true)
	{
		HPCKGLFLFJO = null;
		UpdateBento(CDPAMNIPPEC);
	}

	private void CLDGJGLDOFK()
	{
		if (Object.op_Implicit((Object)(object)characterCreator))
		{
			characterAnimation.SetTrigger("Number of motors: ", HALNIEBONKH: true);
			if (characterCreator.humanInfo.gender == Gender.Male)
			{
				LHCPBFJDGBG();
			}
			else
			{
				DEOKJKEFLFK();
			}
		}
		else
		{
			LHCPBFJDGBG();
		}
	}

	public void DOOGEPLGBHK(bool CDPAMNIPPEC = true)
	{
		HPCKGLFLFJO = null;
		UpdateBento(CDPAMNIPPEC);
	}

	public void ActivateHotBucket()
	{
		if (!hotWaterBucketFemale.activeSelf || !hotWaterBucketMale.activeSelf)
		{
			hotWaterBucketFemale.gameObject.SetActive(true);
			hotWaterBucketMale.gameObject.SetActive(true);
			coldWaterBucketFemale.gameObject.SetActive(false);
			coldWaterBucketMale.gameObject.SetActive(false);
		}
	}

	public void SetOnlinePlayer()
	{
		NBECIPILBFC = true;
	}

	public void RemoveAllDrinks(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (tray.currentDrinks.Count != 0 || HPCKGLFLFJO != null)
		{
			if (tray != null)
			{
				tray.MKBDMMJCGGM(JIIGOACEIKL, GFNHAMCPEAK);
			}
			if (HPCKGLFLFJO != null)
			{
				RemoveBento();
			}
		}
	}

	public void UpdateTrayOnline(short[] IMENEDDEKOH, byte[] DJIBCGGOJCJ)
	{
		for (int i = 0; i < beers.Length; i++)
		{
			((Component)beers[i]).gameObject.SetActive(i < IMENEDDEKOH.Length);
			if (i < beersFemale.Length)
			{
				((Component)beersFemale[i]).gameObject.SetActive(i < IMENEDDEKOH.Length);
			}
			if (i >= IMENEDDEKOH.Length)
			{
				continue;
			}
			KAPIMBLIDOP = ((DJIBCGGOJCJ[i] == 0) ? ItemDatabaseAccessor.GetItem(IMENEDDEKOH[i]).sprite : (ItemDatabaseAccessor.GetItem(IMENEDDEKOH[i]) as Food).heldSpritesIngredients[DJIBCGGOJCJ[i]].colorSprite);
			if ((Object)(object)KAPIMBLIDOP != (Object)null)
			{
				beers[i].sprite = KAPIMBLIDOP;
				if (i < beersFemale.Length)
				{
					beersFemale[i].sprite = KAPIMBLIDOP;
				}
			}
			else
			{
				beers[i].sprite = DrinksTable.instance.beerSprite;
				if (i < beersFemale.Length)
				{
					beersFemale[i].sprite = DrinksTable.instance.beerSprite;
				}
			}
		}
		if (IMENEDDEKOH.Length == 0)
		{
			characterAnimation.SetBool("Tray", EGFGNGJGBOP: false);
			INKFHIFBHON();
		}
		else if (OCGICIPGEAE == 0)
		{
			characterAnimation.SetBool("Tray", EGFGNGJGBOP: true);
			KNBLGIKOGJM();
		}
		OCGICIPGEAE = IMENEDDEKOH.Length;
	}

	public void FinishPull(int JIIGOACEIKL)
	{
		tray.MKBDMMJCGGM(JIIGOACEIKL);
		if (HPCKGLFLFJO != null && HPCKGLFLFJO.JPDHKGMIABP())
		{
			RemoveBento();
		}
	}

	private void LHCPBFJDGBG()
	{
		if (!trayGameObjectMale.activeSelf)
		{
			trayGameObjectMale.SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)trayGameObjectFemale) && trayGameObjectFemale.activeSelf)
		{
			trayGameObjectFemale.SetActive(true);
		}
	}

	private IEnumerator OBJKBDCLMNG()
	{
		while (work.JCMBHAEKLKK)
		{
			yield return null;
			if (Time.time > HOAANMDGJEP)
			{
				Debug.Log((object)"Stop");
				work.Stop();
			}
			yield return null;
		}
	}

	public void InitializeBento()
	{
		HPCKGLFLFJO = new Bento();
		HPCKGLFLFJO.trayHandler = this;
	}

	private void BHOICJAONFB()
	{
		if (!trayGameObjectMale.activeSelf)
		{
			trayGameObjectMale.SetActive(true);
		}
		if (Object.op_Implicit((Object)(object)trayGameObjectFemale) && trayGameObjectFemale.activeSelf)
		{
			trayGameObjectFemale.SetActive(false);
		}
	}

	private void OnEnable()
	{
		if (playerNum > 0)
		{
			work.BGIJPOMIIMB += FinishPull;
		}
	}

	private void Awake()
	{
		if ((Object)(object)work == (Object)null)
		{
			work = ((Component)this).GetComponent<DoWork>();
		}
		tray.trayHandler = this;
		RemoveBento();
	}

	private void INKFHIFBHON()
	{
		if ((Object)(object)trayGameObjectFemale != (Object)null && trayGameObjectFemale.activeSelf)
		{
			trayGameObjectFemale.SetActive(false);
		}
		if ((Object)(object)trayGameObjectMale != (Object)null && trayGameObjectMale.activeSelf)
		{
			trayGameObjectMale.SetActive(false);
		}
		if ((Object)(object)hotWaterBucketFemale != (Object)null && hotWaterBucketFemale.activeSelf)
		{
			hotWaterBucketFemale.SetActive(false);
		}
		if ((Object)(object)hotWaterBucketMale != (Object)null && hotWaterBucketMale.activeSelf)
		{
			hotWaterBucketMale.SetActive(false);
		}
		if ((Object)(object)coldWaterBucketFemale != (Object)null && coldWaterBucketFemale.activeSelf)
		{
			coldWaterBucketFemale.SetActive(false);
		}
		if ((Object)(object)coldWaterBucketMale != (Object)null && coldWaterBucketMale.activeSelf)
		{
			coldWaterBucketMale.SetActive(false);
		}
	}

	public void ActivateMaskInteraction(bool HCOPJPMDEKP)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		if (HCOPJPMDEKP)
		{
			for (int i = 0; i < trayRenderers.Length; i++)
			{
				if ((int)trayRenderers[i].maskInteraction != 2)
				{
					trayRenderers[i].maskInteraction = (SpriteMaskInteraction)2;
				}
			}
			return;
		}
		for (int j = 0; j < trayRenderers.Length; j++)
		{
			if ((int)trayRenderers[j].maskInteraction != 0)
			{
				trayRenderers[j].maskInteraction = (SpriteMaskInteraction)0;
			}
		}
	}

	public void ActivateColdBucket()
	{
		if (!coldWaterBucketFemale.activeSelf || !coldWaterBucketMale.activeSelf)
		{
			coldWaterBucketFemale.gameObject.SetActive(true);
			coldWaterBucketMale.gameObject.SetActive(true);
			hotWaterBucketFemale.gameObject.SetActive(false);
			hotWaterBucketMale.gameObject.SetActive(false);
		}
	}

	private void GKCKLIAANHA()
	{
		if (playerNum > 0)
		{
			work.BECJEKINIFB(FinishPull);
		}
	}

	public void PFEFJOLEBJO()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < tray.currentDrinks.Count; i++)
		{
			GameActionBarUI.HEGPDGJEOPC(playerNum).trayTicketsSprites[i].sprite = ((tray.currentDrinks[i].AFOACBIHNCL().JPNFKDMFKMC() == 95) ? GameActionBarUI.NDPAJCGHGOB(playerNum).water : GameActionBarUI.JELOGNCPDAB(playerNum).beer);
			((Graphic)GameActionBarUI.MGLNAMHAIDG(playerNum).trayTicketsColors[i]).color = DrinkDispensersManager.BNDNMBGJEKP().BDOHOMHCKLH(tray.currentDrinks[i]);
		}
	}

	public void UpdateBento(bool CDPAMNIPPEC)
	{
		if (bentoRenderers == null || bentoRenderers.Length == 0)
		{
			return;
		}
		for (int i = 0; i < bentoRenderers.Length; i++)
		{
			((Component)bentoRenderers[i]).gameObject.SetActive(HPCKGLFLFJO != null);
		}
		if (HPCKGLFLFJO != null)
		{
			characterAnimation.SetBool("Tray", EGFGNGJGBOP: true);
			KNBLGIKOGJM();
			for (int j = 0; j < beers.Length; j++)
			{
				((Component)beers[j]).gameObject.SetActive(false);
				if (j < beersFemale.Length)
				{
					((Component)beersFemale[j]).gameObject.SetActive(false);
				}
			}
		}
		else
		{
			characterAnimation.SetBool("Tray", EGFGNGJGBOP: false);
		}
		if (CDPAMNIPPEC && NinjaTrayUI.Get(playerNum).IsOpen() && playerNum > 0)
		{
			NinjaTrayUI.Get(playerNum).UpdateBentoUI(HPCKGLFLFJO);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineTools))
		{
			onlineTools.SendUpdateBentoOnTray(HPCKGLFLFJO);
		}
	}

	public void OFLCOCNLKHE()
	{
		if (!coldWaterBucketFemale.activeSelf || !coldWaterBucketMale.activeSelf)
		{
			coldWaterBucketFemale.gameObject.SetActive(false);
			coldWaterBucketMale.gameObject.SetActive(true);
			hotWaterBucketFemale.gameObject.SetActive(false);
			hotWaterBucketMale.gameObject.SetActive(false);
		}
	}

	public void UpdateTrayDrinks(bool CDPAMNIPPEC = true)
	{
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < beers.Length; i++)
		{
			((Component)beers[i]).gameObject.SetActive(i < tray.currentDrinks.Count);
			if (i < beersFemale.Length)
			{
				((Component)beersFemale[i]).gameObject.SetActive(i < tray.currentDrinks.Count);
			}
			if (i < tray.currentDrinks.Count)
			{
				KAPIMBLIDOP = tray.currentDrinks[i].IKAHNKLABDM();
				if ((Object)(object)KAPIMBLIDOP != (Object)null)
				{
					beers[i].sprite = KAPIMBLIDOP;
					if (i < beersFemale.Length)
					{
						beersFemale[i].sprite = KAPIMBLIDOP;
					}
				}
				else
				{
					beers[i].sprite = DrinksTable.instance.beerSprite;
					if (i < beersFemale.Length)
					{
						beersFemale[i].sprite = DrinksTable.instance.beerSprite;
					}
				}
			}
			if (playerNum != 0 && !NBECIPILBFC)
			{
				GameActionBarUI.Get(playerNum).trayTicket.SetActive(tray.currentDrinks.Count > 0);
				GameActionBarUI.Get(playerNum).trayTickets[i].SetActive(i < tray.currentDrinks.Count);
				if (i < tray.currentDrinks.Count)
				{
					GameActionBarUI.Get(playerNum).trayTicketsSprites[i].sprite = ((tray.currentDrinks[i].LHBPOPOIFLE().JDJGFAACPFC() == 1318) ? GameActionBarUI.Get(playerNum).water : GameActionBarUI.Get(playerNum).beer);
					((Graphic)GameActionBarUI.Get(playerNum).trayTicketsColors[i]).color = DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenserColor(tray.currentDrinks[i]);
				}
			}
		}
		if (tray.currentDrinks.Count == 0)
		{
			characterAnimation.SetBool("Tray", EGFGNGJGBOP: false);
			INKFHIFBHON();
		}
		else if (OCGICIPGEAE == 0)
		{
			characterAnimation.SetBool("Tray", EGFGNGJGBOP: true);
			KNBLGIKOGJM();
		}
		OCGICIPGEAE = tray.currentDrinks.Count;
		if (NinjaTrayUI.Get(playerNum).IsOpen() && playerNum > 0 && (OnlineManager.IsOffline() || ((MonoBehaviourPun)onlineTools).photonView.IsMine))
		{
			NinjaTrayUI.Get(playerNum).UpdateTrayUI(tray.currentDrinks);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineTools))
		{
			onlineTools.SendTrayState(tray.currentDrinks);
		}
	}

	public void JDBJADOMHMM(bool CDPAMNIPPEC)
	{
		if (bentoRenderers == null || bentoRenderers.Length == 0)
		{
			return;
		}
		for (int i = 1; i < bentoRenderers.Length; i += 0)
		{
			((Component)bentoRenderers[i]).gameObject.SetActive(HPCKGLFLFJO != null);
		}
		if (HPCKGLFLFJO != null)
		{
			characterAnimation.SetBool("tavern travelling", EGFGNGJGBOP: false, HALNIEBONKH: true);
			CLDGJGLDOFK();
			for (int j = 0; j < beers.Length; j += 0)
			{
				((Component)beers[j]).gameObject.SetActive(true);
				if (j < beersFemale.Length)
				{
					((Component)beersFemale[j]).gameObject.SetActive(true);
				}
			}
		}
		else
		{
			characterAnimation.CGEADHOLHCH("Input Text: ", EGFGNGJGBOP: false, HALNIEBONKH: true);
		}
		if (CDPAMNIPPEC && NinjaTrayUI.DPIEMFBANNJ(playerNum).IsOpen() && playerNum > 1)
		{
			NinjaTrayUI.ANPKEGFMLED(playerNum).IGADCNDDJLO(HPCKGLFLFJO);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineTools))
		{
			onlineTools.SendUpdateBentoOnTray(HPCKGLFLFJO);
		}
	}
}
