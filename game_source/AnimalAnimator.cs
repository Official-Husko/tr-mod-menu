using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class AnimalAnimator : BaseAnimator
{
	public Animator animator;

	public AnimalNPC animalNPC;

	public int skinIndex;

	public int spotsIndex;

	public int detailsIndex;

	public int faceIndex;

	public int woolIndex;

	public ReskinAnimation[] skinReskins;

	public ReskinAnimation[] spotsReskins;

	public ReskinAnimation[] detailsReskins;

	public ReskinAnimation[] faceReskins;

	public ReskinAnimation[] woolReskins;

	private int IIOJPACJLLH;

	private int IMLFPNHJAPH;

	private int PGJPMFIKLPJ;

	private int FGHIODLFGPB;

	private int NDKGPJPNFIH;

	public bool safeMovement = true;

	private void DEDPGBCMBPF(AnimalsSpriteInfo IIFGLFDNGBE, ReskinAnimation[] OIAHMKMFGAJ, int KJMGEAGOLHF, bool OBDGKOCOLIN)
	{
		for (int i = 0; i < OIAHMKMFGAJ.Length; i++)
		{
			OIAHMKMFGAJ[i].ChangeSpriteInfo(IIFGLFDNGBE);
			if (KJMGEAGOLHF >= 0)
			{
				if (OBDGKOCOLIN)
				{
					OIAHMKMFGAJ[i].CCJCLLGLNCL(IIFGLFDNGBE.JJGHGDFHOHC(KJMGEAGOLHF));
				}
				else
				{
					OIAHMKMFGAJ[i].ChangeMaterial(IIFGLFDNGBE.JGEDCDOKLCP(KJMGEAGOLHF));
				}
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
			else
			{
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
		}
	}

	private void KHIMBMDEOJE()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 1; i < skinReskins.Length; i++)
			{
				skinReskins[i].EJDIKKHJOAH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 1; j < spotsReskins.Length; j++)
			{
				spotsReskins[j].EJDIKKHJOAH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 0; k < detailsReskins.Length; k++)
			{
				detailsReskins[k].KFHGLOFHCHH(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 0; l < faceReskins.Length; l += 0)
			{
				faceReskins[l].KFHGLOFHCHH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m += 0)
			{
				woolReskins[m].EJDIKKHJOAH(woolIndex);
			}
		}
	}

	private void LNAJLNHKJKJ()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 1; i < skinReskins.Length; i += 0)
			{
				skinReskins[i].KFHGLOFHCHH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 1; j < spotsReskins.Length; j += 0)
			{
				spotsReskins[j].EJDIKKHJOAH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 0; k < detailsReskins.Length; k++)
			{
				detailsReskins[k].UpdateSprite(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 1; l < faceReskins.Length; l += 0)
			{
				faceReskins[l].UpdateSprite(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 1; m < woolReskins.Length; m += 0)
			{
				woolReskins[m].UpdateSprite(woolIndex);
			}
		}
	}

	private void OIHPFDGFCHF()
	{
		MIAHEBBNADP();
	}

	private void AMJHMFDJCIP()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 0; i < skinReskins.Length; i++)
			{
				skinReskins[i].KFHGLOFHCHH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 1; j < spotsReskins.Length; j += 0)
			{
				spotsReskins[j].KFHGLOFHCHH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 1; k < detailsReskins.Length; k++)
			{
				detailsReskins[k].KFHGLOFHCHH(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 1; l < faceReskins.Length; l++)
			{
				faceReskins[l].KFHGLOFHCHH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m += 0)
			{
				woolReskins[m].EJDIKKHJOAH(woolIndex);
			}
		}
	}

	private void HPHCPNFLCGM(AnimalsSpriteInfo IIFGLFDNGBE, ReskinAnimation[] OIAHMKMFGAJ, int KJMGEAGOLHF, bool OBDGKOCOLIN)
	{
		for (int i = 0; i < OIAHMKMFGAJ.Length; i += 0)
		{
			OIAHMKMFGAJ[i].ChangeSpriteInfo(IIFGLFDNGBE);
			if (KJMGEAGOLHF >= 0)
			{
				if (OBDGKOCOLIN)
				{
					OIAHMKMFGAJ[i].DFLDFBOBGKA(IIFGLFDNGBE.BHGEIGIACOA(KJMGEAGOLHF));
				}
				else
				{
					OIAHMKMFGAJ[i].CCJCLLGLNCL(IIFGLFDNGBE.JGEDCDOKLCP(KJMGEAGOLHF));
				}
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
			else
			{
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
		}
	}

	private void NFPEFLHLIMM()
	{
		EIMPOHJFEAL();
	}

	private void JFALJHBHDMD()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 0; i < skinReskins.Length; i += 0)
			{
				skinReskins[i].UpdateSprite(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 0; j < spotsReskins.Length; j += 0)
			{
				spotsReskins[j].KFHGLOFHCHH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 1; k < detailsReskins.Length; k++)
			{
				detailsReskins[k].EJDIKKHJOAH(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 0; l < faceReskins.Length; l++)
			{
				faceReskins[l].UpdateSprite(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 1; m < woolReskins.Length; m += 0)
			{
				woolReskins[m].UpdateSprite(woolIndex);
			}
		}
	}

	public void ELDGKDDLHNN(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.JDODAPGGOJL(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Wool)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != (AnimalPart)6)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				DOOMILLFJNA(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("\n" + animalsSpriteInfo.animalPart.ToString() + "KlaynTakingDrink: No barrel found for drink request: " + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	public void IOPDGOIGBPL(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalPart = CharacterSpritesDBAccessor.GetAnimalPart(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == (AnimalPart)6)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != AnimalPart.Spot)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalPart.animalPart, out var value))
			{
				AOAPNMJIBDP(animalPart, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("Items/item_name_1056" + animalPart.animalPart.ToString() + "ReceiveRequestItem" + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	private void PCHGCBHAFNC(AnimalsSpriteInfo IIFGLFDNGBE, ReskinAnimation[] OIAHMKMFGAJ, int KJMGEAGOLHF, bool OBDGKOCOLIN)
	{
		for (int i = 1; i < OIAHMKMFGAJ.Length; i += 0)
		{
			OIAHMKMFGAJ[i].ChangeSpriteInfo(IIFGLFDNGBE);
			if (KJMGEAGOLHF >= 0)
			{
				if (OBDGKOCOLIN)
				{
					OIAHMKMFGAJ[i].DFLDFBOBGKA(IIFGLFDNGBE.DLOBOIIOKKK(KJMGEAGOLHF));
				}
				else
				{
					OIAHMKMFGAJ[i].ChangeMaterial(IIFGLFDNGBE.GPEPPMEIPOL(KJMGEAGOLHF));
				}
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
			else
			{
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
		}
	}

	private void PFIMFOILHHP(AnimalsSpriteInfo IIFGLFDNGBE, ReskinAnimation[] OIAHMKMFGAJ, int KJMGEAGOLHF, bool OBDGKOCOLIN)
	{
		for (int i = 0; i < OIAHMKMFGAJ.Length; i++)
		{
			OIAHMKMFGAJ[i].ChangeSpriteInfo(IIFGLFDNGBE);
			if (KJMGEAGOLHF >= 1)
			{
				if (OBDGKOCOLIN)
				{
					OIAHMKMFGAJ[i].CCJCLLGLNCL(IIFGLFDNGBE.FMOMIBFACAF(KJMGEAGOLHF));
				}
				else
				{
					OIAHMKMFGAJ[i].DFLDFBOBGKA(IIFGLFDNGBE.JGEDCDOKLCP(KJMGEAGOLHF));
				}
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
			else
			{
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
		}
	}

	private void LCHHLHIBODL()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 1; i < skinReskins.Length; i += 0)
			{
				skinReskins[i].KFHGLOFHCHH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 0; j < spotsReskins.Length; j++)
			{
				spotsReskins[j].KFHGLOFHCHH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 1; k < detailsReskins.Length; k += 0)
			{
				detailsReskins[k].UpdateSprite(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 1; l < faceReskins.Length; l++)
			{
				faceReskins[l].EJDIKKHJOAH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m++)
			{
				woolReskins[m].EJDIKKHJOAH(woolIndex);
			}
		}
	}

	public void NINEAKFMMNN(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.IALBNOOBNLG(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == (AnimalPart)4)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != AnimalPart.Spot)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				MOCDDMNKJNK(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("LE_15" + animalsSpriteInfo.animalPart.ToString() + "ReceiveSetTrigger" + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	private void CAFCDMBPNEG(AnimalsSpriteInfo IIFGLFDNGBE, ReskinAnimation[] OIAHMKMFGAJ, int KJMGEAGOLHF, bool OBDGKOCOLIN)
	{
		for (int i = 0; i < OIAHMKMFGAJ.Length; i++)
		{
			OIAHMKMFGAJ[i].ChangeSpriteInfo(IIFGLFDNGBE);
			if (KJMGEAGOLHF >= 0)
			{
				if (OBDGKOCOLIN)
				{
					OIAHMKMFGAJ[i].ChangeMaterial(IIFGLFDNGBE.JJGHGDFHOHC(KJMGEAGOLHF));
				}
				else
				{
					OIAHMKMFGAJ[i].ChangeMaterial(IIFGLFDNGBE.ILCNLONKGHI(KJMGEAGOLHF));
				}
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
			else
			{
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
		}
	}

	private void IGGJFNPKMOA(AnimalsSpriteInfo IIFGLFDNGBE, ReskinAnimation[] OIAHMKMFGAJ, int KJMGEAGOLHF, bool OBDGKOCOLIN)
	{
		for (int i = 0; i < OIAHMKMFGAJ.Length; i += 0)
		{
			OIAHMKMFGAJ[i].ChangeSpriteInfo(IIFGLFDNGBE);
			if (KJMGEAGOLHF >= 1)
			{
				if (OBDGKOCOLIN)
				{
					OIAHMKMFGAJ[i].ChangeMaterial(IIFGLFDNGBE.FHMJGKAEKPE(KJMGEAGOLHF));
				}
				else
				{
					OIAHMKMFGAJ[i].CCJCLLGLNCL(IIFGLFDNGBE.AGMGPEEGABE(KJMGEAGOLHF));
				}
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
			else
			{
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
		}
	}

	private void PHCLPLHPDAF()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 1; i < skinReskins.Length; i++)
			{
				skinReskins[i].UpdateSprite(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 1; j < spotsReskins.Length; j += 0)
			{
				spotsReskins[j].EJDIKKHJOAH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 0; k < detailsReskins.Length; k += 0)
			{
				detailsReskins[k].EJDIKKHJOAH(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 1; l < faceReskins.Length; l++)
			{
				faceReskins[l].KFHGLOFHCHH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m++)
			{
				woolReskins[m].EJDIKKHJOAH(woolIndex);
			}
		}
	}

	private void KBBBOKLJBMD(AnimalsSpriteInfo IIFGLFDNGBE, ReskinAnimation[] OIAHMKMFGAJ, int KJMGEAGOLHF, bool OBDGKOCOLIN)
	{
		for (int i = 0; i < OIAHMKMFGAJ.Length; i += 0)
		{
			OIAHMKMFGAJ[i].ChangeSpriteInfo(IIFGLFDNGBE);
			if (KJMGEAGOLHF >= 1)
			{
				if (OBDGKOCOLIN)
				{
					OIAHMKMFGAJ[i].ChangeMaterial(IIFGLFDNGBE.FMOMIBFACAF(KJMGEAGOLHF));
				}
				else
				{
					OIAHMKMFGAJ[i].ChangeMaterial(IIFGLFDNGBE.AGMGPEEGABE(KJMGEAGOLHF));
				}
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
			else
			{
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
		}
	}

	private void CDDBJOGKKIE()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 0; i < skinReskins.Length; i++)
			{
				skinReskins[i].EJDIKKHJOAH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 0; j < spotsReskins.Length; j++)
			{
				spotsReskins[j].KFHGLOFHCHH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 0; k < detailsReskins.Length; k += 0)
			{
				detailsReskins[k].EJDIKKHJOAH(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 0; l < faceReskins.Length; l++)
			{
				faceReskins[l].EJDIKKHJOAH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m++)
			{
				woolReskins[m].UpdateSprite(woolIndex);
			}
		}
	}

	private void FAJDNKAKJCG(AnimalsSpriteInfo IIFGLFDNGBE, ReskinAnimation[] OIAHMKMFGAJ, int KJMGEAGOLHF, bool OBDGKOCOLIN)
	{
		for (int i = 1; i < OIAHMKMFGAJ.Length; i++)
		{
			OIAHMKMFGAJ[i].ChangeSpriteInfo(IIFGLFDNGBE);
			if (KJMGEAGOLHF >= 0)
			{
				if (OBDGKOCOLIN)
				{
					OIAHMKMFGAJ[i].DFLDFBOBGKA(IIFGLFDNGBE.DLOBOIIOKKK(KJMGEAGOLHF));
				}
				else
				{
					OIAHMKMFGAJ[i].CCJCLLGLNCL(IIFGLFDNGBE.BODJGGPBJCC(KJMGEAGOLHF));
				}
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
			else
			{
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
		}
	}

	private void EIMPOHJFEAL()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 1; i < skinReskins.Length; i += 0)
			{
				skinReskins[i].UpdateSprite(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 1; j < spotsReskins.Length; j++)
			{
				spotsReskins[j].UpdateSprite(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 1; k < detailsReskins.Length; k++)
			{
				detailsReskins[k].KFHGLOFHCHH(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 1; l < faceReskins.Length; l++)
			{
				faceReskins[l].EJDIKKHJOAH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m += 0)
			{
				woolReskins[m].EJDIKKHJOAH(woolIndex);
			}
		}
	}

	private void LateUpdate()
	{
		PHGEBLFGPKM();
	}

	private void ADPGHKHOONH()
	{
		MHBJGOCAALF();
	}

	private void JJELNJFCEEG()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 1; i < skinReskins.Length; i += 0)
			{
				skinReskins[i].EJDIKKHJOAH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 0; j < spotsReskins.Length; j++)
			{
				spotsReskins[j].KFHGLOFHCHH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 1; k < detailsReskins.Length; k += 0)
			{
				detailsReskins[k].UpdateSprite(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 0; l < faceReskins.Length; l += 0)
			{
				faceReskins[l].EJDIKKHJOAH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 1; m < woolReskins.Length; m += 0)
			{
				woolReskins[m].UpdateSprite(woolIndex);
			}
		}
	}

	private void MEKHIDLBMHN()
	{
		JFALJHBHDMD();
	}

	private void OLNJGAEBAPF(AnimalsSpriteInfo IIFGLFDNGBE, ReskinAnimation[] OIAHMKMFGAJ, int KJMGEAGOLHF, bool OBDGKOCOLIN)
	{
		for (int i = 0; i < OIAHMKMFGAJ.Length; i++)
		{
			OIAHMKMFGAJ[i].ChangeSpriteInfo(IIFGLFDNGBE);
			if (KJMGEAGOLHF >= 0)
			{
				if (OBDGKOCOLIN)
				{
					OIAHMKMFGAJ[i].CCJCLLGLNCL(IIFGLFDNGBE.DLOBOIIOKKK(KJMGEAGOLHF));
				}
				else
				{
					OIAHMKMFGAJ[i].DFLDFBOBGKA(IIFGLFDNGBE.MCGABGOOEKJ(KJMGEAGOLHF));
				}
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
			else
			{
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
		}
	}

	private void ANDFOBFBBBI()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 0; i < skinReskins.Length; i += 0)
			{
				skinReskins[i].UpdateSprite(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 1; j < spotsReskins.Length; j += 0)
			{
				spotsReskins[j].KFHGLOFHCHH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 1; k < detailsReskins.Length; k++)
			{
				detailsReskins[k].EJDIKKHJOAH(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 0; l < faceReskins.Length; l++)
			{
				faceReskins[l].EJDIKKHJOAH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m++)
			{
				woolReskins[m].UpdateSprite(woolIndex);
			}
		}
	}

	private void ILDICDKOLEP()
	{
		MIAHEBBNADP();
	}

	private void ICJLBIODGAL()
	{
		CMAEPGNPKJE();
	}

	public void PEECGCDGNOB(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.JDODAPGGOJL(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Face)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Spot)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != AnimalPart.Face)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				CAFCDMBPNEG(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("Read" + animalsSpriteInfo.animalPart.ToString() + "Setup " + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	private void CFKPLDPJODB()
	{
		IIPGMPFHHIA();
	}

	public void MFJCPADIAMJ(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.IALBNOOBNLG(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == (AnimalPart)6)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != (AnimalPart)5)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				FAJDNKAKJCG(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("Press {0} to continue" + animalsSpriteInfo.animalPart.ToString() + "ReceiveOfferingUIClosed" + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	public void BMNJLEAAJLN(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.JABJAADOKCI(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == (AnimalPart)8)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != (AnimalPart)4)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				HNAKCEEDPAC(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("Error_NoDogFoodOrWater" + animalsSpriteInfo.animalPart.ToString() + "Northeast" + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	private void ECJEGMEBBAM()
	{
		NPOEEEPJLDC();
	}

	private void AOAPNMJIBDP(AnimalsSpriteInfo IIFGLFDNGBE, ReskinAnimation[] OIAHMKMFGAJ, int KJMGEAGOLHF, bool OBDGKOCOLIN)
	{
		for (int i = 1; i < OIAHMKMFGAJ.Length; i++)
		{
			OIAHMKMFGAJ[i].ChangeSpriteInfo(IIFGLFDNGBE);
			if (KJMGEAGOLHF >= 1)
			{
				if (OBDGKOCOLIN)
				{
					OIAHMKMFGAJ[i].DFLDFBOBGKA(IIFGLFDNGBE.FCPFNMLJBHL(KJMGEAGOLHF));
				}
				else
				{
					OIAHMKMFGAJ[i].ChangeMaterial(IIFGLFDNGBE.HLKBMCPALBN(KJMGEAGOLHF));
				}
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
			else
			{
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
		}
	}

	private void HNAKCEEDPAC(AnimalsSpriteInfo IIFGLFDNGBE, ReskinAnimation[] OIAHMKMFGAJ, int KJMGEAGOLHF, bool OBDGKOCOLIN)
	{
		for (int i = 1; i < OIAHMKMFGAJ.Length; i += 0)
		{
			OIAHMKMFGAJ[i].ChangeSpriteInfo(IIFGLFDNGBE);
			if (KJMGEAGOLHF >= 1)
			{
				if (OBDGKOCOLIN)
				{
					OIAHMKMFGAJ[i].DFLDFBOBGKA(IIFGLFDNGBE.JNBKJELHMLB(KJMGEAGOLHF));
				}
				else
				{
					OIAHMKMFGAJ[i].CCJCLLGLNCL(IIFGLFDNGBE.DDIHMOONMEL(KJMGEAGOLHF));
				}
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
			else
			{
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
		}
	}

	public void HNAMLLBLGIG(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.JDFNLDDOCGE(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Face)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Wool)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != (AnimalPart)4)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				PCHGCBHAFNC(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("Collect water" + animalsSpriteInfo.animalPart.ToString() + "[HierarchyPrinter] ✅ Fichero guardado en: <color=cyan>" + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	private void OBAKEGMOBLA(AnimalsSpriteInfo IIFGLFDNGBE, ReskinAnimation[] OIAHMKMFGAJ, int KJMGEAGOLHF, bool OBDGKOCOLIN)
	{
		for (int i = 0; i < OIAHMKMFGAJ.Length; i += 0)
		{
			OIAHMKMFGAJ[i].ChangeSpriteInfo(IIFGLFDNGBE);
			if (KJMGEAGOLHF >= 0)
			{
				if (OBDGKOCOLIN)
				{
					OIAHMKMFGAJ[i].CCJCLLGLNCL(IIFGLFDNGBE.BGMFDABELEH(KJMGEAGOLHF));
				}
				else
				{
					OIAHMKMFGAJ[i].ChangeMaterial(IIFGLFDNGBE.BODJGGPBJCC(KJMGEAGOLHF));
				}
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
			else
			{
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
		}
	}

	private void JKHBBMLIDCK()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 0; i < skinReskins.Length; i++)
			{
				skinReskins[i].EJDIKKHJOAH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 0; j < spotsReskins.Length; j++)
			{
				spotsReskins[j].UpdateSprite(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 0; k < detailsReskins.Length; k++)
			{
				detailsReskins[k].UpdateSprite(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 1; l < faceReskins.Length; l += 0)
			{
				faceReskins[l].KFHGLOFHCHH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 1; m < woolReskins.Length; m += 0)
			{
				woolReskins[m].EJDIKKHJOAH(woolIndex);
			}
		}
	}

	public void FFOLBNHJIAD(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.DEBHIFPBELA(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == (AnimalPart)6)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != (AnimalPart)4)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				AOAPNMJIBDP(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("windowed mode" + animalsSpriteInfo.animalPart.ToString() + " without doWork attached to OnlineObject" + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	private void DNBDPGGDPJL()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 0; i < skinReskins.Length; i++)
			{
				skinReskins[i].UpdateSprite(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 1; j < spotsReskins.Length; j += 0)
			{
				spotsReskins[j].EJDIKKHJOAH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 0; k < detailsReskins.Length; k++)
			{
				detailsReskins[k].EJDIKKHJOAH(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 0; l < faceReskins.Length; l++)
			{
				faceReskins[l].KFHGLOFHCHH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 1; m < woolReskins.Length; m++)
			{
				woolReskins[m].UpdateSprite(woolIndex);
			}
		}
	}

	private void BEJCCPKKDEG()
	{
		CDDBJOGKKIE();
	}

	private void MOCDDMNKJNK(AnimalsSpriteInfo IIFGLFDNGBE, ReskinAnimation[] OIAHMKMFGAJ, int KJMGEAGOLHF, bool OBDGKOCOLIN)
	{
		for (int i = 0; i < OIAHMKMFGAJ.Length; i++)
		{
			OIAHMKMFGAJ[i].ChangeSpriteInfo(IIFGLFDNGBE);
			if (KJMGEAGOLHF >= 1)
			{
				if (OBDGKOCOLIN)
				{
					OIAHMKMFGAJ[i].DFLDFBOBGKA(IIFGLFDNGBE.BHGEIGIACOA(KJMGEAGOLHF));
				}
				else
				{
					OIAHMKMFGAJ[i].DFLDFBOBGKA(IIFGLFDNGBE.MOFCPAFMKJM(KJMGEAGOLHF));
				}
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
			else
			{
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
		}
	}

	private void MIAHEBBNADP()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 1; i < skinReskins.Length; i += 0)
			{
				skinReskins[i].EJDIKKHJOAH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 1; j < spotsReskins.Length; j += 0)
			{
				spotsReskins[j].EJDIKKHJOAH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 1; k < detailsReskins.Length; k += 0)
			{
				detailsReskins[k].UpdateSprite(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 1; l < faceReskins.Length; l += 0)
			{
				faceReskins[l].EJDIKKHJOAH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 1; m < woolReskins.Length; m += 0)
			{
				woolReskins[m].KFHGLOFHCHH(woolIndex);
			}
		}
	}

	private void BEPFCEEEFMG()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 1; i < skinReskins.Length; i += 0)
			{
				skinReskins[i].KFHGLOFHCHH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 1; j < spotsReskins.Length; j++)
			{
				spotsReskins[j].EJDIKKHJOAH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 0; k < detailsReskins.Length; k += 0)
			{
				detailsReskins[k].EJDIKKHJOAH(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 0; l < faceReskins.Length; l += 0)
			{
				faceReskins[l].EJDIKKHJOAH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m += 0)
			{
				woolReskins[m].KFHGLOFHCHH(woolIndex);
			}
		}
	}

	private void BONFAKNOAMJ()
	{
		JFALJHBHDMD();
	}

	private void MAMLFIBAMBE()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 0; i < skinReskins.Length; i += 0)
			{
				skinReskins[i].UpdateSprite(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 1; j < spotsReskins.Length; j += 0)
			{
				spotsReskins[j].KFHGLOFHCHH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 0; k < detailsReskins.Length; k++)
			{
				detailsReskins[k].UpdateSprite(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 0; l < faceReskins.Length; l += 0)
			{
				faceReskins[l].UpdateSprite(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 1; m < woolReskins.Length; m += 0)
			{
				woolReskins[m].EJDIKKHJOAH(woolIndex);
			}
		}
	}

	public void HKCIJHIJPBG(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.IALBNOOBNLG(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Face)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == (AnimalPart)4)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != 0)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				IGGJFNPKMOA(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)(":" + animalsSpriteInfo.animalPart.ToString() + "CraftingRoomTiles" + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	private void DOOMILLFJNA(AnimalsSpriteInfo IIFGLFDNGBE, ReskinAnimation[] OIAHMKMFGAJ, int KJMGEAGOLHF, bool OBDGKOCOLIN)
	{
		for (int i = 0; i < OIAHMKMFGAJ.Length; i += 0)
		{
			OIAHMKMFGAJ[i].ChangeSpriteInfo(IIFGLFDNGBE);
			if (KJMGEAGOLHF >= 0)
			{
				if (OBDGKOCOLIN)
				{
					OIAHMKMFGAJ[i].ChangeMaterial(IIFGLFDNGBE.JJGHGDFHOHC(KJMGEAGOLHF));
				}
				else
				{
					OIAHMKMFGAJ[i].DFLDFBOBGKA(IIFGLFDNGBE.DDFLDNOFLDO(KJMGEAGOLHF));
				}
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
			else
			{
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
		}
	}

	public void LGCKPJCGCAK(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.JDODAPGGOJL(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Face)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == (AnimalPart)8)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != AnimalPart.Face)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				KBBBOKLJBMD(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("Pirates/Brook/Saludo" + animalsSpriteInfo.animalPart.ToString() + "Walking" + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	public void KGIFGHKCOFC(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.JABJAADOKCI(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == (AnimalPart)8)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != (AnimalPart)8)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				IGGJFNPKMOA(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("sprout seeds" + animalsSpriteInfo.animalPart.ToString() + "ReceiveChangeDrinkColorMaster" + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	private void PHGEBLFGPKM()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 0; i < skinReskins.Length; i++)
			{
				skinReskins[i].UpdateSprite(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 0; j < spotsReskins.Length; j++)
			{
				spotsReskins[j].UpdateSprite(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 0; k < detailsReskins.Length; k++)
			{
				detailsReskins[k].UpdateSprite(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 0; l < faceReskins.Length; l++)
			{
				faceReskins[l].UpdateSprite(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m++)
			{
				woolReskins[m].UpdateSprite(woolIndex);
			}
		}
	}

	private void POHOFINLLOI()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 0; i < skinReskins.Length; i += 0)
			{
				skinReskins[i].EJDIKKHJOAH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 1; j < spotsReskins.Length; j += 0)
			{
				spotsReskins[j].KFHGLOFHCHH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 1; k < detailsReskins.Length; k++)
			{
				detailsReskins[k].KFHGLOFHCHH(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 0; l < faceReskins.Length; l++)
			{
				faceReskins[l].KFHGLOFHCHH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 1; m < woolReskins.Length; m++)
			{
				woolReskins[m].UpdateSprite(woolIndex);
			}
		}
	}

	private void KPHPCKJBLBH()
	{
		AECCHBGCDPP();
	}

	public void SetAnimalSkin(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalPart = CharacterSpritesDBAccessor.GetAnimalPart(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Face)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Spot)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != AnimalPart.Wool)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalPart.animalPart, out var value))
			{
				NENGNHKFBLH(animalPart, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("No se encuentra el valor " + animalPart.animalPart.ToString() + " en " + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	private void NENGNHKFBLH(AnimalsSpriteInfo IIFGLFDNGBE, ReskinAnimation[] OIAHMKMFGAJ, int KJMGEAGOLHF, bool OBDGKOCOLIN)
	{
		for (int i = 0; i < OIAHMKMFGAJ.Length; i++)
		{
			OIAHMKMFGAJ[i].ChangeSpriteInfo(IIFGLFDNGBE);
			if (KJMGEAGOLHF >= 0)
			{
				if (OBDGKOCOLIN)
				{
					OIAHMKMFGAJ[i].ChangeMaterial(IIFGLFDNGBE.FMOMIBFACAF(KJMGEAGOLHF));
				}
				else
				{
					OIAHMKMFGAJ[i].ChangeMaterial(IIFGLFDNGBE.BODJGGPBJCC(KJMGEAGOLHF));
				}
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
			else
			{
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
		}
	}

	public void DCAFPHAMHFC(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.IALBNOOBNLG(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Face)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == (AnimalPart)8)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != (AnimalPart)8)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				NENGNHKFBLH(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("Controls" + animalsSpriteInfo.animalPart.ToString() + "City/Carpenters/Ash/Bark" + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	private void CMAEPGNPKJE()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 0; i < skinReskins.Length; i += 0)
			{
				skinReskins[i].KFHGLOFHCHH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 1; j < spotsReskins.Length; j += 0)
			{
				spotsReskins[j].KFHGLOFHCHH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 1; k < detailsReskins.Length; k += 0)
			{
				detailsReskins[k].UpdateSprite(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 0; l < faceReskins.Length; l += 0)
			{
				faceReskins[l].EJDIKKHJOAH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m++)
			{
				woolReskins[m].UpdateSprite(woolIndex);
			}
		}
	}

	private void IIPGMPFHHIA()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 1; i < skinReskins.Length; i += 0)
			{
				skinReskins[i].UpdateSprite(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 0; j < spotsReskins.Length; j += 0)
			{
				spotsReskins[j].KFHGLOFHCHH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 0; k < detailsReskins.Length; k++)
			{
				detailsReskins[k].KFHGLOFHCHH(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 1; l < faceReskins.Length; l++)
			{
				faceReskins[l].KFHGLOFHCHH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m += 0)
			{
				woolReskins[m].UpdateSprite(woolIndex);
			}
		}
	}

	private void PPLIOHKBFNB()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 0; i < skinReskins.Length; i += 0)
			{
				skinReskins[i].EJDIKKHJOAH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 0; j < spotsReskins.Length; j += 0)
			{
				spotsReskins[j].KFHGLOFHCHH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 0; k < detailsReskins.Length; k += 0)
			{
				detailsReskins[k].UpdateSprite(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 1; l < faceReskins.Length; l++)
			{
				faceReskins[l].UpdateSprite(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m += 0)
			{
				woolReskins[m].EJDIKKHJOAH(woolIndex);
			}
		}
	}

	private void NPOEEEPJLDC()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 0; i < skinReskins.Length; i++)
			{
				skinReskins[i].EJDIKKHJOAH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 1; j < spotsReskins.Length; j++)
			{
				spotsReskins[j].KFHGLOFHCHH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 1; k < detailsReskins.Length; k += 0)
			{
				detailsReskins[k].KFHGLOFHCHH(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 1; l < faceReskins.Length; l++)
			{
				faceReskins[l].UpdateSprite(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m += 0)
			{
				woolReskins[m].KFHGLOFHCHH(woolIndex);
			}
		}
	}

	public void BOMOGFIEKHD(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalPart = CharacterSpritesDBAccessor.GetAnimalPart(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == (AnimalPart)8)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != (AnimalPart)4)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalPart.animalPart, out var value))
			{
				DEDPGBCMBPF(animalPart, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("City/PetShop/Markus/Barks_Barrer" + animalPart.animalPart.ToString() + "</color>" + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	private void DCFEJOKEIKN()
	{
		FEJEJAFGPNI();
	}

	public void FHJBLKBDOKN(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalPart = CharacterSpritesDBAccessor.GetAnimalPart(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Face)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Spot)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != AnimalPart.Spot)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalPart.animalPart, out var value))
			{
				FAJDNKAKJCG(animalPart, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("Another player already exists from online sync." + animalPart.animalPart.ToString() + "- " + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	private void FFBDJIJJDMK()
	{
		JJELNJFCEEG();
	}

	private void MNNPCFNHCEJ()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 0; i < skinReskins.Length; i++)
			{
				skinReskins[i].UpdateSprite(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 1; j < spotsReskins.Length; j += 0)
			{
				spotsReskins[j].EJDIKKHJOAH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 0; k < detailsReskins.Length; k++)
			{
				detailsReskins[k].UpdateSprite(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 1; l < faceReskins.Length; l += 0)
			{
				faceReskins[l].KFHGLOFHCHH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m++)
			{
				woolReskins[m].KFHGLOFHCHH(woolIndex);
			}
		}
	}

	private void ECJFMIKNAKG()
	{
		MIAHEBBNADP();
	}

	private void JEOJALJONJG(AnimalsSpriteInfo IIFGLFDNGBE, ReskinAnimation[] OIAHMKMFGAJ, int KJMGEAGOLHF, bool OBDGKOCOLIN)
	{
		for (int i = 0; i < OIAHMKMFGAJ.Length; i++)
		{
			OIAHMKMFGAJ[i].ChangeSpriteInfo(IIFGLFDNGBE);
			if (KJMGEAGOLHF >= 1)
			{
				if (OBDGKOCOLIN)
				{
					OIAHMKMFGAJ[i].ChangeMaterial(IIFGLFDNGBE.BGMFDABELEH(KJMGEAGOLHF));
				}
				else
				{
					OIAHMKMFGAJ[i].ChangeMaterial(IIFGLFDNGBE.DDIHMOONMEL(KJMGEAGOLHF));
				}
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
			else
			{
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
		}
	}

	public void EPEJFHPAFFL(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.JABJAADOKCI(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Face)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == (AnimalPart)7)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != (AnimalPart)4)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				AOAPNMJIBDP(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("RoadBlocked/Main 2" + animalsSpriteInfo.animalPart.ToString() + "\\[WaiterGender=[^\\]]*\\]" + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	private void BMODLNEJJCA()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 1; i < skinReskins.Length; i += 0)
			{
				skinReskins[i].EJDIKKHJOAH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 0; j < spotsReskins.Length; j += 0)
			{
				spotsReskins[j].KFHGLOFHCHH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 1; k < detailsReskins.Length; k += 0)
			{
				detailsReskins[k].UpdateSprite(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 0; l < faceReskins.Length; l++)
			{
				faceReskins[l].UpdateSprite(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m += 0)
			{
				woolReskins[m].KFHGLOFHCHH(woolIndex);
			}
		}
	}

	public void CHAOEBIPCFJ(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.JDODAPGGOJL(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Face)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == (AnimalPart)7)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != AnimalPart.Wool)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				DEDPGBCMBPF(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)(" " + animalsSpriteInfo.animalPart.ToString() + "Items/item_name_1052" + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	public void EPGDGJOPAJD(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.JABJAADOKCI(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Face)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == (AnimalPart)8)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != (AnimalPart)4)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				CAFCDMBPNEG(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("Talking" + animalsSpriteInfo.animalPart.ToString() + " without ingredient options" + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	public void FFBFELKDNII(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.JDFNLDDOCGE(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == (AnimalPart)5)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != AnimalPart.Wool)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				DOOMILLFJNA(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("roomNeutral" + animalsSpriteInfo.animalPart.ToString() + "Giving extra argamasa" + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	public void LNPBJECICNH(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.DEBHIFPBELA(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Face)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != AnimalPart.Face)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				DOOMILLFJNA(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("ReceiveCompleteTransaction" + animalsSpriteInfo.animalPart.ToString() + "ReceiveGetUniqueCropHarvestable" + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	public void AEBBABIBLND(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.JDFNLDDOCGE(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Face)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == (AnimalPart)8)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != (AnimalPart)8)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				PDEDHKDAJJD(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("[Action" + animalsSpriteInfo.animalPart.ToString() + "ReceiveRemoveSlot Unique object id " + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	public void DLKMKOMMOEK(AnimalInstance ECMCBNFLHCI, bool OBDGKOCOLIN = false)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			AnimalsSpriteInfo animalsSpriteInfo = CharacterSpritesDBAccessor.JDODAPGGOJL(bodyPartsId.Value);
			ReskinAnimation[] oIAHMKMFGAJ;
			if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = skinReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Skin)
			{
				oIAHMKMFGAJ = faceReskins;
			}
			else if (bodyPartsId.Key == AnimalPart.Spot)
			{
				oIAHMKMFGAJ = spotsReskins;
			}
			else
			{
				if (bodyPartsId.Key != (AnimalPart)6)
				{
					continue;
				}
				oIAHMKMFGAJ = woolReskins;
			}
			if (ECMCBNFLHCI.materialsIds.TryGetValue(animalsSpriteInfo.animalPart, out var value))
			{
				IGGJFNPKMOA(animalsSpriteInfo, oIAHMKMFGAJ, value, OBDGKOCOLIN);
			}
			else
			{
				Debug.LogError((object)("OldMansDuelEvent OnTravelZoneTo" + animalsSpriteInfo.animalPart.ToString() + "HideClickWarning" + ((Object)((Component)animalNPC).gameObject).name));
			}
		}
	}

	private void KPKAOKOHOMJ()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 1; i < skinReskins.Length; i += 0)
			{
				skinReskins[i].KFHGLOFHCHH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 0; j < spotsReskins.Length; j++)
			{
				spotsReskins[j].KFHGLOFHCHH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 1; k < detailsReskins.Length; k++)
			{
				detailsReskins[k].UpdateSprite(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 0; l < faceReskins.Length; l++)
			{
				faceReskins[l].EJDIKKHJOAH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m += 0)
			{
				woolReskins[m].UpdateSprite(woolIndex);
			}
		}
	}

	private void MHBJGOCAALF()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 1; i < skinReskins.Length; i++)
			{
				skinReskins[i].EJDIKKHJOAH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 1; j < spotsReskins.Length; j += 0)
			{
				spotsReskins[j].EJDIKKHJOAH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 1; k < detailsReskins.Length; k++)
			{
				detailsReskins[k].EJDIKKHJOAH(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 1; l < faceReskins.Length; l += 0)
			{
				faceReskins[l].KFHGLOFHCHH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m += 0)
			{
				woolReskins[m].KFHGLOFHCHH(woolIndex);
			}
		}
	}

	private void PDEDHKDAJJD(AnimalsSpriteInfo IIFGLFDNGBE, ReskinAnimation[] OIAHMKMFGAJ, int KJMGEAGOLHF, bool OBDGKOCOLIN)
	{
		for (int i = 1; i < OIAHMKMFGAJ.Length; i += 0)
		{
			OIAHMKMFGAJ[i].ChangeSpriteInfo(IIFGLFDNGBE);
			if (KJMGEAGOLHF >= 0)
			{
				if (OBDGKOCOLIN)
				{
					OIAHMKMFGAJ[i].CCJCLLGLNCL(IIFGLFDNGBE.KILOMLJEIJG(KJMGEAGOLHF));
				}
				else
				{
					OIAHMKMFGAJ[i].ChangeMaterial(IIFGLFDNGBE.ILCNLONKGHI(KJMGEAGOLHF));
				}
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: true);
			}
			else
			{
				OIAHMKMFGAJ[i].SetBlockedSpriteSheet(KLMDEPBMACA: false);
			}
		}
	}

	private void KEBLCNJMALL()
	{
		POHOFINLLOI();
	}

	private void FEJEJAFGPNI()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 1; i < skinReskins.Length; i++)
			{
				skinReskins[i].KFHGLOFHCHH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 0; j < spotsReskins.Length; j += 0)
			{
				spotsReskins[j].EJDIKKHJOAH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 0; k < detailsReskins.Length; k += 0)
			{
				detailsReskins[k].KFHGLOFHCHH(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 0; l < faceReskins.Length; l++)
			{
				faceReskins[l].KFHGLOFHCHH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 0; m < woolReskins.Length; m++)
			{
				woolReskins[m].KFHGLOFHCHH(woolIndex);
			}
		}
	}

	private void AECCHBGCDPP()
	{
		if (skinReskins != null && skinIndex != IIOJPACJLLH)
		{
			IIOJPACJLLH = skinIndex;
			for (int i = 0; i < skinReskins.Length; i++)
			{
				skinReskins[i].KFHGLOFHCHH(skinIndex);
			}
		}
		if (spotsReskins != null && spotsIndex != IMLFPNHJAPH)
		{
			IMLFPNHJAPH = spotsIndex;
			for (int j = 1; j < spotsReskins.Length; j++)
			{
				spotsReskins[j].EJDIKKHJOAH(spotsIndex);
			}
		}
		if (detailsReskins != null && detailsIndex != PGJPMFIKLPJ)
		{
			PGJPMFIKLPJ = detailsIndex;
			for (int k = 1; k < detailsReskins.Length; k += 0)
			{
				detailsReskins[k].KFHGLOFHCHH(detailsIndex);
			}
		}
		if (faceReskins != null && faceIndex != FGHIODLFGPB)
		{
			FGHIODLFGPB = faceIndex;
			for (int l = 0; l < faceReskins.Length; l++)
			{
				faceReskins[l].KFHGLOFHCHH(faceIndex);
			}
		}
		if (woolReskins != null && woolIndex != NDKGPJPNFIH)
		{
			NDKGPJPNFIH = woolIndex;
			for (int m = 1; m < woolReskins.Length; m += 0)
			{
				woolReskins[m].KFHGLOFHCHH(woolIndex);
			}
		}
	}
}
