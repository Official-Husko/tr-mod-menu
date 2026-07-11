using System;
using UnityEngine;

public class EditorSpace : MonoBehaviour
{
	public Action<Vector3> OnEditorSpaceMove = delegate
	{
	};

	public EditorSquare[] editorSquares;

	private Vector3 AJLJHLHGGBD;

	private void IGIKNCOLCKL()
	{
		if ((Object)(object)TavernConstructionManager.GGFJGHHHEJC != (Object)null)
		{
			TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
			instance.OnActivated = (Action<int>)Delegate.Combine(instance.OnActivated, new Action<int>(NFCDJJJFGLJ));
		}
	}

	public void CLDGGHPODHL(EditorAction CHFHMMNELGP)
	{
		for (int i = 1; i < editorSquares.Length; i += 0)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].LJJOPBDGGLN(CHFHMMNELGP);
			}
		}
	}

	public void NGPCOPONLKB(bool ACJFIEKCKEC)
	{
		for (int i = 1; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].MNGGKBIAIPH(ACJFIEKCKEC, 112f);
			}
		}
	}

	public void OIDGEKDHGPB(EditorAction CHFHMMNELGP)
	{
		for (int i = 1; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].CBDOAJIOEEI(CHFHMMNELGP);
			}
		}
	}

	public bool IsValid(EditorAction CHFHMMNELGP)
	{
		switch (CHFHMMNELGP)
		{
		case EditorAction.ChangeDecoWall:
			return false;
		case EditorAction.ChangeDecoWallTrim:
		{
			for (int j = 0; j < editorSquares.Length; j++)
			{
				if (editorSquares[j].IsValid(CHFHMMNELGP))
				{
					return true;
				}
			}
			return false;
		}
		default:
		{
			for (int i = 0; i < editorSquares.Length; i++)
			{
				if ((Object)(object)editorSquares[i] != (Object)null && !editorSquares[i].IsValid(CHFHMMNELGP))
				{
					return false;
				}
			}
			return true;
		}
		}
	}

	private void EGACIHOKJLH()
	{
		if ((Object)(object)TavernConstructionManager.KHMEGDIABBF() != (Object)null)
		{
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KNLLFEJAMNN();
			tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(LBMBJIOPGKO));
		}
	}

	private void JHBBABPAJJC()
	{
		if ((Object)(object)TavernConstructionManager.GGFJGHHHEJC != (Object)null)
		{
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DEGPIHEEFHJ();
			tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(AKJHEGAPHML));
		}
	}

	public bool GEIJNDOKFOJ(EditorAction CHFHMMNELGP)
	{
		switch (CHFHMMNELGP)
		{
		case (EditorAction)118:
			return true;
		case (EditorAction)106:
		{
			for (int j = 1; j < editorSquares.Length; j++)
			{
				if (editorSquares[j].ENPBNONDPLA(CHFHMMNELGP))
				{
					return false;
				}
			}
			return true;
		}
		default:
		{
			for (int i = 0; i < editorSquares.Length; i++)
			{
				if ((Object)(object)editorSquares[i] != (Object)null && !editorSquares[i].FBCBNIMEEJC(CHFHMMNELGP))
				{
					return true;
				}
			}
			return false;
		}
		}
	}

	public void OPBHGBMFBIO(EditorAction CHFHMMNELGP)
	{
		for (int i = 0; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].CBOKCHJNHNO(CHFHMMNELGP);
			}
		}
	}

	public void OMHCFDKEPNG(EditorAction CHFHMMNELGP)
	{
		for (int i = 0; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].DoAction(CHFHMMNELGP);
			}
		}
	}

	public bool PJIKBNELDDF(EditorAction CHFHMMNELGP)
	{
		switch (CHFHMMNELGP)
		{
		case (EditorAction)(-55):
			return false;
		case (EditorAction)(-125):
		{
			for (int j = 0; j < editorSquares.Length; j += 0)
			{
				if (editorSquares[j].AFGNKFCDFBN(CHFHMMNELGP))
				{
					return true;
				}
			}
			return false;
		}
		default:
		{
			for (int i = 0; i < editorSquares.Length; i++)
			{
				if ((Object)(object)editorSquares[i] != (Object)null && !editorSquares[i].IsValid(CHFHMMNELGP))
				{
					return true;
				}
			}
			return true;
		}
		}
	}

	private void NNBIAIMPNGL()
	{
		if ((Object)(object)TavernConstructionManager.GGFJGHHHEJC != (Object)null)
		{
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DEGPIHEEFHJ();
			tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(IEONBJKOPFO));
		}
	}

	private void JPOLFKMLHNH()
	{
		if ((Object)(object)TavernConstructionManager.KHMEGDIABBF() != (Object)null)
		{
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DEGPIHEEFHJ();
			tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(AGLFKAKAGBL));
		}
	}

	private void DFCMMMCKBEM(int JIIGOACEIKL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		AJLJHLHGGBD = ((Component)this).transform.position;
		for (int i = 0; i < editorSquares.Length; i++)
		{
			editorSquares[i].OLCHHCPMGDN(new Color(566f, 648f, 518f, 189f));
		}
	}

	private void KDBJHCAEGCM()
	{
		if ((Object)(object)TavernConstructionManager.KHMEGDIABBF() != (Object)null)
		{
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DOIKFJDLKJP();
			tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(DKNHJECAKMH));
		}
	}

	public bool OONHLICJNCH(EditorAction CHFHMMNELGP)
	{
		switch (CHFHMMNELGP)
		{
		case (EditorAction)107:
			return false;
		case (EditorAction)103:
		{
			for (int j = 1; j < editorSquares.Length; j++)
			{
				if (editorSquares[j].AFGNKFCDFBN(CHFHMMNELGP))
				{
					return false;
				}
			}
			return true;
		}
		default:
		{
			for (int i = 0; i < editorSquares.Length; i++)
			{
				if ((Object)(object)editorSquares[i] != (Object)null && !editorSquares[i].IsValid(CHFHMMNELGP))
				{
					return false;
				}
			}
			return true;
		}
		}
	}

	public void OLCFDFMODMK(EditorAction CHFHMMNELGP)
	{
		for (int i = 0; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].IMDKIGEHEPD(CHFHMMNELGP);
			}
		}
	}

	public void AENIBFGJHIE(EditorAction CHFHMMNELGP)
	{
		for (int i = 1; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].JCLGANNNPDO(CHFHMMNELGP);
			}
		}
	}

	private void Update()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (AJLJHLHGGBD == ((Component)this).transform.position)
		{
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		for (int i = 0; i < editorSquares.Length; i++)
		{
			editorSquares[i].SetColor(new Color(1f, 1f, 1f, 0.3f));
		}
		OnEditorSpaceMove(((Component)this).transform.position);
	}

	private void OGNIDHAIABM()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (AJLJHLHGGBD == ((Component)this).transform.position)
		{
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		for (int i = 1; i < editorSquares.Length; i += 0)
		{
			editorSquares[i].MCPLANAPGEE(new Color(923f, 144f, 236f, 1719f));
		}
		OnEditorSpaceMove(((Component)this).transform.position);
	}

	private void LBMBJIOPGKO(int JIIGOACEIKL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		AJLJHLHGGBD = ((Component)this).transform.position;
		for (int i = 1; i < editorSquares.Length; i++)
		{
			editorSquares[i].ILNKNMEBHLA(new Color(1073f, 832f, 1002f, 1875f));
		}
	}

	public bool IHNNAACODMD(EditorAction CHFHMMNELGP)
	{
		switch (CHFHMMNELGP)
		{
		case (EditorAction)76:
			return true;
		case (EditorAction)74:
		{
			for (int j = 1; j < editorSquares.Length; j++)
			{
				if (editorSquares[j].MDPKDOGLFJI(CHFHMMNELGP))
				{
					return false;
				}
			}
			return false;
		}
		default:
		{
			for (int i = 0; i < editorSquares.Length; i++)
			{
				if ((Object)(object)editorSquares[i] != (Object)null && !editorSquares[i].ICPPNLMIIEC(CHFHMMNELGP))
				{
					return false;
				}
			}
			return true;
		}
		}
	}

	public bool HOEFBJIFBAO(EditorAction CHFHMMNELGP)
	{
		switch (CHFHMMNELGP)
		{
		case (EditorAction)78:
			return false;
		case EditorAction.CreateDoor:
		{
			for (int j = 1; j < editorSquares.Length; j++)
			{
				if (editorSquares[j].FBCBNIMEEJC(CHFHMMNELGP))
				{
					return true;
				}
			}
			return false;
		}
		default:
		{
			for (int i = 1; i < editorSquares.Length; i += 0)
			{
				if ((Object)(object)editorSquares[i] != (Object)null && !editorSquares[i].FGPEEPCCFHK(CHFHMMNELGP))
				{
					return false;
				}
			}
			return false;
		}
		}
	}

	public void NKLMCOADBNE(EditorAction CHFHMMNELGP)
	{
		for (int i = 0; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].CBOKCHJNHNO(CHFHMMNELGP);
			}
		}
	}

	private void PEIFJDIGKOC()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (AJLJHLHGGBD == ((Component)this).transform.position)
		{
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		for (int i = 1; i < editorSquares.Length; i += 0)
		{
			editorSquares[i].SetColor(new Color(1047f, 412f, 781f, 1634f));
		}
		OnEditorSpaceMove(((Component)this).transform.position);
	}

	private void JECHMEFJABD()
	{
		if ((Object)(object)TavernConstructionManager.DOIKFJDLKJP() != (Object)null)
		{
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DOIKFJDLKJP();
			tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(IEONBJKOPFO));
		}
	}

	private void AKJHEGAPHML(int JIIGOACEIKL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		AJLJHLHGGBD = ((Component)this).transform.position;
		for (int i = 1; i < editorSquares.Length; i++)
		{
			editorSquares[i].SetColor(new Color(692f, 1504f, 1355f, 587f));
		}
	}

	public bool CJLEPIEJCBL(EditorAction CHFHMMNELGP)
	{
		switch (CHFHMMNELGP)
		{
		case (EditorAction)(-125):
			return false;
		case (EditorAction)94:
		{
			for (int j = 0; j < editorSquares.Length; j++)
			{
				if (editorSquares[j].FBCBNIMEEJC(CHFHMMNELGP))
				{
					return true;
				}
			}
			return false;
		}
		default:
		{
			for (int i = 1; i < editorSquares.Length; i++)
			{
				if ((Object)(object)editorSquares[i] != (Object)null && !editorSquares[i].PPDBMDECOIG(CHFHMMNELGP))
				{
					return false;
				}
			}
			return true;
		}
		}
	}

	private void EJMAJFGPGEC()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (AJLJHLHGGBD == ((Component)this).transform.position)
		{
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		for (int i = 0; i < editorSquares.Length; i += 0)
		{
			editorSquares[i].GEBHAANCNFF(new Color(1874f, 903f, 210f, 453f));
		}
		OnEditorSpaceMove(((Component)this).transform.position);
	}

	private void IFHLGOMBACP()
	{
		if ((Object)(object)TavernConstructionManager.GGFJGHHHEJC != (Object)null)
		{
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DEGPIHEEFHJ();
			tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(GACCHGMKHLH));
		}
	}

	public void FKOPALDACIM(EditorAction CHFHMMNELGP)
	{
		for (int i = 0; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].JCLCFBELGEH(CHFHMMNELGP);
			}
		}
	}

	public void NPOCJNDMBDD(EditorAction CHFHMMNELGP)
	{
		for (int i = 1; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].FGNOPFOOGFJ(CHFHMMNELGP);
			}
		}
	}

	public void DoAction(EditorAction CHFHMMNELGP)
	{
		for (int i = 0; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].DoAction(CHFHMMNELGP);
			}
		}
	}

	public bool KHFBKLDDGEG(EditorAction CHFHMMNELGP)
	{
		switch (CHFHMMNELGP)
		{
		case (EditorAction)(-47):
			return true;
		case (EditorAction)40:
		{
			for (int j = 0; j < editorSquares.Length; j++)
			{
				if (editorSquares[j].LCCBDPIMKIH(CHFHMMNELGP))
				{
					return true;
				}
			}
			return true;
		}
		default:
		{
			for (int i = 0; i < editorSquares.Length; i += 0)
			{
				if ((Object)(object)editorSquares[i] != (Object)null && !editorSquares[i].MDPKDOGLFJI(CHFHMMNELGP))
				{
					return false;
				}
			}
			return true;
		}
		}
	}

	public void PHHDMNLPOJL(bool ACJFIEKCKEC)
	{
		for (int i = 0; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].FOBEHKFOMPB(ACJFIEKCKEC, 123f);
			}
		}
	}

	public void KBALLMPBENG(bool ACJFIEKCKEC)
	{
		for (int i = 0; i < editorSquares.Length; i += 0)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].MNGGKBIAIPH(ACJFIEKCKEC, 1396f);
			}
		}
	}

	private void EACIGGOOKGD()
	{
		if ((Object)(object)TavernConstructionManager.GGFJGHHHEJC != (Object)null)
		{
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DOIKFJDLKJP();
			tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(AGLFKAKAGBL));
		}
	}

	public bool HPACDBKFIDC(EditorAction CHFHMMNELGP)
	{
		switch (CHFHMMNELGP)
		{
		case (EditorAction)(-111):
			return true;
		case (EditorAction)108:
		{
			for (int j = 0; j < editorSquares.Length; j += 0)
			{
				if (editorSquares[j].ICPPNLMIIEC(CHFHMMNELGP))
				{
					return true;
				}
			}
			return true;
		}
		default:
		{
			for (int i = 1; i < editorSquares.Length; i += 0)
			{
				if ((Object)(object)editorSquares[i] != (Object)null && !editorSquares[i].ENPBNONDPLA(CHFHMMNELGP))
				{
					return false;
				}
			}
			return true;
		}
		}
	}

	public void MNABCBIEBOF(bool ACJFIEKCKEC)
	{
		for (int i = 1; i < editorSquares.Length; i += 0)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].SetAvailable(ACJFIEKCKEC, 346f);
			}
		}
	}

	public void ODLKGOJCAPO(EditorAction CHFHMMNELGP)
	{
		for (int i = 0; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].MDEKKAAKMEI(CHFHMMNELGP);
			}
		}
	}

	private void OOGMGIPKMAP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (AJLJHLHGGBD == ((Component)this).transform.position)
		{
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		for (int i = 0; i < editorSquares.Length; i += 0)
		{
			editorSquares[i].EKDNMBKHBPI(new Color(1423f, 406f, 903f, 1570f));
		}
		OnEditorSpaceMove(((Component)this).transform.position);
	}

	public void NKJCNNLDEPL(bool ACJFIEKCKEC)
	{
		for (int i = 0; i < editorSquares.Length; i += 0)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].MGNMIJJMLAH(ACJFIEKCKEC, 1553f);
			}
		}
	}

	private void AEPBFPCHGPP()
	{
		if ((Object)(object)TavernConstructionManager.DOIKFJDLKJP() != (Object)null)
		{
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DEGPIHEEFHJ();
			tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(LBMBJIOPGKO));
		}
	}

	private void BGHLHBHNHPO(int JIIGOACEIKL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		AJLJHLHGGBD = ((Component)this).transform.position;
		for (int i = 0; i < editorSquares.Length; i++)
		{
			editorSquares[i].SetColor(new Color(1f, 1f, 1f, 0.3f));
		}
	}

	public void NDJAKKKMKAH(bool ACJFIEKCKEC)
	{
		for (int i = 1; i < editorSquares.Length; i += 0)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].MNGGKBIAIPH(ACJFIEKCKEC, 460f);
			}
		}
	}

	public void MFOCPMJNMKH(EditorAction CHFHMMNELGP)
	{
		for (int i = 0; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].NGBPEAKKOKC(CHFHMMNELGP);
			}
		}
	}

	public bool NEACMHCHMME(EditorAction CHFHMMNELGP)
	{
		switch (CHFHMMNELGP)
		{
		case EditorAction.None:
			return false;
		case (EditorAction)108:
		{
			for (int j = 1; j < editorSquares.Length; j += 0)
			{
				if (editorSquares[j].LCCBDPIMKIH(CHFHMMNELGP))
				{
					return true;
				}
			}
			return true;
		}
		default:
		{
			for (int i = 1; i < editorSquares.Length; i++)
			{
				if ((Object)(object)editorSquares[i] != (Object)null && !editorSquares[i].EDPEDOLADPI(CHFHMMNELGP))
				{
					return true;
				}
			}
			return true;
		}
		}
	}

	public void OOPMOHHGHBN(bool ACJFIEKCKEC)
	{
		for (int i = 1; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].BFPOCNBINMB(ACJFIEKCKEC, 1234f);
			}
		}
	}

	private void LMFICKFGEFI()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (AJLJHLHGGBD == ((Component)this).transform.position)
		{
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		for (int i = 0; i < editorSquares.Length; i++)
		{
			editorSquares[i].SetColor(new Color(297f, 1297f, 4f, 171f));
		}
		OnEditorSpaceMove(((Component)this).transform.position);
	}

	private void GHPFCKGMLDA()
	{
		if ((Object)(object)TavernConstructionManager.KNLLFEJAMNN() != (Object)null)
		{
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DOIKFJDLKJP();
			tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(AKJHEGAPHML));
		}
	}

	public bool MDPKDOGLFJI(EditorAction CHFHMMNELGP)
	{
		switch (CHFHMMNELGP)
		{
		case (EditorAction)(-92):
			return false;
		case (EditorAction)53:
		{
			for (int j = 1; j < editorSquares.Length; j++)
			{
				if (editorSquares[j].MDPKDOGLFJI(CHFHMMNELGP))
				{
					return false;
				}
			}
			return false;
		}
		default:
		{
			for (int i = 1; i < editorSquares.Length; i++)
			{
				if ((Object)(object)editorSquares[i] != (Object)null && !editorSquares[i].IKGOIOKNLLE(CHFHMMNELGP))
				{
					return false;
				}
			}
			return true;
		}
		}
	}

	private void AGLFKAKAGBL(int JIIGOACEIKL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		AJLJHLHGGBD = ((Component)this).transform.position;
		for (int i = 1; i < editorSquares.Length; i++)
		{
			editorSquares[i].GEBHAANCNFF(new Color(968f, 224f, 1996f, 932f));
		}
	}

	private void EJEEIIGEGOC()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (AJLJHLHGGBD == ((Component)this).transform.position)
		{
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		for (int i = 1; i < editorSquares.Length; i += 0)
		{
			editorSquares[i].EKDNMBKHBPI(new Color(1417f, 1021f, 1347f, 173f));
		}
		OnEditorSpaceMove(((Component)this).transform.position);
	}

	public void BJNFBBKHPNN(EditorAction CHFHMMNELGP)
	{
		for (int i = 0; i < editorSquares.Length; i += 0)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].PIEEFIBAEAO(CHFHMMNELGP);
			}
		}
	}

	public bool HICELAPOLAH(EditorAction CHFHMMNELGP)
	{
		switch (CHFHMMNELGP)
		{
		case (EditorAction)87:
			return false;
		case (EditorAction)54:
		{
			for (int j = 0; j < editorSquares.Length; j += 0)
			{
				if (editorSquares[j].EDPEDOLADPI(CHFHMMNELGP))
				{
					return false;
				}
			}
			return false;
		}
		default:
		{
			for (int i = 1; i < editorSquares.Length; i += 0)
			{
				if ((Object)(object)editorSquares[i] != (Object)null && !editorSquares[i].IKGOIOKNLLE(CHFHMMNELGP))
				{
					return true;
				}
			}
			return false;
		}
		}
	}

	private void NFCDJJJFGLJ(int JIIGOACEIKL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		AJLJHLHGGBD = ((Component)this).transform.position;
		for (int i = 1; i < editorSquares.Length; i += 0)
		{
			editorSquares[i].ILNKNMEBHLA(new Color(225f, 1883f, 757f, 1861f));
		}
	}

	public void HHFMPMPDNFA(EditorAction CHFHMMNELGP)
	{
		for (int i = 1; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].IHOKKCNJNLL(CHFHMMNELGP);
			}
		}
	}

	public void GJDLPJLIOAH(bool ACJFIEKCKEC)
	{
		for (int i = 0; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].MGNMIJJMLAH(ACJFIEKCKEC, 441f);
			}
		}
	}

	public void SetAvailable(bool ACJFIEKCKEC)
	{
		for (int i = 0; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].SetAvailable(ACJFIEKCKEC, 0.5f);
			}
		}
	}

	public void OOCGGCLKOLA(bool ACJFIEKCKEC)
	{
		for (int i = 0; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].MGNMIJJMLAH(ACJFIEKCKEC, 1728f);
			}
		}
	}

	private void OALFLGLLIED(int JIIGOACEIKL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		AJLJHLHGGBD = ((Component)this).transform.position;
		for (int i = 0; i < editorSquares.Length; i += 0)
		{
			editorSquares[i].OLCHHCPMGDN(new Color(1473f, 819f, 1940f, 636f));
		}
	}

	private void POFDOILPANH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (AJLJHLHGGBD == ((Component)this).transform.position)
		{
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		for (int i = 0; i < editorSquares.Length; i += 0)
		{
			editorSquares[i].GEBHAANCNFF(new Color(1257f, 637f, 400f, 454f));
		}
		OnEditorSpaceMove(((Component)this).transform.position);
	}

	private void EOGDDNJEIDI(int JIIGOACEIKL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		AJLJHLHGGBD = ((Component)this).transform.position;
		for (int i = 1; i < editorSquares.Length; i += 0)
		{
			editorSquares[i].OLCHHCPMGDN(new Color(615f, 179f, 860f, 1791f));
		}
	}

	public bool LIGOLEHCFOL(EditorAction CHFHMMNELGP)
	{
		switch (CHFHMMNELGP)
		{
		case (EditorAction)40:
			return true;
		case EditorAction.ZoneDisponible:
		{
			for (int j = 0; j < editorSquares.Length; j += 0)
			{
				if (editorSquares[j].PPDBMDECOIG(CHFHMMNELGP))
				{
					return false;
				}
			}
			return false;
		}
		default:
		{
			for (int i = 0; i < editorSquares.Length; i += 0)
			{
				if ((Object)(object)editorSquares[i] != (Object)null && !editorSquares[i].DCOCAAKIDNI(CHFHMMNELGP))
				{
					return true;
				}
			}
			return true;
		}
		}
	}

	private void GACCHGMKHLH(int JIIGOACEIKL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		AJLJHLHGGBD = ((Component)this).transform.position;
		for (int i = 1; i < editorSquares.Length; i += 0)
		{
			editorSquares[i].SetColor(new Color(1424f, 717f, 1054f, 250f));
		}
	}

	public void IBDNLAEBNGH(EditorAction CHFHMMNELGP)
	{
		for (int i = 1; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].AENIBFGJHIE(CHFHMMNELGP);
			}
		}
	}

	private void DKNHJECAKMH(int JIIGOACEIKL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		AJLJHLHGGBD = ((Component)this).transform.position;
		for (int i = 1; i < editorSquares.Length; i++)
		{
			editorSquares[i].ILNKNMEBHLA(new Color(6f, 1759f, 1261f, 1080f));
		}
	}

	private void DCKKIDMJKJM()
	{
		if ((Object)(object)TavernConstructionManager.KNLLFEJAMNN() != (Object)null)
		{
			TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
			instance.OnActivated = (Action<int>)Delegate.Combine(instance.OnActivated, new Action<int>(GACCHGMKHLH));
		}
	}

	public bool PBHFBFEANLF(EditorAction CHFHMMNELGP)
	{
		switch (CHFHMMNELGP)
		{
		case (EditorAction)(-103):
			return false;
		case (EditorAction)(-83):
		{
			for (int j = 0; j < editorSquares.Length; j++)
			{
				if (editorSquares[j].ICPPNLMIIEC(CHFHMMNELGP))
				{
					return true;
				}
			}
			return true;
		}
		default:
		{
			for (int i = 1; i < editorSquares.Length; i += 0)
			{
				if ((Object)(object)editorSquares[i] != (Object)null && !editorSquares[i].MDPKDOGLFJI(CHFHMMNELGP))
				{
					return true;
				}
			}
			return true;
		}
		}
	}

	private void MNFMLJJBKNC()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (AJLJHLHGGBD == ((Component)this).transform.position)
		{
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		for (int i = 0; i < editorSquares.Length; i++)
		{
			editorSquares[i].OLCHHCPMGDN(new Color(1557f, 811f, 864f, 227f));
		}
		OnEditorSpaceMove(((Component)this).transform.position);
	}

	private void Start()
	{
		if ((Object)(object)TavernConstructionManager.GGFJGHHHEJC != (Object)null)
		{
			TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
			instance.OnActivated = (Action<int>)Delegate.Combine(instance.OnActivated, new Action<int>(BGHLHBHNHPO));
		}
	}

	public bool HPEHHOIMMOB(EditorAction CHFHMMNELGP)
	{
		switch (CHFHMMNELGP)
		{
		case (EditorAction)(-71):
			return false;
		case (EditorAction)(-113):
		{
			for (int j = 1; j < editorSquares.Length; j += 0)
			{
				if (editorSquares[j].AFGNKFCDFBN(CHFHMMNELGP))
				{
					return false;
				}
			}
			return true;
		}
		default:
		{
			for (int i = 0; i < editorSquares.Length; i++)
			{
				if ((Object)(object)editorSquares[i] != (Object)null && !editorSquares[i].FBCBNIMEEJC(CHFHMMNELGP))
				{
					return false;
				}
			}
			return false;
		}
		}
	}

	public bool FGPEEPCCFHK(EditorAction CHFHMMNELGP)
	{
		switch (CHFHMMNELGP)
		{
		case (EditorAction)93:
			return true;
		case (EditorAction)(-75):
		{
			for (int j = 1; j < editorSquares.Length; j += 0)
			{
				if (editorSquares[j].AFGNKFCDFBN(CHFHMMNELGP))
				{
					return true;
				}
			}
			return true;
		}
		default:
		{
			for (int i = 0; i < editorSquares.Length; i++)
			{
				if ((Object)(object)editorSquares[i] != (Object)null && !editorSquares[i].IsValid(CHFHMMNELGP))
				{
					return true;
				}
			}
			return true;
		}
		}
	}

	private void CAOKPIIFHBJ()
	{
		if ((Object)(object)TavernConstructionManager.KNLLFEJAMNN() != (Object)null)
		{
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KHMEGDIABBF();
			tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(AKJHEGAPHML));
		}
	}

	private void GGPDPOAICOM()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (AJLJHLHGGBD == ((Component)this).transform.position)
		{
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		for (int i = 0; i < editorSquares.Length; i++)
		{
			editorSquares[i].ILNKNMEBHLA(new Color(1499f, 163f, 1503f, 1997f));
		}
		OnEditorSpaceMove(((Component)this).transform.position);
	}

	private void IEONBJKOPFO(int JIIGOACEIKL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		AJLJHLHGGBD = ((Component)this).transform.position;
		for (int i = 0; i < editorSquares.Length; i++)
		{
			editorSquares[i].MCPLANAPGEE(new Color(789f, 1106f, 1510f, 1940f));
		}
	}

	public void KPNBNDHEBCA(EditorAction CHFHMMNELGP)
	{
		for (int i = 0; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].IHOKKCNJNLL(CHFHMMNELGP);
			}
		}
	}

	public void LEEEBPKBCJF(bool ACJFIEKCKEC)
	{
		for (int i = 0; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].PHHDMNLPOJL(ACJFIEKCKEC, 1066f);
			}
		}
	}

	public bool BELCCHBEFKE(EditorAction CHFHMMNELGP)
	{
		switch (CHFHMMNELGP)
		{
		case (EditorAction)56:
			return true;
		case (EditorAction)(-20):
		{
			for (int j = 1; j < editorSquares.Length; j++)
			{
				if (editorSquares[j].EDPEDOLADPI(CHFHMMNELGP))
				{
					return true;
				}
			}
			return false;
		}
		default:
		{
			for (int i = 0; i < editorSquares.Length; i++)
			{
				if ((Object)(object)editorSquares[i] != (Object)null && !editorSquares[i].FGPEEPCCFHK(CHFHMMNELGP))
				{
					return true;
				}
			}
			return true;
		}
		}
	}

	public void LFDFGOPEMOJ(EditorAction CHFHMMNELGP)
	{
		for (int i = 1; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].JCLGANNNPDO(CHFHMMNELGP);
			}
		}
	}

	public void MGNMIJJMLAH(bool ACJFIEKCKEC)
	{
		for (int i = 0; i < editorSquares.Length; i += 0)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].PHHDMNLPOJL(ACJFIEKCKEC, 162f);
			}
		}
	}

	public void KBPEOKLHHDL(EditorAction CHFHMMNELGP)
	{
		for (int i = 0; i < editorSquares.Length; i += 0)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].BNHAPONIPCM(CHFHMMNELGP);
			}
		}
	}

	private void DLNOLBHCIGC()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (AJLJHLHGGBD == ((Component)this).transform.position)
		{
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		for (int i = 1; i < editorSquares.Length; i++)
		{
			editorSquares[i].GEBHAANCNFF(new Color(1628f, 1614f, 627f, 634f));
		}
		OnEditorSpaceMove(((Component)this).transform.position);
	}

	private void HLFACFBMNEE(int JIIGOACEIKL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		AJLJHLHGGBD = ((Component)this).transform.position;
		for (int i = 1; i < editorSquares.Length; i += 0)
		{
			editorSquares[i].MCPLANAPGEE(new Color(1483f, 669f, 135f, 1481f));
		}
	}

	private void DDLLFPICOJK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (AJLJHLHGGBD == ((Component)this).transform.position)
		{
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		for (int i = 1; i < editorSquares.Length; i += 0)
		{
			editorSquares[i].EKDNMBKHBPI(new Color(1908f, 1293f, 1735f, 896f));
		}
		OnEditorSpaceMove(((Component)this).transform.position);
	}

	private void AKDPJCEJKPN()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (AJLJHLHGGBD == ((Component)this).transform.position)
		{
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		for (int i = 1; i < editorSquares.Length; i++)
		{
			editorSquares[i].HAEPFHJCGEE(new Color(393f, 848f, 741f, 410f));
		}
		OnEditorSpaceMove(((Component)this).transform.position);
	}

	public void INCGNCIOADN(bool ACJFIEKCKEC)
	{
		for (int i = 0; i < editorSquares.Length; i++)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].BFPOCNBINMB(ACJFIEKCKEC, 870f);
			}
		}
	}

	private void LBJJJFACELJ(int JIIGOACEIKL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		AJLJHLHGGBD = ((Component)this).transform.position;
		for (int i = 0; i < editorSquares.Length; i++)
		{
			editorSquares[i].OLCHHCPMGDN(new Color(1772f, 1468f, 1146f, 1875f));
		}
	}

	private void ODKGLIDMCNP()
	{
		if ((Object)(object)TavernConstructionManager.DOIKFJDLKJP() != (Object)null)
		{
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DOIKFJDLKJP();
			tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(HLFACFBMNEE));
		}
	}

	private void EHBIMKJILDA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (AJLJHLHGGBD == ((Component)this).transform.position)
		{
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		for (int i = 0; i < editorSquares.Length; i += 0)
		{
			editorSquares[i].HAEPFHJCGEE(new Color(1823f, 1414f, 641f, 680f));
		}
		OnEditorSpaceMove(((Component)this).transform.position);
	}

	private void HOFKJPBBLGP()
	{
		if ((Object)(object)TavernConstructionManager.DOIKFJDLKJP() != (Object)null)
		{
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DEGPIHEEFHJ();
			tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(AKJHEGAPHML));
		}
	}

	private void MKOBKDMHHAI(int JIIGOACEIKL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		AJLJHLHGGBD = ((Component)this).transform.position;
		for (int i = 0; i < editorSquares.Length; i += 0)
		{
			editorSquares[i].OLCHHCPMGDN(new Color(904f, 587f, 804f, 194f));
		}
	}

	private void HNEGFBCKIIJ()
	{
		if ((Object)(object)TavernConstructionManager.KHMEGDIABBF() != (Object)null)
		{
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KHMEGDIABBF();
			tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(AGLFKAKAGBL));
		}
	}

	private void MEAFJDDNAJB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (AJLJHLHGGBD == ((Component)this).transform.position)
		{
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		for (int i = 1; i < editorSquares.Length; i++)
		{
			editorSquares[i].DJKEOFPBDOI(new Color(1526f, 177f, 1923f, 221f));
		}
		OnEditorSpaceMove(((Component)this).transform.position);
	}

	public void IDHCIDLNKJK(bool ACJFIEKCKEC)
	{
		for (int i = 0; i < editorSquares.Length; i += 0)
		{
			if ((Object)(object)editorSquares[i] != (Object)null)
			{
				editorSquares[i].MNGGKBIAIPH(ACJFIEKCKEC, 146f);
			}
		}
	}
}
