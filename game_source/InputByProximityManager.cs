using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InputByProximityManager : MonoBehaviour
{
	private static InputByProximityManager[] GJBBNHCMNJN = new InputByProximityManager[5];

	private List<InputByProximity> KNOIHBHLPHJ = new List<InputByProximity>();

	private List<InputByProximity> KEPNDJDKMMO = new List<InputByProximity>();

	private InputByProximity EPNCNFIFHKK;

	private InputByProximity BOJOHALHFJH;

	private CharacterAnimation FJHKGBNBNKL;

	private Direction KIBOMMJNDDN;

	private ITool EOOFAGCLEME;

	private ToolInstance ACFLBADEHDN;

	private ITool AKOBBMKGIFK;

	private bool FPDGCCDAAKO;

	private int JIIGOACEIKL;

	private SelectObject FLDDAIONMNB;

	private bool JAKCENHIJJC;

	private InputByProximity AMANLGEHNEO;

	private float EFLJMIPFNHD;

	private float MIJLMAIEEHB;

	private int MENBAFNNBFB;

	private float KCNJFGGCGFF;

	private float AALLAMLNIDK;

	private Quaternion OIFDFAJPEKO;

	private Quaternion JFFMJCOLPDA;

	private ITool GABMEGOFGJE(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		if (EOOFAGCLEME != null)
		{
			return EOOFAGCLEME;
		}
		return ACFLBADEHDN;
	}

	private InputByProximity IPPKPIDDLFC(List<InputByProximity> DOILBNGPBLK, bool CLNJDFFMGDL)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		EFLJMIPFNHD = 1366f;
		AMANLGEHNEO = null;
		for (MENBAFNNBFB = 0; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB++)
		{
			if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) || !DOILBNGPBLK[MENBAFNNBFB].IsAvailableByProximity(JIIGOACEIKL))
			{
				continue;
			}
			if (CLNJDFFMGDL)
			{
				if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.itemSpace != (Object)null) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider != (Object)null))
				{
					continue;
				}
				Vector2 val = Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL));
				Bounds bounds = DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider.bounds;
				MIJLMAIEEHB = Vector2.Distance(val, Vector2.op_Implicit(((Bounds)(ref bounds)).ClosestPoint(PlayerController.GetPlayerPosition(JIIGOACEIKL))));
			}
			else
			{
				MIJLMAIEEHB = Vector2.Distance(Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL)), Vector2.op_Implicit(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position));
			}
			if (MIJLMAIEEHB < EFLJMIPFNHD)
			{
				AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
				EFLJMIPFNHD = MIJLMAIEEHB;
			}
		}
		return AMANLGEHNEO;
	}

	private bool NGMCJMADPAD(InputByProximity LPFGACEBMGD)
	{
		if ((Object)(object)LPFGACEBMGD.placeable == (Object)null)
		{
			return false;
		}
		if ((Object)(object)LPFGACEBMGD.placeable.itemSetup == (Object)null)
		{
			return false;
		}
		if (Item.NGIIPJDAMGP(LPFGACEBMGD.placeable.itemSetup.item, null))
		{
			return false;
		}
		if (LPFGACEBMGD.placeable.itemSetup.item.JDJGFAACPFC() == 663)
		{
			return true;
		}
		return false;
	}

	private bool EIHCIMCILPM(InputByProximity LPFGACEBMGD)
	{
		if ((Object)(object)LPFGACEBMGD.placeable == (Object)null)
		{
			return true;
		}
		if ((Object)(object)LPFGACEBMGD.placeable.itemSetup == (Object)null)
		{
			return false;
		}
		if (Item.GBMFCPGEJDK(LPFGACEBMGD.placeable.itemSetup.item, null))
		{
			return true;
		}
		if (LPFGACEBMGD.placeable.itemSetup.item.IMCJPECAAPC() == -43)
		{
			return false;
		}
		return false;
	}

	private bool GHKGEEDHPLM(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		ITool tool = DNDDEEJGADF(EOOFAGCLEME, ACFLBADEHDN);
		if (tool != null && !Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			if (AKOBBMKGIFK != null && AKOBBMKGIFK != tool)
			{
				AALPBNELNNO(AKOBBMKGIFK);
				AKOBBMKGIFK = null;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
			if (tool.NBFBPMNMBJG(JIIGOACEIKL))
			{
				if ((Object)(object)BOJOHALHFJH != (Object)null)
				{
					BOJOHALHFJH.OffHover(JIIGOACEIKL);
				}
				BOJOHALHFJH = null;
				FPDGCCDAAKO = false;
				AKOBBMKGIFK = tool;
				tool.AONJJGAIDBG(JIIGOACEIKL);
				tool.HEKGALMDLIL(JIIGOACEIKL);
				return true;
			}
			tool.LBMKLIDKHJD(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	private void BFJOEMCBJJO()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		FLDDAIONMNB = ((Component)this).GetComponent<SelectObject>();
		LDCIDHKOIPN(this);
	}

	public void CPNNCJOEONP(InputByProximity FDGJJPGOKNG)
	{
		if (!KNOIHBHLPHJ.Contains(FDGJJPGOKNG))
		{
			KNOIHBHLPHJ.Add(FDGJJPGOKNG);
		}
	}

	private bool GOACFHLPELH(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		ITool tool = GJIDLADLNKA(EOOFAGCLEME, ACFLBADEHDN);
		if (tool != null && !Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			if (AKOBBMKGIFK != null && AKOBBMKGIFK != tool)
			{
				KIBCOOMAOGI(AKOBBMKGIFK);
				AKOBBMKGIFK = null;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
			if (tool.NBFBPMNMBJG(JIIGOACEIKL))
			{
				if ((Object)(object)BOJOHALHFJH != (Object)null)
				{
					BOJOHALHFJH.KMPILLCNJPC(JIIGOACEIKL);
				}
				BOJOHALHFJH = null;
				FPDGCCDAAKO = true;
				AKOBBMKGIFK = tool;
				tool.AONJJGAIDBG(JIIGOACEIKL);
				tool.HEKGALMDLIL(JIIGOACEIKL);
				return false;
			}
			tool.LBMKLIDKHJD(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public void HNJMHFPLDCN()
	{
		EOOFAGCLEME = ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem() as ITool;
		ACFLBADEHDN = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL).GOADDJLNIBN() as ToolInstance;
		if (!CMGOACOKMIL(EOOFAGCLEME, ACFLBADEHDN) && FPDGCCDAAKO)
		{
			FPDGCCDAAKO = false;
			KIBCOOMAOGI(AKOBBMKGIFK);
			AKOBBMKGIFK = null;
		}
		if (TavernConstructionManager.DOIKFJDLKJP().LNLJMCONDNE && !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).GABNNLJOMHI())
		{
			if (ConstructionActionBarUI.currentPanel != 0)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
				EPNCNFIFHKK = null;
			}
			return;
		}
		DCANBDGHBKC();
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			if ((Object)(object)EPNCNFIFHKK.placeable == (Object)null || !EPNCNFIFHKK.placeable.attachedToPlayer)
			{
				OnHover(EPNCNFIFHKK);
			}
			EPNCNFIFHKK.AOEOBNOPLIG(JIIGOACEIKL);
		}
	}

	private ITool FDKPJMJFNFC(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		if (EOOFAGCLEME != null)
		{
			return EOOFAGCLEME;
		}
		return ACFLBADEHDN;
	}

	private InputByProximity CBENJCIJLPK(List<InputByProximity> DOILBNGPBLK, bool CLNJDFFMGDL)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		EFLJMIPFNHD = 141f;
		AMANLGEHNEO = null;
		for (MENBAFNNBFB = 0; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB += 0)
		{
			if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) || !DOILBNGPBLK[MENBAFNNBFB].HLDFEKIDJAK(JIIGOACEIKL))
			{
				continue;
			}
			if (CLNJDFFMGDL)
			{
				if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.itemSpace != (Object)null) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider != (Object)null))
				{
					continue;
				}
				Vector2 val = Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL));
				Bounds bounds = DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider.bounds;
				MIJLMAIEEHB = Vector2.Distance(val, Vector2.op_Implicit(((Bounds)(ref bounds)).ClosestPoint(PlayerController.GetPlayerPosition(JIIGOACEIKL))));
			}
			else
			{
				MIJLMAIEEHB = Vector2.Distance(Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL)), Vector2.op_Implicit(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position));
			}
			if (MIJLMAIEEHB < EFLJMIPFNHD)
			{
				AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
				EFLJMIPFNHD = MIJLMAIEEHB;
			}
		}
		return AMANLGEHNEO;
	}

	public void IPOFDHNPIDL()
	{
		EOOFAGCLEME = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JDAFPKOHJPC() as ITool;
		ACFLBADEHDN = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).BBBGBHPJOAG() as ToolInstance;
		if (!GHKGEEDHPLM(EOOFAGCLEME, ACFLBADEHDN) && FPDGCCDAAKO)
		{
			FPDGCCDAAKO = true;
			KIBCOOMAOGI(AKOBBMKGIFK);
			AKOBBMKGIFK = null;
		}
		if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE && !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).GABNNLJOMHI())
		{
			if (ConstructionActionBarUI.currentPanel != 7)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
				EPNCNFIFHKK = null;
			}
			return;
		}
		PCJMBBJBKHG();
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			if ((Object)(object)EPNCNFIFHKK.placeable == (Object)null || !EPNCNFIFHKK.placeable.attachedToPlayer)
			{
				DKJFCCLJAPD(EPNCNFIFHKK);
			}
			EPNCNFIFHKK.AOEOBNOPLIG(JIIGOACEIKL);
		}
	}

	private bool KGPBGEFNBMF(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		ITool tool = FDKPJMJFNFC(EOOFAGCLEME, ACFLBADEHDN);
		if (tool != null && !Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			if (AKOBBMKGIFK != null && AKOBBMKGIFK != tool)
			{
				AALPBNELNNO(AKOBBMKGIFK);
				AKOBBMKGIFK = null;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
			if (tool.NBFBPMNMBJG(JIIGOACEIKL))
			{
				if ((Object)(object)BOJOHALHFJH != (Object)null)
				{
					BOJOHALHFJH.BJCDFHFKEGG(JIIGOACEIKL);
				}
				BOJOHALHFJH = null;
				FPDGCCDAAKO = false;
				AKOBBMKGIFK = tool;
				tool.AONJJGAIDBG(JIIGOACEIKL);
				tool.HEKGALMDLIL(JIIGOACEIKL);
				return true;
			}
			tool.LBMKLIDKHJD(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public void NFLJFGBCLGP()
	{
		EOOFAGCLEME = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JDAFPKOHJPC() as ITool;
		ACFLBADEHDN = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOADDJLNIBN() as ToolInstance;
		if (!GOACFHLPELH(EOOFAGCLEME, ACFLBADEHDN) && FPDGCCDAAKO)
		{
			FPDGCCDAAKO = false;
			PHNJOFIMJHM(AKOBBMKGIFK);
			AKOBBMKGIFK = null;
		}
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE && !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).MDOKKKHKKKE())
		{
			if (ConstructionActionBarUI.currentPanel != 1)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
				EPNCNFIFHKK = null;
			}
			return;
		}
		PCJMBBJBKHG();
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			if ((Object)(object)EPNCNFIFHKK.placeable == (Object)null || !EPNCNFIFHKK.placeable.attachedToPlayer)
			{
				HJJIFLPPIBO(EPNCNFIFHKK);
			}
			EPNCNFIFHKK.PNFKIHGMBLG(JIIGOACEIKL);
		}
	}

	private void INHBDHMJHEB()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		FLDDAIONMNB = ((Component)this).GetComponent<SelectObject>();
		LDCIDHKOIPN(this);
	}

	private void BIPOBGNDFCK()
	{
		FJHKGBNBNKL = ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).GetComponent<CharacterAnimation>();
	}

	private void IPMCBCCJAAJ()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		FLDDAIONMNB = ((Component)this).GetComponent<SelectObject>();
		MPBPEPLBDPK(this);
	}

	public static InputByProximityManager BPDFMAEOGGC(int JIIGOACEIKL)
	{
		if (!GDHLGONLGOO(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private bool FFOCCDHEEIO(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		ITool tool = BCONKAHCJDF(EOOFAGCLEME, ACFLBADEHDN);
		if (tool != null && !Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			if (AKOBBMKGIFK != null && AKOBBMKGIFK != tool)
			{
				PHNJOFIMJHM(AKOBBMKGIFK);
				AKOBBMKGIFK = null;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
			if (tool.NBFBPMNMBJG(JIIGOACEIKL))
			{
				if ((Object)(object)BOJOHALHFJH != (Object)null)
				{
					BOJOHALHFJH.KMPILLCNJPC(JIIGOACEIKL);
				}
				BOJOHALHFJH = null;
				FPDGCCDAAKO = false;
				AKOBBMKGIFK = tool;
				tool.AONJJGAIDBG(JIIGOACEIKL);
				tool.HEKGALMDLIL(JIIGOACEIKL);
				return true;
			}
			tool.LBMKLIDKHJD(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public void CGPPGMLKAEL()
	{
		EOOFAGCLEME = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JDAFPKOHJPC() as ITool;
		ACFLBADEHDN = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL).GOADDJLNIBN() as ToolInstance;
		if (!GHKGEEDHPLM(EOOFAGCLEME, ACFLBADEHDN) && FPDGCCDAAKO)
		{
			FPDGCCDAAKO = true;
			PKNMLBCHEBH(AKOBBMKGIFK);
			AKOBBMKGIFK = null;
		}
		if (TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE && !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DMBFKFLDDLH)
		{
			if (ConstructionActionBarUI.currentPanel != 1)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
				EPNCNFIFHKK = null;
			}
			return;
		}
		FNPAJCJLCBM();
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			if ((Object)(object)EPNCNFIFHKK.placeable == (Object)null || !EPNCNFIFHKK.placeable.attachedToPlayer)
			{
				DKJFCCLJAPD(EPNCNFIFHKK);
			}
			EPNCNFIFHKK.UpdateByProximity(JIIGOACEIKL);
		}
	}

	private ITool PDFEBNFPJFL(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		if (EOOFAGCLEME != null)
		{
			return EOOFAGCLEME;
		}
		return ACFLBADEHDN;
	}

	public void EAAJBBAJIHB(InputByProximity FDGJJPGOKNG)
	{
		if (!KNOIHBHLPHJ.Contains(FDGJJPGOKNG))
		{
			KNOIHBHLPHJ.Add(FDGJJPGOKNG);
		}
	}

	public void DoAction()
	{
		EOOFAGCLEME = ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem() as ITool;
		ACFLBADEHDN = ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItemInstance() as ToolInstance;
		if (!LNALFMDLFFN(EOOFAGCLEME, ACFLBADEHDN) && FPDGCCDAAKO)
		{
			FPDGCCDAAKO = false;
			PKNMLBCHEBH(AKOBBMKGIFK);
			AKOBBMKGIFK = null;
		}
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			if (ConstructionActionBarUI.currentPanel != 3)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
				EPNCNFIFHKK = null;
			}
			return;
		}
		NMNAKPILMBE();
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			if ((Object)(object)EPNCNFIFHKK.placeable == (Object)null || !EPNCNFIFHKK.placeable.attachedToPlayer)
			{
				OnHover(EPNCNFIFHKK);
			}
			EPNCNFIFHKK.UpdateByProximity(JIIGOACEIKL);
		}
	}

	public Vector3 JFCFDGIDDBK()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			return ((Component)EPNCNFIFHKK).transform.position;
		}
		return ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
	}

	public static InputByProximityManager NHJMJHGGBOA(int JIIGOACEIKL)
	{
		if (!GDHLGONLGOO(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void OHGLJCKNBFB(InputByProximity LFBNPHHABDK)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
		LFBNPHHABDK.OnHover(JIIGOACEIKL);
	}

	public void ResetFocusedInputElement()
	{
		EPNCNFIFHKK = null;
	}

	private ITool GHLKHKCPCGB(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		if (EOOFAGCLEME != null)
		{
			return EOOFAGCLEME;
		}
		return ACFLBADEHDN;
	}

	private static bool DOJCKFPNIPD(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	public static InputByProximityManager CKJGBDHHKHB(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void IOBLLDIPBCA()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		FLDDAIONMNB = ((Component)this).GetComponent<SelectObject>();
		MPBPEPLBDPK(this);
	}

	private void LLANPCLPOJI()
	{
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		if (KNOIHBHLPHJ.Count == 0 || MainUI.IsAnyUIOpen(JIIGOACEIKL) || (CursorManager.GetPlayer(JIIGOACEIKL).LALPELGNIJB() && DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DMBFKFLDDLH))
		{
			EPNCNFIFHKK = null;
		}
		else if (Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			EPNCNFIFHKK = FLDDAIONMNB.placeable.inputByProximity;
		}
		else
		{
			KEPNDJDKMMO.Clear();
			JAKCENHIJJC = false;
			for (MENBAFNNBFB = 1; MENBAFNNBFB < KNOIHBHLPHJ.Count; MENBAFNNBFB += 0)
			{
				if (Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB]) && KNOIHBHLPHJ[MENBAFNNBFB].HLDFEKIDJAK(JIIGOACEIKL))
				{
					if (DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DMBFKFLDDLH && Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable) && (Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable.itemSpace != (Object)null)
					{
						JAKCENHIJJC = true;
						break;
					}
					KIBOMMJNDDN = Utils.LFOGGLLPPBI(Vector2.op_Implicit(((Component)KNOIHBHLPHJ[MENBAFNNBFB]).transform.position - ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position), KIBOMMJNDDN);
					if (KIBOMMJNDDN == FJHKGBNBNKL.FCGBJEIIMBC)
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
					else if (CJGCOELLGDH(KNOIHBHLPHJ[MENBAFNNBFB]))
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
				}
			}
			if (JAKCENHIJJC)
			{
				EPNCNFIFHKK = IPPKPIDDLFC(KNOIHBHLPHJ, CLNJDFFMGDL: false);
			}
			else if (KEPNDJDKMMO.Count > 0)
			{
				EPNCNFIFHKK = NDDMFPDKBAP(KEPNDJDKMMO, JOLKJNACDDE: true);
			}
			else
			{
				EPNCNFIFHKK = CKCJPKFODBI(KNOIHBHLPHJ, JOLKJNACDDE: true);
			}
		}
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, EPNCNFIFHKK.actionButtonsPoint.position);
		}
		if (!((Object)(object)EPNCNFIFHKK != (Object)(object)BOJOHALHFJH) || (!((Object)(object)EPNCNFIFHKK == (Object)null) && !((Object)(object)EPNCNFIFHKK.placeable == (Object)null) && EPNCNFIFHKK.placeable.attachedToPlayer))
		{
			return;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		if (Object.op_Implicit((Object)(object)BOJOHALHFJH))
		{
			if (BOJOHALHFJH.playerToHover == JIIGOACEIKL)
			{
				BOJOHALHFJH.playerToHover = 0;
			}
			BOJOHALHFJH.LAEDMIPNGPJ(JIIGOACEIKL);
		}
		BOJOHALHFJH = EPNCNFIFHKK;
	}

	private void HCEDMLJNOBL()
	{
		FJHKGBNBNKL = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).GetComponent<CharacterAnimation>();
	}

	private void HEKMNCEDPIP()
	{
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		if (KNOIHBHLPHJ.Count == 0 || MainUI.IsAnyUIOpen(JIIGOACEIKL) || (CursorManager.CMDGPJEIIJI(JIIGOACEIKL).LALPELGNIJB() && DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DBAEGBDEPFK()))
		{
			EPNCNFIFHKK = null;
		}
		else if (Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			EPNCNFIFHKK = FLDDAIONMNB.placeable.inputByProximity;
		}
		else
		{
			KEPNDJDKMMO.Clear();
			JAKCENHIJJC = false;
			for (MENBAFNNBFB = 0; MENBAFNNBFB < KNOIHBHLPHJ.Count; MENBAFNNBFB += 0)
			{
				if (Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB]) && KNOIHBHLPHJ[MENBAFNNBFB].HLDFEKIDJAK(JIIGOACEIKL))
				{
					if (DecorationMode.IECFJGHAIDO(JIIGOACEIKL).MDOKKKHKKKE() && Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable) && (Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable.itemSpace != (Object)null)
					{
						JAKCENHIJJC = false;
						break;
					}
					KIBOMMJNDDN = Utils.LFOGGLLPPBI(Vector2.op_Implicit(((Component)KNOIHBHLPHJ[MENBAFNNBFB]).transform.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position), KIBOMMJNDDN);
					if (KIBOMMJNDDN == FJHKGBNBNKL.FCGBJEIIMBC)
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
					else if (MFKIKBFPKMH(KNOIHBHLPHJ[MENBAFNNBFB]))
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
				}
			}
			if (JAKCENHIJJC)
			{
				EPNCNFIFHKK = FFEJHHFJEOP(KNOIHBHLPHJ, CLNJDFFMGDL: true);
			}
			else if (KEPNDJDKMMO.Count > 0)
			{
				EPNCNFIFHKK = NHEHKIFMADF(KEPNDJDKMMO, JOLKJNACDDE: false);
			}
			else
			{
				EPNCNFIFHKK = NHEHKIFMADF(KNOIHBHLPHJ, JOLKJNACDDE: true);
			}
		}
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, EPNCNFIFHKK.actionButtonsPoint.position);
		}
		if (!((Object)(object)EPNCNFIFHKK != (Object)(object)BOJOHALHFJH) || (!((Object)(object)EPNCNFIFHKK == (Object)null) && !((Object)(object)EPNCNFIFHKK.placeable == (Object)null) && EPNCNFIFHKK.placeable.attachedToPlayer))
		{
			return;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		if (Object.op_Implicit((Object)(object)BOJOHALHFJH))
		{
			if (BOJOHALHFJH.playerToHover == JIIGOACEIKL)
			{
				BOJOHALHFJH.playerToHover = 1;
			}
			BOJOHALHFJH.LAEDMIPNGPJ(JIIGOACEIKL);
		}
		BOJOHALHFJH = EPNCNFIFHKK;
	}

	private void KIBCOOMAOGI(ITool EOOFAGCLEME)
	{
		EOOFAGCLEME?.LBMKLIDKHJD(JIIGOACEIKL);
	}

	public Vector3 DAKHPLLBEAJ()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			return ((Component)EPNCNFIFHKK).transform.position;
		}
		return ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
	}

	public Vector3 GPNAENFPFOE()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			return ((Component)EPNCNFIFHKK).transform.position;
		}
		return ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
	}

	public void GPBFCGNNMPM(InputByProximity FDGJJPGOKNG)
	{
		if (!KNOIHBHLPHJ.Contains(FDGJJPGOKNG))
		{
			KNOIHBHLPHJ.Add(FDGJJPGOKNG);
		}
	}

	private void COIFEAKALBC(InputByProximity LFBNPHHABDK)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
		LFBNPHHABDK.DECOJGDAFNH(JIIGOACEIKL);
	}

	private InputByProximity NDDMFPDKBAP(List<InputByProximity> DOILBNGPBLK, bool JOLKJNACDDE)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		AMANLGEHNEO = null;
		KCNJFGGCGFF = 10000f;
		OIFDFAJPEKO = Quaternion.Euler(Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
		for (MENBAFNNBFB = 0; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB++)
		{
			if (Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) && (!JOLKJNACDDE || DOILBNGPBLK[MENBAFNNBFB].IsAvailableByProximity(JIIGOACEIKL)))
			{
				JFFMJCOLPDA = Quaternion.Euler(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
				AALLAMLNIDK = Mathf.Abs(Quaternion.Angle(OIFDFAJPEKO, JFFMJCOLPDA));
				if (NGMCJMADPAD(DOILBNGPBLK[MENBAFNNBFB]))
				{
					AALLAMLNIDK = float.MinValue;
				}
				if (AALLAMLNIDK < KCNJFGGCGFF)
				{
					AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
					KCNJFGGCGFF = AALLAMLNIDK;
				}
			}
		}
		return AMANLGEHNEO;
	}

	public void MNHMHGOGLEK(InputByProximity FDGJJPGOKNG)
	{
		if (!KNOIHBHLPHJ.Contains(FDGJJPGOKNG))
		{
			KNOIHBHLPHJ.Add(FDGJJPGOKNG);
		}
	}

	public static InputByProximityManager JOFDIPFMIHF(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private bool CMGOACOKMIL(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		ITool tool = GJIDLADLNKA(EOOFAGCLEME, ACFLBADEHDN);
		if (tool != null && !Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			if (AKOBBMKGIFK != null && AKOBBMKGIFK != tool)
			{
				KIBCOOMAOGI(AKOBBMKGIFK);
				AKOBBMKGIFK = null;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
			if (tool.NBFBPMNMBJG(JIIGOACEIKL))
			{
				if ((Object)(object)BOJOHALHFJH != (Object)null)
				{
					BOJOHALHFJH.BJCDFHFKEGG(JIIGOACEIKL);
				}
				BOJOHALHFJH = null;
				FPDGCCDAAKO = false;
				AKOBBMKGIFK = tool;
				tool.AONJJGAIDBG(JIIGOACEIKL);
				tool.HEKGALMDLIL(JIIGOACEIKL);
				return true;
			}
			tool.LBMKLIDKHJD(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public Vector3 JKNOPBDCAPO()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			return ((Component)EPNCNFIFHKK).transform.position;
		}
		return ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
	}

	public InputByProximity HOMHFEJHKIF()
	{
		return EPNCNFIFHKK;
	}

	public static InputByProximityManager CMDGPJEIIJI(int JIIGOACEIKL)
	{
		if (!DOJCKFPNIPD(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public Vector3 CNJNBFFPJHJ()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			return ((Component)EPNCNFIFHKK).transform.position;
		}
		return ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
	}

	public void BOKEMDHLIBA()
	{
		EPNCNFIFHKK = null;
	}

	private ITool DNDDEEJGADF(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		if (EOOFAGCLEME != null)
		{
			return EOOFAGCLEME;
		}
		return ACFLBADEHDN;
	}

	private void NCHCNDMMMCL(InputByProximity LFBNPHHABDK)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
		LFBNPHHABDK.DECOJGDAFNH(JIIGOACEIKL);
	}

	private InputByProximity LGEILKJPCBK(List<InputByProximity> DOILBNGPBLK, bool CLNJDFFMGDL)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		EFLJMIPFNHD = 1944f;
		AMANLGEHNEO = null;
		for (MENBAFNNBFB = 1; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB += 0)
		{
			if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) || !DOILBNGPBLK[MENBAFNNBFB].HLDFEKIDJAK(JIIGOACEIKL))
			{
				continue;
			}
			if (CLNJDFFMGDL)
			{
				if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.itemSpace != (Object)null) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider != (Object)null))
				{
					continue;
				}
				Vector2 val = Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL));
				Bounds bounds = DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider.bounds;
				MIJLMAIEEHB = Vector2.Distance(val, Vector2.op_Implicit(((Bounds)(ref bounds)).ClosestPoint(PlayerController.GetPlayerPosition(JIIGOACEIKL))));
			}
			else
			{
				MIJLMAIEEHB = Vector2.Distance(Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL)), Vector2.op_Implicit(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position));
			}
			if (MIJLMAIEEHB < EFLJMIPFNHD)
			{
				AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
				EFLJMIPFNHD = MIJLMAIEEHB;
			}
		}
		return AMANLGEHNEO;
	}

	public static InputByProximityManager OGKNJNINGMH(int JIIGOACEIKL)
	{
		if (!CKKLEAOACOJ(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public static InputByProximityManager FLOIJFPDJGG(int JIIGOACEIKL)
	{
		if (!GKHDOONMOHL(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void MFGANCCJFJK()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		FLDDAIONMNB = ((Component)this).GetComponent<SelectObject>();
		IFMOJAMENPG(this);
	}

	private void MDDJAAEGOKN(InputByProximity LFBNPHHABDK)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
		LFBNPHHABDK.BCGBODLPDEB(JIIGOACEIKL);
	}

	private InputByProximity FLCHPBAOBPE(List<InputByProximity> DOILBNGPBLK, bool JOLKJNACDDE)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		AMANLGEHNEO = null;
		KCNJFGGCGFF = 1880f;
		OIFDFAJPEKO = Quaternion.Euler(Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
		for (MENBAFNNBFB = 1; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB += 0)
		{
			if (Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) && (!JOLKJNACDDE || DOILBNGPBLK[MENBAFNNBFB].HLDFEKIDJAK(JIIGOACEIKL)))
			{
				JFFMJCOLPDA = Quaternion.Euler(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
				AALLAMLNIDK = Mathf.Abs(Quaternion.Angle(OIFDFAJPEKO, JFFMJCOLPDA));
				if (CJGCOELLGDH(DOILBNGPBLK[MENBAFNNBFB]))
				{
					AALLAMLNIDK = 374f;
				}
				if (AALLAMLNIDK < KCNJFGGCGFF)
				{
					AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
					KCNJFGGCGFF = AALLAMLNIDK;
				}
			}
		}
		return AMANLGEHNEO;
	}

	public void DDDAKPKKFKJ()
	{
		EOOFAGCLEME = ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL).GetSelectedItem() as ITool;
		ACFLBADEHDN = ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JHDFIPFOHDP() as ToolInstance;
		if (!HLCDIKGAMGJ(EOOFAGCLEME, ACFLBADEHDN) && FPDGCCDAAKO)
		{
			FPDGCCDAAKO = false;
			KIBCOOMAOGI(AKOBBMKGIFK);
			AKOBBMKGIFK = null;
		}
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE && !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).IBEFDKHFBFM())
		{
			if (ConstructionActionBarUI.currentPanel != 1)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
				EPNCNFIFHKK = null;
			}
			return;
		}
		NMNAKPILMBE();
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			if ((Object)(object)EPNCNFIFHKK.placeable == (Object)null || !EPNCNFIFHKK.placeable.attachedToPlayer)
			{
				HJJIFLPPIBO(EPNCNFIFHKK);
			}
			EPNCNFIFHKK.AOEOBNOPLIG(JIIGOACEIKL);
		}
	}

	private ITool BCONKAHCJDF(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		if (EOOFAGCLEME != null)
		{
			return EOOFAGCLEME;
		}
		return ACFLBADEHDN;
	}

	private void PCJMBBJBKHG()
	{
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		if (KNOIHBHLPHJ.Count == 0 || MainUI.IsAnyUIOpen(JIIGOACEIKL) || (CursorManager.CMDGPJEIIJI(JIIGOACEIKL).LALPELGNIJB() && DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).GABNNLJOMHI()))
		{
			EPNCNFIFHKK = null;
		}
		else if (Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			EPNCNFIFHKK = FLDDAIONMNB.placeable.inputByProximity;
		}
		else
		{
			KEPNDJDKMMO.Clear();
			JAKCENHIJJC = true;
			for (MENBAFNNBFB = 1; MENBAFNNBFB < KNOIHBHLPHJ.Count; MENBAFNNBFB++)
			{
				if (Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB]) && KNOIHBHLPHJ[MENBAFNNBFB].HLDFEKIDJAK(JIIGOACEIKL))
				{
					if (DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DFNMDDHOIJI() && Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable) && (Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable.itemSpace != (Object)null)
					{
						JAKCENHIJJC = false;
						break;
					}
					KIBOMMJNDDN = Utils.LFOGGLLPPBI(Vector2.op_Implicit(((Component)KNOIHBHLPHJ[MENBAFNNBFB]).transform.position - ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position), KIBOMMJNDDN);
					if (KIBOMMJNDDN == FJHKGBNBNKL.FCGBJEIIMBC)
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
					else if (CJGCOELLGDH(KNOIHBHLPHJ[MENBAFNNBFB]))
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
				}
			}
			if (JAKCENHIJJC)
			{
				EPNCNFIFHKK = FFEJHHFJEOP(KNOIHBHLPHJ, CLNJDFFMGDL: true);
			}
			else if (KEPNDJDKMMO.Count > 1)
			{
				EPNCNFIFHKK = FPHKPBPJEPI(KEPNDJDKMMO, JOLKJNACDDE: true);
			}
			else
			{
				EPNCNFIFHKK = FLCHPBAOBPE(KNOIHBHLPHJ, JOLKJNACDDE: false);
			}
		}
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, EPNCNFIFHKK.actionButtonsPoint.position);
		}
		if (!((Object)(object)EPNCNFIFHKK != (Object)(object)BOJOHALHFJH) || (!((Object)(object)EPNCNFIFHKK == (Object)null) && !((Object)(object)EPNCNFIFHKK.placeable == (Object)null) && EPNCNFIFHKK.placeable.attachedToPlayer))
		{
			return;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		if (Object.op_Implicit((Object)(object)BOJOHALHFJH))
		{
			if (BOJOHALHFJH.playerToHover == JIIGOACEIKL)
			{
				BOJOHALHFJH.playerToHover = 0;
			}
			BOJOHALHFJH.KMPILLCNJPC(JIIGOACEIKL);
		}
		BOJOHALHFJH = EPNCNFIFHKK;
	}

	public void RemoveInputNearPlayer(InputByProximity FDGJJPGOKNG)
	{
		if (KNOIHBHLPHJ.Contains(FDGJJPGOKNG))
		{
			KNOIHBHLPHJ.Remove(FDGJJPGOKNG);
		}
	}

	private void DKJFCCLJAPD(InputByProximity LFBNPHHABDK)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
		LFBNPHHABDK.LFNJAANBPLK(JIIGOACEIKL);
	}

	public void MBLNNMEGJBG()
	{
		EOOFAGCLEME = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JDAFPKOHJPC() as ITool;
		ACFLBADEHDN = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true).GetSelectedItemInstance() as ToolInstance;
		if (!LNALFMDLFFN(EOOFAGCLEME, ACFLBADEHDN) && FPDGCCDAAKO)
		{
			FPDGCCDAAKO = true;
			PHNJOFIMJHM(AKOBBMKGIFK);
			AKOBBMKGIFK = null;
		}
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE && !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DBAEGBDEPFK())
		{
			if (ConstructionActionBarUI.currentPanel != 6)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
				EPNCNFIFHKK = null;
			}
			return;
		}
		NMNAKPILMBE();
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			if ((Object)(object)EPNCNFIFHKK.placeable == (Object)null || !EPNCNFIFHKK.placeable.attachedToPlayer)
			{
				COIFEAKALBC(EPNCNFIFHKK);
			}
			EPNCNFIFHKK.PNFKIHGMBLG(JIIGOACEIKL);
		}
	}

	private void KBLEJDFHIHJ(InputByProximity LFBNPHHABDK)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
		LFBNPHHABDK.LFNJAANBPLK(JIIGOACEIKL);
	}

	public Vector3 LOFIDLJMBMB()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			return ((Component)EPNCNFIFHKK).transform.position;
		}
		return ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
	}

	private static void IFMOJAMENPG(InputByProximityManager HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"</color>\n");
			return;
		}
		for (int i = 0; i < GJBBNHCMNJN.Length; i += 0)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"Items/item_name_1104");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private void Awake()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		FLDDAIONMNB = ((Component)this).GetComponent<SelectObject>();
		CAAMEEBOAOF(this);
	}

	private void NLFHFPHDNCF()
	{
		FJHKGBNBNKL = ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).GetComponent<CharacterAnimation>();
	}

	private static void CAAMEEBOAOF(InputByProximityManager HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"Trying to add a player that's already on the list.");
			return;
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i++)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"Trying to add player but player list is full.");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	public Vector3 JLMOIKMEIFI()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			return ((Component)EPNCNFIFHKK).transform.position;
		}
		return ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
	}

	private void OnHover(InputByProximity LFBNPHHABDK)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
		LFBNPHHABDK.OnHover(JIIGOACEIKL);
	}

	public Vector3 MADBFHLAGBN()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			return ((Component)EPNCNFIFHKK).transform.position;
		}
		return ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
	}

	private InputByProximity CJBPAHPFJBE(List<InputByProximity> DOILBNGPBLK, bool CLNJDFFMGDL)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		EFLJMIPFNHD = 1786f;
		AMANLGEHNEO = null;
		for (MENBAFNNBFB = 0; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB += 0)
		{
			if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) || !DOILBNGPBLK[MENBAFNNBFB].IsAvailableByProximity(JIIGOACEIKL))
			{
				continue;
			}
			if (CLNJDFFMGDL)
			{
				if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.itemSpace != (Object)null) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider != (Object)null))
				{
					continue;
				}
				Vector2 val = Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL));
				Bounds bounds = DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider.bounds;
				MIJLMAIEEHB = Vector2.Distance(val, Vector2.op_Implicit(((Bounds)(ref bounds)).ClosestPoint(PlayerController.GetPlayerPosition(JIIGOACEIKL))));
			}
			else
			{
				MIJLMAIEEHB = Vector2.Distance(Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL)), Vector2.op_Implicit(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position));
			}
			if (MIJLMAIEEHB < EFLJMIPFNHD)
			{
				AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
				EFLJMIPFNHD = MIJLMAIEEHB;
			}
		}
		return AMANLGEHNEO;
	}

	private void DNBGIIGAKMJ()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		FLDDAIONMNB = ((Component)this).GetComponent<SelectObject>();
		MPBPEPLBDPK(this);
	}

	private InputByProximity CKCJPKFODBI(List<InputByProximity> DOILBNGPBLK, bool JOLKJNACDDE)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		AMANLGEHNEO = null;
		KCNJFGGCGFF = 565f;
		OIFDFAJPEKO = Quaternion.Euler(Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
		for (MENBAFNNBFB = 0; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB++)
		{
			if (Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) && (!JOLKJNACDDE || DOILBNGPBLK[MENBAFNNBFB].HLDFEKIDJAK(JIIGOACEIKL)))
			{
				JFFMJCOLPDA = Quaternion.Euler(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
				AALLAMLNIDK = Mathf.Abs(Quaternion.Angle(OIFDFAJPEKO, JFFMJCOLPDA));
				if (NGMCJMADPAD(DOILBNGPBLK[MENBAFNNBFB]))
				{
					AALLAMLNIDK = 511f;
				}
				if (AALLAMLNIDK < KCNJFGGCGFF)
				{
					AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
					KCNJFGGCGFF = AALLAMLNIDK;
				}
			}
		}
		return AMANLGEHNEO;
	}

	private void HAJDAIKJMMC()
	{
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		if (KNOIHBHLPHJ.Count == 0 || MainUI.IsAnyUIOpen(JIIGOACEIKL) || (CursorManager.GetPlayer(JIIGOACEIKL).LALPELGNIJB() && DecorationMode.HBDCJFLINDA(JIIGOACEIKL).MDOKKKHKKKE()))
		{
			EPNCNFIFHKK = null;
		}
		else if (Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			EPNCNFIFHKK = FLDDAIONMNB.placeable.inputByProximity;
		}
		else
		{
			KEPNDJDKMMO.Clear();
			JAKCENHIJJC = true;
			for (MENBAFNNBFB = 0; MENBAFNNBFB < KNOIHBHLPHJ.Count; MENBAFNNBFB += 0)
			{
				if (Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB]) && KNOIHBHLPHJ[MENBAFNNBFB].IsAvailableByProximity(JIIGOACEIKL))
				{
					if (DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).IDPGEBNGDJD() && Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable) && (Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable.itemSpace != (Object)null)
					{
						JAKCENHIJJC = false;
						break;
					}
					KIBOMMJNDDN = Utils.LFOGGLLPPBI(Vector2.op_Implicit(((Component)KNOIHBHLPHJ[MENBAFNNBFB]).transform.position - ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position), KIBOMMJNDDN);
					if (KIBOMMJNDDN == FJHKGBNBNKL.FCGBJEIIMBC)
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
					else if (CJGCOELLGDH(KNOIHBHLPHJ[MENBAFNNBFB]))
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
				}
			}
			if (JAKCENHIJJC)
			{
				EPNCNFIFHKK = IDIAEKKIENC(KNOIHBHLPHJ, CLNJDFFMGDL: true);
			}
			else if (KEPNDJDKMMO.Count > 0)
			{
				EPNCNFIFHKK = FLCHPBAOBPE(KEPNDJDKMMO, JOLKJNACDDE: false);
			}
			else
			{
				EPNCNFIFHKK = CKCJPKFODBI(KNOIHBHLPHJ, JOLKJNACDDE: false);
			}
		}
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			ButtonsContext.SetPosition(JIIGOACEIKL, EPNCNFIFHKK.actionButtonsPoint.position);
		}
		if (!((Object)(object)EPNCNFIFHKK != (Object)(object)BOJOHALHFJH) || (!((Object)(object)EPNCNFIFHKK == (Object)null) && !((Object)(object)EPNCNFIFHKK.placeable == (Object)null) && EPNCNFIFHKK.placeable.attachedToPlayer))
		{
			return;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		if (Object.op_Implicit((Object)(object)BOJOHALHFJH))
		{
			if (BOJOHALHFJH.playerToHover == JIIGOACEIKL)
			{
				BOJOHALHFJH.playerToHover = 1;
			}
			BOJOHALHFJH.KMPILLCNJPC(JIIGOACEIKL);
		}
		BOJOHALHFJH = EPNCNFIFHKK;
	}

	public InputByProximity ABGDFIDOCCL()
	{
		return EPNCNFIFHKK;
	}

	public void IJDOAOOEHEN(InputByProximity FDGJJPGOKNG)
	{
		if (!KNOIHBHLPHJ.Contains(FDGJJPGOKNG))
		{
			KNOIHBHLPHJ.Add(FDGJJPGOKNG);
		}
	}

	private void GHKECMLMFNK()
	{
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		if (KNOIHBHLPHJ.Count == 0 || MainUI.IsAnyUIOpen(JIIGOACEIKL) || (CursorManager.CMDGPJEIIJI(JIIGOACEIKL).LALPELGNIJB() && DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).KNFEPKBIHND()))
		{
			EPNCNFIFHKK = null;
		}
		else if (Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			EPNCNFIFHKK = FLDDAIONMNB.placeable.inputByProximity;
		}
		else
		{
			KEPNDJDKMMO.Clear();
			JAKCENHIJJC = true;
			for (MENBAFNNBFB = 0; MENBAFNNBFB < KNOIHBHLPHJ.Count; MENBAFNNBFB += 0)
			{
				if (Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB]) && KNOIHBHLPHJ[MENBAFNNBFB].HLDFEKIDJAK(JIIGOACEIKL))
				{
					if (DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).IBEFDKHFBFM() && Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable) && (Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable.itemSpace != (Object)null)
					{
						JAKCENHIJJC = false;
						break;
					}
					KIBOMMJNDDN = Utils.LFOGGLLPPBI(Vector2.op_Implicit(((Component)KNOIHBHLPHJ[MENBAFNNBFB]).transform.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position), KIBOMMJNDDN);
					if (KIBOMMJNDDN == FJHKGBNBNKL.FCGBJEIIMBC)
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
					else if (EIHCIMCILPM(KNOIHBHLPHJ[MENBAFNNBFB]))
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
				}
			}
			if (JAKCENHIJJC)
			{
				EPNCNFIFHKK = CBENJCIJLPK(KNOIHBHLPHJ, CLNJDFFMGDL: true);
			}
			else if (KEPNDJDKMMO.Count > 0)
			{
				EPNCNFIFHKK = NDDMFPDKBAP(KEPNDJDKMMO, JOLKJNACDDE: false);
			}
			else
			{
				EPNCNFIFHKK = IHEAMHJPJIJ(KNOIHBHLPHJ, JOLKJNACDDE: false);
			}
		}
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, EPNCNFIFHKK.actionButtonsPoint.position);
		}
		if (!((Object)(object)EPNCNFIFHKK != (Object)(object)BOJOHALHFJH) || (!((Object)(object)EPNCNFIFHKK == (Object)null) && !((Object)(object)EPNCNFIFHKK.placeable == (Object)null) && EPNCNFIFHKK.placeable.attachedToPlayer))
		{
			return;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		if (Object.op_Implicit((Object)(object)BOJOHALHFJH))
		{
			if (BOJOHALHFJH.playerToHover == JIIGOACEIKL)
			{
				BOJOHALHFJH.playerToHover = 1;
			}
			BOJOHALHFJH.BJCDFHFKEGG(JIIGOACEIKL);
		}
		BOJOHALHFJH = EPNCNFIFHKK;
	}

	private InputByProximity AMKCECKADBA(List<InputByProximity> DOILBNGPBLK, bool CLNJDFFMGDL)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		EFLJMIPFNHD = 736f;
		AMANLGEHNEO = null;
		for (MENBAFNNBFB = 0; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB += 0)
		{
			if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) || !DOILBNGPBLK[MENBAFNNBFB].IsAvailableByProximity(JIIGOACEIKL))
			{
				continue;
			}
			if (CLNJDFFMGDL)
			{
				if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.itemSpace != (Object)null) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider != (Object)null))
				{
					continue;
				}
				Vector2 val = Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL));
				Bounds bounds = DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider.bounds;
				MIJLMAIEEHB = Vector2.Distance(val, Vector2.op_Implicit(((Bounds)(ref bounds)).ClosestPoint(PlayerController.GetPlayerPosition(JIIGOACEIKL))));
			}
			else
			{
				MIJLMAIEEHB = Vector2.Distance(Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL)), Vector2.op_Implicit(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position));
			}
			if (MIJLMAIEEHB < EFLJMIPFNHD)
			{
				AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
				EFLJMIPFNHD = MIJLMAIEEHB;
			}
		}
		return AMANLGEHNEO;
	}

	private ITool CPLOPJPMEDP(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		if (EOOFAGCLEME != null)
		{
			return EOOFAGCLEME;
		}
		return ACFLBADEHDN;
	}

	private static void KGLKHPDAHOP(InputByProximityManager HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)" : ");
			return;
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i += 0)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"Received RPC SetTrigger {0} on {1}. Setting animator parameter.");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private bool ACGPJFFEEDA(InputByProximity LPFGACEBMGD)
	{
		if ((Object)(object)LPFGACEBMGD.placeable == (Object)null)
		{
			return false;
		}
		if ((Object)(object)LPFGACEBMGD.placeable.itemSetup == (Object)null)
		{
			return false;
		}
		if (Item.GBMFCPGEJDK(LPFGACEBMGD.placeable.itemSetup.item, null))
		{
			return false;
		}
		if (LPFGACEBMGD.placeable.itemSetup.item.JDJGFAACPFC() == 116)
		{
			return false;
		}
		return false;
	}

	public InputByProximity GetCurrentFocusedInputElement()
	{
		return EPNCNFIFHKK;
	}

	public void NEILJDELEMN(InputByProximity FDGJJPGOKNG)
	{
		if (KNOIHBHLPHJ.Contains(FDGJJPGOKNG))
		{
			KNOIHBHLPHJ.Remove(FDGJJPGOKNG);
		}
	}

	public void GMCJIMELMKJ(InputByProximity FDGJJPGOKNG)
	{
		if (!KNOIHBHLPHJ.Contains(FDGJJPGOKNG))
		{
			KNOIHBHLPHJ.Add(FDGJJPGOKNG);
		}
	}

	private bool AOEDEKAPLMP(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		ITool tool = GJIDLADLNKA(EOOFAGCLEME, ACFLBADEHDN);
		if (tool != null && !Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			if (AKOBBMKGIFK != null && AKOBBMKGIFK != tool)
			{
				PHNJOFIMJHM(AKOBBMKGIFK);
				AKOBBMKGIFK = null;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
			if (tool.NBFBPMNMBJG(JIIGOACEIKL))
			{
				if ((Object)(object)BOJOHALHFJH != (Object)null)
				{
					BOJOHALHFJH.BJCDFHFKEGG(JIIGOACEIKL);
				}
				BOJOHALHFJH = null;
				FPDGCCDAAKO = false;
				AKOBBMKGIFK = tool;
				tool.AONJJGAIDBG(JIIGOACEIKL);
				tool.HEKGALMDLIL(JIIGOACEIKL);
				return true;
			}
			tool.LBMKLIDKHJD(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	private ITool OJNBDJCFLLL(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		if (EOOFAGCLEME != null)
		{
			return EOOFAGCLEME;
		}
		return ACFLBADEHDN;
	}

	public static InputByProximityManager GetPlayer(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public InputByProximity GDJNPPCMIBL()
	{
		return EPNCNFIFHKK;
	}

	private void PKNMLBCHEBH(ITool EOOFAGCLEME)
	{
		EOOFAGCLEME?.LBMKLIDKHJD(JIIGOACEIKL);
	}

	private InputByProximity FFEJHHFJEOP(List<InputByProximity> DOILBNGPBLK, bool CLNJDFFMGDL)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		EFLJMIPFNHD = 216f;
		AMANLGEHNEO = null;
		for (MENBAFNNBFB = 0; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB += 0)
		{
			if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) || !DOILBNGPBLK[MENBAFNNBFB].IsAvailableByProximity(JIIGOACEIKL))
			{
				continue;
			}
			if (CLNJDFFMGDL)
			{
				if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.itemSpace != (Object)null) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider != (Object)null))
				{
					continue;
				}
				Vector2 val = Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL));
				Bounds bounds = DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider.bounds;
				MIJLMAIEEHB = Vector2.Distance(val, Vector2.op_Implicit(((Bounds)(ref bounds)).ClosestPoint(PlayerController.GetPlayerPosition(JIIGOACEIKL))));
			}
			else
			{
				MIJLMAIEEHB = Vector2.Distance(Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL)), Vector2.op_Implicit(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position));
			}
			if (MIJLMAIEEHB < EFLJMIPFNHD)
			{
				AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
				EFLJMIPFNHD = MIJLMAIEEHB;
			}
		}
		return AMANLGEHNEO;
	}

	public Vector3 GKOPEPOFPIL()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			return ((Component)EPNCNFIFHKK).transform.position;
		}
		return ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
	}

	public InputByProximity GFCOOKLMLNE()
	{
		return EPNCNFIFHKK;
	}

	private void Start()
	{
		FJHKGBNBNKL = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).GetComponent<CharacterAnimation>();
	}

	public static InputByProximityManager HBDCJFLINDA(int JIIGOACEIKL)
	{
		if (!GKHDOONMOHL(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public void PFIHMJGLKBB(InputByProximity FDGJJPGOKNG)
	{
		if (!KNOIHBHLPHJ.Contains(FDGJJPGOKNG))
		{
			KNOIHBHLPHJ.Add(FDGJJPGOKNG);
		}
	}

	private void MOFIIKDJGKP(ITool EOOFAGCLEME)
	{
		EOOFAGCLEME?.LBMKLIDKHJD(JIIGOACEIKL);
	}

	private ITool GJIDLADLNKA(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		if (EOOFAGCLEME != null)
		{
			return EOOFAGCLEME;
		}
		return ACFLBADEHDN;
	}

	public void KHAKOECJPEG(InputByProximity FDGJJPGOKNG)
	{
		if (KNOIHBHLPHJ.Contains(FDGJJPGOKNG))
		{
			KNOIHBHLPHJ.Remove(FDGJJPGOKNG);
		}
	}

	public static InputByProximityManager MBDFOJAKELO(int JIIGOACEIKL)
	{
		if (!CKKLEAOACOJ(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private static void LDCIDHKOIPN(InputByProximityManager HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"RecieveEndEvent");
			return;
		}
		for (int i = 0; i < GJBBNHCMNJN.Length; i += 0)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"[SelectSpawnersByMaxDistance] Candidate {0} score:{1:F1} (entrance:{2:F1} mutual:{3:F1} altar:{4:F1} exit:{5:F1})");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private void FNPAJCJLCBM()
	{
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		if (KNOIHBHLPHJ.Count == 0 || MainUI.IsAnyUIOpen(JIIGOACEIKL) || (CursorManager.CMDGPJEIIJI(JIIGOACEIKL).LALPELGNIJB() && DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DMBFKFLDDLH))
		{
			EPNCNFIFHKK = null;
		}
		else if (Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			EPNCNFIFHKK = FLDDAIONMNB.placeable.inputByProximity;
		}
		else
		{
			KEPNDJDKMMO.Clear();
			JAKCENHIJJC = true;
			for (MENBAFNNBFB = 0; MENBAFNNBFB < KNOIHBHLPHJ.Count; MENBAFNNBFB++)
			{
				if (Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB]) && KNOIHBHLPHJ[MENBAFNNBFB].IsAvailableByProximity(JIIGOACEIKL))
				{
					if (DecorationMode.OCJGHINCLJM(JIIGOACEIKL).GABNNLJOMHI() && Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable) && (Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable.itemSpace != (Object)null)
					{
						JAKCENHIJJC = true;
						break;
					}
					KIBOMMJNDDN = Utils.LFOGGLLPPBI(Vector2.op_Implicit(((Component)KNOIHBHLPHJ[MENBAFNNBFB]).transform.position - ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position), KIBOMMJNDDN);
					if (KIBOMMJNDDN == FJHKGBNBNKL.FCGBJEIIMBC)
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
					else if (NGMCJMADPAD(KNOIHBHLPHJ[MENBAFNNBFB]))
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
				}
			}
			if (JAKCENHIJJC)
			{
				EPNCNFIFHKK = IDIMHPANEMG(KNOIHBHLPHJ, CLNJDFFMGDL: false);
			}
			else if (KEPNDJDKMMO.Count > 1)
			{
				EPNCNFIFHKK = NDDMFPDKBAP(KEPNDJDKMMO, JOLKJNACDDE: true);
			}
			else
			{
				EPNCNFIFHKK = IJJCCDDOPEN(KNOIHBHLPHJ, JOLKJNACDDE: true);
			}
		}
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			ButtonsContext.SetPosition(JIIGOACEIKL, EPNCNFIFHKK.actionButtonsPoint.position);
		}
		if (!((Object)(object)EPNCNFIFHKK != (Object)(object)BOJOHALHFJH) || (!((Object)(object)EPNCNFIFHKK == (Object)null) && !((Object)(object)EPNCNFIFHKK.placeable == (Object)null) && EPNCNFIFHKK.placeable.attachedToPlayer))
		{
			return;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		if (Object.op_Implicit((Object)(object)BOJOHALHFJH))
		{
			if (BOJOHALHFJH.playerToHover == JIIGOACEIKL)
			{
				BOJOHALHFJH.playerToHover = 0;
			}
			BOJOHALHFJH.KMPILLCNJPC(JIIGOACEIKL);
		}
		BOJOHALHFJH = EPNCNFIFHKK;
	}

	private InputByProximity NHEHKIFMADF(List<InputByProximity> DOILBNGPBLK, bool JOLKJNACDDE)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		AMANLGEHNEO = null;
		KCNJFGGCGFF = 444f;
		OIFDFAJPEKO = Quaternion.Euler(Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
		for (MENBAFNNBFB = 0; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB += 0)
		{
			if (Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) && (!JOLKJNACDDE || DOILBNGPBLK[MENBAFNNBFB].IsAvailableByProximity(JIIGOACEIKL)))
			{
				JFFMJCOLPDA = Quaternion.Euler(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
				AALLAMLNIDK = Mathf.Abs(Quaternion.Angle(OIFDFAJPEKO, JFFMJCOLPDA));
				if (EIHCIMCILPM(DOILBNGPBLK[MENBAFNNBFB]))
				{
					AALLAMLNIDK = 872f;
				}
				if (AALLAMLNIDK < KCNJFGGCGFF)
				{
					AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
					KCNJFGGCGFF = AALLAMLNIDK;
				}
			}
		}
		return AMANLGEHNEO;
	}

	private static void MPBPEPLBDPK(InputByProximityManager HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"ReceiveStatus");
			return;
		}
		for (int i = 0; i < GJBBNHCMNJN.Length; i += 0)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"ScrollDown");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private InputByProximity FLMOBDCIICL(List<InputByProximity> DOILBNGPBLK, bool CLNJDFFMGDL)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		EFLJMIPFNHD = 10000f;
		AMANLGEHNEO = null;
		for (MENBAFNNBFB = 0; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB++)
		{
			if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) || !DOILBNGPBLK[MENBAFNNBFB].IsAvailableByProximity(JIIGOACEIKL))
			{
				continue;
			}
			if (CLNJDFFMGDL)
			{
				if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.itemSpace != (Object)null) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider != (Object)null))
				{
					continue;
				}
				Vector2 val = Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL));
				Bounds bounds = DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider.bounds;
				MIJLMAIEEHB = Vector2.Distance(val, Vector2.op_Implicit(((Bounds)(ref bounds)).ClosestPoint(PlayerController.GetPlayerPosition(JIIGOACEIKL))));
			}
			else
			{
				MIJLMAIEEHB = Vector2.Distance(Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL)), Vector2.op_Implicit(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position));
			}
			if (MIJLMAIEEHB < EFLJMIPFNHD)
			{
				AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
				EFLJMIPFNHD = MIJLMAIEEHB;
			}
		}
		return AMANLGEHNEO;
	}

	private void PHNJOFIMJHM(ITool EOOFAGCLEME)
	{
		EOOFAGCLEME?.LBMKLIDKHJD(JIIGOACEIKL);
	}

	private bool LNALFMDLFFN(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		ITool tool = CPLOPJPMEDP(EOOFAGCLEME, ACFLBADEHDN);
		if (tool != null && !Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			if (AKOBBMKGIFK != null && AKOBBMKGIFK != tool)
			{
				PKNMLBCHEBH(AKOBBMKGIFK);
				AKOBBMKGIFK = null;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
			if (tool.NBFBPMNMBJG(JIIGOACEIKL))
			{
				if ((Object)(object)BOJOHALHFJH != (Object)null)
				{
					BOJOHALHFJH.OffHover(JIIGOACEIKL);
				}
				BOJOHALHFJH = null;
				FPDGCCDAAKO = true;
				AKOBBMKGIFK = tool;
				tool.AONJJGAIDBG(JIIGOACEIKL);
				tool.HEKGALMDLIL(JIIGOACEIKL);
				return true;
			}
			tool.LBMKLIDKHJD(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	private void HJJIFLPPIBO(InputByProximity LFBNPHHABDK)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
		LFBNPHHABDK.DEEFMMKDBJB(JIIGOACEIKL);
	}

	private bool DMGPHEDPJKJ(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		ITool tool = FDKPJMJFNFC(EOOFAGCLEME, ACFLBADEHDN);
		if (tool != null && !Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			if (AKOBBMKGIFK != null && AKOBBMKGIFK != tool)
			{
				KIBCOOMAOGI(AKOBBMKGIFK);
				AKOBBMKGIFK = null;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
			if (tool.NBFBPMNMBJG(JIIGOACEIKL))
			{
				if ((Object)(object)BOJOHALHFJH != (Object)null)
				{
					BOJOHALHFJH.BJCDFHFKEGG(JIIGOACEIKL);
				}
				BOJOHALHFJH = null;
				FPDGCCDAAKO = false;
				AKOBBMKGIFK = tool;
				tool.AONJJGAIDBG(JIIGOACEIKL);
				tool.HEKGALMDLIL(JIIGOACEIKL);
				return false;
			}
			tool.LBMKLIDKHJD(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	private bool NNFBPCGNODH(InputByProximity LPFGACEBMGD)
	{
		if ((Object)(object)LPFGACEBMGD.placeable == (Object)null)
		{
			return false;
		}
		if ((Object)(object)LPFGACEBMGD.placeable.itemSetup == (Object)null)
		{
			return false;
		}
		if (Item.GBMFCPGEJDK(LPFGACEBMGD.placeable.itemSetup.item, null))
		{
			return false;
		}
		if (LPFGACEBMGD.placeable.itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == -63)
		{
			return false;
		}
		return false;
	}

	private void NMNAKPILMBE()
	{
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		if (KNOIHBHLPHJ.Count == 0 || MainUI.IsAnyUIOpen(JIIGOACEIKL) || (CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible() && DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH))
		{
			EPNCNFIFHKK = null;
		}
		else if (Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			EPNCNFIFHKK = FLDDAIONMNB.placeable.inputByProximity;
		}
		else
		{
			KEPNDJDKMMO.Clear();
			JAKCENHIJJC = false;
			for (MENBAFNNBFB = 0; MENBAFNNBFB < KNOIHBHLPHJ.Count; MENBAFNNBFB++)
			{
				if (Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB]) && KNOIHBHLPHJ[MENBAFNNBFB].IsAvailableByProximity(JIIGOACEIKL))
				{
					if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable) && (Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable.itemSpace != (Object)null)
					{
						JAKCENHIJJC = true;
						break;
					}
					KIBOMMJNDDN = Utils.LFOGGLLPPBI(Vector2.op_Implicit(((Component)KNOIHBHLPHJ[MENBAFNNBFB]).transform.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position), KIBOMMJNDDN);
					if (KIBOMMJNDDN == FJHKGBNBNKL.FCGBJEIIMBC)
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
					else if (NGMCJMADPAD(KNOIHBHLPHJ[MENBAFNNBFB]))
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
				}
			}
			if (JAKCENHIJJC)
			{
				EPNCNFIFHKK = FLMOBDCIICL(KNOIHBHLPHJ, CLNJDFFMGDL: true);
			}
			else if (KEPNDJDKMMO.Count > 0)
			{
				EPNCNFIFHKK = NDDMFPDKBAP(KEPNDJDKMMO, JOLKJNACDDE: false);
			}
			else
			{
				EPNCNFIFHKK = NDDMFPDKBAP(KNOIHBHLPHJ, JOLKJNACDDE: true);
			}
		}
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			ButtonsContext.SetPosition(JIIGOACEIKL, EPNCNFIFHKK.actionButtonsPoint.position);
		}
		if (!((Object)(object)EPNCNFIFHKK != (Object)(object)BOJOHALHFJH) || (!((Object)(object)EPNCNFIFHKK == (Object)null) && !((Object)(object)EPNCNFIFHKK.placeable == (Object)null) && EPNCNFIFHKK.placeable.attachedToPlayer))
		{
			return;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		if (Object.op_Implicit((Object)(object)BOJOHALHFJH))
		{
			if (BOJOHALHFJH.playerToHover == JIIGOACEIKL)
			{
				BOJOHALHFJH.playerToHover = 0;
			}
			BOJOHALHFJH.OffHover(JIIGOACEIKL);
		}
		BOJOHALHFJH = EPNCNFIFHKK;
	}

	private bool ABCDFMHKLJP(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		ITool tool = CPLOPJPMEDP(EOOFAGCLEME, ACFLBADEHDN);
		if (tool != null && !Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			if (AKOBBMKGIFK != null && AKOBBMKGIFK != tool)
			{
				MOFIIKDJGKP(AKOBBMKGIFK);
				AKOBBMKGIFK = null;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
			if (tool.NBFBPMNMBJG(JIIGOACEIKL))
			{
				if ((Object)(object)BOJOHALHFJH != (Object)null)
				{
					BOJOHALHFJH.OffHover(JIIGOACEIKL);
				}
				BOJOHALHFJH = null;
				FPDGCCDAAKO = false;
				AKOBBMKGIFK = tool;
				tool.AONJJGAIDBG(JIIGOACEIKL);
				tool.HEKGALMDLIL(JIIGOACEIKL);
				return true;
			}
			tool.LBMKLIDKHJD(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	private ITool PGPHEEFLHND(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		if (EOOFAGCLEME != null)
		{
			return EOOFAGCLEME;
		}
		return ACFLBADEHDN;
	}

	private InputByProximity KAFBEFDAOHD(List<InputByProximity> DOILBNGPBLK, bool CLNJDFFMGDL)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		EFLJMIPFNHD = 898f;
		AMANLGEHNEO = null;
		for (MENBAFNNBFB = 1; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB++)
		{
			if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) || !DOILBNGPBLK[MENBAFNNBFB].HLDFEKIDJAK(JIIGOACEIKL))
			{
				continue;
			}
			if (CLNJDFFMGDL)
			{
				if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.itemSpace != (Object)null) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider != (Object)null))
				{
					continue;
				}
				Vector2 val = Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL));
				Bounds bounds = DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider.bounds;
				MIJLMAIEEHB = Vector2.Distance(val, Vector2.op_Implicit(((Bounds)(ref bounds)).ClosestPoint(PlayerController.GetPlayerPosition(JIIGOACEIKL))));
			}
			else
			{
				MIJLMAIEEHB = Vector2.Distance(Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL)), Vector2.op_Implicit(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position));
			}
			if (MIJLMAIEEHB < EFLJMIPFNHD)
			{
				AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
				EFLJMIPFNHD = MIJLMAIEEHB;
			}
		}
		return AMANLGEHNEO;
	}

	private void MIKNFPCDLML()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		FLDDAIONMNB = ((Component)this).GetComponent<SelectObject>();
		IFMOJAMENPG(this);
	}

	public Vector3 POABHHPCDDP()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			return ((Component)EPNCNFIFHKK).transform.position;
		}
		return ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
	}

	private bool DCADIOLIIAD(InputByProximity LPFGACEBMGD)
	{
		if ((Object)(object)LPFGACEBMGD.placeable == (Object)null)
		{
			return true;
		}
		if ((Object)(object)LPFGACEBMGD.placeable.itemSetup == (Object)null)
		{
			return false;
		}
		if (Item.EKGNIODFJCO(LPFGACEBMGD.placeable.itemSetup.item, null))
		{
			return false;
		}
		if (LPFGACEBMGD.placeable.itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == -29)
		{
			return false;
		}
		return true;
	}

	private InputByProximity FPHKPBPJEPI(List<InputByProximity> DOILBNGPBLK, bool JOLKJNACDDE)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		AMANLGEHNEO = null;
		KCNJFGGCGFF = 162f;
		OIFDFAJPEKO = Quaternion.Euler(Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
		for (MENBAFNNBFB = 0; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB += 0)
		{
			if (Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) && (!JOLKJNACDDE || DOILBNGPBLK[MENBAFNNBFB].IsAvailableByProximity(JIIGOACEIKL)))
			{
				JFFMJCOLPDA = Quaternion.Euler(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
				AALLAMLNIDK = Mathf.Abs(Quaternion.Angle(OIFDFAJPEKO, JFFMJCOLPDA));
				if (NNFBPCGNODH(DOILBNGPBLK[MENBAFNNBFB]))
				{
					AALLAMLNIDK = 1938f;
				}
				if (AALLAMLNIDK < KCNJFGGCGFF)
				{
					AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
					KCNJFGGCGFF = AALLAMLNIDK;
				}
			}
		}
		return AMANLGEHNEO;
	}

	private InputByProximity CEMLJJNDBDL(List<InputByProximity> DOILBNGPBLK, bool CLNJDFFMGDL)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		EFLJMIPFNHD = 267f;
		AMANLGEHNEO = null;
		for (MENBAFNNBFB = 1; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB += 0)
		{
			if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) || !DOILBNGPBLK[MENBAFNNBFB].HLDFEKIDJAK(JIIGOACEIKL))
			{
				continue;
			}
			if (CLNJDFFMGDL)
			{
				if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.itemSpace != (Object)null) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider != (Object)null))
				{
					continue;
				}
				Vector2 val = Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL));
				Bounds bounds = DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider.bounds;
				MIJLMAIEEHB = Vector2.Distance(val, Vector2.op_Implicit(((Bounds)(ref bounds)).ClosestPoint(PlayerController.GetPlayerPosition(JIIGOACEIKL))));
			}
			else
			{
				MIJLMAIEEHB = Vector2.Distance(Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL)), Vector2.op_Implicit(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position));
			}
			if (MIJLMAIEEHB < EFLJMIPFNHD)
			{
				AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
				EFLJMIPFNHD = MIJLMAIEEHB;
			}
		}
		return AMANLGEHNEO;
	}

	private bool GOLPHCCBIJE(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		ITool tool = GJIDLADLNKA(EOOFAGCLEME, ACFLBADEHDN);
		if (tool != null && !Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			if (AKOBBMKGIFK != null && AKOBBMKGIFK != tool)
			{
				AALPBNELNNO(AKOBBMKGIFK);
				AKOBBMKGIFK = null;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
			if (tool.NBFBPMNMBJG(JIIGOACEIKL))
			{
				if ((Object)(object)BOJOHALHFJH != (Object)null)
				{
					BOJOHALHFJH.LAEDMIPNGPJ(JIIGOACEIKL);
				}
				BOJOHALHFJH = null;
				FPDGCCDAAKO = true;
				AKOBBMKGIFK = tool;
				tool.AONJJGAIDBG(JIIGOACEIKL);
				tool.HEKGALMDLIL(JIIGOACEIKL);
				return true;
			}
			tool.LBMKLIDKHJD(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	public void IHOKKCNJNLL()
	{
		EOOFAGCLEME = ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL).FGGKCJDFNEK() as ITool;
		ACFLBADEHDN = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KFDBMPDPJBF() as ToolInstance;
		if (!LONFLCBBIIO(EOOFAGCLEME, ACFLBADEHDN) && FPDGCCDAAKO)
		{
			FPDGCCDAAKO = true;
			AALPBNELNNO(AKOBBMKGIFK);
			AKOBBMKGIFK = null;
		}
		if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE && !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).GABNNLJOMHI())
		{
			if (ConstructionActionBarUI.currentPanel != 0)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
				EPNCNFIFHKK = null;
			}
			return;
		}
		GHKECMLMFNK();
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			if ((Object)(object)EPNCNFIFHKK.placeable == (Object)null || !EPNCNFIFHKK.placeable.attachedToPlayer)
			{
				HJJIFLPPIBO(EPNCNFIFHKK);
			}
			EPNCNFIFHKK.AOEOBNOPLIG(JIIGOACEIKL);
		}
	}

	private void PBFAEPOEKPG()
	{
		FJHKGBNBNKL = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).GetComponent<CharacterAnimation>();
	}

	private static bool KJLLBGGILAK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	public static InputByProximityManager DAEEJGKLOCF(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public static InputByProximityManager DFGOGIIPPPH(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private InputByProximity IHEAMHJPJIJ(List<InputByProximity> DOILBNGPBLK, bool JOLKJNACDDE)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		AMANLGEHNEO = null;
		KCNJFGGCGFF = 1745f;
		OIFDFAJPEKO = Quaternion.Euler(Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
		for (MENBAFNNBFB = 1; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB += 0)
		{
			if (Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) && (!JOLKJNACDDE || DOILBNGPBLK[MENBAFNNBFB].IsAvailableByProximity(JIIGOACEIKL)))
			{
				JFFMJCOLPDA = Quaternion.Euler(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position - ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position);
				AALLAMLNIDK = Mathf.Abs(Quaternion.Angle(OIFDFAJPEKO, JFFMJCOLPDA));
				if (CJGCOELLGDH(DOILBNGPBLK[MENBAFNNBFB]))
				{
					AALLAMLNIDK = 965f;
				}
				if (AALLAMLNIDK < KCNJFGGCGFF)
				{
					AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
					KCNJFGGCGFF = AALLAMLNIDK;
				}
			}
		}
		return AMANLGEHNEO;
	}

	private void HINGECEDJAP()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		FLDDAIONMNB = ((Component)this).GetComponent<SelectObject>();
		KGLKHPDAHOP(this);
	}

	public void BBDKBBJMKME()
	{
		EPNCNFIFHKK = null;
	}

	private void OKAPGNGLOHO()
	{
		FJHKGBNBNKL = ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).GetComponent<CharacterAnimation>();
	}

	public void GBAECGMIKFL(InputByProximity FDGJJPGOKNG)
	{
		if (!KNOIHBHLPHJ.Contains(FDGJJPGOKNG))
		{
			KNOIHBHLPHJ.Add(FDGJJPGOKNG);
		}
	}

	public void AddInputNearPlayer(InputByProximity FDGJJPGOKNG)
	{
		if (!KNOIHBHLPHJ.Contains(FDGJJPGOKNG))
		{
			KNOIHBHLPHJ.Add(FDGJJPGOKNG);
		}
	}

	private void MOOKDDEDCBB()
	{
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		if (KNOIHBHLPHJ.Count == 0 || MainUI.IsAnyUIOpen(JIIGOACEIKL) || (CursorManager.GetPlayer(JIIGOACEIKL).IHMADDCNKAM() && DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DFNMDDHOIJI()))
		{
			EPNCNFIFHKK = null;
		}
		else if (Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			EPNCNFIFHKK = FLDDAIONMNB.placeable.inputByProximity;
		}
		else
		{
			KEPNDJDKMMO.Clear();
			JAKCENHIJJC = true;
			for (MENBAFNNBFB = 1; MENBAFNNBFB < KNOIHBHLPHJ.Count; MENBAFNNBFB++)
			{
				if (Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB]) && KNOIHBHLPHJ[MENBAFNNBFB].IsAvailableByProximity(JIIGOACEIKL))
				{
					if (DecorationMode.HBDCJFLINDA(JIIGOACEIKL).MDOKKKHKKKE() && Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable) && (Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable.itemSpace != (Object)null)
					{
						JAKCENHIJJC = false;
						break;
					}
					KIBOMMJNDDN = Utils.LFOGGLLPPBI(Vector2.op_Implicit(((Component)KNOIHBHLPHJ[MENBAFNNBFB]).transform.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position), KIBOMMJNDDN);
					if (KIBOMMJNDDN == FJHKGBNBNKL.FCGBJEIIMBC)
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
					else if (ACGPJFFEEDA(KNOIHBHLPHJ[MENBAFNNBFB]))
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
				}
			}
			if (JAKCENHIJJC)
			{
				EPNCNFIFHKK = IDIMHPANEMG(KNOIHBHLPHJ, CLNJDFFMGDL: false);
			}
			else if (KEPNDJDKMMO.Count > 0)
			{
				EPNCNFIFHKK = NHEHKIFMADF(KEPNDJDKMMO, JOLKJNACDDE: true);
			}
			else
			{
				EPNCNFIFHKK = NDDMFPDKBAP(KNOIHBHLPHJ, JOLKJNACDDE: false);
			}
		}
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, EPNCNFIFHKK.actionButtonsPoint.position);
		}
		if (!((Object)(object)EPNCNFIFHKK != (Object)(object)BOJOHALHFJH) || (!((Object)(object)EPNCNFIFHKK == (Object)null) && !((Object)(object)EPNCNFIFHKK.placeable == (Object)null) && EPNCNFIFHKK.placeable.attachedToPlayer))
		{
			return;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		if (Object.op_Implicit((Object)(object)BOJOHALHFJH))
		{
			if (BOJOHALHFJH.playerToHover == JIIGOACEIKL)
			{
				BOJOHALHFJH.playerToHover = 1;
			}
			BOJOHALHFJH.OffHover(JIIGOACEIKL);
		}
		BOJOHALHFJH = EPNCNFIFHKK;
	}

	private bool CJGCOELLGDH(InputByProximity LPFGACEBMGD)
	{
		if ((Object)(object)LPFGACEBMGD.placeable == (Object)null)
		{
			return true;
		}
		if ((Object)(object)LPFGACEBMGD.placeable.itemSetup == (Object)null)
		{
			return false;
		}
		if (Item.GBMFCPGEJDK(LPFGACEBMGD.placeable.itemSetup.item, null))
		{
			return true;
		}
		if (LPFGACEBMGD.placeable.itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -111)
		{
			return true;
		}
		return true;
	}

	public Vector3 GetCurrentFocusedInputElementPosition()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			return ((Component)EPNCNFIFHKK).transform.position;
		}
		return ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
	}

	private bool MFKIKBFPKMH(InputByProximity LPFGACEBMGD)
	{
		if ((Object)(object)LPFGACEBMGD.placeable == (Object)null)
		{
			return false;
		}
		if ((Object)(object)LPFGACEBMGD.placeable.itemSetup == (Object)null)
		{
			return true;
		}
		if (Item.EKGNIODFJCO(LPFGACEBMGD.placeable.itemSetup.item, null))
		{
			return false;
		}
		if (LPFGACEBMGD.placeable.itemSetup.item.JGHNDJBCFAJ() == 191)
		{
			return false;
		}
		return true;
	}

	public void GCEBEHBFGEC()
	{
		EPNCNFIFHKK = null;
	}

	public void OIDGEKDHGPB()
	{
		EOOFAGCLEME = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSelectedItem() as ITool;
		ACFLBADEHDN = ActionBarInventory.GetPlayer(JIIGOACEIKL).MFDBJINDCAO() as ToolInstance;
		if (!GOLPHCCBIJE(EOOFAGCLEME, ACFLBADEHDN) && FPDGCCDAAKO)
		{
			FPDGCCDAAKO = false;
			MOFIIKDJGKP(AKOBBMKGIFK);
			AKOBBMKGIFK = null;
		}
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IDPGEBNGDJD())
		{
			if (ConstructionActionBarUI.currentPanel != 7)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
				EPNCNFIFHKK = null;
			}
			return;
		}
		PCJMBBJBKHG();
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			if ((Object)(object)EPNCNFIFHKK.placeable == (Object)null || !EPNCNFIFHKK.placeable.attachedToPlayer)
			{
				NCHCNDMMMCL(EPNCNFIFHKK);
			}
			EPNCNFIFHKK.AOEOBNOPLIG(JIIGOACEIKL);
		}
	}

	private void DCANBDGHBKC()
	{
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		if (KNOIHBHLPHJ.Count == 0 || MainUI.IsAnyUIOpen(JIIGOACEIKL) || (CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible() && DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DBAEGBDEPFK()))
		{
			EPNCNFIFHKK = null;
		}
		else if (Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			EPNCNFIFHKK = FLDDAIONMNB.placeable.inputByProximity;
		}
		else
		{
			KEPNDJDKMMO.Clear();
			JAKCENHIJJC = true;
			for (MENBAFNNBFB = 1; MENBAFNNBFB < KNOIHBHLPHJ.Count; MENBAFNNBFB += 0)
			{
				if (Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB]) && KNOIHBHLPHJ[MENBAFNNBFB].IsAvailableByProximity(JIIGOACEIKL))
				{
					if (DecorationMode.KKJABELKCNM(JIIGOACEIKL).GABNNLJOMHI() && Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable) && (Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable.itemSpace != (Object)null)
					{
						JAKCENHIJJC = true;
						break;
					}
					KIBOMMJNDDN = Utils.LFOGGLLPPBI(Vector2.op_Implicit(((Component)KNOIHBHLPHJ[MENBAFNNBFB]).transform.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position), KIBOMMJNDDN);
					if (KIBOMMJNDDN == FJHKGBNBNKL.FCGBJEIIMBC)
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
					else if (BFLJGMGHNCL(KNOIHBHLPHJ[MENBAFNNBFB]))
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
				}
			}
			if (JAKCENHIJJC)
			{
				EPNCNFIFHKK = CEMLJJNDBDL(KNOIHBHLPHJ, CLNJDFFMGDL: true);
			}
			else if (KEPNDJDKMMO.Count > 1)
			{
				EPNCNFIFHKK = FPHKPBPJEPI(KEPNDJDKMMO, JOLKJNACDDE: true);
			}
			else
			{
				EPNCNFIFHKK = NHEHKIFMADF(KNOIHBHLPHJ, JOLKJNACDDE: false);
			}
		}
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			ButtonsContext.SetPosition(JIIGOACEIKL, EPNCNFIFHKK.actionButtonsPoint.position);
		}
		if (!((Object)(object)EPNCNFIFHKK != (Object)(object)BOJOHALHFJH) || (!((Object)(object)EPNCNFIFHKK == (Object)null) && !((Object)(object)EPNCNFIFHKK.placeable == (Object)null) && EPNCNFIFHKK.placeable.attachedToPlayer))
		{
			return;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		if (Object.op_Implicit((Object)(object)BOJOHALHFJH))
		{
			if (BOJOHALHFJH.playerToHover == JIIGOACEIKL)
			{
				BOJOHALHFJH.playerToHover = 0;
			}
			BOJOHALHFJH.BJCDFHFKEGG(JIIGOACEIKL);
		}
		BOJOHALHFJH = EPNCNFIFHKK;
	}

	public void FLABOBMCCEC(InputByProximity FDGJJPGOKNG)
	{
		if (KNOIHBHLPHJ.Contains(FDGJJPGOKNG))
		{
			KNOIHBHLPHJ.Remove(FDGJJPGOKNG);
		}
	}

	public void PMNFONNIDKH(InputByProximity FDGJJPGOKNG)
	{
		if (KNOIHBHLPHJ.Contains(FDGJJPGOKNG))
		{
			KNOIHBHLPHJ.Remove(FDGJJPGOKNG);
		}
	}

	public Vector3 BLIBJGLFCKA()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			return ((Component)EPNCNFIFHKK).transform.position;
		}
		return ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
	}

	public Vector3 OBFLHEHLFJA()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			return ((Component)EPNCNFIFHKK).transform.position;
		}
		return ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
	}

	private static bool GDHLGONLGOO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return true;
		}
		return false;
	}

	private ITool OKKIKIKNOFF(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		if (EOOFAGCLEME != null)
		{
			return EOOFAGCLEME;
		}
		return ACFLBADEHDN;
	}

	public void KPEMEFNHBDK()
	{
		EPNCNFIFHKK = null;
	}

	public static InputByProximityManager NMGNGAEEKIO(int JIIGOACEIKL)
	{
		if (!GKHDOONMOHL(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public void PCNNOADOGDP(InputByProximity FDGJJPGOKNG)
	{
		if (!KNOIHBHLPHJ.Contains(FDGJJPGOKNG))
		{
			KNOIHBHLPHJ.Add(FDGJJPGOKNG);
		}
	}

	private InputByProximity MIBLKPDECNK(List<InputByProximity> DOILBNGPBLK, bool CLNJDFFMGDL)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		EFLJMIPFNHD = 1734f;
		AMANLGEHNEO = null;
		for (MENBAFNNBFB = 0; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB += 0)
		{
			if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) || !DOILBNGPBLK[MENBAFNNBFB].HLDFEKIDJAK(JIIGOACEIKL))
			{
				continue;
			}
			if (CLNJDFFMGDL)
			{
				if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.itemSpace != (Object)null) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider != (Object)null))
				{
					continue;
				}
				Vector2 val = Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL));
				Bounds bounds = DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider.bounds;
				MIJLMAIEEHB = Vector2.Distance(val, Vector2.op_Implicit(((Bounds)(ref bounds)).ClosestPoint(PlayerController.GetPlayerPosition(JIIGOACEIKL))));
			}
			else
			{
				MIJLMAIEEHB = Vector2.Distance(Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL)), Vector2.op_Implicit(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position));
			}
			if (MIJLMAIEEHB < EFLJMIPFNHD)
			{
				AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
				EFLJMIPFNHD = MIJLMAIEEHB;
			}
		}
		return AMANLGEHNEO;
	}

	private ITool OHBMCBCIHBH(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		if (EOOFAGCLEME != null)
		{
			return EOOFAGCLEME;
		}
		return ACFLBADEHDN;
	}

	private static bool MKGFGPPMBGC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return true;
		}
		return false;
	}

	private static bool CKKLEAOACOJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return true;
		}
		return true;
	}

	private bool EODHMHMCNAK(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		ITool tool = GHLKHKCPCGB(EOOFAGCLEME, ACFLBADEHDN);
		if (tool != null && !Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			if (AKOBBMKGIFK != null && AKOBBMKGIFK != tool)
			{
				AALPBNELNNO(AKOBBMKGIFK);
				AKOBBMKGIFK = null;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
			if (tool.NBFBPMNMBJG(JIIGOACEIKL))
			{
				if ((Object)(object)BOJOHALHFJH != (Object)null)
				{
					BOJOHALHFJH.OffHover(JIIGOACEIKL);
				}
				BOJOHALHFJH = null;
				FPDGCCDAAKO = true;
				AKOBBMKGIFK = tool;
				tool.AONJJGAIDBG(JIIGOACEIKL);
				tool.HEKGALMDLIL(JIIGOACEIKL);
				return true;
			}
			tool.LBMKLIDKHJD(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	public Vector3 EINDAIFELGM()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			return ((Component)EPNCNFIFHKK).transform.position;
		}
		return ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
	}

	private InputByProximity IDIAEKKIENC(List<InputByProximity> DOILBNGPBLK, bool CLNJDFFMGDL)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		EFLJMIPFNHD = 235f;
		AMANLGEHNEO = null;
		for (MENBAFNNBFB = 0; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB += 0)
		{
			if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) || !DOILBNGPBLK[MENBAFNNBFB].HLDFEKIDJAK(JIIGOACEIKL))
			{
				continue;
			}
			if (CLNJDFFMGDL)
			{
				if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.itemSpace != (Object)null) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider != (Object)null))
				{
					continue;
				}
				Vector2 val = Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL));
				Bounds bounds = DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider.bounds;
				MIJLMAIEEHB = Vector2.Distance(val, Vector2.op_Implicit(((Bounds)(ref bounds)).ClosestPoint(PlayerController.GetPlayerPosition(JIIGOACEIKL))));
			}
			else
			{
				MIJLMAIEEHB = Vector2.Distance(Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL)), Vector2.op_Implicit(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position));
			}
			if (MIJLMAIEEHB < EFLJMIPFNHD)
			{
				AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
				EFLJMIPFNHD = MIJLMAIEEHB;
			}
		}
		return AMANLGEHNEO;
	}

	public void NFCJMIIEDGC()
	{
		EPNCNFIFHKK = null;
	}

	private InputByProximity IJJCCDDOPEN(List<InputByProximity> DOILBNGPBLK, bool JOLKJNACDDE)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		AMANLGEHNEO = null;
		KCNJFGGCGFF = 56f;
		OIFDFAJPEKO = Quaternion.Euler(Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
		for (MENBAFNNBFB = 0; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB++)
		{
			if (Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) && (!JOLKJNACDDE || DOILBNGPBLK[MENBAFNNBFB].HLDFEKIDJAK(JIIGOACEIKL)))
			{
				JFFMJCOLPDA = Quaternion.Euler(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
				AALLAMLNIDK = Mathf.Abs(Quaternion.Angle(OIFDFAJPEKO, JFFMJCOLPDA));
				if (DCADIOLIIAD(DOILBNGPBLK[MENBAFNNBFB]))
				{
					AALLAMLNIDK = 865f;
				}
				if (AALLAMLNIDK < KCNJFGGCGFF)
				{
					AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
					KCNJFGGCGFF = AALLAMLNIDK;
				}
			}
		}
		return AMANLGEHNEO;
	}

	private InputByProximity IDIMHPANEMG(List<InputByProximity> DOILBNGPBLK, bool CLNJDFFMGDL)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		EFLJMIPFNHD = 783f;
		AMANLGEHNEO = null;
		for (MENBAFNNBFB = 0; MENBAFNNBFB < DOILBNGPBLK.Count; MENBAFNNBFB++)
		{
			if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB]) || !DOILBNGPBLK[MENBAFNNBFB].HLDFEKIDJAK(JIIGOACEIKL))
			{
				continue;
			}
			if (CLNJDFFMGDL)
			{
				if (!Object.op_Implicit((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.itemSpace != (Object)null) || !((Object)(object)DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider != (Object)null))
				{
					continue;
				}
				Vector2 val = Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL));
				Bounds bounds = DOILBNGPBLK[MENBAFNNBFB].placeable.placeableCollider.bounds;
				MIJLMAIEEHB = Vector2.Distance(val, Vector2.op_Implicit(((Bounds)(ref bounds)).ClosestPoint(PlayerController.GetPlayerPosition(JIIGOACEIKL))));
			}
			else
			{
				MIJLMAIEEHB = Vector2.Distance(Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL)), Vector2.op_Implicit(((Component)DOILBNGPBLK[MENBAFNNBFB]).transform.position));
			}
			if (MIJLMAIEEHB < EFLJMIPFNHD)
			{
				AMANLGEHNEO = DOILBNGPBLK[MENBAFNNBFB];
				EFLJMIPFNHD = MIJLMAIEEHB;
			}
		}
		return AMANLGEHNEO;
	}

	private bool HLCDIKGAMGJ(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		ITool tool = CPLOPJPMEDP(EOOFAGCLEME, ACFLBADEHDN);
		if (tool != null && !Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			if (AKOBBMKGIFK != null && AKOBBMKGIFK != tool)
			{
				MOFIIKDJGKP(AKOBBMKGIFK);
				AKOBBMKGIFK = null;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
			if (tool.NBFBPMNMBJG(JIIGOACEIKL))
			{
				if ((Object)(object)BOJOHALHFJH != (Object)null)
				{
					BOJOHALHFJH.BJCDFHFKEGG(JIIGOACEIKL);
				}
				BOJOHALHFJH = null;
				FPDGCCDAAKO = true;
				AKOBBMKGIFK = tool;
				tool.AONJJGAIDBG(JIIGOACEIKL);
				tool.HEKGALMDLIL(JIIGOACEIKL);
				return false;
			}
			tool.LBMKLIDKHJD(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	private static bool GKHDOONMOHL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return true;
		}
		return true;
	}

	private void AALPBNELNNO(ITool EOOFAGCLEME)
	{
		EOOFAGCLEME?.LBMKLIDKHJD(JIIGOACEIKL);
	}

	public void OBPEBEMOGDL()
	{
		EOOFAGCLEME = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: true).FGGKCJDFNEK() as ITool;
		ACFLBADEHDN = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: true).BBBGBHPJOAG() as ToolInstance;
		if (!AOEDEKAPLMP(EOOFAGCLEME, ACFLBADEHDN) && FPDGCCDAAKO)
		{
			FPDGCCDAAKO = true;
			PHNJOFIMJHM(AKOBBMKGIFK);
			AKOBBMKGIFK = null;
		}
		if (TavernConstructionManager.DOIKFJDLKJP().LNLJMCONDNE && !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DMBFKFLDDLH)
		{
			if (ConstructionActionBarUI.currentPanel != 5)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
				EPNCNFIFHKK = null;
			}
			return;
		}
		PMCGLLEFBPJ();
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			if ((Object)(object)EPNCNFIFHKK.placeable == (Object)null || !EPNCNFIFHKK.placeable.attachedToPlayer)
			{
				OACAPFIFIOC(EPNCNFIFHKK);
			}
			EPNCNFIFHKK.AOEOBNOPLIG(JIIGOACEIKL);
		}
	}

	private void OACAPFIFIOC(InputByProximity LFBNPHHABDK)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
		LFBNPHHABDK.BCGBODLPDEB(JIIGOACEIKL);
	}

	public InputByProximity HBIKILDEHFI()
	{
		return EPNCNFIFHKK;
	}

	public void KAKEGCNNBCB(InputByProximity FDGJJPGOKNG)
	{
		if (KNOIHBHLPHJ.Contains(FDGJJPGOKNG))
		{
			KNOIHBHLPHJ.Remove(FDGJJPGOKNG);
		}
	}

	public void IMDKIGEHEPD()
	{
		EOOFAGCLEME = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL).FGGKCJDFNEK() as ITool;
		ACFLBADEHDN = ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JHDFIPFOHDP() as ToolInstance;
		if (!LNALFMDLFFN(EOOFAGCLEME, ACFLBADEHDN) && FPDGCCDAAKO)
		{
			FPDGCCDAAKO = true;
			PKNMLBCHEBH(AKOBBMKGIFK);
			AKOBBMKGIFK = null;
		}
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE && !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).IBEFDKHFBFM())
		{
			if (ConstructionActionBarUI.currentPanel != 5)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
				EPNCNFIFHKK = null;
			}
			return;
		}
		PMCGLLEFBPJ();
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			if ((Object)(object)EPNCNFIFHKK.placeable == (Object)null || !EPNCNFIFHKK.placeable.attachedToPlayer)
			{
				DKJFCCLJAPD(EPNCNFIFHKK);
			}
			EPNCNFIFHKK.PNFKIHGMBLG(JIIGOACEIKL);
		}
	}

	public static InputByProximityManager IJMLNIHAOGK(int JIIGOACEIKL)
	{
		if (!GDHLGONLGOO(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void PMCGLLEFBPJ()
	{
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		if (KNOIHBHLPHJ.Count == 0 || MainUI.IsAnyUIOpen(JIIGOACEIKL) || (CursorManager.GetPlayer(JIIGOACEIKL).IHMADDCNKAM() && DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DMBFKFLDDLH))
		{
			EPNCNFIFHKK = null;
		}
		else if (Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			EPNCNFIFHKK = FLDDAIONMNB.placeable.inputByProximity;
		}
		else
		{
			KEPNDJDKMMO.Clear();
			JAKCENHIJJC = false;
			for (MENBAFNNBFB = 0; MENBAFNNBFB < KNOIHBHLPHJ.Count; MENBAFNNBFB += 0)
			{
				if (Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB]) && KNOIHBHLPHJ[MENBAFNNBFB].HLDFEKIDJAK(JIIGOACEIKL))
				{
					if (DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DFNMDDHOIJI() && Object.op_Implicit((Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable) && (Object)(object)KNOIHBHLPHJ[MENBAFNNBFB].placeable.itemSpace != (Object)null)
					{
						JAKCENHIJJC = true;
						break;
					}
					KIBOMMJNDDN = Utils.LFOGGLLPPBI(Vector2.op_Implicit(((Component)KNOIHBHLPHJ[MENBAFNNBFB]).transform.position - ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position), KIBOMMJNDDN);
					if (KIBOMMJNDDN == FJHKGBNBNKL.FCGBJEIIMBC)
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
					else if (MFKIKBFPKMH(KNOIHBHLPHJ[MENBAFNNBFB]))
					{
						KEPNDJDKMMO.Add(KNOIHBHLPHJ[MENBAFNNBFB]);
					}
				}
			}
			if (JAKCENHIJJC)
			{
				EPNCNFIFHKK = FFEJHHFJEOP(KNOIHBHLPHJ, CLNJDFFMGDL: false);
			}
			else if (KEPNDJDKMMO.Count > 0)
			{
				EPNCNFIFHKK = FLCHPBAOBPE(KEPNDJDKMMO, JOLKJNACDDE: false);
			}
			else
			{
				EPNCNFIFHKK = NHEHKIFMADF(KNOIHBHLPHJ, JOLKJNACDDE: false);
			}
		}
		if (Object.op_Implicit((Object)(object)EPNCNFIFHKK))
		{
			ButtonsContext.SetPosition(JIIGOACEIKL, EPNCNFIFHKK.actionButtonsPoint.position);
		}
		if (!((Object)(object)EPNCNFIFHKK != (Object)(object)BOJOHALHFJH) || (!((Object)(object)EPNCNFIFHKK == (Object)null) && !((Object)(object)EPNCNFIFHKK.placeable == (Object)null) && EPNCNFIFHKK.placeable.attachedToPlayer))
		{
			return;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		if (Object.op_Implicit((Object)(object)BOJOHALHFJH))
		{
			if (BOJOHALHFJH.playerToHover == JIIGOACEIKL)
			{
				BOJOHALHFJH.playerToHover = 1;
			}
			BOJOHALHFJH.OffHover(JIIGOACEIKL);
		}
		BOJOHALHFJH = EPNCNFIFHKK;
	}

	private bool LONFLCBBIIO(ITool EOOFAGCLEME, ToolInstance ACFLBADEHDN)
	{
		ITool tool = GHLKHKCPCGB(EOOFAGCLEME, ACFLBADEHDN);
		if (tool != null && !Object.op_Implicit((Object)(object)FLDDAIONMNB.placeable))
		{
			if (AKOBBMKGIFK != null && AKOBBMKGIFK != tool)
			{
				PKNMLBCHEBH(AKOBBMKGIFK);
				AKOBBMKGIFK = null;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SoftResetButtons();
			if (tool.NBFBPMNMBJG(JIIGOACEIKL))
			{
				if ((Object)(object)BOJOHALHFJH != (Object)null)
				{
					BOJOHALHFJH.BJCDFHFKEGG(JIIGOACEIKL);
				}
				BOJOHALHFJH = null;
				FPDGCCDAAKO = true;
				AKOBBMKGIFK = tool;
				tool.AONJJGAIDBG(JIIGOACEIKL);
				tool.HEKGALMDLIL(JIIGOACEIKL);
				return true;
			}
			tool.LBMKLIDKHJD(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	private bool BFLJGMGHNCL(InputByProximity LPFGACEBMGD)
	{
		if ((Object)(object)LPFGACEBMGD.placeable == (Object)null)
		{
			return false;
		}
		if ((Object)(object)LPFGACEBMGD.placeable.itemSetup == (Object)null)
		{
			return false;
		}
		if (Item.EKMFELLJHFG(LPFGACEBMGD.placeable.itemSetup.item, null))
		{
			return true;
		}
		if (LPFGACEBMGD.placeable.itemSetup.item.IMCJPECAAPC() == -74)
		{
			return true;
		}
		return true;
	}
}
