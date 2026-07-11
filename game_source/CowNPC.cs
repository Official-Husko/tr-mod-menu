public class CowNPC : AnimalNPC
{
	public override bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		DKOMFLMOIJJ(JIIGOACEIKL, IIEDALMMNLI);
		return base.OnHover(JIIGOACEIKL, IIEDALMMNLI);
	}

	public override bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		base.MouseHold(JIIGOACEIKL, KLGOCJMGKFO);
		if (!isSick)
		{
			return DPGJOMBFDHC(JIIGOACEIKL);
		}
		return false;
	}
}
