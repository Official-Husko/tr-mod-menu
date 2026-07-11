using System.Runtime.CompilerServices;
using UnityEngine;

public class NinjaFoodTable : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	public int id;

	public SpriteRenderer spriteRenderer;

	public SpriteRenderer spriteRendererFood;

	public SpriteRenderer spriteRendererSignal;

	public Transform positionToTakeFood;

	public ParticleSystem particlesSystem;

	public Material outlineMaterial;

	private Material HKIODKOAHPE;

	public Food AJOMICMACEJ => NinjaFoodTablesManager.instance.GetFoodTableItem(id);

	public void HMIIELFEHHD()
	{
		if ((Object)(object)NinjaFoodTablesManager.instance == (Object)null && !Application.isPlaying)
		{
			NinjaFoodTablesManager.instance = Object.FindObjectOfType<NinjaFoodTablesManager>();
		}
		spriteRendererFood.sprite = NinjaFoodTablesManager.instance.JAOEKMAPBFG(id);
		spriteRendererSignal.sprite = NinjaFoodTablesManager.instance.GetSignalSprite(id);
	}

	public bool HAPLPIMJGGN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool JMPMCJDDKGD(int JIIGOACEIKL)
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			return true;
		}
		if (!NinjaChallenge.ADDLIAMDPBL)
		{
			return false;
		}
		return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public void DBHFOFJIHIB()
	{
		particlesSystem.Play();
	}

	private void Awake()
	{
		HKIODKOAHPE = ((Renderer)spriteRenderer).sharedMaterial;
	}

	public bool LDFBGJOFCHB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void BGBFJPJLPMF()
	{
		HKIODKOAHPE = ((Renderer)spriteRenderer).sharedMaterial;
	}

	public void PIJCFKHFBED(int JIIGOACEIKL)
	{
	}

	public void SetID(int MKNCFIEHMGB)
	{
		id = MKNCFIEHMGB;
		UpdateSprite();
	}

	public void PCKGLEPBNFE(int JIIGOACEIKL)
	{
	}

	public void JJELBOKLMLB(int JIIGOACEIKL)
	{
		((Renderer)spriteRenderer).sharedMaterial = HKIODKOAHPE;
	}

	public void DBPLFIOGBOM(int JIIGOACEIKL)
	{
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.NPMGIIIBGNP(AJOMICMACEJ))
			{
				return false;
			}
			if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count >= 3)
			{
				return false;
			}
			PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.FEEOFAGCONJ(AJOMICMACEJ.JMDALJBNFML());
			return true;
		}
		return false;
	}

	public void GNKHENEIOPC()
	{
		particlesSystem.Play();
	}

	[SpecialName]
	public Food MGCJCDOBAPP()
	{
		return NinjaFoodTablesManager.instance.GDMPIFINKEJ(id);
	}

	[SpecialName]
	public Food HJFKKMJNOIP()
	{
		return NinjaFoodTablesManager.instance.GetFoodTableItem(id);
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool IEJBNMOKBAI(int JIIGOACEIKL)
	{
		return false;
	}

	public void PDPMLNIPJJG(int JIIGOACEIKL)
	{
		((Renderer)spriteRenderer).sharedMaterial = HKIODKOAHPE;
	}

	public void KGHAMBEDHKD(int JIIGOACEIKL)
	{
	}

	public bool IPKOOEJJANI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (CKHHGCILKKK(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Dialogue System/Conversation/DeclinedRoom/Entry/1/Dialogue Text"));
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				((Renderer)spriteRenderer).sharedMaterial = outlineMaterial;
			}
			return true;
		}
		((Renderer)spriteRenderer).sharedMaterial = HKIODKOAHPE;
		return true;
	}

	public bool EOCIBHJBOLM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool CLFKOPEMJGH(int JIIGOACEIKL)
	{
		return false;
	}

	public void DNHKEEKHOAF()
	{
		particlesSystem.Play();
	}

	public void EDKAJNBJAJK(int JIIGOACEIKL)
	{
		((Renderer)spriteRenderer).sharedMaterial = HKIODKOAHPE;
	}

	public bool CAJMKLBCBEK(int JIIGOACEIKL)
	{
		if (JMPMCJDDKGD(JIIGOACEIKL))
		{
			if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.LDMNMBJFOMA(AJOMICMACEJ))
			{
				return false;
			}
			if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count >= 7)
			{
				return true;
			}
			PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.ILJFDOAABNH(GANOFJOFEAM().JMDALJBNFML());
			return true;
		}
		return true;
	}

	private void AAENCDNIBFJ()
	{
		HKIODKOAHPE = ((Renderer)spriteRenderer).sharedMaterial;
	}

	public bool GBGCHNBJBFG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (JMPMCJDDKGD(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("wForWeeks"));
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				((Renderer)spriteRenderer).sharedMaterial = outlineMaterial;
			}
			return true;
		}
		((Renderer)spriteRenderer).sharedMaterial = HKIODKOAHPE;
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private void HEMAHKJEONA()
	{
		HKIODKOAHPE = ((Renderer)spriteRenderer).sharedMaterial;
	}

	public void HACPCOIPNDD(int JIIGOACEIKL)
	{
	}

	public bool LGDMGLJCBJM(int JIIGOACEIKL)
	{
		if (HEOEEFNLJMO(JIIGOACEIKL))
		{
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.LOKKMKODJNJ(JPDPMMMOLNI()))
			{
				return true;
			}
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count >= 2)
			{
				return true;
			}
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.LBIMPLILOJP(MGCJCDOBAPP().JMDALJBNFML());
			return false;
		}
		return true;
	}

	public void DMAADGALMLN(int JIIGOACEIKL)
	{
		((Renderer)spriteRenderer).sharedMaterial = HKIODKOAHPE;
	}

	public void GGAOCGGKIEJ(int JIIGOACEIKL)
	{
	}

	public void JIHOOPJFDAD(int MKNCFIEHMGB)
	{
		id = MKNCFIEHMGB;
		UpdateSprite();
	}

	public bool LAIMPCCHFCH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (CKHHGCILKKK(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(" not found"));
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				((Renderer)spriteRenderer).sharedMaterial = outlineMaterial;
			}
			return true;
		}
		((Renderer)spriteRenderer).sharedMaterial = HKIODKOAHPE;
		return false;
	}

	public void DFFCCILMAHN(int JIIGOACEIKL)
	{
	}

	public bool FJPJAEKLDJF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void NPPALHNMMEN(int JIIGOACEIKL)
	{
	}

	private void KHONOODGLBI()
	{
		HKIODKOAHPE = ((Renderer)spriteRenderer).sharedMaterial;
	}

	public void LEAFCPEJJDM(int JIIGOACEIKL)
	{
	}

	private void EIHMDMMOPCM()
	{
		HKIODKOAHPE = ((Renderer)spriteRenderer).sharedMaterial;
	}

	public void OOJPHIEMPOO()
	{
		if ((Object)(object)NinjaFoodTablesManager.instance == (Object)null && !Application.isPlaying)
		{
			NinjaFoodTablesManager.instance = Object.FindObjectOfType<NinjaFoodTablesManager>();
		}
		spriteRendererFood.sprite = NinjaFoodTablesManager.instance.IFKFDNNOMFF(id);
		spriteRendererSignal.sprite = NinjaFoodTablesManager.instance.FJECLALNCIG(id);
	}

	public void UpdateSprite()
	{
		if ((Object)(object)NinjaFoodTablesManager.instance == (Object)null && !Application.isPlaying)
		{
			NinjaFoodTablesManager.instance = Object.FindObjectOfType<NinjaFoodTablesManager>();
		}
		spriteRendererFood.sprite = NinjaFoodTablesManager.instance.GetFoodSprite(id);
		spriteRendererSignal.sprite = NinjaFoodTablesManager.instance.GetSignalSprite(id);
	}

	private void EFJFJJDGGGI()
	{
		HKIODKOAHPE = ((Renderer)spriteRenderer).sharedMaterial;
	}

	public void BBIAGBIAELE(int JIIGOACEIKL)
	{
	}

	public bool AGJPABDBHCJ(int JIIGOACEIKL)
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			return false;
		}
		if (!NinjaChallenge.ADDLIAMDPBL)
		{
			return true;
		}
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public void NHNDOOBOKDO()
	{
		particlesSystem.Play();
	}

	public void EJDLBJGJAAN(int JIIGOACEIKL)
	{
	}

	private void KJHKBGDJNDC()
	{
		HKIODKOAHPE = ((Renderer)spriteRenderer).sharedMaterial;
	}

	public bool KAPFKOCOOCO(int JIIGOACEIKL)
	{
		if (DOLBNBFGKKP(JIIGOACEIKL))
		{
			if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.IHCMCKDNODF(MGCJCDOBAPP()))
			{
				return false;
			}
			if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count >= 4)
			{
				return false;
			}
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.ILJFDOAABNH(CAAIDKJIGLO().JMDALJBNFML());
			return true;
		}
		return false;
	}

	public bool COIGDMKGFCM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool CFLDFKODIKL(int JIIGOACEIKL)
	{
		if (CBKJOIDFOCG(JIIGOACEIKL))
		{
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.OFNAOLAMFJA(AJOMICMACEJ))
			{
				return true;
			}
			if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count >= 3)
			{
				return true;
			}
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.CBPCDEKHELA(AJOMICMACEJ.JMDALJBNFML());
			return false;
		}
		return false;
	}

	public bool HFKHIIFGAKP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (JMPMCJDDKGD(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Look"));
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				((Renderer)spriteRenderer).sharedMaterial = outlineMaterial;
			}
			return false;
		}
		((Renderer)spriteRenderer).sharedMaterial = HKIODKOAHPE;
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public void PEOILAGPJNB(int JIIGOACEIKL)
	{
	}

	[SpecialName]
	public Food GANOFJOFEAM()
	{
		return NinjaFoodTablesManager.instance.MJBECDFIBCC(id);
	}

	public bool GPHHMPEOCEJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (AGJPABDBHCJ(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("ToFish"));
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				((Renderer)spriteRenderer).sharedMaterial = outlineMaterial;
			}
			return false;
		}
		((Renderer)spriteRenderer).sharedMaterial = HKIODKOAHPE;
		return true;
	}

	public bool EKKKHOHJONB(int JIIGOACEIKL)
	{
		return false;
	}

	public bool OPDOELKOIMI(int JIIGOACEIKL)
	{
		return true;
	}

	public bool NFBGMIPPMDB(int JIIGOACEIKL)
	{
		return false;
	}

	public bool HEOEEFNLJMO(int JIIGOACEIKL)
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			return true;
		}
		if (!NinjaChallenge.ADDLIAMDPBL)
		{
			return true;
		}
		return DecorationMode.IECFJGHAIDO(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public void KOJMFFEMMEE()
	{
		particlesSystem.Play();
	}

	public void BEMEBLIDBGA(int JIIGOACEIKL)
	{
	}

	public void NKKLPHMBJGP()
	{
		if ((Object)(object)NinjaFoodTablesManager.instance == (Object)null && !Application.isPlaying)
		{
			NinjaFoodTablesManager.instance = Object.FindObjectOfType<NinjaFoodTablesManager>();
		}
		spriteRendererFood.sprite = NinjaFoodTablesManager.instance.JFHGCIJGGOF(id);
		spriteRendererSignal.sprite = NinjaFoodTablesManager.instance.LFDHJEOAJDE(id);
	}

	public bool MJDJANLLJPP(int JIIGOACEIKL)
	{
		return false;
	}

	private void KHCJDKHONPK()
	{
		HKIODKOAHPE = ((Renderer)spriteRenderer).sharedMaterial;
	}

	public void IIDGNNPFIEP(int MKNCFIEHMGB)
	{
		id = MKNCFIEHMGB;
		OOJPHIEMPOO();
	}

	public void OBBHKOLLLJH(int JIIGOACEIKL)
	{
	}

	public bool ONLBODAGFEP(int JIIGOACEIKL)
	{
		if (JMPMCJDDKGD(JIIGOACEIKL))
		{
			if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.EDNOMELCHEP(JPDPMMMOLNI()))
			{
				return true;
			}
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count >= 7)
			{
				return true;
			}
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.CANCHBINJNE(HJFKKMJNOIP().JMDALJBNFML());
			return false;
		}
		return false;
	}

	public void NDJCAFBKCIL(int JIIGOACEIKL)
	{
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Take"));
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				((Renderer)spriteRenderer).sharedMaterial = outlineMaterial;
			}
			return true;
		}
		((Renderer)spriteRenderer).sharedMaterial = HKIODKOAHPE;
		return false;
	}

	public void NOAIKDADPBD(int JIIGOACEIKL)
	{
		((Renderer)spriteRenderer).sharedMaterial = HKIODKOAHPE;
	}

	public void PPFIHGCMLHM(int MKNCFIEHMGB)
	{
		id = MKNCFIEHMGB;
		HMIIELFEHHD();
	}

	public void AEPBJIILGMP(int MKNCFIEHMGB)
	{
		id = MKNCFIEHMGB;
		MKFCJEELIEM();
	}

	private void JDHHJKBOJML()
	{
		HKIODKOAHPE = ((Renderer)spriteRenderer).sharedMaterial;
	}

	public bool CHAGCELLLOJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (CKHHGCILKKK(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("ReceiveRemoveDrink"));
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				((Renderer)spriteRenderer).sharedMaterial = outlineMaterial;
			}
			return false;
		}
		((Renderer)spriteRenderer).sharedMaterial = HKIODKOAHPE;
		return true;
	}

	[SpecialName]
	public Food NAPDEHMFOMM()
	{
		return NinjaFoodTablesManager.instance.LDPCMHBBPAC(id);
	}

	[SpecialName]
	public Food CAAIDKJIGLO()
	{
		return NinjaFoodTablesManager.instance.LMCKPCEFFOF(id);
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool NDIDAPAIOLL(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (CBKJOIDFOCG(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Round "));
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				((Renderer)spriteRenderer).sharedMaterial = outlineMaterial;
			}
			return false;
		}
		((Renderer)spriteRenderer).sharedMaterial = HKIODKOAHPE;
		return true;
	}

	public bool FCLFHOFIJAK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool PPJOGFFLKOL(int JIIGOACEIKL)
	{
		return false;
	}

	public void IJOHPJPPHHG(int JIIGOACEIKL)
	{
	}

	public void ONHOGJCOKBC(int JIIGOACEIKL)
	{
	}

	public bool OPCLGDNHJMI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool CKHHGCILKKK(int JIIGOACEIKL)
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			return true;
		}
		if (!NinjaChallenge.ADDLIAMDPBL)
		{
			return true;
		}
		return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public void OffHover(int JIIGOACEIKL)
	{
		((Renderer)spriteRenderer).sharedMaterial = HKIODKOAHPE;
	}

	public bool CBKJOIDFOCG(int JIIGOACEIKL)
	{
		if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			return true;
		}
		if (!NinjaChallenge.ADDLIAMDPBL)
		{
			return true;
		}
		return !DecorationMode.GetPlayer(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public void JBDIDGIGKAN()
	{
		particlesSystem.Play();
	}

	public bool DFFLACOALJM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (AGJPABDBHCJ(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Perk with id "));
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				((Renderer)spriteRenderer).sharedMaterial = outlineMaterial;
			}
			return false;
		}
		((Renderer)spriteRenderer).sharedMaterial = HKIODKOAHPE;
		return true;
	}

	public bool MGBCFPCOKID(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.EDNOMELCHEP(CAAIDKJIGLO()))
			{
				return false;
			}
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count >= 2)
			{
				return false;
			}
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.ILJFDOAABNH(NAPDEHMFOMM().JMDALJBNFML());
			return true;
		}
		return true;
	}

	public void ActivateParticles()
	{
		particlesSystem.Play();
	}

	public void GFMPBMEBOBD()
	{
		if ((Object)(object)NinjaFoodTablesManager.instance == (Object)null && !Application.isPlaying)
		{
			NinjaFoodTablesManager.instance = Object.FindObjectOfType<NinjaFoodTablesManager>();
		}
		spriteRendererFood.sprite = NinjaFoodTablesManager.instance.JFHGCIJGGOF(id);
		spriteRendererSignal.sprite = NinjaFoodTablesManager.instance.CHINILGEFBD(id);
	}

	public bool OFBABFAOFEJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void MKFCJEELIEM()
	{
		if ((Object)(object)NinjaFoodTablesManager.instance == (Object)null && !Application.isPlaying)
		{
			NinjaFoodTablesManager.instance = Object.FindObjectOfType<NinjaFoodTablesManager>();
		}
		spriteRendererFood.sprite = NinjaFoodTablesManager.instance.CLFACINLGDM(id);
		spriteRendererSignal.sprite = NinjaFoodTablesManager.instance.GetSignalSprite(id);
	}

	public bool BDEEAGGBHCE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			return false;
		}
		if (!NinjaChallenge.ADDLIAMDPBL)
		{
			return false;
		}
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool JCCHKBELDFJ(int JIIGOACEIKL)
	{
		return false;
	}

	public bool PPJFDGOOIDK(int JIIGOACEIKL)
	{
		if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			return true;
		}
		if (!NinjaChallenge.ADDLIAMDPBL)
		{
			return false;
		}
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public void BDGEMFNLDGC(int JIIGOACEIKL)
	{
	}

	public void FGIJLMGFNMM(int JIIGOACEIKL)
	{
		((Renderer)spriteRenderer).sharedMaterial = HKIODKOAHPE;
	}

	public void LIKMMPIIFJI()
	{
		particlesSystem.Play();
	}

	private void PKPHKBMPJGJ()
	{
		HKIODKOAHPE = ((Renderer)spriteRenderer).sharedMaterial;
	}

	public bool DOLBNBFGKKP(int JIIGOACEIKL)
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			return false;
		}
		if (!NinjaChallenge.ADDLIAMDPBL)
		{
			return false;
		}
		return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).KNFEPKBIHND();
	}

	public void KMBCKODACPJ(int JIIGOACEIKL)
	{
	}

	public bool OFMJFMILDJP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void LGOPNIBHMIA(int JIIGOACEIKL)
	{
	}

	public void FAMFDBFEMHK(int MKNCFIEHMGB)
	{
		id = MKNCFIEHMGB;
		UpdateSprite();
	}

	[SpecialName]
	public Food JPDPMMMOLNI()
	{
		return NinjaFoodTablesManager.instance.KLHHHFLOPKK(id);
	}

	public bool NDHKOEDAHNI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (JMPMCJDDKGD(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Trying to add a player that's already on the list."));
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				((Renderer)spriteRenderer).sharedMaterial = outlineMaterial;
			}
			return false;
		}
		((Renderer)spriteRenderer).sharedMaterial = HKIODKOAHPE;
		return false;
	}
}
