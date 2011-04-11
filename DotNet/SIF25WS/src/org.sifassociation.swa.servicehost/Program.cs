
/*
 * Copyright © 2011 Pearson Education, Inc. or its affiliate(s).  All rights reserved.
 *
 * Pearson licenses this file to you under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
*/

using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.sifassociation.swa.flowcontrol;
using org.sifassociation.swa.datamodel;

namespace org.sifassociation.swa.servicehost
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**************************************************************");
            Console.WriteLine(" SIF 2.5 Web Application Server Test Harness");
            Console.WriteLine(" Version {0}", typeof(Program).Assembly.GetName().Version);
            Console.WriteLine(" Copyright © 2011 Pearson Education, Inc. or its affiliate(s). ");
            Console.WriteLine(" All rights reserved.");
            Console.WriteLine("**************************************************************");
            Console.WriteLine();

            Console.WriteLine(" Starting Services....");

            List<ServiceHost> hosts = new List<ServiceHost>();
            hosts.Add( new ServiceHost(typeof(ptFlowControl) ) );
            hosts.Add( new ServiceHost( typeof (ptDataModel) ) );

            try
            {
                startServices(hosts);

                Console.WriteLine("The services are ready");
                Console.WriteLine("Press <Enter> to stop the services.");
                Console.WriteLine();
                Console.ReadLine();
            }
            finally
            {
                stopServices(hosts);
            }

            Console.WriteLine("Press <Enter> to end.");
            Console.WriteLine();
            Console.ReadLine();
            

        }

        private static void stopServices(List<ServiceHost> hosts)
        {
            foreach (ServiceHost host in hosts)
            {
                try
                {
                    Console.WriteLine("Closing host: {0}", host.Description.Name);
                    host.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                Console.WriteLine();
            }
        }

        private static void startServices(List<ServiceHost> hosts)
        {
            foreach (ServiceHost host in hosts)
            {
                try
                {
                    host.Open();

                    ServiceDescription desc = host.Description;
                    Console.WriteLine("Started Service {0}", desc.Name);
                    Console.WriteLine(" -- Implemented by {0}", desc.ServiceType);
                    Console.WriteLine(" -- In Namespace {0}", desc.Namespace);
                    foreach (ServiceEndpoint endpoint in desc.Endpoints)
                    {
                        Console.WriteLine(" -- Hosted at endpoint: {0}", endpoint.Name);
                        Console.WriteLine(" -- at uri: {0}", endpoint.ListenUri);
                        Console.WriteLine(" -- using contract: {0}", endpoint.Contract.Name);
                        Console.WriteLine(" -- at address: {0}", endpoint.Address);
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
        }


        


    }
}
