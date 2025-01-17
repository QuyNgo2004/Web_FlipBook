using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BatLoi
    {
        public BUS_BatLoi() { }
        public bool KT_Null( string  chuoi)
        {
            bool flag = false;
            if (chuoi == string.Empty)
            {
                flag = true;
            }
            return flag;
        }
        public bool KT_ChuoiSo(string chuoi)
        {
            bool flag = false;
            Regex regex = new Regex(@"^[0-9]*?[0-9]+$");
            if (regex.IsMatch(chuoi) == true)
            {
                flag = true;
            }
            return flag;
        }
        public bool KT_ChuoiSoDT(string chuoi)
        {
            bool flag = false;
            Regex regex = new Regex(@"^0+[0-9]+$");
            if (regex.IsMatch(chuoi) == true)
            {
                flag = true;
            }
            return flag;
        }
        public static string RemoveUnicode(string text)  
           {  
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",  
            "đ",  
            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",  
            "í","ì","ỉ","ĩ","ị",  
            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",  
            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",  
            "ý","ỳ","ỷ","ỹ","ỵ",};  
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",  
            "d",  
            "e","e","e","e","e","e","e","e","e","e","e",  
            "i","i","i","i","i",  
            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",  
            "u","u","u","u","u","u","u","u","u","u","u",  
            "y","y","y","y","y",};  
            for (int i = 0; i < arr1.Length; i++)  
            {  
                text = text.Replace(arr1[i], arr2[i]);  
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());  
            }  
            return text;  
        }
        public bool KT_ChuoiKiTu(string chuoi)
        {
            bool flag = false;
            Regex regex = new Regex(@"^(([A-Z]{1}([a-z]?)+)\s{1})+([A-Z]{1}([a-z]?)+)$");
            if (regex.IsMatch(RemoveUnicode(chuoi)) == true)
            {
                flag = true;
            }
            return flag;
        }
        public bool KT_SoKiTu<T>( T chuoi , int SoTD /* Số tối đa */ )
        {
            bool flag = false;
            int lenght = chuoi.ToString().Length;
            if (lenght == SoTD) { 
                flag = true;
            }
            return flag;
        }
        public bool KT_SoKiTuCoTheLuu<T>(T chuoi, int SoTD /* Số tối đa */ )
        {
            bool flag = false;
            int lenght = chuoi.ToString().Length;
            if (lenght <= SoTD)
            {
                flag = true;
            }
            return flag;
        }
        public bool KT_Email ( string chuoi)
        {
            bool flag = false;
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(strRegex);
            if (regex.IsMatch(chuoi) == true)
            {
                flag = true;
            }
            return flag;
        }
        public bool KT_SoLonBe(int so, int soDo)
        {
            bool flag = false;
            if(so >=0 && so < soDo)
            {
                flag = true;
            }
            return flag;
        }
    }
}
