using System.Collections.Generic;
using UnityEngine;

public class NinjaOrdersUI : MonoBehaviour
{
	public static NinjaOrdersUI instance;

	public NinjaOrderBubble[] orderBubble;

	private List<NinjaOrderBubble> KIADFDFLLEM = new List<NinjaOrderBubble>();

	public bool fadeOutSomeIngredients;

	public bool fadeOutAllIngredients;

	private void LFKANGBJLGO()
	{
		instance = this;
	}

	public void CLHBJIFMNDK()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].NEAPIIMOFIL(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public List<int> AssignBubbleToCustomer(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].AssignOrder(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	private void DADPOICMNPI()
	{
		instance = this;
	}

	public void MABDLHFAFBI(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.AKPBPFEHGMC(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void GKCPIIDAMKK()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].ONDNPABHJPN(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	private void EDKFNAPDMCN()
	{
		instance = this;
	}

	public void ICMFIJFIKFE(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.ONDNPABHJPN(NJHMBMGKCPL: true);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void DFPKMGCPKCC()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].GBHFNIJPJDJ(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	private void IBMDFNKKPJF()
	{
		instance = this;
	}

	public void CJDCKGOJHBN()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].GBHFNIJPJDJ(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	public void IKOAKLLBNPD()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].ONDNPABHJPN(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	private void KHONOODGLBI()
	{
		instance = this;
	}

	public List<int> EBKKDFJEPEG(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].KOCNPIOBILL(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	private void NEOICNJNKNL()
	{
		instance = this;
	}

	private void PGPPIHJJGDB()
	{
		instance = this;
	}

	public List<int> HNCNFOCGMAO(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].KOCNPIOBILL(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void KELPOHGFFFL(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.LAGPAFBLPPJ(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public List<int> BJHEJLDLEGD(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].BLEOBGBKALC(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	private void AMNCIAEMBFO()
	{
		instance = this;
	}

	public List<int> IANCBMALADG(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].KMEDBEDKHGP(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void MACOGAAKBMB(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.AKPBPFEHGMC(NJHMBMGKCPL: true);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void JKOGILFMIFL(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.LKJJELBLEMM(NJHMBMGKCPL: true);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public List<int> BAAHECGNBBL(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].JGGELPMAKJI(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void LJBCKENHOPM()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].AKPBPFEHGMC(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	public void FHFHHHLABPH(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.FLDPGGLMLCN(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public List<int> GOIGGFDJHDH(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].BLEOBGBKALC(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	private void IGNEGEOPLOP()
	{
		instance = this;
	}

	public void OENBBEHAIGN(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.LIFCOAFJAAL(NJHMBMGKCPL: true);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void AFHICGJDFFG()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].LKJJELBLEMM(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	public List<int> NJFIMHMBOME(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].JIAIINNEJID(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void EBABLOBFAKG(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.MMKGIIKFCKP(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public List<int> BJAAOPNPDMJ(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].DHJEKNNBCIF(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	private void OAEJGGFFCBO()
	{
		instance = this;
	}

	public void GLHEICNFHJI()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].LKJJELBLEMM(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	public void PAAPJCFCKDL()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].ONDNPABHJPN(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public void HIDABKBKCJL(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.SetPending(NJHMBMGKCPL: true);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	private void GNOBDKFFPOL()
	{
		instance = this;
	}

	public List<int> FANBKHADEKM(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].DHJEKNNBCIF(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void GLGEHDFHLIF(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.GBHFNIJPJDJ(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public List<int> FLCBAPEFFBA(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].HIPFMGKJHPG(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public List<int> MOBNONOFODA(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].AOJKMLIMBIB(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	private void Awake()
	{
		instance = this;
	}

	public void FKMEDGBDJEK()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].LKJJELBLEMM(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public void ODDICGHFBHF(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.MMKGIIKFCKP(NJHMBMGKCPL: true);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	private void LHABENPEMPB()
	{
		instance = this;
	}

	public void GEHDDPGBFEO()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].HCGCEBOMNNB(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public void AMOJHBJBNPP()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].KABIIBMMMFK(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	private void MPCFCNCMOAF()
	{
		instance = this;
	}

	public void BIECJPLNICN(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.LIFCOAFJAAL(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void LIODNFOHOCN()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].NEAPIIMOFIL(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	public List<int> LLBKFBMHMCF(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].AssignOrder(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	private void OCJOAHDNDIJ()
	{
		instance = this;
	}

	public List<int> FNFGHBJCKNB(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].DHJEKNNBCIF(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	private void PNLAJCHBHPH()
	{
		instance = this;
	}

	public void FEJDNPEEEED(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.HCGCEBOMNNB(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void RemoveAllBubbles()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].SetPending(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public List<int> CHCJGGMCGGN(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].DHJEKNNBCIF(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	private void EOBODNOCKGA()
	{
		instance = this;
	}

	public void GGBGHCKKDGM()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].ANAHIPOMMPJ(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public List<int> KNNGNJNAMFO(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].CAPHILFFIDC(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void KNIPPLMMPBF()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].HNDEKPEHKFA(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	public List<int> NLFGAFJPLGG(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].IIEIIHKMIPM(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	private void EMJKKALMGLK()
	{
		instance = this;
	}

	public void BEJJOILACEI(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.ONDNPABHJPN(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public List<int> HGNMLHFAOCC(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].HIPFMGKJHPG(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void PDEMPENMPNM()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].NEAPIIMOFIL(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	private void FELJAKBBFJD()
	{
		instance = this;
	}

	public void NPAPOJIKCJA()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].SetPending(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public void CLMMPJDCFFK()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].LKJJELBLEMM(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public void OOKNNFAFNCA(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.ONDNPABHJPN(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void LHHAEGFKOHL(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.ONDNPABHJPN(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void NMNLMDHCDHN(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.LAGPAFBLPPJ(NJHMBMGKCPL: true);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	private void FFHIGDJEFJE()
	{
		instance = this;
	}

	public void MJKDOALLALD(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.AKPBPFEHGMC(NJHMBMGKCPL: true);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void JOGDDBLNJMB(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.FLDPGGLMLCN(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void RemoveBubble(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.SetPending(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public List<int> GFJIMEEFPJC(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].CAPHILFFIDC(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void HNGDGICCFFA()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].LIFCOAFJAAL(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	private void PHJKJHKAABL()
	{
		instance = this;
	}

	public void GOMNALEBCBC()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].FLDPGGLMLCN(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	public List<int> KPPFIHIBEAP(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].JGGELPMAKJI(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void JPEPCHLDPLK()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].SetPending(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	public void GINLJCHPCML()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].LIFCOAFJAAL(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public List<int> IOHGDDJLONO(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].HIPFMGKJHPG(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	private void HMANFAEHJCA()
	{
		instance = this;
	}

	private void JPFDPIAFACG()
	{
		instance = this;
	}

	private void DNKEFFMOCKP()
	{
		instance = this;
	}

	public void CHEKBCFIEBJ()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].ONDNPABHJPN(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	private void BHAFCBHENPL()
	{
		instance = this;
	}

	public List<int> ONBIIDLCJII(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].BLEOBGBKALC(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void FANEFLANOCB()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].HCGCEBOMNNB(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public void OFHGLEFJKJI(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.AKPBPFEHGMC(NJHMBMGKCPL: true);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void CHDGPEJNAHF()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].HNDEKPEHKFA(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	public void FDFAMDNLKHD()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].HNDEKPEHKFA(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public void ADOOAAHCAPC()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].NEAPIIMOFIL(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	public void CKDMNPFKMHC(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.AKPBPFEHGMC(NJHMBMGKCPL: true);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public List<int> DANPMOPBMJM(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].JIAIINNEJID(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void LAHMMJKIDEN(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.LKJJELBLEMM(NJHMBMGKCPL: true);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void PMIPEANDOFL()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].AKPBPFEHGMC(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public void PDOKDPJCJHJ()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].ONDNPABHJPN(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	public void DEAHMBEFADP()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].NEAPIIMOFIL(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	public void AHKGFLFNDLE()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].AKPBPFEHGMC(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public void LIOPCEOHEDO()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].NEAPIIMOFIL(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	public void ICFHCAGCPDM()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].GBHFNIJPJDJ(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public void FMBDKBFDALE(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.GBHFNIJPJDJ(NJHMBMGKCPL: true);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void AJOHPLJIBMN(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.KABIIBMMMFK(NJHMBMGKCPL: true);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	private void AJGKMFOJLBJ()
	{
		instance = this;
	}

	public void EDCNEGNCHBE()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].AKPBPFEHGMC(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	private void PEFKNEPONAG()
	{
		instance = this;
	}

	public void NIMLLKJPPCG()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].LAGPAFBLPPJ(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public void KKKFGEEMDIN()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].LAGPAFBLPPJ(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	public void CCFBLPDLLIB(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.GBHFNIJPJDJ(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void ELMIANNPLKN()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].HNDEKPEHKFA(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	private void GOJKOBEEMNA()
	{
		instance = this;
	}

	public List<int> BIPJCFONINI(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].LNPHDDNJBLP(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void EPJHOIOJCPO(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.LKJJELBLEMM(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public List<int> KPEFKHNGFEJ(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].AssignOrder(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void AMDKHEAILDB()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].FLDPGGLMLCN(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public List<int> FGBJBELHCIL(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].DHJEKNNBCIF(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void OJFOBLCOEKI(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.HCGCEBOMNNB(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public List<int> ODLAHJFHIBE(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].IIEIIHKMIPM(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public List<int> LBHNCKKNNCI(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].LNPHDDNJBLP(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void KOHPKAJEJEG()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].SetPending(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public void FLLCPHDIGJO()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].HCGCEBOMNNB(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	private void BGBFJPJLPMF()
	{
		instance = this;
	}

	public void POEGBPHPOHA(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.LIFCOAFJAAL(NJHMBMGKCPL: true);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	private void KJPECNGCOKK()
	{
		instance = this;
	}

	public void AADHLOIOMCN(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.LIFCOAFJAAL(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	private void GFLFDLIMOLI()
	{
		instance = this;
	}

	private void ONIALAOGMCF()
	{
		instance = this;
	}

	private void GANBBAGDALD()
	{
		instance = this;
	}

	public List<int> PJFOHKFFCCL(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].CCGENALJGDO(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void JLDFKHPNKHN()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].AKPBPFEHGMC(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	public List<int> JINLJJIGACB(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].JIAIINNEJID(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void KMIOEFGCLKH()
	{
		for (int i = 1; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].KABIIBMMMFK(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	private void NNEBAHFHINE()
	{
		instance = this;
	}

	public void CMIOEKHGFKL(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.GBHFNIJPJDJ(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void GKNIIAJBODM()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i += 0)
		{
			KIADFDFLLEM[i].HCGCEBOMNNB(NJHMBMGKCPL: false);
		}
		KIADFDFLLEM.Clear();
	}

	public void EEKMCDMDHFK(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.SetPending(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public List<int> NOJAHOEHEDG(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].IIEIIHKMIPM(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public List<int> PNELAHLDKBK(Item[] PMHCFCEPFMC, NinjaCustomer PJNGMCJIHME, ref NinjaOrderBubble KEILIDDIKMF)
	{
		orderBubble[PJNGMCJIHME.id].KMEDBEDKHGP(PMHCFCEPFMC, PJNGMCJIHME);
		KIADFDFLLEM.Add(orderBubble[PJNGMCJIHME.id]);
		KEILIDDIKMF = orderBubble[PJNGMCJIHME.id];
		return orderBubble[PJNGMCJIHME.id].fadedIngredients;
	}

	public void GPGBPAIJDKC(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.LKJJELBLEMM(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void MLDFJGHLNKC(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.GBHFNIJPJDJ(NJHMBMGKCPL: true);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void FAIHOKIEFPL()
	{
		for (int i = 0; i < KIADFDFLLEM.Count; i++)
		{
			KIADFDFLLEM[i].MMKGIIKFCKP(NJHMBMGKCPL: true);
		}
		KIADFDFLLEM.Clear();
	}

	public void KAJHDBEPGAO(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.AKPBPFEHGMC(NJHMBMGKCPL: false);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}

	public void GLAGCADGGAE(NinjaCustomer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if ((Object)(object)PJNGMCJIHME.bubbleWant != (Object)null && !((Object)(object)PJNGMCJIHME.bubbleWant.customer != (Object)(object)PJNGMCJIHME))
		{
			PJNGMCJIHME.bubbleWant.NEAPIIMOFIL(NJHMBMGKCPL: true);
			KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWant);
		}
	}
}
