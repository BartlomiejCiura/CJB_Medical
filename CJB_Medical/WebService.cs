using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CJB_Medical
{
    class WebService
    {
        static BasicHttpBinding binding = null;
        static EndpointAddress endpoint = null;
        public static ServiceReference.WebServiceSoapClient service = null;

        static WebService()
        {
            ServiceReference.WebServiceSoapClient r = new ServiceReference.WebServiceSoapClient();

            binding = new BasicHttpBinding();
            binding.MaxBufferSize = 2147483647;
            binding.MaxReceivedMessageSize = 2147483647;
            binding.ReaderQuotas.MaxDepth = 2147483647;
            binding.ReaderQuotas.MaxStringContentLength = 2147483647;
            binding.ReaderQuotas.MaxArrayLength = 2147483647;
            binding.ReaderQuotas.MaxBytesPerRead = 2147483647;
            binding.ReaderQuotas.MaxNameTableCharCount = 2147483647;

            int timeOutSeconds = 10;

            binding.SendTimeout = new TimeSpan(0, 0, timeOutSeconds);
            binding.OpenTimeout = new TimeSpan(0, 0, timeOutSeconds);
            binding.ReceiveTimeout = new TimeSpan(0, 0, timeOutSeconds);

            endpoint = new EndpointAddress(new Uri("http://cjbmedical.somee.com/webservice.asmx?WSDL"));

            try
            {
                service = new ServiceReference.WebServiceSoapClient(binding, endpoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
