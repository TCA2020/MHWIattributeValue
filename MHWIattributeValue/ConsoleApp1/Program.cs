﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) {
            int cal, Rcal, Acal, TRcal, TAcal, con = 0;
            if (typejud()) {
                int bulletM = dragonbullte();
                int bulletA = bulletM;
                cal = AVcalS(bulletM, out bulletA, 0, ref con);
                Rcal = RedAVcal(bulletM, out bulletA, 0, ref con);
                TRcal = TRedAVcal(bulletM, out bulletA, 0, ref con);
                Acal = AccelAVcal(bulletM, out bulletA,0, ref con);
                TAcal = TAccelAVcal(bulletM, out bulletA,0, ref con);
            } else {
                int ravM = ReadAV();
                int ravA = ravM;
                cal = AVcalS(ravM, out ravA, 1, ref con);
                Rcal = RedAVcal(ravM, out ravA, 1, ref con);
                TRcal = TRedAVcal(ravM, out ravA, 1, ref con);
                Acal = AccelAVcal(ravM, out ravA,1, ref con);
                TAcal = TAccelAVcal(ravM, out ravA,1, ref con);
            }
        }

        static bool typejud() {
            string wtype;
            int type = 0, tf = 0;
            bool a = true;
            Console.WriteLine("武器はボウガンですか？ボウガンならば1をそれ以外ならば1以外の数字を入力してください");
            while (tf == 0) {
                wtype = (Console.ReadLine());
                bool parseOK = int.TryParse(wtype, out type);
                if (parseOK) {
                    Console.WriteLine("パース成功:" + parseOK + type);
                    tf = 1;
                } else {
                    Console.WriteLine("数値を入力してください。");
                }
                if (type == 1) {
                    a = true;
                } else {
                    a = false;
                }
            }
            return a;
        }
        static int dragonbullte() {
            string btype;
            int type = 0, tf = 0, bt = 0;
            Console.WriteLine("弾種類が滅榴弾ならば1をそれ以外ならば1以外の数字を入力してください");
            while (tf == 0)
            {
                btype = (Console.ReadLine());
                bool parseOK = int.TryParse(btype, out type);
                if (parseOK) {
                    Console.WriteLine("パース成功:" + parseOK + type);
                    tf = 1;
                } else {
                    Console.WriteLine("数値を入力してください。");
                }
                if (type == 1) {
                    bt = 180;
                } else {
                    bt = 220;
                }
            }
            return bt;
        }
        static int ReadAV() {
            string AtVl;
            int av = 0, tf = 0;
            Console.WriteLine("武器の属性値を入力してください");
            while (tf == 0) {
                AtVl = (Console.ReadLine());
                bool parseOK = int.TryParse(AtVl, out av);
                if (parseOK) {
                    Console.WriteLine("パース成功:" + parseOK + av);
                    tf = 1;
                } else {
                    Console.WriteLine("数値を入力してください。");
                }
            }
            return av;
        }
        static int AVcalS(int avc, out int avcA, int a, ref int count) {
            double avcD = avc;
            avcA = avc;
            if (a == 1) {
                if (avc <= 250) {
                    avcD += 150;
                } else {
                    avcD = avcD * 1.6;
                }
            } else {
                avcD = avcD * 1.6;
            }
            avcD = Math.Round(avcD, MidpointRounding.AwayFromZero);
            avc = (int)avcD;
            count = 0;
            Console.WriteLine(avc  +" "+ avcA +" "+ a +" "+ count +" "+ avcD);
            Print(avc, avcA, count);
            return avc;
        }
        static int RedAVcal(int Ravc, out int RavcA, int b, ref int count) {
            double avcD = Ravc;
            RavcA = Ravc;
            count = 80;
            if (b == 1) {
                if (Ravc <= 120) {
                    avcD += 150;
                } else {
                    avcD = avcD * 2.2;
                }
                RavcA += count;
            } else {
                avcD = avcD * 1.8;
                RavcA += count;
            }
            avcD = Math.Round(avcD, MidpointRounding.AwayFromZero);
            Ravc = (int)avcD;
            Console.WriteLine(Ravc + " " + RavcA + " " + b + " " + count + " " + avcD);
            Print(Ravc, RavcA, count);
            return Ravc;
        }
        static int TRedAVcal(int TRavc, out int TRavcA, int c, ref int count) {
            double avcD = TRavc;
            TRavcA = TRavc;
            count = 150;
            if (c == 1) {
                if (TRavc <= 90) {
                    avcD += 150;
                } else {
                    avcD = avcD * 2.55;
                }
                TRavcA += count;
            }
            else {
                avcD = avcD * 2.35;
                TRavcA += count;
            }
            avcD = Math.Round(avcD, MidpointRounding.AwayFromZero);
            TRavc = (int)avcD;
            Console.WriteLine(TRavc + " " + TRavcA + " " + c + " " + count + " " + avcD);
            Print(TRavc, TRavcA, count);
            return TRavc;
        }
        static int AccelAVcal(int Aavc, out int AavcA,int d, ref int count) {
            double avcD = Aavc;
            AavcA = Aavc;
            count = 60;
            if (d == 1){
                if (Aavc <= 250){
                    avcD += 150;
                }else{
                    avcD = avcD * 1.6;
                }
            }else{
                avcD = avcD * 1.6;
            }
            avcD = Math.Round(avcD, MidpointRounding.AwayFromZero);
            Aavc = (int)avcD;
            Console.WriteLine(Aavc + " " + AavcA + " " + count + " " + avcD);
            Print(Aavc, AavcA, count);
            return Aavc;
        }
        static int TAccelAVcal(int TAavc, out int TAavcA,int e, ref int count) {
            double avcD = TAavc;
            TAavcA = TAavc;
            count = 150;
            if (e == 1){
                if (TAavc <= 250){
                    avcD += 150;
                }else{
                    avcD = avcD * 1.6;
                }
            }else{
                avcD = avcD * 1.6;
            }
            avcD = Math.Round(avcD, MidpointRounding.AwayFromZero);
            TAavc = (int)avcD;
            Console.WriteLine(TAavc + " " + TAavcA + " " + count + " " + avcD);
            Print(TAavc, TAavcA, count);
            return TAavc;
        }
        static int AVcal(in int AVmax, int AVC, in int con) {
            int cunt = 0;
            double avcD = AVC;
            avcD = Math.Round(avcD, MidpointRounding.AwayFromZero);
            Console.WriteLine("Debug" + AVmax + ":" + AVC + ":" + con + ":"+ cunt);
            while ((int)avcD <= AVmax){
                switch (cunt) {
                    case 0:
                        avcD = AVC + 0;
                        break;
                    case 1:
                        avcD = AVC + 30;
                        break;
                    case 2:
                        avcD = AVC + 60;
                        break;
                    case 3:
                        avcD = AVC + 100;
                        break;
                    case 4:
                        AVC = (int)avcD;
                        avcD = (int)AVC * 1.05 + 100;
                        break;
                    case 5:
                        AVC = (int)avcD;
                        avcD = (int)AVC * 1.1 + 100;
                        break;
                    case 6:
                        AVC = (int)avcD;
                        avcD = (int)AVC * 1.2 + 100;
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
                cunt++;
                Console.WriteLine("Debug" + AVmax + ":" + AVC + ":" + con + ":" + cunt);
            }
        return cunt;
        }
        static void Print(in int AVmax,in int AVC,in int con){
            int x = AVcal(AVmax, AVC, con);
            Console.WriteLine("属性最大値:" + AVmax );
            if (x <= 6){
                Console.WriteLine("属性強化は" + x + "Lvで上限を超えます" + "\n");
            }else{
                Console.WriteLine("属性強化6Lv積んでも上限値は超えません" + "\n");
            }
        }
    }
}
