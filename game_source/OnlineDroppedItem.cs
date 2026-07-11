using UnityEngine;

public class OnlineDroppedItem : OnlineObject
{
	public DroppedItem droppedItem;

	public StackDroppedItems stackDroppedItem;

	private float DCGBADKLANM;

	private Vector3 AJLJHLHGGBD;

	public void IEAPCCKFFFB()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void HFKGEPJNADL()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			BIKEKDGHOMN();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void JFLOIDPBIKP()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	public void GJDEOEHLGMF()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void LNIJAPIAIIL(short FFDIEOBBFKL)
	{
		stackDroppedItem.NewQuantity(FFDIEOBBFKL);
	}

	private void CHIJGHPHCNA()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateDroppedItem(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void IFKBADPMAIG()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	private void ICMNODPLPBK()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			EPDCPECMDJH();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void DAJLGBIIBFM()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		Debug.Log((object)("Get Components " + ((Object)((Component)this).gameObject).name));
		droppedItem = ((Component)((Component)this).transform).GetComponent<DroppedItem>();
		stackDroppedItem = ((Component)((Component)this).transform).GetComponentInChildren<StackDroppedItems>();
		droppedItem.onlineDroppedItem = this;
	}

	private void DKNMGFDFLKL()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			GBDILCPGFAA();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void MGMLDHPOLGK()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			GFBNADDDAIO();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void DGJKLAEINHJ()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			JMBBPFDFIND();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void AAECDMFFLKC()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void HJGBCAFNIJM(short FFDIEOBBFKL)
	{
		stackDroppedItem.BKFJKEFJBEJ(FFDIEOBBFKL);
	}

