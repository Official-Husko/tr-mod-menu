using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Quest/Action Done")]
public class ActionDoneQuest : Quest
{
	public ActionDone action;

	private void EKPOLONBLKE(int JIIGOACEIKL, ActionDone ALPPHCBBBIJ)
	{
		if (ALPPHCBBBIJ == action)
		{
			PIGBLLFBKHD(JIIGOACEIKL, 1);
		}
	}

	public override void OEICMCIGNKO()
	{
		if (id != 0)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnActionDone = (Action<int, ActionDone>)Delegate.Combine(instance.OnActionDone, new Action<int, ActionDone>(ACEOCGFEPMO));
		}
	}

	private void CKEAJMCKLDL(int JIIGOACEIKL, ActionDone ALPPHCBBBIJ)
	{
		if (ALPPHCBBBIJ == action)
		{
			EPIMKBNCFCK(JIIGOACEIKL, 1);
		}
	}

	private void KLJKFGHFKLI(int JIIGOACEIKL, ActionDone ALPPHCBBBIJ)
	{
		if (ALPPHCBBBIJ == action)
		{
			EPIMKBNCFCK(JIIGOACEIKL, 1);
		}
	}

	private void JIKBAHHMCOC(int JIIGOACEIKL, ActionDone ALPPHCBBBIJ)
	{
		if (ALPPHCBBBIJ == action)
		{
			PIGBLLFBKHD(JIIGOACEIKL, 0);
		}
	}

	private void JCOMFCLLOKG(int JIIGOACEIKL, ActionDone ALPPHCBBBIJ)
	{
		if (ALPPHCBBBIJ == action)
		{
			PIGBLLFBKHD(JIIGOACEIKL, 0);
		}
	}

	private void ANAHLDAIDLN(int JIIGOACEIKL, ActionDone ALPPHCBBBIJ)
	{
		if (ALPPHCBBBIJ == action)
		{
			EPIMKBNCFCK(JIIGOACEIKL, 0);
		}
	}

	private void ACEOCGFEPMO(int JIIGOACEIKL, ActionDone ALPPHCBBBIJ)
	{
		if (ALPPHCBBBIJ == action)
		{
			EPIMKBNCFCK(JIIGOACEIKL, 1);
		}
	}

	private void EMFJKKJMMGK(int JIIGOACEIKL, ActionDone ALPPHCBBBIJ)
	{
		if (ALPPHCBBBIJ == action)
		{
			GKDGCBNNHAD(JIIGOACEIKL, 0);
		}
	}

	private void JJMDKHGLLKK(int JIIGOACEIKL, ActionDone ALPPHCBBBIJ)
	{
		if (ALPPHCBBBIJ == action)
		{
			EPIMKBNCFCK(JIIGOACEIKL, 1);
		}
	}

	private void AHDFNBDMIFE(int JIIGOACEIKL, ActionDone ALPPHCBBBIJ)
	{
		if (ALPPHCBBBIJ == action)
		{
			GKDGCBNNHAD(JIIGOACEIKL, 1);
		}
	}

	private void NOMDHEAJCJG(int JIIGOACEIKL, ActionDone ALPPHCBBBIJ)
	{
		if (ALPPHCBBBIJ == action)
		{
			GKDGCBNNHAD(JIIGOACEIKL, 0);
		}
	}

	private void BJEPJNPCMHA(int JIIGOACEIKL, ActionDone ALPPHCBBBIJ)
	{
		if (ALPPHCBBBIJ == action)
		{
			EPIMKBNCFCK(JIIGOACEIKL, 0);
		}
	}

	public override void MHOGPMHEAFN()
	{
		if (id != 0)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(ACEOCGFEPMO));
		}
		MFHHJFEJAMF();
	}
}
