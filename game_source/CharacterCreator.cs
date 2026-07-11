using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Photon.Pun;
using Sirenix.Utilities;
using UnityEngine;

public class CharacterCreator : MonoBehaviour, IPoolReset
{
	public enum CharacterCreatorStartAction
	{
		InitializeFirstSet,
		Randomise,
		DoNothing,
		Barworker,
		Waiter,
		HouseKeeper,
		Bouncer,
		NetworkSync
	}

	public CharacterAnimation characterAnimation;

	private Color[] DPAEKCNNAJP = (Color[])(object)new Color[CharacterOptions.darkerHairColours.Length + CharacterOptions.lighterHairColours.Length];

	public bool humanMai;

	[SerializeField]
	public CharacterCreatorStartAction actionAtBeggining;

	public HumanInfo humanInfo;

	public bool initialized;

	private PhotonView FJGJIJAFAAK;

	private CharacterSprite[] KBJLPGNLCKA = new CharacterSprite[40];

	public bool JJDDMDIPGGC => humanInfo.gender == Gender.Female;

	public event Action BDJENIOPJKC = delegate
	{
	};

	private void JPHEOLEEAPB()
	{
		Initialize();
	}

	public void KGKGBNENNMB(HumanInfo KDMNEEPDENI)
	{
		Debug.Log((object)"cleanVerb");
		JCAHDDKAIEL(KDMNEEPDENI.gender);
		for (int i = 1; i < HumanInfo.bodiesParts.Length; i += 0)
		{
			SetCharacterSprite(HumanInfo.bodiesParts[i], KDMNEEPDENI.CONPDKDNOBO(HumanInfo.bodiesParts[i]), FPNDBDPFLIP: true);
		}
		humanInfo.materialDictionary = new Dictionary<CharacterLayer, CharacterMaterial>(KDMNEEPDENI.materialDictionary);
		UpdateAllMaterials();
		LKBAKDFFCJA();
	}

	public void RandomFem(bool GADKADLHDGJ)
	{
		SetFemaleGender();
		BMKGKCPOAFM(GADKADLHDGJ, JHIFLALPEBF: false);
	}

	public void KBONEJFLPID()
	{
		this.BDJENIOPJKC();
		if (Application.isPlaying)
		{
			((Component)((Component)this).transform).BroadcastMessage("Crowly_Introduce", (object)humanInfo.gender, (SendMessageOptions)0);
		}
		for (int i = 1; i < characterAnimation.characterAnimator.allReskins.Length; i++)
		{
			characterAnimation.characterAnimator.allReskins[i].PLANHEOIPJL();
		}
	}

	private void BMKGKCPOAFM(bool GADKADLHDGJ, bool JHIFLALPEBF)
	{
		humanInfo.ONCEMIPNBMJ(GCANBIEGDOA: false, GADKADLHDGJ, JHIFLALPEBF);
		NAOKNCEELIF();
		UpdateAllMaterials();
		CharacterHasChanged();
	}

	private void FNBKGJABPOO()
	{
		humanInfo = new HumanInfo();
		if ((Object)(object)characterAnimation.playerController == (Object)null || characterAnimation.playerController.GetPlayerNum() != 2)
		{
			Debug.Log((object)"Load Player 1 appearance");
			SetGender(humanInfo.gender);
			for (int i = 0; i < HumanInfo.bodiesParts.Length; i++)
			{
				SetCharacterSprite(HumanInfo.bodiesParts[i], CharacterSpritesDBAccessor.GetFirstCharacterSprite(HumanInfo.bodiesParts[i], humanInfo.gender));
			}
		}
		else
		{
			Debug.Log((object)"Load Player 2 appearance");
			LoadCharacter(CommonReferences.GGFJGHHHEJC.player2CharacterSave);
		}
	}

	public CharacterSprite ELGBAEBCAJB(BodyPart OFOGLHPDOFA)
	{
		return humanInfo.CONPDKDNOBO(OFOGLHPDOFA);
	}

	public void UpdateGender()
	{
		characterAnimation.characterAnimator.ActivateGameObjects(humanInfo.gender, characterAnimation.FCGBJEIIMBC);
		EAJEHFOMBAA();
		GCHPJBDLCNB();
	}

