using System;

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
                Acal = AccelAVcal(bulletM, out bulletA, ref con);
                TAcal = TAccelAVcal(bulletM, out bulletA, ref con);
            } else {
                int ravM = ReadAV();
                int ravA = ravM;
                cal = AVcalS(ravM, out ravA, 1, ref con);
                Rcal = RedAVcal(ravM, out ravA, 1, ref con);
                TRcal = TRedAVcal(ravM, out ravA, 1, ref con);
                Acal = AccelAVcal(ravM, out ravA, ref con);
                TAcal = TAccelAVcal(ravM, out ravA, ref con);
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
            count++;
            Console.WriteLine(avc  +" "+ avcA +" "+ a +" "+ count +" "+ avcD);
            return avc;
        }
        static int RedAVcal(int Ravc, out int RavcA, int b, ref int count) {
            double avcD = Ravc;
            RavcA = Ravc;
            if (b == 1) {
                if (Ravc <= 120) {
                    avcD += 150;
                } else {
                    avcD = avcD * 2.2;
                }
                RavcA += 80;
            } else {
                avcD = avcD * 1.8;
                RavcA += 80;
            }
            avcD = Math.Round(avcD, MidpointRounding.AwayFromZero);
            Ravc = (int)avcD;
            count++;
            Console.WriteLine(Ravc + " " + RavcA + " " + b + " " + count + " " + avcD);
            return Ravc;
        }
        static int TRedAVcal(int TRavc, out int TRavcA, int c, ref int count) {
            double avcD = TRavc;
            TRavcA = TRavc;
            if (c == 1) {
                if (TRavc <= 90) {
                    avcD += 150;
                } else {
                    avcD = avcD * 2.55;
                }
                TRavcA += 150;
            }
            else {
                avcD = avcD * 2.35;
                TRavcA += 150;
            }
            avcD = Math.Round(avcD, MidpointRounding.AwayFromZero);
            TRavc = (int)avcD;
            count++;
            Console.WriteLine(TRavc + " " + TRavcA + " " + c + " " + count + " " + avcD);
            return TRavc;
        }
        static int AccelAVcal(int Aavc, out int AavcA, ref int count) {
            double avcD = Aavc;
            AavcA = Aavc;
            AavcA += 60;
            avcD = Math.Round(avcD, MidpointRounding.AwayFromZero);
            Aavc = (int)avcD;
            count++;
            Console.WriteLine(Aavc + " " + AavcA + " " + count + " " + avcD);
            return Aavc;
        }
        static int TAccelAVcal(int TAavc, out int TAavcA, ref int count) {
            double avcD = TAavc;
            TAavcA = TAavc;
            TAavcA += 150;
            avcD = Math.Round(avcD, MidpointRounding.AwayFromZero);
            TAavc = (int)avcD;
            count++;
            Console.WriteLine(TAavc + " " + TAavcA + " " + count + " " + avcD);
            return TAavc;
        }
        static int AVcal(in int AVmax,int AVC,in int con){
            return AVC;
        }
        static void Print(in int AVmax,in int AVC,in int con){

        }
    }
}
