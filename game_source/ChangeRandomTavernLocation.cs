using System.Collections.Generic;
using AlmenaraGames;
using UnityEngine;

public class ChangeRandomTavernLocation : MonoBehaviour
{
	public int probability = 50;

	public int probabilityOnSurface = 50;

	public Placeable placeable;

	public AudioObject creepySound;

	public List<Item> possibleItemsList = new List<Item>();

	public void FLDFOAFFGOA(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.AddItemBaseToWorldTilesNextFrame(MMICADKPHLP: true);
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.IsMasterClient())
		{
			placeable.onlinePlaceable.BHAMBMLGFOJ(PAICGEGHOCO);
		}
	}

	public void NAKMBJHFKEP(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.MFJNMJMFEOB(MMICADKPHLP: true);
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.IsMasterClient())
		{
			placeable.onlinePlaceable.SendChangeDollPosition(PAICGEGHOCO);
		}
	}

	private void LALJNGFGKPA()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.MNFMOEKMJKN().currentChangeRandomTavernLocation.Remove(this);
		}
	}

	private void OJJCGNICMBD()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.GGFJGHHHEJC.currentChangeRandomTavernLocation.Remove(this);
		}
	}

	private void EEKOJEKPIMP()
	{
		CommonReferences.GGFJGHHHEJC.currentChangeRandomTavernLocation.Add(this);
	}

	public void BGOBMLPLBEE(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.MFJNMJMFEOB();
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.IsMasterClient())
		{
			placeable.onlinePlaceable.FGFDPMLNNLN(PAICGEGHOCO);
		}
	}

	public void EPMDHJFLAGP()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.MasterOrOffline() || !((Object)(object)placeable != (Object)null) || Random.Range(0, -88) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.GDMIHFGJEBK(CDPAMNIPPEC: true);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(1, -19) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.EPPGPDGLHJJ(placeable);
				}
				placeable.AddPlaceableToSurface(surfaceSortOrder, CDPAMNIPPEC: false);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		DHJKFOMKBLH(Utils.MNOPMFHOKNI());
	}

	public void MHGLEMILFEI()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.MasterOrOffline() || !((Object)(object)placeable != (Object)null) || Random.Range(0, -112) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.GDMIHFGJEBK(CDPAMNIPPEC: false);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(0, 34) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.EPPGPDGLHJJ(placeable);
				}
				placeable.AddPlaceableToSurface(surfaceSortOrder, CDPAMNIPPEC: false, 1, MBFODGDKDHG: true);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		FLDFOAFFGOA(Utils.MNOPMFHOKNI());
	}

	private void PLHEHGHFCJI()
	{
		CommonReferences.GGFJGHHHEJC.currentChangeRandomTavernLocation.Add(this);
	}

	private void AHFGOOHOLEL()
	{
		CommonReferences.MNFMOEKMJKN().currentChangeRandomTavernLocation.Add(this);
	}

	private void OnDestroy()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.GGFJGHHHEJC.currentChangeRandomTavernLocation.Remove(this);
		}
	}

	private void ODNGBEOKEFK()
	{
		CommonReferences.GGFJGHHHEJC.currentChangeRandomTavernLocation.Add(this);
	}

	private void ELEGGKIBHGC()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences.GGFJGHHHEJC.currentChangeRandomTavernLocation.Remove(this);
		}
	}

	private void AGELAMLCINB()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (Object.op_Implicit((Object)(object)placeable.onlinePlaceable))
		{
			placeable.onlinePlaceable.changeRandomLocation = this;
		}
	}

	public void FHPJGGFJGOH()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PGAGDFAEEFB() || !((Object)(object)placeable != (Object)null) || Random.Range(0, -91) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.GDMIHFGJEBK(CDPAMNIPPEC: true);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(0, -77) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.EPPGPDGLHJJ(placeable);
				}
				placeable.FMPLGBBHECD(surfaceSortOrder, CDPAMNIPPEC: true, 0, MBFODGDKDHG: true);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		CHCMAGHEHFE(Utils.MNOPMFHOKNI());
	}

	private void PKBHEKHOAAA()
	{
		CommonReferences.GGFJGHHHEJC.currentChangeRandomTavernLocation.Add(this);
	}

	public void CJFJAJLDJFI()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.MasterOrOffline() || !((Object)(object)placeable != (Object)null) || Random.Range(1, -89) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.GDMIHFGJEBK(CDPAMNIPPEC: true);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(0, 97) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.EPPGPDGLHJJ(placeable);
				}
				placeable.OKNEBLLEFNL(surfaceSortOrder, CDPAMNIPPEC: true);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		GMHBBPHEELE(Utils.MNOPMFHOKNI());
	}

	private void AFCIKJPPLFA()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.MNFMOEKMJKN().currentChangeRandomTavernLocation.Remove(this);
		}
	}

	public void AGKBFGLLNBF()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.MasterOrOffline() || !((Object)(object)placeable != (Object)null) || Random.Range(1, 52) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.GDMIHFGJEBK(CDPAMNIPPEC: true);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(0, -78) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.EPPGPDGLHJJ(placeable);
				}
				placeable.FMPLGBBHECD(surfaceSortOrder, CDPAMNIPPEC: true, 1);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		GMHBBPHEELE(Utils.MNOPMFHOKNI());
	}

	public void GMHBBPHEELE(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.AddItemBaseToWorldTilesNextFrame();
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.IsMasterClient())
		{
			placeable.onlinePlaceable.BAAFGFEMGFN(PAICGEGHOCO);
		}
	}

	private void LJHIPOLCFBP()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences.MNFMOEKMJKN().currentChangeRandomTavernLocation.Remove(this);
		}
	}

	private void BLAJFMAAMDO()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.GGFJGHHHEJC.currentChangeRandomTavernLocation.Remove(this);
		}
	}

	private void LNPDALMANFB()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (Object.op_Implicit((Object)(object)placeable.onlinePlaceable))
		{
			placeable.onlinePlaceable.changeRandomLocation = this;
		}
	}

	private void MBBIGANCPNE()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.MNFMOEKMJKN().currentChangeRandomTavernLocation.Remove(this);
		}
	}

	public void GBGKCODPCKD(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.AddItemBaseToWorldTilesNextFrame();
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.IsMasterClient())
		{
			placeable.onlinePlaceable.AMDDHPEBEIN(PAICGEGHOCO);
		}
	}

	private void Start()
	{
		CommonReferences.GGFJGHHHEJC.currentChangeRandomTavernLocation.Add(this);
	}

	public void EJDJILPHKDN()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.MasterOrOffline() || !((Object)(object)placeable != (Object)null) || Random.Range(0, -12) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.RemoveFromSurface(CDPAMNIPPEC: true);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(0, -3) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.EPPGPDGLHJJ(placeable);
				}
				placeable.OKNEBLLEFNL(surfaceSortOrder, CDPAMNIPPEC: true);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		FLDFOAFFGOA(Utils.MNOPMFHOKNI());
	}

	public void NEKMEPBOJEG()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PGAGDFAEEFB() || !((Object)(object)placeable != (Object)null) || Random.Range(0, -59) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.LAIMKKDMEAG(CDPAMNIPPEC: true);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(0, 117) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.EPPGPDGLHJJ(placeable);
				}
				placeable.AddPlaceableToSurface(surfaceSortOrder, CDPAMNIPPEC: false, 1);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		CHCMAGHEHFE(Utils.MNOPMFHOKNI());
	}

	public void OANIPFKBFKL(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.MFJNMJMFEOB();
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			placeable.onlinePlaceable.KKEKGGJDAJF(PAICGEGHOCO);
		}
	}

	public void HBHPJHNAMGF()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PGAGDFAEEFB() || !((Object)(object)placeable != (Object)null) || Random.Range(0, 9) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.LAIMKKDMEAG(CDPAMNIPPEC: true);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(0, -94) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendNewPosition(placeable);
				}
				placeable.AddPlaceableToSurface(surfaceSortOrder, CDPAMNIPPEC: true);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		CEDJDABMGBP(Utils.MNOPMFHOKNI());
	}

	private void LADLGPKMPBP()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences.MNFMOEKMJKN().currentChangeRandomTavernLocation.Remove(this);
		}
	}

	public void ChangeLocation()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.MasterOrOffline() || !((Object)(object)placeable != (Object)null) || Random.Range(0, 100) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.RemoveFromSurface(CDPAMNIPPEC: true);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(0, 100) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendNewPosition(placeable);
				}
				placeable.AddPlaceableToSurface(surfaceSortOrder, CDPAMNIPPEC: true);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		SetNewLocation(Utils.MNOPMFHOKNI());
	}

	private void OBHFJIDKBJN()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.MNFMOEKMJKN().currentChangeRandomTavernLocation.Remove(this);
		}
	}

	public void DHJKFOMKBLH(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.AddItemBaseToWorldTilesNextFrame();
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.IsMasterClient())
		{
			placeable.onlinePlaceable.AMDDHPEBEIN(PAICGEGHOCO);
		}
	}

	private void NJAFKFAPDIE()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (Object.op_Implicit((Object)(object)placeable.onlinePlaceable))
		{
			placeable.onlinePlaceable.changeRandomLocation = this;
		}
	}

	private void GECHJIGBPEN()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (Object.op_Implicit((Object)(object)placeable.onlinePlaceable))
		{
			placeable.onlinePlaceable.changeRandomLocation = this;
		}
	}

	public void GGAGDABKEGM()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PGAGDFAEEFB() || !((Object)(object)placeable != (Object)null) || Random.Range(0, 0) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.LAIMKKDMEAG(CDPAMNIPPEC: false);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(0, -60) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendNewPosition(placeable);
				}
				placeable.AddPlaceableToSurface(surfaceSortOrder, CDPAMNIPPEC: true, 1);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		IHNNLHIIIAA(Utils.MNOPMFHOKNI());
	}

	public void DCAJCCAONGD(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.AddItemBaseToWorldTilesNextFrame(MMICADKPHLP: true);
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			placeable.onlinePlaceable.JDDHAPNMGNO(PAICGEGHOCO);
		}
	}

	private void EHBMONGBJFI()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (Object.op_Implicit((Object)(object)placeable.onlinePlaceable))
		{
			placeable.onlinePlaceable.changeRandomLocation = this;
		}
	}

	private void GHDBHNMOBMN()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.GGFJGHHHEJC.currentChangeRandomTavernLocation.Remove(this);
		}
	}

	private void FLFBLIOOLMA()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.MNFMOEKMJKN().currentChangeRandomTavernLocation.Remove(this);
		}
	}

	public void FLAINODIKOG(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.AddItemBaseToWorldTilesNextFrame();
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			placeable.onlinePlaceable.KNBABMLDOFD(PAICGEGHOCO);
		}
	}

	private void GFLFDLIMOLI()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (Object.op_Implicit((Object)(object)placeable.onlinePlaceable))
		{
			placeable.onlinePlaceable.changeRandomLocation = this;
		}
	}

	public void AAPFJLLJEJO()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PGAGDFAEEFB() || !((Object)(object)placeable != (Object)null) || Random.Range(1, -109) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.LAIMKKDMEAG(CDPAMNIPPEC: true);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(0, -9) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.EPPGPDGLHJJ(placeable);
				}
				placeable.OKNEBLLEFNL(surfaceSortOrder, CDPAMNIPPEC: false, 1, MBFODGDKDHG: true);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		SetNewLocation(Utils.MNOPMFHOKNI());
	}

	private void APEIPGIHEKP()
	{
		CommonReferences.GGFJGHHHEJC.currentChangeRandomTavernLocation.Add(this);
	}

	private void JPHEOLEEAPB()
	{
		CommonReferences.MNFMOEKMJKN().currentChangeRandomTavernLocation.Add(this);
	}

	public void ALNJPHLFFHK()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PGAGDFAEEFB() || !((Object)(object)placeable != (Object)null) || Random.Range(0, 95) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.RemoveFromSurface(CDPAMNIPPEC: true);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(0, 71) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendNewPosition(placeable);
				}
				placeable.OKNEBLLEFNL(surfaceSortOrder, CDPAMNIPPEC: true, 1, MBFODGDKDHG: true);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		GMHBBPHEELE(Utils.MNOPMFHOKNI());
	}

	private void KHONOODGLBI()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (Object.op_Implicit((Object)(object)placeable.onlinePlaceable))
		{
			placeable.onlinePlaceable.changeRandomLocation = this;
		}
	}

	public void MCCOOONOANH()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PGAGDFAEEFB() || !((Object)(object)placeable != (Object)null) || Random.Range(0, 4) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.RemoveFromSurface(CDPAMNIPPEC: true);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(1, -67) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendNewPosition(placeable);
				}
				placeable.OKNEBLLEFNL(surfaceSortOrder, CDPAMNIPPEC: true, 1, MBFODGDKDHG: true);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		IHNNLHIIIAA(Utils.MNOPMFHOKNI());
	}

	private void ALEAOANPHIO()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (Object.op_Implicit((Object)(object)placeable.onlinePlaceable))
		{
			placeable.onlinePlaceable.changeRandomLocation = this;
		}
	}

	private void HCEDMLJNOBL()
	{
		CommonReferences.GGFJGHHHEJC.currentChangeRandomTavernLocation.Add(this);
	}

	public void DCACMJKFGEF(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.AddItemBaseToWorldTilesNextFrame();
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			placeable.onlinePlaceable.AMDDHPEBEIN(PAICGEGHOCO);
		}
	}

	public void AFGCAHEBACJ(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.MFJNMJMFEOB(MMICADKPHLP: true);
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			placeable.onlinePlaceable.BAAFGFEMGFN(PAICGEGHOCO);
		}
	}

	public void HNCFGMAKDJL()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.MasterOrOffline() || !((Object)(object)placeable != (Object)null) || Random.Range(0, -32) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.GDMIHFGJEBK(CDPAMNIPPEC: false);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(0, 0) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendNewPosition(placeable);
				}
				placeable.FMPLGBBHECD(surfaceSortOrder, CDPAMNIPPEC: false);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		SetNewLocation(Utils.MNOPMFHOKNI());
	}

	public void CEDJDABMGBP(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.AddItemBaseToWorldTilesNextFrame(MMICADKPHLP: true);
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			placeable.onlinePlaceable.BHAMBMLGFOJ(PAICGEGHOCO);
		}
	}

	private void CEOEHODJAJK()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (Object.op_Implicit((Object)(object)placeable.onlinePlaceable))
		{
			placeable.onlinePlaceable.changeRandomLocation = this;
		}
	}

	public void AHBFAAEPGCC()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PGAGDFAEEFB() || !((Object)(object)placeable != (Object)null) || Random.Range(0, -45) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.RemoveFromSurface(CDPAMNIPPEC: false);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(0, -6) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendNewPosition(placeable);
				}
				placeable.AddPlaceableToSurface(surfaceSortOrder, CDPAMNIPPEC: false, 0, MBFODGDKDHG: true);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		GBGKCODPCKD(Utils.MNOPMFHOKNI());
	}

	public void SetNewLocation(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.AddItemBaseToWorldTilesNextFrame();
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.IsMasterClient())
		{
			placeable.onlinePlaceable.SendChangeDollPosition(PAICGEGHOCO);
		}
	}

	public void PHEOAFDFFDO(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.AddItemBaseToWorldTilesNextFrame(MMICADKPHLP: true);
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			placeable.onlinePlaceable.MOPKNAKILDI(PAICGEGHOCO);
		}
	}

	private void JNJCCIFIKOC()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.GGFJGHHHEJC.currentChangeRandomTavernLocation.Remove(this);
		}
	}

	private void OKHLEMPJONN()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (Object.op_Implicit((Object)(object)placeable.onlinePlaceable))
		{
			placeable.onlinePlaceable.changeRandomLocation = this;
		}
	}

	private void EFCNKPEPELL()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (Object.op_Implicit((Object)(object)placeable.onlinePlaceable))
		{
			placeable.onlinePlaceable.changeRandomLocation = this;
		}
	}

	private void NCIBKMLIIAJ()
	{
		CommonReferences.GGFJGHHHEJC.currentChangeRandomTavernLocation.Add(this);
	}

	public void EFJMHKELCNO()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PGAGDFAEEFB() || !((Object)(object)placeable != (Object)null) || Random.Range(0, 95) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.RemoveFromSurface(CDPAMNIPPEC: true);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(1, -124) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendNewPosition(placeable);
				}
				placeable.OKNEBLLEFNL(surfaceSortOrder, CDPAMNIPPEC: false, 0, MBFODGDKDHG: true);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		GMHBBPHEELE(Utils.MNOPMFHOKNI());
	}

	private void BAKDKFKNHDE()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (Object.op_Implicit((Object)(object)placeable.onlinePlaceable))
		{
			placeable.onlinePlaceable.changeRandomLocation = this;
		}
	}

	public void DNPBIPLAFJC()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.MasterOrOffline() || !((Object)(object)placeable != (Object)null) || Random.Range(0, 27) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.LAIMKKDMEAG(CDPAMNIPPEC: true);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(0, 71) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.EPPGPDGLHJJ(placeable);
				}
				placeable.AddPlaceableToSurface(surfaceSortOrder, CDPAMNIPPEC: true);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		CEDJDABMGBP(Utils.MNOPMFHOKNI());
	}

	private void PFLBPMIEKGF()
	{
		CommonReferences.MNFMOEKMJKN().currentChangeRandomTavernLocation.Add(this);
	}

	private void OCPLOMJAFPC()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences.MNFMOEKMJKN().currentChangeRandomTavernLocation.Remove(this);
		}
	}

	private void BNIKICAEIND()
	{
		CommonReferences.MNFMOEKMJKN().currentChangeRandomTavernLocation.Add(this);
	}

	private void IMIONHLAKIH()
	{
		CommonReferences.MNFMOEKMJKN().currentChangeRandomTavernLocation.Add(this);
	}

	public void NNKIOHIEIDB(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.AddItemBaseToWorldTilesNextFrame();
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.IsMasterClient())
		{
			placeable.onlinePlaceable.KKEKGGJDAJF(PAICGEGHOCO);
		}
	}

	public void AJIPIGOMDNO()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PGAGDFAEEFB() || !((Object)(object)placeable != (Object)null) || Random.Range(0, -29) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.GDMIHFGJEBK(CDPAMNIPPEC: true);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(1, 103) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.EPPGPDGLHJJ(placeable);
				}
				placeable.FMPLGBBHECD(surfaceSortOrder, CDPAMNIPPEC: true);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		GBGKCODPCKD(Utils.MNOPMFHOKNI());
	}

	private void Awake()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (Object.op_Implicit((Object)(object)placeable.onlinePlaceable))
		{
			placeable.onlinePlaceable.changeRandomLocation = this;
		}
	}

	public void KLOLMNJEBDG()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.MasterOrOffline() || !((Object)(object)placeable != (Object)null) || Random.Range(0, 76) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.RemoveFromSurface(CDPAMNIPPEC: false);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(0, 23) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendNewPosition(placeable);
				}
				placeable.OKNEBLLEFNL(surfaceSortOrder, CDPAMNIPPEC: false, 0, MBFODGDKDHG: true);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		GMHBBPHEELE(Utils.MNOPMFHOKNI());
	}

	private void AEPBFPCHGPP()
	{
		CommonReferences.GGFJGHHHEJC.currentChangeRandomTavernLocation.Add(this);
	}

	private void KPILPDFCHBG()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences.MNFMOEKMJKN().currentChangeRandomTavernLocation.Remove(this);
		}
	}

	private void FNFNLFOJHHA()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.GGFJGHHHEJC.currentChangeRandomTavernLocation.Remove(this);
		}
	}

	private void DCOEEADJLIK()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences.MNFMOEKMJKN().currentChangeRandomTavernLocation.Remove(this);
		}
	}

	public void IHNNLHIIIAA(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.MFJNMJMFEOB();
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.IsMasterClient())
		{
			placeable.onlinePlaceable.BHAMBMLGFOJ(PAICGEGHOCO);
		}
	}

	private void PEOPFPEDFAK()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences.MNFMOEKMJKN().currentChangeRandomTavernLocation.Remove(this);
		}
	}

	public void FEHAACBLPAA()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.MasterOrOffline() || !((Object)(object)placeable != (Object)null) || Random.Range(0, -53) >= probability)
		{
			return;
		}
		if ((Object)(object)placeable.currentSurface != (Object)null)
		{
			placeable.LAIMKKDMEAG(CDPAMNIPPEC: true);
		}
		else
		{
			placeable.RemoveItemBaseFromWorldTiles();
		}
		if (Random.Range(0, 127) < probabilityOnSurface)
		{
			SurfaceSortOrder surfaceSortOrder = Utils.EBJCKGBAGLE(placeable.itemSetup.item, placeable, possibleItemsList);
			if ((Object)(object)surfaceSortOrder != (Object)null)
			{
				((Component)this).transform.position = Utils.BMBMPKNANAC(Vector2.op_Implicit(Utils.ONOELMILFCA(surfaceSortOrder.surfaceCollider)));
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.EPPGPDGLHJJ(placeable);
				}
				placeable.OKNEBLLEFNL(surfaceSortOrder, CDPAMNIPPEC: false, 0, MBFODGDKDHG: true);
				MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
				return;
			}
		}
		GBGKCODPCKD(Utils.MNOPMFHOKNI());
	}

	private void IGIKNCOLCKL()
	{
		CommonReferences.MNFMOEKMJKN().currentChangeRandomTavernLocation.Add(this);
	}

	public void CHCMAGHEHFE(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.AddItemBaseToWorldTilesNextFrame();
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.IsMasterClient())
		{
			placeable.onlinePlaceable.DCPIJMMCBGM(PAICGEGHOCO);
		}
	}

	public void PKIHFHKHMNN(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.BMBMPKNANAC(PAICGEGHOCO);
		placeable.AddItemBaseToWorldTilesNextFrame();
		MultiAudioManager.PlayAudioObject(creepySound, ((Component)this).transform);
		if (OnlineManager.IsMasterClient())
		{
			placeable.onlinePlaceable.DCPIJMMCBGM(PAICGEGHOCO);
		}
	}
}
