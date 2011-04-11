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
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using org.sifassociation.swa.flowcontrol;
using org.sifassociation.swa.common;
using System.ServiceModel;

namespace SIF25WSUnitTesting
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class FlowControlTests
    {
        public FlowControlTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestPing()
        {
            IptFlowControlClient client = new IptFlowControlClient();
            StatusType status = null;
            SIFHeaderType header = createHeader();
            //PingRequest  request = new PingRequest( header, new PingType() );
            status = client.Ping(ref header, new PingType());
            runAssertions(header);
            Console.WriteLine("Invoked with return code " + status.Code);

            Assert.AreEqual(status.Code, InfrastructureStatusCodeType.Item0);
            Assert.AreEqual(status.Desc, "Success");

        }

  
        [TestMethod]
        public void TestPingWithError()
        {
            IptFlowControlClient client = new IptFlowControlClient();
            StatusType status = null;
            SIFHeaderType header = createHeader();
            header.SourceId = "Olympus"; // Triggers an error in the server
            bool exceptionThrown = false;
            try
            {
                status = client.Ping(ref header, new PingType());
                
            }
            catch (FaultException<DataModelErrorType> ex)
            {
                exceptionThrown = true;
                Assert.AreEqual(ex.Detail.Category, InfrastructureErrorCategoryType.Item11, "Expected Category of 11");
                Assert.AreEqual(ex.Detail.Code, "1", "Expected Code of 1");
                
            }
            catch (Exception ex)
            {
                Assert.Fail("Unable to parse SOAP Fault into expected exception type: " + ex.ToString());
            }

            Assert.IsTrue(exceptionThrown, "A SOAP Fault was not returned");
        }

        [TestMethod]
        public void TestSleep()
        {
            IptFlowControlClient client = new IptFlowControlClient();
            StatusType status = null;
            SIFHeaderType header = createHeader();
            status = client.Sleep(ref header, new SleepType());
            runAssertions(header);
            Console.WriteLine("Invoked with return code " + status.Code);

            Assert.AreEqual(status.Code, InfrastructureStatusCodeType.Item0);
            Assert.AreEqual(status.Desc, "Success");

        }

        [TestMethod]
        public void TestWakeup()
        {
            IptFlowControlClient client = new IptFlowControlClient();
            StatusType status = null;
            SIFHeaderType header = createHeader();
            status = client.Wakeup(ref header, new WakeupType());
            runAssertions(header);
            Console.WriteLine("Invoked with return code " + status.Code);

            Assert.AreEqual(status.Code, InfrastructureStatusCodeType.Item0);
            Assert.AreEqual(status.Desc, "Success");

        }

        private SIFHeaderType createHeader()
        {
            SIFHeaderType header = new SIFHeaderType();
            header.ZoneId = "foo:bar";
            header.DataModel = Statics.XMLNS_SIF_US_DATAMODEL;
            header.DataModelVersion = Statics.VERSION_US_DATAMODEL;
            header.SourceId = generateSourceId();
            header.Timestamp = DateTime.Now;
            header.InfrastructureVersion = Statics.VERSION_INFRASTRUCTURE;
            return header;
        }

        private string generateSourceId()
        {
            return this.GetType().FullName;
        }
        
         private void runAssertions(SIFHeaderType header)
        {
             // TODO: Assert WS-Addressing headers

            //OperationContext context = OperationContext.Current;
            //MessageHeaders headers = context.IncomingMessageHeaders;
            //UniqueId contextMsgId = headers.MessageId;
            //if (contextMsgId == null)
            //{
            //    throw new FaultException("No WS-AddressingMsgId Specified");
            //}
            //Console.WriteLine("Received message with ID: {0}", contextMsgId);

            //String action = headers.Action;
            //if (action == null)
            //{
            //    throw new FaultException("No WS-Addressing Action specified");
            //}
            //Console.WriteLine("   -Action: {0}", action);

            //if (!action.StartsWith("http://www.sifassociation.org/contract/DataModel-S11/2.x/"))
            //{
            //    throw new FaultException("Action does not start with 'http://www.sifassociation.org/contract/DataModel-S11/2.x/'");
            //}

            Assert.IsNotNull(header, "SIFHeader was not returned");
            Assert.IsFalse(String.IsNullOrEmpty( header.SourceId), "SourceId is null" );
            Assert.AreNotEqual(header.SourceId, generateSourceId(), "SourceID is not valid");
            Assert.AreEqual( header.InfrastructureVersion, "2.5" );
            Assert.IsNotNull( header.Timestamp );
            DateTime timestamp = header.Timestamp;
            TimeSpan diff = DateTime.Now - timestamp;
            Assert.IsTrue(diff.TotalDays < 30, "Timestamp: '" + timestamp + "' does not represent a recent date");
            Assert.IsFalse( String.IsNullOrEmpty( header.ZoneId ), "ZoneId is null");
            
        }
    }
}
