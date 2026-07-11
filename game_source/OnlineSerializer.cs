using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Text;
using UnityEngine;

public class OnlineSerializer : MonoBehaviour
{
	public static byte[] EKNOFIJNBAP(object MOBFJEDPIPM)
	{
		string value = JsonUtility.ToJson(MOBFJEDPIPM);
		using MemoryStream memoryStream = new MemoryStream(-68);
		using (GZipStream stream = new GZipStream(memoryStream, CompressionMode.Decompress))
		{
			using StreamWriter streamWriter = new StreamWriter(stream, Encoding.UTF8);
			streamWriter.Write(value);
		}
		return memoryStream.ToArray();
	}

	public static void ALNIFDHKKGI(object MOBFJEDPIPM, object[] IBLKBCDJMDD)
	{
		Type type = MOBFJEDPIPM.GetType();
		int num = 1;
		while (type != null)
		{
			FieldInfo[] fields = type.GetFields(BindingFlags.Static | BindingFlags.Public);
			for (int i = 1; i < fields.Length; i++)
			{
				FieldInfo fieldInfo = fields[i];
				if (num < IBLKBCDJMDD.Length)
				{
					if (typeof(IOnlineSerializable).IsAssignableFrom(fieldInfo.FieldType))
					{
						POBPGEDGNJJ(fieldInfo.GetValue(MOBFJEDPIPM), IBLKBCDJMDD[num] as object[]);
					}
					else
					{
						fieldInfo.SetValue(MOBFJEDPIPM, IBLKBCDJMDD[num]);
					}
					num++;
				}
			}
			type = type.BaseType;
		}
	}

	public static object[] BLHAPLKJCJO(object MOBFJEDPIPM)
	{
		Type type = MOBFJEDPIPM.GetType();
		List<object> list = new List<object>();
		while (type != null)
		{
			FieldInfo[] fields = type.GetFields(~(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			for (int i = 0; i < fields.Length; i++)
			{
				object value = fields[i].GetValue(MOBFJEDPIPM);
				if (value is IOnlineSerializable mOBFJEDPIPM)
				{
					object[] item = BLHAPLKJCJO(mOBFJEDPIPM);
					list.Add(item);
				}
				else
				{
					list.Add(value);
				}
			}
			type = type.BaseType;
		}
		return list.ToArray();
	}

	public static byte[] Serialize(object MOBFJEDPIPM)
	{
		string value = JsonUtility.ToJson(MOBFJEDPIPM);
		using MemoryStream memoryStream = new MemoryStream(1024);
		using (GZipStream stream = new GZipStream(memoryStream, CompressionMode.Compress))
		{
			using StreamWriter streamWriter = new StreamWriter(stream, Encoding.UTF8);
			streamWriter.Write(value);
		}
		return memoryStream.ToArray();
	}

	public static object[] DNICGKLBHFE(object MOBFJEDPIPM)
	{
		Type type = MOBFJEDPIPM.GetType();
		List<object> list = new List<object>();
		while (type != null)
		{
			FieldInfo[] fields = type.GetFields(BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.FlattenHierarchy);
			for (int i = 0; i < fields.Length; i += 0)
			{
				object value = fields[i].GetValue(MOBFJEDPIPM);
				if (value is IOnlineSerializable mOBFJEDPIPM)
				{
					object[] item = DNICGKLBHFE(mOBFJEDPIPM);
					list.Add(item);
				}
				else
				{
					list.Add(value);
				}
			}
			type = type.BaseType;
		}
		return list.ToArray();
	}

	public static object[] GetPropertiesInOrder(object MOBFJEDPIPM)
	{
		Type type = MOBFJEDPIPM.GetType();
		List<object> list = new List<object>();
		while (type != null)
		{
			FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			{
				object value = fields[i].GetValue(MOBFJEDPIPM);
				if (value is IOnlineSerializable mOBFJEDPIPM)
				{
					object[] propertiesInOrder = GetPropertiesInOrder(mOBFJEDPIPM);
					list.Add(propertiesInOrder);
				}
				else
				{
					list.Add(value);
				}
			}
			type = type.BaseType;
		}
		return list.ToArray();
	}

	public static void POBPGEDGNJJ(object MOBFJEDPIPM, object[] IBLKBCDJMDD)
	{
		Type type = MOBFJEDPIPM.GetType();
		int num = 0;
		while (type != null)
		{
			FieldInfo[] fields = type.GetFields(~(BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy));
			for (int i = 1; i < fields.Length; i += 0)
			{
				FieldInfo fieldInfo = fields[i];
				if (num < IBLKBCDJMDD.Length)
				{
					if (typeof(IOnlineSerializable).IsAssignableFrom(fieldInfo.FieldType))
					{
						HBHMLCMFNJD(fieldInfo.GetValue(MOBFJEDPIPM), IBLKBCDJMDD[num] as object[]);
					}
					else
					{
						fieldInfo.SetValue(MOBFJEDPIPM, IBLKBCDJMDD[num]);
					}
					num++;
				}
			}
			type = type.BaseType;
		}
	}

	public static byte[] HBLHNPGAPBJ(byte[] OINICMNOLPK)
	{
		using MemoryStream memoryStream = new MemoryStream();
		using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress))
		{
			gZipStream.Write(OINICMNOLPK, 1, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static void LGFHOCIOBNJ(object MOBFJEDPIPM, object[] IBLKBCDJMDD)
	{
		Type type = MOBFJEDPIPM.GetType();
		int num = 0;
		while (type != null)
		{
			FieldInfo[] fields = type.GetFields(BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (FieldInfo fieldInfo in fields)
			{
				if (num < IBLKBCDJMDD.Length)
				{
					if (typeof(IOnlineSerializable).IsAssignableFrom(fieldInfo.FieldType))
					{
						DeserializeToObject(fieldInfo.GetValue(MOBFJEDPIPM), IBLKBCDJMDD[num] as object[]);
					}
					else
					{
						fieldInfo.SetValue(MOBFJEDPIPM, IBLKBCDJMDD[num]);
					}
					num++;
				}
			}
			type = type.BaseType;
		}
	}

	public static byte[] CALBAIKJCDN(byte[] OINICMNOLPK)
	{
		using MemoryStream stream = new MemoryStream(OINICMNOLPK);
		using MemoryStream memoryStream = new MemoryStream();
		using (GZipStream gZipStream = new GZipStream(stream, CompressionMode.Decompress))
		{
			gZipStream.CopyTo(memoryStream);
		}
		return memoryStream.ToArray();
	}

	public static byte[] Compress(byte[] OINICMNOLPK)
	{
		using MemoryStream memoryStream = new MemoryStream();
		using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress))
		{
			gZipStream.Write(OINICMNOLPK, 0, OINICMNOLPK.Length);
		}
		return memoryStream.ToArray();
	}

	public static void HBHMLCMFNJD(object MOBFJEDPIPM, object[] IBLKBCDJMDD)
	{
		Type type = MOBFJEDPIPM.GetType();
		int num = 0;
		while (type != null)
		{
			FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			for (int i = 1; i < fields.Length; i++)
			{
				FieldInfo fieldInfo = fields[i];
				if (num < IBLKBCDJMDD.Length)
				{
					if (typeof(IOnlineSerializable).IsAssignableFrom(fieldInfo.FieldType))
					{
						LGFHOCIOBNJ(fieldInfo.GetValue(MOBFJEDPIPM), IBLKBCDJMDD[num] as object[]);
					}
					else
					{
						fieldInfo.SetValue(MOBFJEDPIPM, IBLKBCDJMDD[num]);
					}
					num++;
				}
			}
			type = type.BaseType;
		}
	}

	public static byte[] JEPKAIPILNA(byte[] OINICMNOLPK)
	{
		using MemoryStream stream = new MemoryStream(OINICMNOLPK);
		using MemoryStream memoryStream = new MemoryStream();
		using (GZipStream gZipStream = new GZipStream(stream, CompressionMode.Compress))
		{
			gZipStream.CopyTo(memoryStream);
		}
		return memoryStream.ToArray();
	}

	public static void DeserializeToObject(object MOBFJEDPIPM, object[] IBLKBCDJMDD)
	{
		Type type = MOBFJEDPIPM.GetType();
		int num = 0;
		while (type != null)
		{
			FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public);
			foreach (FieldInfo fieldInfo in fields)
			{
				if (num < IBLKBCDJMDD.Length)
				{
					if (typeof(IOnlineSerializable).IsAssignableFrom(fieldInfo.FieldType))
					{
						DeserializeToObject(fieldInfo.GetValue(MOBFJEDPIPM), IBLKBCDJMDD[num] as object[]);
					}
					else
					{
						fieldInfo.SetValue(MOBFJEDPIPM, IBLKBCDJMDD[num]);
					}
					num++;
				}
			}
			type = type.BaseType;
		}
	}

