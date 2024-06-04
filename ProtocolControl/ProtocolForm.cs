using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtocolControl
{
    public partial class ProtocolForm : Form
    {
        private static readonly object token = new object();
        private static List<Protocol> protocols;

        public ProtocolForm()
        {
            protocols = LoadFile();
            InitializeComponent();
        }

        /* Ao receber id da empresa se gera o protocolo sequencial conforme regra 
        XXXXXX = Número identificador da empresa: 6 dígitos numéricos. Ex: Empresa A = 319708
		AAAAMMDD = Ano, Mês e Dia. Ex: 20230921
		NNNNNN = Número sequencial do protocolo: 6 dígitos numéricos 
        Depois é salvo os protocolos em um arquivo txt para se utilizado os registros nas próximas gerações */
        private void btnGenerateProtocol_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCompany.Text))
            {
                MessageBox.Show("Deve ser informado código identificador da empresa!");
                txtCompany.Focus();
                return;
            }

            //teste
            if (protocols == null) return;

            #region Teste multi processos
            //for (int i = 0; i < 5; i++)
            //{
            //    ThreadStart start = () => ProcessProtocol(txtCompany.Text);
            //    new Thread(start).Start();
            //}
            #endregion

            ProcessProtocol(txtCompany.Text);
        }

        private static void ProcessProtocol(string company)
        {
            lock (token)
            {
                Protocol protocol = protocols.Find(x => x.IdComapany == company) ?? null;

                protocols.Remove(protocol);
                var protocolNew = GenerateProtocol(protocol, company);
                protocols.Add(protocolNew);
                SaveFile(protocols);
            }
        }

        private static Protocol GenerateProtocol(Protocol protocol, string company)
        {
            var dateCurrent = DateTime.Now.ToString("yyyyMMdd");
            var sequenceCurrent = protocol == null || protocol.Date != dateCurrent ? 1 : Convert.ToInt32(protocol.Sequence) + 1;

            return new Protocol { IdComapany = company, Date = dateCurrent, Sequence = sequenceCurrent.ToString("D" + 6) };
        }


        private List<Protocol> LoadFile()
        {
            var pathFile = Path.Combine(Environment.CurrentDirectory, "Protocol.dat");
            if (!File.Exists(pathFile)) return new List<Protocol>();

            var file = File.ReadAllText(pathFile, Encoding.UTF8);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Protocol>>(file);
        }

        public static void SaveFile(List<Protocol> listProtocols)
        {
            var pathFile = Path.Combine(Environment.CurrentDirectory, "Protocol.dat");
            File.WriteAllText(pathFile, Newtonsoft.Json.JsonConvert.SerializeObject(listProtocols.ToArray()));
        }

        private void btnViewProtocols_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in protocols)
            {
                sb.AppendLine(item.ToString());
            }

            MessageBox.Show(sb.ToString(),"Protocolos");
        }
    }

    public class Protocol
    {
        public string IdComapany { get; set; }
        public string Date { get; set; }
        public string Sequence { get; set; }

        public override string ToString()
        {
            return IdComapany + Date + Sequence;
        }
    }
}
