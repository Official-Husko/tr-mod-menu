using System;
using UnityEngine;

[Serializable]
public class NPCAction
{
	public Action OnSuccessfulStart = delegate
	{
	};

	public Action OnActionComplete = delegate
	{
	};

	public Action OnFailStart = delegate
	{
	};

	public bool complete;

	public NPC npc;

	[SerializeField]
	protected bool canceled;

	public virtual bool PLAGPJAKCKL(bool OEBNHGNJEJL = false)
	{
		FIOIDMJCAKH();
		return true;
	}

	public virtual bool PAHDHACALOH(bool OEBNHGNJEJL = false)
	{
		EGIBBBDHEGC();
		return false;
	}

	public virtual void NOFKEMGPFEO()
	{
	}

	public virtual void EHDKLBLKBEO()
	{
	}

	protected virtual void CDBLJBAFIIK()
	{
		if (OnFailStart != null)
		{
			OnFailStart();
		}
	}

	public virtual bool BODEPFFAHLE(bool OEBNHGNJEJL = false)
	{
		FIOIDMJCAKH();
		return true;
	}

	protected void EGDEAFHIKAI()
	{
		if (OnSuccessfulStart != null)
		{
			OnSuccessfulStart();
		}
	}

	protected virtual void AANGNFFBNNB()
	{
		if (OnFailStart != null)
		{
			OnFailStart();
		}
	}

	public virtual void EGIBBBDHEGC()
	{
		complete = true;
		if (OnActionComplete != null)
		{
			OnActionComplete();
		}
	}

	public virtual void JMNPGLILNDN()
	{
		complete = false;
		if (OnActionComplete != null)
		{
			OnActionComplete();
		}
	}

	public virtual void JKGGEMBAPAJ()
	{
		canceled = true;
	}

	public virtual bool GOACFCOOJLK(bool OEBNHGNJEJL = false)
	{
		EGIBBBDHEGC();
		return false;
	}

	public virtual void FIOIDMJCAKH()
	{
		complete = false;
		if (OnActionComplete != null)
		{
			OnActionComplete();
		}
	}

	public virtual void PEHELKCIECB()
	{
	}

	public virtual bool IIMEFNIECLI(bool OEBNHGNJEJL = false)
	{
		EGIBBBDHEGC();
		return true;
	}

	protected virtual void IALPAKDIDKG()
	{
		if (OnFailStart != null)
		{
			OnFailStart();
		}
	}

	protected virtual void BDKBIAPEJAA()
	{
		if (OnFailStart != null)
		{
			OnFailStart();
		}
	}
}
