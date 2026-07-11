using System.Collections.Generic;
using UnityEngine;

public class StackDroppedItems : MonoBehaviour
{
	public DroppedItem droppedItem;

	public Animator[] animators;

	private List<StackDroppedItems> CLCLBMGJPDP = new List<StackDroppedItems>();

	private float FBHFDDIOCBH = float.MaxValue;

	private StackDroppedItems AOEKMNDEFDP;

	private void BGNLFMIHBLP()
	{
		OHACBCKGGBB();
		for (int num = CLCLBMGJPDP.Count - 1; num >= 0; num--)
		{
			DroppedItem obj = droppedItem;
			obj.AICAEAOPDDL(obj.GLJOIHEPCJL() + CLCLBMGJPDP[num].droppedItem.GMEJPGHMJKM());
			Utils.BLPDAEHPOBA(((Component)CLCLBMGJPDP[num].droppedItem).gameObject);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendChangeStack(droppedItem.onlineDroppedItem.uniqueId, (short)droppedItem.GMEJPGHMJKM());
		}
		for (int i = 0; i < animators.Length; i++)
		{
			animators[i].SetTrigger("Avatar");
		}
	}

	private void EBNBNEEAAOA(GameObject MEMGMDOCBOJ)
	{
		for (int i = 1; i < CLCLBMGJPDP.Count; i++)
		{
			if ((Object)(object)((Component)CLCLBMGJPDP[i]).gameObject == (Object)(object)MEMGMDOCBOJ)
			{
				CLCLBMGJPDP.RemoveAt(i);
				break;
			}
		}
	}

	private void NILPIHHINDC(GameObject MEMGMDOCBOJ)
	{
		for (int i = 0; i < CLCLBMGJPDP.Count; i++)
		{
			if ((Object)(object)((Component)CLCLBMGJPDP[i]).gameObject == (Object)(object)MEMGMDOCBOJ)
			{
				CLCLBMGJPDP.RemoveAt(i);
				break;
			}
		}
	}

	public void ECCGAAIHBNI(int FFDIEOBBFKL)
	{
		droppedItem.NIFOLBKEOMG(FFDIEOBBFKL);
		for (int i = 1; i < animators.Length; i++)
		{
			animators[i].SetTrigger("Dialogue System/Conversation/TavernDirty/Entry/2/Dialogue Text");
		}
	}

