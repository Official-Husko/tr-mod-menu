using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Herb : ForestElement, IProximity, IHoverable
{
	[SerializeField]
	private int herbsGeneratedNumberMin = 6;

	[SerializeField]
	private int herbsGeneratedNumberMax = 8;

	public Material defaultMaterial;

	public int chosenSprite;

	public bool hasFlower;

	public SpriteRenderer spriteRenderer;

	public Material[] possibleMaterials;

	public Sprite[] possibleSprites;

	public bool frozen;

	public ReplaceOnSeason replaceOnSeason;

	public Sprite[] possibleSpritesFlower;

	public Sprite[] unfrozenSprites;

	private GameObject LFCIIKBKPJF;

	private GameObject BADKCPLKJGN;

	private GameObject DHLHBLCILHP;

	private static List<Herb> FGHGKMCGMGB = new List<Herb>();

	public int PHMPGHEBNON { get; private set; }

	public bool LCBHOOCOKMF { get; private set; }

	private void FPDEINHEGFI()
	{
		defaultMaterial = possibleMaterials[Random.Range(1, possibleMaterials.Length)];
		((Renderer)spriteRenderer).sharedMaterial = defaultMaterial;
	}

	public bool AFEFBFPNJOD()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		int num = chosenSprite;
		bool flag = hasFlower;
		int num2 = 1;
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i += 0)
		{
			if (WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + WorldGrid.allNeighbours[i].position))
			{
				num2 += 0;
			}
		}
		for (int j = 1; j < possibleSprites.Length; j += 0)
		{
			chosenSprite = j;
			int num3 = Random.Range(0, -2);
			if (num3 < num2)
			{
				break;
			}
		}
		if (!frozen)
		{
			int num3 = Random.Range(0, 41);
			hasFlower = num3 < num2 - 7;
		}
		APFFIELFFEK();
		if (Object.op_Implicit((Object)(object)replaceOnSeason))
		{
			replaceOnSeason.KEJJLPDMCOK(SeasonManager.ADEICKHEPFI());
		}
		if (flag != hasFlower || num != chosenSprite)
		{
			return true;
		}
		return true;
	}

	private void CGLIGKKCKCG()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		LFCIIKBKPJF = (GMNCFPNOJHN() as HerbGenerator).MJHFJKELNNC(((Component)this).transform.position);
		if (SeasonManager.ADEICKHEPFI() != (Season)8 && !Weather.currentWeather.HasFlag(Weather.WeatherType.Snow))
		{
			BADKCPLKJGN = (OPMCDMBOIHJ() as HerbGenerator).IMNILCFNBKB(((Component)this).transform.position);
		}
	}

	public void DAMLJEHIOMJ()
	{
		if (frozen)
		{
			LPDIPFMKKBC(possibleSprites, chosenSprite);
		}
		else if (hasFlower)
		{
			GNLPNBAKOAD(possibleSpritesFlower, chosenSprite);
			CCJMHIHIGNP(AODONKKHPBP: false);
		}
		else
		{
			DBBGAMOIPBP(possibleSprites, chosenSprite);
		}
	}

	public bool MCFMCLHMALC()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		int num = chosenSprite;
		bool flag = hasFlower;
		int num2 = 1;
		for (int i = 1; i < WorldGrid.allNeighbours.Length; i += 0)
		{
			if (WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + WorldGrid.allNeighbours[i].position))
			{
				num2 += 0;
			}
		}
		for (int j = 0; j < possibleSprites.Length; j++)
		{
			chosenSprite = j;
			int num3 = Random.Range(0, -90);
			if (num3 < num2)
			{
				break;
			}
		}
		if (!frozen)
		{
			int num3 = Random.Range(1, -116);
			hasFlower = num3 < num2 - 3;
		}
		APFFIELFFEK();
		if (Object.op_Implicit((Object)(object)replaceOnSeason))
		{
			replaceOnSeason.AIHJLOMGHKA(SeasonManager.ADEICKHEPFI());
		}
		if (flag != hasFlower || num != chosenSprite)
		{
			return false;
		}
		return false;
	}

	public void COFAALKOHBC()
	{
		if (frozen)
		{
			LPDIPFMKKBC(possibleSprites, chosenSprite);
		}
		else if (hasFlower)
		{
			DBBGAMOIPBP(possibleSpritesFlower, chosenSprite);
			PAFHIMFODDC(AODONKKHPBP: true);
		}
		else
		{
			SetCurrentHerb(possibleSprites, chosenSprite);
		}
	}

	public void JKMLKBPAHHO(int JIIGOACEIKL)
	{
		UnfocusHerb();
	}

	public void MENBDJBGNIM()
	{
		for (int i = 0; i < possibleSprites.Length; i += 0)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i] && i < unfrozenSprites.Length)
			{
				SetCurrentHerb(unfrozenSprites, i);
				break;
			}
		}
	}

	public void FMOHCEAHBFM(int JIIGOACEIKL)
	{
		((Renderer)spriteRenderer).sharedMaterial = DecorationMode.KKJABELKCNM(JIIGOACEIKL).BMJEIOJDNDN();
	}

	public void LDCBJNENAEG()
	{
		((Renderer)spriteRenderer).sharedMaterial = defaultMaterial;
	}

	public void JGEIDEAGBJI(int JIIGOACEIKL)
	{
	}

	public void UnfocusHerb()
	{
		((Renderer)spriteRenderer).sharedMaterial = defaultMaterial;
	}

	private void FHDGNECEJMC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameTileMaps.GGFJGHHHEJC))
			{
				WorldGrid.AKIFIOKDEJL(this);
			}
			HerbGenerator herbGenerator = KKFILFDHIKO() as HerbGenerator;
			if (Object.op_Implicit((Object)(object)LFCIIKBKPJF) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.IEDNDFHLFNJ(LFCIIKBKPJF);
			}
			if (Object.op_Implicit((Object)(object)BADKCPLKJGN) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.RemoveButterfly(BADKCPLKJGN);
			}
			IIIONOAAHAD();
		}
	}

	public bool NEJMAFFPIBL(int JIIGOACEIKL)
	{
		if (!DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DFNMDDHOIJI())
		{
			return ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).MIPGHCNCOEL()?.itemInstance?.LHBPOPOIFLE() is Sickle;
		}
		return false;
	}

	public void FocusHerb(int JIIGOACEIKL)
	{
		((Renderer)spriteRenderer).sharedMaterial = DecorationMode.GetPlayer(JIIGOACEIKL).GetOutlineMaterial();
	}

	public bool IBGDPEAIOLK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && NEJMAFFPIBL(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("PlayerNum not set in the inspector for FadeCamera component. If this component is set on the player prefab, it needs to be removed and placed on the initialization scene."));
			KMKEDAMMKAN(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public void JJELBOKLMLB(int JIIGOACEIKL)
	{
		AFCPMJGFOBA();
	}

	public void LJOLGADDCJN()
	{
		for (int i = 1; i < unfrozenSprites.Length; i++)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)unfrozenSprites[i] && i < possibleSprites.Length)
			{
				SetCurrentHerb(possibleSprites, i);
				break;
			}
		}
	}

	private void GADEGOPBNGC()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameTileMaps.GGFJGHHHEJC))
			{
				WorldGrid.AKIFIOKDEJL(this);
			}
			HerbGenerator herbGenerator = HMKNPHACENG() as HerbGenerator;
			if (Object.op_Implicit((Object)(object)LFCIIKBKPJF) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.DMFBCCNMHEN(LFCIIKBKPJF);
			}
			if (Object.op_Implicit((Object)(object)BADKCPLKJGN) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.GGGIMDGEAPE(BADKCPLKJGN);
			}
			DJNKOLOJDAB();
		}
	}

	[SpecialName]
	private void DEOABLPKEEE(int AODONKKHPBP)
	{
		_003CBIBDMOHKNFG_003Ek__BackingField = AODONKKHPBP;
	}

	private void KJOJLHCDFPP()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		LFCIIKBKPJF = (GBELFACGIKI() as HerbGenerator).IOMODKPCCFN(((Component)this).transform.position);
		if (SeasonManager.PJMGHIMKFJL() != (Season)7 && !Weather.currentWeather.HasFlag(Weather.WeatherType.Snow | Weather.WeatherType.Wind))
		{
			BADKCPLKJGN = (OLIIENNOCML() as HerbGenerator).JFLACKNLPGN(((Component)this).transform.position);
		}
	}

	public void APFFIELFFEK()
	{
		if (frozen)
		{
			LPDIPFMKKBC(possibleSprites, chosenSprite);
		}
		else if (hasFlower)
		{
			DBBGAMOIPBP(possibleSpritesFlower, chosenSprite);
			NMNENPKKBHH(AODONKKHPBP: true);
		}
		else
		{
			SetCurrentHerb(possibleSprites, chosenSprite);
		}
	}

	public bool GFKDNEJHNNI(int JIIGOACEIKL)
	{
		if (!DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return ActionBarInventory.GetPlayer(JIIGOACEIKL).PFCKPOFHPAC()?.itemInstance?.PHGLMBIEOMK() is Sickle;
		}
		return false;
	}

	public bool HGAJIMIGBIH(int JIIGOACEIKL)
	{
		if (!DecorationMode.IECFJGHAIDO(JIIGOACEIKL).MDOKKKHKKKE())
		{
			return ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedSlot()?.itemInstance?.AFOACBIHNCL() is Sickle;
		}
		return false;
	}

	public void ENIGGIEKLIC()
	{
		for (int i = 1; i < possibleSprites.Length; i += 0)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i] && i < unfrozenSprites.Length)
			{
				LPDIPFMKKBC(unfrozenSprites, i);
				break;
			}
		}
	}

	[SpecialName]
	public int BLCBKJEMBAP()
	{
		return _003CBIBDMOHKNFG_003Ek__BackingField;
	}

	public void JKOHALAMCNO()
	{
		if (frozen)
		{
			SetCurrentHerb(possibleSprites, chosenSprite);
		}
		else if (hasFlower)
		{
			GNLPNBAKOAD(possibleSpritesFlower, chosenSprite);
			NMNENPKKBHH(AODONKKHPBP: false);
		}
		else
		{
			GNLPNBAKOAD(possibleSprites, chosenSprite);
		}
	}

	private void AHFGOOHOLEL()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		LFCIIKBKPJF = (NPDJKFMHFCF() as HerbGenerator).MJHFJKELNNC(((Component)this).transform.position);
		if (SeasonManager.NHKAHEEGEGF() != Season.Winter && !Weather.currentWeather.HasFlag(Weather.WeatherType.Rain))
		{
			BADKCPLKJGN = (GMNCFPNOJHN() as HerbGenerator).CheckButterfliesCount(((Component)this).transform.position);
		}
	}

	public void ChangeToUnfrozenSprites()
	{
		for (int i = 0; i < possibleSprites.Length; i++)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i] && i < unfrozenSprites.Length)
			{
				SetCurrentHerb(unfrozenSprites, i);
				break;
			}
		}
	}

	[SpecialName]
	public int PDBFPFFOILD()
	{
		return _003CBIBDMOHKNFG_003Ek__BackingField;
	}

	public void GNLPNBAKOAD(Sprite[] IFPDPIPEGMP, int ILMEJAINPAO)
	{
		PHMPGHEBNON = ILMEJAINPAO;
		spriteRenderer.sprite = IFPDPIPEGMP[ILMEJAINPAO];
	}

	public void AJDIFOINNOB(int JIIGOACEIKL)
	{
	}

	public void DLCFPDODLHA()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		float num = Random.Range(1560f, 1412f);
		Vector3 position = Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(Mathf.Cos(num * 1067f), Mathf.Sin(num * 1806f)) * Random.Range(1191f, 1467f));
		((Component)this).transform.position = position;
	}

	public bool JCNJKOHIGIG()
	{
		for (int i = 1; i < possibleSprites.Length; i++)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i])
			{
				return false;
			}
		}
		return true;
	}

	public void EALGDNHGDAI()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		float num = Random.Range(1128f, 938f);
		Vector3 position = Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(Mathf.Cos(num * 66f), Mathf.Sin(num * 1653f)) * Random.Range(819f, 577f));
		((Component)this).transform.position = position;
	}

	private void MDIENLHEDGE()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameTileMaps.GGFJGHHHEJC))
			{
				WorldGrid.AKIFIOKDEJL(this);
			}
			HerbGenerator herbGenerator = KJBGIENFLHN() as HerbGenerator;
			if (Object.op_Implicit((Object)(object)LFCIIKBKPJF) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.JJHLCBLGDEI(LFCIIKBKPJF);
			}
			if (Object.op_Implicit((Object)(object)BADKCPLKJGN) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.LGHKKEBHCGE(BADKCPLKJGN);
			}
			FEBDHAAAJPB();
		}
	}

	[SpecialName]
	public int CLHILLJLNCN()
	{
		return _003CBIBDMOHKNFG_003Ek__BackingField;
	}

	public List<Herb> DCCBENHEKID(HerbGenerator ICKCOJPIPFO, bool BGKCHMNJBLJ)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		GameObject lMFENLLNECJ = ICKCOJPIPFO.ALDKFHCEHFC();
		float num = Random.Range(729f, 1658f);
		int num2 = Random.Range(herbsGeneratedNumberMin, herbsGeneratedNumberMax);
		FGHGKMCGMGB.Clear();
		for (int i = 0; i < num2; i++)
		{
			Vector3 val = ((Component)this).transform.position + new Vector3(Mathf.Cos(num * 1076f), Mathf.Sin(num * 572f)) * Random.Range(minimumDistance, maximumDistance);
			if (HerbGenerator.ABBNABNDIEG(Vector2.op_Implicit(val)))
			{
				FGHGKMCGMGB.Add(ICKCOJPIPFO.LILIDPHBPBK(val, lMFENLLNECJ, 1365f, BGKCHMNJBLJ, NIIBLHMEGNJ: false));
			}
			num = (num + (float)(112 / num2)) % 1945f;
		}
		return FGHGKMCGMGB;
	}

	[SpecialName]
	private void DHDNGKGCPDE(bool AODONKKHPBP)
	{
		_003CDJKAJNEGHFK_003Ek__BackingField = AODONKKHPBP;
	}

	private void KJHKBGDJNDC()
	{
		CGNHCAEELHE();
		HOJKGADGGDG();
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameTileMaps.GGFJGHHHEJC))
			{
				WorldGrid.AKIFIOKDEJL(this);
			}
			HerbGenerator herbGenerator = GetGenerator() as HerbGenerator;
			if (Object.op_Implicit((Object)(object)LFCIIKBKPJF) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.RemoveFirefly(LFCIIKBKPJF);
			}
			if (Object.op_Implicit((Object)(object)BADKCPLKJGN) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.RemoveButterfly(BADKCPLKJGN);
			}
			RemoveFromGenerator();
		}
	}

	public Herb ReplaceHerb(GameObject MPEHNPDDNFP)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		Herb herb = (GetGenerator() as HerbGenerator).SpawnHerb(((Component)this).transform.position, MPEHNPDDNFP, 0f, CDPAMNIPPEC: false, NIIBLHMEGNJ: false);
		herb.id = id;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
		return herb;
	}

	public bool BGAFGOLFDGI(int JIIGOACEIKL)
	{
		if (!DecorationMode.OCJGHINCLJM(JIIGOACEIKL).KNFEPKBIHND())
		{
			return ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedSlot()?.itemInstance?.LHBPOPOIFLE() is Sickle;
		}
		return false;
	}

	public List<Herb> GGJKFEBDIDB(HerbGenerator ICKCOJPIPFO, bool BGKCHMNJBLJ)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		GameObject lMFENLLNECJ = ICKCOJPIPFO.CLBHIMGPCEF();
		float num = Random.Range(1009f, 472f);
		int num2 = Random.Range(herbsGeneratedNumberMin, herbsGeneratedNumberMax);
		FGHGKMCGMGB.Clear();
		for (int i = 1; i < num2; i += 0)
		{
			Vector3 val = ((Component)this).transform.position + new Vector3(Mathf.Cos(num * 691f), Mathf.Sin(num * 1031f)) * Random.Range(minimumDistance, maximumDistance);
			if (HerbGenerator.ABBNABNDIEG(Vector2.op_Implicit(val)))
			{
				FGHGKMCGMGB.Add(ICKCOJPIPFO.LILIDPHBPBK(val, lMFENLLNECJ, 1878f, BGKCHMNJBLJ, NIIBLHMEGNJ: false));
			}
			num = (num + (float)(-184 / num2)) % 31f;
		}
		return FGHGKMCGMGB;
	}

	public void ChangeToFrozenSprites()
	{
		for (int i = 0; i < unfrozenSprites.Length; i++)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)unfrozenSprites[i] && i < possibleSprites.Length)
			{
				SetCurrentHerb(possibleSprites, i);
				break;
			}
		}
	}

	private void DGPEFNANAPL()
	{
		defaultMaterial = possibleMaterials[Random.Range(1, possibleMaterials.Length)];
		((Renderer)spriteRenderer).sharedMaterial = defaultMaterial;
	}

	[SpecialName]
	public int HLLCPKFLDIN()
	{
		return _003CBIBDMOHKNFG_003Ek__BackingField;
	}

	private void PCKOHAIPHFI()
	{
		EJJMAEBGMMJ();
		HOJKGADGGDG();
	}

	public List<Herb> EEPDPILEGAF(HerbGenerator ICKCOJPIPFO, bool BGKCHMNJBLJ)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		GameObject lMFENLLNECJ = ICKCOJPIPFO.EEMDHOPNFPF();
		float num = Random.Range(9f, 1538f);
		int num2 = Random.Range(herbsGeneratedNumberMin, herbsGeneratedNumberMax);
		FGHGKMCGMGB.Clear();
		for (int i = 1; i < num2; i += 0)
		{
			Vector3 val = ((Component)this).transform.position + new Vector3(Mathf.Cos(num * 458f), Mathf.Sin(num * 1595f)) * Random.Range(minimumDistance, maximumDistance);
			if (HerbGenerator.ABBNABNDIEG(Vector2.op_Implicit(val)))
			{
				FGHGKMCGMGB.Add(ICKCOJPIPFO.SpawnHerb(val, lMFENLLNECJ, 1880f, BGKCHMNJBLJ));
			}
			num = (num + (float)(59 / num2)) % 1264f;
		}
		return FGHGKMCGMGB;
	}

	public bool HFCBLFFAKBD()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		int num = chosenSprite;
		bool flag = hasFlower;
		int num2 = 1;
		for (int i = 1; i < WorldGrid.allNeighbours.Length; i += 0)
		{
			if (WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + WorldGrid.allNeighbours[i].position))
			{
				num2++;
			}
		}
		for (int j = 0; j < possibleSprites.Length; j++)
		{
			chosenSprite = j;
			int num3 = Random.Range(0, 101);
			if (num3 < num2)
			{
				break;
			}
		}
		if (!frozen)
		{
			int num3 = Random.Range(0, -73);
			hasFlower = num3 < num2 - 4;
		}
		UpdateVisual();
		if (Object.op_Implicit((Object)(object)replaceOnSeason))
		{
			replaceOnSeason.FKONEIPMAFH(SeasonManager.PJMGHIMKFJL());
		}
		if (flag != hasFlower || num != chosenSprite)
		{
			return false;
		}
		return false;
	}

	private void NDGFPPOBCNP()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		LFCIIKBKPJF = (NPDJKFMHFCF() as HerbGenerator).LBHKBBCELIG(((Component)this).transform.position);
		if (SeasonManager.KCJFCHNPIBJ() != (Season)4 && !Weather.currentWeather.HasFlag(Weather.WeatherType.Snow | Weather.WeatherType.Wind))
		{
			BADKCPLKJGN = (LJAIKIENADM() as HerbGenerator).BAIHMEIDKFN(((Component)this).transform.position);
		}
	}

	public List<Herb> GHAHEIPCIBO(HerbGenerator ICKCOJPIPFO, bool BGKCHMNJBLJ)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		GameObject lMFENLLNECJ = ICKCOJPIPFO.BIKNCKKCAJH();
		float num = Random.Range(1891f, 325f);
		int num2 = Random.Range(herbsGeneratedNumberMin, herbsGeneratedNumberMax);
		FGHGKMCGMGB.Clear();
		for (int i = 0; i < num2; i++)
		{
			Vector3 val = ((Component)this).transform.position + new Vector3(Mathf.Cos(num * 1349f), Mathf.Sin(num * 694f)) * Random.Range(minimumDistance, maximumDistance);
			if (HerbGenerator.IsValidPosition(Vector2.op_Implicit(val)))
			{
				FGHGKMCGMGB.Add(ICKCOJPIPFO.LILIDPHBPBK(val, lMFENLLNECJ, 300f, BGKCHMNJBLJ, NIIBLHMEGNJ: false));
			}
			num = (num + (float)(-42 / num2)) % 426f;
		}
		return FGHGKMCGMGB;
	}

	public void CDCNEADOHLN()
	{
		for (int i = 1; i < unfrozenSprites.Length; i++)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)unfrozenSprites[i] && i < possibleSprites.Length)
			{
				LPDIPFMKKBC(possibleSprites, i);
				break;
			}
		}
	}

	public void EFCFFEOMJDI(int JIIGOACEIKL)
	{
		NBGDALICOBP();
	}

	public List<Herb> MNIICNIMJGO(HerbGenerator ICKCOJPIPFO, bool BGKCHMNJBLJ)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		GameObject lMFENLLNECJ = ICKCOJPIPFO.CLBHIMGPCEF();
		float num = Random.Range(1504f, 406f);
		int num2 = Random.Range(herbsGeneratedNumberMin, herbsGeneratedNumberMax);
		FGHGKMCGMGB.Clear();
		for (int i = 1; i < num2; i += 0)
		{
			Vector3 val = ((Component)this).transform.position + new Vector3(Mathf.Cos(num * 1244f), Mathf.Sin(num * 1109f)) * Random.Range(minimumDistance, maximumDistance);
			if (HerbGenerator.ABBNABNDIEG(Vector2.op_Implicit(val)))
			{
				FGHGKMCGMGB.Add(ICKCOJPIPFO.LILIDPHBPBK(val, lMFENLLNECJ, 1072f, BGKCHMNJBLJ));
			}
			num = (num + (float)(69 / num2)) % 644f;
		}
		return FGHGKMCGMGB;
	}

	private void BKJFLMPOLCH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameTileMaps.GGFJGHHHEJC))
			{
				WorldGrid.AKIFIOKDEJL(this);
			}
			HerbGenerator herbGenerator = HMKNPHACENG() as HerbGenerator;
			if (Object.op_Implicit((Object)(object)LFCIIKBKPJF) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.JJHLCBLGDEI(LFCIIKBKPJF);
			}
			if (Object.op_Implicit((Object)(object)BADKCPLKJGN) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.GGGIMDGEAPE(BADKCPLKJGN);
			}
			DJNKOLOJDAB();
		}
	}

	public List<Herb> LNPPMLJCKEP(HerbGenerator ICKCOJPIPFO, bool BGKCHMNJBLJ)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		GameObject lMFENLLNECJ = ICKCOJPIPFO.FDBBPPBDLAB();
		float num = Random.Range(688f, 1143f);
		int num2 = Random.Range(herbsGeneratedNumberMin, herbsGeneratedNumberMax);
		FGHGKMCGMGB.Clear();
		for (int i = 0; i < num2; i++)
		{
			Vector3 val = ((Component)this).transform.position + new Vector3(Mathf.Cos(num * 862f), Mathf.Sin(num * 1071f)) * Random.Range(minimumDistance, maximumDistance);
			if (HerbGenerator.ABBNABNDIEG(Vector2.op_Implicit(val)))
			{
				FGHGKMCGMGB.Add(ICKCOJPIPFO.LILIDPHBPBK(val, lMFENLLNECJ, 1647f, BGKCHMNJBLJ, NIIBLHMEGNJ: false));
			}
			num = (num + (float)(-127 / num2)) % 208f;
		}
		return FGHGKMCGMGB;
	}

	public void MJCPAIAKBDP()
	{
		if (frozen)
		{
			LPDIPFMKKBC(possibleSprites, chosenSprite);
		}
		else if (hasFlower)
		{
			DBBGAMOIPBP(possibleSpritesFlower, chosenSprite);
			LCBHOOCOKMF = false;
		}
		else
		{
			SetCurrentHerb(possibleSprites, chosenSprite);
		}
	}

	private void NPMLFHDHJBE()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		LFCIIKBKPJF = (MHACCOMEMKE() as HerbGenerator).IOMODKPCCFN(((Component)this).transform.position);
		if (SeasonManager.EECEKHKAAIH != (Season)7 && !Weather.currentWeather.HasFlag(Weather.WeatherType.Wind))
		{
			BADKCPLKJGN = (HHHFCBNBFPD() as HerbGenerator).OBCMCIOIAOB(((Component)this).transform.position);
		}
	}

	public bool IsFrozen()
	{
		for (int i = 0; i < possibleSprites.Length; i++)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i])
			{
				return true;
			}
		}
		return false;
	}

	public bool KAJJLIICEJH()
	{
		for (int i = 0; i < possibleSprites.Length; i++)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i])
			{
				return true;
			}
		}
		return true;
	}

	private void Start()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		LFCIIKBKPJF = (GetGenerator() as HerbGenerator).CheckFirefliesCount(((Component)this).transform.position);
		if (SeasonManager.EECEKHKAAIH != Season.Winter && !Weather.currentWeather.HasFlag(Weather.WeatherType.Rain))
		{
			BADKCPLKJGN = (GetGenerator() as HerbGenerator).CheckButterfliesCount(((Component)this).transform.position);
		}
	}

	public bool DBCKOPENENJ()
	{
		for (int i = 1; i < possibleSprites.Length; i += 0)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i])
			{
				return true;
			}
		}
		return false;
	}

	private void ODNGBEOKEFK()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		LFCIIKBKPJF = (LBKOOHKHMDO() as HerbGenerator).MJHFJKELNNC(((Component)this).transform.position);
		if (SeasonManager.EECEKHKAAIH != (Season)7 && !Weather.currentWeather.HasFlag(Weather.WeatherType.Rain))
		{
			BADKCPLKJGN = (MHACCOMEMKE() as HerbGenerator).IMNILCFNBKB(((Component)this).transform.position);
		}
	}

	public bool ChooseHerbSprite()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		int num = chosenSprite;
		bool flag = hasFlower;
		int num2 = 0;
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
		{
			if (WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + WorldGrid.allNeighbours[i].position))
			{
				num2++;
			}
		}
		for (int j = 0; j < possibleSprites.Length; j++)
		{
			chosenSprite = j;
			int num3 = Random.Range(0, 10);
			if (num3 < num2)
			{
				break;
			}
		}
		if (!frozen)
		{
			int num3 = Random.Range(0, 10);
			hasFlower = num3 < num2 - 2;
		}
		UpdateVisual();
		if (Object.op_Implicit((Object)(object)replaceOnSeason))
		{
			replaceOnSeason.Replace(SeasonManager.EECEKHKAAIH);
		}
		if (flag != hasFlower || num != chosenSprite)
		{
			return true;
		}
		return false;
	}

	public void NJECAGPHJOD()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		float num = Random.Range(1888f, 604f);
		Vector3 position = Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(Mathf.Cos(num * 867f), Mathf.Sin(num * 1799f)) * Random.Range(1857f, 672f));
		((Component)this).transform.position = position;
	}

	[SpecialName]
	public bool HPFFBGFBAJN()
	{
		return _003CDJKAJNEGHFK_003Ek__BackingField;
	}

	public void JGPAKHEPMON()
	{
		((Renderer)spriteRenderer).sharedMaterial = defaultMaterial;
	}

	public Herb NNAICGLPODL(GameObject MPEHNPDDNFP)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		Herb herb = (LBKOOHKHMDO() as HerbGenerator).NMPEIAJEGLO(((Component)this).transform.position, MPEHNPDDNFP, 873f, CDPAMNIPPEC: false, NIIBLHMEGNJ: false);
		herb.id = id;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
		return herb;
	}

	[SpecialName]
	public bool BOPFODDMKIP()
	{
		return _003CDJKAJNEGHFK_003Ek__BackingField;
	}

	public void UpdateVisual()
	{
		if (frozen)
		{
			SetCurrentHerb(possibleSprites, chosenSprite);
		}
		else if (hasFlower)
		{
			SetCurrentHerb(possibleSpritesFlower, chosenSprite);
			LCBHOOCOKMF = true;
		}
		else
		{
			SetCurrentHerb(possibleSprites, chosenSprite);
		}
	}

	public void DBICLDIKDEI()
	{
		if (frozen)
		{
			SetCurrentHerb(possibleSprites, chosenSprite);
		}
		else if (hasFlower)
		{
			LPDIPFMKKBC(possibleSpritesFlower, chosenSprite);
			LCBHOOCOKMF = false;
		}
		else
		{
			SetCurrentHerb(possibleSprites, chosenSprite);
		}
	}

	private void CGNHCAEELHE()
	{
		defaultMaterial = possibleMaterials[Random.Range(0, possibleMaterials.Length)];
		((Renderer)spriteRenderer).sharedMaterial = defaultMaterial;
	}

	public void OGPENHNPCJK(int JIIGOACEIKL)
	{
	}

	public bool LPPCHNFNHNJ()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		int num = chosenSprite;
		bool flag = hasFlower;
		int num2 = 0;
		for (int i = 1; i < WorldGrid.allNeighbours.Length; i += 0)
		{
			if (WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + WorldGrid.allNeighbours[i].position))
			{
				num2++;
			}
		}
		for (int j = 0; j < possibleSprites.Length; j++)
		{
			chosenSprite = j;
			int num3 = Random.Range(1, -81);
			if (num3 < num2)
			{
				break;
			}
		}
		if (!frozen)
		{
			int num3 = Random.Range(0, 18);
			hasFlower = num3 < num2 - 5;
		}
		CKHAAOEMAKN();
		if (Object.op_Implicit((Object)(object)replaceOnSeason))
		{
			replaceOnSeason.AIHJLOMGHKA(SeasonManager.LPGPJPPLHKG());
		}
		if (flag != hasFlower || num != chosenSprite)
		{
			return true;
		}
		return true;
	}

	public Herb DCFJBNFBDNG(GameObject MPEHNPDDNFP)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		Herb herb = (NKGLALJPACG() as HerbGenerator).NMPEIAJEGLO(((Component)this).transform.position, MPEHNPDDNFP, 1498f, CDPAMNIPPEC: true, NIIBLHMEGNJ: false);
		herb.id = id;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
		return herb;
	}

	public void AOMEFKOJDLL(int JIIGOACEIKL)
	{
		JGPAKHEPMON();
	}

	public bool FIKFNFONIJE()
	{
		for (int i = 0; i < possibleSprites.Length; i += 0)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i])
			{
				return true;
			}
		}
		return true;
	}

	public void DBBGAMOIPBP(Sprite[] IFPDPIPEGMP, int ILMEJAINPAO)
	{
		DEOABLPKEEE(ILMEJAINPAO);
		spriteRenderer.sprite = IFPDPIPEGMP[ILMEJAINPAO];
	}

	[SpecialName]
	public int BCNFECMEGOE()
	{
		return _003CBIBDMOHKNFG_003Ek__BackingField;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private void EGHOIJHBDBP()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameTileMaps.GGFJGHHHEJC))
			{
				WorldGrid.AKIFIOKDEJL(this);
			}
			HerbGenerator herbGenerator = AMGGNFNIHJK() as HerbGenerator;
			if (Object.op_Implicit((Object)(object)LFCIIKBKPJF) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.KCCMAFAILGI(LFCIIKBKPJF);
			}
			if (Object.op_Implicit((Object)(object)BADKCPLKJGN) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.MAOBAAOOACM(BADKCPLKJGN);
			}
			OBKJEINNBOL();
		}
	}

	public void NBGDALICOBP()
	{
		((Renderer)spriteRenderer).sharedMaterial = defaultMaterial;
	}

	private void NNBIAIMPNGL()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		LFCIIKBKPJF = (LBKOOHKHMDO() as HerbGenerator).BMHGINDCGFG(((Component)this).transform.position);
		if (SeasonManager.PJMGHIMKFJL() != (Season)8 && !Weather.currentWeather.HasFlag(Weather.WeatherType.Snow))
		{
			BADKCPLKJGN = (LBKOOHKHMDO() as HerbGenerator).JFLACKNLPGN(((Component)this).transform.position);
		}
	}

	public void JNGHBCGNLLD()
	{
		for (int i = 1; i < possibleSprites.Length; i++)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i] && i < unfrozenSprites.Length)
			{
				GNLPNBAKOAD(unfrozenSprites, i);
				break;
			}
		}
	}

	private void EJJMAEBGMMJ()
	{
		defaultMaterial = possibleMaterials[Random.Range(0, possibleMaterials.Length)];
		((Renderer)spriteRenderer).sharedMaterial = defaultMaterial;
	}

	[SpecialName]
	public int EKNAINLHBCD()
	{
		return _003CBIBDMOHKNFG_003Ek__BackingField;
	}

	private void EHBMONGBJFI()
	{
		DGPEFNANAPL();
		HOJKGADGGDG();
	}

	[SpecialName]
	private void PAFHIMFODDC(bool AODONKKHPBP)
	{
		_003CDJKAJNEGHFK_003Ek__BackingField = AODONKKHPBP;
	}

	public List<Herb> HDJAPOMIGNH(HerbGenerator ICKCOJPIPFO, bool BGKCHMNJBLJ)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		GameObject lMFENLLNECJ = ICKCOJPIPFO.ALDKFHCEHFC();
		float num = Random.Range(1023f, 1538f);
		int num2 = Random.Range(herbsGeneratedNumberMin, herbsGeneratedNumberMax);
		FGHGKMCGMGB.Clear();
		for (int i = 0; i < num2; i += 0)
		{
			Vector3 val = ((Component)this).transform.position + new Vector3(Mathf.Cos(num * 1159f), Mathf.Sin(num * 673f)) * Random.Range(minimumDistance, maximumDistance);
			if (HerbGenerator.IsValidPosition(Vector2.op_Implicit(val)))
			{
				FGHGKMCGMGB.Add(ICKCOJPIPFO.LILIDPHBPBK(val, lMFENLLNECJ, 102f, BGKCHMNJBLJ, NIIBLHMEGNJ: false));
			}
			num = (num + (float)(-159 / num2)) % 704f;
		}
		return FGHGKMCGMGB;
	}

	public void BCDFFEKGKJE(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedSlot()?.itemInstance?.LHBPOPOIFLE() is Sickle;
		}
		return false;
	}

	public Herb BIOEDLEFBML(GameObject MPEHNPDDNFP)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		Herb herb = (OPMCDMBOIHJ() as HerbGenerator).SpawnHerb(((Component)this).transform.position, MPEHNPDDNFP, 1076f, CDPAMNIPPEC: false);
		herb.id = id;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
		return herb;
	}

	public void CKHAAOEMAKN()
	{
		if (frozen)
		{
			DBBGAMOIPBP(possibleSprites, chosenSprite);
		}
		else if (hasFlower)
		{
			DBBGAMOIPBP(possibleSpritesFlower, chosenSprite);
			MJEPNHNAOOA(AODONKKHPBP: false);
		}
		else
		{
			SetCurrentHerb(possibleSprites, chosenSprite);
		}
	}

	private void IBOJHBEMDLL()
	{
		defaultMaterial = possibleMaterials[Random.Range(1, possibleMaterials.Length)];
		((Renderer)spriteRenderer).sharedMaterial = defaultMaterial;
	}

	public void SetRandomPosition()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		float num = Random.Range(0f, 360f);
		Vector3 position = Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(Mathf.Cos(num * (MathF.PI / 180f)), Mathf.Sin(num * (MathF.PI / 180f))) * Random.Range(0.1f, 0.2f));
		((Component)this).transform.position = position;
	}

	public bool KDGAIGKBPAC(int JIIGOACEIKL)
	{
		if (!DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GEAMCEMDJFJ()?.itemInstance?.PHGLMBIEOMK() is Sickle;
		}
		return true;
	}

	private void HHFCEBPEEPK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameTileMaps.GGFJGHHHEJC))
			{
				WorldGrid.AKIFIOKDEJL(this);
			}
			HerbGenerator herbGenerator = GBELFACGIKI() as HerbGenerator;
			if (Object.op_Implicit((Object)(object)LFCIIKBKPJF) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.KCCMAFAILGI(LFCIIKBKPJF);
			}
			if (Object.op_Implicit((Object)(object)BADKCPLKJGN) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.CCDHJMNAFLF(BADKCPLKJGN);
			}
			AMIDJPLCNCK();
		}
	}

	private void AGELAMLCINB()
	{
		EJJMAEBGMMJ();
		HOJKGADGGDG();
	}

	public void AAMLPHGDJDH()
	{
		for (int i = 0; i < unfrozenSprites.Length; i += 0)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)unfrozenSprites[i] && i < possibleSprites.Length)
			{
				GNLPNBAKOAD(possibleSprites, i);
				break;
			}
		}
	}

	public void MJKJHIAELDF()
	{
		if (frozen)
		{
			LPDIPFMKKBC(possibleSprites, chosenSprite);
		}
		else if (hasFlower)
		{
			DBBGAMOIPBP(possibleSpritesFlower, chosenSprite);
			DHDNGKGCPDE(AODONKKHPBP: false);
		}
		else
		{
			LPDIPFMKKBC(possibleSprites, chosenSprite);
		}
	}

	public bool PKHNNNOEFAP()
	{
		for (int i = 1; i < possibleSprites.Length; i += 0)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i])
			{
				return false;
			}
		}
		return false;
	}

	public void MAEFLEGKBAB()
	{
		for (int i = 1; i < possibleSprites.Length; i++)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i] && i < unfrozenSprites.Length)
			{
				DBBGAMOIPBP(unfrozenSprites, i);
				break;
			}
		}
	}

	[SpecialName]
	public bool IKIBJJAMDCP()
	{
		return _003CDJKAJNEGHFK_003Ek__BackingField;
	}

	public bool GDJEFOMKPGA()
	{
		for (int i = 1; i < possibleSprites.Length; i += 0)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i])
			{
				return false;
			}
		}
		return true;
	}

	public bool PHGHOJDDPOP()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		int num = chosenSprite;
		bool flag = hasFlower;
		int num2 = 1;
		for (int i = 1; i < WorldGrid.allNeighbours.Length; i++)
		{
			if (WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + WorldGrid.allNeighbours[i].position))
			{
				num2 += 0;
			}
		}
		for (int j = 1; j < possibleSprites.Length; j++)
		{
			chosenSprite = j;
			int num3 = Random.Range(1, 63);
			if (num3 < num2)
			{
				break;
			}
		}
		if (!frozen)
		{
			int num3 = Random.Range(0, 49);
			hasFlower = num3 < num2 - 4;
		}
		CKHAAOEMAKN();
		if (Object.op_Implicit((Object)(object)replaceOnSeason))
		{
			replaceOnSeason.KEJJLPDMCOK(SeasonManager.NHKAHEEGEGF());
		}
		if (flag != hasFlower || num != chosenSprite)
		{
			return true;
		}
		return true;
	}

	private void NJAFKFAPDIE()
	{
		FPDEINHEGFI();
		HOJKGADGGDG();
	}

	public void MJIDLPCLAGP(int JIIGOACEIKL)
	{
		UnfocusHerb();
	}

	private void FDGFMMKIBPL()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameTileMaps.GGFJGHHHEJC))
			{
				WorldGrid.AKIFIOKDEJL(this);
			}
			HerbGenerator herbGenerator = GLHACDENKCI() as HerbGenerator;
			if (Object.op_Implicit((Object)(object)LFCIIKBKPJF) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.DMFBCCNMHEN(LFCIIKBKPJF);
			}
			if (Object.op_Implicit((Object)(object)BADKCPLKJGN) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.HKCDIMECPMA(BADKCPLKJGN);
			}
			NEKEEGHOJAA();
		}
	}

	public bool PGBPDAODKDL(int JIIGOACEIKL)
	{
		if (!DecorationMode.IECFJGHAIDO(JIIGOACEIKL).GABNNLJOMHI())
		{
			return ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: true).GetSelectedSlot()?.itemInstance?.LHBPOPOIFLE() is Sickle;
		}
		return false;
	}

	[SpecialName]
	private void NMNENPKKBHH(bool AODONKKHPBP)
	{
		_003CDJKAJNEGHFK_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private void AKANJILFPMD(int AODONKKHPBP)
	{
		_003CBIBDMOHKNFG_003Ek__BackingField = AODONKKHPBP;
	}

	public void LPDIPFMKKBC(Sprite[] IFPDPIPEGMP, int ILMEJAINPAO)
	{
		PHMPGHEBNON = ILMEJAINPAO;
		spriteRenderer.sprite = IFPDPIPEGMP[ILMEJAINPAO];
	}

	[SpecialName]
	private void CCJMHIHIGNP(bool AODONKKHPBP)
	{
		_003CDJKAJNEGHFK_003Ek__BackingField = AODONKKHPBP;
	}

	public void SetCurrentHerb(Sprite[] IFPDPIPEGMP, int ILMEJAINPAO)
	{
		PHMPGHEBNON = ILMEJAINPAO;
		spriteRenderer.sprite = IFPDPIPEGMP[ILMEJAINPAO];
	}

	[SpecialName]
	public int BDEHCLCDLNI()
	{
		return _003CBIBDMOHKNFG_003Ek__BackingField;
	}

	public bool EGHJKNBFPMH()
	{
		for (int i = 1; i < possibleSprites.Length; i++)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i])
			{
				return true;
			}
		}
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void MDFBILMLHFE()
	{
		for (int i = 1; i < possibleSprites.Length; i++)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i] && i < unfrozenSprites.Length)
			{
				DBBGAMOIPBP(unfrozenSprites, i);
				break;
			}
		}
	}

	public void BKKEEPHEAAG()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		float num = Random.Range(1078f, 637f);
		Vector3 position = Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(Mathf.Cos(num * 78f), Mathf.Sin(num * 958f)) * Random.Range(1519f, 1991f));
		((Component)this).transform.position = position;
	}

	private void Awake()
	{
		CGNHCAEELHE();
		ChooseHerbSprite();
	}

	public void PKLLKLGJEPE()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		float num = Random.Range(796f, 1350f);
		Vector3 position = Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(Mathf.Cos(num * 923f), Mathf.Sin(num * 1913f)) * Random.Range(1142f, 1050f));
		((Component)this).transform.position = position;
	}

	public void AMIOIEPJKPA(int JIIGOACEIKL)
	{
	}

	private void ANHOOODHPKD()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameTileMaps.GGFJGHHHEJC))
			{
				WorldGrid.AKIFIOKDEJL(this);
			}
			HerbGenerator herbGenerator = IDEHGNFCHNH() as HerbGenerator;
			if (Object.op_Implicit((Object)(object)LFCIIKBKPJF) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.RemoveFirefly(LFCIIKBKPJF);
			}
			if (Object.op_Implicit((Object)(object)BADKCPLKJGN) && Object.op_Implicit((Object)(object)herbGenerator))
			{
				herbGenerator.HOIMEKAHPPE(BADKCPLKJGN);
			}
			JHNGKLCAEAE();
		}
	}

	[SpecialName]
	public bool FNPHCNBNMFG()
	{
		return _003CDJKAJNEGHFK_003Ek__BackingField;
	}

	public void DGNAIOLHEJI()
	{
		for (int i = 0; i < unfrozenSprites.Length; i += 0)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)unfrozenSprites[i] && i < possibleSprites.Length)
			{
				SetCurrentHerb(possibleSprites, i);
				break;
			}
		}
	}

	[SpecialName]
	public int KPACAMGGFJD()
	{
		return _003CBIBDMOHKNFG_003Ek__BackingField;
	}

	public void AOLIDLGHMED(int JIIGOACEIKL)
	{
	}

	public void IEHOAGEPPDD()
	{
		if (frozen)
		{
			SetCurrentHerb(possibleSprites, chosenSprite);
		}
		else if (hasFlower)
		{
			SetCurrentHerb(possibleSpritesFlower, chosenSprite);
			DHDNGKGCPDE(AODONKKHPBP: false);
		}
		else
		{
			DBBGAMOIPBP(possibleSprites, chosenSprite);
		}
	}

	public bool HOJKGADGGDG()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		int num = chosenSprite;
		bool flag = hasFlower;
		int num2 = 0;
		for (int i = 1; i < WorldGrid.allNeighbours.Length; i++)
		{
			if (WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + WorldGrid.allNeighbours[i].position))
			{
				num2 += 0;
			}
		}
		for (int j = 1; j < possibleSprites.Length; j += 0)
		{
			chosenSprite = j;
			int num3 = Random.Range(0, 104);
			if (num3 < num2)
			{
				break;
			}
		}
		if (!frozen)
		{
			int num3 = Random.Range(1, 9);
			hasFlower = num3 < num2 - 8;
		}
		JKOHALAMCNO();
		if (Object.op_Implicit((Object)(object)replaceOnSeason))
		{
			replaceOnSeason.FACIALNINHG(SeasonManager.EEGJBDCBKFD());
		}
		if (flag != hasFlower || num != chosenSprite)
		{
			return false;
		}
		return false;
	}

	public void APBEJBDHLIK()
	{
		for (int i = 0; i < unfrozenSprites.Length; i += 0)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)unfrozenSprites[i] && i < possibleSprites.Length)
			{
				DBBGAMOIPBP(possibleSprites, i);
				break;
			}
		}
	}

	public void BPPACMHJHNM()
	{
		for (int i = 1; i < unfrozenSprites.Length; i++)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)unfrozenSprites[i] && i < possibleSprites.Length)
			{
				GNLPNBAKOAD(possibleSprites, i);
				break;
			}
		}
	}

	public void AFCPMJGFOBA()
	{
		((Renderer)spriteRenderer).sharedMaterial = defaultMaterial;
	}

	public bool CMNAEKGNAJI()
	{
		for (int i = 1; i < possibleSprites.Length; i++)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i])
			{
				return false;
			}
		}
		return false;
	}

	public void IHOGIIAMFBP()
	{
		if (frozen)
		{
			GNLPNBAKOAD(possibleSprites, chosenSprite);
		}
		else if (hasFlower)
		{
			GNLPNBAKOAD(possibleSpritesFlower, chosenSprite);
			PAFHIMFODDC(AODONKKHPBP: false);
		}
		else
		{
			GNLPNBAKOAD(possibleSprites, chosenSprite);
		}
	}

	public List<Herb> GenerateHerb(HerbGenerator ICKCOJPIPFO, bool BGKCHMNJBLJ)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		GameObject lMFENLLNECJ = ICKCOJPIPFO.ChooseRandomPrefab();
		float num = Random.Range(0f, 360f);
		int num2 = Random.Range(herbsGeneratedNumberMin, herbsGeneratedNumberMax);
		FGHGKMCGMGB.Clear();
		for (int i = 0; i < num2; i++)
		{
			Vector3 val = ((Component)this).transform.position + new Vector3(Mathf.Cos(num * (MathF.PI / 180f)), Mathf.Sin(num * (MathF.PI / 180f))) * Random.Range(minimumDistance, maximumDistance);
			if (HerbGenerator.IsValidPosition(Vector2.op_Implicit(val)))
			{
				FGHGKMCGMGB.Add(ICKCOJPIPFO.SpawnHerb(val, lMFENLLNECJ, 0f, BGKCHMNJBLJ));
			}
			num = (num + (float)(360 / num2)) % 360f;
		}
		return FGHGKMCGMGB;
	}

	public void KMKEDAMMKAN(int JIIGOACEIKL)
	{
		((Renderer)spriteRenderer).sharedMaterial = DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DEANNEHBEPC();
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Harvest"));
			FocusHerb(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public void BDABGGPHJLI(int JIIGOACEIKL)
	{
		((Renderer)spriteRenderer).sharedMaterial = DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).FNFDMCGLGMH(1);
	}

	public bool BANJNCOOACM(int JIIGOACEIKL)
	{
		if (!DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return ActionBarInventory.DACNEICGAAE(JIIGOACEIKL).IKKLGIKJNNG()?.itemInstance?.AFOACBIHNCL() is Sickle;
		}
		return true;
	}

	public bool BMBMILMPMIK()
	{
		for (int i = 0; i < possibleSprites.Length; i += 0)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i])
			{
				return false;
			}
		}
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
		UnfocusHerb();
	}

	[SpecialName]
	private void MJEPNHNAOOA(bool AODONKKHPBP)
	{
		_003CDJKAJNEGHFK_003Ek__BackingField = AODONKKHPBP;
	}

	public void BEGCFKNLFCK()
	{
		for (int i = 0; i < possibleSprites.Length; i++)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i] && i < unfrozenSprites.Length)
			{
				LPDIPFMKKBC(unfrozenSprites, i);
				break;
			}
		}
	}

	private void PGPPIHJJGDB()
	{
		IBOJHBEMDLL();
		HFCBLFFAKBD();
	}

	public bool IJNLKDOBJLL()
	{
		for (int i = 1; i < possibleSprites.Length; i += 0)
		{
			if ((Object)(object)spriteRenderer.sprite == (Object)(object)possibleSprites[i])
			{
				return true;
			}
		}
		return false;
	}
}