	private void BJBNBDJHMFN()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			EPDCPECMDJH();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void BFMBEDNIGAB()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateDroppedItem(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	private void NNBIAIMPNGL()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.PAFIAFCJKHP(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	private void PEIFJDIGKOC()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			UpdatePosition();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void KOFIHJIBHJJ(short FFDIEOBBFKL)
	{
		stackDroppedItem.BIGCEBNCBAP(FFDIEOBBFKL);
	}

	public void EPDCPECMDJH()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void NCHGLHLJCIJ()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void PBFAEPOEKPG()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateDroppedItem(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void ILNPAEGOCPC()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	public void PGLDHNANKBI()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void IGIKNCOLCKL()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.NCFLAFBFKDK(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void EHHEACEGHHM(short FFDIEOBBFKL)
	{
		stackDroppedItem.ECCGAAIHBNI(FFDIEOBBFKL);
	}

	private void GJMLHECPGBP()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateDroppedItem(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void JFFCDFDPBNC()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void AKLEFPLEGKK()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			ILECPFFPBMC();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void UpdateQuantity(short FFDIEOBBFKL)
	{
		stackDroppedItem.NewQuantity(FFDIEOBBFKL);
	}

	public void KNEFOIDGCED(short FFDIEOBBFKL)
	{
		stackDroppedItem.BIGCEBNCBAP(FFDIEOBBFKL);
	}

	public void MAPEGEAEFLJ()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	public void ILKBNAIPNFJ()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void DCKKIDMJKJM()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.NCFLAFBFKDK(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	private void BDJKNKIOPIJ()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateDroppedItem(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	private void KACEOJDPLKB()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.NCFLAFBFKDK(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void NKOIMDFMMPB()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void IDDLOOKBJFB()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void GOEGBOEMHLI()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.NCFLAFBFKDK(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void KIPCHPAPMJF()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	public void IJBLOOEHMFK(short FFDIEOBBFKL)
	{
		stackDroppedItem.ECCGAAIHBNI(FFDIEOBBFKL);
	}

	public void LIBDIDBPHFI(short FFDIEOBBFKL)
	{
		stackDroppedItem.BIGCEBNCBAP(FFDIEOBBFKL);
	}

	private void PKEPBKHEDOD()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			HAIGBACGLMP();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void EHJBHGHKPPC()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void FPOIFOGELHC()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			GFBNADDDAIO();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void EIFNMDJKNCA()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	public void MovementUpdate()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	private void LPNBCBIBNNI()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.PAFIAFCJKHP(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void FHAEPHLBGDI(short FFDIEOBBFKL)
	{
		stackDroppedItem.BIGCEBNCBAP(FFDIEOBBFKL);
	}

	private void DLNOLBHCIGC()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			LMDGOOIECKH();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void NMIJACDOGMF()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			GJDEOEHLGMF();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void HMFKKEBGEGB()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void Start()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateDroppedItem(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	private void ONOAGANPECB()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			JFFCDFDPBNC();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void PCDLKDLFLJO()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void LECPGMMOBFE()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	public void MEPCHCAMMEP(short FFDIEOBBFKL)
	{
		stackDroppedItem.BIGCEBNCBAP(FFDIEOBBFKL);
	}

	private void HCPKBJDHLAC()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			NCHGLHLJCIJ();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void HAIGBACGLMP()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void GFBNADDDAIO()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void FDJGIFNLEJM()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	private void HKKDEKIFPPJ()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.NCFLAFBFKDK(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	private void ELHCBGCEJDH()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			GJDEOEHLGMF();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void MPEGJPPMIKF()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	public void MOLPGFGOKNN(short FFDIEOBBFKL)
	{
		stackDroppedItem.BKFJKEFJBEJ(FFDIEOBBFKL);
	}

	private void KEPJNGGNAEK()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateDroppedItem(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void KMAELPEFGAB()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	public void CEGPMHPPKHP(short FFDIEOBBFKL)
	{
		stackDroppedItem.NewQuantity(FFDIEOBBFKL);
	}

	private void OAKGHDAABPM()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			EPDCPECMDJH();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void ILECPFFPBMC()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void LDMDHDACNFJ()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			ILKBNAIPNFJ();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void GLJMNCDGMOJ()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void FEAGCCPBBBA()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void PHLLBPLOLFO()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			GFBNADDDAIO();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void FOHCEDHJOEF()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			GJDEOEHLGMF();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void CGEEJBKCMDJ(short FFDIEOBBFKL)
	{
		stackDroppedItem.ECCGAAIHBNI(FFDIEOBBFKL);
	}

	public void DHKDAFCFJPN()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	private void BIGFBGOMOBA()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.NCFLAFBFKDK(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void OACGMEBANCB(short FFDIEOBBFKL)
	{
		stackDroppedItem.ECCGAAIHBNI(FFDIEOBBFKL);
	}

	public void LLLMKICEFJC()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void OONONNJFEFL()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			AAECDMFFLKC();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void AKKHDIIBEJF()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	public void AGNCFGJMGHJ()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	private void MFIBFFDBNGI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			HAIGBACGLMP();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			UpdatePosition();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void LFLFJNCAGDH(short FFDIEOBBFKL)
	{
		stackDroppedItem.NewQuantity(FFDIEOBBFKL);
	}

	private void BJBPHIFNKIF()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.PAFIAFCJKHP(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void MPADPKPDFJK()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	private void PJIMENLPNOE()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			JFFCDFDPBNC();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void EGDIINMEMGE()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.PAFIAFCJKHP(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void JMBBPFDFIND()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void DBGPOMGFJLM(short FFDIEOBBFKL)
	{
		stackDroppedItem.NewQuantity(FFDIEOBBFKL);
	}

	public void KEELPAOHALH()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void PKBHEKHOAAA()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.NCFLAFBFKDK(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void GMACHGJPPEA(short FFDIEOBBFKL)
	{
		stackDroppedItem.NewQuantity(FFDIEOBBFKL);
	}

	private void BIILFPDIADC()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			PGLDHNANKBI();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void PFOAHHLNKNH()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			NKOIMDFMMPB();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void BPOCJDBGFPA()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	protected override void OnDestroy()
	{
		OnlineObjectsManager.instance.movingDroppedItems.Remove(uniqueId);
		base.OnDestroy();
	}

	public void CLAPFEGBNJO()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	private void PDKEPCIEHEP()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			IDDLOOKBJFB();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void FPDPAJHNGHK()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.NCFLAFBFKDK(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	private void ICFHPJHBPDN()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.PAFIAFCJKHP(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void IOLCPGBPNJC(short FFDIEOBBFKL)
	{
		stackDroppedItem.BIGCEBNCBAP(FFDIEOBBFKL);
	}

	public void ENHLGKGMAKC(short FFDIEOBBFKL)
	{
		stackDroppedItem.BIGCEBNCBAP(FFDIEOBBFKL);
	}

	public void PDIMFOCFHEG()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	public void KHHDKOBOOOC(short FFDIEOBBFKL)
	{
		stackDroppedItem.ECCGAAIHBNI(FFDIEOBBFKL);
	}

	private void HMCLGKHCLPG()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			EHJBHGHKPPC();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void ODKGLIDMCNP()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.NCFLAFBFKDK(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void LKOEAOGLKGB()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	public void UpdatePosition()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void EBNKNEIDDDI()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.PAFIAFCJKHP(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void GFLEKOECHEP()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void EJCHNPEBBPM(short FFDIEOBBFKL)
	{
		stackDroppedItem.BKFJKEFJBEJ(FFDIEOBBFKL);
	}

	public void JGNJKJDLLFE()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void GMNHECBKDGN(short FFDIEOBBFKL)
	{
		stackDroppedItem.ECCGAAIHBNI(FFDIEOBBFKL);
	}

	public void JPGGBDBJILI()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	private void AKDPJCEJKPN()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			LLPJKPPPFIH();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void KIOJCHIDOCA()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	public void BKGLMBJHJAB()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	public void CHFMDMDBNCE()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void BDMEBLBLPIA()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.NCFLAFBFKDK(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void JDHLGBPLGME()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void LAABMDDEGCG()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			NKOIMDFMMPB();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void ICBOGGADGFB(short FFDIEOBBFKL)
	{
		stackDroppedItem.BIGCEBNCBAP(FFDIEOBBFKL);
	}

	public void BCMLEANBMAK(short FFDIEOBBFKL)
	{
		stackDroppedItem.BKFJKEFJBEJ(FFDIEOBBFKL);
	}

	private void NDGFPPOBCNP()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.NCFLAFBFKDK(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void BIKEKDGHOMN()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void KHLGPHDLKBJ()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	private void OJOEPCAJPOA()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			PGLDHNANKBI();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void JENJIGFPBDK(short FFDIEOBBFKL)
	{
		stackDroppedItem.BIGCEBNCBAP(FFDIEOBBFKL);
	}

	private void CAIJLMJBMLA()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.NCFLAFBFKDK(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void LMDGOOIECKH()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void IDMNLNDEBMC()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			GFLEKOECHEP();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void GBDILCPGFAA()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void KBOLMFJEFCL()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void IBEBPPLGPFL(short FFDIEOBBFKL)
	{
		stackDroppedItem.BIGCEBNCBAP(FFDIEOBBFKL);
	}

	private void NLIGLFEEFNO()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			LLPJKPPPFIH();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void LLPJKPPPFIH()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void NIHJCJJKDBA()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			NKOIMDFMMPB();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void KIFMLPBFFDP()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateDroppedItem(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	private void DOHLOJOIHFO()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.NCFLAFBFKDK(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void CHNGKGFNHOG()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			droppedItem.itemFollow.rb.MovePosition(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		}
	}

	private void CMJPIAAGIFF()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			LLLMKICEFJC();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	public void OPJHAIDDILA(short FFDIEOBBFKL)
	{
		stackDroppedItem.NewQuantity(FFDIEOBBFKL);
	}

	private void CLOKMCONOMN()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			KBOLMFJEFCL();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void OCBNLECPJBN()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.NCFLAFBFKDK(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	private void HOKBBFHGACN()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.PAFIAFCJKHP(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void CKNLJAFBNIP()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.movingDroppedItems.ContainsKey(uniqueId))
		{
			OnlineObjectsManager.instance.movingDroppedItems[uniqueId] = Vector2.op_Implicit(((Component)this).transform.position);
		}
		else
		{
			OnlineObjectsManager.instance.movingDroppedItems.Add(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	private void CNBLOMJJECI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			AAECDMFFLKC();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void MEAFJDDNAJB()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			JFFCDFDPBNC();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void JGHILHDNHEN()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient() && AJLJHLHGGBD != ((Component)this).transform.position)
		{
			UpdatePosition();
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void BFAPJEOEPHD()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateDroppedItem(this);
			}
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	public void HKPCNOJPIFG(short FFDIEOBBFKL)
	{
		stackDroppedItem.ECCGAAIHBNI(FFDIEOBBFKL);
	}

	public void AJBCHPPKOMA(short FFDIEOBBFKL)
	{
		stackDroppedItem.NewQuantity(FFDIEOBBFKL);
	}

	public void HKJAFPLEBEM(short FFDIEOBBFKL)
	{
		stackDroppedItem.NewQuantity(FFDIEOBBFKL);
	}
}