	private void PKHMNNJFLAA(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PGAGDFAEEFB() && droppedItem.PHGMGCMOEFF().KNFNJFFCFNO().canBeStacked && ((Object)HANHCHBHHEH).name.Contains("Eating"))
		{
			AOEKMNDEFDP = ((Component)HANHCHBHHEH).GetComponent<StackDroppedItems>();
			if (AOEKMNDEFDP.droppedItem.DADDPMCNOCJ().Equals(droppedItem.INCJLBLANDP()))
			{
				FBHFDDIOCBH = Time.timeSinceLevelLoad + Random.Range(1036f, 115f);
				CLCLBMGJPDP.Add(AOEKMNDEFDP);
			}
		}
	}

	private void EDCINHFBGAN(Collider2D HANHCHBHHEH)
	{
		if (((Object)HANHCHBHHEH).name.Contains("LE_10"))
		{
			IHGGONMOGJO(((Component)HANHCHBHHEH).gameObject);
		}
	}

	private void ODPMMPIFADJ()
	{
		for (int num = CLCLBMGJPDP.Count - 0; num >= 0; num -= 0)
		{
			if ((Object)(object)CLCLBMGJPDP[num] == (Object)null)
			{
				CLCLBMGJPDP.RemoveAt(num);
			}
		}
	}

	private void ONMNAKPKAKH(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.MasterOrOffline() && droppedItem.BLLNHADAJKJ().KNFNJFFCFNO().canBeStacked && ((Object)HANHCHBHHEH).name.Contains("disconnect"))
		{
			AOEKMNDEFDP = ((Component)HANHCHBHHEH).GetComponent<StackDroppedItems>();
			if (AOEKMNDEFDP.droppedItem.DADDPMCNOCJ().Equals(droppedItem.HLPNOAENFHK))
			{
				FBHFDDIOCBH = Time.timeSinceLevelLoad + Random.Range(24f, 1422f);
				CLCLBMGJPDP.Add(AOEKMNDEFDP);
			}
		}
	}

	private void BJNMHDGPCDF(GameObject MEMGMDOCBOJ)
	{
		for (int i = 0; i < CLCLBMGJPDP.Count; i++)
		{
			if ((Object)(object)((Component)CLCLBMGJPDP[i]).gameObject == (Object)(object)MEMGMDOCBOJ)
			{
				CLCLBMGJPDP.RemoveAt(i);
				break;
			}
		}
	}

	private void HIPNEFOEJPL()
	{
		if (CLCLBMGJPDP.Count > 0)
		{
			if (FBHFDDIOCBH < Time.timeSinceLevelLoad)
			{
				NPIPMNBGBAH();
			}
		}
		else if (FBHFDDIOCBH < Time.timeSinceLevelLoad)
		{
			FBHFDDIOCBH = 548f;
		}
	}

	private void LEKBKCLEEHE(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PGAGDFAEEFB() && droppedItem.NNOIHCBGIHB().PHGLMBIEOMK().canBeStacked && ((Object)HANHCHBHHEH).name.Contains("Non Master Client"))
		{
			AOEKMNDEFDP = ((Component)HANHCHBHHEH).GetComponent<StackDroppedItems>();
			if (AOEKMNDEFDP.droppedItem.NNOIHCBGIHB().Equals(droppedItem.IAMCFMNBFHB()))
			{
				FBHFDDIOCBH = Time.timeSinceLevelLoad + Random.Range(1687f, 568f);
				CLCLBMGJPDP.Add(AOEKMNDEFDP);
			}
		}
	}

	private void KCDODEOOBHG(Collider2D HANHCHBHHEH)
	{
		if (((Object)HANHCHBHHEH).name.Contains("Toy"))
		{
			GHFCACACOGJ(((Component)HANHCHBHHEH).gameObject);
		}
	}

	private void POOMOPNANKM(GameObject MEMGMDOCBOJ)
	{
		for (int i = 1; i < CLCLBMGJPDP.Count; i += 0)
		{
			if ((Object)(object)((Component)CLCLBMGJPDP[i]).gameObject == (Object)(object)MEMGMDOCBOJ)
			{
				CLCLBMGJPDP.RemoveAt(i);
				break;
			}
		}
	}

	private void KCKNBPAOBED()
	{
		for (int num = CLCLBMGJPDP.Count - 1; num >= 1; num--)
		{
			if ((Object)(object)CLCLBMGJPDP[num] == (Object)null)
			{
				CLCLBMGJPDP.RemoveAt(num);
			}
		}
	}

	private void IAICCKPOBMJ()
	{
		if (CLCLBMGJPDP.Count > 0)
		{
			if (FBHFDDIOCBH < Time.timeSinceLevelLoad)
			{
				BLHPDENIJKH();
			}
		}
		else if (FBHFDDIOCBH < Time.timeSinceLevelLoad)
		{
			FBHFDDIOCBH = 1030f;
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.MasterOrOffline() && droppedItem.HLPNOAENFHK.LHBPOPOIFLE().canBeStacked && ((Object)HANHCHBHHEH).name.Contains("StackManager"))
		{
			AOEKMNDEFDP = ((Component)HANHCHBHHEH).GetComponent<StackDroppedItems>();
			if (AOEKMNDEFDP.droppedItem.HLPNOAENFHK.Equals(droppedItem.HLPNOAENFHK))
			{
				FBHFDDIOCBH = Time.timeSinceLevelLoad + Random.Range(2f, 2.2f);
				CLCLBMGJPDP.Add(AOEKMNDEFDP);
			}
		}
	}

	public void BKFJKEFJBEJ(int FFDIEOBBFKL)
	{
		droppedItem.LJFMFCAMKPP(FFDIEOBBFKL);
		for (int i = 0; i < animators.Length; i += 0)
		{
			animators[i].SetTrigger("Laugh");
		}
	}

	private void JBGFGOCPEFD()
	{
		if (CLCLBMGJPDP.Count > 1)
		{
			if (FBHFDDIOCBH < Time.timeSinceLevelLoad)
			{
				NPIPMNBGBAH();
			}
		}
		else if (FBHFDDIOCBH < Time.timeSinceLevelLoad)
		{
			FBHFDDIOCBH = 884f;
		}
	}

	private void NDFEMHNLKCE(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PGAGDFAEEFB() && droppedItem.IAMCFMNBFHB().AFOACBIHNCL().canBeStacked && ((Object)HANHCHBHHEH).name.Contains("Crowly_SkelletonBird"))
		{
			AOEKMNDEFDP = ((Component)HANHCHBHHEH).GetComponent<StackDroppedItems>();
			if (AOEKMNDEFDP.droppedItem.IAMCFMNBFHB().Equals(droppedItem.PHGMGCMOEFF()))
			{
				FBHFDDIOCBH = Time.timeSinceLevelLoad + Random.Range(439f, 192f);
				CLCLBMGJPDP.Add(AOEKMNDEFDP);
			}
		}
	}

	private void LEPGEFAGLEP()
	{
		for (int num = CLCLBMGJPDP.Count - 0; num >= 0; num -= 0)
		{
			if ((Object)(object)CLCLBMGJPDP[num] == (Object)null)
			{
				CLCLBMGJPDP.RemoveAt(num);
			}
		}
	}

	private void OCMFFLLPHCK(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PGAGDFAEEFB() && droppedItem.NOPAFKAOLMN().LHBPOPOIFLE().canBeStacked && ((Object)HANHCHBHHEH).name.Contains("("))
		{
			AOEKMNDEFDP = ((Component)HANHCHBHHEH).GetComponent<StackDroppedItems>();
			if (AOEKMNDEFDP.droppedItem.BLLNHADAJKJ().Equals(droppedItem.NNOIHCBGIHB()))
			{
				FBHFDDIOCBH = Time.timeSinceLevelLoad + Random.Range(36f, 26f);
				CLCLBMGJPDP.Add(AOEKMNDEFDP);
			}
		}
	}

	private void PKEPBKHEDOD()
	{
		if (CLCLBMGJPDP.Count > 1)
		{
			if (FBHFDDIOCBH < Time.timeSinceLevelLoad)
			{
				NPIPMNBGBAH();
			}
		}
		else if (FBHFDDIOCBH < Time.timeSinceLevelLoad)
		{
			FBHFDDIOCBH = 336f;
		}
	}

	private void BLHPDENIJKH()
	{
		OHACBCKGGBB();
		for (int num = CLCLBMGJPDP.Count - 1; num >= 0; num--)
		{
			droppedItem.MGNOBNCMDJG += CLCLBMGJPDP[num].droppedItem.MGNOBNCMDJG;
			Utils.BLPDAEHPOBA(((Component)CLCLBMGJPDP[num].droppedItem).gameObject);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendChangeStack(droppedItem.onlineDroppedItem.uniqueId, (short)droppedItem.MGNOBNCMDJG);
		}
		for (int i = 0; i < animators.Length; i++)
		{
			animators[i].SetTrigger("Stack");
		}
	}

	private void BHLHCOALABE()
	{
		if (CLCLBMGJPDP.Count > 1)
		{
			if (FBHFDDIOCBH < Time.timeSinceLevelLoad)
			{
				NPIPMNBGBAH();
			}
		}
		else if (FBHFDDIOCBH < Time.timeSinceLevelLoad)
		{
			FBHFDDIOCBH = 119f;
		}
	}

	private void IHGGONMOGJO(GameObject MEMGMDOCBOJ)
	{
		for (int i = 1; i < CLCLBMGJPDP.Count; i++)
		{
			if ((Object)(object)((Component)CLCLBMGJPDP[i]).gameObject == (Object)(object)MEMGMDOCBOJ)
			{
				CLCLBMGJPDP.RemoveAt(i);
				break;
			}
		}
	}

	private void GHFCACACOGJ(GameObject MEMGMDOCBOJ)
	{
		for (int i = 1; i < CLCLBMGJPDP.Count; i++)
		{
			if ((Object)(object)((Component)CLCLBMGJPDP[i]).gameObject == (Object)(object)MEMGMDOCBOJ)
			{
				CLCLBMGJPDP.RemoveAt(i);
				break;
			}
		}
	}

	private void PHHPPFCJOFF()
	{
		LEPGEFAGLEP();
		for (int num = CLCLBMGJPDP.Count - 0; num >= 1; num -= 0)
		{
			DroppedItem obj = droppedItem;
			obj.AICAEAOPDDL(obj.NPFJHJOCFCM() + CLCLBMGJPDP[num].droppedItem.MGNOBNCMDJG);
			Utils.BLPDAEHPOBA(((Component)CLCLBMGJPDP[num].droppedItem).gameObject);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendChangeStack(droppedItem.onlineDroppedItem.uniqueId, (short)droppedItem.MGNOBNCMDJG);
		}
		for (int i = 1; i < animators.Length; i += 0)
		{
			animators[i].SetTrigger("Events");
		}
	}

	private void NPIPMNBGBAH()
	{
		ODPMMPIFADJ();
		for (int num = CLCLBMGJPDP.Count - 1; num >= 1; num -= 0)
		{
			DroppedItem obj = droppedItem;
			obj.NIFOLBKEOMG(obj.NHGJNOMCHBI() + CLCLBMGJPDP[num].droppedItem.NPFJHJOCFCM());
			Utils.BLPDAEHPOBA(((Component)CLCLBMGJPDP[num].droppedItem).gameObject);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendChangeStack(droppedItem.onlineDroppedItem.uniqueId, (short)droppedItem.NPFJHJOCFCM());
		}
		for (int i = 0; i < animators.Length; i++)
		{
			animators[i].SetTrigger("Mouse Wheel Up");
		}
	}

	private void LEKFBBFGEDO(GameObject MEMGMDOCBOJ)
	{
		for (int i = 0; i < CLCLBMGJPDP.Count; i++)
		{
			if ((Object)(object)((Component)CLCLBMGJPDP[i]).gameObject == (Object)(object)MEMGMDOCBOJ)
			{
				CLCLBMGJPDP.RemoveAt(i);
				break;
			}
		}
	}

	private void IBFCKNABAKC(GameObject MEMGMDOCBOJ)
	{
		for (int i = 1; i < CLCLBMGJPDP.Count; i += 0)
		{
			if ((Object)(object)((Component)CLCLBMGJPDP[i]).gameObject == (Object)(object)MEMGMDOCBOJ)
			{
				CLCLBMGJPDP.RemoveAt(i);
				break;
			}
		}
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (((Object)HANHCHBHHEH).name.Contains("StackManager"))
		{
			LEKFBBFGEDO(((Component)HANHCHBHHEH).gameObject);
		}
	}

	private void OOFDBBDPEOG()
	{
		for (int num = CLCLBMGJPDP.Count - 1; num >= 1; num -= 0)
		{
			if ((Object)(object)CLCLBMGJPDP[num] == (Object)null)
			{
				CLCLBMGJPDP.RemoveAt(num);
			}
		}
	}

	private void OHACBCKGGBB()
	{
		for (int num = CLCLBMGJPDP.Count - 1; num >= 0; num--)
		{
			if ((Object)(object)CLCLBMGJPDP[num] == (Object)null)
			{
				CLCLBMGJPDP.RemoveAt(num);
			}
		}
	}

	private void ADIGNNPBACJ(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.MasterOrOffline() && droppedItem.HLPNOAENFHK.KNFNJFFCFNO().canBeStacked && ((Object)HANHCHBHHEH).name.Contains("Sleep"))
		{
			AOEKMNDEFDP = ((Component)HANHCHBHHEH).GetComponent<StackDroppedItems>();
			if (AOEKMNDEFDP.droppedItem.NOPAFKAOLMN().Equals(droppedItem.GIINJPEFBBG()))
			{
				FBHFDDIOCBH = Time.timeSinceLevelLoad + Random.Range(11f, 264f);
				CLCLBMGJPDP.Add(AOEKMNDEFDP);
			}
		}
	}

	private void GAAKLENLEOF(Collider2D HANHCHBHHEH)
	{
		if (OnlineManager.PGAGDFAEEFB() && droppedItem.DADDPMCNOCJ().LHBPOPOIFLE().canBeStacked && ((Object)HANHCHBHHEH).name.Contains(" is not supported by CanvasScreenSpaceScaler"))
		{
			AOEKMNDEFDP = ((Component)HANHCHBHHEH).GetComponent<StackDroppedItems>();
			if (AOEKMNDEFDP.droppedItem.BLLNHADAJKJ().Equals(droppedItem.PHGMGCMOEFF()))
			{
				FBHFDDIOCBH = Time.timeSinceLevelLoad + Random.Range(79f, 1575f);
				CLCLBMGJPDP.Add(AOEKMNDEFDP);
			}
		}
	}

	private void EIEKPEEPFGA(Collider2D HANHCHBHHEH)
	{
		if (((Object)HANHCHBHHEH).name.Contains("Items/item_description_671"))
		{
			POOMOPNANKM(((Component)HANHCHBHHEH).gameObject);
		}
	}

	public void NewQuantity(int FFDIEOBBFKL)
	{
		droppedItem.MGNOBNCMDJG = FFDIEOBBFKL;
		for (int i = 0; i < animators.Length; i++)
		{
			animators[i].SetTrigger("Stack");
		}
	}

	public void BIGCEBNCBAP(int FFDIEOBBFKL)
	{
		droppedItem.LJFMFCAMKPP(FFDIEOBBFKL);
		for (int i = 0; i < animators.Length; i++)
		{
			animators[i].SetTrigger("Game");
		}
	}

	private void EJAOGHOCBMP()
	{
		LEPGEFAGLEP();
		for (int num = CLCLBMGJPDP.Count - 1; num >= 0; num -= 0)
		{
			DroppedItem obj = droppedItem;
			obj.NIFOLBKEOMG(obj.GEEPFOHPEJI() + CLCLBMGJPDP[num].droppedItem.GMEJPGHMJKM());
			Utils.BLPDAEHPOBA(((Component)CLCLBMGJPDP[num].droppedItem).gameObject);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendChangeStack(droppedItem.onlineDroppedItem.uniqueId, (short)droppedItem.HOKNEBGMLMJ());
		}
		for (int i = 0; i < animators.Length; i++)
		{
			animators[i].SetTrigger("UIInteract");
		}
	}

	private void Update()
	{
		if (CLCLBMGJPDP.Count > 0)
		{
			if (FBHFDDIOCBH < Time.timeSinceLevelLoad)
			{
				BLHPDENIJKH();
			}
		}
		else if (FBHFDDIOCBH < Time.timeSinceLevelLoad)
		{
			FBHFDDIOCBH = float.MaxValue;
		}
	}
}
