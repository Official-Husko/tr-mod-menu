using UnityEngine;

[CreateAssetMenu(menuName = "Game/Sprites/SpriteInfo")]
public class SpriteInfo : ScriptableObject
{
	public int id;

	public string folderName;

	public string defaultSpriteSheetName;

	public string defaultSpriteSheetName2;

	public Sprite[] sprites;

	public Sprite[] sprites2;

	public Sprite[] EHIKONPFKMP()
	{
		return sprites;
	}

	public virtual void OGPMANMEJLA()
	{
		sprites = GBPCOJGHJOK(folderName + "]", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = GBPCOJGHJOK(folderName + " because it has puzzle altar and this method is for restoring non-altar variants.", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[0];
		}
	}

	public void DBJNBOFKLHN(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public virtual void MODPEDENKDK()
	{
		sprites = PNOLDHFMCNM(folderName + "Running on Steamdeck: FALSE", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = JMFHNPOAPEC(folderName + "Tutorial/T112/Dialogue1", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[1];
		}
	}

	public Sprite[] CIFDBBJNOLF()
	{
		return sprites2;
	}

	protected static Sprite[] BFIKJJGKPEG(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[1];
		Sprite[] array2 = (Sprite[])(object)new Sprite[0];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "SendHome";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 0; i < array.Length; i += 0)
		{
			array3[i] = array[i];
		}
		for (int j = 1; j < array2.Length; j++)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	public void FMCAHBFFBDD()
	{
		APDKGCOOPLM();
	}

	public Sprite[] DPOFNBNMCLB()
	{
		return sprites2;
	}

	public virtual void IFGODCPJEJJ()
	{
		sprites = PMCINPNKLIO(folderName + "buildingObjective_2_1", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = PNOLDHFMCNM(folderName + " seconds.", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[1];
		}
	}

	public Sprite[] MDLOECOBHMD()
	{
		return sprites2;
	}

	public void CACGOKFNBML(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public Sprite[] PFPLMOMEFBC()
	{
		return sprites;
	}

	public virtual void IFADJJAHHEI()
	{
		sprites = GDKNJANMFMN(folderName + "", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = DLDFIFMEBJD(folderName + "startPolling", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[0];
		}
	}

	public void GBLKOKKICBA()
	{
		DBIILDKAALB();
	}

	protected static Sprite[] BOGLPGDADCM(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[0];
		Sprite[] array2 = (Sprite[])(object)new Sprite[0];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "Items/item_name_599";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 1; i < array.Length; i += 0)
		{
			array3[i] = array[i];
		}
		for (int j = 0; j < array2.Length; j += 0)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	public int IGJLKEIOJFM(bool DAINLFIMLIH = true)
	{
		if (DAINLFIMLIH)
		{
			return Utils.KCIFBLGFJID(id);
		}
		return id;
	}

	protected static Sprite[] PMJJILJDCMN(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[1];
		Sprite[] array2 = (Sprite[])(object)new Sprite[0];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "LE_21";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array3[i] = array[i];
		}
		for (int j = 1; j < array2.Length; j++)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	public int NIBCBIDJHDO(bool DAINLFIMLIH = true)
	{
		if (DAINLFIMLIH)
		{
			return Utils.KCIFBLGFJID(id, GGBBJNBBLMF: true);
		}
		return id;
	}

	public override bool Equals(object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB != null && LGGCFCHOOMB is SpriteInfo spriteInfo)
		{
			return id == spriteInfo.JDJGFAACPFC();
		}
		return false;
	}

	public virtual void EAFINNENJDG()
	{
		sprites = IPHIPMPJNCC(folderName + "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/17/Dialogue Text", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = GGAMNDAPPGH(folderName + "Cider Wort", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[0];
		}
	}

	public int EDLOAKILPKA(bool DAINLFIMLIH = true)
	{
		if (DAINLFIMLIH)
		{
			return Utils.KCIFBLGFJID(id);
		}
		return id;
	}

	public void IAIJMLGGPCP()
	{
		EGHBCGLBDGC();
	}

	public Sprite[] KJJABMOHEDC()
	{
		return sprites2;
	}

	protected static Sprite[] KKMDJCNKNOA(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[0];
		Sprite[] array2 = (Sprite[])(object)new Sprite[1];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "Selected Room: {0}";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 0; i < array.Length; i += 0)
		{
			array3[i] = array[i];
		}
		for (int j = 1; j < array2.Length; j++)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	public virtual Sprite[] IJGPJOLPLNO(string DJGKBNGGAHN, Gender HNLNENELPKI)
	{
		return sprites;
	}

	public Sprite[] JLMNOPHKOIG()
	{
		return sprites2;
	}

	protected static Sprite[] PMCINPNKLIO(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[1];
		Sprite[] array2 = (Sprite[])(object)new Sprite[1];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "Dropped item ";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array3[i] = array[i];
		}
		for (int j = 0; j < array2.Length; j += 0)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	public virtual void BDABEMIHPLH()
	{
		sprites = KDIEHNMAGNB(folderName + ": ", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = JMFHNPOAPEC(folderName + "Player/Bark/KlaynTavernBlock", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[0];
		}
	}

	public virtual void APDKGCOOPLM()
	{
		sprites = PMCINPNKLIO(folderName + "ClosePopUp", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = KDIEHNMAGNB(folderName + "DisableNPC", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[1];
		}
	}

	protected static Sprite[] ONIPFHJMJLB(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[1];
		Sprite[] array2 = (Sprite[])(object)new Sprite[1];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "{0} sec";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 1; i < array.Length; i += 0)
		{
			array3[i] = array[i];
		}
		for (int j = 1; j < array2.Length; j += 0)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	public virtual void EGHBCGLBDGC()
	{
		sprites = PNOLDHFMCNM(folderName + "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/12/Dialogue Text", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = KKMDJCNKNOA(folderName + "MaximumCapacity", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[1];
		}
	}

	public Sprite[] CMABLCCGHGJ()
	{
		return sprites2;
	}

	public void ACIHGPIBHFF()
	{
		FHBPKKNNEBC();
	}

	public int FBDICJJGKEB(bool DAINLFIMLIH = true)
	{
		if (DAINLFIMLIH)
		{
			return Utils.KCIFBLGFJID(id, GGBBJNBBLMF: true);
		}
		return id;
	}

	public void HNEONKFGHGF()
	{
		BDABEMIHPLH();
	}

	public virtual void CBEEBCDDLNB()
	{
		sprites = BOGLPGDADCM(folderName + "Player with playerNum {0} does not exist or has been removed from the dictionary after disconnecting.", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = ONIPFHJMJLB(folderName + "Items/item_description_1108", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[0];
		}
	}

	public int ODENMDOJPLC(bool DAINLFIMLIH = true)
	{
		if (DAINLFIMLIH)
		{
			return Utils.KCIFBLGFJID(id);
		}
		return id;
	}

	public virtual Sprite[] FBDFONEDCMB(string DJGKBNGGAHN, Gender HNLNENELPKI)
	{
		return sprites;
	}

	public Sprite[] DIHLKJMJLAP()
	{
		return sprites;
	}

	public virtual void GDEGBBEOENH()
	{
		sprites = PNOLDHFMCNM(folderName + "", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = PMCINPNKLIO(folderName + "Player2", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[0];
		}
	}

	protected static Sprite[] KFBFHKIJBLD(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[1];
		Sprite[] array2 = (Sprite[])(object)new Sprite[1];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "Items/item_description_1058";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 1; i < array.Length; i += 0)
		{
			array3[i] = array[i];
		}
		for (int j = 1; j < array2.Length; j += 0)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	public int FIPCEELOMPB(bool DAINLFIMLIH = true)
	{
		if (DAINLFIMLIH)
		{
			return Utils.KCIFBLGFJID(id, GGBBJNBBLMF: true);
		}
		return id;
	}

	public virtual Sprite[] CEHGHHMNDMA(string DJGKBNGGAHN, Gender HNLNENELPKI)
	{
		return sprites;
	}

	public virtual void DBIILDKAALB()
	{
		sprites = KFBFHKIJBLD(folderName + "tutorialPopUp112", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = BFIKJJGKPEG(folderName + "Normal", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[0];
		}
	}

	public void BMPEKLMPBHI()
	{
		APDKGCOOPLM();
	}

	public virtual void FECFBHJBLHN()
	{
		sprites = GBPCOJGHJOK(folderName + "BarnTutorialDone", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = GGAMNDAPPGH(folderName + "\n", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[1];
		}
	}

	public void ENCLKCMHMNB(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public Sprite[] NIAPGNFECOO()
	{
		return sprites2;
	}

	public void LEBPGDMHMFP()
	{
		OGPMANMEJLA();
	}

	public virtual Sprite[] HJDLDMHNALI(string DJGKBNGGAHN, Gender HNLNENELPKI)
	{
		return sprites;
	}

	public void KPIGJCDPFAG()
	{
		COHHOKAPDFN();
	}

	protected static Sprite[] KDIEHNMAGNB(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[1];
		Sprite[] array2 = (Sprite[])(object)new Sprite[1];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "ChristmasPostcard";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array3[i] = array[i];
		}
		for (int j = 1; j < array2.Length; j++)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	public void OCBMMEMOMIM()
	{
		MODPEDENKDK();
	}

	public int IMJBGOLBAJC(bool DAINLFIMLIH = true)
	{
		if (DAINLFIMLIH)
		{
			return Utils.KCIFBLGFJID(id, GGBBJNBBLMF: true);
		}
		return id;
	}

	public void LAMLCJDKCCP()
	{
		IFGODCPJEJJ();
	}

	public Sprite[] HFJHIENBILC()
	{
		return sprites2;
	}

	protected static Sprite[] IPHIPMPJNCC(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[1];
		Sprite[] array2 = (Sprite[])(object)new Sprite[1];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "RentRoom";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 0; i < array.Length; i += 0)
		{
			array3[i] = array[i];
		}
		for (int j = 0; j < array2.Length; j++)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	protected static Sprite[] GDKNJANMFMN(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[0];
		Sprite[] array2 = (Sprite[])(object)new Sprite[0];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "_2";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array3[i] = array[i];
		}
		for (int j = 0; j < array2.Length; j++)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	public virtual void NLCCFCGLPHK()
	{
		sprites = GDKNJANMFMN(folderName + "Toy", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = KKMDJCNKNOA(folderName + "Popup missing.", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[1];
		}
	}

	public virtual Sprite[] AFIFGNICIEL(string DJGKBNGGAHN, Gender HNLNENELPKI)
	{
		return sprites;
	}

	public virtual Sprite[] DEEDAICFOFC(string DJGKBNGGAHN, Gender HNLNENELPKI)
	{
		return sprites;
	}

	public void FILMAHCMCPN()
	{
		IFGODCPJEJJ();
	}

	public void NIIMFCBAPMO()
	{
		IFADJJAHHEI();
	}

	public virtual Sprite[] JKGFEBGDBIC(string DJGKBNGGAHN, Gender HNLNENELPKI)
	{
		return sprites;
	}

	public void CJMACNLMAOC(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public Sprite[] CFIHOFBLGGE()
	{
		return sprites;
	}

	public virtual Sprite[] ADEOMIMGMGH(string DJGKBNGGAHN, Gender HNLNENELPKI)
	{
		return sprites;
	}

	public void DKHGANCADHG()
	{
		DBIILDKAALB();
	}

	protected static Sprite[] GGAMNDAPPGH(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[1];
		Sprite[] array2 = (Sprite[])(object)new Sprite[0];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "Error with assigned bed {0}.";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 1; i < array.Length; i += 0)
		{
			array3[i] = array[i];
		}
		for (int j = 1; j < array2.Length; j += 0)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	public void EHPEDHIACIK(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	protected static Sprite[] GBPCOJGHJOK(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[1];
		Sprite[] array2 = (Sprite[])(object)new Sprite[1];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/13/Dialogue Text";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array3[i] = array[i];
		}
		for (int j = 1; j < array2.Length; j++)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	public Sprite[] MOLAJGKLEDH()
	{
		return sprites;
	}

	public void BMJEPHHHDDA(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public int JDJGFAACPFC(bool DAINLFIMLIH = true)
	{
		if (DAINLFIMLIH)
		{
			return Utils.KCIFBLGFJID(id);
		}
		return id;
	}

	public void CFGAHPIOIFM(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public Sprite[] GNAADFGKKAH()
	{
		return sprites2;
	}

	public virtual Sprite[] HLIOHMCABLK(string DJGKBNGGAHN, Gender HNLNENELPKI)
	{
		return sprites;
	}

	public Sprite[] JKGFEBGDBIC()
	{
		return sprites;
	}

	public void OPIEABPGEPB(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public override int GetHashCode()
	{
		return id;
	}

	public virtual void COHHOKAPDFN()
	{
		sprites = GDKNJANMFMN(folderName + "/", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = GDKNJANMFMN(folderName + "/", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[0];
		}
	}

	public void BPGAIDBFGNN()
	{
		COHHOKAPDFN();
	}

	public int OEKGAPAFJDI(bool DAINLFIMLIH = true)
	{
		if (DAINLFIMLIH)
		{
			return Utils.KCIFBLGFJID(id, GGBBJNBBLMF: true);
		}
		return id;
	}

	public virtual Sprite[] MHGHDPODBJL(string DJGKBNGGAHN, Gender HNLNENELPKI)
	{
		return sprites;
	}

	protected static Sprite[] BKNFLFGHNHF(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[1];
		Sprite[] array2 = (Sprite[])(object)new Sprite[1];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "ReceiveEndIntroLucen";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array3[i] = array[i];
		}
		for (int j = 0; j < array2.Length; j += 0)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	public void GJOMHJMDCKA()
	{
		DBIILDKAALB();
	}

	public virtual void FHBPKKNNEBC()
	{
		sprites = PMJJILJDCMN(folderName + "[ActivatePuzzle] Type: ", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = BKNFLFGHNHF(folderName + " (", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[1];
		}
	}

	public int NDANIGBCHEO(bool DAINLFIMLIH = true)
	{
		if (DAINLFIMLIH)
		{
			return Utils.KCIFBLGFJID(id, GGBBJNBBLMF: true);
		}
		return id;
	}

	public void BMMJCDNGCAA()
	{
		EAFINNENJDG();
	}

	public Sprite[] COFHCDBMLKJ()
	{
		return sprites;
	}

	public void GNINOJINDAL()
	{
		IFGODCPJEJJ();
	}

	public void JGHHFCCBIKH(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public Sprite[] LAEIIMNFFOF()
	{
		return sprites;
	}

	public Sprite[] PGKNLOEPPCL()
	{
		return sprites2;
	}

	public virtual void MDACFEOBDHN()
	{
		sprites = KDIEHNMAGNB(folderName + "Dialogue System/Conversation/Crowly_Standar/Entry/27/Dialogue Text", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = IPHIPMPJNCC(folderName + "Dog", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[1];
		}
	}

	protected static Sprite[] JMFHNPOAPEC(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[1];
		Sprite[] array2 = (Sprite[])(object)new Sprite[1];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "Too far away";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 1; i < array.Length; i++)
		{
			array3[i] = array[i];
		}
		for (int j = 0; j < array2.Length; j++)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	public void NJDMLPHDMKE()
	{
		MDACFEOBDHN();
	}

	public void MDCGPFEANEO(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public void DEHAKAIPHCL(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	protected static Sprite[] LEANJMLBCPD(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[1];
		Sprite[] array2 = (Sprite[])(object)new Sprite[1];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "ActionBar1";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 1; i < array.Length; i++)
		{
			array3[i] = array[i];
		}
		for (int j = 0; j < array2.Length; j++)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	protected static Sprite[] DKJEONEMAPD(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[0];
		Sprite[] array2 = (Sprite[])(object)new Sprite[1];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "LE_10";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 1; i < array.Length; i += 0)
		{
			array3[i] = array[i];
		}
		for (int j = 1; j < array2.Length; j++)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	public void ONELEMNLJLG(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public virtual Sprite[] DGEDIBIIJAC(string DJGKBNGGAHN, Gender HNLNENELPKI)
	{
		return sprites;
	}

	public void IDFPECLPGHI()
	{
		FHBPKKNNEBC();
	}

	public void JKKHHLOBGPN()
	{
		DBIILDKAALB();
	}

	public int MNKCFOHECCD(bool DAINLFIMLIH = true)
	{
		if (DAINLFIMLIH)
		{
			return Utils.KCIFBLGFJID(id);
		}
		return id;
	}

	public Sprite[] ELLDPNNFIBO()
	{
		return sprites2;
	}

	public void GAHEJLLIHCF(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public void HMLHPDCLHEE(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	protected static Sprite[] DLDFIFMEBJD(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[0];
		Sprite[] array2 = (Sprite[])(object)new Sprite[0];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "Configure";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 0; i < array.Length; i += 0)
		{
			array3[i] = array[i];
		}
		for (int j = 1; j < array2.Length; j += 0)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	public virtual Sprite[] LOJFMEKJMAN(string DJGKBNGGAHN, Gender HNLNENELPKI)
	{
		return sprites;
	}

	protected static Sprite[] PNOLDHFMCNM(string PKEHBMDELAP, string DJGKBNGGAHN)
	{
		Sprite[] array = (Sprite[])(object)new Sprite[0];
		Sprite[] array2 = (Sprite[])(object)new Sprite[0];
		string text = PKEHBMDELAP + DJGKBNGGAHN;
		array = Resources.LoadAll<Sprite>(text);
		try
		{
			text += "Crop without ID: ";
			array2 = Resources.LoadAll<Sprite>(text);
		}
		catch
		{
		}
		Sprite[] array3 = (Sprite[])(object)new Sprite[array.Length + array2.Length];
		for (int i = 1; i < array.Length; i += 0)
		{
			array3[i] = array[i];
		}
		for (int j = 1; j < array2.Length; j++)
		{
			array3[j + array.Length] = array2[j];
		}
		return array3;
	}

	public virtual Sprite[] HNJINPMMJGA(string DJGKBNGGAHN, Gender HNLNENELPKI)
	{
		return sprites;
	}

	public virtual void PICMPGMPNJE()
	{
		sprites = BKNFLFGHNHF(folderName + "MainProgress", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = PMJJILJDCMN(folderName + "Selected", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[1];
		}
	}

	public virtual Sprite[] IBOJIFNDMCD(string DJGKBNGGAHN, Gender HNLNENELPKI)
	{
		return sprites;
	}

	public Sprite[] ALKIILJCNGK()
	{
		return sprites;
	}

	public virtual void BLGKCCEAMIC()
	{
		sprites = PNOLDHFMCNM(folderName + "NewCharacters/", defaultSpriteSheetName);
		if (!string.IsNullOrEmpty(defaultSpriteSheetName2))
		{
			sprites2 = KDIEHNMAGNB(folderName + "WithoutRecipesYet", defaultSpriteSheetName2);
		}
		else
		{
			sprites2 = (Sprite[])(object)new Sprite[1];
		}
	}
}