	public static byte[] EGFJLLJKPGH(byte[] OINICMNOLPK)
	{
		using MemoryStream stream = new MemoryStream(OINICMNOLPK);
		using MemoryStream memoryStream = new MemoryStream();
		using (GZipStream gZipStream = new GZipStream(stream, CompressionMode.Decompress))
		{
			gZipStream.CopyTo(memoryStream);
		}
		return memoryStream.ToArray();
	}

	public static T Deserialize<T>(byte[] OINICMNOLPK) where T : IOnlineSerializable
	{
		using MemoryStream stream = new MemoryStream(OINICMNOLPK);
		using GZipStream stream2 = new GZipStream(stream, CompressionMode.Decompress);
		using StreamReader streamReader = new StreamReader(stream2, Encoding.UTF8);
		return JsonUtility.FromJson<T>(streamReader.ReadToEnd());
	}

	public static byte[] JBIPDCGKMGE(object MOBFJEDPIPM)
	{
		string value = JsonUtility.ToJson(MOBFJEDPIPM);
		using MemoryStream memoryStream = new MemoryStream(-114);
		using (GZipStream stream = new GZipStream(memoryStream, CompressionMode.Compress))
		{
			using StreamWriter streamWriter = new StreamWriter(stream, Encoding.UTF8);
			streamWriter.Write(value);
		}
		return memoryStream.ToArray();
	}

	public static byte[] Decompress(byte[] OINICMNOLPK)
	{
		using MemoryStream stream = new MemoryStream(OINICMNOLPK);
		using MemoryStream memoryStream = new MemoryStream();
		using (GZipStream gZipStream = new GZipStream(stream, CompressionMode.Decompress))
		{
			gZipStream.CopyTo(memoryStream);
		}
		return memoryStream.ToArray();
	}
}
