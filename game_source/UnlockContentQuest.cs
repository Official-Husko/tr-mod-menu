using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Quest/Unlock Content")]
public class UnlockContentQuest : Quest
{
	public ContentLockID contentLockID;

	public override void MHOGPMHEAFN()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnUnlocked = (Action<int, ContentLockID>)Delegate.Remove(instance.OnUnlocked, new Action<int, ContentLockID>(GKIJKMMJBIL));
		MFHHJFEJAMF();
	}

	private void IOJEENBBBED(int JIIGOACEIKL, ContentLockID BGECNAEAEDE)
	{
		if (BEBKECMKIAC(BGECNAEAEDE))
		{
			PIGBLLFBKHD(JIIGOACEIKL, 0);
		}
	}

	public override void OEICMCIGNKO()
	{
		if (CommonReferences.GGFJGHHHEJC.contentUnlocked.Contains(contentLockID))
		{
			EPIMKBNCFCK(1, 1);
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnUnlocked = (Action<int, ContentLockID>)Delegate.Combine(instance.OnUnlocked, new Action<int, ContentLockID>(GKIJKMMJBIL));
	}

	private bool BEBMBAHBNGC(ContentLockID BGECNAEAEDE)
	{
		return contentLockID == BGECNAEAEDE;
	}

	private bool FENMFGFLDBO(ContentLockID BGECNAEAEDE)
	{
		return contentLockID == BGECNAEAEDE;
	}

	private bool KFKGOHEKDBI(ContentLockID BGECNAEAEDE)
	{
		return contentLockID == BGECNAEAEDE;
	}

	private bool NJMHBGKLNPP(ContentLockID BGECNAEAEDE)
	{
		return contentLockID == BGECNAEAEDE;
	}

	private bool BEBKECMKIAC(ContentLockID BGECNAEAEDE)
	{
		return contentLockID == BGECNAEAEDE;
	}

	private void IAFKLHBPNIB(int JIIGOACEIKL, ContentLockID BGECNAEAEDE)
	{
		if (BEBKECMKIAC(BGECNAEAEDE))
		{
			EPIMKBNCFCK(JIIGOACEIKL, 1);
		}
	}

	private void KHPEEELPOED(int JIIGOACEIKL, ContentLockID BGECNAEAEDE)
	{
		if (NJMHBGKLNPP(BGECNAEAEDE))
		{
			PIGBLLFBKHD(JIIGOACEIKL, 0);
		}
	}

	private void ECBKFHGJJNP(int JIIGOACEIKL, ContentLockID BGECNAEAEDE)
	{
		if (OAAMCHENCHB(BGECNAEAEDE))
		{
			PIGBLLFBKHD(JIIGOACEIKL, 1);
		}
	}

	private bool ADDJDOJMIKE(ContentLockID BGECNAEAEDE)
	{
		return contentLockID == BGECNAEAEDE;
	}

	private void GKIJKMMJBIL(int JIIGOACEIKL, ContentLockID BGECNAEAEDE)
	{
		if (FENMFGFLDBO(BGECNAEAEDE))
		{
			EPIMKBNCFCK(JIIGOACEIKL, 1);
		}
	}

	private void FMHMPOAPMJA(int JIIGOACEIKL, ContentLockID BGECNAEAEDE)
	{
		if (KFKGOHEKDBI(BGECNAEAEDE))
		{
			GKDGCBNNHAD(JIIGOACEIKL, 1);
		}
	}

	private bool OAAMCHENCHB(ContentLockID BGECNAEAEDE)
	{
		return contentLockID == BGECNAEAEDE;
	}
}
