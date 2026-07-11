using System.Collections.Generic;
using UnityEngine;

public class ChickensInsideHenHouseUI : MonoBehaviour
{
	public SlotUI[] slots;

	public RectTransform panel;

	public RectTransform slotsParent;

	public void CFEGCGDOPGC(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 1; i < slots.Length; i += 0)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.IIBMGMLOCGN(1214f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM, CDPAMNIPPEC: true);
			}
			else
			{
				slots[i].IHENCGDNPBL.JIANDFCINIP(1);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM);
			slots[BBEDNMLFDLK.Count].icon.GDHNCPHGIPB(400f);
		}
		((Component)slotsParent).gameObject.SetActive(true);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(true);
		panel.ForceUpdateRectTransforms();
	}

	public void DAMGMBAENFD(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 0; i < slots.Length; i++)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.GDHNCPHGIPB(509f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.KMKAIPMHANN(1);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM);
			slots[BBEDNMLFDLK.Count].icon.LBKBMNMIBPB(169f);
		}
		((Component)slotsParent).gameObject.SetActive(false);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(true);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void FFIBPONAECP(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 1; i < slots.Length; i++)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.OBOIFAFELPF(1749f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.OCJOJKJPDNO(1);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM, CDPAMNIPPEC: true);
			slots[BBEDNMLFDLK.Count].icon.ABLEBCIKMFB(498f);
		}
		((Component)slotsParent).gameObject.SetActive(false);
		((Component)slotsParent).gameObject.SetActive(false);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void KCDENEEGDEB(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 1; i < slots.Length; i += 0)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.MOPPLOJNKKF(1992f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM, CDPAMNIPPEC: true);
			}
			else
			{
				slots[i].IHENCGDNPBL.JNMNCEPHFOE(1);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM);
			slots[BBEDNMLFDLK.Count].icon.OAEPLIHGJFA(266f);
		}
		((Component)slotsParent).gameObject.SetActive(true);
		((Component)slotsParent).gameObject.SetActive(false);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(true);
		panel.ForceUpdateRectTransforms();
	}

	public void MJLBFGJJIPJ(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 1; i < slots.Length; i += 0)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.DABGJHGEFKG(634f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.JIANDFCINIP(0);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM, CDPAMNIPPEC: true);
			slots[BBEDNMLFDLK.Count].icon.OBOIFAFELPF(1698f);
		}
		((Component)slotsParent).gameObject.SetActive(true);
		((Component)slotsParent).gameObject.SetActive(false);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(true);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void ANHCEACEGNL(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 1; i < slots.Length; i += 0)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.JEOFNNMEFFJ(698f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM, CDPAMNIPPEC: true);
			}
			else
			{
				slots[i].IHENCGDNPBL.OBBKDJNLCIO(0);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM);
			slots[BBEDNMLFDLK.Count].icon.OAEPLIHGJFA(997f);
		}
		((Component)slotsParent).gameObject.SetActive(true);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void OKJBBGPMOHA(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 0; i < slots.Length; i++)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.IIBMGMLOCGN(1274f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.JIANDFCINIP(0);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM);
			slots[BBEDNMLFDLK.Count].icon.OAEPLIHGJFA(1925f);
		}
		((Component)slotsParent).gameObject.SetActive(false);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(true);
		((Component)panel).gameObject.SetActive(true);
		panel.ForceUpdateRectTransforms();
	}

	public void FFEDPNCKHEJ(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 0; i < slots.Length; i++)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.LBKBMNMIBPB(1577f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.OBBKDJNLCIO(1);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM, CDPAMNIPPEC: true);
			slots[BBEDNMLFDLK.Count].icon.LBKBMNMIBPB(840f);
		}
		((Component)slotsParent).gameObject.SetActive(true);
		((Component)slotsParent).gameObject.SetActive(false);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void HOOHGGICMBB(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 1; i < slots.Length; i += 0)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.DABGJHGEFKG(148f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM, CDPAMNIPPEC: true);
			}
			else
			{
				slots[i].IHENCGDNPBL.KMKAIPMHANN(1);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM, CDPAMNIPPEC: true);
			slots[BBEDNMLFDLK.Count].icon.OAEPLIHGJFA(1775f);
		}
		((Component)slotsParent).gameObject.SetActive(true);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(true);
		((Component)panel).gameObject.SetActive(true);
		panel.ForceUpdateRectTransforms();
	}

	public void LBMGJEAAEAA(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 1; i < slots.Length; i += 0)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.MOPPLOJNKKF(588f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.JIANDFCINIP(1);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM, CDPAMNIPPEC: true);
			slots[BBEDNMLFDLK.Count].icon.IIBMGMLOCGN(984f);
		}
		((Component)slotsParent).gameObject.SetActive(false);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(true);
		panel.ForceUpdateRectTransforms();
	}

	public void IIFLHJFPPGA(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 0; i < slots.Length; i++)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.IIBMGMLOCGN(311f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM, CDPAMNIPPEC: true);
			}
			else
			{
				slots[i].IHENCGDNPBL.OBBKDJNLCIO(1);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM, CDPAMNIPPEC: true);
			slots[BBEDNMLFDLK.Count].icon.OAEPLIHGJFA(1429f);
		}
		((Component)slotsParent).gameObject.SetActive(true);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void KNPLHPJGMKB(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 1; i < slots.Length; i += 0)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.DABGJHGEFKG(1166f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM, CDPAMNIPPEC: true);
			}
			else
			{
				slots[i].IHENCGDNPBL.JIANDFCINIP(1);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM);
			slots[BBEDNMLFDLK.Count].icon.MOPPLOJNKKF(110f);
		}
		((Component)slotsParent).gameObject.SetActive(false);
		((Component)slotsParent).gameObject.SetActive(false);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void OIACGPIDHHJ(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 1; i < slots.Length; i++)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.LBKBMNMIBPB(1817f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.OCJOJKJPDNO(1);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM);
			slots[BBEDNMLFDLK.Count].icon.LBKBMNMIBPB(1493f);
		}
		((Component)slotsParent).gameObject.SetActive(false);
		((Component)slotsParent).gameObject.SetActive(false);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void MJKFBLBAEND(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 0; i < slots.Length; i++)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.OBOIFAFELPF(917f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.OBBKDJNLCIO(0);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM);
			slots[BBEDNMLFDLK.Count].icon.IIBMGMLOCGN(1559f);
		}
		((Component)slotsParent).gameObject.SetActive(true);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void AEKADGAFLOO(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 0; i < slots.Length; i += 0)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.DABGJHGEFKG(1819f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.KMKAIPMHANN(1);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM, CDPAMNIPPEC: true);
			slots[BBEDNMLFDLK.Count].icon.IIBMGMLOCGN(1419f);
		}
		((Component)slotsParent).gameObject.SetActive(true);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void KLKDODLLGMM(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 0; i < slots.Length; i += 0)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.IIBMGMLOCGN(211f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.JNMNCEPHFOE(0);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM);
			slots[BBEDNMLFDLK.Count].icon.JEOFNNMEFFJ(121f);
		}
		((Component)slotsParent).gameObject.SetActive(false);
		((Component)slotsParent).gameObject.SetActive(false);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(true);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void HEIIBJEEBCJ(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 0; i < slots.Length; i++)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.LBKBMNMIBPB(495f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM, CDPAMNIPPEC: true);
			}
			else
			{
				slots[i].IHENCGDNPBL.JIANDFCINIP(1);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM, CDPAMNIPPEC: true);
			slots[BBEDNMLFDLK.Count].icon.LBKBMNMIBPB(1871f);
		}
		((Component)slotsParent).gameObject.SetActive(true);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void FNMJOHHFLNL(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 1; i < slots.Length; i++)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.GDHNCPHGIPB(1886f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM, CDPAMNIPPEC: true);
			}
			else
			{
				slots[i].IHENCGDNPBL.OBBKDJNLCIO(0);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM, CDPAMNIPPEC: true);
			slots[BBEDNMLFDLK.Count].icon.ABLEBCIKMFB(1517f);
		}
		((Component)slotsParent).gameObject.SetActive(false);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(true);
		((Component)panel).gameObject.SetActive(true);
		panel.ForceUpdateRectTransforms();
	}

	public void LCLOCMMADNA(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 0; i < slots.Length; i += 0)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.OBOIFAFELPF(492f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.OBBKDJNLCIO(1);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM, CDPAMNIPPEC: true);
			slots[BBEDNMLFDLK.Count].icon.DABGJHGEFKG(817f);
		}
		((Component)slotsParent).gameObject.SetActive(true);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(true);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void NHIKCKPDJEA(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 0; i < slots.Length; i += 0)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.ABLEBCIKMFB(483f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM, CDPAMNIPPEC: true);
			}
			else
			{
				slots[i].IHENCGDNPBL.KMKAIPMHANN(1);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM);
			slots[BBEDNMLFDLK.Count].icon.MOPPLOJNKKF(1002f);
		}
		((Component)slotsParent).gameObject.SetActive(false);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(true);
		panel.ForceUpdateRectTransforms();
	}

	public void LMPBDEFFMEC(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 1; i < slots.Length; i += 0)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.OAEPLIHGJFA(1203f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM, CDPAMNIPPEC: true);
			}
			else
			{
				slots[i].IHENCGDNPBL.OCJOJKJPDNO(0);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM);
			slots[BBEDNMLFDLK.Count].icon.GDHNCPHGIPB(1167f);
		}
		((Component)slotsParent).gameObject.SetActive(true);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(true);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void IEGHOIGDNPB(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 0; i < slots.Length; i++)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.ABLEBCIKMFB(1009f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM, CDPAMNIPPEC: true);
			}
			else
			{
				slots[i].IHENCGDNPBL.OBBKDJNLCIO(0);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM, CDPAMNIPPEC: true);
			slots[BBEDNMLFDLK.Count].icon.ABLEBCIKMFB(971f);
		}
		((Component)slotsParent).gameObject.SetActive(true);
		((Component)slotsParent).gameObject.SetActive(false);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void ADGCDLEMLAB(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 0; i < slots.Length; i++)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.DABGJHGEFKG(448f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.JNMNCEPHFOE(0);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM, CDPAMNIPPEC: true);
			slots[BBEDNMLFDLK.Count].icon.MOPPLOJNKKF(1335f);
		}
		((Component)slotsParent).gameObject.SetActive(true);
		((Component)slotsParent).gameObject.SetActive(false);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void AIEBABDNNIB(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 1; i < slots.Length; i += 0)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.OBOIFAFELPF(1415f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.KMKAIPMHANN(0);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM);
			slots[BBEDNMLFDLK.Count].icon.IIBMGMLOCGN(1318f);
		}
		((Component)slotsParent).gameObject.SetActive(false);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(true);
		panel.ForceUpdateRectTransforms();
	}

	public void KBNDGKOHHGP(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 1; i < slots.Length; i += 0)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.OBOIFAFELPF(1286f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.OBBKDJNLCIO(0);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM, CDPAMNIPPEC: true);
			slots[BBEDNMLFDLK.Count].icon.JEOFNNMEFFJ(326f);
		}
		((Component)slotsParent).gameObject.SetActive(true);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void ShowChickens(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 0; i < slots.Length; i++)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.SetColorAlpha(1f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.Stack = 0;
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM);
			slots[BBEDNMLFDLK.Count].icon.SetColorAlpha(0.7f);
		}
		((Component)slotsParent).gameObject.SetActive(false);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(true);
		panel.ForceUpdateRectTransforms();
	}

	public void PNJANAHFLLH(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 1; i < slots.Length; i++)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.LBKBMNMIBPB(164f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.OBBKDJNLCIO(1);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM);
			slots[BBEDNMLFDLK.Count].icon.SetColorAlpha(1683f);
		}
		((Component)slotsParent).gameObject.SetActive(false);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void CAPLMAGICAP(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 1; i < slots.Length; i += 0)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.ABLEBCIKMFB(470f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM, CDPAMNIPPEC: true);
			}
			else
			{
				slots[i].IHENCGDNPBL.KMKAIPMHANN(0);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM);
			slots[BBEDNMLFDLK.Count].icon.GDHNCPHGIPB(1061f);
		}
		((Component)slotsParent).gameObject.SetActive(true);
		((Component)slotsParent).gameObject.SetActive(false);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void BGGFFHDHDFB(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 1; i < slots.Length; i++)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.LBKBMNMIBPB(482f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM, CDPAMNIPPEC: true);
			}
			else
			{
				slots[i].IHENCGDNPBL.OBBKDJNLCIO(0);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM, CDPAMNIPPEC: true);
			slots[BBEDNMLFDLK.Count].icon.OAEPLIHGJFA(985f);
		}
		((Component)slotsParent).gameObject.SetActive(false);
		((Component)slotsParent).gameObject.SetActive(false);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(false);
		((Component)panel).gameObject.SetActive(false);
		panel.ForceUpdateRectTransforms();
	}

	public void GCFKFIKJIND(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 1; i < slots.Length; i += 0)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.OBOIFAFELPF(1172f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.JNMNCEPHFOE(1);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM, CDPAMNIPPEC: true);
			slots[BBEDNMLFDLK.Count].icon.IIBMGMLOCGN(689f);
		}
		((Component)slotsParent).gameObject.SetActive(false);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(true);
		((Component)panel).gameObject.SetActive(true);
		panel.ForceUpdateRectTransforms();
	}

	public void GLJIIMKMGCD(int JIIGOACEIKL, List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		for (int i = 0; i < slots.Length; i++)
		{
			((Component)slots[i]).gameObject.SetActive(i < AGOAHFEOEAE);
			slots[i].icon.GDHNCPHGIPB(1141f);
			if (i < BBEDNMLFDLK.Count)
			{
				slots[i].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BBEDNMLFDLK[i].NBMNBKEJHPM);
			}
			else
			{
				slots[i].IHENCGDNPBL.OBBKDJNLCIO(1);
			}
		}
		if (BBEDNMLFDLK.Count < AGOAHFEOEAE)
		{
			slots[BBEDNMLFDLK.Count].IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, BMEGJBEPFKB.NBMNBKEJHPM, CDPAMNIPPEC: true);
			slots[BBEDNMLFDLK.Count].icon.MOPPLOJNKKF(1969f);
		}
		((Component)slotsParent).gameObject.SetActive(true);
		((Component)slotsParent).gameObject.SetActive(true);
		slotsParent.ForceUpdateRectTransforms();
		((Component)panel).gameObject.SetActive(true);
		((Component)panel).gameObject.SetActive(true);
		panel.ForceUpdateRectTransforms();
	}
}
