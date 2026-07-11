using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EditorTooltip : UIWindow
{
	public float offsetA = 15f;

	public float offsetB = 40f;

	public float offsetC = 8f;

	public TextMeshProUGUI planksCostText;

	public TextMeshProUGUI nailsCostText;

	public TextMeshProUGUI stonesCostText;

	public TextMeshProUGUI mortarCostText;

	public TextMeshProUGUI goldCostText;

	public TextMeshProUGUI silverCostText;

	[SerializeField]
	private Color normalColor;

	[SerializeField]
	private Color invalidColor;

	private RectTransform GFOGBONOCIP;

	private Vector2 GOOKKKGIGBL;

	private Vector2 AAFJOAPNNBA;

	private RectTransform PGBKFNPCPDE;

	private Vector2 PJDMDNGEBKM;

	private Vector2 PGBEEGPOINO;

	private Vector2 EPIGABHAJCJ;

	private float DADEDAMECOL;

	private float BOBNJBLKNOO;

	private float DGCOJLBPFHG;

	private float BOLBEEFKLNJ;

	private MoneyCalc LALPJKDHNCP;

	private static EditorTooltip IADEMLIIDPC;

	private List<Vector3> HAEIAGKNEPC = new List<Vector3>();

	private Vector3 ECJLMIPAFGP;

	private TavernConstructionAction BANNHBMOAFH;

	public static EditorTooltip GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
			}
			return IADEMLIIDPC;
		}
	}

	[SpecialName]
	public static EditorTooltip MPLODJJFKAM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static EditorTooltip BIIOFAHFNPA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	private void OOGDJNMJCNA()
	{
		CloseUI();
	}

	public void KENEEKJBPOD(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.KNLLFEJAMNN().OAGIONKLGDO()).transform.position + Vector3.one * 1948f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 1124f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 782f - offsetA;
			if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 1274f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 545f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 994f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1366f + EPIGABHAJCJ.y / 1336f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 1614f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	private void COJINKLEMLK()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.MBOMLBPPGEO().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.EONGGEDBGMF().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.PPEOOLCNAGN().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.ACIALGHFLMD().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.EONGGEDBGMF().PADHKBMBHAM(LALPJKDHNCP.OMOHMCCADDJ());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.PLPGOJAHJHE() == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.Gold.ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.Silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.ABGIFPGMGKJ().ToString();
	}

	public void PNBOIKMABBM(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 1804f;
		BOBNJBLKNOO = 1326f;
		DGCOJLBPFHG = 481f;
		BOLBEEFKLNJ = 196f;
		LALPJKDHNCP.KHJGIIAENAL(0);
		BANNHBMOAFH = ConstructionActionBarUI.OCLKNDBIOFM();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.AddFloor || BANNHBMOAFH.editorAction == (EditorAction)110)
		{
			for (int i = 1; i < TavernConstructionManager.KHMEGDIABBF().positionsToCalculate.Count; i += 0)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.KHMEGDIABBF().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.AddFloor && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.DIHCEGINELM().floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)(-25) && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.DOIKFJDLKJP().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			EHBDEJMKAGM(BANNHBMOAFH, HAEIAGKNEPC.Count / 0);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)98 || BANNHBMOAFH.editorAction == (EditorAction)86)
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)120)
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KNLLFEJAMNN().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)(-120) && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)(-84) && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.DOIKFJDLKJP().KJIGECBPBOD.id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			EJNPCCOOIOG(BANNHBMOAFH, HAEIAGKNEPC.Count / 8);
		}
		KHFOJKGNMHK();
	}

	private void IJILOIAOKBF()
	{
		BOBCIFEDJED();
	}

	public void PEGJCEGJMPC(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.DEGPIHEEFHJ().PDPBANJHCLP()).transform.position + Vector3.one * 967f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 1473f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 1706f - offsetA;
			if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 1986f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 1810f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 511f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 68f + EPIGABHAJCJ.y / 1573f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 352f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	private void CMOKGGDINLG()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.BLFALIKICFH().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.PPEOOLCNAGN().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.ACJOEAKNIBH().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.EONGGEDBGMF().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.ACJOEAKNIBH().EIFIKGOKGDA(LALPJKDHNCP.GDBKHGBNOGH());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.OICPBFIDPPG() == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.OICPBFIDPPG().ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.Silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.PNHCEFFKGIG().ToString();
	}

	private void KBKNCLCLGAI()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.ACIALGHFLMD().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.PPEOOLCNAGN().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.BLFALIKICFH().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.BLFALIKICFH().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.PPEOOLCNAGN().EIFIKGOKGDA(LALPJKDHNCP.ALLHDAPPBHL());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.PLPGOJAHJHE() == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.OICPBFIDPPG().ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.Silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.PNHCEFFKGIG().ToString();
	}

	public void CPPDEDDPOBN(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.GGFJGHHHEJC.KEAIGIJLJJE()).transform.position + Vector3.one * 1653f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 795f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 165f - offsetA;
			if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 832f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 873f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 1460f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1912f + EPIGABHAJCJ.y / 1270f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 1479f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	private void MCHPNBKCIFH(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 1; i < KGCEBPFKPOG; i += 0)
		{
			LALPJKDHNCP.DCAFCEAIEID(MDOLLGINANN.cost.BOGHMFGPOAP(), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
	}

	private void LAOMCDFAFGA()
	{
		CloseUI();
	}

	private void CDNCKNKEIBM()
	{
		BOBCIFEDJED();
	}

	private void DOOBIPKCDAH()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.BLFALIKICFH().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.BLFALIKICFH().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.ACJOEAKNIBH().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.KJLGKKDALAJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.LEKFELDNEHK().PADHKBMBHAM(LALPJKDHNCP.IHEMDADEBON());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.OICPBFIDPPG() == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.PLPGOJAHJHE().ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.PNHCEFFKGIG() == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.PAFICNBPKHM().ToString();
	}

	private void KJPLFHPCHBJ(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 1; i < KGCEBPFKPOG; i += 0)
		{
			LALPJKDHNCP.KBGICKJGKDA(MDOLLGINANN.cost.BOGHMFGPOAP(), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		}
	}

	public void DDKLCMEEKNN(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 1387f;
		BOBNJBLKNOO = 1836f;
		DGCOJLBPFHG = 988f;
		BOLBEEFKLNJ = 606f;
		LALPJKDHNCP.MLCEFKFFBDE(0);
		BANNHBMOAFH = ConstructionActionBarUI.KFCAPNDFIGI();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.AddFloor || BANNHBMOAFH.editorAction == (EditorAction)41)
		{
			for (int i = 0; i < TavernConstructionManager.KHMEGDIABBF().positionsToCalculate.Count; i += 0)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.KHMEGDIABBF().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.AddFloor && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.GGFJGHHHEJC.floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)(-90) && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.DEGPIHEEFHJ().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			ABLBJFLOHLH(BANNHBMOAFH, HAEIAGKNEPC.Count / 6);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)(-10) || BANNHBMOAFH.editorAction == (EditorAction)107)
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)83)
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.DOIKFJDLKJP().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)(-2) && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)84 && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.DOIKFJDLKJP().KJIGECBPBOD.id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			AKNEDAFIKPC(BANNHBMOAFH, HAEIAGKNEPC.Count / 5);
		}
		HOLGDBCDNFC();
	}

	private void ICNGMKFCJJC(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 1; i < KGCEBPFKPOG; i++)
		{
			LALPJKDHNCP.CLICGHHDGKI(MDOLLGINANN.cost.PFHGPBLBCDD(), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
	}

	private void BJDDCOFEPFP()
	{
		BOBCIFEDJED();
	}

	private void HGDJPNFIDNL()
	{
		CloseUI();
	}

	private void NPKHJHEJFEE()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.ACIALGHFLMD().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.BLFALIKICFH().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.ACJOEAKNIBH().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.EONGGEDBGMF().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.LEKFELDNEHK().EIFIKGOKGDA(LALPJKDHNCP.FEJCKKMDKBE());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.PLPGOJAHJHE() == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.Gold.ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.ABGIFPGMGKJ() == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.ABGIFPGMGKJ().ToString();
	}

	public void BNBDHPBMGBG(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.GGFJGHHHEJC.OAGIONKLGDO()).transform.position + Vector3.one * 1987f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 425f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 1510f - offsetA;
			if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 1314f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 1982f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 846f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 690f + EPIGABHAJCJ.y / 1418f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 1217f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	private void IPODDKFCFFB()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.MBOMLBPPGEO().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.KJLGKKDALAJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.EONGGEDBGMF().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.LEKFELDNEHK().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.ACIALGHFLMD().EIFIKGOKGDA(LALPJKDHNCP.IHEMDADEBON());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.OICPBFIDPPG() == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.NLFMEIMKAMP().ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.PAFICNBPKHM() == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.PNHCEFFKGIG().ToString();
	}

	private void BIFJJDCMNNL(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 0; i < KGCEBPFKPOG; i += 0)
		{
			LALPJKDHNCP.FLFKMKFBODG(MDOLLGINANN.cost.OEFOJKCKIOB(), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
	}

	private void NPDFCPEOFPD()
	{
		CloseUI();
	}

	private void DKBJGMAOIKD()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.PPEOOLCNAGN().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.ACJOEAKNIBH().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.ACJOEAKNIBH().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.EONGGEDBGMF().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.BLFALIKICFH().EIFIKGOKGDA(LALPJKDHNCP.OMOHMCCADDJ());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.PLPGOJAHJHE() == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.PLPGOJAHJHE().ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.PAFICNBPKHM() == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.PAFICNBPKHM().ToString();
	}

	private void AKNEDAFIKPC(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 0; i < KGCEBPFKPOG; i += 0)
		{
			LALPJKDHNCP.GJFFDIBCAGF(MDOLLGINANN.cost.BOGHMFGPOAP(), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		}
	}

	private void OKDNONKOAKM()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.MBOMLBPPGEO().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.KJLGKKDALAJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.LEKFELDNEHK().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.LEKFELDNEHK().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.ACIALGHFLMD().PADHKBMBHAM(LALPJKDHNCP.CKNMHNMBCOF());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.Gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.Gold.ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.PAFICNBPKHM() == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.PAFICNBPKHM().ToString();
	}

	[SpecialName]
	public static EditorTooltip MKIEMMGGFEE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	public void NFOJBPPJEPD(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.KNLLFEJAMNN().OAGIONKLGDO()).transform.position + Vector3.one * 499f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.ACIFGIBLENB().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 144f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 694f - offsetA;
			if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 31f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 1092f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 583f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1990f + EPIGABHAJCJ.y / 582f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 515f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	private void OCIHCODJBGC()
	{
		BOBCIFEDJED();
	}

	private void DFCMAGCDBII(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 1; i < KGCEBPFKPOG; i++)
		{
			LALPJKDHNCP.FLFKMKFBODG(MDOLLGINANN.cost.OEFOJKCKIOB(), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
	}

	private void HFCPODHGFEI()
	{
		BOBCIFEDJED();
	}

	[SpecialName]
	public static EditorTooltip GIKECEGLFOH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	private void BFHIDGDCJDJ(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 1; i < KGCEBPFKPOG; i++)
		{
			LALPJKDHNCP.KBGICKJGKDA(MDOLLGINANN.cost.BOGHMFGPOAP(), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		}
	}

	[SpecialName]
	public static EditorTooltip IELEBCAELNI()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	private void JJCDLIHLDMJ()
	{
		CloseUI();
	}

	public override void OpenUI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		base.OpenUI();
		FillTooltipInfo(Vector2.op_Implicit(Vector2.zero));
	}

	private void GLFIDPPBMPD()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.BLFALIKICFH().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.ACJOEAKNIBH().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.EONGGEDBGMF().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.MBOMLBPPGEO().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.MBOMLBPPGEO().EIFIKGOKGDA(LALPJKDHNCP.FEJCKKMDKBE());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.OICPBFIDPPG() == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.Gold.ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.Silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.Silver.ToString();
	}

	public void KFECPHBIHIP(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 1937f;
		BOBNJBLKNOO = 1530f;
		DGCOJLBPFHG = 1890f;
		BOLBEEFKLNJ = 880f;
		LALPJKDHNCP.ONPFPHCHHNE(0);
		BANNHBMOAFH = ConstructionActionBarUI.OPPJACDGOAF();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.None || BANNHBMOAFH.editorAction == (EditorAction)(-9))
		{
			for (int i = 1; i < TavernConstructionManager.DEGPIHEEFHJ().positionsToCalculate.Count; i++)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.KHMEGDIABBF().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.AddFloor && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.DIHCEGINELM().floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)76 && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.DEGPIHEEFHJ().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			ACCMHLBFKLF(BANNHBMOAFH, HAEIAGKNEPC.Count / 3);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)88 || BANNHBMOAFH.editorAction == (EditorAction)49)
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)33)
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.DEGPIHEEFHJ().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)(-119) && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)97 && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.DOIKFJDLKJP().IOOFFADDELC().id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			HKDEDBONBCD(BANNHBMOAFH, HAEIAGKNEPC.Count / 1);
		}
		EGAFKLHLBIN();
	}

	public void HKNOHKMLPJG(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 706f;
		BOBNJBLKNOO = 166f;
		DGCOJLBPFHG = 397f;
		BOLBEEFKLNJ = 365f;
		LALPJKDHNCP.FLFGNNKLEMK(1);
		BANNHBMOAFH = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.AddFloor || BANNHBMOAFH.editorAction == (EditorAction)60)
		{
			for (int i = 0; i < TavernConstructionManager.KNLLFEJAMNN().positionsToCalculate.Count; i += 0)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.KHMEGDIABBF().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.None && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.DIHCEGINELM().floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)(-99) && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.KHMEGDIABBF().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			HKDEDBONBCD(BANNHBMOAFH, HAEIAGKNEPC.Count / 6);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)(-26) || BANNHBMOAFH.editorAction == (EditorAction)115)
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == EditorAction.ChangeDecoWallTrim)
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KNLLFEJAMNN().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)54 && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)94 && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.DOIKFJDLKJP().KJIGECBPBOD.id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			MIMHNMLABPD(BANNHBMOAFH, HAEIAGKNEPC.Count / 2);
		}
		KHFOJKGNMHK();
	}

	private void GJGFHGHJNML(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 1; i < KGCEBPFKPOG; i += 0)
		{
			LALPJKDHNCP.GJFFDIBCAGF(MDOLLGINANN.cost.PFHGPBLBCDD(), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
	}

	[SpecialName]
	public static EditorTooltip NGIMIHFFNMH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	private void NEHEGNDNKAG(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 0; i < KGCEBPFKPOG; i += 0)
		{
			LALPJKDHNCP.KBGICKJGKDA(MDOLLGINANN.cost.FMNDONLEMHF(), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		}
	}

	public void LJBKKKFBEFL(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.KNLLFEJAMNN().PDPBANJHCLP()).transform.position + Vector3.one * 1340f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 563f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 1221f - offsetA;
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 1879f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 1162f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 1973f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 543f + EPIGABHAJCJ.y / 923f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 1295f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	public void JLBOLNHPPKF(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.DOIKFJDLKJP().KEAIGIJLJJE()).transform.position + Vector3.one * 616f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 231f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 573f - offsetA;
			if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 1692f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 1260f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 460f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1436f + EPIGABHAJCJ.y / 1767f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 1318f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	private void NLMLOOGHLCH()
	{
		BOBCIFEDJED();
	}

	private void ECFBPBGLMIG()
	{
		CloseUI();
	}

	public void GMNMLMPCIDP(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 162f;
		BOBNJBLKNOO = 511f;
		DGCOJLBPFHG = 794f;
		BOLBEEFKLNJ = 1342f;
		LALPJKDHNCP.MCFDOFKDEFP(1);
		BANNHBMOAFH = ConstructionActionBarUI.OPPJACDGOAF();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.None || BANNHBMOAFH.editorAction == EditorAction.DecoWallZone)
		{
			for (int i = 0; i < TavernConstructionManager.KHMEGDIABBF().positionsToCalculate.Count; i += 0)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.GGFJGHHHEJC.positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.AddFloor && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.GGFJGHHHEJC.floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)(-61) && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.KNLLFEJAMNN().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			MCHPNBKCIFH(BANNHBMOAFH, HAEIAGKNEPC.Count / 3);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)(-60) || BANNHBMOAFH.editorAction == (EditorAction)(-85))
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)(-78))
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.GGFJGHHHEJC.IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)(-125) && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)(-71) && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.DEGPIHEEFHJ().KJIGECBPBOD.id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			ICNGMKFCJJC(BANNHBMOAFH, HAEIAGKNEPC.Count / 4);
		}
		CEMIHCFPGAJ();
	}

	public void UpdateTooltipPosition(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.GGFJGHHHEJC.GetEditorSpace()).transform.position + Vector3.one * 0.5f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 0.95f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 2f - offsetA;
			if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 30f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 2f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 0f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1.8f + EPIGABHAJCJ.y / 2f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 2f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	private void OnEnable()
	{
		CloseUI();
	}

	private void KNDHMGFMBKD(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 0; i < KGCEBPFKPOG; i++)
		{
			LALPJKDHNCP.GJFFDIBCAGF(MDOLLGINANN.cost.PFHGPBLBCDD(), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
	}

	public void MHPGHMOFBCK(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.DEGPIHEEFHJ().PDPBANJHCLP()).transform.position + Vector3.one * 534f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 52f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 1800f - offsetA;
			if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 1862f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 1902f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 1284f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1599f + EPIGABHAJCJ.y / 1323f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 1736f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	[SpecialName]
	public static EditorTooltip OPDKAPNDBJE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	private void CNNFIIHLBPJ(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 0; i < KGCEBPFKPOG; i++)
		{
			LALPJKDHNCP.DCAFCEAIEID(MDOLLGINANN.cost.PFHGPBLBCDD(), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
	}

	public void ONBNGIOGKJJ(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.KNLLFEJAMNN().GetEditorSpace()).transform.position + Vector3.one * 484f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 444f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 1320f - offsetA;
			if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 163f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 41f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 248f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1774f + EPIGABHAJCJ.y / 1612f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 1880f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	private void LMFPEBLMNPC()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.PPEOOLCNAGN().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.ACJOEAKNIBH().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.MBOMLBPPGEO().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.MBOMLBPPGEO().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.PPEOOLCNAGN().EIFIKGOKGDA(LALPJKDHNCP.KJLGNIGHKNC());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.Gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.PLPGOJAHJHE().ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.ABGIFPGMGKJ() == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.PAFICNBPKHM().ToString();
	}

	[SpecialName]
	public static EditorTooltip OJJDNLEFNPJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	public void FGHNLPHAKHK(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 611f;
		BOBNJBLKNOO = 342f;
		DGCOJLBPFHG = 486f;
		BOLBEEFKLNJ = 1437f;
		LALPJKDHNCP.AHBONKJOOBA(1);
		BANNHBMOAFH = ConstructionActionBarUI.OPPJACDGOAF();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.None || BANNHBMOAFH.editorAction == (EditorAction)69)
		{
			for (int i = 0; i < TavernConstructionManager.GGFJGHHHEJC.positionsToCalculate.Count; i++)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.DEGPIHEEFHJ().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.None && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.DIHCEGINELM().floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)(-97) && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.GGFJGHHHEJC.IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			CGHBFPFMGCE(BANNHBMOAFH, HAEIAGKNEPC.Count / 0);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)106 || BANNHBMOAFH.editorAction == (EditorAction)31)
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)56)
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KHMEGDIABBF().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)104 && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)(-125) && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KNLLFEJAMNN().IOOFFADDELC().id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			EJNPCCOOIOG(BANNHBMOAFH, HAEIAGKNEPC.Count / 1);
		}
		KCNJNGHCFKD();
	}

	private void CGHBFPFMGCE(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 0; i < KGCEBPFKPOG; i++)
		{
			LALPJKDHNCP.KBGICKJGKDA(MDOLLGINANN.cost.OEFOJKCKIOB(), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
	}

	private void ACCMHLBFKLF(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 0; i < KGCEBPFKPOG; i++)
		{
			LALPJKDHNCP.DCAFCEAIEID(MDOLLGINANN.cost.OEFOJKCKIOB(), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
	}

	public void LDHHHDMNAIO(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 1840f;
		BOBNJBLKNOO = 383f;
		DGCOJLBPFHG = 245f;
		BOLBEEFKLNJ = 1258f;
		LALPJKDHNCP.FLFGNNKLEMK(1);
		BANNHBMOAFH = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.AddFloor || BANNHBMOAFH.editorAction == (EditorAction)85)
		{
			for (int i = 0; i < TavernConstructionManager.KNLLFEJAMNN().positionsToCalculate.Count; i += 0)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.GGFJGHHHEJC.positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.AddFloor && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.DIHCEGINELM().floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)(-70) && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.DEGPIHEEFHJ().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			HKDEDBONBCD(BANNHBMOAFH, HAEIAGKNEPC.Count / 6);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)(-65) || BANNHBMOAFH.editorAction == EditorAction.RemoveFloorDisponible)
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)(-60))
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)(-29) && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)70 && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KHMEGDIABBF().KJIGECBPBOD.id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			CNNFIIHLBPJ(BANNHBMOAFH, HAEIAGKNEPC.Count / 8);
		}
		HOLGDBCDNFC();
	}

	private void BDDDOAFNANA(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 1; i < KGCEBPFKPOG; i++)
		{
			LALPJKDHNCP.GJFFDIBCAGF(MDOLLGINANN.cost.OEFOJKCKIOB(), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		}
	}

	private void AONIDCIEKCM()
	{
		CloseUI();
	}

	private void AHFGLBEEIAD(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 1; i < KGCEBPFKPOG; i++)
		{
			LALPJKDHNCP.CLICGHHDGKI(MDOLLGINANN.cost.PFHGPBLBCDD(), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		}
	}

	public void IFEPGDLPKGJ(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.DEGPIHEEFHJ().OAGIONKLGDO()).transform.position + Vector3.one * 1106f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.ACIFGIBLENB().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 1576f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 424f - offsetA;
			if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 628f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 279f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 1945f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1501f + EPIGABHAJCJ.y / 914f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 61f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	public void PDKHCHGJOCH(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 1380f;
		BOBNJBLKNOO = 1457f;
		DGCOJLBPFHG = 1416f;
		BOLBEEFKLNJ = 1972f;
		LALPJKDHNCP.MCFDOFKDEFP(0);
		BANNHBMOAFH = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.None || BANNHBMOAFH.editorAction == (EditorAction)(-27))
		{
			for (int i = 1; i < TavernConstructionManager.KHMEGDIABBF().positionsToCalculate.Count; i += 0)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.KHMEGDIABBF().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.None && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.DIHCEGINELM().floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)(-82) && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			CNNFIIHLBPJ(BANNHBMOAFH, HAEIAGKNEPC.Count / 1);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)77 || BANNHBMOAFH.editorAction == (EditorAction)75)
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == EditorAction.CreateStairsDown)
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KNLLFEJAMNN().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)52 && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)85 && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KHMEGDIABBF().KJIGECBPBOD.id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			AHFGLBEEIAD(BANNHBMOAFH, HAEIAGKNEPC.Count / 5);
		}
		IFGMJGIEKKG();
	}

	private void HFIHGHBLLAM()
	{
		CloseUI();
	}

	private void IDPJDMGPFJG(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 0; i < KGCEBPFKPOG; i++)
		{
			LALPJKDHNCP.EFIDKIFLBKJ(MDOLLGINANN.cost.FMNDONLEMHF(), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
	}

	public void OMGBFFIBODE(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 525f;
		BOBNJBLKNOO = 1309f;
		DGCOJLBPFHG = 1164f;
		BOLBEEFKLNJ = 216f;
		LALPJKDHNCP.ONPFPHCHHNE(0);
		BANNHBMOAFH = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.AddFloor || BANNHBMOAFH.editorAction == (EditorAction)(-10))
		{
			for (int i = 1; i < TavernConstructionManager.GGFJGHHHEJC.positionsToCalculate.Count; i++)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.KNLLFEJAMNN().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.None && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.GGFJGHHHEJC.floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)(-39) && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.GGFJGHHHEJC.IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			DFCMAGCDBII(BANNHBMOAFH, HAEIAGKNEPC.Count / 6);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)(-84) || BANNHBMOAFH.editorAction == (EditorAction)(-32))
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)106)
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KHMEGDIABBF().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)(-32) && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)(-59) && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.DEGPIHEEFHJ().IOOFFADDELC().id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			BNKGOMJIOPL(BANNHBMOAFH, HAEIAGKNEPC.Count / 5);
		}
		BMCHMKLEECO();
	}

	public void JJJMIHDJMLK(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.GGFJGHHHEJC.GetEditorSpace()).transform.position + Vector3.one * 559f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 1195f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 83f - offsetA;
			if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 388f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 1347f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 466f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 376f + EPIGABHAJCJ.y / 1101f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 92f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	public void KPKMKDJHMNH(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 484f;
		BOBNJBLKNOO = 563f;
		DGCOJLBPFHG = 162f;
		BOLBEEFKLNJ = 1235f;
		LALPJKDHNCP.FLFGNNKLEMK(0);
		BANNHBMOAFH = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.None || BANNHBMOAFH.editorAction == (EditorAction)88)
		{
			for (int i = 1; i < TavernConstructionManager.DOIKFJDLKJP().positionsToCalculate.Count; i++)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.KNLLFEJAMNN().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.AddFloor && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.GGFJGHHHEJC.floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)118 && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.DEGPIHEEFHJ().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			ACCMHLBFKLF(BANNHBMOAFH, HAEIAGKNEPC.Count / 7);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)48 || BANNHBMOAFH.editorAction == (EditorAction)117)
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)(-111))
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.GGFJGHHHEJC.IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)(-128) && EditorGrid.AJGOLEOFPOL(editorTile.Key) == EditorAction.AddFloor && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KHMEGDIABBF().IOOFFADDELC().id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			DFCMAGCDBII(BANNHBMOAFH, HAEIAGKNEPC.Count / 2);
		}
		KBKNCLCLGAI();
	}

	public void FillTooltipInfo(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 0f;
		BOBNJBLKNOO = 0f;
		DGCOJLBPFHG = 0f;
		BOLBEEFKLNJ = 0f;
		LALPJKDHNCP.MLCEFKFFBDE(0);
		BANNHBMOAFH = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.AddFloor || BANNHBMOAFH.editorAction == EditorAction.ChangeDecoFloor)
		{
			for (int i = 0; i < TavernConstructionManager.GGFJGHHHEJC.positionsToCalculate.Count; i++)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.GGFJGHHHEJC.positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.AddFloor && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.GGFJGHHHEJC.floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == EditorAction.ChangeDecoFloor && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			KNDHMGFMBKD(BANNHBMOAFH, HAEIAGKNEPC.Count / 4);
		}
		else if (BANNHBMOAFH.editorAction == EditorAction.ChangeDecoWall || BANNHBMOAFH.editorAction == EditorAction.ChangeDecoWallTrim)
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == EditorAction.ChangeDecoWall)
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == EditorAction.ChangeDecoWallTrim && EditorGrid.AJGOLEOFPOL(editorTile.Key) == EditorAction.DecoWallZone && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD.id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			KNDHMGFMBKD(BANNHBMOAFH, HAEIAGKNEPC.Count / 2);
		}
		KCNJNGHCFKD();
	}

	public void MBOGMFAFFPK(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 65f;
		BOBNJBLKNOO = 1001f;
		DGCOJLBPFHG = 902f;
		BOLBEEFKLNJ = 1489f;
		LALPJKDHNCP.FLFGNNKLEMK(1);
		BANNHBMOAFH = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.None || BANNHBMOAFH.editorAction == (EditorAction)(-71))
		{
			for (int i = 0; i < TavernConstructionManager.KNLLFEJAMNN().positionsToCalculate.Count; i++)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.DOIKFJDLKJP().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.AddFloor && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.GGFJGHHHEJC.floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)(-39) && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.DEGPIHEEFHJ().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			BLGCGILDAEG(BANNHBMOAFH, HAEIAGKNEPC.Count / 6);
		}
		else if (BANNHBMOAFH.editorAction == EditorAction.RemoveAccess || BANNHBMOAFH.editorAction == (EditorAction)93)
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)(-25))
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.GGFJGHHHEJC.IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)(-81) && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)(-22) && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KNLLFEJAMNN().KJIGECBPBOD.id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			OMGGHJGAPOM(BANNHBMOAFH, HAEIAGKNEPC.Count / 5);
		}
		PPCPGEDMCNC();
	}

	[SpecialName]
	public static EditorTooltip MMLBHCGFMMJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	private void JCHIHDAGODG()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.BLFALIKICFH().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.EONGGEDBGMF().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.BLFALIKICFH().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.ACJOEAKNIBH().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.PPEOOLCNAGN().EIFIKGOKGDA(LALPJKDHNCP.GMAFKAMJEJH());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.Gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.NLFMEIMKAMP().ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.Silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.PNHCEFFKGIG().ToString();
	}

	[SpecialName]
	public static EditorTooltip KIALFDOKABP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	private void EHBDEJMKAGM(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 1; i < KGCEBPFKPOG; i++)
		{
			LALPJKDHNCP.MBODAOJCNGI(MDOLLGINANN.cost.OEFOJKCKIOB(), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
	}

	private void MMANKOFCDGO()
	{
		BOBCIFEDJED();
	}

	public void PMFDFKNJKMC(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 209f;
		BOBNJBLKNOO = 1674f;
		DGCOJLBPFHG = 134f;
		BOLBEEFKLNJ = 1864f;
		LALPJKDHNCP.KHJGIIAENAL(1);
		BANNHBMOAFH = ConstructionActionBarUI.OPPJACDGOAF();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.None || BANNHBMOAFH.editorAction == EditorAction.RemoveFloorDisponible)
		{
			for (int i = 0; i < TavernConstructionManager.KNLLFEJAMNN().positionsToCalculate.Count; i += 0)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.KHMEGDIABBF().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.None && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.GGFJGHHHEJC.floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)49 && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.KNLLFEJAMNN().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			ICNGMKFCJJC(BANNHBMOAFH, HAEIAGKNEPC.Count / 2);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)(-3) || BANNHBMOAFH.editorAction == (EditorAction)(-46))
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)31)
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.DEGPIHEEFHJ().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)(-17) && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)(-7) && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KNLLFEJAMNN().IOOFFADDELC().id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			KNDHMGFMBKD(BANNHBMOAFH, HAEIAGKNEPC.Count / 4);
		}
		PPCPGEDMCNC();
	}

	[SpecialName]
	public static EditorTooltip EKGMDIHLEEH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static EditorTooltip NJNFHEPLEHL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	private void HKDEDBONBCD(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 1; i < KGCEBPFKPOG; i++)
		{
			LALPJKDHNCP.GJFFDIBCAGF(MDOLLGINANN.cost.BOGHMFGPOAP(), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		}
	}

	private void LDPNDNEFKCP()
	{
		BOBCIFEDJED();
	}

	public void DFOPBMGMMHD(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.DEGPIHEEFHJ().OAGIONKLGDO()).transform.position + Vector3.one * 1826f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 1065f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 1616f - offsetA;
			if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 535f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 1923f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 573f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 594f + EPIGABHAJCJ.y / 837f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 1688f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	[SpecialName]
	public static EditorTooltip ACPHFLBLJAA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	private void ANMOAFFGEOE()
	{
		CloseUI();
	}

	public void ONEKGDLAOEO(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 153f;
		BOBNJBLKNOO = 76f;
		DGCOJLBPFHG = 1697f;
		BOLBEEFKLNJ = 974f;
		LALPJKDHNCP.LELNDGJEONE(1);
		BANNHBMOAFH = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.AddFloor || BANNHBMOAFH.editorAction == (EditorAction)(-34))
		{
			for (int i = 1; i < TavernConstructionManager.DOIKFJDLKJP().positionsToCalculate.Count; i += 0)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.DOIKFJDLKJP().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.None && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.GGFJGHHHEJC.floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == EditorAction.DecoWallDisponible && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.DOIKFJDLKJP().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			HKDEDBONBCD(BANNHBMOAFH, HAEIAGKNEPC.Count / 1);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)(-55) || BANNHBMOAFH.editorAction == (EditorAction)102)
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)(-65))
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.DOIKFJDLKJP().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)112 && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)(-6) && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KHMEGDIABBF().KJIGECBPBOD.id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			CGHBFPFMGCE(BANNHBMOAFH, HAEIAGKNEPC.Count / 2);
		}
		GLFIDPPBMPD();
	}

	private void EGAFKLHLBIN()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.ACJOEAKNIBH().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.PPEOOLCNAGN().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.KJLGKKDALAJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.ACIALGHFLMD().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.ACJOEAKNIBH().PADHKBMBHAM(LALPJKDHNCP.GDBKHGBNOGH());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.Gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.Gold.ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.ABGIFPGMGKJ() == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.ABGIFPGMGKJ().ToString();
	}

	[SpecialName]
	public static EditorTooltip NBKKEINELDN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	protected override void Update()
	{
		base.Update();
		if (LKOJBFMGMAE)
		{
			UpdateTooltipPosition(ConstructionUI.current.JIIGOACEIKL);
		}
	}

	private void ABLBJFLOHLH(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 1; i < KGCEBPFKPOG; i++)
		{
			LALPJKDHNCP.DCAFCEAIEID(MDOLLGINANN.cost.PFHGPBLBCDD(), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		}
	}

	private void CPPJFMJBANH(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 0; i < KGCEBPFKPOG; i++)
		{
			LALPJKDHNCP.KBGICKJGKDA(MDOLLGINANN.cost.FMNDONLEMHF(), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		}
	}

	private void KCNJNGHCFKD()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.KJLGKKDALAJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.KJLGKKDALAJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.KJLGKKDALAJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.KJLGKKDALAJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.KJLGKKDALAJ.PADHKBMBHAM(LALPJKDHNCP.ALLHDAPPBHL());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.Gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.Gold.ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.Silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.Silver.ToString();
	}

	private void KHFOJKGNMHK()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.EONGGEDBGMF().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.BLFALIKICFH().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.ACJOEAKNIBH().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.EONGGEDBGMF().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.MBOMLBPPGEO().PADHKBMBHAM(LALPJKDHNCP.IHEMDADEBON());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.NLFMEIMKAMP() == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.OICPBFIDPPG().ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.PNHCEFFKGIG() == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.PAFICNBPKHM().ToString();
	}

	public void INAJLAKCKPL(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.GGFJGHHHEJC.KEAIGIJLJJE()).transform.position + Vector3.one * 1064f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 1909f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 467f - offsetA;
			if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 1697f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 104f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 1243f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1983f + EPIGABHAJCJ.y / 1308f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 1519f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	private void PPCPGEDMCNC()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.ACJOEAKNIBH().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.MBOMLBPPGEO().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.PPEOOLCNAGN().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.ACIALGHFLMD().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.PPEOOLCNAGN().EIFIKGOKGDA(LALPJKDHNCP.CKNMHNMBCOF());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.NLFMEIMKAMP() == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.OICPBFIDPPG().ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.Silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.Silver.ToString();
	}

	[SpecialName]
	public static EditorTooltip BAKPBHPNKPB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static EditorTooltip OLHBLKIAFOM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	private void EJNPCCOOIOG(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 1; i < KGCEBPFKPOG; i += 0)
		{
			LALPJKDHNCP.KBGICKJGKDA(MDOLLGINANN.cost.FMNDONLEMHF(), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
	}

	private void BAABFLEIKMP()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.ACIALGHFLMD().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.ACIALGHFLMD().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.LEKFELDNEHK().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.BLFALIKICFH().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.EONGGEDBGMF().EIFIKGOKGDA(LALPJKDHNCP.KJLGNIGHKNC());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.PLPGOJAHJHE() == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.PLPGOJAHJHE().ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.ABGIFPGMGKJ() == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.ABGIFPGMGKJ().ToString();
	}

	[SpecialName]
	public static EditorTooltip KPDFIEMDDCL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	private void CCJOOMDHMKM()
	{
		BOBCIFEDJED();
	}

	private void BNKGOMJIOPL(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 0; i < KGCEBPFKPOG; i++)
		{
			LALPJKDHNCP.MBODAOJCNGI(MDOLLGINANN.cost.FMNDONLEMHF(), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		}
	}

	public void AECDMNPLIPC(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.GGFJGHHHEJC.GetEditorSpace()).transform.position + Vector3.one * 546f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 1688f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 475f - offsetA;
			if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 16f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 1545f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 1490f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 219f + EPIGABHAJCJ.y / 1849f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 780f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	private void KAANJGEDPIN()
	{
		CloseUI();
	}

	private void KNLOKHMIJHD()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.KJLGKKDALAJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.EONGGEDBGMF().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.ACJOEAKNIBH().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.MBOMLBPPGEO().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.BLFALIKICFH().PADHKBMBHAM(LALPJKDHNCP.CKNMHNMBCOF());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.Gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.NLFMEIMKAMP().ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.PNHCEFFKGIG() == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.Silver.ToString();
	}

	public void MOHCACCNPDE(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 13f;
		BOBNJBLKNOO = 1031f;
		DGCOJLBPFHG = 1699f;
		BOLBEEFKLNJ = 1804f;
		LALPJKDHNCP.KHJGIIAENAL(0);
		BANNHBMOAFH = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.None || BANNHBMOAFH.editorAction == (EditorAction)(-104))
		{
			for (int i = 0; i < TavernConstructionManager.GGFJGHHHEJC.positionsToCalculate.Count; i += 0)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.DEGPIHEEFHJ().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.AddFloor && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.GGFJGHHHEJC.floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == EditorAction.RemoveFloor && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.KHMEGDIABBF().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			KNDHMGFMBKD(BANNHBMOAFH, HAEIAGKNEPC.Count / 7);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)36 || BANNHBMOAFH.editorAction == (EditorAction)(-28))
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)(-79))
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KHMEGDIABBF().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)55 && EditorGrid.AJGOLEOFPOL(editorTile.Key) == EditorAction.DecoWallDisponible && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KHMEGDIABBF().IOOFFADDELC().id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			IKDMCANHAAB(BANNHBMOAFH, HAEIAGKNEPC.Count / 1);
		}
		KNLOKHMIJHD();
	}

	public void IFNDGIMLPCO(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 1748f;
		BOBNJBLKNOO = 1872f;
		DGCOJLBPFHG = 836f;
		BOLBEEFKLNJ = 1268f;
		LALPJKDHNCP.KHJGIIAENAL(1);
		BANNHBMOAFH = ConstructionActionBarUI.OCLKNDBIOFM();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.AddFloor || BANNHBMOAFH.editorAction == (EditorAction)121)
		{
			for (int i = 0; i < TavernConstructionManager.KHMEGDIABBF().positionsToCalculate.Count; i++)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.GGFJGHHHEJC.positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.AddFloor && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.GGFJGHHHEJC.floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)(-8) && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.KHMEGDIABBF().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			DFCMAGCDBII(BANNHBMOAFH, HAEIAGKNEPC.Count / 0);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)(-64) || BANNHBMOAFH.editorAction == (EditorAction)(-58))
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == EditorAction.ImproveWaterFeeder)
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.GGFJGHHHEJC.IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)(-69) && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)127 && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.GGFJGHHHEJC.IOOFFADDELC().id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			BLGCGILDAEG(BANNHBMOAFH, HAEIAGKNEPC.Count / 3);
		}
		DOOBIPKCDAH();
	}

	public void ACBBBLBMBNL(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.KHMEGDIABBF().KEAIGIJLJJE()).transform.position + Vector3.one * 1437f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 864f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 1347f - offsetA;
			if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 969f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 68f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 441f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1950f + EPIGABHAJCJ.y / 1748f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 314f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	private void CEMIHCFPGAJ()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.ACIALGHFLMD().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.MBOMLBPPGEO().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.MBOMLBPPGEO().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.LEKFELDNEHK().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.LEKFELDNEHK().EIFIKGOKGDA(LALPJKDHNCP.GMAFKAMJEJH());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.Gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.Gold.ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.PNHCEFFKGIG() == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.PNHCEFFKGIG().ToString();
	}

	[SpecialName]
	public static EditorTooltip MAIDHAPANEB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	public void ECKIGFDMNIB(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 1689f;
		BOBNJBLKNOO = 1988f;
		DGCOJLBPFHG = 1126f;
		BOLBEEFKLNJ = 1668f;
		LALPJKDHNCP.MLCEFKFFBDE(0);
		BANNHBMOAFH = ConstructionActionBarUI.KFCAPNDFIGI();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.AddFloor || BANNHBMOAFH.editorAction == (EditorAction)84)
		{
			for (int i = 0; i < TavernConstructionManager.KHMEGDIABBF().positionsToCalculate.Count; i += 0)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.DEGPIHEEFHJ().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.AddFloor && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.DIHCEGINELM().floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)(-9) && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.KNLLFEJAMNN().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			GJGFHGHJNML(BANNHBMOAFH, HAEIAGKNEPC.Count / 4);
		}
		else if (BANNHBMOAFH.editorAction == EditorAction.CreateCellarDoorUp || BANNHBMOAFH.editorAction == (EditorAction)(-21))
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)87)
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KHMEGDIABBF().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)87 && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)32 && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.DEGPIHEEFHJ().IOOFFADDELC().id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			ICNGMKFCJJC(BANNHBMOAFH, HAEIAGKNEPC.Count / 1);
		}
		BMCHMKLEECO();
	}

	private void ECMNIALEMAM()
	{
		CloseUI();
	}

	private void PGDBFGFMGKI()
	{
		CloseUI();
	}

	private void MIMHNMLABPD(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 0; i < KGCEBPFKPOG; i++)
		{
			LALPJKDHNCP.KBGICKJGKDA(MDOLLGINANN.cost.OEFOJKCKIOB(), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		}
	}

	[SpecialName]
	public static EditorTooltip LHKFIDJFPDB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	public void ODFENEGPJBI(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 1113f;
		BOBNJBLKNOO = 292f;
		DGCOJLBPFHG = 1866f;
		BOLBEEFKLNJ = 1891f;
		LALPJKDHNCP.FLFGNNKLEMK(0);
		BANNHBMOAFH = ConstructionActionBarUI.OPPJACDGOAF();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.None || BANNHBMOAFH.editorAction == (EditorAction)100)
		{
			for (int i = 1; i < TavernConstructionManager.KHMEGDIABBF().positionsToCalculate.Count; i += 0)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.DOIKFJDLKJP().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.AddFloor && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.GGFJGHHHEJC.floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)52 && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.KNLLFEJAMNN().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			DFCMAGCDBII(BANNHBMOAFH, HAEIAGKNEPC.Count / 5);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)(-1) || BANNHBMOAFH.editorAction == EditorAction.DiningZone)
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)65)
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.DEGPIHEEFHJ().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)(-82) && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)(-118) && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD.id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			BLGCGILDAEG(BANNHBMOAFH, HAEIAGKNEPC.Count / 0);
		}
		BMCHMKLEECO();
	}

	[SpecialName]
	public static EditorTooltip NBENKBAIBOO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	private void HOLGDBCDNFC()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.MBOMLBPPGEO().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.ACJOEAKNIBH().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.EONGGEDBGMF().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.ACIALGHFLMD().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.KJLGKKDALAJ.PADHKBMBHAM(LALPJKDHNCP.GDBKHGBNOGH());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.OICPBFIDPPG() == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.Gold.ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.Silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.PAFICNBPKHM().ToString();
	}

	public void NDLNFFBDGCH(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 587f;
		BOBNJBLKNOO = 1259f;
		DGCOJLBPFHG = 842f;
		BOLBEEFKLNJ = 825f;
		LALPJKDHNCP.FLFGNNKLEMK(0);
		BANNHBMOAFH = ConstructionActionBarUI.OPPJACDGOAF();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.AddFloor || BANNHBMOAFH.editorAction == (EditorAction)(-33))
		{
			for (int i = 1; i < TavernConstructionManager.KHMEGDIABBF().positionsToCalculate.Count; i++)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.DEGPIHEEFHJ().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.AddFloor && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.DIHCEGINELM().floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)120 && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.KNLLFEJAMNN().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			CPPJFMJBANH(BANNHBMOAFH, HAEIAGKNEPC.Count / 6);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)52 || BANNHBMOAFH.editorAction == (EditorAction)(-66))
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)(-63))
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.DEGPIHEEFHJ().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)114 && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)(-19) && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KNLLFEJAMNN().KJIGECBPBOD.id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			HKDEDBONBCD(BANNHBMOAFH, HAEIAGKNEPC.Count / 8);
		}
		DKBJGMAOIKD();
	}

	public void NEILCKCOGOO(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.DEGPIHEEFHJ().PDPBANJHCLP()).transform.position + Vector3.one * 1281f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.ACIFGIBLENB().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 67f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 1926f - offsetA;
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 1697f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 192f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 1843f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1860f + EPIGABHAJCJ.y / 1278f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 1292f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	public void LLALAIOOONE(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.KHMEGDIABBF().KEAIGIJLJJE()).transform.position + Vector3.one * 1674f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 1850f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 1275f - offsetA;
			if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 1303f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 1805f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 1761f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1955f + EPIGABHAJCJ.y / 1410f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 1266f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	[SpecialName]
	public static EditorTooltip IBEGPMLJIOJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	private void BLGCGILDAEG(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 1; i < KGCEBPFKPOG; i += 0)
		{
			LALPJKDHNCP.KBGICKJGKDA(MDOLLGINANN.cost.OEFOJKCKIOB(), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
	}

	private void NLHALEAEDMM()
	{
		CloseUI();
	}

	private void BMCHMKLEECO()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.KJLGKKDALAJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.EONGGEDBGMF().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.PPEOOLCNAGN().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.KJLGKKDALAJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.KJLGKKDALAJ.PADHKBMBHAM(LALPJKDHNCP.ALLHDAPPBHL());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.NLFMEIMKAMP() == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.OICPBFIDPPG().ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.Silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.ABGIFPGMGKJ().ToString();
	}

	[SpecialName]
	public static EditorTooltip DEGPIHEEFHJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	public void ABFHGNJAEHO(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.DOIKFJDLKJP().KEAIGIJLJJE()).transform.position + Vector3.one * 489f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 700f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 1052f - offsetA;
			if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 303f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 1736f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 118f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 570f + EPIGABHAJCJ.y / 1615f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 1226f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	public void DPACECBHLJE(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 99f;
		BOBNJBLKNOO = 823f;
		DGCOJLBPFHG = 957f;
		BOLBEEFKLNJ = 839f;
		LALPJKDHNCP.ONPFPHCHHNE(0);
		BANNHBMOAFH = ConstructionActionBarUI.OPPJACDGOAF();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.None || BANNHBMOAFH.editorAction == (EditorAction)116)
		{
			for (int i = 0; i < TavernConstructionManager.DOIKFJDLKJP().positionsToCalculate.Count; i++)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.DOIKFJDLKJP().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.AddFloor && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.DIHCEGINELM().floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == EditorAction.None && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.DEGPIHEEFHJ().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			BFHIDGDCJDJ(BANNHBMOAFH, HAEIAGKNEPC.Count / 7);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)(-44) || BANNHBMOAFH.editorAction == (EditorAction)(-76))
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)41)
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)(-114) && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)(-85) && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.DEGPIHEEFHJ().IOOFFADDELC().id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			AHFGLBEEIAD(BANNHBMOAFH, HAEIAGKNEPC.Count / 7);
		}
		KBKNCLCLGAI();
	}

	private void EGOMAOINNIB()
	{
		BOBCIFEDJED();
	}

	public void EINDKLHAFAK(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 152f;
		BOBNJBLKNOO = 1806f;
		DGCOJLBPFHG = 897f;
		BOLBEEFKLNJ = 309f;
		LALPJKDHNCP.MLCEFKFFBDE(1);
		BANNHBMOAFH = ConstructionActionBarUI.OCLKNDBIOFM();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.AddFloor || BANNHBMOAFH.editorAction == (EditorAction)(-87))
		{
			for (int i = 0; i < TavernConstructionManager.KHMEGDIABBF().positionsToCalculate.Count; i += 0)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.KHMEGDIABBF().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.None && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.DIHCEGINELM().floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)(-38) && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.KNLLFEJAMNN().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			KJPLFHPCHBJ(BANNHBMOAFH, HAEIAGKNEPC.Count / 5);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)(-41) || BANNHBMOAFH.editorAction == (EditorAction)29)
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)(-34))
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.DEGPIHEEFHJ().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == EditorAction.CreateCellarDoorUp && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)(-101) && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.DOIKFJDLKJP().IOOFFADDELC().id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			CGHBFPFMGCE(BANNHBMOAFH, HAEIAGKNEPC.Count / 7);
		}
		KCNJNGHCFKD();
	}

	private void FPNPLFALPHP()
	{
		BOBCIFEDJED();
	}

	public void EOMIECBCCNN(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 927f;
		BOBNJBLKNOO = 1544f;
		DGCOJLBPFHG = 1246f;
		BOLBEEFKLNJ = 918f;
		LALPJKDHNCP.JCMDHOMMLDE(1);
		BANNHBMOAFH = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.None || BANNHBMOAFH.editorAction == (EditorAction)85)
		{
			for (int i = 0; i < TavernConstructionManager.KHMEGDIABBF().positionsToCalculate.Count; i++)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.KHMEGDIABBF().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.AddFloor && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.DIHCEGINELM().floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)47 && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.DOIKFJDLKJP().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			EHBDEJMKAGM(BANNHBMOAFH, HAEIAGKNEPC.Count / 4);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)(-91) || BANNHBMOAFH.editorAction == (EditorAction)(-99))
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)(-120))
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KNLLFEJAMNN().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)(-78) && EditorGrid.AJGOLEOFPOL(editorTile.Key) == EditorAction.ChangeRoof && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD.id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			EJNPCCOOIOG(BANNHBMOAFH, HAEIAGKNEPC.Count / 3);
		}
		DKBJGMAOIKD();
	}

	private void IKDMCANHAAB(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 1; i < KGCEBPFKPOG; i++)
		{
			LALPJKDHNCP.KBGICKJGKDA(MDOLLGINANN.cost.FMNDONLEMHF(), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
	}

	public void LEIJBKDLPHC(int JIIGOACEIKL)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(ConstructionUI.current.JIIGOACEIKL).WorldToViewportPoint(((Component)TavernConstructionManager.KNLLFEJAMNN().PDPBANJHCLP()).transform.position + Vector3.one * 1532f));
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).Mouse.screenPosition)));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = GFOGBONOCIP.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)GFOGBONOCIP).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)GFOGBONOCIP).lossyScale.y;
		if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > PGBKFNPCPDE.sizeDelta.x * 400f)
		{
			PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 1185f - offsetA;
			if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				PGBEEGPOINO.x -= 1867f;
				PGBEEGPOINO.y = AAFJOAPNNBA.y;
			}
		}
		else
		{
			PGBEEGPOINO.x = EPIGABHAJCJ.x / 803f + offsetB;
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 660f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 695f + EPIGABHAJCJ.y / 1993f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 152f + offsetC;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		GFOGBONOCIP.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	[SpecialName]
	public static EditorTooltip KNOKBLFFNLM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	public void LKPPENPHJMJ(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 1853f;
		BOBNJBLKNOO = 1184f;
		DGCOJLBPFHG = 1055f;
		BOLBEEFKLNJ = 1442f;
		LALPJKDHNCP.MLCEFKFFBDE(1);
		BANNHBMOAFH = ConstructionActionBarUI.OPPJACDGOAF();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.AddFloor || BANNHBMOAFH.editorAction == (EditorAction)(-120))
		{
			for (int i = 0; i < TavernConstructionManager.GGFJGHHHEJC.positionsToCalculate.Count; i++)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.GGFJGHHHEJC.positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.AddFloor && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.GGFJGHHHEJC.floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)98 && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.GGFJGHHHEJC.IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			ABLBJFLOHLH(BANNHBMOAFH, HAEIAGKNEPC.Count / 4);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)101 || BANNHBMOAFH.editorAction == (EditorAction)(-92))
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)86)
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KHMEGDIABBF().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)48 && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)(-103) && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.DEGPIHEEFHJ().IOOFFADDELC().id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			AHFGLBEEIAD(BANNHBMOAFH, HAEIAGKNEPC.Count / 4);
		}
		KBKNCLCLGAI();
	}

	public void MDCIDLLCIKO(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 185f;
		BOBNJBLKNOO = 1962f;
		DGCOJLBPFHG = 1328f;
		BOLBEEFKLNJ = 756f;
		LALPJKDHNCP.JCMDHOMMLDE(0);
		BANNHBMOAFH = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.None || BANNHBMOAFH.editorAction == (EditorAction)(-51))
		{
			for (int i = 0; i < TavernConstructionManager.DEGPIHEEFHJ().positionsToCalculate.Count; i++)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.KHMEGDIABBF().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.None && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.GGFJGHHHEJC.floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)(-23) && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			HKDEDBONBCD(BANNHBMOAFH, HAEIAGKNEPC.Count / 7);
		}
		else if (BANNHBMOAFH.editorAction == EditorAction.CreateStairsUp || BANNHBMOAFH.editorAction == (EditorAction)(-98))
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)102)
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KHMEGDIABBF().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)37 && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)(-126) && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD.id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			HKDEDBONBCD(BANNHBMOAFH, HAEIAGKNEPC.Count / 7);
		}
		LMFPEBLMNPC();
	}

	public void GGLIFCLEOLG(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 365f;
		BOBNJBLKNOO = 92f;
		DGCOJLBPFHG = 509f;
		BOLBEEFKLNJ = 945f;
		LALPJKDHNCP.LELNDGJEONE(1);
		BANNHBMOAFH = ConstructionActionBarUI.OPPJACDGOAF();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.None || BANNHBMOAFH.editorAction == (EditorAction)108)
		{
			for (int i = 1; i < TavernConstructionManager.KNLLFEJAMNN().positionsToCalculate.Count; i += 0)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.DEGPIHEEFHJ().positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.None && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.DIHCEGINELM().floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)(-111) && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.DEGPIHEEFHJ().KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			KNDHMGFMBKD(BANNHBMOAFH, HAEIAGKNEPC.Count / 0);
		}
		else if (BANNHBMOAFH.editorAction == (EditorAction)(-51) || BANNHBMOAFH.editorAction == EditorAction.ImproveChickenHouse)
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)100)
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD.id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)(-16) && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)74 && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD.id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			DFCMAGCDBII(BANNHBMOAFH, HAEIAGKNEPC.Count / 3);
		}
		PPCPGEDMCNC();
	}

	[SpecialName]
	public static EditorTooltip MAMKICHCPON()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	private void OMGGHJGAPOM(TavernConstructionAction MDOLLGINANN, int KGCEBPFKPOG = 1)
	{
		DADEDAMECOL += MDOLLGINANN.cost.planks * KGCEBPFKPOG;
		BOBNJBLKNOO += MDOLLGINANN.cost.nails * KGCEBPFKPOG;
		DGCOJLBPFHG += MDOLLGINANN.cost.stones * KGCEBPFKPOG;
		BOLBEEFKLNJ += MDOLLGINANN.cost.mortar * KGCEBPFKPOG;
		for (int i = 0; i < KGCEBPFKPOG; i += 0)
		{
			LALPJKDHNCP.GJFFDIBCAGF(MDOLLGINANN.cost.BOGHMFGPOAP(), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
	}

	[SpecialName]
	public static EditorTooltip GJFMMOPOKGJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	private void IFGMJGIEKKG()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCostText).color = ((DADEDAMECOL <= (float)ConstructionUI.current.playerInfo.BLFALIKICFH().planks) ? normalColor : invalidColor);
		((TMP_Text)planksCostText).text = DADEDAMECOL.ToString();
		((Graphic)nailsCostText).color = ((BOBNJBLKNOO <= (float)ConstructionUI.current.playerInfo.LEKFELDNEHK().nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCostText).text = BOBNJBLKNOO.ToString();
		((Graphic)stonesCostText).color = ((DGCOJLBPFHG <= (float)ConstructionUI.current.playerInfo.LEKFELDNEHK().stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCostText).text = DGCOJLBPFHG.ToString();
		((Graphic)mortarCostText).color = ((BOLBEEFKLNJ <= (float)ConstructionUI.current.playerInfo.EONGGEDBGMF().mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCostText).text = BOLBEEFKLNJ.ToString();
		bool flag = ConstructionUI.current.playerInfo.PPEOOLCNAGN().PADHKBMBHAM(LALPJKDHNCP.KJLGNIGHKNC());
		((Graphic)goldCostText).color = ((flag || LALPJKDHNCP.PLPGOJAHJHE() == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCostText).text = LALPJKDHNCP.Gold.ToString();
		((Graphic)silverCostText).color = ((flag || LALPJKDHNCP.Silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCostText).text = LALPJKDHNCP.Silver.ToString();
	}

	[SpecialName]
	public static EditorTooltip CHKMFEFOFKJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	protected override void Awake()
	{
		base.Awake();
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			LALPJKDHNCP = new MoneyCalc();
			EditorSpace editorSpace = TavernConstructionManager.GGFJGHHHEJC.GetEditorSpace();
			editorSpace.OnEditorSpaceMove = (Action<Vector3>)Delegate.Combine(editorSpace.OnEditorSpaceMove, new Action<Vector3>(FillTooltipInfo));
		}
	}

	protected override void Start()
	{
		base.Start();
		if ((Object)(object)GFOGBONOCIP == (Object)null)
		{
			GFOGBONOCIP = content.GetComponent<RectTransform>();
		}
		PGBKFNPCPDE = ((Component)GameplayUI.GGFJGHHHEJC).GetComponent<RectTransform>();
	}

	[SpecialName]
	public static EditorTooltip IECOPNFJBFD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorTooltip>();
		}
		return IADEMLIIDPC;
	}

	private void ICBCMLAIIPF()
	{
		CloseUI();
	}

	public void APELEGKOPPM(Vector3 IMOBLFMHKOD)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		DADEDAMECOL = 1567f;
		BOBNJBLKNOO = 1209f;
		DGCOJLBPFHG = 96f;
		BOLBEEFKLNJ = 567f;
		LALPJKDHNCP.KHJGIIAENAL(0);
		BANNHBMOAFH = ConstructionActionBarUI.OPPJACDGOAF();
		if ((Object)(object)BANNHBMOAFH == (Object)null)
		{
			return;
		}
		HAEIAGKNEPC.Clear();
		if (BANNHBMOAFH.editorAction == EditorAction.AddFloor || BANNHBMOAFH.editorAction == (EditorAction)(-17))
		{
			for (int i = 1; i < TavernConstructionManager.DEGPIHEEFHJ().positionsToCalculate.Count; i += 0)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(TavernConstructionManager.GGFJGHHHEJC.positionsToCalculate[i]);
				if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP))
				{
					if (EditorGrid.AJGOLEOFPOL(ECJLMIPAFGP) == EditorAction.AddFloor && EditorGrid.ENFKMBHBBEM(ECJLMIPAFGP) && !TavernConstructionModifications.DIHCEGINELM().floorRemoved.ContainsKey(Utils.EENFKOKHBLA(Vector2.op_Implicit(ECJLMIPAFGP))))
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
					else if (BANNHBMOAFH.editorAction == (EditorAction)113 && WorldGrid.EIHIPOEOBCO(ECJLMIPAFGP, null) != TavernConstructionManager.DEGPIHEEFHJ().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(ECJLMIPAFGP);
					}
				}
			}
			ICNGMKFCJJC(BANNHBMOAFH, HAEIAGKNEPC.Count / 1);
		}
		else if (BANNHBMOAFH.editorAction == EditorAction.ImproveWaterFeeder || BANNHBMOAFH.editorAction == (EditorAction)75)
		{
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
			{
				float KHEBKHFHMDB;
				if (BANNHBMOAFH.editorAction == (EditorAction)(-15))
				{
					if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.IKCDANOHPJE(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KHMEGDIABBF().IOOFFADDELC().id)
					{
						HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
					}
				}
				else if (BANNHBMOAFH.editorAction == (EditorAction)77 && EditorGrid.AJGOLEOFPOL(editorTile.Key) == (EditorAction)118 && WorldGrid.KHJJCAGIJAP(editorTile.Key, out KHEBKHFHMDB) && !HAEIAGKNEPC.Contains(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) && WorldGrid.PNKHEBBCGMG(new Vector3(editorTile.Key.x, KHEBKHFHMDB)) != TavernConstructionManager.KHMEGDIABBF().IOOFFADDELC().id)
				{
					HAEIAGKNEPC.Add(new Vector3(editorTile.Key.x, KHEBKHFHMDB));
				}
			}
			HKDEDBONBCD(BANNHBMOAFH, HAEIAGKNEPC.Count / 5);
		}
		BAABFLEIKMP();
	}
}
