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
using org.sifassociation.swa.datamodel;
using org.sifassociation.swa.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using System.ServiceModel;

namespace org.sifassociation.swa.testing
{
    /// <summary>
    /// Summary description for DataModelTest
    /// </summary>
    [TestClass]
    public class DataModelTest
    {
        public DataModelTest()
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
        public void TestEvent()
        {
            IptDataModel client = new IptDataModelClient();
            PostEvent pEvent = new PostEvent();

            SIFHeaderType header = createHeader();
            header.EventAction = SIFHeaderTypeEventAction.Add;
            header.EventActionSpecified = true;
            header.TopicName = "SchoolCourseInfo";


            pEvent.SIFHeader = header;
            pEvent.Event = createXML(
                @"<SchoolCourseInfo RefId='9D75101A8C3D00AA001A0000A2E35B35' SchoolInfoRefId='101A8C3D00AA001A0000A2E35B359D75' SchoolYear='2006'
                        xmlns='" + Statics.XMLNS_SIF_US_DATAMODEL + @"'>
                      <CourseCode>CS101</CourseCode>
                      <StateCourseCode>08-001</StateCourseCode>
                      <DistrictCourseCode>CS101</DistrictCourseCode>
                      <SubjectAreaList>
                        <SubjectArea>
                          <Code>05</Code>
                          <OtherCodeList>
                            <OtherCode Codeset='Text'>Graphic Arts</OtherCode>
                          </OtherCodeList>
                        </SubjectArea>
                      </SubjectAreaList>
                      <CourseTitle>Gif, JPeg, or Png: What's the Difference?</CourseTitle>
                      <Description>Explore the various types of files related to graphic arts.</Description>
                      <InstructionalLevel>
                        <Code>0571</Code>
                      </InstructionalLevel>
                      <CourseCredits Type='0585'>2</CourseCredits>
                      <CoreAcademicCourse>No</CoreAcademicCourse>
                      <GraduationRequirement>No</GraduationRequirement>
                </SchoolCourseInfo>");

            EventStatus evStatus = client.Event( pEvent );
            runAssertions(evStatus.SIFHeader);
            Assert.IsNotNull(evStatus.Status, "Status is null");
            StatusType status = evStatus.Status;
            Console.WriteLine("Invoked with return code " + status.Code);
            Assert.AreEqual(status.Code, InfrastructureStatusCodeType.Item0);
            Assert.AreEqual(status.Desc, "Success");

        }

        [TestMethod]
        public void TestEventWithError()
        {
            IptDataModel client = new IptDataModelClient();
            PostEvent pEvent = new PostEvent();

            SIFHeaderType header = createHeader();
            header.EventAction = SIFHeaderTypeEventAction.Add;
            header.EventActionSpecified = true;
            header.TopicName = "FoodserviceMilkSales";


            pEvent.SIFHeader = header;
            pEvent.Event = createXML(
                @"<FoodserviceMilkSales RefId='D21CF29B7FB44965A9CF950E1E60B21E'
                            xmlns='" + Statics.XMLNS_SIF_US_DATAMODEL + @"'>
                      <SchoolInfoRefId>AA66800BE0D84E80AA5838FA97EE3A3E</SchoolInfoRefId>
                      <Date>2001-10-31</Date>
                      <Program Type='Foodservice'>NSLP</Program>
                      <SaleQuantities>
                        <SaleQuantity>
                          <Value>99999</Value>
                          <MealStatus Type='Free' />
                          <SaleUnit>6 oz</SaleUnit>
                          <ChargeToChild Currency='USD'>999.99</ChargeToChild>
                        </SaleQuantity>
                        <SaleQuantity>
                          <Value>99999</Value>
                          <MealStatus Type='Reduced' />
                          <SaleUnit>6 oz</SaleUnit>
                          <ChargeToChild Currency='USD'>999.99</ChargeToChild>
                        </SaleQuantity>
                      </SaleQuantities>
                    </FoodserviceMilkSales>");

           
            bool exceptionThrown = false;
            try
            {
                EventStatus evStatus = client.Event(pEvent);
            }
            catch (FaultException<DataModelErrorType> ex)
            {
                exceptionThrown = true;
                Assert.AreEqual(ex.Detail.Category, InfrastructureErrorCategoryType.Item9, "Expected Category of 9");
                Assert.AreEqual(ex.Detail.Code, "3", "Expected Code of 3");

            }
            catch (Exception ex)
            {
                Assert.Fail("Unable to parse SOAP Fault into expected exception type : " + ex.ToString());
            }

            Assert.IsTrue(exceptionThrown, "A SOAP Fault was not returned");

        }



        [TestMethod]
        public void TestQuery()
        {
            IptDataModel client = new IptDataModelClient();
            QueryRequest qRequest = new QueryRequest();

            // Header
            SIFHeaderType header = createHeader();
            header.TopicName = "SchoolCourseInfo";
            header.MaxBufferSize = uint.MaxValue;
            header.MaxBufferSizeSpecified = true;
            header.ResponseVersion = new String[] { "1.1", "2.0r1", "2.1", "2.5", "2.*" };
            qRequest.SIFHeader = header;

            // Query
            QueryTypeQueryObject query = new QueryTypeQueryObject();
            query.ObjectName = "SchoolCourseInfo";
            QueryType type = new QueryType();
            type.QueryObject = query;


            qRequest.Query = type;

            EventStatus evStatus = client.Query(qRequest);
            runAssertions(evStatus.SIFHeader);
            Assert.IsNotNull(evStatus.Status, "Status is null");
            StatusType status = evStatus.Status;
            Console.WriteLine("Invoked with return code " + status.Code);

            Assert.AreEqual(status.Code, InfrastructureStatusCodeType.Item0);
            Assert.AreEqual(status.Desc, "Success");


        }

        [TestMethod]
        public void TestQueryWithError()
        {
            IptDataModel client = new IptDataModelClient();
            QueryRequest qRequest = new QueryRequest();

            // Header
            SIFHeaderType header = createHeader();
            header.TopicName = "FoodserviceMilkSales";
            header.MaxBufferSize = uint.MaxValue;
            header.MaxBufferSizeSpecified = true;
            header.ResponseVersion = new String[] { "1.1", "2.0r1", "2.1", "2.5", "2.*" };
            qRequest.SIFHeader = header;

            // Query
            QueryTypeQueryObject query = new QueryTypeQueryObject();
            query.ObjectName = "FoodserviceMilkSales";
            QueryType type = new QueryType();
            type.QueryObject = query;
            qRequest.Query = type;
           
            bool exceptionThrown = false;

            try
            {
                EventStatus evStatus = client.Query(qRequest);
            }
            catch (FaultException<DataModelErrorType> ex)
            {
                exceptionThrown = true;
                Assert.AreEqual(ex.Detail.Category, InfrastructureErrorCategoryType.Item8, "Expected Category of 8");
                Assert.AreEqual(ex.Detail.Code, "4", "Expected Code of 4");
            }
            catch (Exception ex)
            {
                Assert.Fail("Unable to parse SOAP Fault into expected exception type: " + ex.ToString());
            }

            Assert.IsTrue(exceptionThrown, "A SOAP Fault was not returned");

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

        private XmlElement createXML(String inputXML)
        {
            XmlDocument doc = new XmlDocument();
            doc.InnerXml = inputXML;
            return doc.DocumentElement;
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

            Assert.IsFalse(String.IsNullOrEmpty(header.SourceId), "SourceId is null");
            Assert.AreNotEqual(header.SourceId, generateSourceId(), "SourceID is not valid");
            Assert.AreEqual(header.InfrastructureVersion, "2.5");
            Assert.IsNotNull(header.Timestamp);
            DateTime timestamp = header.Timestamp;
            TimeSpan diff = DateTime.Now - timestamp;
            Assert.IsTrue(diff.TotalDays < 30, "Timestamp: '" + timestamp + "' does not represent a recent date");
            Assert.IsFalse(String.IsNullOrEmpty(header.ZoneId), "ZoneId is null");

        }

    }
}
