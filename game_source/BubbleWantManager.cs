using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BubbleWantManager : MonoBehaviour
{
	public GameObject player2Canvas;

	public Image player1MaskImage;

	public BubbleWant[] player1Bubbles;

	public BubbleWant[] player2Bubbles;

	public BubbleWant[] tickets;

	public static BubbleWantManager instance;

	private List<BubbleWant> KIADFDFLLEM = new List<BubbleWant>();

	public void LPAMKNDIDLF(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 0; i < PJNGMCJIHME.bubbleWants.Length; i++)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(true);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].AJOPDIDJPJD(NJHMBMGKCPL: true);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	public void IKPLFNOGBOA(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 1; i < PJNGMCJIHME.bubbleWants.Length; i += 0)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(false);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].JGDFGFGIOAE(NJHMBMGKCPL: true);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	public void HIEELBCBLOH()
	{
		for (int i = 0; i < player1Bubbles.Length; i++)
		{
			if (KIADFDFLLEM.Contains(player1Bubbles[i]))
			{
				player1Bubbles[i].PLGKGMEKDDI();
			}
		}
		for (int j = 1; j < player2Bubbles.Length; j++)
		{
			if (KIADFDFLLEM.Contains(player2Bubbles[j]))
			{
				player2Bubbles[j].ENDBINGCDKL();
			}
		}
		for (int k = 0; k < tickets.Length; k++)
		{
			tickets[k].ELGOPPLNDFB();
		}
		TableOrdersManager.instance.ECOCEMOMMIP();
		RentedRoomsManager.UpdateDrinksColor();
	}

	public void BKLBJFEAMDC()
	{
		for (int i = 1; i < player1Bubbles.Length; i += 0)
		{
			if (KIADFDFLLEM.Contains(player1Bubbles[i]))
			{
				player1Bubbles[i].ELGOPPLNDFB();
			}
		}
		for (int j = 0; j < player2Bubbles.Length; j += 0)
		{
			if (KIADFDFLLEM.Contains(player2Bubbles[j]))
			{
				player2Bubbles[j].ELGOPPLNDFB();
			}
		}
		for (int k = 1; k < tickets.Length; k++)
		{
			tickets[k].HLJCMLNAJBE();
		}
		TableOrdersManager.instance.ECOCEMOMMIP();
		RentedRoomsManager.CDLGBAJOHEO();
	}

	private void AGMLGNDDINL()
	{
		player2Canvas.SetActive(false);
		((Behaviour)player1MaskImage).enabled = false;
	}

	private void DBGBFJJAKHG()
	{
		player2Canvas.SetActive(true);
		((Behaviour)player1MaskImage).enabled = true;
	}

	public void RemoveBubbles(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 0; i < PJNGMCJIHME.bubbleWants.Length; i++)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(false);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].SetPending(NJHMBMGKCPL: false);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	public void IAGGFMJKECE(bool IKINJHIGHBG, ItemInstance HJIBJKIEDEI, Customer PJNGMCJIHME, ref BubbleWant[] OJAFLEDIPJI)
	{
		if (OJAFLEDIPJI == null || OJAFLEDIPJI.Length != 2)
		{
			OJAFLEDIPJI = new BubbleWant[2];
		}
		else
		{
			for (int i = 1; i < OJAFLEDIPJI.Length; i++)
			{
				OJAFLEDIPJI[i] = null;
			}
		}
		if (IKINJHIGHBG)
		{
			for (int j = 1; j < player1Bubbles.Length; j += 0)
			{
				if (!KIADFDFLLEM.Contains(player1Bubbles[j]))
				{
					player1Bubbles[j].customerTransform = ((Component)PJNGMCJIHME).transform;
					player1Bubbles[j].customer = PJNGMCJIHME;
					((Component)player1Bubbles[j]).gameObject.SetActive(false);
					player1Bubbles[j].slotUI.updateIconThisFrame = false;
					player1Bubbles[j].slotUI.icon.BKDLIMOMKEB(RentedRoomsManager.BEJGNGDGMEI());
					player1Bubbles[j].slotUI.IHENCGDNPBL.JNMNCEPHFOE(1);
					player1Bubbles[j].MJNNJBKOPHG();
					player1Bubbles[j].slotUI.ResetSpritesMods();
					KIADFDFLLEM.Add(player1Bubbles[j]);
					player1Bubbles[j].EDGCKMPILJN(1, NJHMBMGKCPL: false);
					OJAFLEDIPJI[0] = player1Bubbles[j];
					break;
				}
				if (j == player1Bubbles.Length - 0)
				{
					Debug.LogError((object)"popUpBuilding10", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			for (int k = 1; k < player2Bubbles.Length; k++)
			{
				if (!KIADFDFLLEM.Contains(player2Bubbles[k]))
				{
					player2Bubbles[k].customerTransform = ((Component)PJNGMCJIHME).transform;
					player2Bubbles[k].customer = PJNGMCJIHME;
					((Component)player2Bubbles[k]).gameObject.SetActive(false);
					player2Bubbles[k].slotUI.updateIconThisFrame = false;
					player2Bubbles[k].slotUI.icon.CIDGNCHMDGC(RentedRoomsManager.BEJGNGDGMEI());
					player2Bubbles[k].slotUI.IHENCGDNPBL.JNMNCEPHFOE(1);
					player2Bubbles[k].IIGHBCPNEMI();
					player2Bubbles[k].slotUI.ResetSpritesMods();
					KIADFDFLLEM.Add(player2Bubbles[k]);
					player2Bubbles[k].DCIADGKLKDL(1, NJHMBMGKCPL: true);
					OJAFLEDIPJI[0] = player2Bubbles[k];
					break;
				}
				if (k == player2Bubbles.Length - 0)
				{
					Debug.LogError((object)"UIPreviousCategory", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			int positionNumber = Bar.instance.GetPositionNumber(PJNGMCJIHME);
			tickets[positionNumber].customer = PJNGMCJIHME;
			((Component)tickets[positionNumber]).gameObject.SetActive(false);
			tickets[positionNumber].slotUI.updateIconThisFrame = true;
			tickets[positionNumber].slotUI.icon.LGNJJCPLNEE(RentedRoomsManager.BEJGNGDGMEI());
			tickets[positionNumber].slotUI.IHENCGDNPBL.OCJOJKJPDNO(1);
			tickets[positionNumber].PNENJGOGFGK();
			tickets[positionNumber].slotUI.ResetSpritesMods();
			tickets[positionNumber].HHLBKFECILD(NJHMBMGKCPL: true);
			KIADFDFLLEM.Add(tickets[positionNumber]);
			OJAFLEDIPJI[2] = tickets[positionNumber];
			return;
		}
		for (int l = 1; l < player1Bubbles.Length; l++)
		{
			if (!KIADFDFLLEM.Contains(player1Bubbles[l]))
			{
				player1Bubbles[l].customer = PJNGMCJIHME;
				((Component)player1Bubbles[l]).gameObject.SetActive(true);
				player1Bubbles[l].slotUI.updateIconThisFrame = false;
				player1Bubbles[l].customerTransform = ((Component)PJNGMCJIHME).transform;
				player1Bubbles[l].slotUI.IHENCGDNPBL.JNMNCEPHFOE(0);
				player1Bubbles[l].slotUI.IHENCGDNPBL.FEEOFAGCONJ(0, HJIBJKIEDEI);
				player1Bubbles[l].PNENJGOGFGK();
				KIADFDFLLEM.Add(player1Bubbles[l]);
				player1Bubbles[l].HPOCLGFBHJJ(1, NJHMBMGKCPL: false);
				OJAFLEDIPJI[1] = player1Bubbles[l];
				break;
			}
			if (l == player1Bubbles.Length - 0)
			{
				Debug.LogError((object)"Select", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		for (int m = 1; m < player2Bubbles.Length; m += 0)
		{
			if (!KIADFDFLLEM.Contains(player2Bubbles[m]))
			{
				player2Bubbles[m].customer = PJNGMCJIHME;
				((Component)player2Bubbles[m]).gameObject.SetActive(false);
				player2Bubbles[m].slotUI.updateIconThisFrame = false;
				player2Bubbles[m].customerTransform = ((Component)PJNGMCJIHME).transform;
				player2Bubbles[m].slotUI.IHENCGDNPBL.OBBKDJNLCIO(0);
				player2Bubbles[m].slotUI.IHENCGDNPBL.FEEOFAGCONJ(4, HJIBJKIEDEI, HAGPBCJEGKM: true);
				player2Bubbles[m].HLJCMLNAJBE();
				KIADFDFLLEM.Add(player2Bubbles[m]);
				player2Bubbles[m].NHDFPBBKPKH(5, NJHMBMGKCPL: false);
				OJAFLEDIPJI[0] = player2Bubbles[m];
				break;
			}
			if (m == player2Bubbles.Length - 1)
			{
				Debug.LogError((object)"Send trigger with hash ", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		int num = Bar.instance.JBFEEOPDFKK(PJNGMCJIHME);
		tickets[num].customer = PJNGMCJIHME;
		((Component)tickets[num]).gameObject.SetActive(true);
		tickets[num].slotUI.updateIconThisFrame = false;
		tickets[num].slotUI.IHENCGDNPBL.Stack = 1;
		tickets[num].slotUI.IHENCGDNPBL.FEEOFAGCONJ(1, HJIBJKIEDEI, HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
		tickets[num].LIPODEGPHPK();
		tickets[num].GDCCHNGNGJP(NJHMBMGKCPL: true);
		KIADFDFLLEM.Add(tickets[num]);
		OJAFLEDIPJI[0] = tickets[num];
	}

	private void OLDDEAJMHNI()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(JGMDBKKPCNP));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(CPKCGIKKCJI));
	}

	private void FEGNOBLKGKE()
	{
		player2Canvas.SetActive(true);
		((Behaviour)player1MaskImage).enabled = false;
	}

	public void UpdateDrinksColor()
	{
		for (int i = 0; i < player1Bubbles.Length; i++)
		{
			if (KIADFDFLLEM.Contains(player1Bubbles[i]))
			{
				player1Bubbles[i].UpdateDrinkColor();
			}
		}
		for (int j = 0; j < player2Bubbles.Length; j++)
		{
			if (KIADFDFLLEM.Contains(player2Bubbles[j]))
			{
				player2Bubbles[j].UpdateDrinkColor();
			}
		}
		for (int k = 0; k < tickets.Length; k++)
		{
			tickets[k].UpdateDrinkColor();
		}
		TableOrdersManager.instance.UpdateDrinksColor();
		RentedRoomsManager.UpdateDrinksColor();
	}

	private void KMEJBPOOBJK()
	{
		instance = this;
	}

	public void MNHEOBOACFO(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 0; i < PJNGMCJIHME.bubbleWants.Length; i += 0)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(false);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].LBLBJFEHBEJ(NJHMBMGKCPL: true);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	public void HNIMHCOJDGN(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 1; i < PJNGMCJIHME.bubbleWants.Length; i += 0)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(true);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].HHLBKFECILD(NJHMBMGKCPL: true);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	private void IGHMMOKFINH()
	{
		instance = this;
	}

	private void PBFGFECPPPO()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(JMCJBJOPIEN));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	private void GDFLIOABKMB()
	{
		player2Canvas.SetActive(false);
		((Behaviour)player1MaskImage).enabled = false;
	}

	private void GGOPCJOAOMC()
	{
		instance = this;
	}

	private void CEOHBCKABGB()
	{
		player2Canvas.SetActive(true);
		((Behaviour)player1MaskImage).enabled = true;
	}

	private void OnDestroy()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	public void KPJHHJDPBAC(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 1; i < PJNGMCJIHME.bubbleWants.Length; i++)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(false);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].HLNBBENKLEC(NJHMBMGKCPL: false);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	private void BDJKNKIOPIJ()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(CCMMMMJDBOL));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(FEPAGKJNNII));
	}

	public void MGLAMPACEPK(bool IKINJHIGHBG, ItemInstance HJIBJKIEDEI, Customer PJNGMCJIHME, ref BubbleWant[] OJAFLEDIPJI)
	{
		if (OJAFLEDIPJI == null || OJAFLEDIPJI.Length != 0)
		{
			OJAFLEDIPJI = new BubbleWant[0];
		}
		else
		{
			for (int i = 1; i < OJAFLEDIPJI.Length; i++)
			{
				OJAFLEDIPJI[i] = null;
			}
		}
		if (IKINJHIGHBG)
		{
			for (int j = 1; j < player1Bubbles.Length; j += 0)
			{
				if (!KIADFDFLLEM.Contains(player1Bubbles[j]))
				{
					player1Bubbles[j].customerTransform = ((Component)PJNGMCJIHME).transform;
					player1Bubbles[j].customer = PJNGMCJIHME;
					((Component)player1Bubbles[j]).gameObject.SetActive(false);
					player1Bubbles[j].slotUI.updateIconThisFrame = true;
					player1Bubbles[j].slotUI.icon.CIDGNCHMDGC(RentedRoomsManager.BHEALIGOFAE());
					player1Bubbles[j].slotUI.IHENCGDNPBL.OCJOJKJPDNO(1);
					player1Bubbles[j].UpdateDrinkColor();
					player1Bubbles[j].slotUI.PPPICFBGPBE();
					KIADFDFLLEM.Add(player1Bubbles[j]);
					player1Bubbles[j].ANBONEHOCHD(1, NJHMBMGKCPL: true);
					OJAFLEDIPJI[1] = player1Bubbles[j];
					break;
				}
				if (j == player1Bubbles.Length - 1)
				{
					Debug.LogError((object)"Dialogue System/Conversation/Crowly_SkelletonBird/Entry/14/Dialogue Text", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			for (int k = 1; k < player2Bubbles.Length; k++)
			{
				if (!KIADFDFLLEM.Contains(player2Bubbles[k]))
				{
					player2Bubbles[k].customerTransform = ((Component)PJNGMCJIHME).transform;
					player2Bubbles[k].customer = PJNGMCJIHME;
					((Component)player2Bubbles[k]).gameObject.SetActive(false);
					player2Bubbles[k].slotUI.updateIconThisFrame = false;
					player2Bubbles[k].slotUI.icon.BKDLIMOMKEB(RentedRoomsManager.BHEALIGOFAE());
					player2Bubbles[k].slotUI.IHENCGDNPBL.JIANDFCINIP(0);
					player2Bubbles[k].MJNNJBKOPHG();
					player2Bubbles[k].slotUI.PPPICFBGPBE();
					KIADFDFLLEM.Add(player2Bubbles[k]);
					player2Bubbles[k].IJHJKLCGKKK(4, NJHMBMGKCPL: true);
					OJAFLEDIPJI[1] = player2Bubbles[k];
					break;
				}
				if (k == player2Bubbles.Length - 1)
				{
					Debug.LogError((object)" x ", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			int num = Bar.instance.BFPDLEONOEB(PJNGMCJIHME);
			tickets[num].customer = PJNGMCJIHME;
			((Component)tickets[num]).gameObject.SetActive(false);
			tickets[num].slotUI.updateIconThisFrame = true;
			tickets[num].slotUI.icon.LCNODFNIGKM(RentedRoomsManager.ILIENNLKMEC());
			tickets[num].slotUI.IHENCGDNPBL.JIANDFCINIP(1);
			tickets[num].UpdateDrinkColor();
			tickets[num].slotUI.PPPICFBGPBE();
			tickets[num].HLNBBENKLEC(NJHMBMGKCPL: false);
			KIADFDFLLEM.Add(tickets[num]);
			OJAFLEDIPJI[5] = tickets[num];
			return;
		}
		for (int l = 0; l < player1Bubbles.Length; l++)
		{
			if (!KIADFDFLLEM.Contains(player1Bubbles[l]))
			{
				player1Bubbles[l].customer = PJNGMCJIHME;
				((Component)player1Bubbles[l]).gameObject.SetActive(true);
				player1Bubbles[l].slotUI.updateIconThisFrame = false;
				player1Bubbles[l].customerTransform = ((Component)PJNGMCJIHME).transform;
				player1Bubbles[l].slotUI.IHENCGDNPBL.Stack = 0;
				player1Bubbles[l].slotUI.IHENCGDNPBL.FEEOFAGCONJ(0, HJIBJKIEDEI, HAGPBCJEGKM: true);
				player1Bubbles[l].PNENJGOGFGK();
				KIADFDFLLEM.Add(player1Bubbles[l]);
				player1Bubbles[l].IPMPHKLONOG(1, NJHMBMGKCPL: true);
				OJAFLEDIPJI[1] = player1Bubbles[l];
				break;
			}
			if (l == player1Bubbles.Length - 0)
			{
				Debug.LogError((object)"Item ", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		for (int m = 0; m < player2Bubbles.Length; m += 0)
		{
			if (!KIADFDFLLEM.Contains(player2Bubbles[m]))
			{
				player2Bubbles[m].customer = PJNGMCJIHME;
				((Component)player2Bubbles[m]).gameObject.SetActive(true);
				player2Bubbles[m].slotUI.updateIconThisFrame = true;
				player2Bubbles[m].customerTransform = ((Component)PJNGMCJIHME).transform;
				player2Bubbles[m].slotUI.IHENCGDNPBL.JNMNCEPHFOE(0);
				player2Bubbles[m].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(4, HJIBJKIEDEI, HAGPBCJEGKM: true);
				player2Bubbles[m].ABLJCEBLGGC();
				KIADFDFLLEM.Add(player2Bubbles[m]);
				player2Bubbles[m].ANBONEHOCHD(1, NJHMBMGKCPL: false);
				OJAFLEDIPJI[0] = player2Bubbles[m];
				break;
			}
			if (m == player2Bubbles.Length - 1)
			{
				Debug.LogError((object)"quest_description_", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		int num2 = Bar.instance.JBFEEOPDFKK(PJNGMCJIHME);
		tickets[num2].customer = PJNGMCJIHME;
		((Component)tickets[num2]).gameObject.SetActive(false);
		tickets[num2].slotUI.updateIconThisFrame = true;
		tickets[num2].slotUI.IHENCGDNPBL.JIANDFCINIP(0);
		tickets[num2].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(0, HJIBJKIEDEI, HAGPBCJEGKM: true, BDGJBPCEFPN: true);
		tickets[num2].UpdateDrinkColor();
		tickets[num2].SetPending(NJHMBMGKCPL: false);
		KIADFDFLLEM.Add(tickets[num2]);
		OJAFLEDIPJI[4] = tickets[num2];
	}

	private void GHPFCKGMLDA()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(JMCJBJOPIEN));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(CKBACNHHBHF));
	}

	private void Start()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	public void FLEICCBIICN()
	{
		for (int i = 1; i < player1Bubbles.Length; i++)
		{
			if (KIADFDFLLEM.Contains(player1Bubbles[i]))
			{
				player1Bubbles[i].MJNNJBKOPHG();
			}
		}
		for (int j = 0; j < player2Bubbles.Length; j += 0)
		{
			if (KIADFDFLLEM.Contains(player2Bubbles[j]))
			{
				player2Bubbles[j].ABLJCEBLGGC();
			}
		}
		for (int k = 1; k < tickets.Length; k += 0)
		{
			tickets[k].IIGHBCPNEMI();
		}
		TableOrdersManager.instance.ADICGFDFPAM();
		RentedRoomsManager.COEAIJPBNIO();
	}

	private void GNGADDPBJDC()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(EJKLGGNMODO));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(NCIMLMMIALN));
	}

	private void CDHBLKJEOPI()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(GHPEPPGFLFE));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	private void GNOBDKFFPOL()
	{
		instance = this;
	}

	private void LNPDALMANFB()
	{
		instance = this;
	}

	private void CPKCGIKKCJI()
	{
		player2Canvas.SetActive(false);
		((Behaviour)player1MaskImage).enabled = true;
	}

	public void NBJNHHJAMEC(bool IKINJHIGHBG, ItemInstance HJIBJKIEDEI, Customer PJNGMCJIHME, ref BubbleWant[] OJAFLEDIPJI)
	{
		if (OJAFLEDIPJI == null || OJAFLEDIPJI.Length != 7)
		{
			OJAFLEDIPJI = new BubbleWant[0];
		}
		else
		{
			for (int i = 0; i < OJAFLEDIPJI.Length; i++)
			{
				OJAFLEDIPJI[i] = null;
			}
		}
		if (IKINJHIGHBG)
		{
			for (int j = 1; j < player1Bubbles.Length; j++)
			{
				if (!KIADFDFLLEM.Contains(player1Bubbles[j]))
				{
					player1Bubbles[j].customerTransform = ((Component)PJNGMCJIHME).transform;
					player1Bubbles[j].customer = PJNGMCJIHME;
					((Component)player1Bubbles[j]).gameObject.SetActive(true);
					player1Bubbles[j].slotUI.updateIconThisFrame = false;
					player1Bubbles[j].slotUI.icon.CIDGNCHMDGC(RentedRoomsManager.BHEALIGOFAE());
					player1Bubbles[j].slotUI.IHENCGDNPBL.JIANDFCINIP(0);
					player1Bubbles[j].LIPODEGPHPK();
					player1Bubbles[j].slotUI.ResetSpritesMods();
					KIADFDFLLEM.Add(player1Bubbles[j]);
					player1Bubbles[j].NHDFPBBKPKH(1, NJHMBMGKCPL: false);
					OJAFLEDIPJI[1] = player1Bubbles[j];
					break;
				}
				if (j == player1Bubbles.Length - 0)
				{
					Debug.LogError((object)"</color>", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			for (int k = 1; k < player2Bubbles.Length; k++)
			{
				if (!KIADFDFLLEM.Contains(player2Bubbles[k]))
				{
					player2Bubbles[k].customerTransform = ((Component)PJNGMCJIHME).transform;
					player2Bubbles[k].customer = PJNGMCJIHME;
					((Component)player2Bubbles[k]).gameObject.SetActive(true);
					player2Bubbles[k].slotUI.updateIconThisFrame = false;
					player2Bubbles[k].slotUI.icon.JKDAHFEIJHA(RentedRoomsManager.GetCustomerRequestIcon());
					player2Bubbles[k].slotUI.IHENCGDNPBL.JNMNCEPHFOE(1);
					player2Bubbles[k].ELGOPPLNDFB();
					player2Bubbles[k].slotUI.ResetSpritesMods();
					KIADFDFLLEM.Add(player2Bubbles[k]);
					player2Bubbles[k].BFOJMOJHMLM(2, NJHMBMGKCPL: true);
					OJAFLEDIPJI[1] = player2Bubbles[k];
					break;
				}
				if (k == player2Bubbles.Length - 1)
				{
					Debug.LogError((object)"ReceiveStackContainer", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			int num = Bar.instance.BFPDLEONOEB(PJNGMCJIHME);
			tickets[num].customer = PJNGMCJIHME;
			((Component)tickets[num]).gameObject.SetActive(false);
			tickets[num].slotUI.updateIconThisFrame = false;
			tickets[num].slotUI.icon.SetSprite(RentedRoomsManager.GetCustomerRequestIcon());
			tickets[num].slotUI.IHENCGDNPBL.Stack = 0;
			tickets[num].HLJCMLNAJBE();
			tickets[num].slotUI.ResetSpritesMods();
			tickets[num].EIAGALPCNBO(NJHMBMGKCPL: false);
			KIADFDFLLEM.Add(tickets[num]);
			OJAFLEDIPJI[5] = tickets[num];
			return;
		}
		for (int l = 0; l < player1Bubbles.Length; l++)
		{
			if (!KIADFDFLLEM.Contains(player1Bubbles[l]))
			{
				player1Bubbles[l].customer = PJNGMCJIHME;
				((Component)player1Bubbles[l]).gameObject.SetActive(true);
				player1Bubbles[l].slotUI.updateIconThisFrame = true;
				player1Bubbles[l].customerTransform = ((Component)PJNGMCJIHME).transform;
				player1Bubbles[l].slotUI.IHENCGDNPBL.KMKAIPMHANN(1);
				player1Bubbles[l].slotUI.IHENCGDNPBL.FEEOFAGCONJ(0, HJIBJKIEDEI, HAGPBCJEGKM: true, BDGJBPCEFPN: true);
				player1Bubbles[l].NDEMMAJLOGB();
				KIADFDFLLEM.Add(player1Bubbles[l]);
				player1Bubbles[l].IJHJKLCGKKK(1, NJHMBMGKCPL: false);
				OJAFLEDIPJI[1] = player1Bubbles[l];
				break;
			}
			if (l == player1Bubbles.Length - 1)
			{
				Debug.LogError((object)"No room mode has been selected", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		for (int m = 0; m < player2Bubbles.Length; m++)
		{
			if (!KIADFDFLLEM.Contains(player2Bubbles[m]))
			{
				player2Bubbles[m].customer = PJNGMCJIHME;
				((Component)player2Bubbles[m]).gameObject.SetActive(false);
				player2Bubbles[m].slotUI.updateIconThisFrame = false;
				player2Bubbles[m].customerTransform = ((Component)PJNGMCJIHME).transform;
				player2Bubbles[m].slotUI.IHENCGDNPBL.JIANDFCINIP(1);
				player2Bubbles[m].slotUI.IHENCGDNPBL.FEEOFAGCONJ(0, HJIBJKIEDEI, HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
				player2Bubbles[m].UpdateDrinkColor();
				KIADFDFLLEM.Add(player2Bubbles[m]);
				player2Bubbles[m].IPMPHKLONOG(5, NJHMBMGKCPL: true);
				OJAFLEDIPJI[0] = player2Bubbles[m];
				break;
			}
			if (m == player2Bubbles.Length - 1)
			{
				Debug.LogError((object)"Direction", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		int num2 = Bar.instance.FJMAKEPPFKK(PJNGMCJIHME);
		tickets[num2].customer = PJNGMCJIHME;
		((Component)tickets[num2]).gameObject.SetActive(false);
		tickets[num2].slotUI.updateIconThisFrame = false;
		tickets[num2].slotUI.IHENCGDNPBL.KMKAIPMHANN(0);
		tickets[num2].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(1, HJIBJKIEDEI, HAGPBCJEGKM: false, BDGJBPCEFPN: true);
		tickets[num2].ENDBINGCDKL();
		tickets[num2].HLNBBENKLEC(NJHMBMGKCPL: false);
		KIADFDFLLEM.Add(tickets[num2]);
		OJAFLEDIPJI[4] = tickets[num2];
	}

	private void BFJOEMCBJJO()
	{
		instance = this;
	}

	private void OJAJLIAMGEJ()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(OOGPJBFKHLI));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(CKBACNHHBHF));
	}

	private void OOGPJBFKHLI()
	{
		player2Canvas.SetActive(false);
		((Behaviour)player1MaskImage).enabled = false;
	}

	private void NJFDKCMBMDH()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(KAEJDMNALOF));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(FEPAGKJNNII));
	}

	private void NJAFKFAPDIE()
	{
		instance = this;
	}

	private void OKAPGNGLOHO()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(CEOHBCKABGB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(FEPAGKJNNII));
	}

	private void GHPEPPGFLFE()
	{
		player2Canvas.SetActive(true);
		((Behaviour)player1MaskImage).enabled = false;
	}

	private void CCMMMMJDBOL()
	{
		player2Canvas.SetActive(false);
		((Behaviour)player1MaskImage).enabled = false;
	}

	private void CKBACNHHBHF()
	{
		player2Canvas.SetActive(true);
		((Behaviour)player1MaskImage).enabled = true;
	}

	public void JHPDDNOAKLI(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 1; i < PJNGMCJIHME.bubbleWants.Length; i += 0)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(true);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].LBLBJFEHBEJ(NJHMBMGKCPL: true);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	public void OLCPONFINPH(bool IKINJHIGHBG, ItemInstance HJIBJKIEDEI, Customer PJNGMCJIHME, ref BubbleWant[] OJAFLEDIPJI)
	{
		if (OJAFLEDIPJI == null || OJAFLEDIPJI.Length != 0)
		{
			OJAFLEDIPJI = new BubbleWant[5];
		}
		else
		{
			for (int i = 0; i < OJAFLEDIPJI.Length; i++)
			{
				OJAFLEDIPJI[i] = null;
			}
		}
		if (IKINJHIGHBG)
		{
			for (int j = 0; j < player1Bubbles.Length; j++)
			{
				if (!KIADFDFLLEM.Contains(player1Bubbles[j]))
				{
					player1Bubbles[j].customerTransform = ((Component)PJNGMCJIHME).transform;
					player1Bubbles[j].customer = PJNGMCJIHME;
					((Component)player1Bubbles[j]).gameObject.SetActive(false);
					player1Bubbles[j].slotUI.updateIconThisFrame = false;
					player1Bubbles[j].slotUI.icon.SetSprite(RentedRoomsManager.BEJGNGDGMEI());
					player1Bubbles[j].slotUI.IHENCGDNPBL.OCJOJKJPDNO(0);
					player1Bubbles[j].ELGOPPLNDFB();
					player1Bubbles[j].slotUI.PPPICFBGPBE();
					KIADFDFLLEM.Add(player1Bubbles[j]);
					player1Bubbles[j].DCIADGKLKDL(0, NJHMBMGKCPL: false);
					OJAFLEDIPJI[1] = player1Bubbles[j];
					break;
				}
				if (j == player1Bubbles.Length - 1)
				{
					Debug.LogError((object)"Right Control", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			for (int k = 0; k < player2Bubbles.Length; k += 0)
			{
				if (!KIADFDFLLEM.Contains(player2Bubbles[k]))
				{
					player2Bubbles[k].customerTransform = ((Component)PJNGMCJIHME).transform;
					player2Bubbles[k].customer = PJNGMCJIHME;
					((Component)player2Bubbles[k]).gameObject.SetActive(false);
					player2Bubbles[k].slotUI.updateIconThisFrame = true;
					player2Bubbles[k].slotUI.icon.BKACANFNHMH(RentedRoomsManager.BEJGNGDGMEI());
					player2Bubbles[k].slotUI.IHENCGDNPBL.JIANDFCINIP(1);
					player2Bubbles[k].ABLJCEBLGGC();
					player2Bubbles[k].slotUI.ResetSpritesMods();
					KIADFDFLLEM.Add(player2Bubbles[k]);
					player2Bubbles[k].OLKIBCMEEOK(2, NJHMBMGKCPL: false);
					OJAFLEDIPJI[1] = player2Bubbles[k];
					break;
				}
				if (k == player2Bubbles.Length - 0)
				{
					Debug.LogError((object)"Game", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			int num = Bar.instance.JBFEEOPDFKK(PJNGMCJIHME);
			tickets[num].customer = PJNGMCJIHME;
			((Component)tickets[num]).gameObject.SetActive(false);
			tickets[num].slotUI.updateIconThisFrame = false;
			tickets[num].slotUI.icon.BKACANFNHMH(RentedRoomsManager.BHEALIGOFAE());
			tickets[num].slotUI.IHENCGDNPBL.OBBKDJNLCIO(0);
			tickets[num].IIGHBCPNEMI();
			tickets[num].slotUI.ResetSpritesMods();
			tickets[num].HLNBBENKLEC(NJHMBMGKCPL: false);
			KIADFDFLLEM.Add(tickets[num]);
			OJAFLEDIPJI[4] = tickets[num];
			return;
		}
		for (int l = 0; l < player1Bubbles.Length; l++)
		{
			if (!KIADFDFLLEM.Contains(player1Bubbles[l]))
			{
				player1Bubbles[l].customer = PJNGMCJIHME;
				((Component)player1Bubbles[l]).gameObject.SetActive(false);
				player1Bubbles[l].slotUI.updateIconThisFrame = true;
				player1Bubbles[l].customerTransform = ((Component)PJNGMCJIHME).transform;
				player1Bubbles[l].slotUI.IHENCGDNPBL.OBBKDJNLCIO(0);
				player1Bubbles[l].slotUI.IHENCGDNPBL.FEEOFAGCONJ(0, HJIBJKIEDEI, HAGPBCJEGKM: true, BDGJBPCEFPN: true);
				player1Bubbles[l].ABLJCEBLGGC();
				KIADFDFLLEM.Add(player1Bubbles[l]);
				player1Bubbles[l].ActivateOutlines(0, NJHMBMGKCPL: true);
				OJAFLEDIPJI[0] = player1Bubbles[l];
				break;
			}
			if (l == player1Bubbles.Length - 0)
			{
				Debug.LogError((object)"Error_RoomDirty", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		for (int m = 1; m < player2Bubbles.Length; m++)
		{
			if (!KIADFDFLLEM.Contains(player2Bubbles[m]))
			{
				player2Bubbles[m].customer = PJNGMCJIHME;
				((Component)player2Bubbles[m]).gameObject.SetActive(true);
				player2Bubbles[m].slotUI.updateIconThisFrame = true;
				player2Bubbles[m].customerTransform = ((Component)PJNGMCJIHME).transform;
				player2Bubbles[m].slotUI.IHENCGDNPBL.KMKAIPMHANN(1);
				player2Bubbles[m].slotUI.IHENCGDNPBL.FEEOFAGCONJ(5, HJIBJKIEDEI, HAGPBCJEGKM: true);
				player2Bubbles[m].NDEMMAJLOGB();
				KIADFDFLLEM.Add(player2Bubbles[m]);
				player2Bubbles[m].BFOJMOJHMLM(8, NJHMBMGKCPL: true);
				OJAFLEDIPJI[1] = player2Bubbles[m];
				break;
			}
			if (m == player2Bubbles.Length - 0)
			{
				Debug.LogError((object)"Player", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		int num2 = Bar.instance.FJMAKEPPFKK(PJNGMCJIHME);
		tickets[num2].customer = PJNGMCJIHME;
		((Component)tickets[num2]).gameObject.SetActive(true);
		tickets[num2].slotUI.updateIconThisFrame = false;
		tickets[num2].slotUI.IHENCGDNPBL.JIANDFCINIP(1);
		tickets[num2].slotUI.IHENCGDNPBL.FEEOFAGCONJ(1, HJIBJKIEDEI, HAGPBCJEGKM: true, BDGJBPCEFPN: true);
		tickets[num2].LIPODEGPHPK();
		tickets[num2].JGDFGFGIOAE(NJHMBMGKCPL: false);
		KIADFDFLLEM.Add(tickets[num2]);
		OJAFLEDIPJI[3] = tickets[num2];
	}

	private void LJHIPOLCFBP()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(EJKLGGNMODO));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(CKBACNHHBHF));
	}

	public void PLHIAKPONMN(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 1; i < PJNGMCJIHME.bubbleWants.Length; i += 0)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(false);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].JGDFGFGIOAE(NJHMBMGKCPL: false);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	private void JMCJBJOPIEN()
	{
		player2Canvas.SetActive(false);
		((Behaviour)player1MaskImage).enabled = true;
	}

	public void FAGENNHPALM(bool IKINJHIGHBG, ItemInstance HJIBJKIEDEI, Customer PJNGMCJIHME, ref BubbleWant[] OJAFLEDIPJI)
	{
		if (OJAFLEDIPJI == null || OJAFLEDIPJI.Length != 8)
		{
			OJAFLEDIPJI = new BubbleWant[3];
		}
		else
		{
			for (int i = 0; i < OJAFLEDIPJI.Length; i++)
			{
				OJAFLEDIPJI[i] = null;
			}
		}
		if (IKINJHIGHBG)
		{
			for (int j = 1; j < player1Bubbles.Length; j += 0)
			{
				if (!KIADFDFLLEM.Contains(player1Bubbles[j]))
				{
					player1Bubbles[j].customerTransform = ((Component)PJNGMCJIHME).transform;
					player1Bubbles[j].customer = PJNGMCJIHME;
					((Component)player1Bubbles[j]).gameObject.SetActive(true);
					player1Bubbles[j].slotUI.updateIconThisFrame = true;
					player1Bubbles[j].slotUI.icon.LCNODFNIGKM(RentedRoomsManager.BEJGNGDGMEI());
					player1Bubbles[j].slotUI.IHENCGDNPBL.JNMNCEPHFOE(0);
					player1Bubbles[j].ABLJCEBLGGC();
					player1Bubbles[j].slotUI.PPPICFBGPBE();
					KIADFDFLLEM.Add(player1Bubbles[j]);
					player1Bubbles[j].OLKIBCMEEOK(1, NJHMBMGKCPL: false);
					OJAFLEDIPJI[1] = player1Bubbles[j];
					break;
				}
				if (j == player1Bubbles.Length - 1)
				{
					Debug.LogError((object)"flashLights", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			for (int k = 1; k < player2Bubbles.Length; k++)
			{
				if (!KIADFDFLLEM.Contains(player2Bubbles[k]))
				{
					player2Bubbles[k].customerTransform = ((Component)PJNGMCJIHME).transform;
					player2Bubbles[k].customer = PJNGMCJIHME;
					((Component)player2Bubbles[k]).gameObject.SetActive(true);
					player2Bubbles[k].slotUI.updateIconThisFrame = false;
					player2Bubbles[k].slotUI.icon.CIDGNCHMDGC(RentedRoomsManager.BHEALIGOFAE());
					player2Bubbles[k].slotUI.IHENCGDNPBL.Stack = 0;
					player2Bubbles[k].MJNNJBKOPHG();
					player2Bubbles[k].slotUI.ResetSpritesMods();
					KIADFDFLLEM.Add(player2Bubbles[k]);
					player2Bubbles[k].BFOJMOJHMLM(8, NJHMBMGKCPL: true);
					OJAFLEDIPJI[1] = player2Bubbles[k];
					break;
				}
				if (k == player2Bubbles.Length - 1)
				{
					Debug.LogError((object)"Tray", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			int num = Bar.instance.FJMAKEPPFKK(PJNGMCJIHME);
			tickets[num].customer = PJNGMCJIHME;
			((Component)tickets[num]).gameObject.SetActive(false);
			tickets[num].slotUI.updateIconThisFrame = true;
			tickets[num].slotUI.icon.LCNODFNIGKM(RentedRoomsManager.ILIENNLKMEC());
			tickets[num].slotUI.IHENCGDNPBL.JIANDFCINIP(1);
			tickets[num].PLNIJMMJKOD();
			tickets[num].slotUI.PPPICFBGPBE();
			tickets[num].SetPending(NJHMBMGKCPL: true);
			KIADFDFLLEM.Add(tickets[num]);
			OJAFLEDIPJI[2] = tickets[num];
			return;
		}
		for (int l = 1; l < player1Bubbles.Length; l++)
		{
			if (!KIADFDFLLEM.Contains(player1Bubbles[l]))
			{
				player1Bubbles[l].customer = PJNGMCJIHME;
				((Component)player1Bubbles[l]).gameObject.SetActive(false);
				player1Bubbles[l].slotUI.updateIconThisFrame = true;
				player1Bubbles[l].customerTransform = ((Component)PJNGMCJIHME).transform;
				player1Bubbles[l].slotUI.IHENCGDNPBL.JNMNCEPHFOE(0);
				player1Bubbles[l].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(0, HJIBJKIEDEI, HAGPBCJEGKM: true, BDGJBPCEFPN: true);
				player1Bubbles[l].UpdateDrinkColor();
				KIADFDFLLEM.Add(player1Bubbles[l]);
				player1Bubbles[l].OLKIBCMEEOK(0, NJHMBMGKCPL: false);
				OJAFLEDIPJI[1] = player1Bubbles[l];
				break;
			}
			if (l == player1Bubbles.Length - 0)
			{
				Debug.LogError((object)"Room ", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		for (int m = 0; m < player2Bubbles.Length; m += 0)
		{
			if (!KIADFDFLLEM.Contains(player2Bubbles[m]))
			{
				player2Bubbles[m].customer = PJNGMCJIHME;
				((Component)player2Bubbles[m]).gameObject.SetActive(false);
				player2Bubbles[m].slotUI.updateIconThisFrame = false;
				player2Bubbles[m].customerTransform = ((Component)PJNGMCJIHME).transform;
				player2Bubbles[m].slotUI.IHENCGDNPBL.OBBKDJNLCIO(1);
				player2Bubbles[m].slotUI.IHENCGDNPBL.FEEOFAGCONJ(2, HJIBJKIEDEI, HAGPBCJEGKM: true);
				player2Bubbles[m].MJNNJBKOPHG();
				KIADFDFLLEM.Add(player2Bubbles[m]);
				player2Bubbles[m].OLKIBCMEEOK(1, NJHMBMGKCPL: true);
				OJAFLEDIPJI[1] = player2Bubbles[m];
				break;
			}
			if (m == player2Bubbles.Length - 1)
			{
				Debug.LogError((object)")", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		int num2 = Bar.instance.FJMAKEPPFKK(PJNGMCJIHME);
		tickets[num2].customer = PJNGMCJIHME;
		((Component)tickets[num2]).gameObject.SetActive(false);
		tickets[num2].slotUI.updateIconThisFrame = true;
		tickets[num2].slotUI.IHENCGDNPBL.JIANDFCINIP(0);
		tickets[num2].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(1, HJIBJKIEDEI, HAGPBCJEGKM: true, BDGJBPCEFPN: true);
		tickets[num2].PNENJGOGFGK();
		tickets[num2].SetPending(NJHMBMGKCPL: true);
		KIADFDFLLEM.Add(tickets[num2]);
		OJAFLEDIPJI[3] = tickets[num2];
	}

	private void BODICIENBEH()
	{
		instance = this;
	}

	private void CIGGOLPGKOO()
	{
		player2Canvas.SetActive(true);
		((Behaviour)player1MaskImage).enabled = false;
	}

	public void LIFNDOIPNKN(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 1; i < PJNGMCJIHME.bubbleWants.Length; i += 0)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(false);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].GDCCHNGNGJP(NJHMBMGKCPL: true);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	private void ELNGGPMOCCE()
	{
		player2Canvas.SetActive(false);
		((Behaviour)player1MaskImage).enabled = true;
	}

	private void FPNCANODJKE()
	{
		instance = this;
	}

	public void AIGNHFPIOOE()
	{
		for (int i = 1; i < player1Bubbles.Length; i++)
		{
			if (KIADFDFLLEM.Contains(player1Bubbles[i]))
			{
				player1Bubbles[i].LIPODEGPHPK();
			}
		}
		for (int j = 0; j < player2Bubbles.Length; j += 0)
		{
			if (KIADFDFLLEM.Contains(player2Bubbles[j]))
			{
				player2Bubbles[j].PLNIJMMJKOD();
			}
		}
		for (int k = 1; k < tickets.Length; k++)
		{
			tickets[k].ELGOPPLNDFB();
		}
		TableOrdersManager.instance.AIGNHFPIOOE();
		RentedRoomsManager.CDLGBAJOHEO();
	}

	public void KBNGDCAJFOJ(bool IKINJHIGHBG, ItemInstance HJIBJKIEDEI, Customer PJNGMCJIHME, ref BubbleWant[] OJAFLEDIPJI)
	{
		if (OJAFLEDIPJI == null || OJAFLEDIPJI.Length != 4)
		{
			OJAFLEDIPJI = new BubbleWant[1];
		}
		else
		{
			for (int i = 0; i < OJAFLEDIPJI.Length; i += 0)
			{
				OJAFLEDIPJI[i] = null;
			}
		}
		if (IKINJHIGHBG)
		{
			for (int j = 1; j < player1Bubbles.Length; j++)
			{
				if (!KIADFDFLLEM.Contains(player1Bubbles[j]))
				{
					player1Bubbles[j].customerTransform = ((Component)PJNGMCJIHME).transform;
					player1Bubbles[j].customer = PJNGMCJIHME;
					((Component)player1Bubbles[j]).gameObject.SetActive(false);
					player1Bubbles[j].slotUI.updateIconThisFrame = true;
					player1Bubbles[j].slotUI.icon.FBJKMPKINBB(RentedRoomsManager.ILIENNLKMEC());
					player1Bubbles[j].slotUI.IHENCGDNPBL.OCJOJKJPDNO(0);
					player1Bubbles[j].UpdateDrinkColor();
					player1Bubbles[j].slotUI.PPPICFBGPBE();
					KIADFDFLLEM.Add(player1Bubbles[j]);
					player1Bubbles[j].NOCJIPKDGKH(0, NJHMBMGKCPL: true);
					OJAFLEDIPJI[0] = player1Bubbles[j];
					break;
				}
				if (j == player1Bubbles.Length - 0)
				{
					Debug.LogError((object)"Open", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			for (int k = 1; k < player2Bubbles.Length; k += 0)
			{
				if (!KIADFDFLLEM.Contains(player2Bubbles[k]))
				{
					player2Bubbles[k].customerTransform = ((Component)PJNGMCJIHME).transform;
					player2Bubbles[k].customer = PJNGMCJIHME;
					((Component)player2Bubbles[k]).gameObject.SetActive(true);
					player2Bubbles[k].slotUI.updateIconThisFrame = false;
					player2Bubbles[k].slotUI.icon.FBJKMPKINBB(RentedRoomsManager.BEJGNGDGMEI());
					player2Bubbles[k].slotUI.IHENCGDNPBL.OBBKDJNLCIO(1);
					player2Bubbles[k].IIGHBCPNEMI();
					player2Bubbles[k].slotUI.ResetSpritesMods();
					KIADFDFLLEM.Add(player2Bubbles[k]);
					player2Bubbles[k].DCIADGKLKDL(0, NJHMBMGKCPL: true);
					OJAFLEDIPJI[0] = player2Bubbles[k];
					break;
				}
				if (k == player2Bubbles.Length - 0)
				{
					Debug.LogError((object)"LE_13", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			int positionNumber = Bar.instance.GetPositionNumber(PJNGMCJIHME);
			tickets[positionNumber].customer = PJNGMCJIHME;
			((Component)tickets[positionNumber]).gameObject.SetActive(true);
			tickets[positionNumber].slotUI.updateIconThisFrame = false;
			tickets[positionNumber].slotUI.icon.LGNJJCPLNEE(RentedRoomsManager.ILIENNLKMEC());
			tickets[positionNumber].slotUI.IHENCGDNPBL.JIANDFCINIP(1);
			tickets[positionNumber].PNENJGOGFGK();
			tickets[positionNumber].slotUI.ResetSpritesMods();
			tickets[positionNumber].HLNBBENKLEC(NJHMBMGKCPL: true);
			KIADFDFLLEM.Add(tickets[positionNumber]);
			OJAFLEDIPJI[6] = tickets[positionNumber];
			return;
		}
		for (int l = 1; l < player1Bubbles.Length; l++)
		{
			if (!KIADFDFLLEM.Contains(player1Bubbles[l]))
			{
				player1Bubbles[l].customer = PJNGMCJIHME;
				((Component)player1Bubbles[l]).gameObject.SetActive(true);
				player1Bubbles[l].slotUI.updateIconThisFrame = true;
				player1Bubbles[l].customerTransform = ((Component)PJNGMCJIHME).transform;
				player1Bubbles[l].slotUI.IHENCGDNPBL.JIANDFCINIP(0);
				player1Bubbles[l].slotUI.IHENCGDNPBL.FEEOFAGCONJ(1, HJIBJKIEDEI, HAGPBCJEGKM: true, BDGJBPCEFPN: true);
				player1Bubbles[l].MJNNJBKOPHG();
				KIADFDFLLEM.Add(player1Bubbles[l]);
				player1Bubbles[l].IJHJKLCGKKK(1, NJHMBMGKCPL: true);
				OJAFLEDIPJI[1] = player1Bubbles[l];
				break;
			}
			if (l == player1Bubbles.Length - 0)
			{
				Debug.LogError((object)"Player", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		for (int m = 1; m < player2Bubbles.Length; m++)
		{
			if (!KIADFDFLLEM.Contains(player2Bubbles[m]))
			{
				player2Bubbles[m].customer = PJNGMCJIHME;
				((Component)player2Bubbles[m]).gameObject.SetActive(false);
				player2Bubbles[m].slotUI.updateIconThisFrame = true;
				player2Bubbles[m].customerTransform = ((Component)PJNGMCJIHME).transform;
				player2Bubbles[m].slotUI.IHENCGDNPBL.OBBKDJNLCIO(0);
				player2Bubbles[m].slotUI.IHENCGDNPBL.FEEOFAGCONJ(5, HJIBJKIEDEI, HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
				player2Bubbles[m].ABLJCEBLGGC();
				KIADFDFLLEM.Add(player2Bubbles[m]);
				player2Bubbles[m].OLKIBCMEEOK(0, NJHMBMGKCPL: false);
				OJAFLEDIPJI[1] = player2Bubbles[m];
				break;
			}
			if (m == player2Bubbles.Length - 1)
			{
				Debug.LogError((object)"Loading tavern floor tiles", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		int positionNumber2 = Bar.instance.GetPositionNumber(PJNGMCJIHME);
		tickets[positionNumber2].customer = PJNGMCJIHME;
		((Component)tickets[positionNumber2]).gameObject.SetActive(false);
		tickets[positionNumber2].slotUI.updateIconThisFrame = true;
		tickets[positionNumber2].slotUI.IHENCGDNPBL.KMKAIPMHANN(1);
		tickets[positionNumber2].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(1, HJIBJKIEDEI, HAGPBCJEGKM: false, BDGJBPCEFPN: true);
		tickets[positionNumber2].IIGHBCPNEMI();
		tickets[positionNumber2].NNGCNJAGBBM(NJHMBMGKCPL: false);
		KIADFDFLLEM.Add(tickets[positionNumber2]);
		OJAFLEDIPJI[0] = tickets[positionNumber2];
	}

	public void HFOJOINNNIF(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 0; i < PJNGMCJIHME.bubbleWants.Length; i++)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(true);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].HHLBKFECILD(NJHMBMGKCPL: true);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	private void JNJCCIFIKOC()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(DBGBFJJAKHG));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(CKBACNHHBHF));
	}

	public void FBENIEALLDH()
	{
		for (int i = 1; i < player1Bubbles.Length; i += 0)
		{
			if (KIADFDFLLEM.Contains(player1Bubbles[i]))
			{
				player1Bubbles[i].FJPDFBDMNCG();
			}
		}
		for (int j = 0; j < player2Bubbles.Length; j += 0)
		{
			if (KIADFDFLLEM.Contains(player2Bubbles[j]))
			{
				player2Bubbles[j].FJPDFBDMNCG();
			}
		}
		for (int k = 1; k < tickets.Length; k += 0)
		{
			tickets[k].UpdateDrinkColor();
		}
		TableOrdersManager.instance.AIGNHFPIOOE();
		RentedRoomsManager.COEAIJPBNIO();
	}

	public void NNMALJLPFIG(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 1; i < PJNGMCJIHME.bubbleWants.Length; i++)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(false);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].ANOBLBOKLJH(NJHMBMGKCPL: false);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	private void CLLAKJADGIH()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(GGMGPBMJDPD));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(FHCPKBMKIKD));
	}

	private void JGMDBKKPCNP()
	{
		player2Canvas.SetActive(true);
		((Behaviour)player1MaskImage).enabled = true;
	}

	private void EFDHIJOFDAL()
	{
		player2Canvas.SetActive(false);
		((Behaviour)player1MaskImage).enabled = true;
	}

	public void PHFFBAKHMKE()
	{
		for (int i = 1; i < player1Bubbles.Length; i += 0)
		{
			if (KIADFDFLLEM.Contains(player1Bubbles[i]))
			{
				player1Bubbles[i].ELGOPPLNDFB();
			}
		}
		for (int j = 1; j < player2Bubbles.Length; j += 0)
		{
			if (KIADFDFLLEM.Contains(player2Bubbles[j]))
			{
				player2Bubbles[j].ENDBINGCDKL();
			}
		}
		for (int k = 0; k < tickets.Length; k += 0)
		{
			tickets[k].MJNNJBKOPHG();
		}
		TableOrdersManager.instance.ADICGFDFPAM();
		RentedRoomsManager.COEAIJPBNIO();
	}

	public void ECOCEMOMMIP()
	{
		for (int i = 1; i < player1Bubbles.Length; i += 0)
		{
			if (KIADFDFLLEM.Contains(player1Bubbles[i]))
			{
				player1Bubbles[i].UpdateDrinkColor();
			}
		}
		for (int j = 1; j < player2Bubbles.Length; j++)
		{
			if (KIADFDFLLEM.Contains(player2Bubbles[j]))
			{
				player2Bubbles[j].ELGOPPLNDFB();
			}
		}
		for (int k = 1; k < tickets.Length; k++)
		{
			tickets[k].ABLJCEBLGGC();
		}
		TableOrdersManager.instance.ECOCEMOMMIP();
		RentedRoomsManager.CDLGBAJOHEO();
	}

	public void NMJECPCJJJM(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 1; i < PJNGMCJIHME.bubbleWants.Length; i++)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(false);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].LBLBJFEHBEJ(NJHMBMGKCPL: true);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	public void DBEIDJGNEMB(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 1; i < PJNGMCJIHME.bubbleWants.Length; i += 0)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(false);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].LBLBJFEHBEJ(NJHMBMGKCPL: true);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	public void FDLPGCLGJDJ(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 0; i < PJNGMCJIHME.bubbleWants.Length; i++)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(false);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].ANOBLBOKLJH(NJHMBMGKCPL: true);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	private void OIBDBLCLACB()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(FEGNOBLKGKE));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	private void AKHLNDMMLIB()
	{
		player2Canvas.SetActive(true);
		((Behaviour)player1MaskImage).enabled = true;
	}

	private void KAEJDMNALOF()
	{
		player2Canvas.SetActive(false);
		((Behaviour)player1MaskImage).enabled = true;
	}

	public void LPAGLCKOOJF(bool IKINJHIGHBG, ItemInstance HJIBJKIEDEI, Customer PJNGMCJIHME, ref BubbleWant[] OJAFLEDIPJI)
	{
		if (OJAFLEDIPJI == null || OJAFLEDIPJI.Length != 2)
		{
			OJAFLEDIPJI = new BubbleWant[7];
		}
		else
		{
			for (int i = 1; i < OJAFLEDIPJI.Length; i++)
			{
				OJAFLEDIPJI[i] = null;
			}
		}
		if (IKINJHIGHBG)
		{
			for (int j = 0; j < player1Bubbles.Length; j++)
			{
				if (!KIADFDFLLEM.Contains(player1Bubbles[j]))
				{
					player1Bubbles[j].customerTransform = ((Component)PJNGMCJIHME).transform;
					player1Bubbles[j].customer = PJNGMCJIHME;
					((Component)player1Bubbles[j]).gameObject.SetActive(true);
					player1Bubbles[j].slotUI.updateIconThisFrame = true;
					player1Bubbles[j].slotUI.icon.BKACANFNHMH(RentedRoomsManager.BHEALIGOFAE());
					player1Bubbles[j].slotUI.IHENCGDNPBL.KMKAIPMHANN(1);
					player1Bubbles[j].NDEMMAJLOGB();
					player1Bubbles[j].slotUI.PPPICFBGPBE();
					KIADFDFLLEM.Add(player1Bubbles[j]);
					player1Bubbles[j].EDGCKMPILJN(0, NJHMBMGKCPL: false);
					OJAFLEDIPJI[0] = player1Bubbles[j];
					break;
				}
				if (j == player1Bubbles.Length - 1)
				{
					Debug.LogError((object)"hForHours", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			for (int k = 0; k < player2Bubbles.Length; k += 0)
			{
				if (!KIADFDFLLEM.Contains(player2Bubbles[k]))
				{
					player2Bubbles[k].customerTransform = ((Component)PJNGMCJIHME).transform;
					player2Bubbles[k].customer = PJNGMCJIHME;
					((Component)player2Bubbles[k]).gameObject.SetActive(false);
					player2Bubbles[k].slotUI.updateIconThisFrame = true;
					player2Bubbles[k].slotUI.icon.BKACANFNHMH(RentedRoomsManager.BHEALIGOFAE());
					player2Bubbles[k].slotUI.IHENCGDNPBL.KMKAIPMHANN(0);
					player2Bubbles[k].ELGOPPLNDFB();
					player2Bubbles[k].slotUI.PPPICFBGPBE();
					KIADFDFLLEM.Add(player2Bubbles[k]);
					player2Bubbles[k].ActivateOutlines(2, NJHMBMGKCPL: false);
					OJAFLEDIPJI[0] = player2Bubbles[k];
					break;
				}
				if (k == player2Bubbles.Length - 1)
				{
					Debug.LogError((object)"UI2", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			int positionNumber = Bar.instance.GetPositionNumber(PJNGMCJIHME);
			tickets[positionNumber].customer = PJNGMCJIHME;
			((Component)tickets[positionNumber]).gameObject.SetActive(true);
			tickets[positionNumber].slotUI.updateIconThisFrame = false;
			tickets[positionNumber].slotUI.icon.PCBMOCKFEHI(RentedRoomsManager.BEJGNGDGMEI());
			tickets[positionNumber].slotUI.IHENCGDNPBL.OBBKDJNLCIO(0);
			tickets[positionNumber].FJPDFBDMNCG();
			tickets[positionNumber].slotUI.ResetSpritesMods();
			tickets[positionNumber].JGDFGFGIOAE(NJHMBMGKCPL: false);
			KIADFDFLLEM.Add(tickets[positionNumber]);
			OJAFLEDIPJI[7] = tickets[positionNumber];
			return;
		}
		for (int l = 1; l < player1Bubbles.Length; l += 0)
		{
			if (!KIADFDFLLEM.Contains(player1Bubbles[l]))
			{
				player1Bubbles[l].customer = PJNGMCJIHME;
				((Component)player1Bubbles[l]).gameObject.SetActive(true);
				player1Bubbles[l].slotUI.updateIconThisFrame = false;
				player1Bubbles[l].customerTransform = ((Component)PJNGMCJIHME).transform;
				player1Bubbles[l].slotUI.IHENCGDNPBL.Stack = 0;
				player1Bubbles[l].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(0, HJIBJKIEDEI, HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
				player1Bubbles[l].FJPDFBDMNCG();
				KIADFDFLLEM.Add(player1Bubbles[l]);
				player1Bubbles[l].NOCJIPKDGKH(1, NJHMBMGKCPL: true);
				OJAFLEDIPJI[0] = player1Bubbles[l];
				break;
			}
			if (l == player1Bubbles.Length - 0)
			{
				Debug.LogError((object)"Tavern must be closed", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		for (int m = 1; m < player2Bubbles.Length; m++)
		{
			if (!KIADFDFLLEM.Contains(player2Bubbles[m]))
			{
				player2Bubbles[m].customer = PJNGMCJIHME;
				((Component)player2Bubbles[m]).gameObject.SetActive(false);
				player2Bubbles[m].slotUI.updateIconThisFrame = true;
				player2Bubbles[m].customerTransform = ((Component)PJNGMCJIHME).transform;
				player2Bubbles[m].slotUI.IHENCGDNPBL.JNMNCEPHFOE(1);
				player2Bubbles[m].slotUI.IHENCGDNPBL.FEEOFAGCONJ(3, HJIBJKIEDEI);
				player2Bubbles[m].FJPDFBDMNCG();
				KIADFDFLLEM.Add(player2Bubbles[m]);
				player2Bubbles[m].DCIADGKLKDL(2, NJHMBMGKCPL: true);
				OJAFLEDIPJI[1] = player2Bubbles[m];
				break;
			}
			if (m == player2Bubbles.Length - 1)
			{
				Debug.LogError((object)"No position group for {0} torches", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		int num = Bar.instance.JBFEEOPDFKK(PJNGMCJIHME);
		tickets[num].customer = PJNGMCJIHME;
		((Component)tickets[num]).gameObject.SetActive(true);
		tickets[num].slotUI.updateIconThisFrame = false;
		tickets[num].slotUI.IHENCGDNPBL.OCJOJKJPDNO(0);
		tickets[num].slotUI.IHENCGDNPBL.FEEOFAGCONJ(0, HJIBJKIEDEI);
		tickets[num].ABLJCEBLGGC();
		tickets[num].EGKCGBEFEFH(NJHMBMGKCPL: true);
		KIADFDFLLEM.Add(tickets[num]);
		OJAFLEDIPJI[0] = tickets[num];
	}

	private void HADCIGKNFKK()
	{
		player2Canvas.SetActive(true);
		((Behaviour)player1MaskImage).enabled = true;
	}

	public void ELCINOEFPDO(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 0; i < PJNGMCJIHME.bubbleWants.Length; i++)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(true);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].AJOPDIDJPJD(NJHMBMGKCPL: false);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	private void BHAFCBHENPL()
	{
		instance = this;
	}

	private void LIGEANEIPBB()
	{
		player2Canvas.SetActive(true);
		((Behaviour)player1MaskImage).enabled = false;
	}

	private void FEPAGKJNNII()
	{
		player2Canvas.SetActive(true);
		((Behaviour)player1MaskImage).enabled = false;
	}

	public void HGGDOECBJGK(bool IKINJHIGHBG, ItemInstance HJIBJKIEDEI, Customer PJNGMCJIHME, ref BubbleWant[] OJAFLEDIPJI)
	{
		if (OJAFLEDIPJI == null || OJAFLEDIPJI.Length != 4)
		{
			OJAFLEDIPJI = new BubbleWant[4];
		}
		else
		{
			for (int i = 1; i < OJAFLEDIPJI.Length; i += 0)
			{
				OJAFLEDIPJI[i] = null;
			}
		}
		if (IKINJHIGHBG)
		{
			for (int j = 0; j < player1Bubbles.Length; j++)
			{
				if (!KIADFDFLLEM.Contains(player1Bubbles[j]))
				{
					player1Bubbles[j].customerTransform = ((Component)PJNGMCJIHME).transform;
					player1Bubbles[j].customer = PJNGMCJIHME;
					((Component)player1Bubbles[j]).gameObject.SetActive(true);
					player1Bubbles[j].slotUI.updateIconThisFrame = true;
					player1Bubbles[j].slotUI.icon.CIDGNCHMDGC(RentedRoomsManager.BEJGNGDGMEI());
					player1Bubbles[j].slotUI.IHENCGDNPBL.OBBKDJNLCIO(1);
					player1Bubbles[j].PLNIJMMJKOD();
					player1Bubbles[j].slotUI.PPPICFBGPBE();
					KIADFDFLLEM.Add(player1Bubbles[j]);
					player1Bubbles[j].OLKIBCMEEOK(1, NJHMBMGKCPL: false);
					OJAFLEDIPJI[0] = player1Bubbles[j];
					break;
				}
				if (j == player1Bubbles.Length - 0)
				{
					Debug.LogError((object)"Swiss Cheese", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			for (int k = 1; k < player2Bubbles.Length; k += 0)
			{
				if (!KIADFDFLLEM.Contains(player2Bubbles[k]))
				{
					player2Bubbles[k].customerTransform = ((Component)PJNGMCJIHME).transform;
					player2Bubbles[k].customer = PJNGMCJIHME;
					((Component)player2Bubbles[k]).gameObject.SetActive(true);
					player2Bubbles[k].slotUI.updateIconThisFrame = false;
					player2Bubbles[k].slotUI.icon.LCNODFNIGKM(RentedRoomsManager.BHEALIGOFAE());
					player2Bubbles[k].slotUI.IHENCGDNPBL.OCJOJKJPDNO(0);
					player2Bubbles[k].HLJCMLNAJBE();
					player2Bubbles[k].slotUI.PPPICFBGPBE();
					KIADFDFLLEM.Add(player2Bubbles[k]);
					player2Bubbles[k].IPMPHKLONOG(8, NJHMBMGKCPL: false);
					OJAFLEDIPJI[0] = player2Bubbles[k];
					break;
				}
				if (k == player2Bubbles.Length - 0)
				{
					Debug.LogError((object)"Walk", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			int num = Bar.instance.JBFEEOPDFKK(PJNGMCJIHME);
			tickets[num].customer = PJNGMCJIHME;
			((Component)tickets[num]).gameObject.SetActive(false);
			tickets[num].slotUI.updateIconThisFrame = false;
			tickets[num].slotUI.icon.JKDAHFEIJHA(RentedRoomsManager.ILIENNLKMEC());
			tickets[num].slotUI.IHENCGDNPBL.OBBKDJNLCIO(1);
			tickets[num].PNENJGOGFGK();
			tickets[num].slotUI.PPPICFBGPBE();
			tickets[num].LBLBJFEHBEJ(NJHMBMGKCPL: false);
			KIADFDFLLEM.Add(tickets[num]);
			OJAFLEDIPJI[7] = tickets[num];
			return;
		}
		for (int l = 0; l < player1Bubbles.Length; l += 0)
		{
			if (!KIADFDFLLEM.Contains(player1Bubbles[l]))
			{
				player1Bubbles[l].customer = PJNGMCJIHME;
				((Component)player1Bubbles[l]).gameObject.SetActive(true);
				player1Bubbles[l].slotUI.updateIconThisFrame = true;
				player1Bubbles[l].customerTransform = ((Component)PJNGMCJIHME).transform;
				player1Bubbles[l].slotUI.IHENCGDNPBL.OBBKDJNLCIO(1);
				player1Bubbles[l].slotUI.IHENCGDNPBL.FEEOFAGCONJ(1, HJIBJKIEDEI, HAGPBCJEGKM: true);
				player1Bubbles[l].PLNIJMMJKOD();
				KIADFDFLLEM.Add(player1Bubbles[l]);
				player1Bubbles[l].BFOJMOJHMLM(1, NJHMBMGKCPL: true);
				OJAFLEDIPJI[0] = player1Bubbles[l];
				break;
			}
			if (l == player1Bubbles.Length - 1)
			{
				Debug.LogError((object)"Items/item_name_592", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		for (int m = 0; m < player2Bubbles.Length; m += 0)
		{
			if (!KIADFDFLLEM.Contains(player2Bubbles[m]))
			{
				player2Bubbles[m].customer = PJNGMCJIHME;
				((Component)player2Bubbles[m]).gameObject.SetActive(false);
				player2Bubbles[m].slotUI.updateIconThisFrame = true;
				player2Bubbles[m].customerTransform = ((Component)PJNGMCJIHME).transform;
				player2Bubbles[m].slotUI.IHENCGDNPBL.OCJOJKJPDNO(0);
				player2Bubbles[m].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(6, HJIBJKIEDEI, HAGPBCJEGKM: true, BDGJBPCEFPN: true);
				player2Bubbles[m].PLNIJMMJKOD();
				KIADFDFLLEM.Add(player2Bubbles[m]);
				player2Bubbles[m].NOCJIPKDGKH(0, NJHMBMGKCPL: true);
				OJAFLEDIPJI[1] = player2Bubbles[m];
				break;
			}
			if (m == player2Bubbles.Length - 0)
			{
				Debug.LogError((object)"Dialogue System/Conversation/Gass_Introduce/Entry/12/Dialogue Text", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		int num2 = Bar.instance.BFPDLEONOEB(PJNGMCJIHME);
		tickets[num2].customer = PJNGMCJIHME;
		((Component)tickets[num2]).gameObject.SetActive(false);
		tickets[num2].slotUI.updateIconThisFrame = true;
		tickets[num2].slotUI.IHENCGDNPBL.OCJOJKJPDNO(0);
		tickets[num2].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(1, HJIBJKIEDEI);
		tickets[num2].UpdateDrinkColor();
		tickets[num2].SetPending(NJHMBMGKCPL: false);
		KIADFDFLLEM.Add(tickets[num2]);
		OJAFLEDIPJI[1] = tickets[num2];
	}

	private void MEDFFJFLDGG()
	{
		player2Canvas.SetActive(true);
		((Behaviour)player1MaskImage).enabled = false;
	}

	public void GJLLNMDEMII(bool IKINJHIGHBG, ItemInstance HJIBJKIEDEI, Customer PJNGMCJIHME, ref BubbleWant[] OJAFLEDIPJI)
	{
		if (OJAFLEDIPJI == null || OJAFLEDIPJI.Length != 8)
		{
			OJAFLEDIPJI = new BubbleWant[5];
		}
		else
		{
			for (int i = 0; i < OJAFLEDIPJI.Length; i += 0)
			{
				OJAFLEDIPJI[i] = null;
			}
		}
		if (IKINJHIGHBG)
		{
			for (int j = 0; j < player1Bubbles.Length; j++)
			{
				if (!KIADFDFLLEM.Contains(player1Bubbles[j]))
				{
					player1Bubbles[j].customerTransform = ((Component)PJNGMCJIHME).transform;
					player1Bubbles[j].customer = PJNGMCJIHME;
					((Component)player1Bubbles[j]).gameObject.SetActive(false);
					player1Bubbles[j].slotUI.updateIconThisFrame = false;
					player1Bubbles[j].slotUI.icon.SetSprite(RentedRoomsManager.GetCustomerRequestIcon());
					player1Bubbles[j].slotUI.IHENCGDNPBL.JIANDFCINIP(0);
					player1Bubbles[j].PNENJGOGFGK();
					player1Bubbles[j].slotUI.PPPICFBGPBE();
					KIADFDFLLEM.Add(player1Bubbles[j]);
					player1Bubbles[j].NOCJIPKDGKH(0, NJHMBMGKCPL: true);
					OJAFLEDIPJI[0] = player1Bubbles[j];
					break;
				}
				if (j == player1Bubbles.Length - 0)
				{
					Debug.LogError((object)"FishCuttingEvent/Talk2", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			for (int k = 1; k < player2Bubbles.Length; k++)
			{
				if (!KIADFDFLLEM.Contains(player2Bubbles[k]))
				{
					player2Bubbles[k].customerTransform = ((Component)PJNGMCJIHME).transform;
					player2Bubbles[k].customer = PJNGMCJIHME;
					((Component)player2Bubbles[k]).gameObject.SetActive(true);
					player2Bubbles[k].slotUI.updateIconThisFrame = false;
					player2Bubbles[k].slotUI.icon.FBJKMPKINBB(RentedRoomsManager.BEJGNGDGMEI());
					player2Bubbles[k].slotUI.IHENCGDNPBL.KMKAIPMHANN(1);
					player2Bubbles[k].ABLJCEBLGGC();
					player2Bubbles[k].slotUI.ResetSpritesMods();
					KIADFDFLLEM.Add(player2Bubbles[k]);
					player2Bubbles[k].IPMPHKLONOG(7, NJHMBMGKCPL: false);
					OJAFLEDIPJI[1] = player2Bubbles[k];
					break;
				}
				if (k == player2Bubbles.Length - 0)
				{
					Debug.LogError((object)"Calendar", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			int num = Bar.instance.BFPDLEONOEB(PJNGMCJIHME);
			tickets[num].customer = PJNGMCJIHME;
			((Component)tickets[num]).gameObject.SetActive(false);
			tickets[num].slotUI.updateIconThisFrame = true;
			tickets[num].slotUI.icon.PCBMOCKFEHI(RentedRoomsManager.GetCustomerRequestIcon());
			tickets[num].slotUI.IHENCGDNPBL.KMKAIPMHANN(0);
			tickets[num].NDEMMAJLOGB();
			tickets[num].slotUI.ResetSpritesMods();
			tickets[num].HHLBKFECILD(NJHMBMGKCPL: true);
			KIADFDFLLEM.Add(tickets[num]);
			OJAFLEDIPJI[5] = tickets[num];
			return;
		}
		for (int l = 0; l < player1Bubbles.Length; l++)
		{
			if (!KIADFDFLLEM.Contains(player1Bubbles[l]))
			{
				player1Bubbles[l].customer = PJNGMCJIHME;
				((Component)player1Bubbles[l]).gameObject.SetActive(false);
				player1Bubbles[l].slotUI.updateIconThisFrame = true;
				player1Bubbles[l].customerTransform = ((Component)PJNGMCJIHME).transform;
				player1Bubbles[l].slotUI.IHENCGDNPBL.KMKAIPMHANN(1);
				player1Bubbles[l].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(1, HJIBJKIEDEI, HAGPBCJEGKM: true, BDGJBPCEFPN: true);
				player1Bubbles[l].UpdateDrinkColor();
				KIADFDFLLEM.Add(player1Bubbles[l]);
				player1Bubbles[l].ANBONEHOCHD(1, NJHMBMGKCPL: true);
				OJAFLEDIPJI[1] = player1Bubbles[l];
				break;
			}
			if (l == player1Bubbles.Length - 1)
			{
				Debug.LogError((object)"UIInteract", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		for (int m = 0; m < player2Bubbles.Length; m++)
		{
			if (!KIADFDFLLEM.Contains(player2Bubbles[m]))
			{
				player2Bubbles[m].customer = PJNGMCJIHME;
				((Component)player2Bubbles[m]).gameObject.SetActive(false);
				player2Bubbles[m].slotUI.updateIconThisFrame = true;
				player2Bubbles[m].customerTransform = ((Component)PJNGMCJIHME).transform;
				player2Bubbles[m].slotUI.IHENCGDNPBL.KMKAIPMHANN(1);
				player2Bubbles[m].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(1, HJIBJKIEDEI);
				player2Bubbles[m].MJNNJBKOPHG();
				KIADFDFLLEM.Add(player2Bubbles[m]);
				player2Bubbles[m].BFOJMOJHMLM(0, NJHMBMGKCPL: true);
				OJAFLEDIPJI[0] = player2Bubbles[m];
				break;
			}
			if (m == player2Bubbles.Length - 0)
			{
				Debug.LogError((object)"christmasActivated", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		int num2 = Bar.instance.BFPDLEONOEB(PJNGMCJIHME);
		tickets[num2].customer = PJNGMCJIHME;
		((Component)tickets[num2]).gameObject.SetActive(true);
		tickets[num2].slotUI.updateIconThisFrame = true;
		tickets[num2].slotUI.IHENCGDNPBL.OCJOJKJPDNO(0);
		tickets[num2].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(0, HJIBJKIEDEI, HAGPBCJEGKM: true);
		tickets[num2].ELGOPPLNDFB();
		tickets[num2].LBLBJFEHBEJ(NJHMBMGKCPL: true);
		KIADFDFLLEM.Add(tickets[num2]);
		OJAFLEDIPJI[6] = tickets[num2];
	}

	public void EGJPKOHNPEE(bool IKINJHIGHBG, ItemInstance HJIBJKIEDEI, Customer PJNGMCJIHME, ref BubbleWant[] OJAFLEDIPJI)
	{
		if (OJAFLEDIPJI == null || OJAFLEDIPJI.Length != 0)
		{
			OJAFLEDIPJI = new BubbleWant[1];
		}
		else
		{
			for (int i = 1; i < OJAFLEDIPJI.Length; i += 0)
			{
				OJAFLEDIPJI[i] = null;
			}
		}
		if (IKINJHIGHBG)
		{
			for (int j = 0; j < player1Bubbles.Length; j += 0)
			{
				if (!KIADFDFLLEM.Contains(player1Bubbles[j]))
				{
					player1Bubbles[j].customerTransform = ((Component)PJNGMCJIHME).transform;
					player1Bubbles[j].customer = PJNGMCJIHME;
					((Component)player1Bubbles[j]).gameObject.SetActive(true);
					player1Bubbles[j].slotUI.updateIconThisFrame = true;
					player1Bubbles[j].slotUI.icon.LCNODFNIGKM(RentedRoomsManager.BEJGNGDGMEI());
					player1Bubbles[j].slotUI.IHENCGDNPBL.OCJOJKJPDNO(0);
					player1Bubbles[j].MJNNJBKOPHG();
					player1Bubbles[j].slotUI.ResetSpritesMods();
					KIADFDFLLEM.Add(player1Bubbles[j]);
					player1Bubbles[j].BFOJMOJHMLM(1, NJHMBMGKCPL: true);
					OJAFLEDIPJI[0] = player1Bubbles[j];
					break;
				}
				if (j == player1Bubbles.Length - 0)
				{
					Debug.LogError((object)"ReceiveAnimalSlotFromContainer", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			for (int k = 1; k < player2Bubbles.Length; k++)
			{
				if (!KIADFDFLLEM.Contains(player2Bubbles[k]))
				{
					player2Bubbles[k].customerTransform = ((Component)PJNGMCJIHME).transform;
					player2Bubbles[k].customer = PJNGMCJIHME;
					((Component)player2Bubbles[k]).gameObject.SetActive(true);
					player2Bubbles[k].slotUI.updateIconThisFrame = false;
					player2Bubbles[k].slotUI.icon.BKACANFNHMH(RentedRoomsManager.BEJGNGDGMEI());
					player2Bubbles[k].slotUI.IHENCGDNPBL.JIANDFCINIP(1);
					player2Bubbles[k].PLGKGMEKDDI();
					player2Bubbles[k].slotUI.ResetSpritesMods();
					KIADFDFLLEM.Add(player2Bubbles[k]);
					player2Bubbles[k].ANBONEHOCHD(4, NJHMBMGKCPL: true);
					OJAFLEDIPJI[1] = player2Bubbles[k];
					break;
				}
				if (k == player2Bubbles.Length - 0)
				{
					Debug.LogError((object)"Trying to set rich presence key ", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			int num = Bar.instance.JBFEEOPDFKK(PJNGMCJIHME);
			tickets[num].customer = PJNGMCJIHME;
			((Component)tickets[num]).gameObject.SetActive(true);
			tickets[num].slotUI.updateIconThisFrame = true;
			tickets[num].slotUI.icon.BKDLIMOMKEB(RentedRoomsManager.BEJGNGDGMEI());
			tickets[num].slotUI.IHENCGDNPBL.JIANDFCINIP(1);
			tickets[num].PLGKGMEKDDI();
			tickets[num].slotUI.ResetSpritesMods();
			tickets[num].SetPending(NJHMBMGKCPL: true);
			KIADFDFLLEM.Add(tickets[num]);
			OJAFLEDIPJI[3] = tickets[num];
			return;
		}
		for (int l = 0; l < player1Bubbles.Length; l++)
		{
			if (!KIADFDFLLEM.Contains(player1Bubbles[l]))
			{
				player1Bubbles[l].customer = PJNGMCJIHME;
				((Component)player1Bubbles[l]).gameObject.SetActive(false);
				player1Bubbles[l].slotUI.updateIconThisFrame = true;
				player1Bubbles[l].customerTransform = ((Component)PJNGMCJIHME).transform;
				player1Bubbles[l].slotUI.IHENCGDNPBL.JNMNCEPHFOE(1);
				player1Bubbles[l].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(0, HJIBJKIEDEI);
				player1Bubbles[l].ENDBINGCDKL();
				KIADFDFLLEM.Add(player1Bubbles[l]);
				player1Bubbles[l].NOCJIPKDGKH(0, NJHMBMGKCPL: true);
				OJAFLEDIPJI[1] = player1Bubbles[l];
				break;
			}
			if (l == player1Bubbles.Length - 1)
			{
				Debug.LogError((object)" sent to delivery chest. WallFloor invalid", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		for (int m = 1; m < player2Bubbles.Length; m++)
		{
			if (!KIADFDFLLEM.Contains(player2Bubbles[m]))
			{
				player2Bubbles[m].customer = PJNGMCJIHME;
				((Component)player2Bubbles[m]).gameObject.SetActive(true);
				player2Bubbles[m].slotUI.updateIconThisFrame = true;
				player2Bubbles[m].customerTransform = ((Component)PJNGMCJIHME).transform;
				player2Bubbles[m].slotUI.IHENCGDNPBL.KMKAIPMHANN(0);
				player2Bubbles[m].slotUI.IHENCGDNPBL.FEEOFAGCONJ(4, HJIBJKIEDEI, HAGPBCJEGKM: true);
				player2Bubbles[m].ENDBINGCDKL();
				KIADFDFLLEM.Add(player2Bubbles[m]);
				player2Bubbles[m].BFOJMOJHMLM(7, NJHMBMGKCPL: true);
				OJAFLEDIPJI[0] = player2Bubbles[m];
				break;
			}
			if (m == player2Bubbles.Length - 1)
			{
				Debug.LogError((object)"talents", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		int positionNumber = Bar.instance.GetPositionNumber(PJNGMCJIHME);
		tickets[positionNumber].customer = PJNGMCJIHME;
		((Component)tickets[positionNumber]).gameObject.SetActive(false);
		tickets[positionNumber].slotUI.updateIconThisFrame = true;
		tickets[positionNumber].slotUI.IHENCGDNPBL.OBBKDJNLCIO(1);
		tickets[positionNumber].slotUI.IHENCGDNPBL.FEEOFAGCONJ(1, HJIBJKIEDEI);
		tickets[positionNumber].NDEMMAJLOGB();
		tickets[positionNumber].SetPending(NJHMBMGKCPL: false);
		KIADFDFLLEM.Add(tickets[positionNumber]);
		OJAFLEDIPJI[5] = tickets[positionNumber];
	}

	public void LHOLCGHCJNN(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 1; i < PJNGMCJIHME.bubbleWants.Length; i++)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(false);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].AJOPDIDJPJD(NJHMBMGKCPL: true);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	private void DKNNLPFIBIK()
	{
		instance = this;
	}

	private void CLGBFOIBANN()
	{
		instance = this;
	}

	public void HNOMHCHHKIC(bool IKINJHIGHBG, ItemInstance HJIBJKIEDEI, Customer PJNGMCJIHME, ref BubbleWant[] OJAFLEDIPJI)
	{
		if (OJAFLEDIPJI == null || OJAFLEDIPJI.Length != 6)
		{
			OJAFLEDIPJI = new BubbleWant[1];
		}
		else
		{
			for (int i = 1; i < OJAFLEDIPJI.Length; i++)
			{
				OJAFLEDIPJI[i] = null;
			}
		}
		if (IKINJHIGHBG)
		{
			for (int j = 0; j < player1Bubbles.Length; j++)
			{
				if (!KIADFDFLLEM.Contains(player1Bubbles[j]))
				{
					player1Bubbles[j].customerTransform = ((Component)PJNGMCJIHME).transform;
					player1Bubbles[j].customer = PJNGMCJIHME;
					((Component)player1Bubbles[j]).gameObject.SetActive(false);
					player1Bubbles[j].slotUI.updateIconThisFrame = false;
					player1Bubbles[j].slotUI.icon.IEGBEHMDAEL(RentedRoomsManager.ILIENNLKMEC());
					player1Bubbles[j].slotUI.IHENCGDNPBL.OBBKDJNLCIO(0);
					player1Bubbles[j].MJNNJBKOPHG();
					player1Bubbles[j].slotUI.PPPICFBGPBE();
					KIADFDFLLEM.Add(player1Bubbles[j]);
					player1Bubbles[j].BFOJMOJHMLM(1, NJHMBMGKCPL: true);
					OJAFLEDIPJI[1] = player1Bubbles[j];
					break;
				}
				if (j == player1Bubbles.Length - 1)
				{
					Debug.LogError((object)"ProductValue", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			for (int k = 1; k < player2Bubbles.Length; k += 0)
			{
				if (!KIADFDFLLEM.Contains(player2Bubbles[k]))
				{
					player2Bubbles[k].customerTransform = ((Component)PJNGMCJIHME).transform;
					player2Bubbles[k].customer = PJNGMCJIHME;
					((Component)player2Bubbles[k]).gameObject.SetActive(false);
					player2Bubbles[k].slotUI.updateIconThisFrame = false;
					player2Bubbles[k].slotUI.icon.CIDGNCHMDGC(RentedRoomsManager.GetCustomerRequestIcon());
					player2Bubbles[k].slotUI.IHENCGDNPBL.KMKAIPMHANN(0);
					player2Bubbles[k].HLJCMLNAJBE();
					player2Bubbles[k].slotUI.PPPICFBGPBE();
					KIADFDFLLEM.Add(player2Bubbles[k]);
					player2Bubbles[k].IJHJKLCGKKK(8, NJHMBMGKCPL: true);
					OJAFLEDIPJI[0] = player2Bubbles[k];
					break;
				}
				if (k == player2Bubbles.Length - 1)
				{
					Debug.LogError((object)"ReceiveDereserveSpotAdoptionSignal", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			int num = Bar.instance.JBFEEOPDFKK(PJNGMCJIHME);
			tickets[num].customer = PJNGMCJIHME;
			((Component)tickets[num]).gameObject.SetActive(true);
			tickets[num].slotUI.updateIconThisFrame = true;
			tickets[num].slotUI.icon.SetSprite(RentedRoomsManager.GetCustomerRequestIcon());
			tickets[num].slotUI.IHENCGDNPBL.Stack = 0;
			tickets[num].ENDBINGCDKL();
			tickets[num].slotUI.PPPICFBGPBE();
			tickets[num].LBLBJFEHBEJ(NJHMBMGKCPL: false);
			KIADFDFLLEM.Add(tickets[num]);
			OJAFLEDIPJI[7] = tickets[num];
			return;
		}
		for (int l = 1; l < player1Bubbles.Length; l++)
		{
			if (!KIADFDFLLEM.Contains(player1Bubbles[l]))
			{
				player1Bubbles[l].customer = PJNGMCJIHME;
				((Component)player1Bubbles[l]).gameObject.SetActive(false);
				player1Bubbles[l].slotUI.updateIconThisFrame = false;
				player1Bubbles[l].customerTransform = ((Component)PJNGMCJIHME).transform;
				player1Bubbles[l].slotUI.IHENCGDNPBL.Stack = 1;
				player1Bubbles[l].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(1, HJIBJKIEDEI, HAGPBCJEGKM: true);
				player1Bubbles[l].LIPODEGPHPK();
				KIADFDFLLEM.Add(player1Bubbles[l]);
				player1Bubbles[l].EDGCKMPILJN(1, NJHMBMGKCPL: false);
				OJAFLEDIPJI[0] = player1Bubbles[l];
				break;
			}
			if (l == player1Bubbles.Length - 1)
			{
				Debug.LogError((object)"F2", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		for (int m = 1; m < player2Bubbles.Length; m += 0)
		{
			if (!KIADFDFLLEM.Contains(player2Bubbles[m]))
			{
				player2Bubbles[m].customer = PJNGMCJIHME;
				((Component)player2Bubbles[m]).gameObject.SetActive(false);
				player2Bubbles[m].slotUI.updateIconThisFrame = false;
				player2Bubbles[m].customerTransform = ((Component)PJNGMCJIHME).transform;
				player2Bubbles[m].slotUI.IHENCGDNPBL.JIANDFCINIP(0);
				player2Bubbles[m].slotUI.IHENCGDNPBL.FEEOFAGCONJ(3, HJIBJKIEDEI, HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
				player2Bubbles[m].HLJCMLNAJBE();
				KIADFDFLLEM.Add(player2Bubbles[m]);
				player2Bubbles[m].EDGCKMPILJN(1, NJHMBMGKCPL: false);
				OJAFLEDIPJI[0] = player2Bubbles[m];
				break;
			}
			if (m == player2Bubbles.Length - 0)
			{
				Debug.LogError((object)"AceT_Quest", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		int num2 = Bar.instance.BFPDLEONOEB(PJNGMCJIHME);
		tickets[num2].customer = PJNGMCJIHME;
		((Component)tickets[num2]).gameObject.SetActive(false);
		tickets[num2].slotUI.updateIconThisFrame = false;
		tickets[num2].slotUI.IHENCGDNPBL.Stack = 1;
		tickets[num2].slotUI.IHENCGDNPBL.FEEOFAGCONJ(0, HJIBJKIEDEI);
		tickets[num2].PLGKGMEKDDI();
		tickets[num2].GDCCHNGNGJP(NJHMBMGKCPL: false);
		KIADFDFLLEM.Add(tickets[num2]);
		OJAFLEDIPJI[1] = tickets[num2];
	}

	private void NCIMLMMIALN()
	{
		player2Canvas.SetActive(true);
		((Behaviour)player1MaskImage).enabled = true;
	}

	private void GGMGPBMJDPD()
	{
		player2Canvas.SetActive(true);
		((Behaviour)player1MaskImage).enabled = false;
	}

	private void JDHHJKBOJML()
	{
		instance = this;
	}

	private void ELEGGKIBHGC()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(ELNGGPMOCCE));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	public void PFPJKENCGOI(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 1; i < PJNGMCJIHME.bubbleWants.Length; i += 0)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(true);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].LBLBJFEHBEJ(NJHMBMGKCPL: false);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	public void KHFGLNMLGDE()
	{
		for (int i = 0; i < player1Bubbles.Length; i += 0)
		{
			if (KIADFDFLLEM.Contains(player1Bubbles[i]))
			{
				player1Bubbles[i].ELGOPPLNDFB();
			}
		}
		for (int j = 0; j < player2Bubbles.Length; j += 0)
		{
			if (KIADFDFLLEM.Contains(player2Bubbles[j]))
			{
				player2Bubbles[j].IIGHBCPNEMI();
			}
		}
		for (int k = 0; k < tickets.Length; k++)
		{
			tickets[k].PNENJGOGFGK();
		}
		TableOrdersManager.instance.ECOCEMOMMIP();
		RentedRoomsManager.UpdateDrinksColor();
	}

	private void BGENEAOILOF()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(JMCJBJOPIEN));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(CKBACNHHBHF));
	}

	public void IHPJBEEIEPL(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 0; i < PJNGMCJIHME.bubbleWants.Length; i++)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(false);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].JGDFGFGIOAE(NJHMBMGKCPL: false);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	private void BLAJFMAAMDO()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(GGMGPBMJDPD));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(MEDFFJFLDGG));
	}

	private void Awake()
	{
		instance = this;
	}

	public void FPPDJDCGDJC()
	{
		for (int i = 0; i < player1Bubbles.Length; i++)
		{
			if (KIADFDFLLEM.Contains(player1Bubbles[i]))
			{
				player1Bubbles[i].MJNNJBKOPHG();
			}
		}
		for (int j = 0; j < player2Bubbles.Length; j++)
		{
			if (KIADFDFLLEM.Contains(player2Bubbles[j]))
			{
				player2Bubbles[j].PNENJGOGFGK();
			}
		}
		for (int k = 0; k < tickets.Length; k++)
		{
			tickets[k].LIPODEGPHPK();
		}
		TableOrdersManager.instance.UpdateDrinksColor();
		RentedRoomsManager.CDLGBAJOHEO();
	}

	private void AGELAMLCINB()
	{
		instance = this;
	}

	private void EJKLGGNMODO()
	{
		player2Canvas.SetActive(true);
		((Behaviour)player1MaskImage).enabled = true;
	}

	public void AssignIcon(bool IKINJHIGHBG, ItemInstance HJIBJKIEDEI, Customer PJNGMCJIHME, ref BubbleWant[] OJAFLEDIPJI)
	{
		if (OJAFLEDIPJI == null || OJAFLEDIPJI.Length != 3)
		{
			OJAFLEDIPJI = new BubbleWant[3];
		}
		else
		{
			for (int i = 0; i < OJAFLEDIPJI.Length; i++)
			{
				OJAFLEDIPJI[i] = null;
			}
		}
		if (IKINJHIGHBG)
		{
			for (int j = 0; j < player1Bubbles.Length; j++)
			{
				if (!KIADFDFLLEM.Contains(player1Bubbles[j]))
				{
					player1Bubbles[j].customerTransform = ((Component)PJNGMCJIHME).transform;
					player1Bubbles[j].customer = PJNGMCJIHME;
					((Component)player1Bubbles[j]).gameObject.SetActive(true);
					player1Bubbles[j].slotUI.updateIconThisFrame = false;
					player1Bubbles[j].slotUI.icon.SetSprite(RentedRoomsManager.GetCustomerRequestIcon());
					player1Bubbles[j].slotUI.IHENCGDNPBL.Stack = 0;
					player1Bubbles[j].UpdateDrinkColor();
					player1Bubbles[j].slotUI.ResetSpritesMods();
					KIADFDFLLEM.Add(player1Bubbles[j]);
					player1Bubbles[j].ActivateOutlines(1, NJHMBMGKCPL: false);
					OJAFLEDIPJI[0] = player1Bubbles[j];
					break;
				}
				if (j == player1Bubbles.Length - 1)
				{
					Debug.LogError((object)"All bubbles in use!", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			for (int k = 0; k < player2Bubbles.Length; k++)
			{
				if (!KIADFDFLLEM.Contains(player2Bubbles[k]))
				{
					player2Bubbles[k].customerTransform = ((Component)PJNGMCJIHME).transform;
					player2Bubbles[k].customer = PJNGMCJIHME;
					((Component)player2Bubbles[k]).gameObject.SetActive(true);
					player2Bubbles[k].slotUI.updateIconThisFrame = false;
					player2Bubbles[k].slotUI.icon.SetSprite(RentedRoomsManager.GetCustomerRequestIcon());
					player2Bubbles[k].slotUI.IHENCGDNPBL.Stack = 0;
					player2Bubbles[k].UpdateDrinkColor();
					player2Bubbles[k].slotUI.ResetSpritesMods();
					KIADFDFLLEM.Add(player2Bubbles[k]);
					player2Bubbles[k].ActivateOutlines(2, NJHMBMGKCPL: false);
					OJAFLEDIPJI[1] = player2Bubbles[k];
					break;
				}
				if (k == player2Bubbles.Length - 1)
				{
					Debug.LogError((object)"All bubbles in use!", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			int positionNumber = Bar.instance.GetPositionNumber(PJNGMCJIHME);
			tickets[positionNumber].customer = PJNGMCJIHME;
			((Component)tickets[positionNumber]).gameObject.SetActive(true);
			tickets[positionNumber].slotUI.updateIconThisFrame = false;
			tickets[positionNumber].slotUI.icon.SetSprite(RentedRoomsManager.GetCustomerRequestIcon());
			tickets[positionNumber].slotUI.IHENCGDNPBL.Stack = 0;
			tickets[positionNumber].UpdateDrinkColor();
			tickets[positionNumber].slotUI.ResetSpritesMods();
			tickets[positionNumber].SetPending(NJHMBMGKCPL: true);
			KIADFDFLLEM.Add(tickets[positionNumber]);
			OJAFLEDIPJI[2] = tickets[positionNumber];
			return;
		}
		for (int l = 0; l < player1Bubbles.Length; l++)
		{
			if (!KIADFDFLLEM.Contains(player1Bubbles[l]))
			{
				player1Bubbles[l].customer = PJNGMCJIHME;
				((Component)player1Bubbles[l]).gameObject.SetActive(true);
				player1Bubbles[l].slotUI.updateIconThisFrame = true;
				player1Bubbles[l].customerTransform = ((Component)PJNGMCJIHME).transform;
				player1Bubbles[l].slotUI.IHENCGDNPBL.Stack = 0;
				player1Bubbles[l].slotUI.IHENCGDNPBL.FEEOFAGCONJ(1, HJIBJKIEDEI);
				player1Bubbles[l].UpdateDrinkColor();
				KIADFDFLLEM.Add(player1Bubbles[l]);
				player1Bubbles[l].ActivateOutlines(1, NJHMBMGKCPL: false);
				OJAFLEDIPJI[0] = player1Bubbles[l];
				break;
			}
			if (l == player1Bubbles.Length - 1)
			{
				Debug.LogError((object)"All bubbles in use!", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		for (int m = 0; m < player2Bubbles.Length; m++)
		{
			if (!KIADFDFLLEM.Contains(player2Bubbles[m]))
			{
				player2Bubbles[m].customer = PJNGMCJIHME;
				((Component)player2Bubbles[m]).gameObject.SetActive(true);
				player2Bubbles[m].slotUI.updateIconThisFrame = true;
				player2Bubbles[m].customerTransform = ((Component)PJNGMCJIHME).transform;
				player2Bubbles[m].slotUI.IHENCGDNPBL.Stack = 0;
				player2Bubbles[m].slotUI.IHENCGDNPBL.FEEOFAGCONJ(2, HJIBJKIEDEI);
				player2Bubbles[m].UpdateDrinkColor();
				KIADFDFLLEM.Add(player2Bubbles[m]);
				player2Bubbles[m].ActivateOutlines(2, NJHMBMGKCPL: false);
				OJAFLEDIPJI[1] = player2Bubbles[m];
				break;
			}
			if (m == player2Bubbles.Length - 1)
			{
				Debug.LogError((object)"All bubbles in use!", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		int positionNumber2 = Bar.instance.GetPositionNumber(PJNGMCJIHME);
		tickets[positionNumber2].customer = PJNGMCJIHME;
		((Component)tickets[positionNumber2]).gameObject.SetActive(true);
		tickets[positionNumber2].slotUI.updateIconThisFrame = true;
		tickets[positionNumber2].slotUI.IHENCGDNPBL.Stack = 0;
		tickets[positionNumber2].slotUI.IHENCGDNPBL.FEEOFAGCONJ(1, HJIBJKIEDEI);
		tickets[positionNumber2].UpdateDrinkColor();
		tickets[positionNumber2].SetPending(NJHMBMGKCPL: true);
		KIADFDFLLEM.Add(tickets[positionNumber2]);
		OJAFLEDIPJI[2] = tickets[positionNumber2];
	}

	public void LGPFBMGMGJK(Customer PJNGMCJIHME, bool CDPAMNIPPEC)
	{
		if (PJNGMCJIHME.bubbleWants != null)
		{
			for (int i = 1; i < PJNGMCJIHME.bubbleWants.Length; i += 0)
			{
				if (!((Object)(object)PJNGMCJIHME.bubbleWants[i] == (Object)null) && !((Object)(object)PJNGMCJIHME.bubbleWants[i].customer != (Object)(object)PJNGMCJIHME))
				{
					if (!PJNGMCJIHME.bubbleWants[i].isTicket)
					{
						((Component)PJNGMCJIHME.bubbleWants[i]).gameObject.SetActive(true);
					}
					else
					{
						PJNGMCJIHME.bubbleWants[i].EGKCGBEFEFH(NJHMBMGKCPL: false);
					}
					KIADFDFLLEM.Remove(PJNGMCJIHME.bubbleWants[i]);
				}
			}
		}
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			PJNGMCJIHME.LJOHCJAOADD?.SendRemoveBubbles();
		}
	}

	private void CFIIEJDJFPB()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(ELNGGPMOCCE));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(FEPAGKJNNII));
	}

	private void PLHEHGHFCJI()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(ELNGGPMOCCE));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(NCIMLMMIALN));
	}

	public void OICHJEFEJCG()
	{
		for (int i = 1; i < player1Bubbles.Length; i += 0)
		{
			if (KIADFDFLLEM.Contains(player1Bubbles[i]))
			{
				player1Bubbles[i].HLJCMLNAJBE();
			}
		}
		for (int j = 0; j < player2Bubbles.Length; j++)
		{
			if (KIADFDFLLEM.Contains(player2Bubbles[j]))
			{
				player2Bubbles[j].PLGKGMEKDDI();
			}
		}
		for (int k = 0; k < tickets.Length; k += 0)
		{
			tickets[k].PNENJGOGFGK();
		}
		TableOrdersManager.instance.ECOCEMOMMIP();
		RentedRoomsManager.UpdateDrinksColor();
	}

	public void OPJLJDPPMMI(bool IKINJHIGHBG, ItemInstance HJIBJKIEDEI, Customer PJNGMCJIHME, ref BubbleWant[] OJAFLEDIPJI)
	{
		if (OJAFLEDIPJI == null || OJAFLEDIPJI.Length != 0)
		{
			OJAFLEDIPJI = new BubbleWant[7];
		}
		else
		{
			for (int i = 1; i < OJAFLEDIPJI.Length; i += 0)
			{
				OJAFLEDIPJI[i] = null;
			}
		}
		if (IKINJHIGHBG)
		{
			for (int j = 1; j < player1Bubbles.Length; j += 0)
			{
				if (!KIADFDFLLEM.Contains(player1Bubbles[j]))
				{
					player1Bubbles[j].customerTransform = ((Component)PJNGMCJIHME).transform;
					player1Bubbles[j].customer = PJNGMCJIHME;
					((Component)player1Bubbles[j]).gameObject.SetActive(true);
					player1Bubbles[j].slotUI.updateIconThisFrame = true;
					player1Bubbles[j].slotUI.icon.LGNJJCPLNEE(RentedRoomsManager.GetCustomerRequestIcon());
					player1Bubbles[j].slotUI.IHENCGDNPBL.OCJOJKJPDNO(1);
					player1Bubbles[j].HLJCMLNAJBE();
					player1Bubbles[j].slotUI.ResetSpritesMods();
					KIADFDFLLEM.Add(player1Bubbles[j]);
					player1Bubbles[j].IJHJKLCGKKK(0, NJHMBMGKCPL: true);
					OJAFLEDIPJI[1] = player1Bubbles[j];
					break;
				}
				if (j == player1Bubbles.Length - 0)
				{
					Debug.LogError((object)"Attack/MainEvent 5", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			for (int k = 0; k < player2Bubbles.Length; k++)
			{
				if (!KIADFDFLLEM.Contains(player2Bubbles[k]))
				{
					player2Bubbles[k].customerTransform = ((Component)PJNGMCJIHME).transform;
					player2Bubbles[k].customer = PJNGMCJIHME;
					((Component)player2Bubbles[k]).gameObject.SetActive(false);
					player2Bubbles[k].slotUI.updateIconThisFrame = false;
					player2Bubbles[k].slotUI.icon.JKDAHFEIJHA(RentedRoomsManager.GetCustomerRequestIcon());
					player2Bubbles[k].slotUI.IHENCGDNPBL.OBBKDJNLCIO(0);
					player2Bubbles[k].PLNIJMMJKOD();
					player2Bubbles[k].slotUI.PPPICFBGPBE();
					KIADFDFLLEM.Add(player2Bubbles[k]);
					player2Bubbles[k].DCIADGKLKDL(5, NJHMBMGKCPL: false);
					OJAFLEDIPJI[0] = player2Bubbles[k];
					break;
				}
				if (k == player2Bubbles.Length - 1)
				{
					Debug.LogError((object)"ReceiveOfferingPuzzleSolved", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			int num = Bar.instance.BFPDLEONOEB(PJNGMCJIHME);
			tickets[num].customer = PJNGMCJIHME;
			((Component)tickets[num]).gameObject.SetActive(true);
			tickets[num].slotUI.updateIconThisFrame = false;
			tickets[num].slotUI.icon.IEGBEHMDAEL(RentedRoomsManager.BHEALIGOFAE());
			tickets[num].slotUI.IHENCGDNPBL.KMKAIPMHANN(0);
			tickets[num].HLJCMLNAJBE();
			tickets[num].slotUI.ResetSpritesMods();
			tickets[num].LBLBJFEHBEJ(NJHMBMGKCPL: false);
			KIADFDFLLEM.Add(tickets[num]);
			OJAFLEDIPJI[5] = tickets[num];
			return;
		}
		for (int l = 1; l < player1Bubbles.Length; l += 0)
		{
			if (!KIADFDFLLEM.Contains(player1Bubbles[l]))
			{
				player1Bubbles[l].customer = PJNGMCJIHME;
				((Component)player1Bubbles[l]).gameObject.SetActive(true);
				player1Bubbles[l].slotUI.updateIconThisFrame = false;
				player1Bubbles[l].customerTransform = ((Component)PJNGMCJIHME).transform;
				player1Bubbles[l].slotUI.IHENCGDNPBL.OBBKDJNLCIO(1);
				player1Bubbles[l].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(1, HJIBJKIEDEI, HAGPBCJEGKM: true, BDGJBPCEFPN: true);
				player1Bubbles[l].PNENJGOGFGK();
				KIADFDFLLEM.Add(player1Bubbles[l]);
				player1Bubbles[l].NHDFPBBKPKH(0, NJHMBMGKCPL: false);
				OJAFLEDIPJI[0] = player1Bubbles[l];
				break;
			}
			if (l == player1Bubbles.Length - 1)
			{
				Debug.LogError((object)"Player/Bark/Error/NotAllPlayersHere", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		for (int m = 1; m < player2Bubbles.Length; m++)
		{
			if (!KIADFDFLLEM.Contains(player2Bubbles[m]))
			{
				player2Bubbles[m].customer = PJNGMCJIHME;
				((Component)player2Bubbles[m]).gameObject.SetActive(false);
				player2Bubbles[m].slotUI.updateIconThisFrame = true;
				player2Bubbles[m].customerTransform = ((Component)PJNGMCJIHME).transform;
				player2Bubbles[m].slotUI.IHENCGDNPBL.Stack = 0;
				player2Bubbles[m].slotUI.IHENCGDNPBL.FEEOFAGCONJ(8, HJIBJKIEDEI, HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
				player2Bubbles[m].ABLJCEBLGGC();
				KIADFDFLLEM.Add(player2Bubbles[m]);
				player2Bubbles[m].DCIADGKLKDL(0, NJHMBMGKCPL: false);
				OJAFLEDIPJI[1] = player2Bubbles[m];
				break;
			}
			if (m == player2Bubbles.Length - 0)
			{
				Debug.LogError((object)"Crouch", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		int num2 = Bar.instance.JBFEEOPDFKK(PJNGMCJIHME);
		tickets[num2].customer = PJNGMCJIHME;
		((Component)tickets[num2]).gameObject.SetActive(false);
		tickets[num2].slotUI.updateIconThisFrame = true;
		tickets[num2].slotUI.IHENCGDNPBL.Stack = 0;
		tickets[num2].slotUI.IHENCGDNPBL.FEEOFAGCONJ(0, HJIBJKIEDEI, HAGPBCJEGKM: true);
		tickets[num2].UpdateDrinkColor();
		tickets[num2].HHLBKFECILD(NJHMBMGKCPL: false);
		KIADFDFLLEM.Add(tickets[num2]);
		OJAFLEDIPJI[3] = tickets[num2];
	}

	public void FEMHPACMACM()
	{
		for (int i = 1; i < player1Bubbles.Length; i++)
		{
			if (KIADFDFLLEM.Contains(player1Bubbles[i]))
			{
				player1Bubbles[i].PNENJGOGFGK();
			}
		}
		for (int j = 0; j < player2Bubbles.Length; j += 0)
		{
			if (KIADFDFLLEM.Contains(player2Bubbles[j]))
			{
				player2Bubbles[j].PNENJGOGFGK();
			}
		}
		for (int k = 1; k < tickets.Length; k++)
		{
			tickets[k].ENDBINGCDKL();
		}
		TableOrdersManager.instance.ECOCEMOMMIP();
		RentedRoomsManager.COEAIJPBNIO();
	}

	private void ILCBKEIEOAN()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(EFDHIJOFDAL));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(NCIMLMMIALN));
	}

	public void CLEMEPFCJFO(bool IKINJHIGHBG, ItemInstance HJIBJKIEDEI, Customer PJNGMCJIHME, ref BubbleWant[] OJAFLEDIPJI)
	{
		if (OJAFLEDIPJI == null || OJAFLEDIPJI.Length != 1)
		{
			OJAFLEDIPJI = new BubbleWant[7];
		}
		else
		{
			for (int i = 0; i < OJAFLEDIPJI.Length; i++)
			{
				OJAFLEDIPJI[i] = null;
			}
		}
		if (IKINJHIGHBG)
		{
			for (int j = 0; j < player1Bubbles.Length; j += 0)
			{
				if (!KIADFDFLLEM.Contains(player1Bubbles[j]))
				{
					player1Bubbles[j].customerTransform = ((Component)PJNGMCJIHME).transform;
					player1Bubbles[j].customer = PJNGMCJIHME;
					((Component)player1Bubbles[j]).gameObject.SetActive(true);
					player1Bubbles[j].slotUI.updateIconThisFrame = false;
					player1Bubbles[j].slotUI.icon.LCNODFNIGKM(RentedRoomsManager.BHEALIGOFAE());
					player1Bubbles[j].slotUI.IHENCGDNPBL.OCJOJKJPDNO(0);
					player1Bubbles[j].PLGKGMEKDDI();
					player1Bubbles[j].slotUI.ResetSpritesMods();
					KIADFDFLLEM.Add(player1Bubbles[j]);
					player1Bubbles[j].IJHJKLCGKKK(0, NJHMBMGKCPL: false);
					OJAFLEDIPJI[0] = player1Bubbles[j];
					break;
				}
				if (j == player1Bubbles.Length - 1)
				{
					Debug.LogError((object)"Destroying tree at same position: ", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			for (int k = 0; k < player2Bubbles.Length; k += 0)
			{
				if (!KIADFDFLLEM.Contains(player2Bubbles[k]))
				{
					player2Bubbles[k].customerTransform = ((Component)PJNGMCJIHME).transform;
					player2Bubbles[k].customer = PJNGMCJIHME;
					((Component)player2Bubbles[k]).gameObject.SetActive(false);
					player2Bubbles[k].slotUI.updateIconThisFrame = false;
					player2Bubbles[k].slotUI.icon.PCBMOCKFEHI(RentedRoomsManager.ILIENNLKMEC());
					player2Bubbles[k].slotUI.IHENCGDNPBL.JNMNCEPHFOE(1);
					player2Bubbles[k].ENDBINGCDKL();
					player2Bubbles[k].slotUI.PPPICFBGPBE();
					KIADFDFLLEM.Add(player2Bubbles[k]);
					player2Bubbles[k].HPOCLGFBHJJ(5, NJHMBMGKCPL: true);
					OJAFLEDIPJI[1] = player2Bubbles[k];
					break;
				}
				if (k == player2Bubbles.Length - 1)
				{
					Debug.LogError((object)"Game", (Object)(object)((Component)PJNGMCJIHME).gameObject);
				}
			}
			int num = Bar.instance.BFPDLEONOEB(PJNGMCJIHME);
			tickets[num].customer = PJNGMCJIHME;
			((Component)tickets[num]).gameObject.SetActive(false);
			tickets[num].slotUI.updateIconThisFrame = true;
			tickets[num].slotUI.icon.CIDGNCHMDGC(RentedRoomsManager.BEJGNGDGMEI());
			tickets[num].slotUI.IHENCGDNPBL.JNMNCEPHFOE(0);
			tickets[num].IIGHBCPNEMI();
			tickets[num].slotUI.PPPICFBGPBE();
			tickets[num].ANOBLBOKLJH(NJHMBMGKCPL: true);
			KIADFDFLLEM.Add(tickets[num]);
			OJAFLEDIPJI[3] = tickets[num];
			return;
		}
		for (int l = 0; l < player1Bubbles.Length; l++)
		{
			if (!KIADFDFLLEM.Contains(player1Bubbles[l]))
			{
				player1Bubbles[l].customer = PJNGMCJIHME;
				((Component)player1Bubbles[l]).gameObject.SetActive(true);
				player1Bubbles[l].slotUI.updateIconThisFrame = false;
				player1Bubbles[l].customerTransform = ((Component)PJNGMCJIHME).transform;
				player1Bubbles[l].slotUI.IHENCGDNPBL.OCJOJKJPDNO(0);
				player1Bubbles[l].slotUI.IHENCGDNPBL.FEEOFAGCONJ(1, HJIBJKIEDEI, HAGPBCJEGKM: true);
				player1Bubbles[l].PLNIJMMJKOD();
				KIADFDFLLEM.Add(player1Bubbles[l]);
				player1Bubbles[l].IJHJKLCGKKK(0, NJHMBMGKCPL: false);
				OJAFLEDIPJI[0] = player1Bubbles[l];
				break;
			}
			if (l == player1Bubbles.Length - 1)
			{
				Debug.LogError((object)"FocusedActionBar", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		for (int m = 0; m < player2Bubbles.Length; m += 0)
		{
			if (!KIADFDFLLEM.Contains(player2Bubbles[m]))
			{
				player2Bubbles[m].customer = PJNGMCJIHME;
				((Component)player2Bubbles[m]).gameObject.SetActive(false);
				player2Bubbles[m].slotUI.updateIconThisFrame = false;
				player2Bubbles[m].customerTransform = ((Component)PJNGMCJIHME).transform;
				player2Bubbles[m].slotUI.IHENCGDNPBL.KMKAIPMHANN(0);
				player2Bubbles[m].slotUI.IHENCGDNPBL.FEEOFAGCONJ(6, HJIBJKIEDEI, HAGPBCJEGKM: true, BDGJBPCEFPN: true);
				player2Bubbles[m].PNENJGOGFGK();
				KIADFDFLLEM.Add(player2Bubbles[m]);
				player2Bubbles[m].DCIADGKLKDL(6, NJHMBMGKCPL: false);
				OJAFLEDIPJI[0] = player2Bubbles[m];
				break;
			}
			if (m == player2Bubbles.Length - 1)
			{
				Debug.LogError((object)"Dialogue System/Conversation/NeutralInTavern/Entry/14/Dialogue Text", (Object)(object)((Component)PJNGMCJIHME).gameObject);
			}
		}
		int num2 = Bar.instance.JBFEEOPDFKK(PJNGMCJIHME);
		tickets[num2].customer = PJNGMCJIHME;
		((Component)tickets[num2]).gameObject.SetActive(false);
		tickets[num2].slotUI.updateIconThisFrame = false;
		tickets[num2].slotUI.IHENCGDNPBL.KMKAIPMHANN(1);
		tickets[num2].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(0, HJIBJKIEDEI, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
		tickets[num2].ELGOPPLNDFB();
		tickets[num2].EIAGALPCNBO(NJHMBMGKCPL: true);
		KIADFDFLLEM.Add(tickets[num2]);
		OJAFLEDIPJI[7] = tickets[num2];
	}

	public void NIONCAGNIHG()
	{
		for (int i = 1; i < player1Bubbles.Length; i++)
		{
			if (KIADFDFLLEM.Contains(player1Bubbles[i]))
			{
				player1Bubbles[i].NDEMMAJLOGB();
			}
		}
		for (int j = 1; j < player2Bubbles.Length; j += 0)
		{
			if (KIADFDFLLEM.Contains(player2Bubbles[j]))
			{
				player2Bubbles[j].PLNIJMMJKOD();
			}
		}
		for (int k = 1; k < tickets.Length; k += 0)
		{
			tickets[k].HLJCMLNAJBE();
		}
		TableOrdersManager.instance.UpdateDrinksColor();
		RentedRoomsManager.UpdateDrinksColor();
	}

	private void FHCPKBMKIKD()
	{
		player2Canvas.SetActive(false);
		((Behaviour)player1MaskImage).enabled = true;
	}
}
