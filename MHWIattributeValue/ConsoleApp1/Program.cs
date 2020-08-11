using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args){
            int cal,Rcal,Acal;
            if (typejud()){
                int bullet = dragonbullte();
                cal = AVcal(bullet,0);
                Rcal = RedAVcal(bullet);
                Acal = AccelAVcal(bullet);
            }else{
                int rav = ReadAV();
                cal = AVcal(rav,1);
                Rcal = RedAVcal(rav);
                Acal = AccelAVcal(rav);
            }
        }

        static bool typejud(){
            string wtype;
            int type = 0, tf = 0;
            bool a = true;
            Console.WriteLine("武器はボウガンですか？ボウガンならば1をそれ以外ならば1以外の数字を入力してください");
            while (tf == 0){
                wtype = (Console.ReadLine());
                bool parseOK = int.TryParse(wtype, out type);
                if (parseOK){
                    Console.WriteLine("パース成功:" + parseOK + type);
                    tf = 1;
                }else{
                    Console.WriteLine("数値を入力してください。");
                }
                if (type == 1){
                    a = true;
                }else{
                    a = false;
                }
            }
            return a;
        }
        static int dragonbullte(){
            string btype;
            int type = 0, tf = 0,bt = 0;
            Console.WriteLine("弾種類は滅榴弾ならば1をそれ以外ならば1以外の数字を入力してください");
            while (tf == 0)
            {
                btype = (Console.ReadLine());
                bool parseOK = int.TryParse(btype, out type);
                if (parseOK){
                    Console.WriteLine("パース成功:" + parseOK + type);
                    tf = 1;
                }else{
                    Console.WriteLine("数値を入力してください。");
                }
                if (type == 1){
                    bt = 180;
                }else{
                    bt = 220;
                }
            }
            return bt;
        }
            static int ReadAV(){
                string AtVl;
                int av = 0, tf = 0;
                Console.WriteLine("武器の属性値を入力してください");
                while (tf == 0){
                    AtVl = (Console.ReadLine());
                    bool parseOK = int.TryParse(AtVl, out av);
                    if (parseOK){
                        Console.WriteLine("パース成功:" + parseOK + av);
                        tf = 1;
                    }else{
                        Console.WriteLine("数値を入力してください。");
                    }
                }
            return av;
        }
        static int AVcal(int avc,int a){
            double avcD = avc;
            if (a == 0) {
                if (avc <= 250) {
                    avcD += 150;
                } else {
                    avcD = avcD * 1.6;
                }
            }else {
                avcD = avcD * 1.6;
            }
            avcD = Math.Round(avcD, MidpointRounding.AwayFromZero);
            avc = (int)avcD;
            return avc;
                ;
        }
        static int RedAVcal(int Ravc){
            return 0;
        }
        static int AccelAVcal(int Aavc){
            return 0;
        }
    }
}
