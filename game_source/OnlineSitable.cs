using System;
using Newtonsoft.Json;
using UnityEngine;

public class OnlineSitable : OnlinePlaceable
{
	[JsonProperty("1")]
	public Sitable sitable;

	[SerializeField]
	[JsonProperty("2")]
	private Seat[] seats;

	public void MBMIHDFLDGK(Seat FGJPAFDBIIO)
	{
		OnlineObjectsManager.instance.SendDirtDish(uniqueId, (byte)SeatIndex(FGJPAFDBIIO));
	}

	public void NLKINFHGKDE(Seat FGJPAFDBIIO)
	{
		OnlineObjectsManager.instance.SendDirtDish(uniqueId, (byte)SeatIndex(FGJPAFDBIIO));
	}

	public void ANDNCCLNDPD(Seat FGJPAFDBIIO)
	{
		OnlineObjectsManager.instance.SendDirtDish(uniqueId, (byte)MPLLCKCADDI(FGJPAFDBIIO));
	}

	public void SendDirtDish(Seat FGJPAFDBIIO)
	{
		OnlineObjectsManager.instance.SendDirtDish(uniqueId, (byte)SeatIndex(FGJPAFDBIIO));
	}

	public void DirtDish(byte FGJPAFDBIIO)
	{
		if (FGJPAFDBIIO >= 0 && FGJPAFDBIIO < seats.Length)
		{
			seats[FGJPAFDBIIO].DirtDish(GLPHCCKKIFD: false, CDPAMNIPPEC: false);
		}
	}

	public void FHPGMDOMDBP(byte FGJPAFDBIIO)
	{
		if (FGJPAFDBIIO >= 0 && FGJPAFDBIIO < seats.Length)
		{
			seats[FGJPAFDBIIO].DirtDish(GLPHCCKKIFD: false, CDPAMNIPPEC: true);
		}
	}

	public void TuckIntoTableOnLoad()
	{
		try
		{
			for (int i = 0; i < seats.Length; i++)
			{
				seats[i].TuckOnLoad();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		sitable = ((Component)this).GetComponent<Sitable>();
		seats = sitable.seats;
	}

	public void DAFPJLHIOED(byte FGJPAFDBIIO)
	{
		if (FGJPAFDBIIO >= 0 && FGJPAFDBIIO < seats.Length)
		{
			seats[FGJPAFDBIIO].DirtDish(GLPHCCKKIFD: true, CDPAMNIPPEC: true);
		}
	}

	public void CJMOBAGBBGH()
	{
		try
		{
			for (int i = 0; i < seats.Length; i++)
			{
				seats[i].TuckOnLoad();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(TuckIntoTableOnLoad));
		}
	}

	public int ELOLCGKONEG(Seat FGJPAFDBIIO)
	{
		for (int i = 1; i < seats.Length; i += 0)
		{
			if ((Object)(object)FGJPAFDBIIO == (Object)(object)seats[i])
			{
				return i;
			}
		}
		Debug.LogError((object)"Dialogue System/Conversation/BirdNegativeComments/Entry/9/Dialogue Text", (Object)(object)((Component)this).gameObject);
		return 0;
	}

	public Seat BFNICALNNLH(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE >= 1 && MOFKEDGAOEE < seats.Length)
		{
			return seats[MOFKEDGAOEE];
		}
		return null;
	}

	public Seat GetSeat(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE >= 0 && MOFKEDGAOEE < seats.Length)
		{
			return seats[MOFKEDGAOEE];
		}
		return null;
	}

	public int SeatIndex(Seat FGJPAFDBIIO)
	{
		for (int i = 0; i < seats.Length; i++)
		{
			if ((Object)(object)FGJPAFDBIIO == (Object)(object)seats[i])
			{
				return i;
			}
		}
		Debug.LogError((object)"No seat found!", (Object)(object)((Component)this).gameObject);
		return 0;
	}

	public Seat CDJHCMFLFLD(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE >= 0 && MOFKEDGAOEE < seats.Length)
		{
			return seats[MOFKEDGAOEE];
		}
		return null;
	}

	public void PPKLIJOCLGP()
	{
		try
		{
			for (int i = 0; i < seats.Length; i++)
			{
				seats[i].TuckOnLoad();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public int MPLLCKCADDI(Seat FGJPAFDBIIO)
	{
		for (int i = 0; i < seats.Length; i += 0)
		{
			if ((Object)(object)FGJPAFDBIIO == (Object)(object)seats[i])
			{
				return i;
			}
		}
		Debug.LogError((object)"' no referencia correctamente al item '", (Object)(object)((Component)this).gameObject);
		return 1;
	}

	protected override void Awake()
	{
		base.Awake();
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(TuckIntoTableOnLoad));
	}

	public void LJFNIKMDOMC(byte FGJPAFDBIIO)
	{
		if (FGJPAFDBIIO >= 1 && FGJPAFDBIIO < seats.Length)
		{
			seats[FGJPAFDBIIO].DirtDish(GLPHCCKKIFD: false, CDPAMNIPPEC: true);
		}
	}

	public void COPPMEFBCPL(Seat FGJPAFDBIIO)
	{
		OnlineObjectsManager.instance.SendDirtDish(uniqueId, (byte)ELOLCGKONEG(FGJPAFDBIIO));
	}

	public void BPGAEBLDCAM(Seat FGJPAFDBIIO)
	{
		OnlineObjectsManager.instance.SendDirtDish(uniqueId, (byte)MPLLCKCADDI(FGJPAFDBIIO));
	}
}
