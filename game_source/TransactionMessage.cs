using System;
using UnityEngine;

[Serializable]
public class TransactionMessage : IOnlineSerializable
{
	public short playerNum = 1;

	public FoodInstanceMessage itemInstanceOnline;

	public bool player = true;

	public byte workerType;

	public TransactionMessage(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool NLCDDFDGACP, Employee IDALLKFAMOH)
	{
		playerNum = (short)JIIGOACEIKL;
		itemInstanceOnline = new FoodInstanceMessage(DNLMCHDOMOK as FoodInstance);
		player = NLCDDFDGACP;
		if ((Object)(object)IDALLKFAMOH != (Object)null)
		{
			workerType = (byte)IDALLKFAMOH.JFCLIAFAOEK.workerType;
		}
		else
		{
			workerType = byte.MaxValue;
		}
	}
}
