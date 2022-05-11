using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Encodings;

/*https://supportcenter.checkpoint.com/supportcenter/portal?eventSubmit_doGoviewsolutiondetails=&solutionid=sk95447
 * <00000000, c0a802fe, 00000000, c0a80232, 00000000, 0000002f; 00010001, 40004080, 00000100, 00000392, 00000000, 62342bed, 0000000d, 9014db74, d49d6f7a, 00000025, 00000025, 00000015, ffffffff, 00000800, 08000000, 00000000, 00000000, 00000000, 72c59bc8, ffffc900, 00000000, a647e002, 00000000, 00000000, 00000000, 00000000, 00000000, 00000000, 00000000, 00000000, 00000000, 00000000, 00000000, 00000000; 458/605>
*/

namespace FWTABdecoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string IPDEC = txtIP.Text.ToString();
            string HEX = "";
            List<string> list = new List<string>();
            list = IPDEC.Split('.').ToList();
            foreach (var l in list)
            {
                int number = Int16.Parse(l);
                if(number <10)
                {
                    HEX += "0";
                }

                HEX +=number.ToString("X");
                
            }
         
            txtCMD.Text = "fw tab -t connections -u | grep " + HEX.ToString().ToLower();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGetInfo2_Click(object sender, EventArgs e)
        {
            string fwtab = txtTAB.Text.ToString();
            string fwtabt = fwtab.Trim(new char[] {'<','>', '\u2063' });

            string[] splitfwtab = fwtabt.Split(new char[] { ',',';'});
        

            if(splitfwtab[0]== "00000000")
            {
                txtDirection.Text = "inbound";
            }
            else
            {
                txtDirection.Text = "outbound";
            }

            //txtSRC.Text = BitConverter.ToString(System.Text.Encoding.UTF8.GetBytes(HEXIPtoDECIP(splitfwtab[1])));
    
            txtSRC.Text= HEXIPtoDECIP(splitfwtab[1]);
            txtSRCPORT.Text= int.Parse(splitfwtab[2], System.Globalization.NumberStyles.HexNumber).ToString();
            txtDST.Text = HEXIPtoDECIP(splitfwtab[3]);
            txtDSTPORT.Text = int.Parse(splitfwtab[4], System.Globalization.NumberStyles.HexNumber).ToString();
            txtPROTO.Text = getProto(splitfwtab[5]);

            txtRULE.Text = int.Parse(splitfwtab[8], System.Globalization.NumberStyles.HexNumber).ToString();
            ///DateTime tijd = new DateTime(1970, 1, 1, 0, 0, 0).AddMilliseconds(Convert.ToDouble(int.Parse(splitfwtab[11], System.Globalization.NumberStyles.HexNumber)));
            //txtSESSION.Text = tijd.ToString("dd/MM/yyyy HH:mm:ss");

            DateTimeOffset datetimeoffset = DateTimeOffset.FromUnixTimeSeconds(int.Parse(splitfwtab[11], System.Globalization.NumberStyles.HexNumber));
            DateTime tijd = datetimeoffset.DateTime;
            txtSESSION.Text = tijd.ToString("dd/MM/yyyy HH:mm:ss");


            txtKill.Text = "fw tab -t connections -x -e \"" + splitfwtab[0] + "," + splitfwtab[1].Substring(1, (splitfwtab[1].Length) - 1) + "," + splitfwtab[2].Substring(1, (splitfwtab[2].Length) - 1) + "," + splitfwtab[3].Substring(1, (splitfwtab[3].Length) - 1) + "," + splitfwtab[4].Substring(1, (splitfwtab[4].Length) - 1) + "," + splitfwtab[5].Substring(1, (splitfwtab[5].Length) - 1) + "\""  ;


        }

        private string getProto(string HEX)
        {
            HEX = HEX.Substring(1, (HEX.Length) - 1);
            string proto = "";
            int protnr = int.Parse(HEX, System.Globalization.NumberStyles.HexNumber);

            switch (protnr)
            {
                case 1:
                    proto = "ICMP";
                    break;
                case 2:
                    proto = "IGMP";
                    break;
                case 6:
                    proto = "TCP";
                    break;
                case 17:
                    proto = "UDP";
                    break;
                case 41:
                    proto = "IPv6";
                    break;
                case 43:
                    proto = "IPv6-Route";
                    break;
                case 44:
                    proto = "IPv6-Frag";
                    break;
                case 47:
                    proto = "GRE";
                    break;
                case 50:
                    proto = "ESP";
                    break;
                case 88:
                    proto = "EIGRP";
                    break;
                case 89:
                    proto = "OSPF";
                    break;
                case 97:
                    proto = "ETHER-IP";
                    break;
                case 115:
                    proto = "L2TP";
                    break;

                default:
                    proto = "IP PROTO NR:" + protnr;
                    break;
            }

            return proto;
        }

        private string HEXIPtoDECIP(string HEX)
        {
            HEX = HEX.Substring(1, (HEX.Length) - 1);
            string HEXoc1 = HEX.Substring(0, 2);
            string HEXoc2 = HEX.Substring(2, 2);
            string HEXoc3 = HEX.Substring(4, 2);
            string HEXoc4 = HEX.Substring(6, 2);
            int decip1 = int.Parse(HEXoc1, System.Globalization.NumberStyles.HexNumber);
            int decip2 = int.Parse(HEXoc2, System.Globalization.NumberStyles.HexNumber);
            int decip3 = int.Parse(HEXoc3, System.Globalization.NumberStyles.HexNumber);
            int decip4 = int.Parse(HEXoc4, System.Globalization.NumberStyles.HexNumber);

            string decip = decip1 + "." + decip2 + "." + decip3 + "." + decip4;

            return decip;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
