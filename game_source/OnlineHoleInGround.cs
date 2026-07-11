using UnityEngine;

public class OnlineHoleInGround : OnlineObject
{
	private enum JDBLOKANBMI
	{
		Dig
	}

	public int prefabIndex;

	public HoleInGround holeInGround;

	[HideInInspector]
	public bool found;

	public void BKHGLAHMICE(byte EKJDLCODLJG)
	{
		found = false;
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, EKJDLCODLJG);
	}

	public void LPCCJMOOKPJ(byte EKJDLCODLJG)
	{
		found = true;
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = EKJDLCODLJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void PDBJPAJDGKB(byte EKJDLCODLJG)
	{
		found = false;
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, EKJDLCODLJG);
	}

	public void Dig(byte EKJDLCODLJG)
	{
		found = true;
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, EKJDLCODLJG);
	}

	public void PKBFNMNMFLI(byte EKJDLCODLJG)
	{
		found = true;
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, EKJDLCODLJG);
	}

	public override void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		if (FACPEEACCMH == 0)
		{
			holeInGround.OnlineDig((byte)GEMFIOKGIMC[0]);
			found = true;
		}
	}

	private void CHIJGHPHCNA()
	{
		if (OnlineManager.PlayingOnline() && !((Object)(object)holeInGround == (Object)null) && uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateHoleInGround(this);
			}
		}
	}

	public void HPFDCKNCMMJ(byte EKJDLCODLJG)
	{
		found = false;
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, EKJDLCODLJG);
	}

	public void GGBOOJENJGJ(byte EKJDLCODLJG)
	{
		found = true;
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = EKJDLCODLJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void LBOGKGOBNDC(byte EKJDLCODLJG)
	{
		found = false;
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = EKJDLCODLJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	private void CEIIFHIBIFI()
	{
		if (OnlineManager.PlayingOnline() && !((Object)(object)holeInGround == (Object)null) && uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateHoleInGround(this);
			}
		}
	}

	public void OODDMEFAEPK(byte EKJDLCODLJG)
	{
		found = false;
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = EKJDLCODLJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	private void NKDFMFFDGKC()
	{
		if (OnlineManager.PlayingOnline() && !((Object)(object)holeInGround == (Object)null) && uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateHoleInGround(this);
			}
		}
	}

	public void BPABBJEEJMO(byte EKJDLCODLJG)
	{
		found = true;
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = EKJDLCODLJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void AGMPIBGPHFE(byte EKJDLCODLJG)
	{
		found = false;
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = EKJDLCODLJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	private void HFFFFAJFIPB()
	{
		if (OnlineManager.PlayingOnline() && !((Object)(object)holeInGround == (Object)null) && uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateHoleInGround(this);
			}
		}
	}

	public void HLLMHNPLKNN(byte EKJDLCODLJG)
	{
		found = false;
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, EKJDLCODLJG);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		Debug.Log((object)("Get Components " + ((Object)((Component)this).gameObject).name));
		holeInGround = ((Component)this).GetComponent<HoleInGround>();
		holeInGround.onlineHole = this;
	}

	public void DPFALNNJKFP(byte EKJDLCODLJG)
	{
		found = false;
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = EKJDLCODLJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	private void Start()
	{
		if (OnlineManager.PlayingOnline() && !((Object)(object)holeInGround == (Object)null) && uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateHoleInGround(this);
			}
		}
	}

	private void KJOJLHCDFPP()
	{
		if (OnlineManager.PlayingOnline() && !((Object)(object)holeInGround == (Object)null) && uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateHoleInGround(this);
			}
		}
	}

	public void PDMNIFJPCDB(byte EKJDLCODLJG)
	{
		found = false;
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = EKJDLCODLJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void HCJKKNGMFEE(byte EKJDLCODLJG)
	{
		found = true;
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = EKJDLCODLJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	private void LANGHIOBJIH()
	{
		if (OnlineManager.PlayingOnline() && !((Object)(object)holeInGround == (Object)null) && uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateHoleInGround(this);
			}
		}
	}

	private void HOFKJPBBLGP()
	{
		if (OnlineManager.PlayingOnline() && !((Object)(object)holeInGround == (Object)null) && uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateHoleInGround(this);
			}
		}
	}
}
