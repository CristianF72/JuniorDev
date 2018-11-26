using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //Week 45: Proxy Design Pattern example
        //https://refactoring.guru/design-patterns/proxy/
        private void ProxyDesignExampleButton(object sender, EventArgs e)
        {
            Client client = new Client();
            Console.WriteLine("Client: Executing the client code with a real subject:");

            RealSubject realSubject = new RealSubject();

            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");

            Proxy proxy = new Proxy();

            client.ClientCode(proxy);
        }

        public class Client
        {
            public void ClientCode(Subject subject)
            {
                subject.Request();
            }
        }

        public abstract class Subject
        {
            public abstract void Request();
        }

        class RealSubject : Subject
        {
            public override void Request()
            {
                Console.WriteLine("RealSubject: Handling Request.");
            }
        }

        class Proxy : Subject
        {
            RealSubject realSubject;

            public override void Request()
            {
                if (this.checkAccess())
                {
                    realSubject = new RealSubject();
                    realSubject.Request();

                    this.logAccess();
                }

            }

            public bool checkAccess()
            {
                Console.WriteLine("Proxy: Checking access prior to firing a real request.");

                return true;
            }

            public void logAccess()
            {
                Console.WriteLine("Proxy: Logging the time of request.");
            }
        }
    }
}