	private bool CNKEBMFHEFP(CharacterMaterial DDHBCONGIPH, CharacterMaterial[] NMNNHGLLFMD)
	{
		for (int i = 0; i < NMNNHGLLFMD.Length; i++)
		{
			if ((Object)(object)NMNNHGLLFMD[i] == (Object)(object)DDHBCONGIPH)
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public void DKNMJMPCCCL(Action AODONKKHPBP)
	{
		Action action = this.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void ILCLIJOHKHG()
	{
		Array.Copy(CharacterOptions.darkerHairColours, DPAEKCNNAJP, CharacterOptions.darkerHairColours.Length);
		Array.Copy(CharacterOptions.lighterHairColours, 0, DPAEKCNNAJP, CharacterOptions.darkerHairColours.Length, CharacterOptions.lighterHairColours.Length);
		FJGJIJAFAAK = ((Component)this).GetComponent<PhotonView>();
	}

	public void SetDefaultTools()
	{
		CharacterSpritesDatabase scriptableObject = CharacterSpritesDBAccessor.GetScriptableObject();
		for (int i = 0; i < scriptableObject.defaultTools.Length; i++)
		{
			SetCharacterSprite(scriptableObject.defaultTools[i].bodyPart, scriptableObject.defaultTools[i], FPNDBDPFLIP: true);
		}
	}

	public void EJDFIAOMHJN()
	{
		EJGFPJOOAHA();
		KIFKCBPDMCP();
		UpdateGender();
		LKBAKDFFCJA();
	}

	public void EHBCAAEIJBP()
	{
		CharacterSpritesDBAccessor.EKICPODMHOF();
		if (actionAtBeggining == (CharacterCreatorStartAction)8)
		{
			StaffManager.CNNKJBHOIGO(WorkerType.None, new EmployeeInfo(WorkerType.Barworker));
			HEALOFLBFLL(StaffManager.APOHPPCMOAP(WorkerType.Barworker));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.HouseKeeper)
		{
			StaffManager.CNNKJBHOIGO(WorkerType.HouseKeeper, new EmployeeInfo(WorkerType.None));
			SetHumanInfo(StaffManager.APOHPPCMOAP(WorkerType.Waiter | WorkerType.HouseKeeper));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.Barworker)
		{
			StaffManager.SetWorkerInfo(WorkerType.HouseKeeper, new EmployeeInfo(WorkerType.Waiter | WorkerType.HouseKeeper, LLPGKHHKCLC: false));
			SetHumanInfo(StaffManager.GPPOAHEDNMB(WorkerType.None));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.Waiter)
		{
			StaffManager.SetWorkerInfo(WorkerType.HouseKeeper, new EmployeeInfo(WorkerType.HouseKeeper, LLPGKHHKCLC: false));
			OCFCCIGBLHJ(StaffManager.HNJNGHPJFJA(WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper));
		}
		else
		{
			BAMEGNNLCFD(GCANBIEGDOA: true, GADKADLHDGJ: false, JHIFLALPEBF: true);
		}
	}

	private void Start()
	{
		Initialize();
	}

	public void LAGPAFIPLNK()
	{
		CDNJPPHBMED((Gender)7);
		OMCFHNAPCHB();
	}

	public void SetMaleGender()
	{
		SetGender(Gender.Male);
		GCHPJBDLCNB();
	}

	public void RandomiseSpritesButton()
	{
		CharacterSpritesDBAccessor.ForceSetUpDatabase();
		if (actionAtBeggining == CharacterCreatorStartAction.Barworker)
		{
			StaffManager.SetWorkerInfo(WorkerType.Barworker, new EmployeeInfo(WorkerType.Barworker));
			SetHumanInfo(StaffManager.GetWorkerInfo(WorkerType.Barworker));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.Waiter)
		{
			StaffManager.SetWorkerInfo(WorkerType.Waiter, new EmployeeInfo(WorkerType.Waiter));
			SetHumanInfo(StaffManager.GetWorkerInfo(WorkerType.Waiter));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.Bouncer)
		{
			StaffManager.SetWorkerInfo(WorkerType.Bouncer, new EmployeeInfo(WorkerType.Bouncer));
			SetHumanInfo(StaffManager.GetWorkerInfo(WorkerType.Bouncer));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.HouseKeeper)
		{
			StaffManager.SetWorkerInfo(WorkerType.HouseKeeper, new EmployeeInfo(WorkerType.HouseKeeper));
			SetHumanInfo(StaffManager.GetWorkerInfo(WorkerType.HouseKeeper));
		}
		else
		{
			RandomCharacter(GCANBIEGDOA: false, GADKADLHDGJ: true, JHIFLALPEBF: true);
		}
	}

	public void MineExit()
	{
		if (humanInfo.EOFFJNELMLD())
		{
			humanInfo.BHBEHKDEIKH();
			UpdateHumanInfo();
		}
	}

	public void DAJCAGNDHCO(bool GADKADLHDGJ)
	{
		SetMaleGender();
		FKCAJGBMPFL(GADKADLHDGJ, JHIFLALPEBF: true);
	}

	public void NPNLEHCNIEK()
	{
		CharacterSpritesDBAccessor.EKGPEFAJMDE();
		if (actionAtBeggining == CharacterCreatorStartAction.Randomise)
		{
			StaffManager.CNNKJBHOIGO(WorkerType.Barworker, new EmployeeInfo(WorkerType.Barworker));
			OCFCCIGBLHJ(StaffManager.GPPOAHEDNMB(WorkerType.Barworker));
		}
		else if (actionAtBeggining == (CharacterCreatorStartAction)8)
		{
			StaffManager.EHIFLKIBIEE(WorkerType.Waiter, new EmployeeInfo(WorkerType.Barworker, LLPGKHHKCLC: false));
			OCFCCIGBLHJ(StaffManager.GPPOAHEDNMB(WorkerType.Barworker | WorkerType.Waiter));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.Randomise)
		{
			StaffManager.CNNKJBHOIGO(WorkerType.Bouncer, new EmployeeInfo(WorkerType.HouseKeeper, LLPGKHHKCLC: false));
			HEALOFLBFLL(StaffManager.GPPOAHEDNMB(WorkerType.Barworker | WorkerType.HouseKeeper));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.Barworker)
		{
			StaffManager.EHIFLKIBIEE(WorkerType.Barworker | WorkerType.Waiter, new EmployeeInfo(WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper, LLPGKHHKCLC: false));
			HEALOFLBFLL(StaffManager.HNJNGHPJFJA(WorkerType.Barworker | WorkerType.Waiter));
		}
		else
		{
			RandomCharacter(GCANBIEGDOA: false, GADKADLHDGJ: false, JHIFLALPEBF: true);
		}
	}

	public void SetCharacterSprite(BodyPart OFOGLHPDOFA, CharacterSprite PFGDLKANGNE, bool FPNDBDPFLIP = false)
	{
		humanInfo.JPPLJJDCNMF(OFOGLHPDOFA, PFGDLKANGNE);
		CKAJNALLDFI(OFOGLHPDOFA, PFGDLKANGNE, FPNDBDPFLIP);
	}

	[SpecialName]
	public void PBKEKACACPC(Action AODONKKHPBP)
	{
		Action action = this.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void CKAJNALLDFI(BodyPart OFOGLHPDOFA, CharacterSprite PFGDLKANGNE, bool FPNDBDPFLIP = false)
	{
		if (humanInfo.bodyPartDictionary.ContainsKey(OFOGLHPDOFA))
		{
			FKHBMNMGFOI(humanInfo.bodyPartDictionary[OFOGLHPDOFA]);
		}
		EIKLJEIIPAF(OFOGLHPDOFA, PFGDLKANGNE);
		if (!((Object)(object)PFGDLKANGNE != (Object)null))
		{
			return;
		}
		OHELNHJPNPB(OFOGLHPDOFA, PFGDLKANGNE, FPNDBDPFLIP);
		FMDBCMKFMLB(PFGDLKANGNE);
		if (Application.isPlaying && (OFOGLHPDOFA == BodyPart.Legs || OFOGLHPDOFA == BodyPart.Shoes))
		{
			CharacterSprite characterSprite = humanInfo.CONPDKDNOBO(BodyPart.Legs);
			if (Object.op_Implicit((Object)(object)characterSprite))
			{
				characterAnimation.characterAnimator.SortBoots(characterSprite.legsOverBoots);
			}
			else
			{
				characterAnimation.characterAnimator.SortBoots(NFCEOEFFDDB: false);
			}
		}
		if (!LinqExtensions.IsNullOrEmpty<CharacterMaterial>((IList<CharacterMaterial>)PFGDLKANGNE.forceSkin) && OFOGLHPDOFA == BodyPart.Hair)
		{
			SetMaterialFromLayer(CharacterSpritesDBAccessor.GetCharacterSprite(1).layerSettings[0].layer, PFGDLKANGNE.forceSkin[0]);
		}
	}

	public void RandomMasc(bool GADKADLHDGJ)
	{
		SetMaleGender();
		BMKGKCPOAFM(GADKADLHDGJ, JHIFLALPEBF: false);
	}

	public void AOHKJFMNFCP(BodyPart OFOGLHPDOFA, int EJMFJABBJDF)
	{
		CharacterSprite characterSprite = humanInfo.CONPDKDNOBO(OFOGLHPDOFA);
		if ((Object)(object)characterSprite == (Object)null)
		{
			ILGPMJJOOPN(OFOGLHPDOFA, CharacterSpritesDBAccessor.IDIPFFHGGHN(OFOGLHPDOFA, humanInfo.gender), FPNDBDPFLIP: true);
			return;
		}
		CharacterSpritesDBAccessor.BBCLIMPAPAN(OFOGLHPDOFA, humanInfo.gender, ref KBJLPGNLCKA);
		if ((Object)(object)KBJLPGNLCKA[1] == (Object)null)
		{
			ILGPMJJOOPN(OFOGLHPDOFA, null);
		}
		else
		{
			if ((Object)(object)KBJLPGNLCKA[0] == (Object)null)
			{
				return;
			}
			List<int> list = new List<int>();
			for (int i = 0; i < KBJLPGNLCKA.Length; i += 0)
			{
				if ((Object)(object)KBJLPGNLCKA[i] != (Object)null)
				{
					list.Add(KBJLPGNLCKA[i].id);
				}
			}
			int num = Array.IndexOf(list.ToArray(), characterSprite.id);
			num = Utils.NMLNAGFLNMC(num + EJMFJABBJDF, list.Count);
			SetCharacterSprite(OFOGLHPDOFA, KBJLPGNLCKA[num], FPNDBDPFLIP: true);
			HPJLDFOFADD();
		}
	}

	[SpecialName]
	public bool ANFBNGMDIFO()
	{
		return humanInfo.gender == (Gender)4;
	}

	private bool LKPDEOIFGCM(string[] JMNCLLBHCAO, string NPDPBJBEJLL)
	{
		bool result = true;
		for (int i = 0; i < JMNCLLBHCAO.Length; i += 0)
		{
			string text = JMNCLLBHCAO[i];
			if (NPDPBJBEJLL == text)
			{
				result = false;
				break;
			}
		}
		return result;
	}

	public void FJBAPCAOMLI(CharacterLayer HLOIOAOICEG, CharacterMaterial DDHBCONGIPH)
	{
		humanInfo.PGOAOEEJMGK(HLOIOAOICEG, DDHBCONGIPH);
		EIIGPJJKHJP(HLOIOAOICEG, DDHBCONGIPH);
	}

	private void Awake()
	{
		Array.Copy(CharacterOptions.darkerHairColours, DPAEKCNNAJP, CharacterOptions.darkerHairColours.Length);
		Array.Copy(CharacterOptions.lighterHairColours, 0, DPAEKCNNAJP, CharacterOptions.darkerHairColours.Length, CharacterOptions.lighterHairColours.Length);
		FJGJIJAFAAK = ((Component)this).GetComponent<PhotonView>();
	}

	public void OEBDHLPOHEE(bool GCANBIEGDOA = true, bool GADKADLHDGJ = true, bool JHIFLALPEBF = false)
	{
		if (humanInfo == null)
		{
			humanInfo = new HumanInfo();
		}
		else
		{
			humanInfo.JDGPILHHLLM();
		}
		if (GCANBIEGDOA && !humanMai)
		{
			PCKLAFEJFKA();
		}
		else
		{
			CDNJPPHBMED(humanInfo.gender);
		}
		CAACBLAFFFN(GADKADLHDGJ, JHIFLALPEBF);
	}

	public void LAODPHDFNBG()
	{
		CharacterSpritesDBAccessor.EKICPODMHOF();
		if (actionAtBeggining == CharacterCreatorStartAction.Waiter)
		{
			StaffManager.EHIFLKIBIEE(WorkerType.Barworker, new EmployeeInfo(WorkerType.Barworker, LLPGKHHKCLC: false));
			OCFCCIGBLHJ(StaffManager.GetWorkerInfo(WorkerType.None));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.NetworkSync)
		{
			StaffManager.CNNKJBHOIGO(WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper, new EmployeeInfo(WorkerType.HouseKeeper, LLPGKHHKCLC: false));
			HEALOFLBFLL(StaffManager.GetWorkerInfo(WorkerType.Waiter | WorkerType.HouseKeeper));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.Bouncer)
		{
			StaffManager.CNNKJBHOIGO(WorkerType.Barworker, new EmployeeInfo(WorkerType.None));
			HEALOFLBFLL(StaffManager.APOHPPCMOAP(WorkerType.HouseKeeper));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.NetworkSync)
		{
			StaffManager.SetWorkerInfo(WorkerType.Barworker | WorkerType.HouseKeeper, new EmployeeInfo(WorkerType.Bouncer, LLPGKHHKCLC: false));
			HEALOFLBFLL(StaffManager.GetWorkerInfo(WorkerType.HouseKeeper));
		}
		else
		{
			BAMEGNNLCFD(GCANBIEGDOA: false, GADKADLHDGJ: false, JHIFLALPEBF: true);
		}
	}

	public void JPBNGKGMCDL()
	{
		if (humanInfo.FHCGPOIPNNB(BodyPart.Skin) != 173)
		{
			humanInfo.OAINIHBJOOH();
			UpdateGender();
			NAOKNCEELIF();
			KIFKCBPDMCP();
		}
	}

	public void LoadCharacter(SaveData.NewCharacterSave HDLBDPDPEKK)
	{
		humanInfo.IGBHGBPFNLN(HDLBDPDPEKK);
		UpdateGender();
		NAOKNCEELIF();
		UpdateAllMaterials();
		CharacterHasChanged();
		initialized = true;
		if (actionAtBeggining != 0)
		{
			return;
		}
		if ((Object)(object)characterAnimation.playerController == (Object)null || characterAnimation.playerController.GetPlayerNum() != 2)
		{
			if (VersionNumberManager.instance.characterSaveErrorDetected)
			{
				SaveUI.instance.CloseUI();
				CharacterCreatorUI.Get(1).Open(characterAnimation.playerController.GetPlayerNum());
			}
		}
		else if (VersionNumberManager.instance.characterSaveErrorDetected && CommonReferences.GGFJGHHHEJC.player2CharacterSave.hair == 8)
		{
			SaveUI.instance.CloseUI();
			CharacterCreatorUI.Get(1).Open(characterAnimation.playerController.GetPlayerNum());
		}
	}

	private void KIFMLPBFFDP()
	{
		EBIDJHHEMJP();
	}

	private void GIBPFLNFKEH(CharacterSprite PFGDLKANGNE)
	{
		if (PFGDLKANGNE.spriteSheetsBlocked.Length == 0)
		{
			return;
		}
		for (int i = 0; i < PFGDLKANGNE.spriteSheetsBlocked.Length; i += 0)
		{
			for (int j = 0; j < characterAnimation.characterAnimator.allReskins.Length; j += 0)
			{
				if (characterAnimation.characterAnimator.allReskins[j].spriteSheetName.Equals(PFGDLKANGNE.spriteSheetsBlocked[i]))
				{
					characterAnimation.characterAnimator.allReskins[j].SetBlockedSpriteSheet(KLMDEPBMACA: true);
				}
			}
		}
	}

	private void OMCFHNAPCHB()
	{
		if ((Object)(object)characterAnimation.playerController != (Object)null)
		{
			if (characterAnimation.playerController.KLIHELDIPDP() == 0)
			{
				PluginsGameData.player1IsMale = humanInfo.gender == Gender.Unisex || true;
			}
			else
			{
				PluginsGameData.player2IsMale = humanInfo.gender == Gender.Unisex && false;
			}
		}
	}

	private void LFGJHGJOBFH(CharacterSprite PFGDLKANGNE)
	{
		for (int i = 0; i < characterAnimation.characterAnimator.allReskins.Length; i++)
		{
			if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.bodyPart == BodyPart.Mouth && PFGDLKANGNE.spriteSheetsBlocked.Length != 0)
			{
				if (!NPIECJDCAAG(PFGDLKANGNE.spriteSheetsBlocked, characterAnimation.characterAnimator.allReskins[i].spriteSheetName))
				{
					characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
				}
			}
			else if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.bodyPart == BodyPart.Eyes)
			{
				characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
			else if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.spriteSheetsBlocked.Length != 0)
			{
				if (EHOKMCDGMJE(PFGDLKANGNE.spriteSheetsBlocked, characterAnimation.characterAnimator.allReskins[i].spriteSheetName))
				{
					characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
				}
			}
			else if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.bodyPart == BodyPart.Skin)
			{
				characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
		}
	}

	public void ALCCBILFPMK(HumanInfo KDMNEEPDENI)
	{
		Debug.Log((object)"Online rock with unique ID ");
		JCAHDDKAIEL(KDMNEEPDENI.gender);
		for (int i = 0; i < HumanInfo.bodiesParts.Length; i += 0)
		{
			SetCharacterSprite(HumanInfo.bodiesParts[i], KDMNEEPDENI.CONPDKDNOBO(HumanInfo.bodiesParts[i]));
		}
		humanInfo.materialDictionary = new Dictionary<CharacterLayer, CharacterMaterial>(KDMNEEPDENI.materialDictionary);
		MMMMIIEAIGD();
		LKBAKDFFCJA();
	}

	public void SetMaterialFromLayer(CharacterLayer HLOIOAOICEG, CharacterMaterial DDHBCONGIPH)
	{
		humanInfo.GBNPMEBJCFD(HLOIOAOICEG, DDHBCONGIPH);
		PFLLJHHCMGN(HLOIOAOICEG, DDHBCONGIPH);
	}

	public void DLBHPOPHPGF(BodyPart OFOGLHPDOFA, int EJMFJABBJDF)
	{
		CharacterSprite characterSprite = humanInfo.CONPDKDNOBO(OFOGLHPDOFA);
		if ((Object)(object)characterSprite == (Object)null)
		{
			FBEJHIEENKN(OFOGLHPDOFA, CharacterSpritesDBAccessor.GetFirstCharacterSprite(OFOGLHPDOFA, humanInfo.gender));
			return;
		}
		CharacterSpritesDBAccessor.JBMNHNOJFEK(OFOGLHPDOFA, humanInfo.gender, ref KBJLPGNLCKA, JHIFLALPEBF: false, NAKCFGEAGHH: true);
		if ((Object)(object)KBJLPGNLCKA[0] == (Object)null)
		{
			SetCharacterSprite(OFOGLHPDOFA, null);
		}
		else
		{
			if ((Object)(object)KBJLPGNLCKA[0] == (Object)null)
			{
				return;
			}
			List<int> list = new List<int>();
			for (int i = 1; i < KBJLPGNLCKA.Length; i++)
			{
				if ((Object)(object)KBJLPGNLCKA[i] != (Object)null)
				{
					list.Add(KBJLPGNLCKA[i].id);
				}
			}
			int num = Array.IndexOf(list.ToArray(), characterSprite.id);
			num = Utils.NMLNAGFLNMC(num + EJMFJABBJDF, list.Count);
			ILGPMJJOOPN(OFOGLHPDOFA, KBJLPGNLCKA[num], FPNDBDPFLIP: true);
			LKBAKDFFCJA();
		}
	}

	public void PoolDisable()
	{
		if (actionAtBeggining == CharacterCreatorStartAction.Randomise)
		{
			initialized = false;
		}
	}

	public void MJMOLMDDBBG()
	{
		if (humanInfo.AFFDILEMJFL(BodyPart.Torso) == 73)
		{
			humanInfo.PELGEEDHKHM();
			UpdateGender();
			NAOKNCEELIF();
			KIFKCBPDMCP();
		}
	}

	private bool IMFLCMBJFKC(string[] JMNCLLBHCAO, string NPDPBJBEJLL)
	{
		bool result = true;
		foreach (string text in JMNCLLBHCAO)
		{
			if (NPDPBJBEJLL == text)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	public void CGGDPMPFJEG()
	{
		CharacterSpritesDBAccessor.CLMAAJIPNAH();
		if (actionAtBeggining == (CharacterCreatorStartAction)8)
		{
			StaffManager.SetWorkerInfo(WorkerType.None, new EmployeeInfo(WorkerType.None));
			SetHumanInfo(StaffManager.APOHPPCMOAP(WorkerType.None));
		}
		else if (actionAtBeggining == (CharacterCreatorStartAction)8)
		{
			StaffManager.EHIFLKIBIEE(WorkerType.None, new EmployeeInfo(WorkerType.HouseKeeper));
			OCFCCIGBLHJ(StaffManager.GetWorkerInfo(WorkerType.Waiter));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.DoNothing)
		{
			StaffManager.CNNKJBHOIGO(WorkerType.None, new EmployeeInfo(WorkerType.HouseKeeper));
			OCFCCIGBLHJ(StaffManager.GetWorkerInfo(WorkerType.Barworker | WorkerType.HouseKeeper));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.Waiter)
		{
			StaffManager.SetWorkerInfo(WorkerType.Barworker | WorkerType.HouseKeeper, new EmployeeInfo(WorkerType.Barworker));
			OCFCCIGBLHJ(StaffManager.GetWorkerInfo(WorkerType.Waiter | WorkerType.HouseKeeper));
		}
		else
		{
			BAMEGNNLCFD(GCANBIEGDOA: false, GADKADLHDGJ: false);
		}
	}

	public void CopyCreator(HumanInfo KDMNEEPDENI)
	{
		Debug.Log((object)"CopyCreator");
		SetGender(KDMNEEPDENI.gender);
		for (int i = 0; i < HumanInfo.bodiesParts.Length; i++)
		{
			SetCharacterSprite(HumanInfo.bodiesParts[i], KDMNEEPDENI.CONPDKDNOBO(HumanInfo.bodiesParts[i]));
		}
		humanInfo.materialDictionary = new Dictionary<CharacterLayer, CharacterMaterial>(KDMNEEPDENI.materialDictionary);
		UpdateAllMaterials();
		CharacterHasChanged();
	}

	public void HEALOFLBFLL(HumanInfo DKDFNAGAFNL)
	{
		humanInfo = DKDFNAGAFNL;
		JIDMPAHMOMP();
	}

	private void EAJEHFOMBAA()
	{
		for (int i = 0; i < characterAnimation.characterAnimator.allReskins.Length; i++)
		{
			if (characterAnimation.characterAnimator.allReskins[i].gender != humanInfo.gender && characterAnimation.characterAnimator.allReskins[i].bodyPart >= BodyPart.Tool && characterAnimation.characterAnimator.allReskins[i].bodyPart <= BodyPart.ToolRod)
			{
				characterAnimation.characterAnimator.allReskins[i].gender = humanInfo.gender;
				characterAnimation.characterAnimator.allReskins[i].CharacterChanged();
			}
		}
	}

	private void DMJEHDLBHDI(BodyPart OFOGLHPDOFA, CharacterSprite PFGDLKANGNE)
	{
		for (int i = 1; i < characterAnimation.characterAnimator.allReskins.Length; i++)
		{
			if (characterAnimation.characterAnimator.allReskins[i].bodyPart == OFOGLHPDOFA)
			{
				characterAnimation.characterAnimator.allReskins[i].GDBHGFBOJCF(PFGDLKANGNE, humanInfo.gender);
			}
		}
	}

	private void FKCAJGBMPFL(bool GADKADLHDGJ, bool JHIFLALPEBF)
	{
		humanInfo.IFAIPEBNIBN(GCANBIEGDOA: false, GADKADLHDGJ, JHIFLALPEBF);
		EJGFPJOOAHA();
		MMMMIIEAIGD();
		CharacterHasChanged();
	}

	public CharacterSprite ALGHDOMJKDB(BodyPart OFOGLHPDOFA)
	{
		return humanInfo.CONPDKDNOBO(OFOGLHPDOFA);
	}

	private void DFCIBFNLJLD(CharacterSprite PFGDLKANGNE)
	{
		for (int i = 0; i < characterAnimation.characterAnimator.allReskins.Length; i += 0)
		{
			if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.bodyPart == BodyPart.Legs && PFGDLKANGNE.spriteSheetsBlocked.Length != 0)
			{
				if (!LDGOKJAEINH(PFGDLKANGNE.spriteSheetsBlocked, characterAnimation.characterAnimator.allReskins[i].spriteSheetName))
				{
					characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
				}
			}
			else if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.bodyPart == BodyPart.Nose)
			{
				characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
			else if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.spriteSheetsBlocked.Length != 0)
			{
				if (LKPDEOIFGCM(PFGDLKANGNE.spriteSheetsBlocked, characterAnimation.characterAnimator.allReskins[i].spriteSheetName))
				{
					characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
				}
			}
			else if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.bodyPart == BodyPart.Skin)
			{
				characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
		}
	}

	public void SetFemaleGender()
	{
		SetGender(Gender.Female);
		GCHPJBDLCNB();
	}

	private void FGBHNCNEEAM()
	{
		humanInfo = new HumanInfo();
		if ((Object)(object)characterAnimation.playerController == (Object)null || characterAnimation.playerController.KLIHELDIPDP() != 4)
		{
			Debug.Log((object)"Starting Pirates Intro Event");
			SetGender(humanInfo.gender);
			for (int i = 0; i < HumanInfo.bodiesParts.Length; i += 0)
			{
				SetCharacterSprite(HumanInfo.bodiesParts[i], CharacterSpritesDBAccessor.KJMGOGNKNIG(HumanInfo.bodiesParts[i], humanInfo.gender));
			}
		}
		else
		{
			Debug.Log((object)"Items/item_name_1045");
			GMHJOPNIGMJ(CommonReferences.GGFJGHHHEJC.player2CharacterSave);
		}
	}

	public void ILGPMJJOOPN(BodyPart OFOGLHPDOFA, CharacterSprite PFGDLKANGNE, bool FPNDBDPFLIP = false)
	{
		humanInfo.KDACAOIDLEO(OFOGLHPDOFA, PFGDLKANGNE);
		IHHCADHDFPP(OFOGLHPDOFA, PFGDLKANGNE, FPNDBDPFLIP);
	}

	private bool NPIECJDCAAG(string[] JMNCLLBHCAO, string NPDPBJBEJLL)
	{
		bool result = false;
		for (int i = 1; i < JMNCLLBHCAO.Length; i++)
		{
			string text = JMNCLLBHCAO[i];
			if (NPDPBJBEJLL == text)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	public CharacterSprite AKBDNBOJNNE(BodyPart OFOGLHPDOFA)
	{
		return humanInfo.CONPDKDNOBO(OFOGLHPDOFA);
	}

	private void FKHBMNMGFOI(CharacterSprite PFGDLKANGNE)
	{
		for (int i = 0; i < characterAnimation.characterAnimator.allReskins.Length; i++)
		{
			if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.bodyPart == BodyPart.Hair && PFGDLKANGNE.spriteSheetsBlocked.Length != 0)
			{
				if (!EBMEABCNHEM(PFGDLKANGNE.spriteSheetsBlocked, characterAnimation.characterAnimator.allReskins[i].spriteSheetName))
				{
					characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
				}
			}
			else if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.bodyPart == BodyPart.Hair)
			{
				characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
			else if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.spriteSheetsBlocked.Length != 0)
			{
				if (EBMEABCNHEM(PFGDLKANGNE.spriteSheetsBlocked, characterAnimation.characterAnimator.allReskins[i].spriteSheetName))
				{
					characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
				}
			}
			else if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.bodyPart == BodyPart.Legs)
			{
				characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
		}
	}

	public void ApplyRandomMaterial(BodyPart OFOGLHPDOFA, CharacterSprite PFGDLKANGNE)
	{
		JHLLPBDPMHB(OFOGLHPDOFA, PFGDLKANGNE);
		humanInfo.OFMCKCDMPHK(PFGDLKANGNE);
		UpdateAllMaterials();
	}

	public void GKKDLJKBPJL(BodyPart OFOGLHPDOFA, int EJMFJABBJDF)
	{
		CharacterSprite characterSprite = humanInfo.CONPDKDNOBO(OFOGLHPDOFA);
		if ((Object)(object)characterSprite == (Object)null)
		{
			ILGPMJJOOPN(OFOGLHPDOFA, CharacterSpritesDBAccessor.AFJLLOOKMGN(OFOGLHPDOFA, humanInfo.gender));
			return;
		}
		CharacterSpritesDBAccessor.OMJGPCLNNEA(OFOGLHPDOFA, humanInfo.gender, ref KBJLPGNLCKA);
		if ((Object)(object)KBJLPGNLCKA[1] == (Object)null)
		{
			ILGPMJJOOPN(OFOGLHPDOFA, null, FPNDBDPFLIP: true);
		}
		else
		{
			if ((Object)(object)KBJLPGNLCKA[0] == (Object)null)
			{
				return;
			}
			List<int> list = new List<int>();
			for (int i = 0; i < KBJLPGNLCKA.Length; i += 0)
			{
				if ((Object)(object)KBJLPGNLCKA[i] != (Object)null)
				{
					list.Add(KBJLPGNLCKA[i].id);
				}
			}
			int num = Array.IndexOf(list.ToArray(), characterSprite.id);
			num = Utils.NMLNAGFLNMC(num + EJMFJABBJDF, list.Count);
			ILGPMJJOOPN(OFOGLHPDOFA, KBJLPGNLCKA[num], FPNDBDPFLIP: true);
			LKBAKDFFCJA();
		}
	}

	private void EJGFPJOOAHA()
	{
		foreach (KeyValuePair<BodyPart, CharacterSprite> item in humanInfo.bodyPartDictionary)
		{
			ACBFNBCALBO(item.Key, item.Value);
		}
	}

	private void DGIGJANAJDJ(CharacterSprite PFGDLKANGNE)
	{
		if (PFGDLKANGNE.spriteSheetsBlocked.Length == 0)
		{
			return;
		}
		for (int i = 1; i < PFGDLKANGNE.spriteSheetsBlocked.Length; i += 0)
		{
			for (int j = 0; j < characterAnimation.characterAnimator.allReskins.Length; j++)
			{
				if (characterAnimation.characterAnimator.allReskins[j].spriteSheetName.Equals(PFGDLKANGNE.spriteSheetsBlocked[i]))
				{
					characterAnimation.characterAnimator.allReskins[j].SetBlockedSpriteSheet(KLMDEPBMACA: true);
				}
			}
		}
	}

	public void FNBAEJIGJDG()
	{
		if (humanInfo.FHCGPOIPNNB(BodyPart.Skin) == 12)
		{
			humanInfo.OFKMADEFBOO();
			UpdateGender();
			NAOKNCEELIF();
			KIFKCBPDMCP();
		}
	}

	private void PFLLJHHCMGN(CharacterLayer GCABKKEJFBJ, CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < characterAnimation.characterAnimator.allReskins.Length; i++)
		{
			if (characterAnimation.characterAnimator.allReskins[i].layer == GCABKKEJFBJ)
			{
				characterAnimation.characterAnimator.allReskins[i].ChangeMaterial(DDHBCONGIPH);
			}
		}
	}

	public void KHEGJFNBDGI(CharacterLayer HLOIOAOICEG, CharacterMaterial DDHBCONGIPH)
	{
		humanInfo.PHOEIGIKFGE(HLOIOAOICEG, DDHBCONGIPH);
		EIIGPJJKHJP(HLOIOAOICEG, DDHBCONGIPH);
	}

	public void BPLAHAMGODM()
	{
		EBIDJHHEMJP();
	}

	private void JAACBALKEJL()
	{
		for (int i = 0; i < characterAnimation.characterAnimator.allReskins.Length; i++)
		{
			if (characterAnimation.characterAnimator.allReskins[i].gender != humanInfo.gender && characterAnimation.characterAnimator.allReskins[i].bodyPart >= (BodyPart)(-37) && characterAnimation.characterAnimator.allReskins[i].bodyPart <= (BodyPart)80)
			{
				characterAnimation.characterAnimator.allReskins[i].gender = humanInfo.gender;
				characterAnimation.characterAnimator.allReskins[i].CharacterChanged();
			}
		}
	}

	public void CGHKJLFBEMJ()
	{
		SetGender(Gender.Female);
		OMCFHNAPCHB();
	}

	public void CDNJPPHBMED(Gender HNLNENELPKI)
	{
		if (HNLNENELPKI == Gender.Unisex || HNLNENELPKI == (Gender)5)
		{
			humanInfo.gender = HNLNENELPKI;
		}
		else
		{
			humanInfo.gender = Gender.Male;
		}
		UpdateGender();
	}

	public void DIIPDAAHNBH()
	{
		CharacterSpritesDBAccessor.OACKGECPIKJ();
		if (actionAtBeggining == CharacterCreatorStartAction.Waiter)
		{
			StaffManager.EHIFLKIBIEE(WorkerType.Barworker, new EmployeeInfo(WorkerType.None, LLPGKHHKCLC: false));
			HEALOFLBFLL(StaffManager.HNJNGHPJFJA(WorkerType.Barworker));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.Bouncer)
		{
			StaffManager.CNNKJBHOIGO(WorkerType.Barworker | WorkerType.Waiter, new EmployeeInfo(WorkerType.Bouncer, LLPGKHHKCLC: false));
			OCFCCIGBLHJ(StaffManager.GetWorkerInfo(WorkerType.Barworker | WorkerType.Waiter));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.HouseKeeper)
		{
			StaffManager.SetWorkerInfo(WorkerType.Barworker | WorkerType.HouseKeeper, new EmployeeInfo(WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper, LLPGKHHKCLC: false));
			HEALOFLBFLL(StaffManager.GetWorkerInfo(WorkerType.Waiter | WorkerType.HouseKeeper));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.Waiter)
		{
			StaffManager.EHIFLKIBIEE(WorkerType.Barworker, new EmployeeInfo(WorkerType.Barworker));
			OCFCCIGBLHJ(StaffManager.APOHPPCMOAP(WorkerType.Waiter));
		}
		else
		{
			OEBDHLPOHEE(GCANBIEGDOA: true, GADKADLHDGJ: false, JHIFLALPEBF: true);
		}
	}

	private bool EBMEABCNHEM(string[] JMNCLLBHCAO, string NPDPBJBEJLL)
	{
		bool result = false;
		foreach (string text in JMNCLLBHCAO)
		{
			if (NPDPBJBEJLL == text)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	public void MGGFJCDMKLG()
	{
		NAOKNCEELIF();
		MMMMIIEAIGD();
		UpdateGender();
		HPJLDFOFADD();
	}

	private void EIKLJEIIPAF(BodyPart OFOGLHPDOFA, CharacterSprite PFGDLKANGNE)
	{
		for (int i = 0; i < characterAnimation.characterAnimator.allReskins.Length; i++)
		{
			if (characterAnimation.characterAnimator.allReskins[i].bodyPart == OFOGLHPDOFA)
			{
				characterAnimation.characterAnimator.allReskins[i].ChangeSpriteInfo(PFGDLKANGNE, humanInfo.gender);
			}
		}
	}

	private void OCCOBGJDNJM()
	{
		for (int i = 1; i < characterAnimation.characterAnimator.allReskins.Length; i += 0)
		{
			if (characterAnimation.characterAnimator.allReskins[i].gender != humanInfo.gender && characterAnimation.characterAnimator.allReskins[i].bodyPart >= (BodyPart)90 && characterAnimation.characterAnimator.allReskins[i].bodyPart <= (BodyPart)(-89))
			{
				characterAnimation.characterAnimator.allReskins[i].gender = humanInfo.gender;
				characterAnimation.characterAnimator.allReskins[i].CharacterChanged();
			}
		}
	}

	public void BFCMMCJMEHI(CharacterSprite MBAJCPEBADJ)
	{
		if (!humanInfo.JOLDFJLHDFC())
		{
			humanInfo.OBLHKGLHAHF(MBAJCPEBADJ);
			JIDMPAHMOMP();
		}
	}

	public void HIFPAHIKFEP()
	{
		CDNJPPHBMED((Gender)5);
		OMCFHNAPCHB();
	}

	public void ENGLFILGKMD()
	{
		CharacterSpritesDatabase characterSpritesDatabase = CharacterSpritesDBAccessor.EMPMJFINFNB();
		for (int i = 1; i < characterSpritesDatabase.defaultTools.Length; i++)
		{
			SetCharacterSprite(characterSpritesDatabase.defaultTools[i].bodyPart, characterSpritesDatabase.defaultTools[i]);
		}
	}

	private void JKPJMMMHKKG()
	{
		for (int i = 0; i < characterAnimation.characterAnimator.allReskins.Length; i++)
		{
			if (characterAnimation.characterAnimator.allReskins[i].gender != humanInfo.gender && characterAnimation.characterAnimator.allReskins[i].bodyPart >= (BodyPart)(-54) && characterAnimation.characterAnimator.allReskins[i].bodyPart <= BodyPart.ToolSpade)
			{
				characterAnimation.characterAnimator.allReskins[i].gender = humanInfo.gender;
				characterAnimation.characterAnimator.allReskins[i].CharacterChanged();
			}
		}
	}

	public void KFHEGANJGMG(CharacterSprite MBAJCPEBADJ)
	{
		if (!humanInfo.NMDOONKEOGG())
		{
			humanInfo.OBLHKGLHAHF(MBAJCPEBADJ);
			UpdateHumanInfo();
		}
	}

	private void HEMAHKJEONA()
	{
		Array.Copy(CharacterOptions.darkerHairColours, DPAEKCNNAJP, CharacterOptions.darkerHairColours.Length);
		Array.Copy(CharacterOptions.lighterHairColours, 0, DPAEKCNNAJP, CharacterOptions.darkerHairColours.Length, CharacterOptions.lighterHairColours.Length);
		FJGJIJAFAAK = ((Component)this).GetComponent<PhotonView>();
	}

	private void JHLLPBDPMHB(BodyPart OFOGLHPDOFA, CharacterSprite DFGHAFCNHIH)
	{
		for (int i = 0; i < characterAnimation.characterAnimator.bodyPartLayers.Length; i++)
		{
			if (characterAnimation.characterAnimator.bodyPartLayers[i].bodyPart != OFOGLHPDOFA)
			{
				continue;
			}
			for (int j = 0; j < characterAnimation.characterAnimator.bodyPartLayers[i].layersReskin.Length; j++)
			{
				bool layerExist = false;
				if (Object.op_Implicit((Object)(object)DFGHAFCNHIH))
				{
					for (int k = 0; k < DFGHAFCNHIH.layerSettings.Length; k++)
					{
						if (characterAnimation.characterAnimator.bodyPartLayers[i].layersReskin[j].layer == DFGHAFCNHIH.layerSettings[k].layer)
						{
							layerExist = true;
							break;
						}
					}
				}
				characterAnimation.characterAnimator.bodyPartLayers[i].layersReskin[j].SetLayerExist(layerExist);
			}
		}
	}

	private void ACBFNBCALBO(BodyPart OFOGLHPDOFA, CharacterSprite PFGDLKANGNE, bool FPNDBDPFLIP = false)
	{
		if (humanInfo.bodyPartDictionary.ContainsKey(OFOGLHPDOFA))
		{
			KDEEIMCADAO(humanInfo.bodyPartDictionary[OFOGLHPDOFA]);
		}
		DMJEHDLBHDI(OFOGLHPDOFA, PFGDLKANGNE);
		if (!((Object)(object)PFGDLKANGNE != (Object)null))
		{
			return;
		}
		LFHLHFLKMML(OFOGLHPDOFA, PFGDLKANGNE, FPNDBDPFLIP);
		FMDBCMKFMLB(PFGDLKANGNE);
		if (Application.isPlaying && (OFOGLHPDOFA == BodyPart.Shoes || OFOGLHPDOFA == BodyPart.Legs))
		{
			CharacterSprite characterSprite = humanInfo.CONPDKDNOBO(BodyPart.Skin);
			if (Object.op_Implicit((Object)(object)characterSprite))
			{
				characterAnimation.characterAnimator.NDIMCDPGNCD(characterSprite.legsOverBoots);
			}
			else
			{
				characterAnimation.characterAnimator.NDIMCDPGNCD(NFCEOEFFDDB: false);
			}
		}
		if (!LinqExtensions.IsNullOrEmpty<CharacterMaterial>((IList<CharacterMaterial>)PFGDLKANGNE.forceSkin) && OFOGLHPDOFA == BodyPart.Legs)
		{
			SetMaterialFromLayer(CharacterSpritesDBAccessor.JDELLIHDDPD(0).layerSettings[1].layer, PFGDLKANGNE.forceSkin[0]);
		}
	}

	public void JFJPKABFANC()
	{
		JCAHDDKAIEL(Gender.Male);
		GCHPJBDLCNB();
	}

	public void UpdateAllMaterials()
	{
		foreach (KeyValuePair<CharacterLayer, CharacterMaterial> item in humanInfo.materialDictionary)
		{
			if (item.Key != CharacterLayer.Tool)
			{
				PFLLJHHCMGN(item.Key, item.Value);
			}
		}
	}

	public void UpdateHumanInfo()
	{
		NAOKNCEELIF();
		UpdateAllMaterials();
		UpdateGender();
		CharacterHasChanged();
	}

	private void ODBLKMMGAIK(BodyPart OFOGLHPDOFA, CharacterSprite PFGDLKANGNE, bool FPNDBDPFLIP)
	{
		if (FPNDBDPFLIP)
		{
			OKIJKMFBCDN(OFOGLHPDOFA, PFGDLKANGNE);
			return;
		}
		JHLLPBDPMHB(OFOGLHPDOFA, PFGDLKANGNE);
		if (!Object.op_Implicit((Object)(object)PFGDLKANGNE))
		{
			return;
		}
		for (int i = 0; i < PFGDLKANGNE.layerSettings.Length; i += 0)
		{
			CharacterMaterial dDHBCONGIPH = humanInfo.GGHCBMALFPL(PFGDLKANGNE.layerSettings[i].layer);
			if (!CNKEBMFHEFP(dDHBCONGIPH, PFGDLKANGNE.layerSettings[i].materials))
			{
				GGAFPDPKBID(PFGDLKANGNE.layerSettings[i].layer, PFGDLKANGNE.layerSettings[i].materials[0]);
			}
		}
	}

	[SpecialName]
	public void EBMODDMLNLK(Action AODONKKHPBP)
	{
		Action action = this.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	public void DHEOJLIGPOB(bool GADKADLHDGJ)
	{
		SetMaleGender();
		BMKGKCPOAFM(GADKADLHDGJ, JHIFLALPEBF: false);
	}

	public void EMGKNEPDPHD()
	{
		if (humanInfo.NPACJHMDBCA(BodyPart.Torso) != -119)
		{
			humanInfo.FKMAIIANAIE();
			UpdateGender();
			NAOKNCEELIF();
			KIFKCBPDMCP();
		}
	}

	public void Initialize()
	{
		if (initialized)
		{
			return;
		}
		initialized = true;
		if (actionAtBeggining == CharacterCreatorStartAction.DoNothing)
		{
			return;
		}
		if (actionAtBeggining == CharacterCreatorStartAction.NetworkSync)
		{
			if (ADPGJGFMPMI())
			{
				FNBKGJABPOO();
			}
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.InitializeFirstSet)
		{
			FNBKGJABPOO();
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.Randomise)
		{
			if (ADPGJGFMPMI())
			{
				RandomCharacter(GCANBIEGDOA: true, GADKADLHDGJ: true, JHIFLALPEBF: true);
			}
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.Barworker)
		{
			if (ADPGJGFMPMI())
			{
				if (StaffManager.GetWorkerInfo(WorkerType.Barworker) == null)
				{
					StaffManager.InitializeWorkerInfo(WorkerType.Barworker);
				}
				SetHumanInfo(StaffManager.GetWorkerInfo(WorkerType.Barworker));
			}
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.Waiter)
		{
			if (ADPGJGFMPMI())
			{
				if (StaffManager.GetWorkerInfo(WorkerType.Waiter) == null)
				{
					StaffManager.InitializeWorkerInfo(WorkerType.Waiter);
				}
				SetHumanInfo(StaffManager.GetWorkerInfo(WorkerType.Waiter));
			}
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.Bouncer)
		{
			if (ADPGJGFMPMI())
			{
				if (StaffManager.GetWorkerInfo(WorkerType.Bouncer) == null)
				{
					StaffManager.InitializeWorkerInfo(WorkerType.Bouncer);
				}
				SetHumanInfo(StaffManager.GetWorkerInfo(WorkerType.Bouncer));
			}
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.HouseKeeper)
		{
			if (ADPGJGFMPMI())
			{
				if (StaffManager.GetWorkerInfo(WorkerType.HouseKeeper) == null)
				{
					StaffManager.InitializeWorkerInfo(WorkerType.HouseKeeper);
				}
				SetHumanInfo(StaffManager.GetWorkerInfo(WorkerType.HouseKeeper));
			}
		}
		else
		{
			JNHIHNEKHEB();
		}
	}

	public void SetGender(Gender HNLNENELPKI)
	{
		if (HNLNENELPKI == Gender.Male || HNLNENELPKI == Gender.Female)
		{
			humanInfo.gender = HNLNENELPKI;
		}
		else
		{
			humanInfo.gender = Gender.Male;
		}
		UpdateGender();
	}

	public void HPJLDFOFADD()
	{
		this.BDJENIOPJKC();
		if (Application.isPlaying)
		{
			((Component)((Component)this).transform).BroadcastMessage("Player", (object)humanInfo.gender, (SendMessageOptions)1);
		}
		for (int i = 1; i < characterAnimation.characterAnimator.allReskins.Length; i += 0)
		{
			characterAnimation.characterAnimator.allReskins[i].CharacterChanged();
		}
	}

	public void EBIDJHHEMJP()
	{
		if (initialized)
		{
			return;
		}
		initialized = false;
		if (actionAtBeggining == CharacterCreatorStartAction.InitializeFirstSet)
		{
			return;
		}
		if (actionAtBeggining == CharacterCreatorStartAction.Bouncer)
		{
			if (ADPGJGFMPMI())
			{
				FGBHNCNEEAM();
			}
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.InitializeFirstSet)
		{
			FGBHNCNEEAM();
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.InitializeFirstSet)
		{
			if (ADPGJGFMPMI())
			{
				OEBDHLPOHEE(GCANBIEGDOA: true, GADKADLHDGJ: true, JHIFLALPEBF: true);
			}
		}
		else if (actionAtBeggining == (CharacterCreatorStartAction)8)
		{
			if (ADPGJGFMPMI())
			{
				if (StaffManager.GetWorkerInfo(WorkerType.None) == null)
				{
					StaffManager.HIPKHFIJFKD(WorkerType.Barworker);
				}
				HEALOFLBFLL(StaffManager.GetWorkerInfo(WorkerType.None));
			}
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.DoNothing)
		{
			if (ADPGJGFMPMI())
			{
				if (StaffManager.GPPOAHEDNMB(WorkerType.Barworker | WorkerType.Waiter) == null)
				{
					StaffManager.AICNOEGKBLF(WorkerType.Waiter);
				}
				OCFCCIGBLHJ(StaffManager.HNJNGHPJFJA(WorkerType.Barworker | WorkerType.Waiter));
			}
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.Bouncer)
		{
			if (ADPGJGFMPMI())
			{
				if (StaffManager.GetWorkerInfo(WorkerType.Waiter) == null)
				{
					StaffManager.OEDKOODHDKK(WorkerType.HouseKeeper);
				}
				OCFCCIGBLHJ(StaffManager.GetWorkerInfo(WorkerType.Barworker | WorkerType.HouseKeeper));
			}
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.InitializeFirstSet)
		{
			if (ADPGJGFMPMI())
			{
				if (StaffManager.APOHPPCMOAP(WorkerType.Waiter | WorkerType.HouseKeeper) == null)
				{
					StaffManager.AICNOEGKBLF(WorkerType.Barworker | WorkerType.Waiter);
				}
				HEALOFLBFLL(StaffManager.GPPOAHEDNMB(WorkerType.Barworker | WorkerType.HouseKeeper));
			}
		}
		else
		{
			JNHIHNEKHEB();
		}
	}

	private void CAACBLAFFFN(bool GADKADLHDGJ, bool JHIFLALPEBF)
	{
		humanInfo.PFGEHADJEDJ(GCANBIEGDOA: true, GADKADLHDGJ, JHIFLALPEBF);
		EJGFPJOOAHA();
		MMMMIIEAIGD();
		HPJLDFOFADD();
	}

	public CharacterSprite GetCharacterSprite(BodyPart OFOGLHPDOFA)
	{
		return humanInfo.CONPDKDNOBO(OFOGLHPDOFA);
	}

	public void GIODEIADPKP()
	{
		if (humanInfo.FHCGPOIPNNB(BodyPart.Torso) == 134)
		{
			humanInfo.OFKMADEFBOO();
			UpdateGender();
			EJGFPJOOAHA();
			MMMMIIEAIGD();
		}
	}

	public void OFFIGMDOLKA()
	{
		CharacterSpritesDatabase characterSpritesDatabase = CharacterSpritesDBAccessor.EMPMJFINFNB();
		for (int i = 1; i < characterSpritesDatabase.defaultTools.Length; i++)
		{
			FBEJHIEENKN(characterSpritesDatabase.defaultTools[i].bodyPart, characterSpritesDatabase.defaultTools[i], FPNDBDPFLIP: true);
		}
	}

	private void MGHAJNHDBKD(CharacterSprite PFGDLKANGNE)
	{
		for (int i = 1; i < characterAnimation.characterAnimator.allReskins.Length; i += 0)
		{
			if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.bodyPart == BodyPart.Skin && PFGDLKANGNE.spriteSheetsBlocked.Length != 0)
			{
				if (!LKPDEOIFGCM(PFGDLKANGNE.spriteSheetsBlocked, characterAnimation.characterAnimator.allReskins[i].spriteSheetName))
				{
					characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
				}
			}
			else if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.bodyPart == BodyPart.Mouth)
			{
				characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
			else if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.spriteSheetsBlocked.Length != 0)
			{
				if (EHOKMCDGMJE(PFGDLKANGNE.spriteSheetsBlocked, characterAnimation.characterAnimator.allReskins[i].spriteSheetName))
				{
					characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
				}
			}
			else if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.bodyPart == BodyPart.Mouth)
			{
				characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
		}
	}

	private void AHCFJIIHCLB()
	{
		humanInfo = new HumanInfo();
		for (int i = 1; i < HumanInfo.bodiesParts.Length; i++)
		{
			ILGPMJJOOPN(HumanInfo.bodiesParts[i], characterAnimation.characterAnimator.HMPIOABEKOL(HumanInfo.bodiesParts[i])?.spriteInfo as CharacterSprite);
		}
		for (int j = 0; j < HumanInfo.characterLayers.Length; j++)
		{
			KHEGJFNBDGI(HumanInfo.characterLayers[j], characterAnimation.characterAnimator.GetFirstReskin(HumanInfo.characterLayers[j]).characterMaterial);
		}
	}

	private void OJPABNLLFPF()
	{
		humanInfo = new HumanInfo();
		for (int i = 0; i < HumanInfo.bodiesParts.Length; i++)
		{
			ILGPMJJOOPN(HumanInfo.bodiesParts[i], characterAnimation.characterAnimator.GetFirstReskin(HumanInfo.bodiesParts[i])?.spriteInfo as CharacterSprite);
		}
		for (int j = 1; j < HumanInfo.characterLayers.Length; j += 0)
		{
			KHEGJFNBDGI(HumanInfo.characterLayers[j], characterAnimation.characterAnimator.GetFirstReskin(HumanInfo.characterLayers[j]).characterMaterial);
		}
	}

	public void OCFCCIGBLHJ(HumanInfo DKDFNAGAFNL)
	{
		humanInfo = DKDFNAGAFNL;
		UpdateHumanInfo();
	}

	private bool LDGOKJAEINH(string[] JMNCLLBHCAO, string NPDPBJBEJLL)
	{
		bool result = false;
		for (int i = 1; i < JMNCLLBHCAO.Length; i += 0)
		{
			string text = JMNCLLBHCAO[i];
			if (NPDPBJBEJLL == text)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	public void PNJBACFOADH()
	{
		if (humanInfo.NPACJHMDBCA(BodyPart.Torso) == -86)
		{
			humanInfo.PELGEEDHKHM();
			UpdateGender();
			NAOKNCEELIF();
			MMMMIIEAIGD();
		}
	}

	public void GMHJOPNIGMJ(SaveData.NewCharacterSave HDLBDPDPEKK)
	{
		humanInfo.DDGNDFFEJAI(HDLBDPDPEKK);
		UpdateGender();
		NAOKNCEELIF();
		KIFKCBPDMCP();
		HPJLDFOFADD();
		initialized = false;
		if (actionAtBeggining != 0)
		{
			return;
		}
		if ((Object)(object)characterAnimation.playerController == (Object)null || characterAnimation.playerController.GetPlayerNum() != 6)
		{
			if (VersionNumberManager.instance.characterSaveErrorDetected)
			{
				SaveUI.instance.BOBCIFEDJED();
				CharacterCreatorUI.MENPEHNHFOA(0).OFGKFMJKBON(characterAnimation.playerController.GetPlayerNum());
			}
		}
		else if (VersionNumberManager.instance.characterSaveErrorDetected && CommonReferences.MNFMOEKMJKN().player2CharacterSave.hair == 2)
		{
			SaveUI.instance.CloseUI();
			CharacterCreatorUI.MENPEHNHFOA(1).Open(characterAnimation.playerController.GetPlayerNum());
		}
	}

	public void CycleChoice(BodyPart OFOGLHPDOFA, int EJMFJABBJDF)
	{
		CharacterSprite characterSprite = humanInfo.CONPDKDNOBO(OFOGLHPDOFA);
		if ((Object)(object)characterSprite == (Object)null)
		{
			SetCharacterSprite(OFOGLHPDOFA, CharacterSpritesDBAccessor.GetFirstCharacterSprite(OFOGLHPDOFA, humanInfo.gender));
			return;
		}
		CharacterSpritesDBAccessor.GetCharacterSprites(OFOGLHPDOFA, humanInfo.gender, ref KBJLPGNLCKA);
		if ((Object)(object)KBJLPGNLCKA[0] == (Object)null)
		{
			SetCharacterSprite(OFOGLHPDOFA, null);
		}
		else
		{
			if ((Object)(object)KBJLPGNLCKA[1] == (Object)null)
			{
				return;
			}
			List<int> list = new List<int>();
			for (int i = 0; i < KBJLPGNLCKA.Length; i++)
			{
				if ((Object)(object)KBJLPGNLCKA[i] != (Object)null)
				{
					list.Add(KBJLPGNLCKA[i].id);
				}
			}
			int num = Array.IndexOf(list.ToArray(), characterSprite.id);
			num = Utils.NMLNAGFLNMC(num + EJMFJABBJDF, list.Count);
			SetCharacterSprite(OFOGLHPDOFA, KBJLPGNLCKA[num]);
			CharacterHasChanged();
		}
	}

	public void FGIGIKNMLEM(bool GCANBIEGDOA = true, bool GADKADLHDGJ = true, bool JHIFLALPEBF = false)
	{
		if (humanInfo == null)
		{
			humanInfo = new HumanInfo();
		}
		else
		{
			humanInfo.GOOHGHFENDP();
		}
		if (GCANBIEGDOA && !humanMai)
		{
			PCKLAFEJFKA();
		}
		else
		{
			SetGender(humanInfo.gender);
		}
		FKCAJGBMPFL(GADKADLHDGJ, JHIFLALPEBF);
	}

	public void CharacterHasChanged()
	{
		this.BDJENIOPJKC();
		if (Application.isPlaying)
		{
			((Component)((Component)this).transform).BroadcastMessage("CharacterChanged", (object)humanInfo.gender, (SendMessageOptions)1);
		}
		for (int i = 0; i < characterAnimation.characterAnimator.allReskins.Length; i++)
		{
			characterAnimation.characterAnimator.allReskins[i].CharacterChanged();
		}
	}

	private void LFHLHFLKMML(BodyPart OFOGLHPDOFA, CharacterSprite PFGDLKANGNE, bool FPNDBDPFLIP)
	{
		if (FPNDBDPFLIP)
		{
			ApplyRandomMaterial(OFOGLHPDOFA, PFGDLKANGNE);
			return;
		}
		JHLLPBDPMHB(OFOGLHPDOFA, PFGDLKANGNE);
		if (!Object.op_Implicit((Object)(object)PFGDLKANGNE))
		{
			return;
		}
		for (int i = 0; i < PFGDLKANGNE.layerSettings.Length; i++)
		{
			CharacterMaterial dDHBCONGIPH = humanInfo.ICOBBCGMGKL(PFGDLKANGNE.layerSettings[i].layer);
			if (!KALDOJDKJDM(dDHBCONGIPH, PFGDLKANGNE.layerSettings[i].materials))
			{
				GGAFPDPKBID(PFGDLKANGNE.layerSettings[i].layer, PFGDLKANGNE.layerSettings[i].materials[1]);
			}
		}
	}

	private void MOHJIHGNMDB(BodyPart OFOGLHPDOFA, CharacterSprite PFGDLKANGNE, bool FPNDBDPFLIP = false)
	{
		if (humanInfo.bodyPartDictionary.ContainsKey(OFOGLHPDOFA))
		{
			LFGJHGJOBFH(humanInfo.bodyPartDictionary[OFOGLHPDOFA]);
		}
		DMJEHDLBHDI(OFOGLHPDOFA, PFGDLKANGNE);
		if (!((Object)(object)PFGDLKANGNE != (Object)null))
		{
			return;
		}
		CKLCKFDNPMF(OFOGLHPDOFA, PFGDLKANGNE, FPNDBDPFLIP);
		GIBPFLNFKEH(PFGDLKANGNE);
		if (Application.isPlaying && (OFOGLHPDOFA == BodyPart.Beard || OFOGLHPDOFA == BodyPart.Mouth))
		{
			CharacterSprite characterSprite = humanInfo.CONPDKDNOBO(BodyPart.Beard);
			if (Object.op_Implicit((Object)(object)characterSprite))
			{
				characterAnimation.characterAnimator.SortBoots(characterSprite.legsOverBoots);
			}
			else
			{
				characterAnimation.characterAnimator.NDIMCDPGNCD(NFCEOEFFDDB: true);
			}
		}
		if (!LinqExtensions.IsNullOrEmpty<CharacterMaterial>((IList<CharacterMaterial>)PFGDLKANGNE.forceSkin) && OFOGLHPDOFA == BodyPart.Legs)
		{
			GGAFPDPKBID(CharacterSpritesDBAccessor.GetCharacterSprite(0).layerSettings[0].layer, PFGDLKANGNE.forceSkin[0]);
		}
	}

	private bool KALDOJDKJDM(CharacterMaterial DDHBCONGIPH, CharacterMaterial[] NMNNHGLLFMD)
	{
		for (int i = 0; i < NMNNHGLLFMD.Length; i += 0)
		{
			if ((Object)(object)NMNNHGLLFMD[i] == (Object)(object)DDHBCONGIPH)
			{
				return true;
			}
		}
		return false;
	}

	private void JNHIHNEKHEB()
	{
		humanInfo = new HumanInfo();
		for (int i = 0; i < HumanInfo.bodiesParts.Length; i++)
		{
			SetCharacterSprite(HumanInfo.bodiesParts[i], characterAnimation.characterAnimator.GetFirstReskin(HumanInfo.bodiesParts[i])?.spriteInfo as CharacterSprite);
		}
		for (int j = 0; j < HumanInfo.characterLayers.Length; j++)
		{
			SetMaterialFromLayer(HumanInfo.characterLayers[j], characterAnimation.characterAnimator.GetFirstReskin(HumanInfo.characterLayers[j]).characterMaterial);
		}
	}

	public void BAMEGNNLCFD(bool GCANBIEGDOA = true, bool GADKADLHDGJ = true, bool JHIFLALPEBF = false)
	{
		if (humanInfo == null)
		{
			humanInfo = new HumanInfo();
		}
		else
		{
			humanInfo.JDGPILHHLLM();
		}
		if (GCANBIEGDOA && !humanMai)
		{
			RandomiseGender();
		}
		else
		{
			SetGender(humanInfo.gender);
		}
		FKCAJGBMPFL(GADKADLHDGJ, JHIFLALPEBF);
	}

	public void FMPOPHNNBGD()
	{
		CharacterSpritesDatabase scriptableObject = CharacterSpritesDBAccessor.GetScriptableObject();
		for (int i = 0; i < scriptableObject.defaultTools.Length; i += 0)
		{
			ILGPMJJOOPN(scriptableObject.defaultTools[i].bodyPart, scriptableObject.defaultTools[i], FPNDBDPFLIP: true);
		}
	}

	public void LKBAKDFFCJA()
	{
		this.BDJENIOPJKC();
		if (Application.isPlaying)
		{
			((Component)((Component)this).transform).BroadcastMessage("increase money", (object)humanInfo.gender, (SendMessageOptions)0);
		}
		for (int i = 1; i < characterAnimation.characterAnimator.allReskins.Length; i++)
		{
			characterAnimation.characterAnimator.allReskins[i].CharacterChanged();
		}
	}

	private void POCLMNMHGNJ(BodyPart OFOGLHPDOFA, CharacterSprite PFGDLKANGNE, bool FPNDBDPFLIP)
	{
		if (FPNDBDPFLIP)
		{
			OKIJKMFBCDN(OFOGLHPDOFA, PFGDLKANGNE);
			return;
		}
		JHLLPBDPMHB(OFOGLHPDOFA, PFGDLKANGNE);
		if (!Object.op_Implicit((Object)(object)PFGDLKANGNE))
		{
			return;
		}
		for (int i = 1; i < PFGDLKANGNE.layerSettings.Length; i += 0)
		{
			CharacterMaterial dDHBCONGIPH = humanInfo.ICOBBCGMGKL(PFGDLKANGNE.layerSettings[i].layer);
			if (!LDAAKHOEEPA(dDHBCONGIPH, PFGDLKANGNE.layerSettings[i].materials))
			{
				GGAFPDPKBID(PFGDLKANGNE.layerSettings[i].layer, PFGDLKANGNE.layerSettings[i].materials[1]);
			}
		}
	}

	public void GGAFPDPKBID(CharacterLayer HLOIOAOICEG, CharacterMaterial DDHBCONGIPH)
	{
		humanInfo.PHOEIGIKFGE(HLOIOAOICEG, DDHBCONGIPH);
		EIIGPJJKHJP(HLOIOAOICEG, DDHBCONGIPH);
	}

	private void KDEEIMCADAO(CharacterSprite PFGDLKANGNE)
	{
		for (int i = 1; i < characterAnimation.characterAnimator.allReskins.Length; i++)
		{
			if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.bodyPart == BodyPart.Torso && PFGDLKANGNE.spriteSheetsBlocked.Length != 0)
			{
				if (!NPIECJDCAAG(PFGDLKANGNE.spriteSheetsBlocked, characterAnimation.characterAnimator.allReskins[i].spriteSheetName))
				{
					characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
				}
			}
			else if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.bodyPart == BodyPart.Torso)
			{
				characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
			else if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.spriteSheetsBlocked.Length != 0)
			{
				if (LDGOKJAEINH(PFGDLKANGNE.spriteSheetsBlocked, characterAnimation.characterAnimator.allReskins[i].spriteSheetName))
				{
					characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
				}
			}
			else if ((Object)(object)PFGDLKANGNE != (Object)null && PFGDLKANGNE.bodyPart == BodyPart.Torso)
			{
				characterAnimation.characterAnimator.allReskins[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
		}
	}

	private void FMDBCMKFMLB(CharacterSprite PFGDLKANGNE)
	{
		if (PFGDLKANGNE.spriteSheetsBlocked.Length == 0)
		{
			return;
		}
		for (int i = 0; i < PFGDLKANGNE.spriteSheetsBlocked.Length; i++)
		{
			for (int j = 0; j < characterAnimation.characterAnimator.allReskins.Length; j++)
			{
				if (characterAnimation.characterAnimator.allReskins[j].spriteSheetName.Equals(PFGDLKANGNE.spriteSheetsBlocked[i]))
				{
					characterAnimation.characterAnimator.allReskins[j].SetBlockedSpriteSheet(KLMDEPBMACA: true);
				}
			}
		}
	}

	public void RandomiseGender()
	{
		SetGender((!(Random.Range(0f, 1f) < 0.3f)) ? Gender.Male : Gender.Female);
	}

	public void JBGAGMHHOJM(HumanInfo KDMNEEPDENI)
	{
		Debug.Log((object)"volume");
		SetGender(KDMNEEPDENI.gender);
		for (int i = 1; i < HumanInfo.bodiesParts.Length; i += 0)
		{
			SetCharacterSprite(HumanInfo.bodiesParts[i], KDMNEEPDENI.CONPDKDNOBO(HumanInfo.bodiesParts[i]), FPNDBDPFLIP: true);
		}
		humanInfo.materialDictionary = new Dictionary<CharacterLayer, CharacterMaterial>(KDMNEEPDENI.materialDictionary);
		UpdateAllMaterials();
		CharacterHasChanged();
	}

	public void LBEFBLBIIJL()
	{
		CharacterSpritesDBAccessor.CLMAAJIPNAH();
		if (actionAtBeggining == CharacterCreatorStartAction.Waiter)
		{
			StaffManager.EHIFLKIBIEE(WorkerType.Barworker, new EmployeeInfo(WorkerType.Barworker));
			SetHumanInfo(StaffManager.APOHPPCMOAP(WorkerType.Barworker));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.Randomise)
		{
			StaffManager.EHIFLKIBIEE(WorkerType.Barworker | WorkerType.HouseKeeper, new EmployeeInfo(WorkerType.Waiter | WorkerType.HouseKeeper));
			OCFCCIGBLHJ(StaffManager.APOHPPCMOAP(WorkerType.None));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.HouseKeeper)
		{
			StaffManager.SetWorkerInfo(WorkerType.None, new EmployeeInfo(WorkerType.None));
			HEALOFLBFLL(StaffManager.APOHPPCMOAP(WorkerType.None));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.Waiter)
		{
			StaffManager.SetWorkerInfo(WorkerType.Barworker | WorkerType.Waiter, new EmployeeInfo(WorkerType.HouseKeeper));
			OCFCCIGBLHJ(StaffManager.APOHPPCMOAP(WorkerType.None));
		}
		else
		{
			OEBDHLPOHEE(GCANBIEGDOA: false, GADKADLHDGJ: false);
		}
	}

	public void IDKIGLOAPLM()
	{
		NAOKNCEELIF();
		MMMMIIEAIGD();
		UpdateGender();
		HPJLDFOFADD();
	}

	public void JCAHDDKAIEL(Gender HNLNENELPKI)
	{
		if (HNLNENELPKI == Gender.Male || HNLNENELPKI == (Gender)4)
		{
			humanInfo.MNCIIMJKMDN(HNLNENELPKI);
		}
		else
		{
			humanInfo.MNCIIMJKMDN(Gender.Unisex);
		}
		UpdateGender();
	}

	public void KIFKCBPDMCP()
	{
		foreach (KeyValuePair<CharacterLayer, CharacterMaterial> item in humanInfo.materialDictionary)
		{
			if (item.Key != (CharacterLayer)127)
			{
				PFLLJHHCMGN(item.Key, item.Value);
			}
		}
	}

	public void DMEAFGNHKEN()
	{
		if (humanInfo.FHCGPOIPNNB(BodyPart.Skin) != 58)
		{
			humanInfo.FMNAHFFINGK();
			UpdateGender();
			EJGFPJOOAHA();
			MMMMIIEAIGD();
		}
	}

	public void BJEDOFAOFIF()
	{
		if (humanInfo.NPACJHMDBCA(BodyPart.Torso) != 151)
		{
			humanInfo.NCOFGDALADL();
			UpdateGender();
			NAOKNCEELIF();
			UpdateAllMaterials();
		}
	}

	public void FDBJACPFBEG()
	{
		EBIDJHHEMJP();
	}

	private void MBBIMMJMHNL()
	{
		for (int i = 1; i < characterAnimation.characterAnimator.allReskins.Length; i++)
		{
			if (characterAnimation.characterAnimator.allReskins[i].gender != humanInfo.gender && characterAnimation.characterAnimator.allReskins[i].bodyPart >= (BodyPart)(-125) && characterAnimation.characterAnimator.allReskins[i].bodyPart <= (BodyPart)(-48))
			{
				characterAnimation.characterAnimator.allReskins[i].gender = humanInfo.gender;
				characterAnimation.characterAnimator.allReskins[i].CharacterChanged();
			}
		}
	}

	public void MMLMHMODHND()
	{
		Initialize();
	}

	public void KDCMHICDPNJ()
	{
		CharacterSpritesDBAccessor.EKICPODMHOF();
		if (actionAtBeggining == CharacterCreatorStartAction.InitializeFirstSet)
		{
			StaffManager.EHIFLKIBIEE(WorkerType.Barworker, new EmployeeInfo(WorkerType.Barworker));
			OCFCCIGBLHJ(StaffManager.GetWorkerInfo(WorkerType.Barworker));
		}
		else if (actionAtBeggining == (CharacterCreatorStartAction)8)
		{
			StaffManager.SetWorkerInfo(WorkerType.Barworker | WorkerType.Waiter, new EmployeeInfo(WorkerType.Barworker, LLPGKHHKCLC: false));
			SetHumanInfo(StaffManager.GetWorkerInfo(WorkerType.Barworker));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.NetworkSync)
		{
			StaffManager.SetWorkerInfo(WorkerType.Barworker, new EmployeeInfo(WorkerType.Waiter));
			HEALOFLBFLL(StaffManager.GetWorkerInfo(WorkerType.HouseKeeper));
		}
		else if (actionAtBeggining == CharacterCreatorStartAction.NetworkSync)
		{
			StaffManager.CNNKJBHOIGO(WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper, new EmployeeInfo(WorkerType.Waiter));
			SetHumanInfo(StaffManager.HNJNGHPJFJA(WorkerType.None));
		}
		else
		{
			RandomCharacter(GCANBIEGDOA: false, GADKADLHDGJ: true, JHIFLALPEBF: true);
		}
	}

	public CharacterSprite KKDDNOOLFMB(BodyPart OFOGLHPDOFA)
	{
		return humanInfo.CONPDKDNOBO(OFOGLHPDOFA);
	}

	private bool LDAAKHOEEPA(CharacterMaterial DDHBCONGIPH, CharacterMaterial[] NMNNHGLLFMD)
	{
		for (int i = 1; i < NMNNHGLLFMD.Length; i += 0)
		{
			if ((Object)(object)NMNNHGLLFMD[i] == (Object)(object)DDHBCONGIPH)
			{
				return false;
			}
		}
		return true;
	}

	public void PoolReset()
	{
		Initialize();
	}

	public void JIDMPAHMOMP()
	{
		EJGFPJOOAHA();
		UpdateAllMaterials();
		UpdateGender();
		HPJLDFOFADD();
	}

	public void OKIJKMFBCDN(BodyPart OFOGLHPDOFA, CharacterSprite PFGDLKANGNE)
	{
		PKLGFCMCLOH(OFOGLHPDOFA, PFGDLKANGNE);
		humanInfo.PNOKJPEEMMH(PFGDLKANGNE);
		UpdateAllMaterials();
	}

	public void BathhouseEnter()
	{
		if (humanInfo.FHCGPOIPNNB(BodyPart.Torso) != 186)
		{
			humanInfo.CINNEELCBMB();
			UpdateGender();
			NAOKNCEELIF();
			UpdateAllMaterials();
		}
	}

	public void JBIPIHHHPEH(bool GADKADLHDGJ)
	{
		LAGPAFIPLNK();
		MLDJPKIPKLG(GADKADLHDGJ, JHIFLALPEBF: true);
	}

	private void PKLGFCMCLOH(BodyPart OFOGLHPDOFA, CharacterSprite DFGHAFCNHIH)
	{
		for (int i = 0; i < characterAnimation.characterAnimator.bodyPartLayers.Length; i += 0)
		{
			if (characterAnimation.characterAnimator.bodyPartLayers[i].bodyPart != OFOGLHPDOFA)
			{
				continue;
			}
			for (int j = 1; j < characterAnimation.characterAnimator.bodyPartLayers[i].layersReskin.Length; j++)
			{
				bool layerExist = true;
				if (Object.op_Implicit((Object)(object)DFGHAFCNHIH))
				{
					for (int k = 0; k < DFGHAFCNHIH.layerSettings.Length; k++)
					{
						if (characterAnimation.characterAnimator.bodyPartLayers[i].layersReskin[j].layer == DFGHAFCNHIH.layerSettings[k].layer)
						{
							layerExist = true;
							break;
						}
					}
				}
				characterAnimation.characterAnimator.bodyPartLayers[i].layersReskin[j].SetLayerExist(layerExist);
			}
		}
	}

	private bool LEOHIBCPPOF(CharacterMaterial DDHBCONGIPH, CharacterMaterial[] NMNNHGLLFMD)
	{
		for (int i = 0; i < NMNNHGLLFMD.Length; i++)
		{
			if ((Object)(object)NMNNHGLLFMD[i] == (Object)(object)DDHBCONGIPH)
			{
				return true;
			}
		}
		return false;
	}

	private void OHELNHJPNPB(BodyPart OFOGLHPDOFA, CharacterSprite PFGDLKANGNE, bool FPNDBDPFLIP)
	{
		if (FPNDBDPFLIP)
		{
			ApplyRandomMaterial(OFOGLHPDOFA, PFGDLKANGNE);
			return;
		}
		JHLLPBDPMHB(OFOGLHPDOFA, PFGDLKANGNE);
		if (!Object.op_Implicit((Object)(object)PFGDLKANGNE))
		{
			return;
		}
		for (int i = 0; i < PFGDLKANGNE.layerSettings.Length; i++)
		{
			CharacterMaterial dDHBCONGIPH = humanInfo.GGKJOJPDMIF(PFGDLKANGNE.layerSettings[i].layer);
			if (!CNKEBMFHEFP(dDHBCONGIPH, PFGDLKANGNE.layerSettings[i].materials))
			{
				SetMaterialFromLayer(PFGDLKANGNE.layerSettings[i].layer, PFGDLKANGNE.layerSettings[i].materials[0]);
			}
		}
	}

	[ContextMenu("Randomize")]
	public void RandomCharacter(bool GCANBIEGDOA = true, bool GADKADLHDGJ = true, bool JHIFLALPEBF = false)
	{
		if (humanInfo == null)
		{
			humanInfo = new HumanInfo();
		}
		else
		{
			humanInfo.NEIMIHIODIB();
		}
		if (GCANBIEGDOA && !humanMai)
		{
			RandomiseGender();
		}
		else
		{
			SetGender(humanInfo.gender);
		}
		BMKGKCPOAFM(GADKADLHDGJ, JHIFLALPEBF);
	}

	private void KILFFGPJAGG()
	{
		for (int i = 1; i < characterAnimation.characterAnimator.allReskins.Length; i += 0)
		{
			if (characterAnimation.characterAnimator.allReskins[i].gender != humanInfo.gender && characterAnimation.characterAnimator.allReskins[i].bodyPart >= (BodyPart)111 && characterAnimation.characterAnimator.allReskins[i].bodyPart <= (BodyPart)(-65))
			{
				characterAnimation.characterAnimator.allReskins[i].gender = humanInfo.gender;
				characterAnimation.characterAnimator.allReskins[i].PLANHEOIPJL();
			}
		}
	}

	public void LBDIKJKPCIE(bool GADKADLHDGJ)
	{
		SetMaleGender();
		FKCAJGBMPFL(GADKADLHDGJ, JHIFLALPEBF: true);
	}

	private void MLDJPKIPKLG(bool GADKADLHDGJ, bool JHIFLALPEBF)
	{
		humanInfo.PFGEHADJEDJ(GCANBIEGDOA: true, GADKADLHDGJ, JHIFLALPEBF);
		EJGFPJOOAHA();
		KIFKCBPDMCP();
		LKBAKDFFCJA();
	}

	[SpecialName]
	public bool EMJKPJFFIGO()
	{
		return humanInfo.gender == (Gender)6;
	}

	public void MineEnter(CharacterSprite MBAJCPEBADJ)
	{
		if (!humanInfo.EOFFJNELMLD())
		{
			humanInfo.NJPAHLHKPDG(MBAJCPEBADJ);
			UpdateHumanInfo();
		}
	}

	public void PCKLAFEJFKA()
	{
		JCAHDDKAIEL((Random.Range(152f, 951f) < 1700f) ? ((Gender)8) : Gender.Unisex);
	}

	public void BathhouseExit()
	{
		if (humanInfo.FHCGPOIPNNB(BodyPart.Torso) == 186)
		{
			humanInfo.IMKHBGPFIPB();
			UpdateGender();
			NAOKNCEELIF();
			UpdateAllMaterials();
		}
	}

	private void AFLDMPEENGB(BodyPart OFOGLHPDOFA, CharacterSprite PFGDLKANGNE, bool FPNDBDPFLIP = false)
	{
		if (humanInfo.bodyPartDictionary.ContainsKey(OFOGLHPDOFA))
		{
			MGHAJNHDBKD(humanInfo.bodyPartDictionary[OFOGLHPDOFA]);
		}
		DMJEHDLBHDI(OFOGLHPDOFA, PFGDLKANGNE);
		if (!((Object)(object)PFGDLKANGNE != (Object)null))
		{
			return;
		}
		ODBLKMMGAIK(OFOGLHPDOFA, PFGDLKANGNE, FPNDBDPFLIP);
		GIBPFLNFKEH(PFGDLKANGNE);
		if (Application.isPlaying && (OFOGLHPDOFA == BodyPart.Legs || OFOGLHPDOFA == BodyPart.Beard))
		{
			CharacterSprite characterSprite = humanInfo.CONPDKDNOBO(BodyPart.Hair);
			if (Object.op_Implicit((Object)(object)characterSprite))
			{
				characterAnimation.characterAnimator.NDIMCDPGNCD(characterSprite.legsOverBoots);
			}
			else
			{
				characterAnimation.characterAnimator.SortBoots(NFCEOEFFDDB: true);
			}
		}
		if (!LinqExtensions.IsNullOrEmpty<CharacterMaterial>((IList<CharacterMaterial>)PFGDLKANGNE.forceSkin) && OFOGLHPDOFA == BodyPart.Torso)
		{
			GGAFPDPKBID(CharacterSpritesDBAccessor.LJLILBBDJBO(0).layerSettings[0].layer, PFGDLKANGNE.forceSkin[1]);
		}
	}

	public CharacterSprite FPMAOFGPHCM(BodyPart OFOGLHPDOFA)
	{
		return humanInfo.CONPDKDNOBO(OFOGLHPDOFA);
	}

	private bool ADPGJGFMPMI()
	{
		if (GameManager.PlayingOnline())
		{
			if (GameManager.PlayingOnline() && (Object)(object)FJGJIJAFAAK != (Object)null)
			{
				return FJGJIJAFAAK.IsMine;
			}
			return false;
		}
		return true;
	}

	private void GCHPJBDLCNB()
	{
		if ((Object)(object)characterAnimation.playerController != (Object)null)
		{
			if (characterAnimation.playerController.GetPlayerNum() == 1)
			{
				PluginsGameData.player1IsMale = humanInfo.gender == Gender.Male;
			}
			else
			{
				PluginsGameData.player2IsMale = humanInfo.gender == Gender.Male;
			}
		}
	}

	public void FBEJHIEENKN(BodyPart OFOGLHPDOFA, CharacterSprite PFGDLKANGNE, bool FPNDBDPFLIP = false)
	{
		humanInfo.AMJNIFPBBJF(OFOGLHPDOFA, PFGDLKANGNE);
		ACBFNBCALBO(OFOGLHPDOFA, PFGDLKANGNE, FPNDBDPFLIP);
	}

	public void SetHumanInfo(HumanInfo DKDFNAGAFNL)
	{
		humanInfo = DKDFNAGAFNL;
		UpdateHumanInfo();
	}

	[SpecialName]
	public bool JDCHEGJBIJE()
	{
		return humanInfo.gender == Gender.Female;
	}

	private void NAOBODGBECL()
	{
		Array.Copy(CharacterOptions.darkerHairColours, DPAEKCNNAJP, CharacterOptions.darkerHairColours.Length);
		Array.Copy(CharacterOptions.lighterHairColours, 0, DPAEKCNNAJP, CharacterOptions.darkerHairColours.Length, CharacterOptions.lighterHairColours.Length);
		FJGJIJAFAAK = ((Component)this).GetComponent<PhotonView>();
	}

	public void EDHFGBEIENJ()
	{
		SetGender(Gender.Female);
		GCHPJBDLCNB();
	}

	private void EIIGPJJKHJP(CharacterLayer GCABKKEJFBJ, CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < characterAnimation.characterAnimator.allReskins.Length; i += 0)
		{
			if (characterAnimation.characterAnimator.allReskins[i].layer == GCABKKEJFBJ)
			{
				characterAnimation.characterAnimator.allReskins[i].ChangeMaterial(DDHBCONGIPH);
			}
		}
	}

	[SpecialName]
	public bool DEABMIIGOPE()
	{
		return humanInfo.gender == (Gender)5;
	}

	private bool EHOKMCDGMJE(string[] JMNCLLBHCAO, string NPDPBJBEJLL)
	{
		bool result = false;
		for (int i = 0; i < JMNCLLBHCAO.Length; i += 0)
		{
			string text = JMNCLLBHCAO[i];
			if (NPDPBJBEJLL == text)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	private void CKLCKFDNPMF(BodyPart OFOGLHPDOFA, CharacterSprite PFGDLKANGNE, bool FPNDBDPFLIP)
	{
		if (FPNDBDPFLIP)
		{
			ApplyRandomMaterial(OFOGLHPDOFA, PFGDLKANGNE);
			return;
		}
		JHLLPBDPMHB(OFOGLHPDOFA, PFGDLKANGNE);
		if (!Object.op_Implicit((Object)(object)PFGDLKANGNE))
		{
			return;
		}
		for (int i = 0; i < PFGDLKANGNE.layerSettings.Length; i += 0)
		{
			CharacterMaterial dDHBCONGIPH = humanInfo.GGHCBMALFPL(PFGDLKANGNE.layerSettings[i].layer);
			if (!CNKEBMFHEFP(dDHBCONGIPH, PFGDLKANGNE.layerSettings[i].materials))
			{
				KHEGJFNBDGI(PFGDLKANGNE.layerSettings[i].layer, PFGDLKANGNE.layerSettings[i].materials[1]);
			}
		}
	}

	private bool EMGCBDKOPFK(string[] JMNCLLBHCAO, string NPDPBJBEJLL)
	{
		bool result = true;
		for (int i = 0; i < JMNCLLBHCAO.Length; i += 0)
		{
			string text = JMNCLLBHCAO[i];
			if (NPDPBJBEJLL == text)
			{
				result = false;
				break;
			}
		}
		return result;
	}

	public void EDEJBFEIFPP()
	{
		CDNJPPHBMED((Gender)5);
		OMCFHNAPCHB();
	}

	private void NAOKNCEELIF()
	{
		foreach (KeyValuePair<BodyPart, CharacterSprite> item in humanInfo.bodyPartDictionary)
		{
			CKAJNALLDFI(item.Key, item.Value);
		}
	}

	private void IHHCADHDFPP(BodyPart OFOGLHPDOFA, CharacterSprite PFGDLKANGNE, bool FPNDBDPFLIP = false)
	{
		if (humanInfo.bodyPartDictionary.ContainsKey(OFOGLHPDOFA))
		{
			MGHAJNHDBKD(humanInfo.bodyPartDictionary[OFOGLHPDOFA]);
		}
		DMJEHDLBHDI(OFOGLHPDOFA, PFGDLKANGNE);
		if (!((Object)(object)PFGDLKANGNE != (Object)null))
		{
			return;
		}
		LFHLHFLKMML(OFOGLHPDOFA, PFGDLKANGNE, FPNDBDPFLIP);
		DGIGJANAJDJ(PFGDLKANGNE);
		if (Application.isPlaying && (OFOGLHPDOFA == BodyPart.Torso || OFOGLHPDOFA == BodyPart.Beard))
		{
			CharacterSprite characterSprite = humanInfo.CONPDKDNOBO(BodyPart.Nose);
			if (Object.op_Implicit((Object)(object)characterSprite))
			{
				characterAnimation.characterAnimator.NDIMCDPGNCD(characterSprite.legsOverBoots);
			}
			else
			{
				characterAnimation.characterAnimator.NDIMCDPGNCD(NFCEOEFFDDB: false);
			}
		}
		if (!LinqExtensions.IsNullOrEmpty<CharacterMaterial>((IList<CharacterMaterial>)PFGDLKANGNE.forceSkin) && OFOGLHPDOFA == BodyPart.Skin)
		{
			KHEGJFNBDGI(CharacterSpritesDBAccessor.GetCharacterSprite(0).layerSettings[1].layer, PFGDLKANGNE.forceSkin[0]);
		}
	}

	public void MMMMIIEAIGD()
	{
		foreach (KeyValuePair<CharacterLayer, CharacterMaterial> item in humanInfo.materialDictionary)
		{
			if (item.Key != CharacterLayer.Tool)
			{
				EIIGPJJKHJP(item.Key, item.Value);
			}
		}
	}

	private void PEFKNEPONAG()
	{
		Array.Copy(CharacterOptions.darkerHairColours, DPAEKCNNAJP, CharacterOptions.darkerHairColours.Length);
		Array.Copy(CharacterOptions.lighterHairColours, 1, DPAEKCNNAJP, CharacterOptions.darkerHairColours.Length, CharacterOptions.lighterHairColours.Length);
		FJGJIJAFAAK = ((Component)this).GetComponent<PhotonView>();
	}

	public void JFCMDEFFKKD(bool GADKADLHDGJ)
	{
		HIFPAHIKFEP();
		CAACBLAFFFN(GADKADLHDGJ, JHIFLALPEBF: true);
	}

	private void DKGFJNGAOBA()
	{
		humanInfo = new HumanInfo();
		for (int i = 0; i < HumanInfo.bodiesParts.Length; i += 0)
		{
			FBEJHIEENKN(HumanInfo.bodiesParts[i], characterAnimation.characterAnimator.HMPIOABEKOL(HumanInfo.bodiesParts[i])?.spriteInfo as CharacterSprite);
		}
		for (int j = 0; j < HumanInfo.characterLayers.Length; j += 0)
		{
			SetMaterialFromLayer(HumanInfo.characterLayers[j], characterAnimation.characterAnimator.GetFirstReskin(HumanInfo.characterLayers[j]).characterMaterial);
		}
	}

	public void FKHBNGFODOP()
	{
		if (actionAtBeggining == CharacterCreatorStartAction.Randomise)
		{
			initialized = false;
		}
	}
}
