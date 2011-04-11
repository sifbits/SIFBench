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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.sifassociation.swa.common;
using System.ServiceModel;
using System.Xml;
using System.ServiceModel.Channels;

namespace org.sifassociation.swa.datamodel
{
    public partial class ptDataModel
    {
        private EventStatus EventImplementation(PostEvent request)
        {
            runAssertions(request.SIFHeader);

            // Run event assertions
            if (!request.SIFHeader.EventActionSpecified)
            {
                throw new FaultException("No EventAction header specified");
            }
            if (String.IsNullOrEmpty(request.SIFHeader.TopicName))
            {
                throw new FaultException("No TopicName specified");
            }

            // Verify that the TopicName matches the XML Payload
            XmlElement eventObject = request.Event;
            if (! (eventObject.Name == request.SIFHeader.TopicName ))
            {
                throw new FaultException("Topic Name does not match name in event XML");
            }

            // Special case, throw an error for FoodServiceMilkSales
            {
                if (request.SIFHeader.TopicName == "FoodserviceMilkSales")
                {
                    DataModelErrorType sifError = new DataModelErrorType();
                    sifError.Category = InfrastructureErrorCategoryType.Item9;
                    sifError.Code = "3";
                    sifError.Desc = "Bogus objects are not allowed";
                    sifError.ExtendedDesc = "Please Notify Dave Guidos";
                    throw new FaultException<DataModelErrorType>(sifError, "Planned Exception to test SIF WS Transport");
                }
            }

            return genericOKResponse();
        }
        private EventStatus QueryImplementation(QueryRequest request)
        {
            runAssertions(request.SIFHeader);

            // Run Query assertions
            if (String.IsNullOrEmpty(request.SIFHeader.TopicName))
            {
                throw new FaultException("No TopicName specified");
            }

            // Verify that the TopicName matches the XML Payload
            QueryType q = request.Query;
            if (!(q.QueryObject.ObjectName == request.SIFHeader.TopicName))
            {
                throw new FaultException("Topic Name does not match name in query XML");
            }

            String[] responseVersion = request.SIFHeader.ResponseVersion;
            if (responseVersion == null || responseVersion.Length < 1)
            {
                throw new FaultException("No Response version specified");
            }

            if (!request.SIFHeader.MaxBufferSizeSpecified)
            {
                throw new FaultException("Max Buffer Size not specified");
            }

            // Special case, throw an error for FoodServiceMilkSales
            {
                if (request.SIFHeader.TopicName == "FoodserviceMilkSales")
                {
                    DataModelErrorType sifError = new DataModelErrorType();
                    sifError.Category = InfrastructureErrorCategoryType.Item8;
                    sifError.Code = "4";
                    sifError.Desc = "Bogus objects are not allowed";
                    sifError.ExtendedDesc = "Please Notify Dave Guidos";
                    throw new FaultException<DataModelErrorType>(sifError, "Planned Exception to test SIF WS Transport");
                }
            }

            return genericOKResponse();
        }
        private EventStatus ExtendedQueryImplementation(ExtendedQueryRequest request)
        {
            runAssertions(request.SIFHeader);
            return genericOKResponse();
        }
        private EventStatus QueryResultsImplementation(QueryResultsResponse request)
        {
            runAssertions(request.SIFHeader);
            return genericOKResponse();
        }
        private EventStatus ExtendedQueryResultsImplementation(ExtendedQueryResultsResponse request)
        {
            runAssertions(request.SIFHeader);
            return genericOKResponse();
        }
        private EventStatus CancelRequestsImplementation(CancelRequestsRequest request)
        {
            runAssertions(request.SIFHeader);
            return genericOKResponse();
        }
        private EventStatus DataModelErrorImplementation(ErrorNotify request)
        {
            runAssertions(request.SIFHeader);
            return genericOKResponse();
        }

        private SIFHeaderType createHeader()
        {
            SIFHeaderType header = new SIFHeaderType();
            header.ZoneId = "foo:bar";
            header.DataModel = Statics.XMLNS_SIF_US_DATAMODEL;
            header.DataModelVersion = Statics.VERSION_US_DATAMODEL;
            header.SourceId = this.GetType().FullName;
            header.Timestamp = DateTime.Now;
            header.InfrastructureVersion = Statics.VERSION_INFRASTRUCTURE;
            return header;
        }

        private EventStatus genericOKResponse()
        {
            SIFHeaderType header = createHeader();
            StatusType status = new StatusType();
            status.Code = InfrastructureStatusCodeType.Item0;
            status.Desc = "Success";
            EventStatus resp = new EventStatus(header, status);
            return resp;
        }


        private void runAssertions(SIFHeaderType header)
        {
            OperationContext context = OperationContext.Current;
            MessageHeaders headers = context.IncomingMessageHeaders;
            UniqueId contextMsgId = headers.MessageId;
            if (contextMsgId == null)
            {
                throw new FaultException("No WS-AddressingMsgId Specified");
            }
            Console.WriteLine("Received message with ID: {0}", contextMsgId);

            String action = headers.Action;
            if (action == null)
            {
                throw new FaultException("No WS-Addressing Action specified");
            }
            Console.WriteLine("   -Action: {0}", action);

            if (!action.StartsWith("http://www.sifassociation.org/contract/DataModel-S11/2.x/"))
            {
                throw new FaultException("Action does not start with 'http://www.sifassociation.org/contract/DataModel-S11/2.x/'");
            }

            if (String.IsNullOrEmpty( header.SourceId))
            {
                throw new FaultException("SourceId is null");
            }

            Console.WriteLine("   -SourceId: {0}", header.SourceId);

            if (header.InfrastructureVersion != "2.5")
            {
                throw new FaultException("Infrastructure Version is " + header.InfrastructureVersion + " instead of '2.5'");
            }

            Console.WriteLine("   -InfraVer: {0}", header.InfrastructureVersion);

            if (header.Timestamp == null)
            {
                throw new FaultException("Missing timestamp, or incorrect timestamp");
            }
            DateTime timestamp = header.Timestamp;
            TimeSpan diff = DateTime.Now - timestamp;
            if (diff.TotalDays > 30)
            {
                throw new FaultException("Timestamp: '" + timestamp + "' does not represent a recent date");
            }

            Console.WriteLine("   -Timestamp: {0}", header.Timestamp);
            if (String.IsNullOrEmpty( header.ZoneId ))
            {
                throw new FaultException("ZoneId is null");
            }
            Console.WriteLine("   -ZoneId: {0}", header.ZoneId);


            // Verify Data Model and Data Model Version
            if (!(header.DataModel == Statics.XMLNS_SIF_US_DATAMODEL))
            {
                throw new FaultException("Data Model does not match expected: " + header.DataModel);
            }

            if (!(header.DataModelVersion == Statics.VERSION_US_DATAMODEL))
            {
                throw new FaultException("Data Model Version incorrect:" + header.DataModelVersion);
            }


        }

    }
}
