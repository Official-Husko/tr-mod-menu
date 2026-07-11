using UnityEngine;

public class AnimalFeederFood : AnimalFeeder
{
	public AnimalSpace animalSpace;

	public SpritesList style;

	private ItemInstance GLGPAHLDFPN;

	public void MPJABIACFBO(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void EGAMDKMJDME(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.EGFKJOMLHNO(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(0, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void BDBKDFODJAB(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.POOANAHAJAF(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(1, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public void JAJCAIDOBPB(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.GetFoodFeederStyle(MFIDEPNPCHP);
		for (int i = 0; i <= HFEBHJBFNHI; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.POOANAHAJAF(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void LDNIDPEENFL(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(1, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void KJONJCOEKNP(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void JLKGANGEIHD(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void GOAFBDDBNIJ(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.JOIGJCPADFC(MFIDEPNPCHP);
		for (int i = 1; i <= HFEBHJBFNHI; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.OLKOBBGOFJI(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void ODPHHCGPACA(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void FGMMHFOMJFJ(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void IDEKBHBBJNP(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void INBBJEBFJCK(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void DMLBNPIFNOM(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void AOGMNIDFPNN(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.JOIGJCPADFC(MFIDEPNPCHP);
		for (int i = 1; i <= HFEBHJBFNHI; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.OLKOBBGOFJI(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public override void UpdateSprite()
	{
		for (int i = 0; i < improvementsGO.Length; i++)
		{
			((Component)improvementsGO[i]).gameObject.SetActive(i == base.EONJGMONIOM);
		}
		improvementsGO[base.EONJGMONIOM].sprite = style.improvementsSprites[base.EONJGMONIOM];
		MIBCPFGIABD();
	}

	public void PKFMLCBFDGL(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.NPIHNHDFGAK(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(1, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public void MBOGPEFCFBH(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public override void Improve()
	{
		base.Improve();
		container.AddNewSlotToContainer(container.slots.Length, onlineAnimalFeederFood);
		UpdateSprite();
	}

	public void KNHMJIINOKE(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.OLKOBBGOFJI(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(1, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public override void SetStyle(SpritesList ONLCBJNNJMB)
	{
		style = ONLCBJNNJMB;
		UpdateSprite();
	}

	public void PBHLMJBFNLL(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void MMBENJMLEMI(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.FHFGJMDAEEG(MFIDEPNPCHP);
		for (int i = 1; i <= HFEBHJBFNHI; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.EPCMIMIMILH(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void GNFFPIPJECO(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.POOANAHAJAF(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(0, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public override bool WasteUnit(int HFDILBELIKE)
	{
		return LFEGMOHKLEG();
	}

	public void HGFGJBFAEGK(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.OLKOBBGOFJI(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(0, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public void ALJENOCHCBK(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void FFNIGNLFADK(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void HJFOPOOKCHO(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public override bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
			if (!container.slots[0].KPINNBKMOMO())
			{
				GLGPAHLDFPN = container.slots[0].itemInstance;
			}
			else if (container.slots.Length > 1 && !container.slots[1].KPINNBKMOMO())
			{
				GLGPAHLDFPN = container.slots[1].itemInstance;
			}
			else if (container.slots.Length > 2 && !container.slots[2].KPINNBKMOMO())
			{
				GLGPAHLDFPN = container.slots[2].itemInstance;
			}
			else
			{
				GLGPAHLDFPN = null;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SetCrafterAction(new ItemInstanceAmount(GLGPAHLDFPN, 1));
			ButtonsContext.GetPlayer(JIIGOACEIKL).SetFoodFeederBar(container.GetNumberOfItems(), maxAmount[base.EONJGMONIOM]);
			return true;
		}
		return false;
	}

	public void EFJGLNCJFEC(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.JOIGJCPADFC(MFIDEPNPCHP);
		for (int i = 0; i <= HFEBHJBFNHI; i++)
		{
			if (i >= container.slots.Length)
			{
				container.OLKOBBGOFJI(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void AKCKHKACKLF(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.GetFoodFeederStyle(MFIDEPNPCHP);
		for (int i = 0; i <= HFEBHJBFNHI; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.OLKOBBGOFJI(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void PKFPADJMCNE(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.DHHOGOKEPON(MFIDEPNPCHP);
		for (int i = 0; i <= HFEBHJBFNHI; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void MCDOCNJGLJM(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void FOAHPKHPKKH(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.GetFoodFeederStyle(MFIDEPNPCHP);
		for (int i = 1; i <= HFEBHJBFNHI; i++)
		{
			if (i >= container.slots.Length)
			{
				container.NPIHNHDFGAK(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void MKGJFMENBPK(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.POOANAHAJAF(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(0, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public void JOOOFJBKHBG(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.JOIGJCPADFC(MFIDEPNPCHP);
		for (int i = 0; i <= HFEBHJBFNHI; i++)
		{
			if (i >= container.slots.Length)
			{
				container.EGFKJOMLHNO(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void JCPGLOMIHAK(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void FBIGBFIPIIF(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.EGFKJOMLHNO(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(0, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void MPDOEOMOLIK(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.EPCMIMIMILH(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(0, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public void NOGDEDLHHFD(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.JOIGJCPADFC(MFIDEPNPCHP);
		for (int i = 1; i <= HFEBHJBFNHI; i++)
		{
			if (i >= container.slots.Length)
			{
				container.EGFKJOMLHNO(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void GLCAAKKCDGG(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void BGNBDKNCGMC(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.POOANAHAJAF(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(0, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void DALAMDGEMCI(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.FHFGJMDAEEG(MFIDEPNPCHP);
		for (int i = 0; i <= HFEBHJBFNHI; i++)
		{
			if (i >= container.slots.Length)
			{
				container.POOANAHAJAF(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void HIDOGDICODA(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void EPNDJCGGPLE(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.EGFKJOMLHNO(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(0, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public void MNAIOFMKKOH(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.NPIHNHDFGAK(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(0, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void OJHHKAJEMEP(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.EPCMIMIMILH(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(1, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void ENBAJPJEBOK(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.NPIHNHDFGAK(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(0, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void FGBJCKLGNID(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.JOIGJCPADFC(MFIDEPNPCHP);
		for (int i = 1; i <= HFEBHJBFNHI; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void FFCPOKGMBGN(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void CJJNOBADJBH(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void HJAMJAOJCBI(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void IONFOFAPDPC(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(0, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public void PLIHLKFPMCP(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(0, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void FPDGNHIHALC(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.GetFoodFeederStyle(MFIDEPNPCHP);
		for (int i = 0; i <= HFEBHJBFNHI; i++)
		{
			if (i >= container.slots.Length)
			{
				container.POOANAHAJAF(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void NCCBLAJGFAB(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void GJCBJNJICMJ(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(1, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void LLFLNGJGHAB(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.OLKOBBGOFJI(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(0, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public void GOFDDCFDMNJ(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.OLKOBBGOFJI(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(1, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public void KMPMNDCOIKH(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void LPLJHJMLGMG(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void LECNGFNGLAJ(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.JOIGJCPADFC(MFIDEPNPCHP);
		for (int i = 0; i <= HFEBHJBFNHI; i++)
		{
			if (i >= container.slots.Length)
			{
				container.OLKOBBGOFJI(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void MDHNCGGPAEB(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.JOIGJCPADFC(MFIDEPNPCHP);
		for (int i = 1; i <= HFEBHJBFNHI; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.POOANAHAJAF(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void LFCDNBJJHKI(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void NKEFLHPNJPF(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.DHHOGOKEPON(MFIDEPNPCHP);
		for (int i = 1; i <= HFEBHJBFNHI; i++)
		{
			if (i >= container.slots.Length)
			{
				container.EPCMIMIMILH(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public override void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void GJKMNOKFCGI(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void ADJOIMBDFAE(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.JOIGJCPADFC(MFIDEPNPCHP);
		for (int i = 0; i <= HFEBHJBFNHI; i++)
		{
			if (i >= container.slots.Length)
			{
				container.POOANAHAJAF(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void NLMIPJFPOJC(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.JOIGJCPADFC(MFIDEPNPCHP);
		for (int i = 0; i <= HFEBHJBFNHI; i++)
		{
			if (i >= container.slots.Length)
			{
				container.EGFKJOMLHNO(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void NDNFNIBPFJB(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.GetFoodFeederStyle(MFIDEPNPCHP);
		for (int i = 1; i <= HFEBHJBFNHI; i++)
		{
			if (i >= container.slots.Length)
			{
				container.EGFKJOMLHNO(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void ALMHEIOHNKE(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(1, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public void NGDOCOMPEJK(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(1, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public override bool MouseUpOnline(int JIIGOACEIKL)
	{
		DDNFENEHJBL(JIIGOACEIKL);
		return true;
	}

	public void ABLJMLNMPNE(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.NPIHNHDFGAK(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(0, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void IFAGINCEJCP(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.OLKOBBGOFJI(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(1, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void PMFIJDMAOBC(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(1, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void JJABFBMNIFH(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void HJCGDHCPHJA(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.NPIHNHDFGAK(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(1, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void PEGECCFIDIN(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.GetFoodFeederStyle(MFIDEPNPCHP);
		for (int i = 0; i <= HFEBHJBFNHI; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.OLKOBBGOFJI(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void DPJADCGMDPD(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void EEPBEAMGFNA(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void NBHOGLCKLAL(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(0, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void DPKNLIGNFGD(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.DHHOGOKEPON(MFIDEPNPCHP);
		for (int i = 1; i <= HFEBHJBFNHI; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void PDLEMIIMKEF(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void ABDMEBFKFMO(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(0, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public void EJIEHHBMHOF(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.POOANAHAJAF(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(0, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public void FADJFCDHPHF(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void IMJNLGCANEI(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.NPIHNHDFGAK(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(1, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void GFAINOMCMNJ(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.EGFKJOMLHNO(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(1, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public override int GetCurrentAmount()
	{
		return container.GetNumberOfItems();
	}

	public void BAOCMICFHBJ(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void PPDHOBNBANA(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void NHCGLJGIOMP(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.OLKOBBGOFJI(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(0, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void FIEAOAOIFOO(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.DHHOGOKEPON(MFIDEPNPCHP);
		for (int i = 0; i <= HFEBHJBFNHI; i++)
		{
			if (i >= container.slots.Length)
			{
				container.EGFKJOMLHNO(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void NLGKNCMPLPC(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.POOANAHAJAF(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(1, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void FGGNKGNHEDI(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(0, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void IGPOJDGDBKF(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.GetFoodFeederStyle(MFIDEPNPCHP);
		for (int i = 1; i <= HFEBHJBFNHI; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.NPIHNHDFGAK(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void CELJLCBEOKM(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.JOIGJCPADFC(MFIDEPNPCHP);
		for (int i = 0; i <= HFEBHJBFNHI; i++)
		{
			if (i >= container.slots.Length)
			{
				container.EPCMIMIMILH(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void MNAHADKBCFL(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void HMGKDEOCHFF(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.JOIGJCPADFC(MFIDEPNPCHP);
		for (int i = 0; i <= HFEBHJBFNHI; i++)
		{
			if (i >= container.slots.Length)
			{
				container.EPCMIMIMILH(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void LoadAnimalFeeder(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.GetFoodFeederStyle(MFIDEPNPCHP);
		for (int i = 1; i <= HFEBHJBFNHI; i++)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void GEDCEJNJODP(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void GHBAHLMHNBJ(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.GetFoodFeederStyle(MFIDEPNPCHP);
		for (int i = 1; i <= HFEBHJBFNHI; i++)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void HBCICPIJMNK(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(0, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public void HJGPBAHFKEL(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.EGFKJOMLHNO(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(1, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public void OBLBDCIFBJD(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.OLKOBBGOFJI(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(1, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public override void ResetState()
	{
		base.EONJGMONIOM = 0;
		style = ((this != null) ? CharacterSpritesDBAccessor.GetFoodFeederStyles()[0] : CharacterSpritesDBAccessor.GetWaterFeederStyles()[0]);
		container.RemoveItems();
	}

	public void MKKHAJAMNDB(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void LoadFeeder(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void GDFHDFLONFP(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void PIPDFLBLIDK(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.GetFoodFeederStyle(MFIDEPNPCHP);
		for (int i = 0; i <= HFEBHJBFNHI; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.EPCMIMIMILH(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void CGMPPBNFLHK(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void KCOENKKHECM(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.EGFKJOMLHNO(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(0, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public void GKFKKLCGGMB(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void ODOGNKHHNFN(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void GPFIJNFBGPO(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.GetFoodFeederStyle(MFIDEPNPCHP);
		for (int i = 0; i <= HFEBHJBFNHI; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.EGFKJOMLHNO(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void LMCGCCBFBGD(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(1, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void EFCMDBBODBL(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(onlineAnimalFeederFood.uniqueId);
				return false;
			}
			DDNFENEHJBL(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public void DMLAOHFIPHG(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void FLPMMMFFJHD(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.EPCMIMIMILH(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(0, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void SetFeederInfo(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i++)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(1, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void KMMANOACBCL(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void GDFMEOJCJHI(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void IOIMGFAANAA(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.DHHOGOKEPON(MFIDEPNPCHP);
		for (int i = 0; i <= HFEBHJBFNHI; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.NPIHNHDFGAK(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void LJMHMDKGDKE(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.EGFKJOMLHNO(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(1, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public void HCJDHPONCDF(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void FBACGBIMJNK(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.EPCMIMIMILH(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(0, GNKEFIPENCF.container.slots[i].itemInstance, CDPAMNIPPEC: true);
		}
		UpdateSprite();
	}

	public void EKIJHANCKNK(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void AGOAOGMFAPJ(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		UpdateSprite();
	}

	public void LBHCGJPLFFD(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 0; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.EGFKJOMLHNO(i, onlineAnimalFeederFood);
			}
			container.slots[i].OLHGPMJPJFF(1, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}

	public void PEODEOOKPHG(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.JOIGJCPADFC(MFIDEPNPCHP);
		for (int i = 1; i <= HFEBHJBFNHI; i++)
		{
			if (i >= container.slots.Length)
			{
				container.NPIHNHDFGAK(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void AJAFAPKJAPK(int HFEBHJBFNHI, int MFIDEPNPCHP)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.JOIGJCPADFC(MFIDEPNPCHP);
		for (int i = 1; i <= HFEBHJBFNHI; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.NPIHNHDFGAK(i, onlineAnimalFeederFood);
			}
		}
		UpdateSprite();
	}

	public void IDBCPAFPPNK(AnimalFeederFood GNKEFIPENCF)
	{
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		for (int i = 1; i < GNKEFIPENCF.container.slots.Length; i += 0)
		{
			if (i >= container.slots.Length)
			{
				container.AddNewSlotToContainer(i, onlineAnimalFeederFood);
			}
			container.slots[i].ONIFGHNHCPP(0, GNKEFIPENCF.container.slots[i].itemInstance);
		}
		UpdateSprite();
	}
}
