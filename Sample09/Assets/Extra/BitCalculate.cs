using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitCalculate
{
    public static void Test()
    {
        bool[] data=new bool[]
            {true,false,false,false,true,true,false,false};

        byte packed = PackFlags(data);

        bool flag = GetFlag(packed, 4);
        Debug.Log(flag);
    }

    //flags‚Ì”z—ñ’·‚Í8ˆÈ‰º
    public static byte PackFlags(bool[] flags)
    {
        byte packed = 0;
        for(int i=0;i<flags.Length;i++)
        {
            int flag = flags[i] ? 1 : 0;
            packed |= (byte)(flag << i);
        }
        return packed;
    }

    public static bool GetFlag(byte packed,int index)
    {
        int shifted = 1 << index;
        //index=4‚È‚ç 0b_00010000

        int and = packed & shifted;

        return and == shifted;
    }
}
