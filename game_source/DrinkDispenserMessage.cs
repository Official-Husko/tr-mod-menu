using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class DrinkDispenserMessage : PlaceableMsg
{
	[JsonProperty("dC")]
	public byte drinkColorID;

	[JsonProperty("ii")]
	public ItemInstanceWrapperMessage currentItemInstance;

	[JsonProperty("a")]
	public short amount;

	public void CFGKHCJHFIM(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.MNHCGCBNEGE(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[0].OLHGPMJPJFF(0, currentItemInstance.EJOAGMLFPCK());
		MJMNGLHDJFH.slots[0].OBBKDJNLCIO(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().CADCLHFMOID();
		}
	}

	public void NPMHBMEFKCD(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.NIONHJBJDGF(drinkColorID);
		MJMNGLHDJFH.slots[0].ONIFGHNHCPP(0, currentItemInstance.GBGPEBOHPAI(), CDPAMNIPPEC: true);
		MJMNGLHDJFH.slots[1].OCJOJKJPDNO(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().FNOOGNIECKI();
		}
	}

	public void MBEPGFBPKBM(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.BJGIKCKGEJO(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[1].OLHGPMJPJFF(1, currentItemInstance.BMLEJIBNOEG());
		MJMNGLHDJFH.slots[1].KMKAIPMHANN(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().CADCLHFMOID();
		}
	}

	public void DFKDKPLFNFL(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.ADDLJEJIAFP(drinkColorID);
		MJMNGLHDJFH.slots[0].ONIFGHNHCPP(1, currentItemInstance.JLKCLBLPDAC());
		MJMNGLHDJFH.slots[0].JNMNCEPHFOE(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().UpdateSpritesForceWallNextFrame();
		}
	}

	public void LPMMMOPMJKF(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.KMNCGIECPIP(drinkColorID);
		MJMNGLHDJFH.slots[1].OLHGPMJPJFF(0, currentItemInstance.HONPLLLFDIF());
		MJMNGLHDJFH.slots[1].KMKAIPMHANN(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().FNOOGNIECKI();
		}
	}

	public void MLOFABMOBLA(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.NIONHJBJDGF(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[0].ONIFGHNHCPP(1, currentItemInstance.LNELHNKCFBL());
		MJMNGLHDJFH.slots[1].Stack = amount;
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().IHKDNHPPFPG();
		}
	}

	public void PJMEPFPOBIH(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.SetDrinkColorNextFrame(drinkColorID);
		MJMNGLHDJFH.slots[1].ONIFGHNHCPP(0, currentItemInstance.HMDCIDDHFHL());
		MJMNGLHDJFH.slots[1].Stack = amount;
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().IHKDNHPPFPG();
		}
	}

	public void OALIGPKNHEP(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.MNHCGCBNEGE(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[1].OLHGPMJPJFF(0, currentItemInstance.FKCEFMOLIAB(), CDPAMNIPPEC: true);
		MJMNGLHDJFH.slots[0].KMKAIPMHANN(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().UpdateSpritesForceWallNextFrame();
		}
	}

	public void MIIJDMMIIJE(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.KMNCGIECPIP(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[0].ONIFGHNHCPP(0, currentItemInstance.IMEMGKABHOM());
		MJMNGLHDJFH.slots[0].KMKAIPMHANN(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().NEIPIPDLPDE();
		}
	}

	public void PPLLMNFMEOP(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.ADDLJEJIAFP(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[0].ONIFGHNHCPP(1, currentItemInstance.LNELHNKCFBL(), CDPAMNIPPEC: true);
		MJMNGLHDJFH.slots[1].OBBKDJNLCIO(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().IHKDNHPPFPG();
		}
	}

	public void OJDJONEOELH(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.NIONHJBJDGF(drinkColorID);
		MJMNGLHDJFH.slots[0].OLHGPMJPJFF(1, currentItemInstance.PPPIJBBGMCG());
		MJMNGLHDJFH.slots[1].KMKAIPMHANN(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().IHKDNHPPFPG();
		}
	}

	public void JMKOHAGIJAK(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.SetDrinkColorNextFrame(drinkColorID);
		MJMNGLHDJFH.slots[0].ONIFGHNHCPP(1, currentItemInstance.EMFCKLAFIED());
		MJMNGLHDJFH.slots[0].KMKAIPMHANN(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().NEIPIPDLPDE();
		}
	}

	public void CBHDLGIHGGG(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.BJGIKCKGEJO(drinkColorID);
		MJMNGLHDJFH.slots[1].OLHGPMJPJFF(1, currentItemInstance.LEIKEJOAAKF());
		MJMNGLHDJFH.slots[1].OBBKDJNLCIO(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().UpdateSpritesForceWallNextFrame();
		}
	}

	public void JMBBHFHCMFI(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.KMNCGIECPIP(drinkColorID);
		MJMNGLHDJFH.slots[0].ONIFGHNHCPP(1, currentItemInstance.PLAALMCLGMO(), CDPAMNIPPEC: true);
		MJMNGLHDJFH.slots[0].KMKAIPMHANN(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().NEIPIPDLPDE();
		}
	}

	public void GJEJPIANAMG(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.SetDrinkColorNextFrame(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[0].ONIFGHNHCPP(0, currentItemInstance.DMKHGCEDDIJ());
		MJMNGLHDJFH.slots[0].Stack = amount;
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().CADCLHFMOID();
		}
	}

	public void KJLFLBMHNBC(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.ADDLJEJIAFP(drinkColorID);
		MJMNGLHDJFH.slots[0].OLHGPMJPJFF(1, currentItemInstance.IMEMGKABHOM());
		MJMNGLHDJFH.slots[0].JNMNCEPHFOE(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().NEIPIPDLPDE();
		}
	}

	public void KFHMIBMFJHK(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.MNHCGCBNEGE(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[1].ONIFGHNHCPP(0, currentItemInstance.MJNLGNACHEL());
		MJMNGLHDJFH.slots[1].JIANDFCINIP(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().CADCLHFMOID();
		}
	}

	public void GFIAHFPPBDE(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.SetDrinkColorNextFrame(drinkColorID);
		MJMNGLHDJFH.slots[0].OLHGPMJPJFF(0, currentItemInstance.BLGHALFGLBF());
		MJMNGLHDJFH.slots[1].OBBKDJNLCIO(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().UpdateSpritesForceWallNextFrame();
		}
	}

	public void MNJOFPKPMGL(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.NIONHJBJDGF(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[1].ONIFGHNHCPP(1, currentItemInstance.MEBJICJFALH(), CDPAMNIPPEC: true);
		MJMNGLHDJFH.slots[0].KMKAIPMHANN(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().NEIPIPDLPDE();
		}
	}

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineDrinkDispenser onlineDrinkDispenser)
		{
			KONEAIKLOMO(onlineDrinkDispenser.drinkDispenser);
		}
		return onlineObject;
	}

	public void IFCMLCADAJB(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.KMNCGIECPIP(drinkColorID);
		MJMNGLHDJFH.slots[1].ONIFGHNHCPP(0, currentItemInstance.KJAACNGLNOG());
		MJMNGLHDJFH.slots[0].JIANDFCINIP(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().UpdateSpritesForceWallNextFrame();
		}
	}

	public void GPJBOJDDNLN(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.KMNCGIECPIP(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[1].ONIFGHNHCPP(0, currentItemInstance.PPPIJBBGMCG());
		MJMNGLHDJFH.slots[0].KMKAIPMHANN(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().FNOOGNIECKI();
		}
	}

	public void CENFDFDNGPE(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.BJGIKCKGEJO(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[1].ONIFGHNHCPP(1, currentItemInstance.ANMBPDJLNFN());
		MJMNGLHDJFH.slots[0].OCJOJKJPDNO(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().NEIPIPDLPDE();
		}
	}

	public void GPHMODOBPDI(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.SetDrinkColorNextFrame(drinkColorID);
		MJMNGLHDJFH.slots[0].ONIFGHNHCPP(0, currentItemInstance.EJOAGMLFPCK());
		MJMNGLHDJFH.slots[1].KMKAIPMHANN(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().IHKDNHPPFPG();
		}
	}

	public void MOFPPJLIJHH(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.KMNCGIECPIP(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[1].OLHGPMJPJFF(0, currentItemInstance.DLFOMGKFBND(), CDPAMNIPPEC: true);
		MJMNGLHDJFH.slots[1].OCJOJKJPDNO(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().CADCLHFMOID();
		}
	}

	public void FPKEDMGPBMM(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.ADDLJEJIAFP(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[1].ONIFGHNHCPP(1, currentItemInstance.FDADKINGADJ(), CDPAMNIPPEC: true);
		MJMNGLHDJFH.slots[1].OCJOJKJPDNO(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().FNOOGNIECKI();
		}
	}

	public DrinkDispenserMessage(OnlineDrinkDispenser LEGOMLJEKNI)
		: base(LEGOMLJEKNI)
	{
		DrinkDispenser drinkDispenser = LEGOMLJEKNI.drinkDispenser;
		drinkColorID = (byte)drinkDispenser.FJAHJEMPPKH.id;
		currentItemInstance = new ItemInstanceWrapperMessage(drinkDispenser.slots[0].itemInstance);
		amount = (short)drinkDispenser.slots[0].Stack;
	}

	public void EMAGKCBCGFM(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.MNHCGCBNEGE(drinkColorID);
		MJMNGLHDJFH.slots[0].OLHGPMJPJFF(0, currentItemInstance.DMKHGCEDDIJ());
		MJMNGLHDJFH.slots[0].OBBKDJNLCIO(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().IHKDNHPPFPG();
		}
	}

	public void EILMILPAAOB(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.MNHCGCBNEGE(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[0].OLHGPMJPJFF(0, currentItemInstance.NMELFMAKGDK(), CDPAMNIPPEC: true);
		MJMNGLHDJFH.slots[1].OBBKDJNLCIO(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().IHKDNHPPFPG();
		}
	}

	public void GBFMHLKNPID(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.NIONHJBJDGF(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[0].ONIFGHNHCPP(1, currentItemInstance.ODLODIBLGIO());
		MJMNGLHDJFH.slots[0].OBBKDJNLCIO(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().UpdateSpritesForceWallNextFrame();
		}
	}

	public void CEJKGKENMPD(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.KMNCGIECPIP(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[0].OLHGPMJPJFF(0, currentItemInstance.LNELHNKCFBL(), CDPAMNIPPEC: true);
		MJMNGLHDJFH.slots[1].OCJOJKJPDNO(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().FNOOGNIECKI();
		}
	}

	public void HLJJMPICNII(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.NIONHJBJDGF(drinkColorID);
		MJMNGLHDJFH.slots[0].OLHGPMJPJFF(0, currentItemInstance.GBPFODKFMAB());
		MJMNGLHDJFH.slots[1].KMKAIPMHANN(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().CADCLHFMOID();
		}
	}

	public void AJPIKHCHOKM(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.SetDrinkColorNextFrame(drinkColorID);
		MJMNGLHDJFH.slots[1].OLHGPMJPJFF(1, currentItemInstance.FDADKINGADJ(), CDPAMNIPPEC: true);
		MJMNGLHDJFH.slots[1].OBBKDJNLCIO(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().UpdateSpritesForceWallNextFrame();
		}
	}

	public void CEAKLBNGAIK(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.BJGIKCKGEJO(drinkColorID);
		MJMNGLHDJFH.slots[0].ONIFGHNHCPP(0, currentItemInstance.JAEJCIJCCBN());
		MJMNGLHDJFH.slots[1].KMKAIPMHANN(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().UpdateSpritesForceWallNextFrame();
		}
	}

	public void CPBNEAABKNJ(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.ADDLJEJIAFP(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[1].OLHGPMJPJFF(1, currentItemInstance.DMKHGCEDDIJ(), CDPAMNIPPEC: true);
		MJMNGLHDJFH.slots[1].OBBKDJNLCIO(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().UpdateSpritesForceWallNextFrame();
		}
	}

	public void KONEAIKLOMO(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.SetDrinkColorNextFrame(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[0].ONIFGHNHCPP(1, currentItemInstance.ANMBPDJLNFN());
		MJMNGLHDJFH.slots[0].Stack = amount;
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().UpdateSpritesForceWallNextFrame();
		}
	}

	public void JHIJKKJHJMA(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.SetDrinkColorNextFrame(drinkColorID);
		MJMNGLHDJFH.slots[1].ONIFGHNHCPP(1, currentItemInstance.JAEJCIJCCBN(), CDPAMNIPPEC: true);
		MJMNGLHDJFH.slots[1].JNMNCEPHFOE(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().FNOOGNIECKI();
		}
	}

	public void LLAEBEGBKFN(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.NIONHJBJDGF(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[1].OLHGPMJPJFF(1, currentItemInstance.NMELFMAKGDK(), CDPAMNIPPEC: true);
		MJMNGLHDJFH.slots[0].KMKAIPMHANN(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().UpdateSpritesForceWallNextFrame();
		}
	}

	public void FHBBKBIKPMK(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.KMNCGIECPIP(drinkColorID, BGKCHMNJBLJ: false);
		MJMNGLHDJFH.slots[0].OLHGPMJPJFF(0, currentItemInstance.DMKHGCEDDIJ(), CDPAMNIPPEC: true);
		MJMNGLHDJFH.slots[0].JNMNCEPHFOE(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().IHKDNHPPFPG();
		}
	}

	public void NAEONEFKPPH(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.SetDrinkColorNextFrame(drinkColorID);
		MJMNGLHDJFH.slots[1].ONIFGHNHCPP(1, currentItemInstance.JPCIMEAFOBC(), CDPAMNIPPEC: true);
		MJMNGLHDJFH.slots[0].JIANDFCINIP(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().CADCLHFMOID();
		}
	}

	public void HAOBLGFPKJH(DrinkDispenser MJMNGLHDJFH)
	{
		MJMNGLHDJFH.NIONHJBJDGF(drinkColorID);
		MJMNGLHDJFH.slots[1].ONIFGHNHCPP(0, currentItemInstance.NJKMGGPONFC());
		MJMNGLHDJFH.slots[0].OCJOJKJPDNO(amount);
		if (Object.op_Implicit((Object)(object)((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>()))
		{
			((Component)MJMNGLHDJFH).GetComponent<ServiceBarrel>().NEIPIPDLPDE();
		}
	}
}
