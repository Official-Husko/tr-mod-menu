using System;
using System.Collections.Generic;

[Serializable]
public class LettersMessage : LoadMessageBase
{
	public OnlineLettersInfo[] onlineLettersInfo;

	public override void OEJJGDMKIDN()
	{
		if (onlineLettersInfo != null)
		{
			LettersManager.instance.lettersSaved = new List<PostBox.LetterSaveData>();
			for (int i = 0; i < onlineLettersInfo.Length; i++)
			{
				PostBox.LetterSaveData item = new PostBox.LetterSaveData(onlineLettersInfo[i].letterID + 1000, onlineLettersInfo[i].read, onlineLettersInfo[i].receivedDate.JBJLBDHAECK());
				LettersManager.instance.lettersSaved.Add(item);
			}
			LettersManager.instance.ShowLetterIconIfAnyLetterUnread();
		}
	}

	public LettersMessage(PostBox.LetterSaveData[] HBNEBFKKKNE)
	{
		if (HBNEBFKKKNE != null)
		{
			onlineLettersInfo = new OnlineLettersInfo[HBNEBFKKKNE.Length];
			for (int i = 0; i < HBNEBFKKKNE.Length; i++)
			{
				onlineLettersInfo[i] = new OnlineLettersInfo((short)(HBNEBFKKKNE[i].letterID - 1000), HBNEBFKKKNE[i].read, new GameDateMessage(HBNEBFKKKNE[i].receivedDate));
			}
		}
	}
}
