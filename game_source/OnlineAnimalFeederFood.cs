using UnityEngine;

public class OnlineAnimalFeederFood : OnlineObject
{
	public AnimalFeederFood animalFeederFood;

	public void MHEHMOMADGA(short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		animalFeederFood.AnimalFeederSlotPressed(1, animalFeederFood.container.slots[IKMIKEDNCDI], FGFCNKFEIGF);
	}

	public void PMAFEIMBHEC(short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		animalFeederFood.AnimalFeederSlotPressed(0, animalFeederFood.container.slots[IKMIKEDNCDI], FGFCNKFEIGF, GFNHAMCPEAK: false);
	}

	private void FOHGHCPODBJ()
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
		}
	}

	public void CAHLPBBGODA(short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		animalFeederFood.AnimalFeederSlotPressed(1, animalFeederFood.container.slots[IKMIKEDNCDI], FGFCNKFEIGF, GFNHAMCPEAK: false);
	}

	private void KACEOJDPLKB()
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
		}
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		animalFeederFood = ((Component)this).GetComponentInChildren<AnimalFeederFood>();
		if (Object.op_Implicit((Object)(object)animalFeederFood))
		{
			animalFeederFood.onlineAnimalFeederFood = this;
		}
		for (int i = 0; i < animalFeederFood.container.slots.Length; i++)
		{
			animalFeederFood.container.slots[i].onlineObject = this;
		}
	}

	public void LJBLMHOJOCD(short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		animalFeederFood.AnimalFeederSlotPressed(0, animalFeederFood.container.slots[IKMIKEDNCDI], FGFCNKFEIGF);
	}

	public void BNAOECBMNDF(short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		animalFeederFood.AnimalFeederSlotPressed(0, animalFeederFood.container.slots[IKMIKEDNCDI], FGFCNKFEIGF, GFNHAMCPEAK: false);
	}

	public void KAGEDLJBOPC(short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		animalFeederFood.AnimalFeederSlotPressed(1, animalFeederFood.container.slots[IKMIKEDNCDI], FGFCNKFEIGF, GFNHAMCPEAK: false);
	}

	public void FBCEBPGGGHA(short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		animalFeederFood.AnimalFeederSlotPressed(1, animalFeederFood.container.slots[IKMIKEDNCDI], FGFCNKFEIGF, GFNHAMCPEAK: false);
	}

	private void OLDDEAJMHNI()
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
		}
	}

	public void KCDJEGEEHHO(short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		animalFeederFood.AnimalFeederSlotPressed(1, animalFeederFood.container.slots[IKMIKEDNCDI], FGFCNKFEIGF);
	}

	private void KDBJHCAEGCM()
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
		}
	}

	public void FJMFJKHNMID(short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		animalFeederFood.AnimalFeederSlotPressed(1, animalFeederFood.container.slots[IKMIKEDNCDI], FGFCNKFEIGF, GFNHAMCPEAK: false);
	}

	public void BFMFHMOGMKB(short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		animalFeederFood.AnimalFeederSlotPressed(0, animalFeederFood.container.slots[IKMIKEDNCDI], FGFCNKFEIGF);
	}

	public void HCMIDFCAFIC(short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		animalFeederFood.AnimalFeederSlotPressed(0, animalFeederFood.container.slots[IKMIKEDNCDI], FGFCNKFEIGF, GFNHAMCPEAK: false);
	}

	private void KJOJLHCDFPP()
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
		}
	}

	public void OMKJOKONPJO(short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		animalFeederFood.AnimalFeederSlotPressed(1, animalFeederFood.container.slots[IKMIKEDNCDI], FGFCNKFEIGF, GFNHAMCPEAK: false);
	}

	private void OIAHJHNPPCO()
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
		}
	}

	private void LANGHIOBJIH()
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
		}
	}

	private void Start()
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
		}
	}

	private void BELOIFKPNMM()
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
		}
	}

	public void ReceiveAnimalFeederSlotPressed(short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		animalFeederFood.AnimalFeederSlotPressed(1, animalFeederFood.container.slots[IKMIKEDNCDI], FGFCNKFEIGF, GFNHAMCPEAK: false);
	}

	public void EABAMNCLMIB(short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		animalFeederFood.AnimalFeederSlotPressed(0, animalFeederFood.container.slots[IKMIKEDNCDI], FGFCNKFEIGF);
	}

	public void IAHCOHNABAN(short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		animalFeederFood.AnimalFeederSlotPressed(1, animalFeederFood.container.slots[IKMIKEDNCDI], FGFCNKFEIGF);
	}

	private void BNIKICAEIND()
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
		}
	}

	private void MCMKNBIBDFF()
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
		}
	}

	public void AGCBFDBEOBE(short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		animalFeederFood.AnimalFeederSlotPressed(1, animalFeederFood.container.slots[IKMIKEDNCDI], FGFCNKFEIGF);
	}

	public void FPLOJONIAKO(short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		animalFeederFood.AnimalFeederSlotPressed(0, animalFeederFood.container.slots[IKMIKEDNCDI], FGFCNKFEIGF);
	}
}
