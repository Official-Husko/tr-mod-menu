using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

public class Encryption : MonoBehaviour
{
	private static readonly byte[] INAPMPEEDPO = Encoding.UTF8.GetBytes("16charsecretkey!");

	private static readonly byte[] KOEEMMKCDAH = Encoding.UTF8.GetBytes("16byteivector123");

	public static byte[] AOOHEGMILIC(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
		{
			cryptoStream.Write(OINICMNOLPK, 1, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] AHPCLFGCLBB(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 0, array.Length);
		return array;
	}

	public static byte[] IJDCMGNPPBI(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 0, array.Length);
		return array;
	}

	public static byte[] HEAHMOLPCLM(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 1, array.Length);
		return array;
	}

	public static byte[] PHACGHLAFCN(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 0, array.Length);
		return array;
	}

	public static byte[] PGAIBKKDCFN(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
		{
			cryptoStream.Write(OINICMNOLPK, 1, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] IIDJEJJPKCH(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
		{
			cryptoStream.Write(OINICMNOLPK, 0, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] NMAKCDHIEMK(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 0, array.Length);
		return array;
	}

	public static byte[] DAFDCJMJGNF(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 1, array.Length);
		return array;
	}

	public static byte[] APKPKMOHKHA(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
		{
			cryptoStream.Write(OINICMNOLPK, 0, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] HAMHGJHMIMI(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
		{
			cryptoStream.Write(OINICMNOLPK, 1, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] OFNBGCENIBE(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
		{
			cryptoStream.Write(OINICMNOLPK, 0, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] BAMLIHAALFC(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 1, array.Length);
		return array;
	}

	public static byte[] CEAKCEDBLMD(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
		{
			cryptoStream.Write(OINICMNOLPK, 1, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] IEGOACEFNOB(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
		{
			cryptoStream.Write(OINICMNOLPK, 0, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] FCHDIMADLHD(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
		{
			cryptoStream.Write(OINICMNOLPK, 1, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] FALCOFOGGOB(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 0, array.Length);
		return array;
	}

	public static byte[] BCODNJNPAPF(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
		{
			cryptoStream.Write(OINICMNOLPK, 1, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] DCMOEEGPCDB(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 1, array.Length);
		return array;
	}

	public static byte[] NOGMFENMEOG(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 0, array.Length);
		return array;
	}

	public static byte[] OBFBJKEMAKO(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 1, array.Length);
		return array;
	}

	public static byte[] MONFMONECEO(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 1, array.Length);
		return array;
	}

	public static byte[] Encrypt(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
		{
			cryptoStream.Write(OINICMNOLPK, 0, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] KOGBKMPNDFD(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
		{
			cryptoStream.Write(OINICMNOLPK, 0, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] JGCFLPJNPBP(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
		{
			cryptoStream.Write(OINICMNOLPK, 1, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] BPDHLBFCJHD(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
		{
			cryptoStream.Write(OINICMNOLPK, 0, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] IKIFDPGGOAI(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 0, array.Length);
		return array;
	}

	public static byte[] KKGMCIPNADO(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
		{
			cryptoStream.Write(OINICMNOLPK, 1, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] BFCJGCEAFJA(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
		{
			cryptoStream.Write(OINICMNOLPK, 1, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] KABEJONDGMF(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 0, array.Length);
		return array;
	}

	public static byte[] DGDOLEEJMJL(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
		{
			cryptoStream.Write(OINICMNOLPK, 0, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] OGLHAEGACGF(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 0, array.Length);
		return array;
	}

	public static byte[] JANHFAPENKP(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
		{
			cryptoStream.Write(OINICMNOLPK, 0, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] EAPBAGLMANC(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 0, array.Length);
		return array;
	}

	public static byte[] JKIIJLJBEBO(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 0, array.Length);
		return array;
	}

	public static byte[] GIKBKLNPDPK(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
		{
			cryptoStream.Write(OINICMNOLPK, 0, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] HPMGNDPHIAC(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
		{
			cryptoStream.Write(OINICMNOLPK, 0, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] LCENKFNJGME(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 0, array.Length);
		return array;
	}

	public static byte[] Decrypt(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 0, array.Length);
		return array;
	}

	public static byte[] JEBAAOPECFP(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 1, array.Length);
		return array;
	}

	public static byte[] OICNKDOMIHH(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 1, array.Length);
		return array;
	}

	public static byte[] GLNNBOKGLHF(byte[] OINICMNOLPK)
	{
		using Aes aes = Aes.Create();
		aes.Key = INAPMPEEDPO;
		aes.IV = KOEEMMKCDAH;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		byte[] array = new byte[OINICMNOLPK.Length];
		cryptoStream.Read(array, 0, array.Length);
		return array;
	}
}
