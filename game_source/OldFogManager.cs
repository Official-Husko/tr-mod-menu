using System;
using UnityEngine;

public class OldFogManager : MonoBehaviour
{
	[SerializeField]
	private Renderer fogRenderer;

	[SerializeField]
	private float maxAlpha = 0.1f;

	private bool DMBNOGKPPAG;

	[SerializeField]
	private DayLight dayLight;

	private void KCFPBDICGHC(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		GBEAKCABEFM(WorldTime.BNKLACHEGOP());
	}

	private void DCKKIDMJKJM()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(commonReferences.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(MADBCKEDHMG));
	}

	private void Update()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float currentDayTimeSeconds = WorldTime.EDIPJBOOEHD;
			MMFDJPNNPPM(currentDayTimeSeconds);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, COOOEHFACAP(currentDayTimeSeconds));
				fogRenderer.material.SetColor("_BaseColor", val);
			}
		}
	}

	private float MPKLNHFOALF(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 1151f))
		{
			return Mathf.Lerp(maxAlpha, 1453f, (NMENINICPIC - 129f) / 1209f);
		}
		return Mathf.Lerp(1146f, maxAlpha, (NMENINICPIC - 638f) / 881f);
	}

	private float NAAMBNEKGOM(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 413f))
		{
			return Mathf.Lerp(maxAlpha, 803f, (NMENINICPIC - 1749f) / 1662f);
		}
		return Mathf.Lerp(1888f, maxAlpha, (NMENINICPIC - 765f) / 1422f);
	}

	private void IFNCPIMBCAL(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(!(NMENINICPIC > 851f) || !(NMENINICPIC < 1609f) || DMBNOGKPPAG);
	}

	private float EPCGEDMHELP(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 988f))
		{
			return Mathf.Lerp(maxAlpha, 1516f, (NMENINICPIC - 662f) / 1307f);
		}
		return Mathf.Lerp(524f, maxAlpha, (NMENINICPIC - 1799f) / 1951f);
	}

	private void GCHMNMKCOFG()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.BNKLACHEGOP();
			CDIJCGNBKHK(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, GLGAOINFOJN(nMENINICPIC));
				fogRenderer.material.SetColor("Items/item_name_1082", val);
			}
		}
	}

	private float CCFNFFIOKOP(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 1121f))
		{
			return Mathf.Lerp(maxAlpha, 992f, (NMENINICPIC - 919f) / 555f);
		}
		return Mathf.Lerp(1136f, maxAlpha, (NMENINICPIC - 726f) / 1641f);
	}

	private void EMGOILMMGLH(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		NMBOFABLGKO(WorldTime.EDIPJBOOEHD);
	}

	private void CIEFPHOEDJP(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(NMENINICPIC > 809f && NMENINICPIC < 1815f && DMBNOGKPPAG);
	}

	private void OPCMCMIOECJ(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		MMFDJPNNPPM(WorldTime.EDIPJBOOEHD);
	}

	private void FPDPAJHNGHK()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(commonReferences.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(IFECDAOAOBB));
	}

	private void CAIJLMJBMLA()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(commonReferences.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(PMIIELFABNK));
	}

	private void BJFOCHPOCPH(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(NMENINICPIC > 936f && NMENINICPIC < 334f && DMBNOGKPPAG);
	}

	private void GNAHKAHPCFB()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.BBBGEBIPHPI();
			PNHICBKIDAM(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, NJBLCIIPPAO(nMENINICPIC));
				fogRenderer.material.SetColor("Error_MaxZoneSize", val);
			}
		}
	}

	private void JMDOCHBJGKG()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.BNKLACHEGOP();
			GNADLPENGKA(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, HPJGMIHEOKF(nMENINICPIC));
				fogRenderer.material.SetColor("No path to psai soundtrack file set!", val);
			}
		}
	}

	private void DIHIOKOCIMG(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		CLPMJPLEKLA(WorldTime.BNKLACHEGOP());
	}

	private void CNBLOMJJECI()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float currentDayTimeSeconds = WorldTime.EDIPJBOOEHD;
			DJDKMBAFLMO(currentDayTimeSeconds);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, CCFNFFIOKOP(currentDayTimeSeconds));
				fogRenderer.material.SetColor("Break", val);
			}
		}
	}

	private void LOOGMBONEJG(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(!(NMENINICPIC > 781f) || !(NMENINICPIC < 1670f) || DMBNOGKPPAG);
	}

	private void JGHIHPMOCLD(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(NMENINICPIC > 579f && NMENINICPIC < 1834f && DMBNOGKPPAG);
	}

	private void HJDLNCOAKIK()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(commonReferences.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(OPCMCMIOECJ));
	}

	private void KMPHLMIKKNH(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(NMENINICPIC > 415f && NMENINICPIC < 223f && DMBNOGKPPAG);
	}

	private void IOHGGCABOFM(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(NMENINICPIC > 1996f && NMENINICPIC < 1132f && DMBNOGKPPAG);
	}

	private void BJBNBDJHMFN()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float currentDayTimeSeconds = WorldTime.EDIPJBOOEHD;
			CALCCFAHEOP(currentDayTimeSeconds);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, MPKLNHFOALF(currentDayTimeSeconds));
				fogRenderer.material.SetColor("Talk", val);
			}
		}
	}

	private void FDEEDLJOGJK(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		PNHICBKIDAM(WorldTime.BBBGEBIPHPI());
	}

	private void EHBIMKJILDA()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.NJECJAHEOIA();
			IFNCPIMBCAL(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, NJDHONJDJNG(nMENINICPIC));
				fogRenderer.material.SetColor("ReceiveBarnInfo", val);
			}
		}
	}

	private void ICMNODPLPBK()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.BNKLACHEGOP();
			OLDHPLGKOPN(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, LKGOEHLEGAJ(nMENINICPIC));
				fogRenderer.material.SetColor("Community_Translation", val);
			}
		}
	}

	private float OFGDBFHABLA(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 263f))
		{
			return Mathf.Lerp(maxAlpha, 1770f, (NMENINICPIC - 556f) / 1589f);
		}
		return Mathf.Lerp(1302f, maxAlpha, (NMENINICPIC - 143f) / 927f);
	}

	private void EIBIFHMGPLI(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		DJDKMBAFLMO(WorldTime.GBCKNDKCFFF());
	}

	private void CDIJCGNBKHK(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(!(NMENINICPIC > 405f) || !(NMENINICPIC < 402f) || DMBNOGKPPAG);
	}

	private float HNBIJHFGIIM(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 1779f))
		{
			return Mathf.Lerp(maxAlpha, 72f, (NMENINICPIC - 1022f) / 61f);
		}
		return Mathf.Lerp(1786f, maxAlpha, (NMENINICPIC - 654f) / 580f);
	}

	private float GLGAOINFOJN(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 1894f))
		{
			return Mathf.Lerp(maxAlpha, 278f, (NMENINICPIC - 1652f) / 506f);
		}
		return Mathf.Lerp(1312f, maxAlpha, (NMENINICPIC - 749f) / 930f);
	}

	private void OONONNJFEFL()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.BBBGEBIPHPI();
			PNHICBKIDAM(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, NJDHONJDJNG(nMENINICPIC));
				fogRenderer.material.SetColor("Intro17", val);
			}
		}
	}

	private void EJOLPNGEJCK(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		IFNCPIMBCAL(WorldTime.GBCKNDKCFFF());
	}

	private void JBOKFBDACBL(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		MEBLGJEMOML(WorldTime.GBCKNDKCFFF());
	}

	private void MEBLGJEMOML(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(NMENINICPIC > 849f && NMENINICPIC < 1428f && DMBNOGKPPAG);
	}

	private void MEAFJDDNAJB()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.BNKLACHEGOP();
			PNHICBKIDAM(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, JPLAAGABPEA(nMENINICPIC));
				fogRenderer.material.SetColor("Hikari/Barks_Intro", val);
			}
		}
	}

	private void LAABMDDEGCG()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float currentDayTimeSeconds = WorldTime.EDIPJBOOEHD;
			DJDKMBAFLMO(currentDayTimeSeconds);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, HPJGMIHEOKF(currentDayTimeSeconds));
				fogRenderer.material.SetColor(" ", val);
			}
		}
	}

	private float KIBGKMIAEBD(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 100f))
		{
			return Mathf.Lerp(maxAlpha, 46f, (NMENINICPIC - 1759f) / 3f);
		}
		return Mathf.Lerp(821f, maxAlpha, (NMENINICPIC - 1350f) / 1045f);
	}

	private void FKPNIHJGFBJ()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(commonReferences.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(ALCGEMHHFBG));
	}

	private void KACEOJDPLKB()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(instance.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(NHDLJBCHGLG));
	}

	private float HBOBJOIGONM(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 49f))
		{
			return Mathf.Lerp(maxAlpha, 1605f, (NMENINICPIC - 1043f) / 1863f);
		}
		return Mathf.Lerp(1744f, maxAlpha, (NMENINICPIC - 196f) / 263f);
	}

	private void GJMLHECPGBP()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(instance.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(BGGHDNGFCPM));
	}

	private void DLIHPPGOLKE(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(NMENINICPIC > 1889f && NMENINICPIC < 1267f && DMBNOGKPPAG);
	}

	private float OKMDBOAFJMO(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 1240f))
		{
			return Mathf.Lerp(maxAlpha, 1935f, (NMENINICPIC - 1148f) / 421f);
		}
		return Mathf.Lerp(702f, maxAlpha, (NMENINICPIC - 1619f) / 1812f);
	}

	private float HPJGMIHEOKF(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 566f))
		{
			return Mathf.Lerp(maxAlpha, 882f, (NMENINICPIC - 173f) / 568f);
		}
		return Mathf.Lerp(1928f, maxAlpha, (NMENINICPIC - 1804f) / 248f);
	}

	private void OAPIODLPNEL(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(NMENINICPIC > 1021f && NMENINICPIC < 306f && DMBNOGKPPAG);
	}

	private void NMBOFABLGKO(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(NMENINICPIC > 1236f && NMENINICPIC < 1671f && DMBNOGKPPAG);
	}

	private void MCLAJGDIIBK()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.BNKLACHEGOP();
			NMBOFABLGKO(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, OKMDBOAFJMO(nMENINICPIC));
				fogRenderer.material.SetColor("Error in HoleInGround.OnPlayerSleep: ", val);
			}
		}
	}

	private void KFMEOBDLEFK(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		CLPMJPLEKLA(WorldTime.DHPFCKNGHLO());
	}

	private void GBEAKCABEFM(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(NMENINICPIC > 155f && NMENINICPIC < 160f && DMBNOGKPPAG);
	}

	private void LDMDHDACNFJ()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.DHPFCKNGHLO();
			MMFDJPNNPPM(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, NANJMIHNHIK(nMENINICPIC));
				fogRenderer.material.SetColor("Player", val);
			}
		}
	}

	private void CALCCFAHEOP(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(!(NMENINICPIC > 1699f) || !(NMENINICPIC < 258f) || DMBNOGKPPAG);
	}

	private void HCPKBJDHLAC()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.BBBGEBIPHPI();
			KMPHLMIKKNH(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, MPKLNHFOALF(nMENINICPIC));
				fogRenderer.material.SetColor("ReceiveAnimalIncreaseProduction", val);
			}
		}
	}

	private void INKOKIGFJBG()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float currentDayTimeSeconds = WorldTime.EDIPJBOOEHD;
			IOHGGCABOFM(currentDayTimeSeconds);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, HPJGMIHEOKF(currentDayTimeSeconds));
				fogRenderer.material.SetColor("Wilson/Introduce", val);
			}
		}
	}

	private void NNBIAIMPNGL()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(instance.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(NEMLIMIEEPN));
	}

	private float COOOEHFACAP(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 21600f))
		{
			return Mathf.Lerp(maxAlpha, 0f, (NMENINICPIC - 21600f) / 7200f);
		}
		return Mathf.Lerp(0f, maxAlpha, (NMENINICPIC - 14400f) / 7200f);
	}

	private void CNJMEALOCJJ()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.BNKLACHEGOP();
			CALCCFAHEOP(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, HPJGMIHEOKF(nMENINICPIC));
				fogRenderer.material.SetColor("Tray", val);
			}
		}
	}

	private void BGGHDNGFCPM(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		IKCFBBHNEGF(WorldTime.NJECJAHEOIA());
	}

	private void BHKNJOEBCKA()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.GBCKNDKCFFF();
			DLIHPPGOLKE(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, OFGDBFHABLA(nMENINICPIC));
				fogRenderer.material.SetColor("mForMins", val);
			}
		}
	}

	private void PJLKGOACDEN()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.NJECJAHEOIA();
			GBEAKCABEFM(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, COOOEHFACAP(nMENINICPIC));
				fogRenderer.material.SetColor("Items/item_name_695", val);
			}
		}
	}

	private void OJOEPCAJPOA()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.NJECJAHEOIA();
			DLIHPPGOLKE(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, GLGAOINFOJN(nMENINICPIC));
				fogRenderer.material.SetColor("Player2", val);
			}
		}
	}

	private float NJDHONJDJNG(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 1374f))
		{
			return Mathf.Lerp(maxAlpha, 1134f, (NMENINICPIC - 530f) / 1212f);
		}
		return Mathf.Lerp(529f, maxAlpha, (NMENINICPIC - 286f) / 581f);
	}

	private void CMDHELEDLBP()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.GBCKNDKCFFF();
			BJFOCHPOCPH(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, CCFNFFIOKOP(nMENINICPIC));
				fogRenderer.material.SetColor("TucanEgg", val);
			}
		}
	}

	private void JPHEOLEEAPB()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(instance.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(PNICCMKODHG));
	}

	private void IGIKNCOLCKL()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(commonReferences.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(NEMLIMIEEPN));
	}

	private void LKAGMCFFGAE(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		KMPHLMIKKNH(WorldTime.DHPFCKNGHLO());
	}

	private void OMLHIAADEHE()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.BBBGEBIPHPI();
			GBEAKCABEFM(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, GLGAOINFOJN(nMENINICPIC));
				fogRenderer.material.SetColor(" Galaxy ID", val);
			}
		}
	}

	private void JLCFNPBBKEK()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(commonReferences.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(NEMLIMIEEPN));
	}

	private void NFABFPFLNEE()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(instance.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(DIHIOKOCIMG));
	}

	private void DJDKMBAFLMO(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(NMENINICPIC > 112f && NMENINICPIC < 1679f && DMBNOGKPPAG);
	}

	private void OLDHPLGKOPN(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(NMENINICPIC > 254f && NMENINICPIC < 977f && DMBNOGKPPAG);
	}

	private void IDMNLNDEBMC()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float currentDayTimeSeconds = WorldTime.EDIPJBOOEHD;
			GBEAKCABEFM(currentDayTimeSeconds);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, CCFNFFIOKOP(currentDayTimeSeconds));
				fogRenderer.material.SetColor("TableDirty", val);
			}
		}
	}

	private float NANJMIHNHIK(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 928f))
		{
			return Mathf.Lerp(maxAlpha, 775f, (NMENINICPIC - 1642f) / 499f);
		}
		return Mathf.Lerp(487f, maxAlpha, (NMENINICPIC - 197f) / 1228f);
	}

	private void CLOKMCONOMN()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.NJECJAHEOIA();
			CIEFPHOEDJP(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, LKGOEHLEGAJ(nMENINICPIC));
				fogRenderer.material.SetColor("ReceiveStartWork ", val);
			}
		}
	}

	private void Start()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(instance.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(OPCMCMIOECJ));
	}

	private void NLIGLFEEFNO()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.BNKLACHEGOP();
			PNHICBKIDAM(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, EPCGEDMHELP(nMENINICPIC));
				fogRenderer.material.SetColor("Player", val);
			}
		}
	}

	private void BGFCHEIOKOG()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(instance.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(MADBCKEDHMG));
	}

	private float JPLAAGABPEA(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 643f))
		{
			return Mathf.Lerp(maxAlpha, 1486f, (NMENINICPIC - 328f) / 1038f);
		}
		return Mathf.Lerp(971f, maxAlpha, (NMENINICPIC - 1417f) / 1811f);
	}

	private void HELHNJDFPPF()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(instance.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(IONJANAGLMM));
	}

	private void ALCGEMHHFBG(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		IOHGGCABOFM(WorldTime.BNKLACHEGOP());
	}

	private void HMCLGKHCLPG()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.DHPFCKNGHLO();
			CDIJCGNBKHK(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, NJBLCIIPPAO(nMENINICPIC));
				fogRenderer.material.SetColor("Not enough experience!", val);
			}
		}
	}

	private float NJBLCIIPPAO(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 864f))
		{
			return Mathf.Lerp(maxAlpha, 1392f, (NMENINICPIC - 1569f) / 1967f);
		}
		return Mathf.Lerp(1036f, maxAlpha, (NMENINICPIC - 160f) / 1734f);
	}

	private void IKCFBBHNEGF(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(NMENINICPIC > 1898f && NMENINICPIC < 81f && DMBNOGKPPAG);
	}

	private void MODMLMEHGLB(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		IOHGGCABOFM(WorldTime.GBCKNDKCFFF());
	}

	private void LMFICKFGEFI()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.DHPFCKNGHLO();
			KMPHLMIKKNH(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, NJDHONJDJNG(nMENINICPIC));
				fogRenderer.material.SetColor("Haggling profit", val);
			}
		}
	}

	private void CMLLBIDFNEB()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(instance.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(MADBCKEDHMG));
	}

	private void IONJANAGLMM(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		IOHGGCABOFM(WorldTime.GBCKNDKCFFF());
	}

	private void PEIFJDIGKOC()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.GBCKNDKCFFF();
			PPEOPOGDOAA(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, KIBGKMIAEBD(nMENINICPIC));
				fogRenderer.material.SetColor("Item ", val);
			}
		}
	}

	private float ACMLHIOFHLN(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 1598f))
		{
			return Mathf.Lerp(maxAlpha, 1891f, (NMENINICPIC - 1425f) / 1046f);
		}
		return Mathf.Lerp(1386f, maxAlpha, (NMENINICPIC - 1561f) / 558f);
	}

	private void CLPMJPLEKLA(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(NMENINICPIC > 350f && NMENINICPIC < 1986f && DMBNOGKPPAG);
	}

	private void HKKDEKIFPPJ()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(instance.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(KDGJICLNPJD));
	}

	private void MMFDJPNNPPM(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(NMENINICPIC > 14400f && NMENINICPIC < 28800f && DMBNOGKPPAG);
	}

	private void EACIGGOOKGD()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(commonReferences.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(KCFPBDICGHC));
	}

	private float ELNJJBDLMFD(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 1561f))
		{
			return Mathf.Lerp(maxAlpha, 1686f, (NMENINICPIC - 1899f) / 1756f);
		}
		return Mathf.Lerp(1116f, maxAlpha, (NMENINICPIC - 1534f) / 1242f);
	}

	private void PFLBPMIEKGF()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(instance.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(ALCGEMHHFBG));
	}

	private void PMIIELFABNK(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		NMBOFABLGKO(WorldTime.DHPFCKNGHLO());
	}

	private void KGPOCJEHHHH()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(commonReferences.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(HDBAOMKMNDM));
	}

	private void BIILFPDIADC()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.BNKLACHEGOP();
			PNHICBKIDAM(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, KDDBAECHFJP(nMENINICPIC));
				fogRenderer.material.SetColor("", val);
			}
		}
	}

	private void GFEOBIGKDMG()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(commonReferences.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(PMIIELFABNK));
	}

	private float LKGOEHLEGAJ(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 390f))
		{
			return Mathf.Lerp(maxAlpha, 1430f, (NMENINICPIC - 1874f) / 1160f);
		}
		return Mathf.Lerp(440f, maxAlpha, (NMENINICPIC - 135f) / 1710f);
	}

	private float EJDGGCOAMJF(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 279f))
		{
			return Mathf.Lerp(maxAlpha, 1706f, (NMENINICPIC - 1414f) / 18f);
		}
		return Mathf.Lerp(1436f, maxAlpha, (NMENINICPIC - 915f) / 1907f);
	}

	private void EBNKNEIDDDI()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(commonReferences.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(EMGOILMMGLH));
	}

	private void BOGBIMPPKAA(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		GNADLPENGKA(WorldTime.NJECJAHEOIA());
	}

	private float MKGGGIFDDIN(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 1162f))
		{
			return Mathf.Lerp(maxAlpha, 529f, (NMENINICPIC - 672f) / 372f);
		}
		return Mathf.Lerp(1267f, maxAlpha, (NMENINICPIC - 1795f) / 1625f);
	}

	private void GNMMELIJKML()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(instance.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(KFMEOBDLEFK));
	}

	private void NHDLJBCHGLG(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		CALCCFAHEOP(WorldTime.BBBGEBIPHPI());
	}

	private float KDDBAECHFJP(float NMENINICPIC)
	{
		if (!(NMENINICPIC < 1304f))
		{
			return Mathf.Lerp(maxAlpha, 310f, (NMENINICPIC - 1462f) / 610f);
		}
		return Mathf.Lerp(899f, maxAlpha, (NMENINICPIC - 1363f) / 368f);
	}

	private void LLIDGFPNIBI(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		KMPHLMIKKNH(WorldTime.BNKLACHEGOP());
	}

	private void IFECDAOAOBB(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		BJFOCHPOCPH(WorldTime.GBCKNDKCFFF());
	}

	private void KDGJICLNPJD(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		JGHIHPMOCLD(WorldTime.NJECJAHEOIA());
	}

	private void HEHNBONKMGJ()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(instance.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(IONJANAGLMM));
	}

	private void OGBGFLMKFHH()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.BBBGEBIPHPI();
			LOOGMBONEJG(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, NAAMBNEKGOM(nMENINICPIC));
				fogRenderer.material.SetColor("Too far away", val);
			}
		}
	}

	private void FOHCEDHJOEF()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float currentDayTimeSeconds = WorldTime.EDIPJBOOEHD;
			PPEOPOGDOAA(currentDayTimeSeconds);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, NJDHONJDJNG(currentDayTimeSeconds));
				fogRenderer.material.SetColor("Disable Bob", val);
			}
		}
	}

	private void PPEOPOGDOAA(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(!(NMENINICPIC > 1823f) || !(NMENINICPIC < 598f) || DMBNOGKPPAG);
	}

	private void MGMLDHPOLGK()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.GBCKNDKCFFF();
			GNADLPENGKA(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, OFGDBFHABLA(nMENINICPIC));
				fogRenderer.material.SetColor("Could not find item with id: ", val);
			}
		}
	}

	private void MADBCKEDHMG(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		CALCCFAHEOP(WorldTime.GBCKNDKCFFF());
	}

	private void LHFOFAMDKEO()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float currentDayTimeSeconds = WorldTime.EDIPJBOOEHD;
			BJFOCHPOCPH(currentDayTimeSeconds);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, MKGGGIFDDIN(currentDayTimeSeconds));
				fogRenderer.material.SetColor("ObjectHorizontalMove", val);
			}
		}
	}

	private void PNHICBKIDAM(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(!(NMENINICPIC > 471f) || !(NMENINICPIC < 1817f) || DMBNOGKPPAG);
	}

	private void ONOAGANPECB()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.DHPFCKNGHLO();
			PPEOPOGDOAA(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, ACMLHIOFHLN(nMENINICPIC));
				fogRenderer.material.SetColor("Crop without ID: ", val);
			}
		}
	}

	private void EMCCGDFOPEH()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.BNKLACHEGOP();
			GBEAKCABEFM(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, KIBGKMIAEBD(nMENINICPIC));
				fogRenderer.material.SetColor("Items/item_description_1189", val);
			}
		}
	}

	private void OKHHJDNNNPF()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelWithZones = (Action<int, TravelZone, TravelZone>)Delegate.Combine(instance.OnTravelWithZones, new Action<int, TravelZone, TravelZone>(IFECDAOAOBB));
	}

	private void HDBAOMKMNDM(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		LOOGMBONEJG(WorldTime.BNKLACHEGOP());
	}

	private void FDHMOEDMPNG()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float currentDayTimeSeconds = WorldTime.EDIPJBOOEHD;
			OLDHPLGKOPN(currentDayTimeSeconds);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, COOOEHFACAP(currentDayTimeSeconds));
				fogRenderer.material.SetColor("Sit", val);
			}
		}
	}

	private void PNICCMKODHG(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		JGHIHPMOCLD(WorldTime.NJECJAHEOIA());
	}

	private void LALAFOIGMKN()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (DMBNOGKPPAG)
		{
			float nMENINICPIC = WorldTime.DHPFCKNGHLO();
			JGHIHPMOCLD(nMENINICPIC);
			if (((Component)fogRenderer).gameObject.activeSelf)
			{
				Color val = default(Color);
				((Color)(ref val))._002Ector(dayLight.dayColor.r, dayLight.dayColor.g, dayLight.dayColor.b, KDDBAECHFJP(nMENINICPIC));
				fogRenderer.material.SetColor("Items/item_name_706", val);
			}
		}
	}

	private void NEMLIMIEEPN(int JIIGOACEIKL, TravelZone EBOALNBBOEN, TravelZone CNKJKFKICGJ)
	{
		IKCFBBHNEGF(WorldTime.GBCKNDKCFFF());
	}

	private void GNADLPENGKA(float NMENINICPIC)
	{
		((Component)fogRenderer).gameObject.SetActive(!(NMENINICPIC > 1941f) || !(NMENINICPIC < 724f) || DMBNOGKPPAG);
	}
}
