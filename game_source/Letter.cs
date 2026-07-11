using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Letter", menuName = "Game/Letter")]
public class Letter : ScriptableObject
{
	public enum Sender
	{
		Unknown,
		Holly,
		Buzz,
		Amos,
		Bob,
		Petra,
		Hallmund,
		Agatha,
		Hikari,
		Wilson,
		Woody,
		Chuck,
		Rhia,
		Lia,
		Kujaku,
		Crowly,
		RiliaCC
	}

	[Serializable]
	public struct OrderItem
	{
		public Item item;

		public Sprite itemSprite;
	}

	public int letterID;

	public Sender sender;

	public string unknownSenderName = "";

	public bool localisedUnknownSenderName;

	public bool signOffDifferentFromName;

	public Sprite portrait;

	public string subjectText;

	[TextArea(3, 10)]
	public string letterText;

	public bool isOrder;

	public OrderItem[] orderItems;
}
